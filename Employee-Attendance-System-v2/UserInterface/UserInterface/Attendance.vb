Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.VisualBasic
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Attendance
    Public DataTableAttendance As New DataTable
    Dim MongoDB As MongoDBConnection = New MongoDBConnection()
    Dim client As MongoClient = MongoDB.client
    Dim db As IMongoDatabase = MongoDB.db
    Dim collection As IMongoCollection(Of BsonDocument) = MongoDB.EmployeeCollection
    Dim AttendanceCollection As IMongoCollection(Of BsonDocument) = MongoDB.AttendanceCollection


    Dim xSub As New SampleCallEveryXMinute(3000) ' 1000 ms = 1 sec so 60000 ms = 1 min

    'Excel Configurations
    Dim excelLocation As String = "C:\Users\Sampogi\Desktop\vbnet\Employee-Attendance-System-v2\print_to_excel.xlsx"
    Dim pdfLocation As String = "C:\Users\Sampogi\Desktop\vbnet\Employee-Attendance-System-v2\"
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        xSub.StopTimer()

    End Sub

    Public Sub LoadDataInTable()
        'Excel Configs for load
        DataTableAttendance = New DataTable

        DataTableAttendance.Columns.Add("Name", GetType(String))
        DataTableAttendance.Columns.Add("Age", GetType(String))
        DataTableAttendance.Columns.Add("Email", GetType(String))
        DataTableAttendance.Columns.Add("Employee Number", GetType(String))
        DataTableAttendance.Columns.Add("Time In", GetType(String))

        Dim filter = Builders(Of BsonDocument).Filter.Empty
        For Each item As BsonDocument In AttendanceCollection.Find(filter).ToList
            Dim str As String
            Dim strArr As Array
            str = item.GetElement("name").ToString
            strArr = str.Split("=")
            Dim val1 = strArr(1)
            str = item.GetElement("age").ToString
            strArr = str.Split("=")
            Dim val2 = strArr(1)
            str = item.GetElement("phone_number").ToString
            strArr = str.Split("=")
            Dim val3 = strArr(1)
            str = item.GetElement("employee_number").ToString
            strArr = str.Split("=")
            Dim val4 = strArr(1)
            str = item.GetElement("date_string").ToString
            strArr = str.Split("=")
            Dim val5 = strArr(1)
            DataTableAttendance.Rows.Add(val1, val2, val3, val4, val5)
        Next

        'DataTableAttendance.Columns.Add("ID", GetType(String))
        'DataTableAttendance.Columns.Add("Name", GetType(String))
        'DataTableAttendance.Columns.Add("Age", GetType(String))
        'DataTableAttendance.Columns.Add("Employee Number", GetType(String))

        'Dim filter = Builders(Of BsonDocument).Filter.Empty
        'For Each item As BsonDocument In collection.Find(filter).ToList
        '    Dim str As String
        '    Dim strArr As Array
        '    str = item.GetElement("_id").ToString
        '    strArr = str.Split("=")
        '    Dim val1 = strArr(1)
        '    str = item.GetElement("name").ToString
        '    strArr = str.Split("=")
        '    Dim val2 = strArr(1)
        '    str = item.GetElement("age").ToString
        '    strArr = str.Split("=")
        '    Dim val3 = strArr(1)
        '    str = item.GetElement("employee_number").ToString
        '    strArr = str.Split("=")
        '    Dim val4 = strArr(1)
        '    DataTableAttendance.Rows.Add(val1, val2, val3, val4)
        'Next

        DGV2.DataSource = DataTableAttendance
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Close()

        LoadDataInTable()

        xSub.StartTimer()
    End Sub


    Private Sub AddNewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        RegisterEmployee.Show()
    End Sub

    Private Sub StartFaceRecognitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartFaceRecognitionToolStripMenuItem.Click
        Shell("CMD.exe /k activate base && cd C:\Users\Sampogi\Desktop\vbnet\Employee-Attendance-System-v2\Engine  && python p1_facerecog.py")
    End Sub

    Private Sub TrainFaceRecognitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrainFaceRecognitionToolStripMenuItem.Click
        Shell("CMD.exe /k activate base && cd C:\Users\Sampogi\Desktop\vbnet\Employee-Attendance-System-v2\Engine  && python data_preprocess.py && python train_main.py && exit")
    End Sub

    Private Sub AddNewAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAdminToolStripMenuItem.Click
        RegisterAdmin.Show()
    End Sub

    Private Sub EditEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEmployeesToolStripMenuItem.Click
        ManageEmployees.Show()
    End Sub

    Private Sub ManageAdminsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAdminsToolStripMenuItem.Click
        ManageAdmins.Show()
    End Sub


    Private Sub PrintToPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToPDFToolStripMenuItem.Click
        'Creating iTextSharp Table from the DataTable data
        'My.Computer.FileSystem.DeleteFile(pdfLocation & "print_to_pdf.pdf")

        Dim pdfTable As New PdfPTable(DGV2.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In DGV2.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In DGV2.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        'Exporting to PDF


        Using stream As New FileStream(pdfLocation & "print_to_pdf.pdf", FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using

        MsgBox("Attendance successfully printed in pdf")
    End Sub
End Class

Public Class SampleCallEveryXMinute
    Private WithEvents xTimer As New System.Windows.Forms.Timer
    Public count As Int32 = 0
    Public Sub New(TickValue As Integer)
        xTimer = New System.Windows.Forms.Timer
        xTimer.Interval = TickValue
    End Sub

    Public Sub StartTimer()
        xTimer.Start()
    End Sub

    Public Sub StopTimer()
        xTimer.Stop()
    End Sub

    Private Sub Timer_Tick() Handles xTimer.Tick
        SampleProcedure()
    End Sub

    Private Sub SampleProcedure()
        If Attendance.DGV2.Rows.Count > 0 Then
            Attendance.DataTableAttendance.Rows.Clear
        End If
        Attendance.LoadDataInTable()
    End Sub
End Class

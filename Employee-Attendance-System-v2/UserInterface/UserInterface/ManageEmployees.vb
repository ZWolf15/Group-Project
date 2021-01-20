Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ManageEmployees
    Public DataTableAttendance As New DataTable
    Dim MongoDB As MongoDBConnection = New MongoDBConnection()
    Dim client As MongoClient = MongoDB.client
    Dim db As IMongoDatabase = MongoDB.db
    Dim EmployeeCollection As IMongoCollection(Of BsonDocument) = MongoDB.EmployeeCollection
    Dim AttendanceCollection As IMongoCollection(Of BsonDocument) = MongoDB.AttendanceCollection
    Private Sub DGVEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmployees.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVEmployees.Rows(e.RowIndex)
            tb_name.Text = row.Cells(0).Value.ToString
            tb_age.Text = row.Cells(1).Value.ToString
            tb_phone_no.Text = row.Cells(2).Value.ToString
            tb_employee_no.Text = row.Cells(3).Value.ToString
        End If
    End Sub

    Public Sub LoadDataInTable()
        Dim attendance_filter = Builders(Of BsonDocument).Sort.Descending("date")

        Dim filter = Builders(Of BsonDocument).Filter.Empty
        For Each item As BsonDocument In EmployeeCollection.Find(filter).ToList
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
            DataTableAttendance.Rows.Add(val1, val2, val3, val4)
        Next

        DGVEmployees.DataSource = DataTableAttendance

        tb_name.Text = ""
        tb_age.Text = ""
        tb_phone_no.Text = ""
        tb_employee_no.Text = ""
    End Sub

    Private Sub ManageEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTableAttendance.Columns.Add("Name", GetType(String))
        DataTableAttendance.Columns.Add("Age", GetType(String))
        DataTableAttendance.Columns.Add("Email", GetType(String))
        DataTableAttendance.Columns.Add("Employee Number", GetType(String))

        LoadDataInTable()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim DialogBox As DialogResult = MessageBox.Show("Are you sure you want to UPDATE employee", "Update Employee", MessageBoxButtons.OKCancel)
        If (DialogBox = DialogResult.OK) Then
            Dim q = Builders(Of BsonDocument).Filter.Eq(Of String)("name", tb_name.Text)
            EmployeeCollection.UpdateMany(q, New BsonDocument("$set", New BsonDocument("age", tb_age.Text).Add("phone_number", tb_phone_no.Text).Add("employee_number", tb_employee_no.Text)))
            If DGVEmployees.Rows.Count > 0 Then
                DataTableAttendance.Rows.Clear()
            End If
            LoadDataInTable()
        ElseIf (DialogBox = DialogResult.Cancel) Then

        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim DialogBox As DialogResult = MessageBox.Show("Are you sure you want to DELETE employee", "Delete Employee", MessageBoxButtons.OKCancel)
        If (DialogBox = DialogResult.OK) Then
            Dim q = Builders(Of BsonDocument).Filter.Eq(Of String)("name", tb_name.Text)
            EmployeeCollection.DeleteOne(q)
            If DGVEmployees.Rows.Count > 0 Then
                DataTableAttendance.Rows.Clear()
            End If
            LoadDataInTable()
        ElseIf (DialogBox = DialogResult.Cancel) Then

        End If

    End Sub
End Class
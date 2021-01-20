Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ManageAdmins
    Public DataTableAttendance As New DataTable
    Dim MongoDB As MongoDBConnection = New MongoDBConnection()
    Dim client As MongoClient = MongoDB.client
    Dim db As IMongoDatabase = MongoDB.db
    Dim EmployeeCollection As IMongoCollection(Of BsonDocument) = MongoDB.EmployeeCollection
    Dim AttendanceCollection As IMongoCollection(Of BsonDocument) = MongoDB.AttendanceCollection
    Dim UserCollection As IMongoCollection(Of BsonDocument) = MongoDB.UserCollection
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim DialogBox As DialogResult = MessageBox.Show("Are you sure you want to DELETE admin", "Delete Admin", MessageBoxButtons.OKCancel)
        If (DialogBox = DialogResult.OK) Then
            Dim q = Builders(Of BsonDocument).Filter.Eq(Of String)("username", tb_username.Text)
            UserCollection.DeleteOne(q)
            If DGVAdmins.Rows.Count > 0 Then
                DataTableAttendance.Rows.Clear()
            End If
            LoadDataInTable()
        ElseIf (DialogBox = DialogResult.Cancel) Then

        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim DialogBox As DialogResult = MessageBox.Show("Are you sure you want to UPDATE admin", "Update Admin", MessageBoxButtons.OKCancel)
        Dim passwordChecker = ""
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", tb_username.Text)
        For Each item As BsonDocument In UserCollection.Find(filter).ToList
            Dim str As String
            Dim strArr As Array
            str = item.GetElement("password").ToString
            strArr = str.Split("=")
            passwordChecker = strArr(1)
        Next

        If passwordChecker = tb_password.Text Then
            If (DialogBox = DialogResult.OK) Then
                Dim q = Builders(Of BsonDocument).Filter.Eq(Of String)("username", tb_username.Text)
                EmployeeCollection.UpdateOne(q, New BsonDocument("$set", New BsonDocument("password", tb_new_password.Text)))
                If DGVAdmins.Rows.Count > 0 Then
                    DataTableAttendance.Rows.Clear()
                End If
                LoadDataInTable()
                MsgBox("Password change successfully")
            ElseIf (DialogBox = DialogResult.Cancel) Then

            End If
        Else
            MsgBox("The old password you entered is wrong")
        End If


    End Sub

    Public Sub LoadDataInTable()

        Dim filter = Builders(Of BsonDocument).Filter.Empty
        For Each item As BsonDocument In UserCollection.Find(filter).ToList
            Dim str As String
            Dim strArr As Array
            str = item.GetElement("username").ToString
            strArr = str.Split("=")
            Dim val1 = strArr(1)
            DataTableAttendance.Rows.Add(val1)
        Next

        DGVAdmins.DataSource = DataTableAttendance

        tb_username.Text = ""
        tb_password.Text = ""
        tb_new_password.Text = ""
    End Sub

    Private Sub DGVEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAdmins.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVAdmins.Rows(e.RowIndex)
            tb_username.Text = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub ManageAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTableAttendance.Columns.Add("Username", GetType(String))

        LoadDataInTable()
    End Sub
End Class
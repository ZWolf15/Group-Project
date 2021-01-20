Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class RegisterEmployee
    ' Initializa Database
    Private MongoDB As MongoDBConnection = New MongoDBConnection
    Private client As IMongoClient = MongoDB.client
    Private db As IMongoDatabase = MongoDB.db
    Private EmployeeColletion = MongoDB.EmployeeCollection

    'Variables
    Private name As String
    Private age As Int32
    Private phone_number As String
    Private emp_number As String
    Private is_face_registered As Boolean = False

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        name = tb_name.Text
        Dim strAge = tb_age.Text
        phone_number = tb_phone_number.Text
        emp_number = tb_employee_number.Text

        If (name = "" Or strAge = "" Or phone_number = "" Or emp_number = "") Then
            MsgBox("All Field is Required")
        ElseIf (is_face_registered = False) Then
            MsgBox("You must Register your face")
        Else
            age = CInt(strAge)
            Dim NewEmployee As BsonDocument = New BsonDocument
            With NewEmployee
                .Add("name", name)
                .Add("age", age)
                .Add("phone_number", phone_number)
                .Add("employee_number", emp_number)
            End With
            EmployeeColletion.InsertOne(NewEmployee)
            Dim DialogBox As DialogResult = MessageBox.Show("Employee Registered Successfully", "Success", MessageBoxButtons.OK)
            If (DialogBox = DialogResult.OK) Then
                Me.Close()
            End If
        End If




    End Sub

    Private Sub btn_register_face_Click(sender As Object, e As EventArgs) Handles btn_register_face.Click
        is_face_registered = True

        Shell("CMD.exe /k activate base && cd C:\Users\Sampogi\Desktop\vbnet\Employee-Attendance-System-v2\Engine  && python take_picture.py")
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class
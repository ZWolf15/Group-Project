Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class RegisterAdmin

    'Database Configurations
    Private MongoDB As MongoDBConnection = New MongoDBConnection
    Private client As MongoClient = MongoDB.client
    Private db As IMongoDatabase = MongoDB.db
    Private UserCollection As IMongoCollection(Of BsonDocument) = MongoDB.UserCollection

    'Encrypting Password Configurations
    Private Configs As Configs = New Configs
    Private PasswordConfig As PasswordConfig = New PasswordConfig(Configs.PasswordKey)

    Private username As String
    Private password As String
    Private password2 As String
    Private passwordEncrypted As String
    Dim NewAdmin As BsonDocument = New BsonDocument

    Private Sub btn_register_admin_Click(sender As Object, e As EventArgs) Handles btn_register_admin.Click
        username = tb_username.Text
        password = tb_password.Text
        password2 = tb_password2.Text

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", username)
        Dim count = UserCollection.Find(filter).ToList.Count

        'Check if passwords were equal
        If (password = password2) Then
            If (count = 0) Then
                passwordEncrypted = PasswordConfig.EncryptData(password)
                NewAdmin.Add("username", username)
                NewAdmin.Add("password", password)
                UserCollection.InsertOne(NewAdmin)
                tb_username.Text = ""
                tb_password.Text = ""
                tb_password2.Text = ""
                Dim DialogBox As DialogResult = MessageBox.Show("Admin Registered Successfully", "Success", MessageBoxButtons.OK)
                If (DialogBox = DialogResult.OK) Then
                    Me.Close()
                End If
            Else
                MsgBox("Username " & username & " is already registered in database. Choose another username")
            End If
        Else
            MsgBox("Password should be equal")
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tb_username.Text = ""
        tb_password.Text = ""
        tb_password2.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tb_username_TextChanged(sender As Object, e As EventArgs) Handles tb_username.TextChanged

    End Sub
End Class
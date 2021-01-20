Imports System.Security.Cryptography
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Login
    Private username As String
    Private password As String
    Private decryptedPassword As String
    Dim strArr As Array
    Dim str As String

    Private MongoDB As MongoDBConnection = New MongoDBConnection
    Private client As IMongoClient = MongoDB.client
    Private db As IMongoDatabase = MongoDB.db
    Private UserCollection As IMongoCollection(Of BsonDocument) = MongoDB.UserCollection

    Private Configs As Configs = New Configs
    Private PasswordConfig As PasswordConfig = New PasswordConfig(Configs.PasswordKey)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = tb_username.Text
        password = tb_password.Text
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", username)
        'Dim UserFound = UserCollection.Find(filter).ToList
        'MsgBox(UserFound.ToString)
        'Dim strArr As Array = UserFound.GetElement("password").ToString.Split("=")
        'Dim str = strArr(1)
        If (UserCollection.Find(filter).ToList.Count = 0) Then
            MsgBox("Credentials are incorrect")
        Else
            For Each item As BsonDocument In UserCollection.Find(filter).ToList
                str = item.GetElement("password").ToString
                strArr = str.Split("=")
                str = strArr(1).ToString
            Next
            If (password = str) Then
                Attendance.Show()
                Me.Hide()
            Else
                MsgBox("Credentials are incorrect")
            End If
        End If
        'Try
        '    decryptedPassword = PasswordConfig.DecryptData(decryptedPassword)
        '    Attendance.Show()
        '    Me.Hide()
        'Catch ex As System.Security.Cryptography.CryptographicException
        '    MsgBox("Password is incorrect" & decryptedPassword)
        'End Try

    End Sub

End Class
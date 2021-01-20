Imports Microsoft.VisualBasic
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class MongoDBConnection

    Public client As MongoClient = New MongoClient("mongodb://localhost/")
    Public db As IMongoDatabase = client.GetDatabase("db")
    Public EmployeeCollection As IMongoCollection(Of BsonDocument) = db.GetCollection(Of BsonDocument)("employees")
    Public UserCollection As IMongoCollection(Of BsonDocument) = db.GetCollection(Of BsonDocument)("users")
    Public AttendanceCollection As IMongoCollection(Of BsonDocument) = db.GetCollection(Of BsonDocument)("attendances")

End Class

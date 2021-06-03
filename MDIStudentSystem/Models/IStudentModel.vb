Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public interface IStudentModel
        Property Id As Integer
        Property FstName As String
        Property LstName As String
        Property EmailAddress As String
        Property CityName As String
        Property Birthdate() As Date
        Property AvatarPic As Byte()
        Property ValidateString As String

    end interface
End NameSpace
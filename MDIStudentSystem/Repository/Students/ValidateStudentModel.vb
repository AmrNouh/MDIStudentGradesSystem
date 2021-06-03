Imports System.Text
Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.CommonRepository

Namespace Repository.Students
    Public Class ValidateStudentModel


        Public ErrorMessage As New StringBuilder

        Public Function IsValid(studentModel As IStudentModel) As Boolean

            If String.IsNullOrWhiteSpace(studentModel.FstName) Then
                ErrorMessage.Append("You Forget To enter Your FirstName")
                ErrorMessage.AppendLine()
                Return False
                ElseIf studentModel.FstName.Contains("1")
            End If
            If String.IsNullOrWhiteSpace(studentModel.LstName) Then
                ErrorMessage.Append("You Forget To enter Your LastName")
                ErrorMessage.AppendLine()
                Return False
            End If
            If String.IsNullOrWhiteSpace(studentModel.EmailAddress) Then
                ErrorMessage.Append("You Forget To enter Your Email")
                ErrorMessage.AppendLine()
                Return False
            End If
            If String.IsNullOrWhiteSpace(studentModel.CityName) Then
                ErrorMessage.Append("You Forget To enter Your City Name")
                ErrorMessage.AppendLine()
                Return False
            End If
            If String.IsNullOrWhiteSpace(studentModel.ValidateString) OrElse studentModel.ValidateString = DateTime.MinValue.ToString()Then
                ErrorMessage.Append("You Forget To enter Your Birthdate")
                ErrorMessage.AppendLine()
                Return False
            End If
            If StudentModel.AvatarPic Is Nothing Then
                ErrorMessage.Append("You Forget To enter Your Picture")
                ErrorMessage.AppendLine()
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace
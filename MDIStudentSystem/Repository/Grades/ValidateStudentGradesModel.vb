Imports System.Text
Imports MDIStudentSystem.Models

Namespace Repository.Grades
    Public Class ValidateStudentGradesModel

        Public ErrorMessage As New StringBuilder
        Public Function IsValid(gradesModel As GradesModel) As Boolean

            If String.IsNullOrWhiteSpace(CType(gradesModel.StudentId, String)) Then
                ErrorMessage.Append("You Forget To enter Your Student ID")
                ErrorMessage.AppendLine()
            End If
            If String.IsNullOrWhiteSpace(gradesModel.SubjectName) OrElse gradesModel.SubjectName.ToLower() = "Select Subject Name".ToLower() Then
                ErrorMessage.Append("You Forget To enter Your Subject Name")
                ErrorMessage.AppendLine()

            End If
            If String.IsNullOrWhiteSpace(CType(gradesModel.SubjectGrade, String)) Then
                ErrorMessage.Append("You Forget To enter Total Subject Grade")
                ErrorMessage.AppendLine()

            End If
            If String.IsNullOrWhiteSpace(CType(gradesModel.StudentGrade, String)) Then
                ErrorMessage.Append("You Forget To enter Student Subject Grade")
                ErrorMessage.AppendLine()

            End If
            'If String.IsNullOrWhiteSpace(CType(gradesModel.Percent, String)) Then
            '    ErrorMessage.Append("You Forget To Calculate Percent")
            '    ErrorMessage.AppendLine()

            'End If

            Return True
        End Function
    End Class
End Namespace
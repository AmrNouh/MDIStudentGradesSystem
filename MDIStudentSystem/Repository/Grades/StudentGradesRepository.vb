Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.CommonRepository

Namespace Repository.Grades

    Public Class StudentGradesRepository
        Implements IStudentGradesRepository

        Private ReadOnly _sql As New SqlFramework

        Public Sub Update(gradesModel As GradesModel) Implements IStudentGradesRepository.Update
            Throw New NotImplementedException()
        End Sub

        Public Sub Delete(gradesModel As GradesModel) Implements IStudentGradesRepository.Delete
            Throw New NotImplementedException()
        End Sub

        Public Function IsRecordFound(gradesModel As GradesModel) As Boolean Implements IStudentGradesRepository.IsRecordFound

            Dim strCmd = "Select * From StudentGrades where StudentID= @StudentID AND SubjectName= @SubjectName"
            _sql.AddParameters("@StudentID", gradesModel.StudentId)
            _sql.AddParameters("@SubjectName", gradesModel.SubjectName)
            _sql.RunQueryV2(strCmd)

            If _sql.RecordCount > 0 Then
                Return True
            End If

            Return False
        End Function
        Public Function Insert(gradesModel As GradesModel) As Boolean Implements IStudentGradesRepository.Insert

            Dim strCmd = "INSERT INTO StudentGrades (StudentID, SubjectName, StudentGrade, SubjectGradePercent, SubjectGrade) VALUES (@StudentID,@SubjectName,@StudentGrade,@SubjectGradePercent,@SubjectGrade)"
            _sql.AddParameters("@StudentID", gradesModel.StudentId)
            _sql.AddParameters("@SubjectName", gradesModel.SubjectName)
            _sql.AddParameters("@StudentGrade", gradesModel.StudentGrade)
            _sql.AddParameters("@SubjectGradePercent", gradesModel.Percent)
            _sql.AddParameters("@SubjectGrade", gradesModel.SubjectGrade)
            _sql.RunQuery(strCmd)

            If Not String.IsNullOrWhiteSpace(_sql.Exception) Then
                MsgBox("There is an Error Please Try Again", MsgBoxStyle.OkOnly, "Data Insertion Error")
                Return False
            End If

            Return True
        End Function

        Public Function Search(studentId As Integer) As DataTable Implements IStudentGradesRepository.Search
            Dim strCmd = "SELECT SubjectName, SubjectGrade, StudentGrade, SubjectGradePercent FROM StudentGrades where StudentID = @StudentID;"
            _sql.AddParameters("@StudentID", studentId)
            Return _sql.RunQueryV2(strCmd)
        End Function

    End Class
End Namespace
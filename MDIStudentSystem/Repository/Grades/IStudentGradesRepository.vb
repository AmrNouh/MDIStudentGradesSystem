Imports MDIStudentSystem.Models

Namespace Repository.Grades
    Public Interface IStudentGradesRepository
        Function Insert(gradesModel As GradesModel) As Boolean
        Sub Update(gradesModel As GradesModel)
        Sub Delete(gradesModel As GradesModel)
        Function Search(studentId As Integer) As DataTable
        Function IsRecordFound(gradesModel As GradesModel) As Boolean
    End Interface
End Namespace
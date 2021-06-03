Imports MDIStudentSystem.Models

Namespace Repository.Students
    Public Interface IStudentRepository
        Function Insert(studentModel As IStudentModel) As Boolean
        Sub Update(studentModel As IStudentModel)
        Sub Delete(studentModel As IStudentModel)
        Function Search(searchText As String) As DataTable
        Function IsRecordFoundById(studentModel As IStudentModel) As Boolean
        Function IsRecordFoundByEmail(studentModel As IStudentModel) As Boolean

        Function UploadImage(path As String, email As String, Optional name As String = Nothing) As Byte()
    End Interface
End Namespace

Imports System.IO
Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.CommonRepository

Namespace Repository.Students
    Public Class StudentRepository
        Implements IStudentRepository

        Private ReadOnly _validate As New ValidateStudentModel
        Private Const ConnString As String = "Data Source=.;Initial Catalog=Students;Integrated Security=True"
        Private _sql As New SqlFramework(ConnString)




        Public Sub Update(studentModel As IStudentModel) Implements IStudentRepository.Update
            Dim strCmd = "UPDATE StudentsData SET FirstName = @FirstName ,LastName = @LastName , Email = @Email , Birthdate = @Birthdate , City = @City  WHERE StudentID= @StudentID "

            _sql.AddParameters("@FirstName", studentModel.FstName)
            _sql.AddParameters("@LastName", studentModel.LstName)
            _sql.AddParameters("@Email", studentModel.EmailAddress)
            _sql.AddParameters("@Birthdate", studentModel.Birthdate)
            _sql.AddParameters("@City", studentModel.CityName)
            '_sql.AddParameters("@Image", StudentModel.AvatarPic)
            _sql.AddParameters("@StudentID", studentModel.Id)

            _sql.RunQueryV2(strCmd)


        End Sub

        Public Sub Delete(studentModel As IStudentModel) Implements IStudentRepository.Delete
            Dim strCmd = "DELETE FROM StudentsData WHERE StudentID= @StudentID;"
            _sql.AddParameters("@StudentID", studentModel.Id)
            _sql.RunQueryV2(strCmd)

        End Sub

        Public Function Search(searchText As String) As DataTable Implements IStudentRepository.Search

            Dim sqlString = String.Format("select StudentID, FirstName, LastName, Email, Birthdate, [Image],City from StudentsData where FirstName Like '%{0}%' OR LastName Like '%{0}%';", searchText)

            '_sql.AddParameters("@FirstName", searchText)
            '_sql.AddParameters("@LastName", searchText)


            If _sql.HasException(True) Then Return Nothing

            Return _sql.RunQueryV2(sqlString)
        End Function


        Public Function IsRecordFoundById(studentModel As IStudentModel) As Boolean Implements IStudentRepository.IsRecordFoundById

            Dim strCmd = "SELECT StudentID, FirstName, LastName, Email, Birthdate, City, [Image] FROM StudentsData where StudentID= @StudentID;"

            _sql.AddParameters("@StudentID", studentModel.Id)

            _sql.RunQueryV2(strCmd)

            If _sql.RecordCount > 0 Then
                Return True
            End If

            Return False
        End Function

        Public Function IsRecordFoundByEmail(studentModel As IStudentModel) As Boolean Implements IStudentRepository.IsRecordFoundByEmail

            Dim strCmd = "SELECT 1 FROM StudentsData where Email= @Email;"

            _sql.AddParameters("@Email", studentModel.EmailAddress)

            _sql.RunQueryV2(strCmd)

            If _sql.RecordCount > 0 Then
                Return True
            End If

            Return False
        End Function

        Public Function UploadImage(path As String, email As String, Optional name As String = Nothing) As Byte() Implements IStudentRepository.UploadImage

            If String.IsNullOrWhiteSpace(path) Then Return Nothing

            Dim img As Image = Image.FromFile(path)
            Dim ms As New MemoryStream
            img.Save(ms, img.RawFormat)
            Return ms.GetBuffer()

        End Function

        Public Function Insert(studentModel As IStudentModel) As Boolean Implements IStudentRepository.Insert

            Dim insertCmd As String = "INSERT INTO StudentsData (FirstName, LastName, Email, Birthdate, City,Image) VALUES (@FirstName, @LastName, @Email, @Birthdate, @City,@AvatarPic) ;"

            _sql.AddParameters("@FirstName", studentModel.FstName)

            _sql.AddParameters("@Email", studentModel.EmailAddress)
            _sql.AddParameters("@Birthdate", studentModel.Birthdate)
            _sql.AddParameters("@City", studentModel.CityName)
            _sql.AddParameters("@AvatarPic", StudentModel.AvatarPic)

            _sql.RunQueryV2(insertCmd)

            If Not String.IsNullOrWhiteSpace(_sql.Exception) Then
                MsgBox(_sql.Exception, MsgBoxStyle.OkOnly, "Data Insertion Error")
                Return False
            End If

            Return True
        End Function


        Public Function FetchImage(id As Integer) As Byte()
            Dim strCmd = $"SELECT [Image] FROM StudentsData where StudentID = {id}"
            _sql.RunQuery(strCmd)

            If Not String.IsNullOrWhiteSpace(_sql.Exception) OrElse _sql.RecordCount < 1 Then
                Return Nothing
            End If

            Dim buffer As Byte() = CType(_sql.Dbds.Tables(0).Rows(0)("Image"), Byte())
            Return buffer
        End Function

        Public Sub DrawingImage(picBox As CircularPictureBox, id As Integer)
            Dim buffer As Byte() = FetchImage(id)

            If buffer IsNot Nothing Then
                Using Ms As New MemoryStream(buffer, 0, buffer.Length)
                    Ms.Write(buffer, 0, buffer.Length)
                    'picBox.Image = Image.FromStream(Ms, True)
                End Using
            End If

        End Sub
    End Class
End Namespace

Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.CommonRepository
Imports MDIStudentSystem.Repository.Students

Namespace UI
    Public Class XFrmSearchStudent

        Private ReadOnly _sql As New SqlFramework
        Private ReadOnly _studentRepo As New StudentRepository
        Private ReadOnly _studentModel As New StudentModel



        Private Sub SearchControlText_TextChanged(sender As Object, e As EventArgs) Handles SearchControlText.TextChanged
            If String.IsNullOrWhiteSpace(SearchControlText.Text) Then
                DataGridStudentsView.Visible = False
            Else
                DataGridStudentsView.Visible = True
            End If
            DataGridStudentsView.DataSource = _studentRepo.Search(SearchControlText.Text)
        End Sub

        Private Sub TileViewStudentCards_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles TileViewStudentCards.ContextButtonClick



            'TileViewStudentCards.GetFocusedRow()
            'TileViewStudentCards.GetRow(TileViewStudentCards.FocusedRowHandle())
            'Dim ID As Integer = TileViewStudentCards.GetFocusedRowCellValue("StudentID")
            '_studentModel.Id = CType(TileViewStudentCards.GetFocusedRowCellValue("StudentID"), Integer)

            

            Dim studentData As New XFrmStudentData With {.MdiParent = MdiParent}
            DisplayValues(studentData)
            studentData.Show()
        End Sub

        Private Sub DisplayValues(xFrmStudentData As XFrmStudentData)

            Dim id = CType(TileViewStudentCards.GetFocusedRowCellValue("StudentID"), Integer)
            xFrmStudentData.lblShowID.Text = id.ToString()
            xFrmStudentData.TxtFirstName.Text = CType(TileViewStudentCards.GetFocusedRowCellValue("FirstName"), String)
            xFrmStudentData.TxtLastName.Text = CType(TileViewStudentCards.GetFocusedRowCellValue("LastName"), String)
            xFrmStudentData.TxtEmail.Text = CType(TileViewStudentCards.GetFocusedRowCellValue("Email"), String)
            xFrmStudentData.TxtCity.Text = CType(TileViewStudentCards.GetDataRow(TileViewStudentCards.FocusedRowHandle).Item("City"), String)
            xFrmStudentData.TxtBirthdate.Text = CType(TileViewStudentCards.GetFocusedRowCellValue("Birthdate"), String)

            Dim pictureData As Byte() = _studentRepo.FetchImage(id)
            Dim picture As Image = Nothing
            
            If pictureData Is Nothing Then Return : Exit Sub

            Using stream As New IO.MemoryStream(pictureData)

                picture = System.Drawing.Image.FromStream(stream)
            End Using

            xFrmStudentData.Avatar.Image = picture
        End Sub


    End Class
End Namespace
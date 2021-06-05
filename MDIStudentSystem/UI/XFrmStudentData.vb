
Imports DevExpress.XtraEditors
Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.Grades
Imports MDIStudentSystem.Repository.Students

Namespace UI
    Public Class XFrmStudentData

        Private ReadOnly _studentRepo As New StudentRepository
        Private ReadOnly _gradesRepo As New StudentGradesRepository
        Private ReadOnly _studentModel As New StudentModel
        Private ReadOnly _validate As New ValidateStudentModel

        Private Sub XFrmStudentData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            XOFBrowseImage.InitialDirectory = Application.StartupPath
            ''Drawing add Fetch the Image
            '_studentRepo.DrawingImage(Avatar, CType(lblShowID.Text, Integer))
        End Sub

        Sub save()

        End Sub

        Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            EnableFields()
            btnDelete.Visible = False
            btnShowGrades.Visible = False
            btnEdit.Visible = False
            'Me.AddControl(DrawButtons())

            'Show Buttons
            btnSave.Visible = True
            btnCancel.Visible = True
        End Sub

        Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click, Avatar.Click
            XOFBrowseImage.ShowDialog()
        End Sub

        Private Sub XOFBrowseImage_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XOFBrowseImage.FileOk
            Avatar.Image = Image.FromFile(XOFBrowseImage.FileName)
        End Sub

        Private Sub EnableFields()
            Avatar.Enabled = True
            btnBrowsePic.Enabled = True
            TxtFirstName.Enabled = True
            TxtLastName.Enabled = True
            TxtEmail.Enabled = True
            TxtCity.Enabled = True
            TxtBirthdate.Enabled = True
        End Sub

        Private Sub DisableFields()
            Avatar.Enabled = False
            btnBrowsePic.Enabled = False
            TxtFirstName.Enabled = False
            TxtLastName.Enabled = False
            TxtEmail.Enabled = False
            TxtCity.Enabled = False
            TxtBirthdate.Enabled = False
        End Sub

        Private Sub ResetFields()
            TxtFirstName.Text = Nothing
            TxtLastName.Text = Nothing
            TxtEmail.Text = Nothing
            TxtCity.Text = Nothing
            TxtBirthdate.Text = Nothing
        End Sub

        Private Function DrawButtons() As SimpleButton

            Dim btnSave = New DevExpress.XtraEditors.SimpleButton() With {
                    .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom,
                    .Name = "btnSave",
                    .Font = New Font("Dexef", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
                    .BackColor = Color.Transparent,
                    .ForeColor = Color.Black,
                    .Location = New Point(393, 599),
                    .MaximumSize = New Size(200, 43),
                    .MinimumSize = New Size(200, 43),
                    .Size = New Size(200, 43),
                    .Text = "Save"
                    }

            Return btnSave
        End Function

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

            'Load Data
            _studentModel.Id = CType(lblShowID.Text, Integer)
            _studentModel.FstName = TxtFirstName.Text
            _studentModel.LstName = TxtLastName.Text
            _studentModel.EmailAddress = TxtEmail.Text
            _studentModel.CityName = TxtCity.Text
            _studentModel.Birthdate = CType(TxtBirthdate.Text, Date)

            If Not String.IsNullOrWhiteSpace(XOFBrowseImage.FileName) Then
                _studentRepo.UploadImage(XOFBrowseImage.FileName, _studentModel.EmailAddress)
            End If

            If MsgBox($"Are You Sure You Want to Edit {TxtFirstName.Text} Info", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then

                'Validate Fields
                If _validate.IsValid(_studentModel) OrElse _validate.ErrorMessage.Length > 0 Then

                    _validate.ErrorMessage.Clear()

                    'Check If Student Exists
                    If _studentRepo.IsRecordFoundById(_studentModel) Then

                        'Update Record
                        _studentRepo.Update(_studentModel)
                        MsgBox("Information Updated Successfully", MsgBoxStyle.OkOnly, "Success")
                        DisableFields()

                        'show
                        btnDelete.Visible = True
                        btnShowGrades.Visible = True
                        btnEdit.Visible = True

                        'Hide 
                        btnSave.Visible = False
                        btnCancel.Visible = False

                    Else
                        MsgBox("This Record does Not Exist", MsgBoxStyle.OkOnly, "Not Found")
                    End If
                Else
                    MsgBox(_validate.ErrorMessage.ToString(), MsgBoxStyle.OkCancel, "Error")
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DisableFields()

            btnDelete.Visible = True
            btnShowGrades.Visible = True
            btnEdit.Visible = True
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            _studentModel.Id = CType(lblShowID.Text, Integer)
            If _studentRepo.IsRecordFoundById(_studentModel) Then
                If MsgBox("Do You Want to Delete This Student ", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    _studentRepo.Delete(_studentModel)
                    MsgBox("Student Deleted Successfully", MsgBoxStyle.OkOnly, "Success")
                    Me.Dispose()
                Else
                    Exit Sub
                End If
            Else
                MsgBox("Student Does Not Exist", MsgBoxStyle.OkOnly, "Not Founded")
                Exit Sub
            End If
        End Sub

        Private Sub btnShowGrades_Click(sender As Object, e As EventArgs) Handles btnShowGrades.Click
            pcShowStudentGrades.Visible = True
            _studentModel.Id = CType(lblShowID.Text, Integer)
            GCStudentTable.DataSource = _gradesRepo.Search(_studentModel.Id)
        End Sub

    End Class
End Namespace
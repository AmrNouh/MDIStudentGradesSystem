Imports DevExpress.XtraEditors
Imports MDIStudentSystem.CommonValidation
Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.Students

Namespace UI
    Public Class XFrmAddStudent

        Private ReadOnly _studentModel As New StudentModel
        Private ReadOnly _studentRepo As New StudentRepository
        Private ReadOnly _validate As New ValidateStudentModel
        Private modelCheck As new ModelDataAnnotationCheck

        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


            'Load Data
            _studentModel.FstName = TxtFirstName.Text
            _studentModel.LstName = TxtLastName.Text
            _studentModel.EmailAddress = TxtEmail.Text
            _studentModel.CityName = TxtCity.Text 
            _studentModel.ValidateString = TxtBirthdate.Text

            If Not String.IsNullOrWhiteSpace(XOFBrowseImage.FileName) Then
                _studentModel.AvatarPic = _studentRepo.UploadImage(XOFBrowseImage.FileName, _studentModel.EmailAddress)
            End If

            StudentModelBindingSource.EndEdit()

            Try
                modelCheck.ValidateModel(_studentModel)
            Catch ex As ArgumentException
                'errorProvider.SetError(TxtFirstName,ex.Message)
                MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly, "Error")
                modelCheck.sb.Clear()
                Exit Sub
            End Try


            'If _validate.IsValid(_studentModel) OrElse _validate.ErrorMessage.Length < 0 Then

                'Check if Student Exist
                If _studentRepo.IsRecordFoundByEmail(_studentModel) Then
                    MsgBox("This Email Address Is Already Exist", MsgBoxStyle.OkOnly, "Change Email Address")
                    Exit Sub
                Else

                    If MsgBox("Do you Want To insert student In Database", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then

                        _studentModel.Birthdate = CType(TxtBirthdate.EditValue, Date)

                        'Insert Data
                        If _studentRepo.Insert(_studentModel) Then

                            MsgBox("Student inserted Successfully", MsgBoxStyle.OkOnly, "Success")
                            ResetFields()
                        Else
                            MsgBox("Data inserted Error", MsgBoxStyle.OkOnly, "Error")
                            Exit Sub
                        End If
                    Else
                        Exit Sub
                    End If

                End If
            'Else
            '    MsgBox(_validate.ErrorMessage.ToString(), MsgBoxStyle.OkOnly, "Error")
            '    _validate.ErrorMessage.Clear()
            '    Exit Sub
            'End If



        End Sub

        Private Sub XFrmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            XOFBrowseImage.InitialDirectory = Application.StartupPath
        End Sub

        Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click, Avatar.Click
            XOFBrowseImage.ShowDialog()
        End Sub

        Private Sub XOFBrowseImage_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XOFBrowseImage.FileOk
            Avatar.Image = Image.FromFile(XOFBrowseImage.FileName)
        End Sub

        Private Sub ResetFields()
            Avatar.Image = Avatar.InitialImage
            TxtFirstName.Text = Nothing
            TxtLastName.Text = Nothing
            TxtEmail.Text = Nothing
            TxtCity.Text = Nothing
            TxtBirthdate.Text = Nothing
        End Sub

    End Class
End Namespace
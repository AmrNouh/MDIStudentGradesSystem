Imports MDIStudentSystem.CommonValidation
Imports MDIStudentSystem.Models
Imports MDIStudentSystem.Repository.Grades

Namespace UI
    Public Class XFrmStudentGrades

        Private ReadOnly _gradesModel As New GradesModel
        Private ReadOnly _studentGradesRepo As New StudentGradesRepository
        Private ReadOnly _validate As New ValidateStudentGradesModel
        Private _modelCheck As New ModelDataAnnotationCheck

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



            'Validate Fields
            'If _validate.IsValid(_gradesModel) And _validate.ErrorMessage.Length < 0 Then

            'Check if Subject Inserted
            If _studentGradesRepo.IsRecordFound(_gradesModel) Then
                MsgBox("This Subject Is added Before", MsgBoxStyle.OkOnly, "Record Is Founded")
                ResetFields()
                Exit Sub
            Else
                

                'Load Data
                _gradesModel.StudentId = Val(TxtStudentId.Text)
                _gradesModel.SubjectName = cbSubjectName.Text
                _gradesModel.SubjectGrade = val(txtSubjectGrade.Text)
                _gradesModel.StudentGrade = val(txtStudentGrade.Text)
                _gradesModel.Percent = Val(txtPercent.Text)

                if cbSubjectName.Text = "Select Subject Name" Then
                    ErrorProvider.SetError(cbSubjectName,"Please Select The Subject Name")
                    Exit Sub
                    Else 
                        ErrorProvider.Dispose()
                End If



                Try
                    _modelCheck.ValidateModel(_gradesModel)
                Catch ex As ArgumentException
                    'errorProvider.SetError(TxtFirstName,ex.Message)
                    MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly, "Validation Error")
                    _modelCheck.Sb.Clear()
                    Exit Sub
                End Try


                If MsgBox($"Are You Sure You Want to add { _gradesModel.SubjectName} Grade", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then

                    'Insert Data
                    If _studentGradesRepo.Insert(_gradesModel) Then
                        MsgBox("Grade Added Successfully", MsgBoxStyle.OkOnly, "Success")
                        ResetFields()
                    Else
                        MsgBox("Can not add Grade", MsgBoxStyle.OkOnly, "Insert Error")
                        Exit Sub
                    End If

                Else
                    Exit Sub
                End If
            End If

            'Else
            '    MsgBox(_validate.ErrorMessage.ToString(), MsgBoxStyle.OkCancel, "Error")
            '    _validate.ErrorMessage.Clear()
            '    Exit Sub
            'End If

        End Sub

        Private Sub txtStudentGrade_EditValueChanged(sender As Object, e As EventArgs) Handles txtStudentGrade.EditValueChanged
            txtPercent.Text = (((Val(txtStudentGrade.Text) / Val(txtSubjectGrade.Text)))* 100).ToString()
        End Sub

        Private Sub ResetFields()
            TxtStudentId.Text = Nothing
            cbSubjectName.Text = "Select Subject Name"
            txtSubjectGrade.Text = Nothing
            txtStudentGrade.Text = Nothing
            txtPercent.Text = Nothing
        End Sub

        Private Sub txtSubjectGrade_EditValueChanged(sender As Object, e As EventArgs) Handles txtSubjectGrade.EditValueChanged
            txtStudentGrade.Enabled = True
        End Sub


        End Class
End Namespace
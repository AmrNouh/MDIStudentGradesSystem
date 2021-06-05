

Namespace UI

    Public Class XFrmHomePage

        Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

            Dim frmAddStudent As New XFrmAddStudent With {.MdiParent = Me}
            frmAddStudent.Show()
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            Dim frmSearchForStudent As New XFrmSearchStudent With {.MdiParent = Me}
            frmSearchForStudent.Show()

        End Sub

        Private Sub btnStudentGrades_Click(sender As Object, e As EventArgs) Handles btnStudentGrades.Click
            Dim frmStudentGrades As New XFrmStudentGrades With {.MdiParent = Me}
            frmStudentGrades.Show()
        End Sub

        Private Sub XFrmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim frmSearchForStudent As New XFrmSearchStudent With {.MdiParent = Me}
            frmSearchForStudent.Show()
        End Sub
    End Class
End Namespace
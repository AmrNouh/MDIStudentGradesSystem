Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI
Imports MDIStudentSystem.Reports

Namespace UI
    Public Class FrmStudentReports

        Dim ReadOnly _studentsReports As New StudentsReports

        Public Sub New ()
            InitializeComponent()
            LoadReport(DocumentViewer,_studentsReports)
        End Sub
        public Sub LoadReport(docView As DocumentViewer,report As XtraReport)
            docView.DocumentSource = report
        End Sub
    End Class
End NameSpace
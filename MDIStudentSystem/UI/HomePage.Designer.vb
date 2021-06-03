Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class XFrmHomePage
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XFrmHomePage))
        Me.SidePanel = New DevExpress.XtraEditors.SidePanel()
        Me.btnStudentGrades = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddStudent = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.tbHomePageContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.SidePanel.SuspendLayout
        CType(Me.DocumentManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbHomePageContainer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SidePanel
        '
        Me.SidePanel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(68,Byte),Integer))
        Me.SidePanel.Appearance.Options.UseBackColor = true
        Me.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SidePanel.BorderThickness = 0
        Me.SidePanel.Controls.Add(Me.btnStudentGrades)
        Me.SidePanel.Controls.Add(Me.btnAddStudent)
        Me.SidePanel.Controls.Add(Me.btnSearch)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(132, 768)
        Me.SidePanel.TabIndex = 0
        Me.SidePanel.Text = "SidePanel"
        '
        'btnStudentGrades
        '
        Me.btnStudentGrades.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(61,Byte),Integer))
        Me.btnStudentGrades.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnStudentGrades.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnStudentGrades.Appearance.Options.UseBackColor = true
        Me.btnStudentGrades.Appearance.Options.UseFont = true
        Me.btnStudentGrades.Appearance.Options.UseForeColor = true
        Me.btnStudentGrades.ImageOptions.Image = CType(resources.GetObject("btnStudentGrades.ImageOptions.Image"),System.Drawing.Image)
        Me.btnStudentGrades.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnStudentGrades.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
        Me.btnStudentGrades.Location = New System.Drawing.Point(0, 212)
        Me.btnStudentGrades.MinimumSize = New System.Drawing.Size(132, 50)
        Me.btnStudentGrades.Name = "btnStudentGrades"
        Me.btnStudentGrades.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnStudentGrades.Size = New System.Drawing.Size(132, 81)
        Me.btnStudentGrades.TabIndex = 1
        Me.btnStudentGrades.Text = "Student Grades"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(61,Byte),Integer))
        Me.btnAddStudent.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAddStudent.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAddStudent.Appearance.Options.UseBackColor = true
        Me.btnAddStudent.Appearance.Options.UseFont = true
        Me.btnAddStudent.Appearance.Options.UseForeColor = true
        Me.btnAddStudent.ImageOptions.Image = CType(resources.GetObject("btnAddStudent.ImageOptions.Image"),System.Drawing.Image)
        Me.btnAddStudent.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnAddStudent.Location = New System.Drawing.Point(0, 107)
        Me.btnAddStudent.MinimumSize = New System.Drawing.Size(132, 50)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnAddStudent.Size = New System.Drawing.Size(132, 81)
        Me.btnAddStudent.TabIndex = 1
        Me.btnAddStudent.Text = "Add Student"
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(61,Byte),Integer))
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSearch.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Appearance.Options.UseBackColor = true
        Me.btnSearch.Appearance.Options.UseFont = true
        Me.btnSearch.Appearance.Options.UseForeColor = true
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnSearch.ImageOptions.ImageToTextIndent = 0
        Me.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSearch.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full
        Me.btnSearch.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
        Me.btnSearch.Location = New System.Drawing.Point(0, 2)
        Me.btnSearch.MinimumSize = New System.Drawing.Size(132, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btnSearch.Size = New System.Drawing.Size(132, 81)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.View = Me.tbHomePageContainer
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tbHomePageContainer})
        '
        'tbHomePageContainer
        '
        Me.tbHomePageContainer.AppearancePage.Header.Font = New System.Drawing.Font("Dexef", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbHomePageContainer.AppearancePage.Header.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tbHomePageContainer.AppearancePage.Header.Options.UseFont = true
        Me.tbHomePageContainer.AppearancePage.Header.Options.UseForeColor = true
        Me.tbHomePageContainer.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(68,Byte),Integer))
        Me.tbHomePageContainer.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Dexef", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbHomePageContainer.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(68,Byte),Integer))
        Me.tbHomePageContainer.AppearancePage.HeaderActive.Options.UseBackColor = true
        Me.tbHomePageContainer.AppearancePage.HeaderActive.Options.UseFont = true
        Me.tbHomePageContainer.AppearancePage.HeaderActive.Options.UseForeColor = true
        '
        'XFrmHomePage
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.Appearance.Options.UseBackColor = true
        Me.Appearance.Options.UseFont = true
        Me.Appearance.Options.UseTextOptions = true
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1419, 768)
        Me.Controls.Add(Me.SidePanel)
        Me.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.IconOptions.LargeImage = CType(resources.GetObject("XFrmHomePage.IconOptions.LargeImage"),System.Drawing.Image)
        Me.IsMdiContainer = true
        Me.LookAndFeel.SkinName = "Office 2019 Colorful"
        Me.LookAndFeel.UseDefaultLookAndFeel = false
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(1421, 808)
        Me.MdiChildCaptionFormatString = "{0} - {1}"
        Me.MinimumSize = New System.Drawing.Size(1421, 808)
        Me.Name = "XFrmHomePage"
        Me.ShowMdiChildCaptionInParentTitle = true
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student System"
        Me.SidePanel.ResumeLayout(false)
        CType(Me.DocumentManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbHomePageContainer,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents SidePanel As DevExpress.XtraEditors.SidePanel
        Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnAddStudent As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnStudentGrades As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents tbHomePageContainer As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    End Class
End NameSpace
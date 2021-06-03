Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class XFrmStudentData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XFrmStudentData))
        Me.pShowStudentInfo = New DevExpress.XtraEditors.PanelControl()
        Me.btnShowGrades = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.GCIdContainer = New DevExpress.XtraEditors.GroupControl()
        Me.lblShowID = New DevExpress.XtraEditors.LabelControl()
        Me.lblTextId = New DevExpress.XtraEditors.LabelControl()
        Me.TxtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCity = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lblBirthDate = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.lblLastName = New DevExpress.XtraEditors.LabelControl()
        Me.lblCity = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.lblFirstName = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBirthdate = New DevExpress.XtraEditors.DateEdit()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.pcShowStudentGrades = New DevExpress.XtraEditors.PanelControl()
        Me.XOFBrowseImage = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowsePic = New MDIStudentSystem.CustomControls.CircularButton()
        Me.Avatar = New MDIStudentSystem.CircularPictureBox()
        Me.GCStudentTable = New DevExpress.XtraGrid.GridControl()
        Me.GVStudentGrades = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSubjectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubjectGrade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStudentGrade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercent = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.pShowStudentInfo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pShowStudentInfo.SuspendLayout
        CType(Me.GCIdContainer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GCIdContainer.SuspendLayout
        CType(Me.TxtLastName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtCity.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtEmail.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtFirstName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtBirthdate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtBirthdate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pcShowStudentGrades,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pcShowStudentGrades.SuspendLayout
        CType(Me.Avatar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GCStudentTable,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GVStudentGrades,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pShowStudentInfo
        '
        Me.pShowStudentInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pShowStudentInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pShowStudentInfo.Controls.Add(Me.btnShowGrades)
        Me.pShowStudentInfo.Controls.Add(Me.btnEdit)
        Me.pShowStudentInfo.Controls.Add(Me.GCIdContainer)
        Me.pShowStudentInfo.Controls.Add(Me.btnBrowsePic)
        Me.pShowStudentInfo.Controls.Add(Me.TxtLastName)
        Me.pShowStudentInfo.Controls.Add(Me.TxtCity)
        Me.pShowStudentInfo.Controls.Add(Me.TxtEmail)
        Me.pShowStudentInfo.Controls.Add(Me.lblBirthDate)
        Me.pShowStudentInfo.Controls.Add(Me.TxtFirstName)
        Me.pShowStudentInfo.Controls.Add(Me.lblLastName)
        Me.pShowStudentInfo.Controls.Add(Me.lblCity)
        Me.pShowStudentInfo.Controls.Add(Me.lblEmail)
        Me.pShowStudentInfo.Controls.Add(Me.lblFirstName)
        Me.pShowStudentInfo.Controls.Add(Me.Avatar)
        Me.pShowStudentInfo.Controls.Add(Me.TxtBirthdate)
        Me.pShowStudentInfo.Controls.Add(Me.btnCancel)
        Me.pShowStudentInfo.Controls.Add(Me.btnDelete)
        Me.pShowStudentInfo.Controls.Add(Me.btnSave)
        Me.pShowStudentInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pShowStudentInfo.Location = New System.Drawing.Point(0, 0)
        Me.pShowStudentInfo.MaximumSize = New System.Drawing.Size(649, 768)
        Me.pShowStudentInfo.MinimumSize = New System.Drawing.Size(649, 768)
        Me.pShowStudentInfo.Name = "pShowStudentInfo"
        Me.pShowStudentInfo.Size = New System.Drawing.Size(649, 768)
        Me.pShowStudentInfo.TabIndex = 0
        '
        'btnShowGrades
        '
        Me.btnShowGrades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnShowGrades.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnShowGrades.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnShowGrades.Appearance.Options.UseBackColor = true
        Me.btnShowGrades.Appearance.Options.UseFont = true
        Me.btnShowGrades.Appearance.Options.UseTextOptions = true
        Me.btnShowGrades.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnShowGrades.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnShowGrades.AppearanceHovered.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnShowGrades.AppearanceHovered.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnShowGrades.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.btnShowGrades.AppearanceHovered.Options.UseBackColor = true
        Me.btnShowGrades.AppearanceHovered.Options.UseFont = true
        Me.btnShowGrades.AppearanceHovered.Options.UseForeColor = true
        Me.btnShowGrades.AppearanceHovered.Options.UseTextOptions = true
        Me.btnShowGrades.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnShowGrades.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnShowGrades.AppearancePressed.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnShowGrades.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnShowGrades.AppearancePressed.Options.UseBackColor = true
        Me.btnShowGrades.AppearancePressed.Options.UseFont = true
        Me.btnShowGrades.AppearancePressed.Options.UseTextOptions = true
        Me.btnShowGrades.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnShowGrades.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnShowGrades.ImageOptions.SvgImage = CType(resources.GetObject("btnShowGrades.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnShowGrades.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btnShowGrades.Location = New System.Drawing.Point(393, 599)
        Me.btnShowGrades.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnShowGrades.MaximumSize = New System.Drawing.Size(200, 43)
        Me.btnShowGrades.MinimumSize = New System.Drawing.Size(200, 43)
        Me.btnShowGrades.Name = "btnShowGrades"
        Me.btnShowGrades.Size = New System.Drawing.Size(200, 43)
        Me.btnShowGrades.TabIndex = 20
        Me.btnShowGrades.Text = "Show Grades"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.Appearance.Options.UseBackColor = true
        Me.btnEdit.Appearance.Options.UseFont = true
        Me.btnEdit.Appearance.Options.UseTextOptions = true
        Me.btnEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnEdit.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnEdit.AppearanceHovered.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnEdit.AppearanceHovered.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.btnEdit.AppearanceHovered.Options.UseBackColor = true
        Me.btnEdit.AppearanceHovered.Options.UseFont = true
        Me.btnEdit.AppearanceHovered.Options.UseForeColor = true
        Me.btnEdit.AppearanceHovered.Options.UseTextOptions = true
        Me.btnEdit.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnEdit.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnEdit.AppearancePressed.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnEdit.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.AppearancePressed.Options.UseBackColor = true
        Me.btnEdit.AppearancePressed.Options.UseFont = true
        Me.btnEdit.AppearancePressed.Options.UseTextOptions = true
        Me.btnEdit.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnEdit.ImageOptions.SvgImage = CType(resources.GetObject("btnEdit.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnEdit.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btnEdit.Location = New System.Drawing.Point(45, 599)
        Me.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnEdit.MaximumSize = New System.Drawing.Size(150, 43)
        Me.btnEdit.MinimumSize = New System.Drawing.Size(150, 43)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(150, 43)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit"
        '
        'GCIdContainer
        '
        Me.GCIdContainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.GCIdContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GCIdContainer.Controls.Add(Me.lblShowID)
        Me.GCIdContainer.Controls.Add(Me.lblTextId)
        Me.GCIdContainer.Enabled = false
        Me.GCIdContainer.GroupStyle = DevExpress.Utils.GroupStyle.Light
        Me.GCIdContainer.Location = New System.Drawing.Point(288, 244)
        Me.GCIdContainer.Name = "GCIdContainer"
        Me.GCIdContainer.Size = New System.Drawing.Size(81, 51)
        Me.GCIdContainer.TabIndex = 19
        Me.GCIdContainer.Text = "GroupControl1"
        '
        'lblShowID
        '
        Me.lblShowID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblShowID.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblShowID.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblShowID.Appearance.Options.UseFont = true
        Me.lblShowID.Appearance.Options.UseForeColor = true
        Me.lblShowID.Appearance.Options.UseTextOptions = true
        Me.lblShowID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblShowID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblShowID.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.lblShowID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblShowID.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblShowID.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.lblShowID.Location = New System.Drawing.Point(35, 0)
        Me.lblShowID.Name = "lblShowID"
        Me.lblShowID.Size = New System.Drawing.Size(49, 51)
        Me.lblShowID.TabIndex = 1
        Me.lblShowID.Text = "SId"
        '
        'lblTextId
        '
        Me.lblTextId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblTextId.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTextId.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTextId.Appearance.Options.UseFont = true
        Me.lblTextId.Appearance.Options.UseForeColor = true
        Me.lblTextId.Appearance.Options.UseTextOptions = true
        Me.lblTextId.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTextId.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblTextId.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.lblTextId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTextId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblTextId.Location = New System.Drawing.Point(0, 0)
        Me.lblTextId.Name = "lblTextId"
        Me.lblTextId.Size = New System.Drawing.Size(44, 51)
        Me.lblTextId.TabIndex = 0
        Me.lblTextId.Text = "ID"
        '
        'TxtLastName
        '
        Me.TxtLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtLastName.Enabled = false
        Me.TxtLastName.Location = New System.Drawing.Point(344, 347)
        Me.TxtLastName.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtLastName.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtLastName.Properties.Appearance.Options.UseFont = true
        Me.TxtLastName.Size = New System.Drawing.Size(250, 30)
        Me.TxtLastName.TabIndex = 9
        '
        'TxtCity
        '
        Me.TxtCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtCity.Enabled = false
        Me.TxtCity.Location = New System.Drawing.Point(45, 511)
        Me.TxtCity.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtCity.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtCity.Properties.Appearance.Options.UseFont = true
        Me.TxtCity.Size = New System.Drawing.Size(250, 30)
        Me.TxtCity.TabIndex = 16
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtEmail.Enabled = false
        Me.TxtEmail.Location = New System.Drawing.Point(45, 428)
        Me.TxtEmail.MaximumSize = New System.Drawing.Size(550, 30)
        Me.TxtEmail.MinimumSize = New System.Drawing.Size(550, 30)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtEmail.Properties.Appearance.Options.UseFont = true
        Me.TxtEmail.Size = New System.Drawing.Size(550, 28)
        Me.TxtEmail.TabIndex = 15
        '
        'lblBirthDate
        '
        Me.lblBirthDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblBirthDate.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBirthDate.Appearance.Options.UseFont = true
        Me.lblBirthDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblBirthDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblBirthDate.Location = New System.Drawing.Point(344, 485)
        Me.lblBirthDate.MaximumSize = New System.Drawing.Size(80, 20)
        Me.lblBirthDate.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(80, 20)
        Me.lblBirthDate.TabIndex = 10
        Me.lblBirthDate.Text = "Birthdate"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtFirstName.Enabled = false
        Me.TxtFirstName.Location = New System.Drawing.Point(45, 347)
        Me.TxtFirstName.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtFirstName.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtFirstName.Properties.Appearance.Options.UseFont = true
        Me.TxtFirstName.Size = New System.Drawing.Size(250, 30)
        Me.TxtFirstName.TabIndex = 7
        '
        'lblLastName
        '
        Me.lblLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblLastName.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLastName.Appearance.Options.UseFont = true
        Me.lblLastName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblLastName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblLastName.Location = New System.Drawing.Point(344, 321)
        Me.lblLastName.MaximumSize = New System.Drawing.Size(80, 20)
        Me.lblLastName.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 20)
        Me.lblLastName.TabIndex = 11
        Me.lblLastName.Text = "LastName"
        '
        'lblCity
        '
        Me.lblCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblCity.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCity.Appearance.Options.UseFont = true
        Me.lblCity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblCity.Location = New System.Drawing.Point(45, 485)
        Me.lblCity.MaximumSize = New System.Drawing.Size(80, 24)
        Me.lblCity.MinimumSize = New System.Drawing.Size(80, 24)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(80, 24)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "City"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEmail.Appearance.Options.UseFont = true
        Me.lblEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblEmail.Location = New System.Drawing.Point(45, 402)
        Me.lblEmail.MaximumSize = New System.Drawing.Size(80, 20)
        Me.lblEmail.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(80, 20)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "Email"
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblFirstName.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFirstName.Appearance.Options.UseFont = true
        Me.lblFirstName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFirstName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblFirstName.Location = New System.Drawing.Point(45, 321)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 20)
        Me.lblFirstName.TabIndex = 14
        Me.lblFirstName.Text = "FirstName"
        '
        'TxtBirthdate
        '
        Me.TxtBirthdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtBirthdate.EditValue = Nothing
        Me.TxtBirthdate.Enabled = false
        Me.TxtBirthdate.Location = New System.Drawing.Point(344, 511)
        Me.TxtBirthdate.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtBirthdate.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtBirthdate.Name = "TxtBirthdate"
        Me.TxtBirthdate.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtBirthdate.Properties.Appearance.Options.UseFont = true
        Me.TxtBirthdate.Properties.BeepOnError = false
        Me.TxtBirthdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBirthdate.Properties.DisplayFormat.FormatString = ""
        Me.TxtBirthdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtBirthdate.Properties.EditFormat.FormatString = ""
        Me.TxtBirthdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtBirthdate.Properties.MaskSettings.Set("mask", "d")
        Me.TxtBirthdate.Size = New System.Drawing.Size(250, 30)
        Me.TxtBirthdate.TabIndex = 17
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancel.Appearance.Options.UseBackColor = true
        Me.btnCancel.Appearance.Options.UseFont = true
        Me.btnCancel.Appearance.Options.UseTextOptions = true
        Me.btnCancel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnCancel.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnCancel.AppearanceHovered.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnCancel.AppearanceHovered.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancel.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.btnCancel.AppearanceHovered.Options.UseBackColor = true
        Me.btnCancel.AppearanceHovered.Options.UseFont = true
        Me.btnCancel.AppearanceHovered.Options.UseForeColor = true
        Me.btnCancel.AppearanceHovered.Options.UseTextOptions = true
        Me.btnCancel.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnCancel.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnCancel.AppearancePressed.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnCancel.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCancel.AppearancePressed.Options.UseBackColor = true
        Me.btnCancel.AppearancePressed.Options.UseFont = true
        Me.btnCancel.AppearancePressed.Options.UseTextOptions = true
        Me.btnCancel.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(443, 599)
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnCancel.MaximumSize = New System.Drawing.Size(150, 43)
        Me.btnCancel.MinimumSize = New System.Drawing.Size(150, 43)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 43)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = false
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelete.Appearance.Options.UseBackColor = true
        Me.btnDelete.Appearance.Options.UseFont = true
        Me.btnDelete.Appearance.Options.UseTextOptions = true
        Me.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnDelete.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnDelete.AppearanceHovered.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnDelete.AppearanceHovered.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelete.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.btnDelete.AppearanceHovered.Options.UseBackColor = true
        Me.btnDelete.AppearanceHovered.Options.UseFont = true
        Me.btnDelete.AppearanceHovered.Options.UseForeColor = true
        Me.btnDelete.AppearanceHovered.Options.UseTextOptions = true
        Me.btnDelete.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnDelete.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnDelete.AppearancePressed.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnDelete.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelete.AppearancePressed.Options.UseBackColor = true
        Me.btnDelete.AppearancePressed.Options.UseFont = true
        Me.btnDelete.AppearancePressed.Options.UseTextOptions = true
        Me.btnDelete.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDelete.ImageOptions.SvgImage = CType(resources.GetObject("btnDelete.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnDelete.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btnDelete.Location = New System.Drawing.Point(219, 599)
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnDelete.MaximumSize = New System.Drawing.Size(150, 43)
        Me.btnDelete.MinimumSize = New System.Drawing.Size(150, 43)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 43)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.Appearance.Options.UseBackColor = true
        Me.btnSave.Appearance.Options.UseFont = true
        Me.btnSave.Appearance.Options.UseTextOptions = true
        Me.btnSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnSave.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnSave.AppearanceHovered.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnSave.AppearanceHovered.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.AppearanceHovered.ForeColor = System.Drawing.Color.White
        Me.btnSave.AppearanceHovered.Options.UseBackColor = true
        Me.btnSave.AppearanceHovered.Options.UseFont = true
        Me.btnSave.AppearanceHovered.Options.UseForeColor = true
        Me.btnSave.AppearanceHovered.Options.UseTextOptions = true
        Me.btnSave.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnSave.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnSave.AppearancePressed.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnSave.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.AppearancePressed.Options.UseBackColor = true
        Me.btnSave.AppearancePressed.Options.UseFont = true
        Me.btnSave.AppearancePressed.Options.UseTextOptions = true
        Me.btnSave.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(219, 599)
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnSave.MaximumSize = New System.Drawing.Size(150, 43)
        Me.btnSave.MinimumSize = New System.Drawing.Size(150, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 43)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.Visible = false
        '
        'pcShowStudentGrades
        '
        Me.pcShowStudentGrades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.pcShowStudentGrades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pcShowStudentGrades.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcShowStudentGrades.Controls.Add(Me.GCStudentTable)
        Me.pcShowStudentGrades.Location = New System.Drawing.Point(638, 0)
        Me.pcShowStudentGrades.Name = "pcShowStudentGrades"
        Me.pcShowStudentGrades.Size = New System.Drawing.Size(649, 768)
        Me.pcShowStudentGrades.TabIndex = 0
        Me.pcShowStudentGrades.Visible = false
        '
        'XOFBrowseImage
        '
        Me.XOFBrowseImage.Filter = "PNG|*.PNG|JPEG|*.JPG"
        Me.XOFBrowseImage.Title = "Browes Image"
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowsePic.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBrowsePic.Enabled = false
        Me.btnBrowsePic.FlatAppearance.BorderSize = 0
        Me.btnBrowsePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowsePic.Image = CType(resources.GetObject("btnBrowsePic.Image"),System.Drawing.Image)
        Me.btnBrowsePic.Location = New System.Drawing.Point(331, 174)
        Me.btnBrowsePic.MaximumSize = New System.Drawing.Size(64, 64)
        Me.btnBrowsePic.MinimumSize = New System.Drawing.Size(64, 64)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(64, 64)
        Me.btnBrowsePic.TabIndex = 18
        Me.btnBrowsePic.UseVisualStyleBackColor = true
        '
        'Avatar
        '
        Me.Avatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Avatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Avatar.Enabled = false
        Me.Avatar.ErrorImage = CType(resources.GetObject("Avatar.ErrorImage"),System.Drawing.Image)
        Me.Avatar.Image = CType(resources.GetObject("Avatar.Image"),System.Drawing.Image)
        Me.Avatar.InitialImage = CType(resources.GetObject("Avatar.InitialImage"),System.Drawing.Image)
        Me.Avatar.Location = New System.Drawing.Point(234, 58)
        Me.Avatar.MaximumSize = New System.Drawing.Size(180, 180)
        Me.Avatar.MinimumSize = New System.Drawing.Size(180, 180)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(180, 180)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 8
        Me.Avatar.TabStop = false
        '
        'GCStudentTable
        '
        Me.GCStudentTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCStudentTable.Location = New System.Drawing.Point(0, 0)
        Me.GCStudentTable.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GCStudentTable.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GCStudentTable.MainView = Me.GVStudentGrades
        Me.GCStudentTable.Name = "GCStudentTable"
        Me.GCStudentTable.Size = New System.Drawing.Size(649, 768)
        Me.GCStudentTable.TabIndex = 0
        Me.GCStudentTable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStudentGrades})
        '
        'GVStudentGrades
        '
        Me.GVStudentGrades.Appearance.EvenRow.BackColor = System.Drawing.Color.DarkGray
        Me.GVStudentGrades.Appearance.EvenRow.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GVStudentGrades.Appearance.EvenRow.Options.UseBackColor = true
        Me.GVStudentGrades.Appearance.EvenRow.Options.UseFont = true
        Me.GVStudentGrades.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.GVStudentGrades.Appearance.FooterPanel.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GVStudentGrades.Appearance.FooterPanel.Options.UseBorderColor = true
        Me.GVStudentGrades.Appearance.FooterPanel.Options.UseFont = true
        Me.GVStudentGrades.Appearance.FooterPanel.Options.UseTextOptions = true
        Me.GVStudentGrades.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStudentGrades.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStudentGrades.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GVStudentGrades.Appearance.HeaderPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.GVStudentGrades.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.GVStudentGrades.Appearance.HeaderPanel.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GVStudentGrades.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GVStudentGrades.Appearance.HeaderPanel.Options.UseBackColor = true
        Me.GVStudentGrades.Appearance.HeaderPanel.Options.UseBorderColor = true
        Me.GVStudentGrades.Appearance.HeaderPanel.Options.UseFont = true
        Me.GVStudentGrades.Appearance.HeaderPanel.Options.UseForeColor = true
        Me.GVStudentGrades.Appearance.HeaderPanel.Options.UseTextOptions = true
        Me.GVStudentGrades.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStudentGrades.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStudentGrades.Appearance.OddRow.BackColor = System.Drawing.Color.Silver
        Me.GVStudentGrades.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.GVStudentGrades.Appearance.OddRow.Options.UseBackColor = true
        Me.GVStudentGrades.Appearance.OddRow.Options.UseFont = true
        Me.GVStudentGrades.Appearance.Preview.BorderColor = System.Drawing.Color.White
        Me.GVStudentGrades.Appearance.Preview.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GVStudentGrades.Appearance.Preview.Options.UseBorderColor = true
        Me.GVStudentGrades.Appearance.Preview.Options.UseFont = true
        Me.GVStudentGrades.Appearance.Row.BorderColor = System.Drawing.Color.White
        Me.GVStudentGrades.Appearance.Row.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GVStudentGrades.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVStudentGrades.Appearance.Row.Options.UseBorderColor = true
        Me.GVStudentGrades.Appearance.Row.Options.UseFont = true
        Me.GVStudentGrades.Appearance.Row.Options.UseForeColor = true
        Me.GVStudentGrades.Appearance.Row.Options.UseTextOptions = true
        Me.GVStudentGrades.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStudentGrades.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStudentGrades.Appearance.RowSeparator.Options.UseBorderColor = true
        Me.GVStudentGrades.Appearance.SelectedRow.BorderColor = System.Drawing.Color.White
        Me.GVStudentGrades.Appearance.SelectedRow.Options.UseBorderColor = true
        Me.GVStudentGrades.Appearance.SelectedRow.Options.UseTextOptions = true
        Me.GVStudentGrades.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStudentGrades.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStudentGrades.Appearance.TopNewRow.Options.UseTextOptions = true
        Me.GVStudentGrades.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStudentGrades.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStudentGrades.Appearance.ViewCaption.Options.UseTextOptions = true
        Me.GVStudentGrades.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStudentGrades.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStudentGrades.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.GVStudentGrades.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubjectName, Me.colSubjectGrade, Me.colStudentGrade, Me.colPercent})
        Me.GVStudentGrades.GridControl = Me.GCStudentTable
        Me.GVStudentGrades.Name = "GVStudentGrades"
        Me.GVStudentGrades.OptionsBehavior.KeepFocusedRowOnUpdate = false
        Me.GVStudentGrades.OptionsHint.ShowFooterHints = false
        Me.GVStudentGrades.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.GVStudentGrades.OptionsMenu.ShowFooterItem = true
        Me.GVStudentGrades.OptionsPrint.EnableAppearanceEvenRow = true
        Me.GVStudentGrades.OptionsPrint.EnableAppearanceOddRow = true
        Me.GVStudentGrades.OptionsPrint.PrintGroupFooter = false
        Me.GVStudentGrades.OptionsPrint.PrintHorzLines = false
        Me.GVStudentGrades.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVStudentGrades.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GVStudentGrades.OptionsSelection.EnableAppearanceFocusedRow = false
        Me.GVStudentGrades.OptionsSelection.UseIndicatorForSelection = false
        Me.GVStudentGrades.OptionsView.EnableAppearanceEvenRow = true
        Me.GVStudentGrades.OptionsView.EnableAppearanceOddRow = true
        Me.GVStudentGrades.OptionsView.ShowErrorPanel = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVStudentGrades.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVStudentGrades.OptionsView.ShowFooter = true
        Me.GVStudentGrades.OptionsView.ShowGroupExpandCollapseButtons = false
        Me.GVStudentGrades.OptionsView.ShowGroupPanel = false
        Me.GVStudentGrades.OptionsView.ShowIndicator = false
        Me.GVStudentGrades.PaintStyleName = "UltraFlat"
        '
        'colSubjectName
        '
        Me.colSubjectName.Caption = "Subject"
        Me.colSubjectName.FieldName = "SubjectName"
        Me.colSubjectName.MinWidth = 25
        Me.colSubjectName.Name = "colSubjectName"
        Me.colSubjectName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "SubjectName", "Total", "Total")})
        Me.colSubjectName.Visible = true
        Me.colSubjectName.VisibleIndex = 0
        Me.colSubjectName.Width = 94
        '
        'colSubjectGrade
        '
        Me.colSubjectGrade.Caption = "Subject Grade"
        Me.colSubjectGrade.DisplayFormat.FormatString = "{0:n0}"
        Me.colSubjectGrade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubjectGrade.FieldName = "SubjectGrade"
        Me.colSubjectGrade.MinWidth = 25
        Me.colSubjectGrade.Name = "colSubjectGrade"
        Me.colSubjectGrade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubjectGrade", "{0:n0}")})
        Me.colSubjectGrade.Visible = true
        Me.colSubjectGrade.VisibleIndex = 1
        Me.colSubjectGrade.Width = 94
        '
        'colStudentGrade
        '
        Me.colStudentGrade.Caption = "Student Grade"
        Me.colStudentGrade.DisplayFormat.FormatString = "{0:n2}"
        Me.colStudentGrade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStudentGrade.FieldName = "StudentGrade"
        Me.colStudentGrade.MinWidth = 25
        Me.colStudentGrade.Name = "colStudentGrade"
        Me.colStudentGrade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StudentGrade", "{0:n2}")})
        Me.colStudentGrade.Visible = true
        Me.colStudentGrade.VisibleIndex = 2
        Me.colStudentGrade.Width = 94
        '
        'colPercent
        '
        Me.colPercent.Caption = "Percent"
        Me.colPercent.DisplayFormat.FormatString = "{0:n2}%"
        Me.colPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPercent.FieldName = "SubjectGradePercent"
        Me.colPercent.MinWidth = 25
        Me.colPercent.Name = "colPercent"
        Me.colPercent.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "SubjectGradePercent", "{0:n2}%")})
        Me.colPercent.Visible = true
        Me.colPercent.VisibleIndex = 3
        Me.colPercent.Width = 94
        '
        'XFrmStudentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 768)
        Me.Controls.Add(Me.pcShowStudentGrades)
        Me.Controls.Add(Me.pShowStudentInfo)
        Me.IconOptions.SvgImage = CType(resources.GetObject("XFrmStudentData.IconOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.Location = New System.Drawing.Point(1289, 808)
        Me.MaximumSize = New System.Drawing.Size(1289, 808)
        Me.Name = "XFrmStudentData"
        Me.Text = "Student Data"
        CType(Me.pShowStudentInfo,System.ComponentModel.ISupportInitialize).EndInit
        Me.pShowStudentInfo.ResumeLayout(false)
        CType(Me.GCIdContainer,System.ComponentModel.ISupportInitialize).EndInit
        Me.GCIdContainer.ResumeLayout(false)
        CType(Me.TxtLastName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtCity.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtEmail.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtFirstName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtBirthdate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtBirthdate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pcShowStudentGrades,System.ComponentModel.ISupportInitialize).EndInit
        Me.pcShowStudentGrades.ResumeLayout(false)
        CType(Me.Avatar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GCStudentTable,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GVStudentGrades,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents pShowStudentInfo As DevExpress.XtraEditors.PanelControl
        Friend WithEvents pcShowStudentGrades As DevExpress.XtraEditors.PanelControl
        Friend WithEvents btnBrowsePic As CustomControls.CircularButton
        Friend WithEvents TxtLastName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtCity As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtEmail As DevExpress.XtraEditors.TextEdit
        Friend WithEvents lblBirthDate As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TxtFirstName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents lblLastName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblCity As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblFirstName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Avatar As CircularPictureBox
        Friend WithEvents TxtBirthdate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents GCIdContainer As DevExpress.XtraEditors.GroupControl
        Friend WithEvents lblShowID As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblTextId As DevExpress.XtraEditors.LabelControl
        Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnShowGrades As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents XOFBrowseImage As OpenFileDialog
        Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents GCStudentTable As DevExpress.XtraGrid.GridControl
        Friend WithEvents GVStudentGrades As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colSubjectName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSubjectGrade As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStudentGrade As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPercent As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End NameSpace
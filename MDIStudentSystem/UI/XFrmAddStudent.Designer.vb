Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class XFrmAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XFrmAddStudent))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBrowsePic = New MDIStudentSystem.CustomControls.CircularButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.StudentModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtCity = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lblBirthDate = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.lblLastName = New DevExpress.XtraEditors.LabelControl()
        Me.lblCity = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.lblFirstName = New DevExpress.XtraEditors.LabelControl()
        Me.Avatar = New MDIStudentSystem.CircularPictureBox()
        Me.TxtBirthdate = New DevExpress.XtraEditors.DateEdit()
        Me.XOFBrowseImage = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.TxtLastName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StudentModelBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtCity.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtEmail.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtFirstName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Avatar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtBirthdate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtBirthdate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.errorProvider,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnBrowsePic)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.TxtLastName)
        Me.PanelControl1.Controls.Add(Me.TxtCity)
        Me.PanelControl1.Controls.Add(Me.TxtEmail)
        Me.PanelControl1.Controls.Add(Me.lblBirthDate)
        Me.PanelControl1.Controls.Add(Me.TxtFirstName)
        Me.PanelControl1.Controls.Add(Me.lblLastName)
        Me.PanelControl1.Controls.Add(Me.lblCity)
        Me.PanelControl1.Controls.Add(Me.lblEmail)
        Me.PanelControl1.Controls.Add(Me.lblFirstName)
        Me.PanelControl1.Controls.Add(Me.Avatar)
        Me.PanelControl1.Controls.Add(Me.TxtBirthdate)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.MaximumSize = New System.Drawing.Size(1289, 808)
        Me.PanelControl1.MinimumSize = New System.Drawing.Size(1289, 808)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1289, 808)
        Me.PanelControl1.TabIndex = 0
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowsePic.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBrowsePic.FlatAppearance.BorderSize = 0
        Me.btnBrowsePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowsePic.Image = CType(resources.GetObject("btnBrowsePic.Image"),System.Drawing.Image)
        Me.btnBrowsePic.Location = New System.Drawing.Point(670, 145)
        Me.btnBrowsePic.MaximumSize = New System.Drawing.Size(64, 64)
        Me.btnBrowsePic.MinimumSize = New System.Drawing.Size(64, 64)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(64, 64)
        Me.btnBrowsePic.TabIndex = 6
        Me.btnBrowsePic.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAdd.Appearance.Options.UseBackColor = true
        Me.btnAdd.Appearance.Options.UseFont = true
        Me.btnAdd.Appearance.Options.UseTextOptions = true
        Me.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAdd.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnAdd.AppearanceHovered.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnAdd.AppearanceHovered.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.AppearanceHovered.Options.UseBackColor = true
        Me.btnAdd.AppearanceHovered.Options.UseFont = true
        Me.btnAdd.AppearanceHovered.Options.UseForeColor = true
        Me.btnAdd.AppearanceHovered.Options.UseTextOptions = true
        Me.btnAdd.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAdd.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnAdd.AppearancePressed.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnAdd.AppearancePressed.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAdd.AppearancePressed.Options.UseBackColor = true
        Me.btnAdd.AppearancePressed.Options.UseFont = true
        Me.btnAdd.AppearancePressed.Options.UseTextOptions = true
        Me.btnAdd.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAdd.ImageOptions.SvgImage = CType(resources.GetObject("btnAdd.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnAdd.Location = New System.Drawing.Point(384, 540)
        Me.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(549, 43)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Insert"
        '
        'TxtLastName
        '
        Me.TxtLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentModelBindingSource, "LstName", true))
        Me.TxtLastName.Location = New System.Drawing.Point(683, 293)
        Me.TxtLastName.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtLastName.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtLastName.Properties.Appearance.Options.UseFont = true
        Me.TxtLastName.Size = New System.Drawing.Size(250, 30)
        Me.TxtLastName.TabIndex = 1
        '
        'StudentModelBindingSource
        '
        Me.StudentModelBindingSource.DataSource = GetType(MDIStudentSystem.Models.StudentModel)
        '
        'TxtCity
        '
        Me.TxtCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentModelBindingSource, "CityName", true))
        Me.TxtCity.Location = New System.Drawing.Point(384, 457)
        Me.TxtCity.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtCity.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtCity.Properties.Appearance.Options.UseFont = true
        Me.TxtCity.Size = New System.Drawing.Size(250, 30)
        Me.TxtCity.TabIndex = 3
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentModelBindingSource, "EmailAddress", true))
        Me.TxtEmail.Location = New System.Drawing.Point(384, 374)
        Me.TxtEmail.MaximumSize = New System.Drawing.Size(550, 30)
        Me.TxtEmail.MinimumSize = New System.Drawing.Size(550, 30)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtEmail.Properties.Appearance.Options.UseFont = true
        Me.TxtEmail.Size = New System.Drawing.Size(550, 28)
        Me.TxtEmail.TabIndex = 2
        '
        'lblBirthDate
        '
        Me.lblBirthDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblBirthDate.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBirthDate.Appearance.Options.UseFont = true
        Me.lblBirthDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblBirthDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblBirthDate.Location = New System.Drawing.Point(683, 431)
        Me.lblBirthDate.MaximumSize = New System.Drawing.Size(80, 20)
        Me.lblBirthDate.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(80, 20)
        Me.lblBirthDate.TabIndex = 1
        Me.lblBirthDate.Text = "Birthdate"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentModelBindingSource, "FstName", true))
        Me.TxtFirstName.Location = New System.Drawing.Point(384, 293)
        Me.TxtFirstName.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtFirstName.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtFirstName.Properties.Appearance.Options.UseFont = true
        Me.TxtFirstName.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.TxtFirstName.Size = New System.Drawing.Size(250, 30)
        Me.TxtFirstName.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblLastName.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLastName.Appearance.Options.UseFont = true
        Me.lblLastName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblLastName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblLastName.Location = New System.Drawing.Point(683, 267)
        Me.lblLastName.MaximumSize = New System.Drawing.Size(80, 20)
        Me.lblLastName.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 20)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "LastName"
        '
        'lblCity
        '
        Me.lblCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblCity.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCity.Appearance.Options.UseFont = true
        Me.lblCity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblCity.Location = New System.Drawing.Point(384, 431)
        Me.lblCity.MaximumSize = New System.Drawing.Size(80, 24)
        Me.lblCity.MinimumSize = New System.Drawing.Size(80, 24)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(80, 24)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEmail.Appearance.Options.UseFont = true
        Me.lblEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblEmail.Location = New System.Drawing.Point(384, 348)
        Me.lblEmail.MaximumSize = New System.Drawing.Size(80, 20)
        Me.lblEmail.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(80, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.lblFirstName.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFirstName.Appearance.Options.UseFont = true
        Me.lblFirstName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFirstName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblFirstName.Location = New System.Drawing.Point(384, 267)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 20)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "FirstName"
        '
        'Avatar
        '
        Me.Avatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Avatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Avatar.ErrorImage = CType(resources.GetObject("Avatar.ErrorImage"),System.Drawing.Image)
        Me.Avatar.Image = CType(resources.GetObject("Avatar.Image"),System.Drawing.Image)
        Me.Avatar.InitialImage = Global.MDIStudentSystem.My.Resources.Resources.kisspng_computer_icons_student_school_student_5abd018f3c5316_0501198915223361432471
        Me.Avatar.Location = New System.Drawing.Point(554, 29)
        Me.Avatar.MaximumSize = New System.Drawing.Size(180, 180)
        Me.Avatar.MinimumSize = New System.Drawing.Size(180, 180)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(180, 180)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = false
        '
        'TxtBirthdate
        '
        Me.TxtBirthdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtBirthdate.EditValue = Nothing
        Me.TxtBirthdate.Location = New System.Drawing.Point(683, 457)
        Me.TxtBirthdate.MaximumSize = New System.Drawing.Size(205, 30)
        Me.TxtBirthdate.MinimumSize = New System.Drawing.Size(250, 30)
        Me.TxtBirthdate.Name = "TxtBirthdate"
        Me.TxtBirthdate.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.TxtBirthdate.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.TxtBirthdate.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.MediumSeaGreen
        Me.TxtBirthdate.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtBirthdate.Properties.Appearance.Options.UseFont = true
        Me.TxtBirthdate.Properties.Appearance.Options.UseTextOptions = true
        Me.TxtBirthdate.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.TxtBirthdate.Properties.AppearanceCalendar.Button.Font = New System.Drawing.Font("Dexef", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtBirthdate.Properties.AppearanceCalendar.Button.Options.UseFont = true
        Me.TxtBirthdate.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Dexef", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtBirthdate.Properties.AppearanceDropDown.Options.UseFont = true
        Me.TxtBirthdate.Properties.BeepOnError = false
        Me.TxtBirthdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBirthdate.Properties.CalendarTimeProperties.BeepOnError = false
        Me.TxtBirthdate.Properties.CalendarTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtBirthdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBirthdate.Properties.CalendarTimeProperties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtBirthdate.Properties.CalendarTimeProperties.MaskSettings.Set("mask", "dd/MM/yyyy")
        Me.TxtBirthdate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.TxtBirthdate.Properties.CalendarTimeProperties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.TxtBirthdate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true
        Me.TxtBirthdate.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.TxtBirthdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtBirthdate.Properties.EditFormat.FormatString = "{0:dd/MM/yyyy}"
        Me.TxtBirthdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtBirthdate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy")
        Me.TxtBirthdate.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.TxtBirthdate.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder
        Me.TxtBirthdate.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.[False]
        Me.TxtBirthdate.Properties.UseMaskAsDisplayFormat = true
        Me.TxtBirthdate.Size = New System.Drawing.Size(250, 30)
        Me.TxtBirthdate.TabIndex = 4
        '
        'XOFBrowseImage
        '
        Me.XOFBrowseImage.Filter = "PNG|*.PNG|JPEG|*.JPG"
        Me.XOFBrowseImage.InitialDirectory = "%appData%"
        Me.XOFBrowseImage.Title = "Browes Image"
        '
        'errorProvider
        '
        Me.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.errorProvider.ContainerControl = Me
        Me.errorProvider.DataSource = Me.StudentModelBindingSource
        '
        'XFrmAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 775)
        Me.Controls.Add(Me.PanelControl1)
        Me.IconOptions.Image = Global.MDIStudentSystem.My.Resources.Resources.icons8_student_male_100
        Me.MaximumSize = New System.Drawing.Size(1289, 815)
        Me.MinimumSize = New System.Drawing.Size(1289, 815)
        Me.Name = "XFrmAddStudent"
        Me.Text = "Add Student"
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.TxtLastName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StudentModelBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtCity.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtEmail.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtFirstName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Avatar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtBirthdate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtBirthdate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.errorProvider,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents Avatar As CircularPictureBox
        Friend WithEvents lblFirstName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TxtLastName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtEmail As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TxtFirstName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents lblLastName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TxtCity As DevExpress.XtraEditors.TextEdit
        Friend WithEvents lblBirthDate As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblCity As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TxtBirthdate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnBrowsePic As CustomControls.CircularButton
        Friend WithEvents XOFBrowseImage As DevExpress.XtraEditors.XtraOpenFileDialog
        Friend WithEvents StudentModelBindingSource As BindingSource
        Friend WithEvents errorProvider As ErrorProvider
    End Class
End NameSpace
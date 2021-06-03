Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class XFrmStudentGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XFrmStudentGrades))
        Me.lblStudentID = New DevExpress.XtraEditors.LabelControl()
        Me.lblStudentGrade = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubjectGradePercent = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubjectGrade = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubjectName = New DevExpress.XtraEditors.LabelControl()
        Me.pcGradesContainer = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.FixedImage = New MDIStudentSystem.CircularPictureBox()
        Me.cbSubjectName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtPercent = New DevExpress.XtraEditors.TextEdit()
        Me.txtStudentGrade = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubjectGrade = New DevExpress.XtraEditors.TextEdit()
        Me.TxtStudentId = New DevExpress.XtraEditors.TextEdit()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StudentModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.pcGradesContainer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pcGradesContainer.SuspendLayout
        CType(Me.FixedImage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbSubjectName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPercent.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtStudentGrade.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSubjectGrade.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtStudentId.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ErrorProvider,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StudentModelBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lblStudentID
        '
        Me.lblStudentID.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!)
        Me.lblStudentID.Appearance.Options.UseFont = true
        Me.lblStudentID.Location = New System.Drawing.Point(363, 211)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(80, 26)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'lblStudentGrade
        '
        Me.lblStudentGrade.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!)
        Me.lblStudentGrade.Appearance.Options.UseFont = true
        Me.lblStudentGrade.Location = New System.Drawing.Point(334, 395)
        Me.lblStudentGrade.Name = "lblStudentGrade"
        Me.lblStudentGrade.Size = New System.Drawing.Size(109, 26)
        Me.lblStudentGrade.TabIndex = 0
        Me.lblStudentGrade.Text = "Student Grade"
        '
        'lblSubjectGradePercent
        '
        Me.lblSubjectGradePercent.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!)
        Me.lblSubjectGradePercent.Appearance.Options.UseFont = true
        Me.lblSubjectGradePercent.Location = New System.Drawing.Point(385, 457)
        Me.lblSubjectGradePercent.Name = "lblSubjectGradePercent"
        Me.lblSubjectGradePercent.Size = New System.Drawing.Size(58, 26)
        Me.lblSubjectGradePercent.TabIndex = 0
        Me.lblSubjectGradePercent.Text = "Percent"
        '
        'lblSubjectGrade
        '
        Me.lblSubjectGrade.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!)
        Me.lblSubjectGrade.Appearance.Options.UseFont = true
        Me.lblSubjectGrade.Location = New System.Drawing.Point(338, 333)
        Me.lblSubjectGrade.Name = "lblSubjectGrade"
        Me.lblSubjectGrade.Size = New System.Drawing.Size(105, 26)
        Me.lblSubjectGrade.TabIndex = 0
        Me.lblSubjectGrade.Text = "Subject Grade"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.Appearance.Font = New System.Drawing.Font("Dexef", 10.2!)
        Me.lblSubjectName.Appearance.Options.UseFont = true
        Me.lblSubjectName.Location = New System.Drawing.Point(338, 272)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(105, 26)
        Me.lblSubjectName.TabIndex = 0
        Me.lblSubjectName.Text = "Subject Name"
        '
        'pcGradesContainer
        '
        Me.pcGradesContainer.Controls.Add(Me.LabelControl1)
        Me.pcGradesContainer.Controls.Add(Me.btnSave)
        Me.pcGradesContainer.Controls.Add(Me.FixedImage)
        Me.pcGradesContainer.Controls.Add(Me.lblSubjectGradePercent)
        Me.pcGradesContainer.Controls.Add(Me.lblSubjectGrade)
        Me.pcGradesContainer.Controls.Add(Me.lblSubjectName)
        Me.pcGradesContainer.Controls.Add(Me.cbSubjectName)
        Me.pcGradesContainer.Controls.Add(Me.lblStudentGrade)
        Me.pcGradesContainer.Controls.Add(Me.txtPercent)
        Me.pcGradesContainer.Controls.Add(Me.txtStudentGrade)
        Me.pcGradesContainer.Controls.Add(Me.txtSubjectGrade)
        Me.pcGradesContainer.Controls.Add(Me.TxtStudentId)
        Me.pcGradesContainer.Controls.Add(Me.lblStudentID)
        Me.pcGradesContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcGradesContainer.Location = New System.Drawing.Point(0, 0)
        Me.pcGradesContainer.Name = "pcGradesContainer"
        Me.pcGradesContainer.Size = New System.Drawing.Size(1287, 768)
        Me.pcGradesContainer.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.ImageOptions.SvgImage = Global.MDIStudentSystem.My.Resources.Resources.percentstyle
        Me.LabelControl1.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.LabelControl1.Location = New System.Drawing.Point(824, 457)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 25)
        Me.LabelControl1.TabIndex = 11
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
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"),DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Location = New System.Drawing.Point(518, 536)
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btnSave.MaximumSize = New System.Drawing.Size(250, 43)
        Me.btnSave.MinimumSize = New System.Drawing.Size(250, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(250, 43)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        '
        'FixedImage
        '
        Me.FixedImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.FixedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FixedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FixedImage.Image = CType(resources.GetObject("FixedImage.Image"),System.Drawing.Image)
        Me.FixedImage.Location = New System.Drawing.Point(570, 70)
        Me.FixedImage.MaximumSize = New System.Drawing.Size(100, 100)
        Me.FixedImage.MinimumSize = New System.Drawing.Size(100, 100)
        Me.FixedImage.Name = "FixedImage"
        Me.FixedImage.Size = New System.Drawing.Size(100, 100)
        Me.FixedImage.TabIndex = 10
        Me.FixedImage.TabStop = false
        '
        'cbSubjectName
        '
        Me.cbSubjectName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.cbSubjectName.EditValue = "Select Subject Name"
        Me.cbSubjectName.Location = New System.Drawing.Point(468, 271)
        Me.cbSubjectName.MaximumSize = New System.Drawing.Size(350, 30)
        Me.cbSubjectName.MinimumSize = New System.Drawing.Size(350, 30)
        Me.cbSubjectName.Name = "cbSubjectName"
        Me.cbSubjectName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbSubjectName.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!)
        Me.cbSubjectName.Properties.Appearance.Options.UseFont = true
        Me.cbSubjectName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSubjectName.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cbSubjectName.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cbSubjectName.Properties.Items.AddRange(New Object() {"Arabic", "Chemistry", "English", "Math"})
        Me.cbSubjectName.Properties.PopupDisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.cbSubjectName.Properties.Sorted = true
        Me.cbSubjectName.Size = New System.Drawing.Size(350, 28)
        Me.cbSubjectName.TabIndex = 1
        '
        'txtPercent
        '
        Me.txtPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.txtPercent.Enabled = false
        Me.txtPercent.Location = New System.Drawing.Point(468, 455)
        Me.txtPercent.MaximumSize = New System.Drawing.Size(350, 30)
        Me.txtPercent.MinimumSize = New System.Drawing.Size(350, 30)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPercent.Properties.Appearance.Options.UseFont = true
        Me.txtPercent.Properties.BeepOnError = false
        Me.txtPercent.Properties.DisplayFormat.FormatString = "f2p"
        Me.txtPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPercent.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtPercent.Properties.MaskSettings.Set("hideInsignificantZeros", Nothing)
        Me.txtPercent.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txtPercent.Properties.MaskSettings.Set("mask", "f")
        Me.txtPercent.Properties.UseMaskAsDisplayFormat = true
        Me.txtPercent.Size = New System.Drawing.Size(350, 28)
        Me.txtPercent.TabIndex = 4
        '
        'txtStudentGrade
        '
        Me.txtStudentGrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.txtStudentGrade.Enabled = false
        Me.txtStudentGrade.Location = New System.Drawing.Point(468, 393)
        Me.txtStudentGrade.MaximumSize = New System.Drawing.Size(350, 30)
        Me.txtStudentGrade.MinimumSize = New System.Drawing.Size(250, 30)
        Me.txtStudentGrade.Name = "txtStudentGrade"
        Me.txtStudentGrade.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtStudentGrade.Properties.Appearance.Options.UseFont = true
        Me.txtStudentGrade.Properties.BeepOnError = false
        Me.txtStudentGrade.Properties.DisplayFormat.FormatString = "f2"
        Me.txtStudentGrade.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtStudentGrade.Properties.MaskSettings.Set("mask", "f")
        Me.txtStudentGrade.Size = New System.Drawing.Size(350, 28)
        Me.txtStudentGrade.TabIndex = 3
        '
        'txtSubjectGrade
        '
        Me.txtSubjectGrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.txtSubjectGrade.Location = New System.Drawing.Point(468, 331)
        Me.txtSubjectGrade.MaximumSize = New System.Drawing.Size(350, 30)
        Me.txtSubjectGrade.MinimumSize = New System.Drawing.Size(350, 30)
        Me.txtSubjectGrade.Name = "txtSubjectGrade"
        Me.txtSubjectGrade.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSubjectGrade.Properties.Appearance.Options.UseFont = true
        Me.txtSubjectGrade.Properties.BeepOnError = false
        Me.txtSubjectGrade.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtSubjectGrade.Properties.MaskSettings.Set("mask", "d")
        Me.txtSubjectGrade.Properties.MaskSettings.Set("autoHideDecimalSeparator", true)
        Me.txtSubjectGrade.Properties.MaskSettings.Set("hideInsignificantZeros", true)
        Me.txtSubjectGrade.Properties.UseMaskAsDisplayFormat = true
        Me.txtSubjectGrade.Size = New System.Drawing.Size(350, 28)
        Me.txtSubjectGrade.TabIndex = 2
        '
        'TxtStudentId
        '
        Me.TxtStudentId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.TxtStudentId.Location = New System.Drawing.Point(468, 209)
        Me.TxtStudentId.MaximumSize = New System.Drawing.Size(350, 30)
        Me.TxtStudentId.MinimumSize = New System.Drawing.Size(350, 30)
        Me.TxtStudentId.Name = "TxtStudentId"
        Me.TxtStudentId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TxtStudentId.Properties.Appearance.Font = New System.Drawing.Font("Dexef", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtStudentId.Properties.Appearance.Options.UseFont = true
        Me.TxtStudentId.Properties.BeepOnError = false
        Me.TxtStudentId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtStudentId.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.TxtStudentId.Properties.MaskSettings.Set("mask", "d")
        Me.TxtStudentId.Properties.MaskSettings.Set("autoHideDecimalSeparator", true)
        Me.TxtStudentId.Properties.MaskSettings.Set("hideInsignificantZeros", true)
        Me.TxtStudentId.Properties.UseMaskAsDisplayFormat = true
        Me.TxtStudentId.Size = New System.Drawing.Size(350, 28)
        Me.TxtStudentId.TabIndex = 0
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.StudentModelBindingSource
        '
        'StudentModelBindingSource
        '
        Me.StudentModelBindingSource.DataSource = GetType(MDIStudentSystem.Models.StudentModel)
        '
        'XFrmStudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 768)
        Me.Controls.Add(Me.pcGradesContainer)
        Me.IconOptions.Image = Global.MDIStudentSystem.My.Resources.Resources.icons8_school_40
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(1289, 808)
        Me.MinimumSize = New System.Drawing.Size(1289, 808)
        Me.Name = "XFrmStudentGrades"
        Me.Text = "Student Grades"
        CType(Me.pcGradesContainer,System.ComponentModel.ISupportInitialize).EndInit
        Me.pcGradesContainer.ResumeLayout(false)
        Me.pcGradesContainer.PerformLayout
        CType(Me.FixedImage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbSubjectName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPercent.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtStudentGrade.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSubjectGrade.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtStudentId.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ErrorProvider,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StudentModelBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents lblStudentID As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblStudentGrade As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblSubjectGradePercent As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblSubjectGrade As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblSubjectName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents pcGradesContainer As DevExpress.XtraEditors.PanelControl
        Friend WithEvents cbSubjectName As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents TxtStudentId As DevExpress.XtraEditors.TextEdit
        Friend WithEvents FixedImage As CircularPictureBox
        Friend WithEvents txtPercent As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtStudentGrade As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtSubjectGrade As DevExpress.XtraEditors.TextEdit
        Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents ErrorProvider As ErrorProvider
        Friend WithEvents StudentModelBindingSource As BindingSource
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End NameSpace
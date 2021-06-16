Namespace Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class StudentsReports
        Inherits DevExpress.XtraReports.UI.XtraReport

        'XtraReport overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Designer
        'It can be modified using the Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentsReports))
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle3 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrStudentGrades = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape3 = New DevExpress.XtraReports.UI.XRShape()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrStudentGrades,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 96!
        Me.TopMargin.HeightF = 7!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 96!
        Me.BottomMargin.HeightF = 5.470801!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrStudentGrades, Me.XrLabel10, Me.XrShape3})
        Me.Detail.Dpi = 96!
        Me.Detail.HeightF = 269.6!
        Me.Detail.HierarchyPrintOptions.Indent = 19.2!
        Me.Detail.Name = "Detail"
        '
        'XrStudentGrades
        '
        Me.XrStudentGrades.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrStudentGrades.BorderWidth = 1!
        Me.XrStudentGrades.Dpi = 96!
        Me.XrStudentGrades.Font = New System.Drawing.Font("Dexef", 11!, System.Drawing.FontStyle.Bold)
        Me.XrStudentGrades.LocationFloat = New DevExpress.Utils.PointFloat(101.04!, 67.27998!)
        Me.XrStudentGrades.Name = "XrStudentGrades"
        Me.XrStudentGrades.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrStudentGrades.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrStudentGrades.SizeF = New System.Drawing.SizeF(528.3201!, 62.39999!)
        Me.XrStudentGrades.StylePriority.UseBorders = false
        Me.XrStudentGrades.StylePriority.UseBorderWidth = false
        Me.XrStudentGrades.StylePriority.UseFont = false
        Me.XrStudentGrades.StylePriority.UseTextAlignment = false
        Me.XrStudentGrades.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow1.Dpi = 96!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.Gray
        Me.XrTableCell1.Dpi = 96!
        Me.XrTableCell1.Multiline = true
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = false
        Me.XrTableCell1.Text = "Subject"
        Me.XrTableCell1.Weight = 1.2994793037780403R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.Gray
        Me.XrTableCell2.Dpi = 96!
        Me.XrTableCell2.Multiline = true
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = false
        Me.XrTableCell2.Text = "Subject Grade"
        Me.XrTableCell2.Weight = 1R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.Gray
        Me.XrTableCell3.Dpi = 96!
        Me.XrTableCell3.Multiline = true
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = false
        Me.XrTableCell3.Text = "Student Grade"
        Me.XrTableCell3.Weight = 1R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.Gray
        Me.XrTableCell4.Dpi = 96!
        Me.XrTableCell4.Multiline = true
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = false
        Me.XrTableCell4.Text = "Percent"
        Me.XrTableCell4.Weight = 1R
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.BorderWidth = 2!
        Me.XrLabel10.Dpi = 96!
        Me.XrLabel10.Font = New System.Drawing.Font("Dexef", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.MediumBlue
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(310.4!, 10!)
        Me.XrLabel10.Multiline = true
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(109.6!, 34.08001!)
        Me.XrLabel10.StylePriority.UseBorders = false
        Me.XrLabel10.StylePriority.UseBorderWidth = false
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.StylePriority.UseForeColor = false
        Me.XrLabel10.StylePriority.UseTextAlignment = false
        Me.XrLabel10.Text = "درجات الطالب"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrShape3
        '
        Me.XrShape3.BorderWidth = 1!
        Me.XrShape3.Dpi = 96!
        Me.XrShape3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10!)
        Me.XrShape3.Name = "XrShape3"
        Me.XrShape3.Shape = ShapeRectangle1
        Me.XrShape3.SizeF = New System.Drawing.SizeF(732!, 259.6!)
        Me.XrShape3.StylePriority.UseBorderWidth = false
        '
        'ReportHeader
        '
        Me.ReportHeader.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
        Me.ReportHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.ReportHeader.BorderWidth = 1!
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrPictureBox1, Me.XrLabel1, Me.XrShape1})
        Me.ReportHeader.Dpi = 96!
        Me.ReportHeader.HeightF = 128.56!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseBorderDashStyle = false
        Me.ReportHeader.StylePriority.UseBorders = false
        Me.ReportHeader.StylePriority.UseBorderWidth = false
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 96!
        Me.XrLabel4.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(534.8!, 66.4!)
        Me.XrLabel4.Multiline = true
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(171.2001!, 26.08!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "إدارة بركة السبع التعليمة"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 96!
        Me.XrLabel3.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(534.8!, 29.91999!)
        Me.XrLabel3.Multiline = true
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(171.2001!, 26.08!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "مدرسة كفرهلال الثانوية"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 96!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 10!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(26!, 92.48!)
        Me.XrLabel2.Multiline = true
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(96!, 19.2!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "School Logo"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 96!
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(26!, 9.6!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(96!, 82.88!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 96!
        Me.XrLabel1.Font = New System.Drawing.Font("Dexef", 20!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(260.8!, 67.2!)
        Me.XrLabel1.Multiline = true
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(208.8!, 44.48001!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "بيان درجات الطلاب"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrShape1
        '
        Me.XrShape1.Dpi = 96!
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle2
        Me.XrShape1.SizeF = New System.Drawing.SizeF(732!, 121.48!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrPictureBox2, Me.XrShape2})
        Me.PageHeader.Dpi = 96!
        Me.PageHeader.HeightF = 193.76!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseTextAlignment = false
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 96!
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Birthdate]")})
        Me.XrLabel14.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Blue
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(270.0002!, 126.48!)
        Me.XrLabel14.Multiline = true
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(169.6!, 22.88002!)
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.StylePriority.UseForeColor = false
        Me.XrLabel14.StylePriority.UseTextAlignment = false
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel14.TextFormatString = "{0:d}"
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 96!
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")})
        Me.XrLabel13.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Blue
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(270.0002!, 92.08003!)
        Me.XrLabel13.Multiline = true
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(298.4!, 22.88!)
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.StylePriority.UseForeColor = false
        Me.XrLabel13.StylePriority.UseTextAlignment = false
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 96!
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LastName]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Blue
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(366.0002!, 57.68003!)
        Me.XrLabel12.Multiline = true
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(96!, 22.88!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseForeColor = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 96!
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FirstName]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Blue
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(270.0002!, 57.68003!)
        Me.XrLabel11.Multiline = true
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(96!, 22.88!)
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.StylePriority.UseForeColor = false
        Me.XrLabel11.StylePriority.UseTextAlignment = false
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.BorderWidth = 2!
        Me.XrLabel9.Dpi = 96!
        Me.XrLabel9.Font = New System.Drawing.Font("Dexef", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.MediumBlue
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(310.4!, 0!)
        Me.XrLabel9.Multiline = true
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(109.6!, 34.08001!)
        Me.XrLabel9.StylePriority.UseBorders = false
        Me.XrLabel9.StylePriority.UseBorderWidth = false
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.StylePriority.UseForeColor = false
        Me.XrLabel9.StylePriority.UseTextAlignment = false
        Me.XrLabel9.Text = "بيانات الطالب"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 96!
        Me.XrLabel8.Font = New System.Drawing.Font("Dexef", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(152.4!, 160.88!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(117.6002!, 22.88!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "Status :"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 96!
        Me.XrLabel7.Font = New System.Drawing.Font("Dexef", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(152.4!, 126.48!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(117.6002!, 22.88!)
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "Birthdate :"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 96!
        Me.XrLabel6.Font = New System.Drawing.Font("Dexef", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(152.4!, 92.08003!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(117.6002!, 22.88!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "Email Address :"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 96!
        Me.XrLabel5.Font = New System.Drawing.Font("Dexef", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(152.4!, 57.68003!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(108.32!, 22.88001!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        Me.XrLabel5.Text = "Full Name :"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrPictureBox2.BorderWidth = 1!
        Me.XrPictureBox2.Dpi = 96!
        Me.XrPictureBox2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Image]")})
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(Global.MDIStudentSystem.My.Resources.Resources.icons8_student_male_100, true)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(10!, 10!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(131.2!, 173.7601!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox2.StylePriority.UseBorders = false
        Me.XrPictureBox2.StylePriority.UseBorderWidth = false
        '
        'XrShape2
        '
        Me.XrShape2.Dpi = 96!
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrShape2.Name = "XrShape2"
        Me.XrShape2.Shape = ShapeRectangle3
        Me.XrShape2.SizeF = New System.Drawing.SizeF(732!, 193.76!)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrLabel15})
        Me.ReportFooter.Dpi = 96!
        Me.ReportFooter.HeightF = 96!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 96!
        Me.XrLabel16.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(25.99999!, 23.49448!)
        Me.XrLabel16.Multiline = true
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(171.2001!, 26.08!)
        Me.XrLabel16.StylePriority.UseFont = false
        Me.XrLabel16.StylePriority.UseTextAlignment = false
        Me.XrLabel16.Text = "توقيع مدير المدرسة"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 96!
        Me.XrLabel15.Font = New System.Drawing.Font("Dexef", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(534.8!, 23.49448!)
        Me.XrLabel15.Multiline = true
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(171.2001!, 26.08!)
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.StylePriority.UseTextAlignment = false
        Me.XrLabel15.Text = "توقيع مدير الكنترول"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Dpi = 96!
        Me.PageFooter.HeightF = 42.00921!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 96!
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(310.4!, 10.00002!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(96!, 22.08!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = false
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BackColor = System.Drawing.Color.White
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8})
        Me.XrTableRow2.Dpi = 96!
        Me.XrTableRow2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(160,Byte),Integer))
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBackColor = false
        Me.XrTableRow2.StylePriority.UseForeColor = false
        Me.XrTableRow2.Weight = 1R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell5.Dpi = 96!
        Me.XrTableCell5.Multiline = true
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = false
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.Weight = 1.2994793037780403R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell6.Dpi = 96!
        Me.XrTableCell6.Multiline = true
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = false
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.Weight = 1R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell7.Dpi = 96!
        Me.XrTableCell7.Multiline = true
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = false
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.Weight = 1R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell8.Dpi = 96!
        Me.XrTableCell8.Multiline = true
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = false
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.Weight = 1R
        '
        'StudentsReports
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.BorderWidth = 50!
        Me.Dpi = 96!
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(33, 29, 7, 5)
        Me.PageHeight = 1123
        Me.PageWidth = 794
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels
        Me.SnapGridSize = 12.5!
        Me.Version = "20.2"
        CType(Me.XrStudentGrades,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
        Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
        Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrStudentGrades As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrShape3 As DevExpress.XtraReports.UI.XRShape
        Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrShape2 As DevExpress.XtraReports.UI.XRShape
        Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
        Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End NameSpace
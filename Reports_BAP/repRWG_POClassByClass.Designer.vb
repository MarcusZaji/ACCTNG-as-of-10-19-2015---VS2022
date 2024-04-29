Partial Class repRWG_POClassByClass

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim CategoryScale1 As Telerik.Reporting.CategoryScale = New Telerik.Reporting.CategoryScale()
        Dim NumericalScale1 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.actualCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.actualYTDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.budgetCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.budgetYTDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCodeCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.actualDataTextBox = New Telerik.Reporting.TextBox()
        Me.budgetYTDDataTextBox = New Telerik.Reporting.TextBox()
        Me.actualYTDDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.budgetDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.CartesianCoordinateSystem2 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.GraphAxis4 = New Telerik.Reporting.GraphAxis()
        Me.GraphAxis3 = New Telerik.Reporting.GraphAxis()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000003576278687R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.actualCaptionTextBox, Me.actualYTDCaptionTextBox, Me.budgetCaptionTextBox, Me.budgetYTDCaptionTextBox, Me.fldDeptCodeCaptionTextBox, Me.TextBox4, Me.TextBox5})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'actualCaptionTextBox
        '
        Me.actualCaptionTextBox.CanGrow = True
        Me.actualCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9601597785949707R), Telerik.Reporting.Drawing.Unit.Inch(0.000079631805419921875R))
        Me.actualCaptionTextBox.Name = "actualCaptionTextBox"
        Me.actualCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999999523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.actualCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.actualCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.actualCaptionTextBox.StyleName = "Caption"
        Me.actualCaptionTextBox.Value = "PO"
        '
        'actualYTDCaptionTextBox
        '
        Me.actualYTDCaptionTextBox.CanGrow = True
        Me.actualYTDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.7001590728759766R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.actualYTDCaptionTextBox.Name = "actualYTDCaptionTextBox"
        Me.actualYTDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998426914215088R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.actualYTDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.actualYTDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.actualYTDCaptionTextBox.StyleName = "Caption"
        Me.actualYTDCaptionTextBox.Value = "PO YTD"
        '
        'budgetCaptionTextBox
        '
        Me.budgetCaptionTextBox.CanGrow = True
        Me.budgetCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5000801086425781R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.budgetCaptionTextBox.Name = "budgetCaptionTextBox"
        Me.budgetCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4600002765655518R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.budgetCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.budgetCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.budgetCaptionTextBox.StyleName = "Caption"
        Me.budgetCaptionTextBox.Value = ""
        '
        'budgetYTDCaptionTextBox
        '
        Me.budgetYTDCaptionTextBox.CanGrow = True
        Me.budgetYTDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7602386474609375R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.budgetYTDCaptionTextBox.Name = "budgetYTDCaptionTextBox"
        Me.budgetYTDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9398418664932251R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.budgetYTDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.budgetYTDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.budgetYTDCaptionTextBox.StyleName = "Caption"
        Me.budgetYTDCaptionTextBox.Value = "BUDGET YTD"
        '
        'fldDeptCodeCaptionTextBox
        '
        Me.fldDeptCodeCaptionTextBox.CanGrow = True
        Me.fldDeptCodeCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00003910064697265625R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCodeCaptionTextBox.Name = "fldDeptCodeCaptionTextBox"
        Me.fldDeptCodeCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5000011920928955R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCodeCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDeptCodeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCodeCaptionTextBox.StyleName = "Caption"
        Me.fldDeptCodeCaptionTextBox.Value = "CLASSIFICATION"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.900080680847168R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9398418664932251R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "FOREX"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.840001106262207R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998426914215088R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "FOREX YTD"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.24988202750682831R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox18})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039378803194267675R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(12.5R), Telerik.Reporting.Drawing.Unit.Inch(0.24984267354011536R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.139961242675781R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8998806476593018R), Telerik.Reporting.Drawing.Unit.Inch(0.24988201260566711R))
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "PageInfo"
        Me.TextBox18.Value = "Budget Actual Program (BAP)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.841927528381348R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.46007838845252991R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1})
        Me.reportHeader.Name = "reportHeader"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Format = "{0:MMMM}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039288403058890253R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1999607086181641R), Telerik.Reporting.Drawing.Unit.Inch(0.46007853746414185R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.StyleName = "Title"
        Me.TextBox1.Value = "= Fields.Bmonth"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40007948875427246R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.actualDataTextBox, Me.budgetYTDDataTextBox, Me.actualYTDDataTextBox, Me.fldDeptCodeDataTextBox, Me.budgetDataTextBox, Me.TextBox3, Me.TextBox2})
        Me.detail.Name = "detail"
        '
        'actualDataTextBox
        '
        Me.actualDataTextBox.CanGrow = True
        Me.actualDataTextBox.Format = "{0:N2}"
        Me.actualDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9601597785949707R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.actualDataTextBox.Name = "actualDataTextBox"
        Me.actualDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.actualDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.actualDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.actualDataTextBox.StyleName = "Data"
        Me.actualDataTextBox.Value = "=Fields.Actual + Fields.FActual"
        '
        'budgetYTDDataTextBox
        '
        Me.budgetYTDDataTextBox.CanGrow = True
        Me.budgetYTDDataTextBox.Format = "{0:N2}"
        Me.budgetYTDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7602391242980957R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.budgetYTDDataTextBox.Name = "budgetYTDDataTextBox"
        Me.budgetYTDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9398413896560669R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.budgetYTDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.budgetYTDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.budgetYTDDataTextBox.StyleName = "Data"
        Me.budgetYTDDataTextBox.Value = "=Fields.BudgetYTD"
        '
        'actualYTDDataTextBox
        '
        Me.actualYTDDataTextBox.CanGrow = True
        Me.actualYTDDataTextBox.Format = "{0:N2}"
        Me.actualYTDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.700160026550293R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.actualYTDDataTextBox.Name = "actualYTDDataTextBox"
        Me.actualYTDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998422145843506R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.actualYTDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.actualYTDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.actualYTDDataTextBox.StyleName = "Data"
        Me.actualYTDDataTextBox.Value = "=Fields.ActualYTD + Fields.FActualYTD"
        '
        'fldDeptCodeDataTextBox
        '
        Me.fldDeptCodeDataTextBox.CanGrow = True
        Me.fldDeptCodeDataTextBox.Format = ""
        Me.fldDeptCodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCodeDataTextBox.Name = "fldDeptCodeDataTextBox"
        Me.fldDeptCodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5000011920928955R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptCodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCodeDataTextBox.StyleName = "Data"
        Me.fldDeptCodeDataTextBox.Value = "=Fields.fldClassDesc"
        '
        'budgetDataTextBox
        '
        Me.budgetDataTextBox.CanGrow = True
        Me.budgetDataTextBox.Format = "{0:N2}"
        Me.budgetDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5000801086425781R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.budgetDataTextBox.Name = "budgetDataTextBox"
        Me.budgetDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4600002765655518R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.budgetDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.budgetDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.budgetDataTextBox.StyleName = "Data"
        Me.budgetDataTextBox.Value = "=Fields.Budget"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Format = "{0:N2}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.900081634521484R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9398413896560669R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "=Fields.ActualForex + Fields.FActualForex"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.840000152587891R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998422145843506R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.ActualYTDForex + Fields.FActualYTDForex"
        '
        'CartesianCoordinateSystem2
        '
        Me.CartesianCoordinateSystem2.Name = "CartesianCoordinateSystem2"
        Me.CartesianCoordinateSystem2.XAxis = Me.GraphAxis4
        Me.CartesianCoordinateSystem2.YAxis = Me.GraphAxis3
        '
        'GraphAxis4
        '
        Me.GraphAxis4.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis4.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis4.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis4.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis4.MinorGridLineStyle.Visible = False
        Me.GraphAxis4.Name = "GraphAxis4"
        Me.GraphAxis4.Scale = CategoryScale1
        '
        'GraphAxis3
        '
        Me.GraphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis3.MinorGridLineStyle.Visible = False
        Me.GraphAxis3.Name = "GraphAxis3"
        Me.GraphAxis3.Scale = NumericalScale1
        '
        'repRWG_POClassByClass
        '
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repRWG_POClassByClass"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule1.Style.Font.Name = "Tahoma"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule2.Style.Color = System.Drawing.Color.White
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Color = System.Drawing.Color.Black
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(15.03984546661377R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents actualCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents actualYTDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents budgetCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents budgetYTDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCodeCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents actualDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents actualYTDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents budgetDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents budgetYTDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents CartesianCoordinateSystem2 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents GraphAxis4 As Telerik.Reporting.GraphAxis
    Friend WithEvents GraphAxis3 As Telerik.Reporting.GraphAxis
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
End Class
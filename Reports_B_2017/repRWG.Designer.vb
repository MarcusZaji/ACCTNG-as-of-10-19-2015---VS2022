Partial Class repRWG2017

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim GraphGroup1 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup2 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup6 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup7 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphTitle1 As Telerik.Reporting.GraphTitle = New Telerik.Reporting.GraphTitle()
        Dim CategoryScale1 As Telerik.Reporting.CategoryScale = New Telerik.Reporting.CategoryScale()
        Dim CategoryScaleCrossAxisPosition1 As Telerik.Reporting.CategoryScaleCrossAxisPosition = New Telerik.Reporting.CategoryScaleCrossAxisPosition()
        Dim CategoryScaleCrossAxisPosition2 As Telerik.Reporting.CategoryScaleCrossAxisPosition = New Telerik.Reporting.CategoryScaleCrossAxisPosition()
        Dim NumericalScale1 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim NumericalScaleCrossAxisPosition1 As Telerik.Reporting.NumericalScaleCrossAxisPosition = New Telerik.Reporting.NumericalScaleCrossAxisPosition()
        Dim NumericalScale2 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim NumericalScaleCrossAxisPosition2 As Telerik.Reporting.NumericalScaleCrossAxisPosition = New Telerik.Reporting.NumericalScaleCrossAxisPosition()
        Dim NumericalScaleCrossAxisPosition3 As Telerik.Reporting.NumericalScaleCrossAxisPosition = New Telerik.Reporting.NumericalScaleCrossAxisPosition()
        Dim GraphGroup3 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup4 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup5 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim CategoryScale2 As Telerik.Reporting.CategoryScale = New Telerik.Reporting.CategoryScale()
        Dim NumericalScale3 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim CategoryScale3 As Telerik.Reporting.CategoryScale = New Telerik.Reporting.CategoryScale()
        Dim CategoryScaleCrossAxisPosition3 As Telerik.Reporting.CategoryScaleCrossAxisPosition = New Telerik.Reporting.CategoryScaleCrossAxisPosition()
        Dim CategoryScaleCrossAxisPosition4 As Telerik.Reporting.CategoryScaleCrossAxisPosition = New Telerik.Reporting.CategoryScaleCrossAxisPosition()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
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
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.Graph1 = New Telerik.Reporting.Graph()
        Me.CartesianCoordinateSystem1 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.GraphAxis2 = New Telerik.Reporting.GraphAxis()
        Me.GraphAxis1 = New Telerik.Reporting.GraphAxis()
        Me.CartesianCoordinateSystem3 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.GraphAxis6 = New Telerik.Reporting.GraphAxis()
        Me.BarSeries1 = New Telerik.Reporting.BarSeries()
        Me.BarSeries2 = New Telerik.Reporting.BarSeries()
        Me.LineSeries1 = New Telerik.Reporting.LineSeries()
        Me.LineSeries2 = New Telerik.Reporting.LineSeries()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.actualDataTextBox = New Telerik.Reporting.TextBox()
        Me.budgetYTDDataTextBox = New Telerik.Reporting.TextBox()
        Me.actualYTDDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.budgetDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.CartesianCoordinateSystem2 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.GraphAxis4 = New Telerik.Reporting.GraphAxis()
        Me.GraphAxis3 = New Telerik.Reporting.GraphAxis()
        Me.GraphAxis5 = New Telerik.Reporting.GraphAxis()
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
        Me.actualCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.900080680847168R), Telerik.Reporting.Drawing.Unit.Inch(0.000079631805419921875R))
        Me.actualCaptionTextBox.Name = "actualCaptionTextBox"
        Me.actualCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999999523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.actualCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.actualCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.actualCaptionTextBox.StyleName = "Caption"
        Me.actualCaptionTextBox.Value = "ACTUAL"
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
        Me.actualYTDCaptionTextBox.Value = "ACTUAL YTD"
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
        Me.budgetCaptionTextBox.Value = "= Parameters.Choice.Value + "" "" + ""BUDGET"""
        '
        'budgetYTDCaptionTextBox
        '
        Me.budgetYTDCaptionTextBox.CanGrow = True
        Me.budgetYTDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9601602554321289R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.budgetYTDCaptionTextBox.Name = "budgetYTDCaptionTextBox"
        Me.budgetYTDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9398418664932251R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.budgetYTDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.budgetYTDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.budgetYTDCaptionTextBox.StyleName = "Caption"
        Me.budgetYTDCaptionTextBox.Value = "= Parameters.Choice.Value + "" "" + ""BUDGET YTD"""
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
        Me.fldDeptCodeCaptionTextBox.Value = "DEPARTMENT"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.900079727172852R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
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
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.839998245239258R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998426914215088R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "FOREX YTD"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value"), New Telerik.Reporting.SqlDataSourceParameter("@Choice", System.Data.DbType.[String], "=Parameters.Choice.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_RWG"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
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
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(13.267502784729004R), Telerik.Reporting.Drawing.Unit.Inch(0.2498820573091507R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.267581939697266R), Telerik.Reporting.Drawing.Unit.Inch(0.0000393986701965332R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2323784828186035R), Telerik.Reporting.Drawing.Unit.Inch(0.24988201260566711R))
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
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.302043914794922R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(4.4999604225158691R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Graph1, Me.TextBox1})
        Me.reportHeader.Name = "reportHeader"
        '
        'Graph1
        '
        GraphGroup1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.fldDeptCode"))
        GraphGroup1.Name = "fldDeptCodeGroup"
        GraphGroup1.Sortings.Add(New Telerik.Reporting.Sorting("=Fields.fldDeptCode", Telerik.Reporting.SortDirection.Asc))
        GraphGroup2.Name = "categoryGroup"
        Me.Graph1.CategoryGroups.Add(GraphGroup1)
        Me.Graph1.CategoryGroups.Add(GraphGroup2)
        Me.Graph1.CoordinateSystems.Add(Me.CartesianCoordinateSystem1)
        Me.Graph1.CoordinateSystems.Add(Me.CartesianCoordinateSystem3)
        Me.Graph1.DataSource = Me.SqlDataSource1
        Me.Graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.Graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.46015739440917969R))
        Me.Graph1.Name = "Graph1"
        Me.Graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray
        Me.Graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.Graph1.Series.Add(Me.BarSeries1)
        Me.Graph1.Series.Add(Me.BarSeries2)
        Me.Graph1.Series.Add(Me.LineSeries1)
        Me.Graph1.Series.Add(Me.LineSeries2)
        GraphGroup6.Name = "seriesGroup"
        GraphGroup7.Name = "seriesGroup1"
        Me.Graph1.SeriesGroups.Add(GraphGroup6)
        Me.Graph1.SeriesGroups.Add(GraphGroup7)
        Me.Graph1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(16.399999618530273R), Telerik.Reporting.Drawing.Unit.Inch(4.0398030281066895R))
        Me.Graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.Graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.Graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.Graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        GraphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        GraphTitle1.Style.LineColor = System.Drawing.Color.LightGray
        GraphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        GraphTitle1.Text = ""
        Me.Graph1.Titles.Add(GraphTitle1)
        '
        'CartesianCoordinateSystem1
        '
        Me.CartesianCoordinateSystem1.Name = "CartesianCoordinateSystem1"
        Me.CartesianCoordinateSystem1.XAxis = Me.GraphAxis2
        Me.CartesianCoordinateSystem1.YAxis = Me.GraphAxis1
        '
        'GraphAxis2
        '
        Me.GraphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis2.MinorGridLineStyle.Visible = False
        Me.GraphAxis2.Name = "GraphAxis2"
        CategoryScaleCrossAxisPosition1.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.[Auto]
        CategoryScaleCrossAxisPosition2.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMaximum
        CategoryScale1.CrossAxisPositions.Add(CategoryScaleCrossAxisPosition1)
        CategoryScale1.CrossAxisPositions.Add(CategoryScaleCrossAxisPosition2)
        Me.GraphAxis2.Scale = CategoryScale1
        '
        'GraphAxis1
        '
        Me.GraphAxis1.LabelFormat = "{0:N2}"
        Me.GraphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis1.MinorGridLineStyle.Visible = False
        Me.GraphAxis1.Name = "GraphAxis1"
        NumericalScaleCrossAxisPosition1.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.[Auto]
        NumericalScaleCrossAxisPosition1.Value = 0.0R
        NumericalScale1.CrossAxisPositions.Add(NumericalScaleCrossAxisPosition1)
        Me.GraphAxis1.Scale = NumericalScale1
        '
        'CartesianCoordinateSystem3
        '
        Me.CartesianCoordinateSystem3.Name = "CartesianCoordinateSystem3"
        Me.CartesianCoordinateSystem3.XAxis = Me.GraphAxis2
        Me.CartesianCoordinateSystem3.YAxis = Me.GraphAxis6
        '
        'GraphAxis6
        '
        Me.GraphAxis6.LabelFormat = "{0:N2}"
        Me.GraphAxis6.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis6.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis6.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis6.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis6.MinorGridLineStyle.Visible = False
        Me.GraphAxis6.Name = "GraphAxis4"
        NumericalScaleCrossAxisPosition2.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.[Auto]
        NumericalScaleCrossAxisPosition2.Value = 0.0R
        NumericalScaleCrossAxisPosition3.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMaximum
        NumericalScaleCrossAxisPosition3.Value = 0.0R
        NumericalScale2.CrossAxisPositions.Add(NumericalScaleCrossAxisPosition2)
        NumericalScale2.CrossAxisPositions.Add(NumericalScaleCrossAxisPosition3)
        Me.GraphAxis6.Scale = NumericalScale2
        '
        'BarSeries1
        '
        GraphGroup3.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.fldDeptCode"))
        GraphGroup3.Name = "fldDeptCodeGroup"
        GraphGroup3.Sortings.Add(New Telerik.Reporting.Sorting("=Fields.fldDeptCode", Telerik.Reporting.SortDirection.Asc))
        Me.BarSeries1.CategoryGroup = GraphGroup3
        Me.BarSeries1.CoordinateSystem = Me.CartesianCoordinateSystem1
        Me.BarSeries1.DataPointLabel = "=Sum(Fields.Budget)"
        Me.BarSeries1.DataPointLabelStyle.Visible = False
        Me.BarSeries1.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.BarSeries1.DataPointStyle.Visible = True
        Me.BarSeries1.LegendItem.Style.LineColor = System.Drawing.Color.LightGray
        Me.BarSeries1.LegendItem.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.BarSeries1.LegendItem.Value = "'Sum(Budget)'"
        Me.BarSeries1.Name = "BarSeries1"
        GraphGroup4.Name = "seriesGroup"
        Me.BarSeries1.SeriesGroup = GraphGroup4
        Me.BarSeries1.Y = "=Sum(Fields.Budget)"
        '
        'BarSeries2
        '
        Me.BarSeries2.CategoryGroup = GraphGroup3
        Me.BarSeries2.CoordinateSystem = Me.CartesianCoordinateSystem1
        Me.BarSeries2.DataPointLabel = "=Sum(Fields.Actual)"
        Me.BarSeries2.DataPointLabelStyle.Visible = False
        Me.BarSeries2.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.BarSeries2.DataPointStyle.Visible = True
        Me.BarSeries2.LegendItem.Style.LineColor = System.Drawing.Color.LightGray
        Me.BarSeries2.LegendItem.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.BarSeries2.LegendItem.Value = "'Sum(Actual)'"
        Me.BarSeries2.Name = "BarSeries2"
        Me.BarSeries2.SeriesGroup = GraphGroup4
        Me.BarSeries2.Y = "=Sum(IsNull(Fields.Actual,0)) + Sum(Fields.FActual)"
        '
        'LineSeries1
        '
        Me.LineSeries1.CategoryGroup = GraphGroup3
        Me.LineSeries1.CoordinateSystem = Me.CartesianCoordinateSystem3
        Me.LineSeries1.DataPointLabel = "=Sum(Fields.BudgetYTD)"
        Me.LineSeries1.DataPointLabelStyle.Visible = False
        Me.LineSeries1.DataPointStyle.Visible = True
        Me.LineSeries1.LegendItem.Style.LineColor = System.Drawing.Color.LightGray
        Me.LineSeries1.LegendItem.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.LineSeries1.LegendItem.Value = "'Sum(BudgetYTD)'"
        Me.LineSeries1.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.LineSeries1.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50.0R)
        Me.LineSeries1.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.LineSeries1.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.LineSeries1.Name = "LineSeries1"
        GraphGroup5.Name = "seriesGroup1"
        Me.LineSeries1.SeriesGroup = GraphGroup5
        Me.LineSeries1.Size = Nothing
        Me.LineSeries1.Y = "=Sum(Fields.BudgetYTD)"
        '
        'LineSeries2
        '
        Me.LineSeries2.CategoryGroup = GraphGroup3
        Me.LineSeries2.CoordinateSystem = Me.CartesianCoordinateSystem3
        Me.LineSeries2.DataPointLabel = "=Sum(IsNull(Fields.ActualYTD,0) + Fields.FActualYTD)"
        Me.LineSeries2.DataPointLabelStyle.Visible = False
        Me.LineSeries2.DataPointStyle.Visible = True
        Me.LineSeries2.LegendItem.Style.LineColor = System.Drawing.Color.LightGray
        Me.LineSeries2.LegendItem.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.LineSeries2.LegendItem.Value = "'Sum(ActualYTD)'"
        Me.LineSeries2.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.LineSeries2.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50.0R)
        Me.LineSeries2.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.LineSeries2.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.LineSeries2.Name = "LineSeries2"
        Me.LineSeries2.SeriesGroup = GraphGroup5
        Me.LineSeries2.Size = Nothing
        Me.LineSeries2.Y = "=Sum(IsNull(Fields.ActualYTD,0) + Fields.FActualYTD)"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Format = "{0:N2}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9600801467895508R), Telerik.Reporting.Drawing.Unit.Inch(0.46003913879394531R))
        Me.TextBox1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.StyleName = "Title"
        Me.TextBox1.Value = "=Fields.Byear"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40007948875427246R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.actualDataTextBox, Me.budgetYTDDataTextBox, Me.actualYTDDataTextBox, Me.fldDeptCodeDataTextBox, Me.budgetDataTextBox, Me.TextBox2, Me.TextBox3})
        Me.detail.Name = "detail"
        '
        'actualDataTextBox
        '
        Me.actualDataTextBox.CanGrow = True
        Me.actualDataTextBox.Format = "{0:N2}"
        Me.actualDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.900080680847168R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.actualDataTextBox.Name = "actualDataTextBox"
        Me.actualDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.actualDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.actualDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.actualDataTextBox.StyleName = "Data"
        Me.actualDataTextBox.Value = "= IsNull(Fields.Actual,0) + Fields.FActual"
        '
        'budgetYTDDataTextBox
        '
        Me.budgetYTDDataTextBox.CanGrow = True
        Me.budgetYTDDataTextBox.Format = "{0:N2}"
        Me.budgetYTDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9601602554321289R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
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
        Me.actualYTDDataTextBox.Value = "= IsNull(Fields.ActualYTD,0) + Fields.FActualYTD"
        '
        'fldDeptCodeDataTextBox
        '
        Me.fldDeptCodeDataTextBox.CanGrow = True
        Me.fldDeptCodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCodeDataTextBox.Name = "fldDeptCodeDataTextBox"
        Me.fldDeptCodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5000011920928955R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptCodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCodeDataTextBox.StyleName = "Data"
        Me.fldDeptCodeDataTextBox.Value = "=Fields.fldDeptCode"
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
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.840000152587891R), Telerik.Reporting.Drawing.Unit.Inch(0.000078413220762740821R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998422145843506R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= IsNull(Fields.ForexYTD,0) + Fields.FActualYTDForex"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Format = "{0:N2}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.900080680847168R), Telerik.Reporting.Drawing.Unit.Inch(0.000078413220762740821R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9398413896560669R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "= IsNull(Fields.Forex,0) + Fields.FActualForex"
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
        Me.GraphAxis4.Scale = CategoryScale2
        '
        'GraphAxis3
        '
        Me.GraphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis3.MinorGridLineStyle.Visible = False
        Me.GraphAxis3.Name = "GraphAxis3"
        Me.GraphAxis3.Scale = NumericalScale3
        '
        'GraphAxis5
        '
        Me.GraphAxis5.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis5.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis5.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis5.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis5.MinorGridLineStyle.Visible = False
        Me.GraphAxis5.Name = "GraphAxis3"
        CategoryScaleCrossAxisPosition3.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.[Auto]
        CategoryScaleCrossAxisPosition4.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMaximum
        CategoryScale3.CrossAxisPositions.Add(CategoryScaleCrossAxisPosition3)
        CategoryScale3.CrossAxisPositions.Add(CategoryScaleCrossAxisPosition4)
        Me.GraphAxis5.Scale = CategoryScale3
        '
        'repRWG2017
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repRWG"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "D1"
        ReportParameter1.Text = "D1"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Name = "D2"
        ReportParameter2.Text = "D2"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "Choice"
        ReportParameter3.Text = "Choice"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(16.5R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
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
    Friend WithEvents Graph1 As Telerik.Reporting.Graph
    Friend WithEvents CartesianCoordinateSystem1 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents GraphAxis2 As Telerik.Reporting.GraphAxis
    Friend WithEvents GraphAxis1 As Telerik.Reporting.GraphAxis
    Friend WithEvents BarSeries1 As Telerik.Reporting.BarSeries
    Friend WithEvents BarSeries2 As Telerik.Reporting.BarSeries
    Friend WithEvents LineSeries1 As Telerik.Reporting.LineSeries
    Friend WithEvents LineSeries2 As Telerik.Reporting.LineSeries
    Friend WithEvents CartesianCoordinateSystem2 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents GraphAxis4 As Telerik.Reporting.GraphAxis
    Friend WithEvents GraphAxis3 As Telerik.Reporting.GraphAxis
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents CartesianCoordinateSystem3 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents GraphAxis5 As Telerik.Reporting.GraphAxis
    Friend WithEvents GraphAxis6 As Telerik.Reporting.GraphAxis
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
End Class
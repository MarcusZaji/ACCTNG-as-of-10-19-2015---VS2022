Partial Class rptDetailedReportInv
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.fldPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.7R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox23, Me.TextBox24})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Value = "Furukawa Electric Autoparts Philippines Inc."
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Value = "Investment Application Register"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.99R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPONoDataTextBox, Me.TextBox22, Me.TextBox25, Me.TextBox28, Me.TextBox32, Me.TextBox33, Me.TextBox36, Me.TextBox37, Me.SubReport1, Me.TextBox29})
        Me.detail.Name = "detail"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.409R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.fldPONoDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldPONoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldPONoDataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "= Fields.fldInvestmentNo"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Format = "{0:d}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.409R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.55R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "= Fields.fldDate"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.959R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.331R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "= Fields.fldProjTitle"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.107R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.441R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "= Fields.fldProdCostJPY"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Format = "{0:N2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.548R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.611R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox32.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox32.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Data"
        Me.TextBox32.Value = "= isnull(Fields.TotalPRAmount,0)"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Format = "{0:N2}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.159R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox33.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox33.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox33.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.StyleName = "Data"
        Me.TextBox33.Value = "=isnull(Fields.fldProdCostJPY,0) - isnull(Fields.TotalPRAmount,0)"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Format = "{0:d}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.459R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.341R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox36.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.StyleName = "Data"
        Me.TextBox36.Value = "= Fields.fldDateInstallation"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Format = "{0:d}"
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.8R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox37.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox37.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.StyleName = "Data"
        Me.TextBox37.Value = "= Fields.fldDateInstallation"
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("InvestmentNo", "= Fields.fldInvestmentNo"))
        InstanceReportSource1.ReportDocument = Nothing
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(18.0R), Telerik.Reporting.Drawing.Unit.Inch(0.052R))
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.292R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.816R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "= Fields.fldApprovedBudget"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@InvestmentNo", System.Data.DbType.[String], "= Parameters.InvestmentNo.Value"), New Telerik.Reporting.SqlDataSourceParameter("@Dept", System.Data.DbType.[String], "= Parameters.Dept.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_SelectInvestmentPerInvNoDeptv2"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.338R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.8R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox38.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox38.Style.Color = System.Drawing.Color.White
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox38.StyleName = "Caption"
        Me.TextBox38.Value = "Target Date of completion for construction / Installation"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.461R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.339R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox35.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox35.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox35.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox35.Style.Color = System.Drawing.Color.White
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.StyleName = "Caption"
        Me.TextBox35.Value = "Target Date of Start of Construction , Installation or delivery"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.161R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox34.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox34.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox34.Style.Color = System.Drawing.Color.White
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.StyleName = "Caption"
        Me.TextBox34.Value = "Balance"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.548R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.612R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox31.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox31.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox31.Style.Color = System.Drawing.Color.White
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.StyleName = "Caption"
        Me.TextBox31.Value = "PR Amount"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.291R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.816R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox30.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox30.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox30.Style.Color = System.Drawing.Color.White
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.StyleName = "Caption"
        Me.TextBox30.Value = "Approved Budget"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.107R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.441R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox27.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox27.Style.Color = System.Drawing.Color.White
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.StyleName = "Caption"
        Me.TextBox27.Value = "Estimated amount of Investment"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.959R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.331R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox26.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox26.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox26.Style.Color = System.Drawing.Color.White
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.StyleName = "Caption"
        Me.TextBox26.Value = "Full Description of the Project"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.409R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.55R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox21.Style.Color = System.Drawing.Color.White
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.StyleName = "Caption"
        Me.TextBox21.Value = "Date Applied"
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.409R), Telerik.Reporting.Drawing.Unit.Inch(0.41R))
        Me.fldPONoCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.fldPONoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldPONoCaptionTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.fldPONoCaptionTextBox.Style.Color = System.Drawing.Color.White
        Me.fldPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.fldPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoCaptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "Investment Application No."
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.41R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPONoCaptionTextBox, Me.TextBox35, Me.TextBox34, Me.TextBox31, Me.TextBox27, Me.TextBox26, Me.TextBox21, Me.TextBox38, Me.TextBox30})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        '
        'rptDetailedReportInv
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1, Me.ReportHeaderSection1})
        Me.Name = "rptDetailedReportInv"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "InvestmentNo"
        ReportParameter1.Text = "InvestmentNo"
        ReportParameter2.Name = "Dept"
        ReportParameter2.Text = "Dept"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Corporate.TableNormal")})
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableBody")})
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableHeader")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.White
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(18.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    ' Friend WithEvents RptDetailedReportInvChild1 As ACCTNG.rptDetailedReportInvChild
End Class
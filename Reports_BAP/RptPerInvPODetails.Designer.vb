Partial Class RptPerInvPODetails

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
        Me.RptPerInvPODetailsC1 = New ACCTNG.RptPerInvPODetailsC()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.fldPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.fldPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        CType(Me.RptPerInvPODetailsC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'RptPerInvPODetailsC1
        '
        Me.RptPerInvPODetailsC1.Name = "RptPerInvPODetailsC"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox24, Me.TextBox23})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.20011806488037109R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9229116439819336R), Telerik.Reporting.Drawing.Unit.Inch(0.19999998807907104R))
        Me.TextBox24.Value = "Investment Application Register"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9229116439819336R), Telerik.Reporting.Drawing.Unit.Inch(0.19999998807907104R))
        Me.TextBox23.Value = "Furukawa Electric Autoparts Philippines Inc."
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.70265740156173706R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox29, Me.TextBox37, Me.TextBox36, Me.TextBox33, Me.TextBox32, Me.TextBox28, Me.TextBox39, Me.fldPONoDataTextBox, Me.TextBox40, Me.TextBox43, Me.TextBox44, Me.SubReport1})
        Me.detail.Name = "detail"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2895073890686035R), Telerik.Reporting.Drawing.Unit.Inch(0.000118255615234375R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8155468702316284R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox29.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "= Fields.fldApprovedBudget"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Format = "{0:d}"
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.713132858276367R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999201774597168R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox37.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox37.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.StyleName = "Data"
        Me.TextBox37.Value = "= Fields.fldDateInstallation"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Format = "{0:d}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.372432708740234R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3406219482421875R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox36.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox36.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.StyleName = "Data"
        Me.TextBox36.Value = "= Fields.fldDateInstallation"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Format = "{0:N2}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.158415794372559R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox33.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox33.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox33.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.StyleName = "Data"
        Me.TextBox33.Value = "=isnull(Fields.fldProdCostJPY,0) - isnull(Fields.POYen,0)"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Format = "{0:N2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.54583740234375R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6124998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox32.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox32.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Data"
        Me.TextBox32.Value = "=Fields.POYen"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.105133056640625R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4406256675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox28.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "= Fields.fldProdCostJPY"
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.958176851272583R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3312516212463379R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox39.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox39.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox39.StyleName = "Data"
        Me.TextBox39.Value = "= Fields.fldProjTitle"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4093749523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.fldPONoDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldPONoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldPONoDataTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "= Fields.fldInvestmentNo"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Format = "{0:d}"
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4094536304473877R), Telerik.Reporting.Drawing.Unit.Inch(0.000118255615234375R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5486441850662231R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox40.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox40.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox40.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox40.StyleName = "Data"
        Me.TextBox40.Value = "= Fields.fldDate"
        '
        'TextBox43
        '
        Me.TextBox43.CanGrow = True
        Me.TextBox43.Format = "{0:N2}"
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.45849609375R), Telerik.Reporting.Drawing.Unit.Inch(0.000118255615234375R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6124998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox43.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox43.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.StyleName = "Data"
        Me.TextBox43.Value = "=Fields.POOrg"
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Format = "{0:N2}"
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.071075439453125R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Inch(0.65037697553634644R))
        Me.TextBox44.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox44.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox44.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox44.StyleName = "Data"
        Me.TextBox44.Value = "=isnull(Fields.fldProdCostJPY,0) - isnull(Fields.POOrg,0)"
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.65057402849197388R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("InvNo", "=Fields.fldInvestmentNo"))
        InstanceReportSource1.ReportDocument = Me.RptPerInvPODetailsC1
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(20.91301155090332R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833358168602R))
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.299999862909317R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40984264016151428R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox26, Me.TextBox38, Me.TextBox25, Me.TextBox30, Me.TextBox27, Me.TextBox31, Me.TextBox34, Me.TextBox35, Me.fldPONoCaptionTextBox, Me.TextBox42, Me.TextBox41})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9594528675079346R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3312516212463379R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
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
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.712696075439453R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123R), Telerik.Reporting.Drawing.Unit.Inch(0.40984240174293518R))
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
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4094536304473877R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5499202013015747R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox25.Style.Color = System.Drawing.Color.White
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.StyleName = "Caption"
        Me.TextBox25.Value = "Date Applied"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2907834053039551R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8155468702316284R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
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
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1064090728759766R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4406256675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
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
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.547114372253418R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6124998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
        Me.TextBox31.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox31.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox31.Style.Color = System.Drawing.Color.White
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.StyleName = "Caption"
        Me.TextBox31.Value = "PO Amount Yen"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.159693717956543R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
        Me.TextBox34.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox34.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox34.Style.Color = System.Drawing.Color.White
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.StyleName = "Caption"
        Me.TextBox34.Value = "Balance Yen"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.372432708740234R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3393440246582031R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
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
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4093749523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
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
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.459774017333984R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6124998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
        Me.TextBox42.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox42.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox42.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox42.Style.Color = System.Drawing.Color.White
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox42.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox42.StyleName = "Caption"
        Me.TextBox42.Value = "PO Amount Org"
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = True
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.072352409362793R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000015020370483R), Telerik.Reporting.Drawing.Unit.Inch(0.40984255075454712R))
        Me.TextBox41.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox41.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.TextBox41.Style.Color = System.Drawing.Color.White
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.StyleName = "Caption"
        Me.TextBox41.Value = "Balance Org"
        '
        'RptPerInvPODetails
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1, Me.ReportHeaderSection1})
        Me.Name = "RptPerInvPODetails"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "InvestmentNo"
        ReportParameter1.Text = "InvestmentNo"
        ReportParameter2.Name = "Dept"
        ReportParameter2.Text = "Dept"
        ReportParameter2.Value = ""
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(20.913053512573242R)
        CType(Me.RptPerInvPODetailsC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents RptPerInvPODetailsC1 As ACCTNG.RptPerInvPODetailsC
End Class
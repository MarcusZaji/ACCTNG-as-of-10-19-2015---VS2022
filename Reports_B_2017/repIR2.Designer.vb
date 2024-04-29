Partial Class repIR22017

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.RepIR_Sub1 = New ACCTNG.repIR_Sub()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.txtTNC = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.txtApprvBy = New Telerik.Reporting.TextBox()
        Me.txtChkBy = New Telerik.Reporting.TextBox()
        Me.txtPrepBy = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.txtDD = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.PONo = New Telerik.Reporting.TextBox()
        Me.txtPRNo = New Telerik.Reporting.TextBox()
        Me.txtOPOCNo = New Telerik.Reporting.TextBox()
        Me.txtATTN = New Telerik.Reporting.TextBox()
        Me.txtTINNo = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.txtSupName = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me.RepIR_Sub1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'RepIR_Sub1
        '
        Me.RepIR_Sub1.Name = "repOrderItem"
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.680000901222229R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0900000333786011R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtTNC, Me.TextBox15, Me.TextBox13, Me.TextBox14, Me.TextBox2, Me.TextBox9, Me.txtApprvBy, Me.txtChkBy, Me.txtPrepBy})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'txtTNC
        '
        Me.txtTNC.CanGrow = False
        Me.txtTNC.Format = "{0:N2}"
        Me.txtTNC.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4376578330993652R), Telerik.Reporting.Drawing.Unit.Inch(0.081806182861328125R))
        Me.txtTNC.Name = "txtTNC"
        Me.txtTNC.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8623427152633667R), Telerik.Reporting.Drawing.Unit.Inch(0.28117117285728455R))
        Me.txtTNC.Style.Font.Name = "Times New Roman"
        Me.txtTNC.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtTNC.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtTNC.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtTNC.Style.Visible = True
        Me.txtTNC.StyleName = "Data"
        Me.txtTNC.Value = ""
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.31023645401001R), Telerik.Reporting.Drawing.Unit.Inch(0.36305618286132813R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9897645711898804R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox15.Style.Color = System.Drawing.Color.Black
        Me.TextBox15.Style.Font.Name = "Times New Roman"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox15.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.Visible = True
        Me.TextBox15.StyleName = "Caption"
        Me.TextBox15.Value = ""
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0376577377319336R), Telerik.Reporting.Drawing.Unit.Inch(0.081806182861328125R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595R), Telerik.Reporting.Drawing.Unit.Inch(0.28117102384567261R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox13.Style.Color = System.Drawing.Color.Black
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Name = "Times New Roman"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox13.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.Visible = False
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "TOTAL NEW COST"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1601576805114746R), Telerik.Reporting.Drawing.Unit.Inch(0.36305618286132813R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1499998569488525R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox14.Style.Color = System.Drawing.Color.Black
        Me.TextBox14.Style.Font.Name = "Times New Roman"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox14.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.Visible = True
        Me.TextBox14.StyleName = "Caption"
        Me.TextBox14.Value = ""
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2100787162780762R), Telerik.Reporting.Drawing.Unit.Inch(0.36305618286132813R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9499999284744263R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox2.Style.Color = System.Drawing.Color.Black
        Me.TextBox2.Style.Font.Name = "Times New Roman"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox2.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.Visible = True
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = ""
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.26000002026557922R), Telerik.Reporting.Drawing.Unit.Inch(0.36305618286132813R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9500000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox9.Style.Color = System.Drawing.Color.Black
        Me.TextBox9.Style.Font.Name = "Times New Roman"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox9.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.Visible = True
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = ""
        '
        'txtApprvBy
        '
        Me.txtApprvBy.CanGrow = False
        Me.txtApprvBy.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4001579284667969R), Telerik.Reporting.Drawing.Unit.Inch(0.8125R))
        Me.txtApprvBy.Name = "txtApprvBy"
        Me.txtApprvBy.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1500000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.27000001072883606R))
        Me.txtApprvBy.Style.Font.Name = "Times New Roman"
        Me.txtApprvBy.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtApprvBy.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtApprvBy.Style.Visible = True
        Me.txtApprvBy.StyleName = "Data"
        Me.txtApprvBy.Value = ""
        '
        'txtChkBy
        '
        Me.txtChkBy.CanGrow = False
        Me.txtChkBy.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4500789642333984R), Telerik.Reporting.Drawing.Unit.Inch(0.8125R))
        Me.txtChkBy.Name = "txtChkBy"
        Me.txtChkBy.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9500000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.27000001072883606R))
        Me.txtChkBy.Style.Font.Name = "Times New Roman"
        Me.txtChkBy.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtChkBy.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtChkBy.Style.Visible = True
        Me.txtChkBy.StyleName = "Data"
        Me.txtChkBy.Value = ""
        '
        'txtPrepBy
        '
        Me.txtPrepBy.CanGrow = False
        Me.txtPrepBy.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.81000000238418579R))
        Me.txtPrepBy.Name = "txtPrepBy"
        Me.txtPrepBy.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9500000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.27000001072883606R))
        Me.txtPrepBy.Style.Font.Name = "Times New Roman"
        Me.txtPrepBy.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtPrepBy.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtPrepBy.Style.Visible = True
        Me.txtPrepBy.StyleName = "Data"
        Me.txtPrepBy.Value = ""
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.detail.Name = "detail"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.5R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox16})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = False
        Me.TextBox16.Format = "{0:d}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(1.2799606323242187R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2199999988079071R))
        Me.TextBox16.Style.Font.Name = "Times New Roman"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.Visible = True
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "=NOW()"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(3.2300000190734863R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.SubReport1, Me.txtDD, Me.TextBox17, Me.PONo, Me.txtPRNo, Me.txtOPOCNo, Me.txtATTN, Me.txtTINNo, Me.TextBox11, Me.txtSupName, Me.TextBox10, Me.TextBox1})
        Me.reportHeader.Name = "reportHeader"
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.80000007152557373R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("CPONo", "=Parameters.par_CPONo.Value"))
        InstanceReportSource1.ReportDocument = Me.RepIR_Sub1
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.4999995231628418R), Telerik.Reporting.Drawing.Unit.Inch(2.3999216556549072R))
        '
        'txtDD
        '
        Me.txtDD.CanGrow = False
        Me.txtDD.Format = "{0:d}"
        Me.txtDD.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7708325386047363R), Telerik.Reporting.Drawing.Unit.Inch(0.54170608520507813R))
        Me.txtDD.Name = "txtDD"
        Me.txtDD.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999214887619019R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.txtDD.Style.Font.Name = "Times New Roman"
        Me.txtDD.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtDD.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtDD.Style.Visible = True
        Me.txtDD.StyleName = "Data"
        Me.txtDD.Value = ""
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3333333432674408R), Telerik.Reporting.Drawing.Unit.Inch(0.63541668653488159R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79999953508377075R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R))
        Me.TextBox17.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox17.Style.Font.Name = "Times New Roman"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox17.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox17.Style.Visible = True
        Me.TextBox17.StyleName = "Title"
        Me.TextBox17.Value = "ATTN No"
        '
        'PONo
        '
        Me.PONo.CanGrow = False
        Me.PONo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.30000114440918R), Telerik.Reporting.Drawing.Unit.Inch(0.63378942012786865R))
        Me.PONo.Name = "PONo"
        Me.PONo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15841208398342133R))
        Me.PONo.Style.Font.Name = "Times New Roman"
        Me.PONo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.PONo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.PONo.Style.Visible = True
        Me.PONo.StyleName = "Data"
        Me.PONo.Value = ""
        '
        'txtPRNo
        '
        Me.txtPRNo.CanGrow = False
        Me.txtPRNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.39999982714653015R))
        Me.txtPRNo.Name = "txtPRNo"
        Me.txtPRNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99999994039535522R), Telerik.Reporting.Drawing.Unit.Inch(0.23371070623397827R))
        Me.txtPRNo.Style.Font.Name = "Times New Roman"
        Me.txtPRNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtPRNo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtPRNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtPRNo.Style.Visible = True
        Me.txtPRNo.StyleName = "Data"
        Me.txtPRNo.Value = ""
        '
        'txtOPOCNo
        '
        Me.txtOPOCNo.CanGrow = False
        Me.txtOPOCNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.txtOPOCNo.Name = "txtOPOCNo"
        Me.txtOPOCNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtOPOCNo.Style.Color = System.Drawing.Color.Transparent
        Me.txtOPOCNo.Style.Font.Name = "Times New Roman"
        Me.txtOPOCNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtOPOCNo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtOPOCNo.Style.Visible = True
        Me.txtOPOCNo.StyleName = "Data"
        Me.txtOPOCNo.Value = ""
        '
        'txtATTN
        '
        Me.txtATTN.CanGrow = False
        Me.txtATTN.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.64799565076828R))
        Me.txtATTN.Name = "txtATTN"
        Me.txtATTN.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999213695526123R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.txtATTN.Style.Font.Name = "Times New Roman"
        Me.txtATTN.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtATTN.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtATTN.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtATTN.Style.Visible = True
        Me.txtATTN.StyleName = "Data"
        Me.txtATTN.Value = ""
        '
        'txtTINNo
        '
        Me.txtTINNo.CanGrow = False
        Me.txtTINNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.49791675806045532R))
        Me.txtTINNo.Name = "txtTINNo"
        Me.txtTINNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999214887619019R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.txtTINNo.Style.Font.Name = "Times New Roman"
        Me.txtTINNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtTINNo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtTINNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtTINNo.Style.Visible = True
        Me.txtTINNo.StyleName = "Data"
        Me.txtTINNo.Value = ""
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3333333432674408R), Telerik.Reporting.Drawing.Unit.Inch(0.4895833432674408R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79999953508377075R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R))
        Me.TextBox11.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox11.Style.Font.Name = "Times New Roman"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox11.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox11.Style.Visible = True
        Me.TextBox11.StyleName = "Title"
        Me.TextBox11.Value = "TIN No"
        '
        'txtSupName
        '
        Me.txtSupName.CanGrow = False
        Me.txtSupName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164R), Telerik.Reporting.Drawing.Unit.Inch(0.18557436764240265R))
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.txtSupName.Style.Font.Bold = True
        Me.txtSupName.Style.Font.Name = "Times New Roman"
        Me.txtSupName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtSupName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtSupName.Style.Visible = True
        Me.txtSupName.StyleName = "Data"
        Me.txtSupName.Value = ""
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3333333432674408R), Telerik.Reporting.Drawing.Unit.Inch(0.0833333358168602R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.10216225683689117R))
        Me.TextBox10.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox10.Style.Font.Name = "Times New Roman"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox10.Style.Visible = True
        Me.TextBox10.StyleName = "Title"
        Me.TextBox10.Value = "Supplier's Name & Address"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7707548141479492R), Telerik.Reporting.Drawing.Unit.Inch(0.29999995231628418R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.19999991357326508R), Telerik.Reporting.Drawing.Unit.Inch(0.18000000715255737R))
        Me.TextBox1.Style.Font.Name = "Times New Roman"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.Visible = True
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "X"
        '
        'repIR22017
        '
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.reportHeader, Me.detail})
        Me.Name = "repIR2"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9.5R), Telerik.Reporting.Drawing.Unit.Inch(11.0R))
        ReportParameter1.Name = "par_CPONo"
        ReportParameter1.Text = "par_CPONo"
        Me.ReportParameters.Add(ReportParameter1)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(9.4000787734985352R)
        CType(Me.RepIR_Sub1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents txtDD As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents PONo As Telerik.Reporting.TextBox
    Friend WithEvents txtPRNo As Telerik.Reporting.TextBox
    Friend WithEvents txtOPOCNo As Telerik.Reporting.TextBox
    Friend WithEvents txtATTN As Telerik.Reporting.TextBox
    Friend WithEvents txtTINNo As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents txtSupName As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents txtPrepBy As Telerik.Reporting.TextBox
    Friend WithEvents txtChkBy As Telerik.Reporting.TextBox
    Friend WithEvents txtApprvBy As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents txtTNC As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents RepIR_Sub1 As ACCTNG.repIR_Sub
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class
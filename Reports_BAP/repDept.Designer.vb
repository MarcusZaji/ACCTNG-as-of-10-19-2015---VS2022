Partial Class repDept

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
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
        Me.aAWITHOUTBgtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.balanceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.onGoingOrderCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.aAWithBgtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.balanceDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptDataTextBox = New Telerik.Reporting.TextBox()
        Me.onGoingOrderDataTextBox = New Telerik.Reporting.TextBox()
        Me.aAWithBgtDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29984250664711R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40007886290550232R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.aAWITHOUTBgtCaptionTextBox, Me.balanceCaptionTextBox, Me.onGoingOrderCaptionTextBox, Me.fldDeptCaptionTextBox, Me.aAWithBgtCaptionTextBox, Me.TextBox3, Me.TextBox1, Me.TextBox5, Me.TextBox7, Me.TextBox9, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox25})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'aAWITHOUTBgtCaptionTextBox
        '
        Me.aAWITHOUTBgtCaptionTextBox.CanGrow = True
        Me.aAWITHOUTBgtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.116824150085449R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.aAWITHOUTBgtCaptionTextBox.Name = "aAWITHOUTBgtCaptionTextBox"
        Me.aAWITHOUTBgtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4666668176651R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.aAWITHOUTBgtCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.aAWITHOUTBgtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWITHOUTBgtCaptionTextBox.StyleName = "Caption"
        Me.aAWITHOUTBgtCaptionTextBox.Value = "ACT. ACQ. W/ BUDGET"
        '
        'balanceCaptionTextBox
        '
        Me.balanceCaptionTextBox.CanGrow = True
        Me.balanceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.583568572998047R), Telerik.Reporting.Drawing.Unit.Inch(0.2100788801908493R))
        Me.balanceCaptionTextBox.Name = "balanceCaptionTextBox"
        Me.balanceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9663921594619751R), Telerik.Reporting.Drawing.Unit.Inch(0.18992112576961517R))
        Me.balanceCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.balanceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.balanceCaptionTextBox.StyleName = "Caption"
        Me.balanceCaptionTextBox.Value = "BUDGET BALANCE  INCLUDING WITH BUDGET"
        '
        'onGoingOrderCaptionTextBox
        '
        Me.onGoingOrderCaptionTextBox.CanGrow = True
        Me.onGoingOrderCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2123417854309082R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.onGoingOrderCaptionTextBox.Name = "onGoingOrderCaptionTextBox"
        Me.onGoingOrderCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5291668176651R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.onGoingOrderCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.onGoingOrderCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.onGoingOrderCaptionTextBox.StyleName = "Caption"
        Me.onGoingOrderCaptionTextBox.Value = "PO WITHOUT BUDGET"
        '
        'fldDeptCaptionTextBox
        '
        Me.fldDeptCaptionTextBox.CanGrow = True
        Me.fldDeptCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.94317561388015747R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldDeptCaptionTextBox.Name = "fldDeptCaptionTextBox"
        Me.fldDeptCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2666666507720947R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDeptCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCaptionTextBox.StyleName = "Caption"
        Me.fldDeptCaptionTextBox.Value = "DEPARTMENT"
        '
        'aAWithBgtCaptionTextBox
        '
        Me.aAWithBgtCaptionTextBox.CanGrow = True
        Me.aAWithBgtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.658411979675293R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.aAWithBgtCaptionTextBox.Name = "aAWithBgtCaptionTextBox"
        Me.aAWithBgtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583333730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.aAWithBgtCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.aAWithBgtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWithBgtCaptionTextBox.StyleName = "Caption"
        Me.aAWithBgtCaptionTextBox.Value = "ACT. ACQ. W/O BUDGET"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.20992112159729R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5666669607162476R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "ORIGINAL BUDGET"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7766666412353516R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4356355667114258R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "REVISION BUDGET"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.94309669733047485R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "YEAR"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7415871620178223R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583333730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Caption"
        Me.TextBox7.Value = "PO WITH BUDGET"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.55003833770752R), Telerik.Reporting.Drawing.Unit.Inch(0.2100788801908493R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9700000286102295R), Telerik.Reporting.Drawing.Unit.Inch(0.18999999761581421R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "BUDGET BALANCE  INCLUDING WITH & WITHOUTH BUDGET"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.583568572998047R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.9364709854125977R), Telerik.Reporting.Drawing.Unit.Inch(0.20999994874000549R))
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "COMPUTATION OF BUDGET LESS ACQUISITION"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.520118713378906R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.9364709854125977R), Telerik.Reporting.Drawing.Unit.Inch(0.20999994874000549R))
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.StyleName = "Caption"
        Me.TextBox20.Value = "COMPUTATION OF BUDGET LESS PURCHASE ORDER"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.486589431762695R), Telerik.Reporting.Drawing.Unit.Inch(0.21015770733356476R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9700000286102295R), Telerik.Reporting.Drawing.Unit.Inch(0.18999999761581421R))
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.StyleName = "Caption"
        Me.TextBox21.Value = "BUDGET BALANCE  INCLUDING WITH & WITHOUTH BUDGET"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.520118713378906R), Telerik.Reporting.Drawing.Unit.Inch(0.21023675799369812R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9663921594619751R), Telerik.Reporting.Drawing.Unit.Inch(0.18992112576961517R))
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.StyleName = "Caption"
        Me.TextBox22.Value = "BUDGET BALANCE  INCLUDING WITH BUDGET"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583333730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.StyleName = "Caption"
        Me.TextBox25.Value = "UPLOADED PO"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" & _
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value"), New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_BPDept"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.24416644871234894R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.23999984562397003R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.486591339111328R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9699991941452026R), Telerik.Reporting.Drawing.Unit.Inch(0.23999999463558197R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(20.456588745117188R), Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Budget per Department"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25996053218841553R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox12, Me.TextBox11, Me.TextBox13, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox14, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31})
        Me.reportFooter.Name = "reportFooter"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.94309705495834351R), Telerik.Reporting.Drawing.Unit.Inch(0.25992092490196228R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox12.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "TOTAL"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Format = "{0:N2}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5765880346298218R), Telerik.Reporting.Drawing.Unit.Inch(0.25992098450660706R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox11.Style.Font.Bold = False
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Data"
        Me.TextBox11.Value = "= Sum(Fields.OrgAmount)"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Format = "{0:N2}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7766666412353516R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4356352090835571R), Telerik.Reporting.Drawing.Unit.Inch(0.25992098450660706R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox13.Style.Font.Bold = False
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Data"
        Me.TextBox13.Value = "= Fields.RevAmount0"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Format = "{0:N2}"
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7415871620178223R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.458412766456604R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox15.Style.Font.Bold = False
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "= SUM(Fields.POWithBgt)"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Format = "{0:N2}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583333730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox16.Style.Font.Bold = False
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "=SUM(Fields.UUPO)"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.658411979675293R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583330154418945R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox17.Style.Font.Bold = False
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "=Sum(IsNull(0,Fields.GRPOWithoutBgt))"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2123417854309082R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5292074680328369R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox14.Style.Font.Bold = False
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "= SUM(Fields.POWithoutBgt)"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.583568572998047R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9663923978805542R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox27.Style.Font.Bold = False
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.StyleName = "Data"
        Me.TextBox27.Value = "= SUM(Fields.RevAmount - (Fields.GRPOWithBgt + Fields.WNUPO))"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.550040245056152R), Telerik.Reporting.Drawing.Unit.Inch(0.000039577484130859375R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9699997901916504R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox28.Style.Font.Bold = False
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "= SUM(Fields.RevAmount - (Fields.GRPOWithBgt + Fields.GRPOWithoutBgt + Fields.UPO" & _
    "))"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.520116806030273R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9663923978805542R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox29.Style.Font.Bold = False
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "= SUM(Fields.RevAmount - (Fields.POWITHBgt + Fields.WNUUPO))"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Format = "{0:N2}"
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.486589431762695R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9699997901916504R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox30.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox30.Style.Font.Bold = False
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.StyleName = "Data"
        Me.TextBox30.Value = "= SUM(Fields.RevAmount - (Fields.POWITHBgt + Fields.POWithoutBgt + Fields.UUPO))"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Format = "{0:N2}"
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.116822242736816R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4666668176651R), Telerik.Reporting.Drawing.Unit.Inch(0.25992095470428467R))
        Me.TextBox31.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox31.Style.Font.Bold = False
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.StyleName = "Data"
        Me.TextBox31.Value = "= SUM(Fields.GRPOWithBgt)"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.290157675743103R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.balanceDataTextBox, Me.fldDeptDataTextBox, Me.onGoingOrderDataTextBox, Me.aAWithBgtDataTextBox, Me.TextBox4, Me.TextBox2, Me.TextBox6, Me.TextBox8, Me.TextBox10, Me.TextBox23, Me.TextBox24, Me.TextBox26, Me.TextBox32})
        Me.detail.Name = "detail"
        '
        'balanceDataTextBox
        '
        Me.balanceDataTextBox.CanGrow = True
        Me.balanceDataTextBox.Format = "{0:N2}"
        Me.balanceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.583568572998047R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.balanceDataTextBox.Name = "balanceDataTextBox"
        Me.balanceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9663923978805542R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.balanceDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.balanceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.balanceDataTextBox.StyleName = "Data"
        Me.balanceDataTextBox.Value = "= Fields.RevAmount - (Fields.GRPOWithBgt + Fields.WNUPO)"
        '
        'fldDeptDataTextBox
        '
        Me.fldDeptDataTextBox.CanGrow = True
        Me.fldDeptDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.94317597150802612R), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492R))
        Me.fldDeptDataTextBox.Name = "fldDeptDataTextBox"
        Me.fldDeptDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2666665315628052R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.fldDeptDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptDataTextBox.StyleName = "Data"
        Me.fldDeptDataTextBox.Value = "=Fields.fldDept"
        '
        'onGoingOrderDataTextBox
        '
        Me.onGoingOrderDataTextBox.CanGrow = True
        Me.onGoingOrderDataTextBox.Format = "{0:N2}"
        Me.onGoingOrderDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2123823165893555R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.onGoingOrderDataTextBox.Name = "onGoingOrderDataTextBox"
        Me.onGoingOrderDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5291668176651R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.onGoingOrderDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.onGoingOrderDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.onGoingOrderDataTextBox.StyleName = "Data"
        Me.onGoingOrderDataTextBox.Value = "= Fields.POWithoutBgt"
        '
        'aAWithBgtDataTextBox
        '
        Me.aAWithBgtDataTextBox.CanGrow = True
        Me.aAWithBgtDataTextBox.Format = "{0:N2}"
        Me.aAWithBgtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.6584110260009766R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.aAWithBgtDataTextBox.Name = "aAWithBgtDataTextBox"
        Me.aAWithBgtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.aAWithBgtDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.aAWithBgtDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWithBgtDataTextBox.StyleName = "Data"
        Me.aAWithBgtDataTextBox.Value = "=IsNull(0,Fields.GRPOWithoutBgt)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2099606990814209R), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5666673183441162R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "=Fields.OrgAmount"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7767457962036133R), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.435596227645874R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.RevAmount0"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.94309705495834351R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "=Fields.Year"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7415871620178223R), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= Fields.POWithBgt"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.550040245056152R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9699997901916504R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "= Fields.RevAmount - (Fields.GRPOWithBgt + Fields.GRPOWithoutBgt + Fields.UPO)"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Format = "{0:N2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.486589431762695R), Telerik.Reporting.Drawing.Unit.Inch(0.00015788608288858086R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9699997901916504R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.StyleName = "Data"
        Me.TextBox23.Value = "= Fields.RevAmount - ((Fields.POWITHBgt + Fields.POWithoutBgt) + Fields.UUPO)"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N2}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.520118713378906R), Telerik.Reporting.Drawing.Unit.Inch(0.00015788608288858086R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9663923978805542R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "= Fields.RevAmount - (Fields.POWITHBgt + Fields.WNUUPO)"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Format = "{0:N2}"
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4583332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.StyleName = "Data"
        Me.TextBox26.Value = "= Fields.UUPO"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Format = "{0:N2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.116822242736816R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4666683673858643R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Data"
        Me.TextBox32.Value = "=Fields.GRPOWithBgt"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox18})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.6000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.24988196790218353R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.324169158935547R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1324193477630615R), Telerik.Reporting.Drawing.Unit.Inch(0.24988201260566711R))
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "PageInfo"
        Me.TextBox18.Value = "Budget Actual Program (BAP)"
        '
        'repDept
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "Report1"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "D1"
        ReportParameter1.Text = "D1"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Value = ""
        ReportParameter2.Name = "D2"
        ReportParameter2.Text = "D2"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = ""
        ReportParameter3.Name = "DEPT"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.Font.Bold = False
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(20.456588745117188R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents aAWithBgtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents aAWITHOUTBgtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents balanceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents onGoingOrderCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents aAWithBgtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents balanceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents onGoingOrderDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
End Class
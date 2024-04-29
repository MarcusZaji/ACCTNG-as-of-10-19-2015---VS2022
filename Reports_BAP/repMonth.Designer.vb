Partial Class repMonth
    
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
        Me.aAWITHBUDGETCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.aAWITHOUTBgtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.month2CaptionTextBox = New Telerik.Reporting.TextBox()
        Me.oNGOINGORDERCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.bUDGETCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.aAWITHBUDGETDataTextBox = New Telerik.Reporting.TextBox()
        Me.aAWITHOUTBgtDataTextBox = New Telerik.Reporting.TextBox()
        Me.bUDGETDataTextBox = New Telerik.Reporting.TextBox()
        Me.month2DataTextBox = New Telerik.Reporting.TextBox()
        Me.oNGOINGORDERDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.245R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.aAWITHBUDGETCaptionTextBox, Me.aAWITHOUTBgtCaptionTextBox, Me.month2CaptionTextBox, Me.oNGOINGORDERCaptionTextBox, Me.bUDGETCaptionTextBox, Me.TextBox3, Me.TextBox6, Me.TextBox17, Me.TextBox18, Me.TextBox20, Me.TextBox21, Me.TextBox19, Me.TextBox22, Me.TextBox1, Me.TextBox2, Me.TextBox13})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'aAWITHBUDGETCaptionTextBox
        '
        Me.aAWITHBUDGETCaptionTextBox.CanGrow = True
        Me.aAWITHBUDGETCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.529R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.aAWITHBUDGETCaptionTextBox.Name = "aAWITHBUDGETCaptionTextBox"
        Me.aAWITHBUDGETCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.071R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.aAWITHBUDGETCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.aAWITHBUDGETCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWITHBUDGETCaptionTextBox.StyleName = "Caption"
        Me.aAWITHBUDGETCaptionTextBox.Value = "ACT. ACQ W/ BUDGET"
        '
        'aAWITHOUTBgtCaptionTextBox
        '
        Me.aAWITHOUTBgtCaptionTextBox.CanGrow = True
        Me.aAWITHOUTBgtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.aAWITHOUTBgtCaptionTextBox.Name = "aAWITHOUTBgtCaptionTextBox"
        Me.aAWITHOUTBgtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.089R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.aAWITHOUTBgtCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.aAWITHOUTBgtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWITHOUTBgtCaptionTextBox.StyleName = "Caption"
        Me.aAWITHOUTBgtCaptionTextBox.Value = "ACT. ACQ W/O BUDGET"
        '
        'month2CaptionTextBox
        '
        Me.month2CaptionTextBox.CanGrow = True
        Me.month2CaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.month2CaptionTextBox.Name = "month2CaptionTextBox"
        Me.month2CaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.month2CaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.month2CaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.month2CaptionTextBox.StyleName = "Caption"
        Me.month2CaptionTextBox.Value = "MONTH"
        '
        'oNGOINGORDERCaptionTextBox
        '
        Me.oNGOINGORDERCaptionTextBox.CanGrow = True
        Me.oNGOINGORDERCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.317R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.oNGOINGORDERCaptionTextBox.Name = "oNGOINGORDERCaptionTextBox"
        Me.oNGOINGORDERCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.106R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.oNGOINGORDERCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.oNGOINGORDERCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.oNGOINGORDERCaptionTextBox.StyleName = "Caption"
        Me.oNGOINGORDERCaptionTextBox.Value = "PO WITHOUT BUDGET"
        '
        'bUDGETCaptionTextBox
        '
        Me.bUDGETCaptionTextBox.CanGrow = True
        Me.bUDGETCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.78R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.bUDGETCaptionTextBox.Name = "bUDGETCaptionTextBox"
        Me.bUDGETCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.965R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.bUDGETCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.bUDGETCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.bUDGETCaptionTextBox.StyleName = "Caption"
        Me.bUDGETCaptionTextBox.Value = "ORIGINAL BUDGET"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.745R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.572R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "REVISION AMOUNT"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.423R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.107R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "PO WITH BUDGET"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.267R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.569R), Telerik.Reporting.Drawing.Unit.Inch(0.19R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.StyleName = "Caption"
        Me.TextBox17.Value = "BALANCE INCLUDED w/0 BUDGET"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.69R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.577R), Telerik.Reporting.Drawing.Unit.Inch(0.19R))
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.StyleName = "Caption"
        Me.TextBox18.Value = "BUDGET BALANCE"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.69R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.146R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.StyleName = "Caption"
        Me.TextBox20.Value = "COMPUTATION OF BUDGET LESS PURCHASE ORDER"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.835R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.149R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.StyleName = "Caption"
        Me.TextBox21.Value = "COMPUTATION OF BUDGET LESS ACTUAL ACQUISITION"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.835R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.565R), Telerik.Reporting.Drawing.Unit.Inch(0.19R))
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "BUDGET BALANCE"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.4R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.584R), Telerik.Reporting.Drawing.Unit.Inch(0.19R))
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.StyleName = "Caption"
        Me.TextBox22.Value = "BALANCE INCLUDED w/0 BUDGET"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.984R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.149R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "FORCE PO"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.984R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.565R), Telerik.Reporting.Drawing.Unit.Inch(0.19R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "FORCE PO WITH BUDGET"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.549R), Telerik.Reporting.Drawing.Unit.Inch(0.21R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.584R), Telerik.Reporting.Drawing.Unit.Inch(0.19R))
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "FORCE FO W/O BUDGET"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" &
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value"), New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_RPMonth"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox16})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.609R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.981R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.152R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.StyleName = "PageInfo"
        Me.TextBox16.Value = "Budget Actual Program (BAP)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.27R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.317R), Telerik.Reporting.Drawing.Unit.Inch(0.27R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.981R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.147R), Telerik.Reporting.Drawing.Unit.Inch(0.27R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.46R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(17.133R), Telerik.Reporting.Drawing.Unit.Inch(0.46R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Report per Month"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox15, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox32, Me.TextBox33, Me.TextBox7})
        Me.reportFooter.Name = "reportFooter"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.78R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.97R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox7.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "=Sum(Fields.OrgAmount)"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.75R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.567R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "=Sum(Fields.RevAmount0)"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Format = "{0:N2}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.317R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.106R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "=Sum(Fields.POWithoutBgt)"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.423R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.106R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "=Sum(Fields.POWITHBgt)"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Format = "{0:N2}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.529R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.081R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Data"
        Me.TextBox11.Value = "=Sum(Fields.GRPOWithoutBgt)"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:N2}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.609R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.08R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "=sum(Fields.GRPOWithBgt)"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox15.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Caption"
        Me.TextBox15.Value = "TOTAL"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = True
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.584R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.StyleName = "Data"
        Me.TextBox27.Value = "= SUM(Fields.RevAmount -(Fields.GRPOWithoutBgt + Fields.UPO))"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.835R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.565R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox28.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "= SUM(Fields.RevAmount -(Fields.GRPOWithBgt + Fields.UPO))"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.267R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.569R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox29.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "= SUM(Fields.RevAmount - (Fields.POWithoutBgt + Fields.UPO + Fields.POWITHBgt))"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Format = "{0:N2}"
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.69R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.577R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox30.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.StyleName = "Data"
        Me.TextBox30.Value = "= SUM (Fields.RevAmount -(Fields.POWITHBgt + Fields.UPO))"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Format = "{0:N2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.984R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.565R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox32.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.StyleName = "Data"
        Me.TextBox32.Value = "= SUM(Fields.FPOWITHBgt)"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Format = "{0:N2}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.549R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.584R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox33.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox33.StyleName = "Data"
        Me.TextBox33.Value = "= SUM(Fields.FPOWithoutBgt)"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.aAWITHBUDGETDataTextBox, Me.aAWITHOUTBgtDataTextBox, Me.bUDGETDataTextBox, Me.month2DataTextBox, Me.oNGOINGORDERDataTextBox, Me.TextBox4, Me.TextBox5, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox14, Me.TextBox31})
        Me.detail.Name = "detail"
        '
        'aAWITHBUDGETDataTextBox
        '
        Me.aAWITHBUDGETDataTextBox.CanGrow = True
        Me.aAWITHBUDGETDataTextBox.Format = "{0:N2}"
        Me.aAWITHBUDGETDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.529R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.aAWITHBUDGETDataTextBox.Name = "aAWITHBUDGETDataTextBox"
        Me.aAWITHBUDGETDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.071R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.aAWITHBUDGETDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.aAWITHBUDGETDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWITHBUDGETDataTextBox.StyleName = "Data"
        Me.aAWITHBUDGETDataTextBox.Value = "= Fields.GRPOWithoutBgt"
        '
        'aAWITHOUTBgtDataTextBox
        '
        Me.aAWITHOUTBgtDataTextBox.CanGrow = True
        Me.aAWITHOUTBgtDataTextBox.Format = "{0:N2}"
        Me.aAWITHOUTBgtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.aAWITHOUTBgtDataTextBox.Name = "aAWITHOUTBgtDataTextBox"
        Me.aAWITHOUTBgtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.089R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.aAWITHOUTBgtDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.aAWITHOUTBgtDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWITHOUTBgtDataTextBox.StyleName = "Data"
        Me.aAWITHOUTBgtDataTextBox.Value = "= Fields.GRPOWithBgt"
        '
        'bUDGETDataTextBox
        '
        Me.bUDGETDataTextBox.CanGrow = True
        Me.bUDGETDataTextBox.Format = "{0:N2}"
        Me.bUDGETDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.78R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.bUDGETDataTextBox.Name = "bUDGETDataTextBox"
        Me.bUDGETDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.965R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.bUDGETDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.bUDGETDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.bUDGETDataTextBox.StyleName = "Data"
        Me.bUDGETDataTextBox.Value = "=Fields.OrgAmount"
        '
        'month2DataTextBox
        '
        Me.month2DataTextBox.CanGrow = True
        Me.month2DataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.month2DataTextBox.Name = "month2DataTextBox"
        Me.month2DataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.month2DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.month2DataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.month2DataTextBox.StyleName = "Data"
        Me.month2DataTextBox.Value = "=Fields.fldMonth"
        '
        'oNGOINGORDERDataTextBox
        '
        Me.oNGOINGORDERDataTextBox.CanGrow = True
        Me.oNGOINGORDERDataTextBox.Format = "{0:N2}"
        Me.oNGOINGORDERDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.317R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.oNGOINGORDERDataTextBox.Name = "oNGOINGORDERDataTextBox"
        Me.oNGOINGORDERDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.106R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.oNGOINGORDERDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.oNGOINGORDERDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.oNGOINGORDERDataTextBox.StyleName = "Data"
        Me.oNGOINGORDERDataTextBox.Value = "= IsNull(Fields.POWithoutBgt + Fields.UPO,0)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.745R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.572R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.RevAmount0"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Format = "{0:N2}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.423R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.106R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "= Fields.POWITHBgt"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Format = "{0:N2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.267R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.569R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.StyleName = "Data"
        Me.TextBox23.Value = "= Fields.RevAmount -(Fields.POWithoutBgt + Fields.UPO + Fields.POWITHBgt)"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Format = "{0:N2}"
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.7R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.566R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "= Fields.RevAmount -(Fields.POWITHBgt + Fields.UPO)"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Format = "{0:N2}"
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.584R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "= Fields.RevAmount -(Fields.GRPOWithoutBgt + Fields.UPO + Fields.FPOWithoutBgt)"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Format = "{0:N2}"
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.835R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.565R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.StyleName = "Data"
        Me.TextBox26.Value = "= Fields.RevAmount -(Fields.GRPOWithBgt + Fields.UPO + Fields.FPOWITHBgt)"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.984R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.565R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "= Fields.FPOWITHBgt"
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Format = "{0:N2}"
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.549R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.584R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox31.StyleName = "Data"
        Me.TextBox31.Value = "= Fields.FPOWithoutBgt"
        '
        'repMonth
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repMonth"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "D1"
        ReportParameter1.Text = "D1"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Name = "D2"
        ReportParameter2.Text = "D2"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "DEPT"
        ReportParameter3.Text = "DEPT"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(17.133R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents aAWITHBUDGETCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents aAWITHOUTBgtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents bUDGETCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents month2CaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents oNGOINGORDERCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents aAWITHBUDGETDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents aAWITHOUTBgtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents bUDGETDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents month2DataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents oNGOINGORDERDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
End Class
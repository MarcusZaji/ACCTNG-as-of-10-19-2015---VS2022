Partial Class repOrderList
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.RepOrderItem1 = New ACCTNG.repOrderItem()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.fldPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderSupplierCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDescCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldCurrencyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.yENCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.uSDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pHPCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderSupplierDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDescDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldCurrencyDataTextBox = New Telerik.Reporting.TextBox()
        Me.yENDataTextBox = New Telerik.Reporting.TextBox()
        Me.uSDDataTextBox = New Telerik.Reporting.TextBox()
        Me.pHPDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYDataTextBox = New Telerik.Reporting.TextBox()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        CType(Me.RepOrderItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'RepOrderItem1
        '
        Me.RepOrderItem1.Name = "repOrderItem"
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPONoCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.fldOrderSupplierCaptionTextBox, Me.fldOrderDescCaptionTextBox, Me.fldQTYCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldCurrencyCaptionTextBox, Me.yENCaptionTextBox, Me.uSDCaptionTextBox, Me.pHPCaptionTextBox, Me.TextBox1, Me.TextBox3, Me.TextBox5})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.154R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "PO NO."
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.154R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.473R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "PR NO."
        '
        'fldOrderSupplierCaptionTextBox
        '
        Me.fldOrderSupplierCaptionTextBox.CanGrow = True
        Me.fldOrderSupplierCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.627R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldOrderSupplierCaptionTextBox.Name = "fldOrderSupplierCaptionTextBox"
        Me.fldOrderSupplierCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.773R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldOrderSupplierCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderSupplierCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierCaptionTextBox.StyleName = "Caption"
        Me.fldOrderSupplierCaptionTextBox.Value = "SUPPLIER"
        '
        'fldOrderDescCaptionTextBox
        '
        Me.fldOrderDescCaptionTextBox.CanGrow = True
        Me.fldOrderDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldOrderDescCaptionTextBox.Name = "fldOrderDescCaptionTextBox"
        Me.fldOrderDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.527R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldOrderDescCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDescCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDescCaptionTextBox.Value = "REMARKS"
        '
        'fldQTYCaptionTextBox
        '
        Me.fldQTYCaptionTextBox.CanGrow = True
        Me.fldQTYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.927R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldQTYCaptionTextBox.Name = "fldQTYCaptionTextBox"
        Me.fldQTYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldQTYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldQTYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYCaptionTextBox.StyleName = "Caption"
        Me.fldQTYCaptionTextBox.Value = "QTY"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.827R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldAmountJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "TOTAL PO AMOUNT "
        '
        'fldCurrencyCaptionTextBox
        '
        Me.fldCurrencyCaptionTextBox.CanGrow = True
        Me.fldCurrencyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.727R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldCurrencyCaptionTextBox.Name = "fldCurrencyCaptionTextBox"
        Me.fldCurrencyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.854R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.fldCurrencyCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldCurrencyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyCaptionTextBox.StyleName = "Caption"
        Me.fldCurrencyCaptionTextBox.Value = "CURRENCY"
        '
        'yENCaptionTextBox
        '
        Me.yENCaptionTextBox.CanGrow = True
        Me.yENCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.yENCaptionTextBox.Name = "yENCaptionTextBox"
        Me.yENCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.yENCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.yENCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.yENCaptionTextBox.StyleName = "Caption"
        Me.yENCaptionTextBox.Value = "JPY"
        '
        'uSDCaptionTextBox
        '
        Me.uSDCaptionTextBox.CanGrow = True
        Me.uSDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.uSDCaptionTextBox.Name = "uSDCaptionTextBox"
        Me.uSDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.uSDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.uSDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDCaptionTextBox.StyleName = "Caption"
        Me.uSDCaptionTextBox.Value = "USD"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.pHPCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.pHPCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "PHP"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.127R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "DISCOUNT "
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.427R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "DISCOUNTED PO AMOUNT"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.373R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "SIGNATURE"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" &
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value"), New Telerik.Reporting.SqlDataSourceParameter("@PO", System.Data.DbType.[String], "=Parameters.PO.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_OrderList"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox18})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.835R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.822R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.132R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "PageInfo"
        Me.TextBox18.Value = "Budget Actual Program (BAP)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.24R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198R), Telerik.Reporting.Drawing.Unit.Inch(0.24R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.754R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2R), Telerik.Reporting.Drawing.Unit.Inch(0.24R))
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
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.835R), Telerik.Reporting.Drawing.Unit.Inch(0.46R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Report per Order"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.09R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPONoDataTextBox, Me.fldPRNoDataTextBox, Me.fldOrderSupplierDataTextBox, Me.fldOrderDescDataTextBox, Me.fldCurrencyDataTextBox, Me.yENDataTextBox, Me.uSDDataTextBox, Me.pHPDataTextBox, Me.fldAmountJPYDataTextBox, Me.fldQTYDataTextBox, Me.SubReport1, Me.TextBox2, Me.TextBox4, Me.TextBox6})
        Me.detail.Name = "detail"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.154R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldPONoDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "= Fields.PO"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.154R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.473R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldPRNoDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "= Fields.PRNo"
        '
        'fldOrderSupplierDataTextBox
        '
        Me.fldOrderSupplierDataTextBox.CanGrow = True
        Me.fldOrderSupplierDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.627R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldOrderSupplierDataTextBox.Name = "fldOrderSupplierDataTextBox"
        Me.fldOrderSupplierDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.773R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldOrderSupplierDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldOrderSupplierDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderSupplierDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierDataTextBox.StyleName = "Data"
        Me.fldOrderSupplierDataTextBox.Value = "= Fields.fldSupplier"
        '
        'fldOrderDescDataTextBox
        '
        Me.fldOrderDescDataTextBox.CanGrow = True
        Me.fldOrderDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldOrderDescDataTextBox.Name = "fldOrderDescDataTextBox"
        Me.fldOrderDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.527R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldOrderDescDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldOrderDescDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderDescDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescDataTextBox.StyleName = "Data"
        Me.fldOrderDescDataTextBox.Value = "= Fields.fldRemarks"
        '
        'fldCurrencyDataTextBox
        '
        Me.fldCurrencyDataTextBox.CanGrow = True
        Me.fldCurrencyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.727R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldCurrencyDataTextBox.Name = "fldCurrencyDataTextBox"
        Me.fldCurrencyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.854R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldCurrencyDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldCurrencyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldCurrencyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyDataTextBox.StyleName = "Data"
        Me.fldCurrencyDataTextBox.Value = "= Fields.fldCurrency"
        '
        'yENDataTextBox
        '
        Me.yENDataTextBox.CanGrow = True
        Me.yENDataTextBox.Format = "{0:N2}"
        Me.yENDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.yENDataTextBox.Name = "yENDataTextBox"
        Me.yENDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.yENDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.yENDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.yENDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.yENDataTextBox.StyleName = "Data"
        Me.yENDataTextBox.Value = "= Fields.SumJPY"
        '
        'uSDDataTextBox
        '
        Me.uSDDataTextBox.CanGrow = True
        Me.uSDDataTextBox.Format = "{0:N2}"
        Me.uSDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.uSDDataTextBox.Name = "uSDDataTextBox"
        Me.uSDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.uSDDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.uSDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.uSDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDDataTextBox.StyleName = "Data"
        Me.uSDDataTextBox.Value = "=Fields.USD"
        '
        'pHPDataTextBox
        '
        Me.pHPDataTextBox.CanGrow = True
        Me.pHPDataTextBox.Format = "{0:N2}"
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.pHPDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.pHPDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.pHPDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPDataTextBox.StyleName = "Data"
        Me.pHPDataTextBox.Value = "=Fields.PHP"
        '
        'fldAmountJPYDataTextBox
        '
        Me.fldAmountJPYDataTextBox.CanGrow = True
        Me.fldAmountJPYDataTextBox.Format = "{0:N2}"
        Me.fldAmountJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.827R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldAmountJPYDataTextBox.Name = "fldAmountJPYDataTextBox"
        Me.fldAmountJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldAmountJPYDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldAmountJPYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldAmountJPYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYDataTextBox.StyleName = "Data"
        Me.fldAmountJPYDataTextBox.Value = "= Fields.fldTPO"
        '
        'fldQTYDataTextBox
        '
        Me.fldQTYDataTextBox.CanGrow = True
        Me.fldQTYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.927R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldQTYDataTextBox.Name = "fldQTYDataTextBox"
        Me.fldQTYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.fldQTYDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldQTYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldQTYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYDataTextBox.StyleName = "Data"
        Me.fldQTYDataTextBox.Value = "= Fields.SumQTY"
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("POBLine", "=Fields.OB_Line"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", "= Parameters.DEPT.Value"))
        InstanceReportSource1.ReportDocument = Me.RepOrderItem1
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(20.954R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.127R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.fldDAmount"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.427R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox4.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.OB_POAmt"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.581R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.373R), Telerik.Reporting.Drawing.Unit.Inch(0.29R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "= Fields.fldSignature"
        '
        'repOrderList
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repOrderList"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "DEPT"
        ReportParameter1.Text = "DEPT"
        ReportParameter2.Name = "PO"
        ReportParameter2.Text = "PO"
        ReportParameter3.Name = "D1"
        ReportParameter3.Text = "D1"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter4.Name = "D2"
        ReportParameter4.Text = "D2"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.DateTime
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(20.954R)
        CType(Me.RepOrderItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fldPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderSupplierCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDescCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldCurrencyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents yENCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fldPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderSupplierDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDescDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldCurrencyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents yENDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents RepOrderItem1 As ACCTNG.repOrderItem
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
End Class
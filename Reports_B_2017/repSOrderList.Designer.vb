Partial Class repSOrderList2017

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
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
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
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
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4000394344329834R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumCaptionTextBox, Me.fldPONoCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.fldOrderSupplierCaptionTextBox, Me.fldOrderDescCaptionTextBox, Me.fldQTYCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldCurrencyCaptionTextBox, Me.yENCaptionTextBox, Me.uSDCaptionTextBox, Me.pHPCaptionTextBox})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999605417251587R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "fld Bud Ref Num"
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5000787973403931R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "fld PONo"
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6270515918731689R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4728692770004272R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "fld PRNo"
        '
        'fldOrderSupplierCaptionTextBox
        '
        Me.fldOrderSupplierCaptionTextBox.CanGrow = True
        Me.fldOrderSupplierCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierCaptionTextBox.Name = "fldOrderSupplierCaptionTextBox"
        Me.fldOrderSupplierCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderSupplierCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderSupplierCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierCaptionTextBox.StyleName = "Caption"
        Me.fldOrderSupplierCaptionTextBox.Value = "fld Order Supplier"
        '
        'fldOrderDescCaptionTextBox
        '
        Me.fldOrderDescCaptionTextBox.CanGrow = True
        Me.fldOrderDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescCaptionTextBox.Name = "fldOrderDescCaptionTextBox"
        Me.fldOrderDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4270057678222656R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDescCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDescCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDescCaptionTextBox.Value = "fld Order Desc"
        '
        'fldQTYCaptionTextBox
        '
        Me.fldQTYCaptionTextBox.CanGrow = True
        Me.fldQTYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.9270844459533691R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYCaptionTextBox.Name = "fldQTYCaptionTextBox"
        Me.fldQTYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldQTYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldQTYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYCaptionTextBox.StyleName = "Caption"
        Me.fldQTYCaptionTextBox.Value = "fld QTY"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.8270845413208R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "fld Amount JPY"
        '
        'fldCurrencyCaptionTextBox
        '
        Me.fldCurrencyCaptionTextBox.CanGrow = True
        Me.fldCurrencyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.127083778381348R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyCaptionTextBox.Name = "fldCurrencyCaptionTextBox"
        Me.fldCurrencyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.85370826721191406R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldCurrencyCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldCurrencyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyCaptionTextBox.StyleName = "Caption"
        Me.fldCurrencyCaptionTextBox.Value = "fld Currency"
        '
        'yENCaptionTextBox
        '
        Me.yENCaptionTextBox.CanGrow = True
        Me.yENCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.980870246887207R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.yENCaptionTextBox.Name = "yENCaptionTextBox"
        Me.yENCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.346016526222229R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.yENCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.yENCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.yENCaptionTextBox.StyleName = "Caption"
        Me.yENCaptionTextBox.Value = "YEN"
        '
        'uSDCaptionTextBox
        '
        Me.uSDCaptionTextBox.CanGrow = True
        Me.uSDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.326966285705566R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uSDCaptionTextBox.Name = "uSDCaptionTextBox"
        Me.uSDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3500000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.uSDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDCaptionTextBox.StyleName = "Caption"
        Me.uSDCaptionTextBox.Value = "USD"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.677044868469238R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3500000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pHPCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.pHPCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "PHP"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value"), New Telerik.Reporting.SqlDataSourceParameter("@PO", System.Data.DbType.[String], "=Parameters.PO.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_SOrderList"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20003937184810638R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.83515453338623R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.24003942310810089R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageInfoTextBox, Me.currentTimeTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.827045440673828R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.23999999463558197R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.23999984562397003R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.45999994874000549R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.835115432739258R), Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Report per Order"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumDataTextBox, Me.fldPONoDataTextBox, Me.fldPRNoDataTextBox, Me.fldOrderSupplierDataTextBox, Me.fldOrderDescDataTextBox, Me.fldCurrencyDataTextBox, Me.yENDataTextBox, Me.uSDDataTextBox, Me.pHPDataTextBox, Me.fldAmountJPYDataTextBox, Me.fldQTYDataTextBox})
        Me.detail.Name = "detail"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.fldBudRefNumDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=Fields.fldBudRefNum"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5000787973403931R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldPONoDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "=Fields.fldPONo"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6270515918731689R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.472948431968689R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldPRNoDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "=Fields.fldPRNo"
        '
        'fldOrderSupplierDataTextBox
        '
        Me.fldOrderSupplierDataTextBox.CanGrow = True
        Me.fldOrderSupplierDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierDataTextBox.Name = "fldOrderSupplierDataTextBox"
        Me.fldOrderSupplierDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999214172363281R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldOrderSupplierDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldOrderSupplierDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderSupplierDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierDataTextBox.StyleName = "Data"
        Me.fldOrderSupplierDataTextBox.Value = "=Fields.fldOrderSupplier"
        '
        'fldOrderDescDataTextBox
        '
        Me.fldOrderDescDataTextBox.CanGrow = True
        Me.fldOrderDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescDataTextBox.Name = "fldOrderDescDataTextBox"
        Me.fldOrderDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4270057678222656R), Telerik.Reporting.Drawing.Unit.Inch(0.28999990224838257R))
        Me.fldOrderDescDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldOrderDescDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderDescDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescDataTextBox.StyleName = "Data"
        Me.fldOrderDescDataTextBox.Value = "=Fields.fldOrderDesc"
        '
        'fldCurrencyDataTextBox
        '
        Me.fldCurrencyDataTextBox.CanGrow = True
        Me.fldCurrencyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.127083778381348R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyDataTextBox.Name = "fldCurrencyDataTextBox"
        Me.fldCurrencyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.85370951890945435R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldCurrencyDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldCurrencyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldCurrencyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyDataTextBox.StyleName = "Data"
        Me.fldCurrencyDataTextBox.Value = "=Fields.fldCurrency"
        '
        'yENDataTextBox
        '
        Me.yENDataTextBox.CanGrow = True
        Me.yENDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.980870246887207R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.yENDataTextBox.Name = "yENDataTextBox"
        Me.yENDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3460178375244141R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.yENDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.yENDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.yENDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.yENDataTextBox.StyleName = "Data"
        Me.yENDataTextBox.Value = "=Fields.YEN"
        '
        'uSDDataTextBox
        '
        Me.uSDDataTextBox.CanGrow = True
        Me.uSDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.326966285705566R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.uSDDataTextBox.Name = "uSDDataTextBox"
        Me.uSDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3499990701675415R), Telerik.Reporting.Drawing.Unit.Inch(0.28996053338050842R))
        Me.uSDDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.uSDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.uSDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDDataTextBox.StyleName = "Data"
        Me.uSDDataTextBox.Value = "=Fields.USD"
        '
        'pHPDataTextBox
        '
        Me.pHPDataTextBox.CanGrow = True
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.677044868469238R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3500003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.pHPDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.pHPDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.pHPDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPDataTextBox.StyleName = "Data"
        Me.pHPDataTextBox.Value = "=Fields.PHP"
        '
        'fldAmountJPYDataTextBox
        '
        Me.fldAmountJPYDataTextBox.CanGrow = True
        Me.fldAmountJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.8270845413208R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYDataTextBox.Name = "fldAmountJPYDataTextBox"
        Me.fldAmountJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldAmountJPYDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldAmountJPYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldAmountJPYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYDataTextBox.StyleName = "Data"
        Me.fldAmountJPYDataTextBox.Value = "=Fields.fldAmountJPY"
        '
        'fldQTYDataTextBox
        '
        Me.fldQTYDataTextBox.CanGrow = True
        Me.fldQTYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.9270844459533691R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYDataTextBox.Name = "fldQTYDataTextBox"
        Me.fldQTYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992141723632813R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldQTYDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldQTYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldQTYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYDataTextBox.StyleName = "Data"
        Me.fldQTYDataTextBox.Value = "=Fields.fldQTY"
        '
        'repSOrderList2017
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(15.027047157287598R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
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
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
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
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
End Class
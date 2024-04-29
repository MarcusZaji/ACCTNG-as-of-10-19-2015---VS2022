Partial Class repOrderList2017

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
        Me.RepOrderItem20171 = New ACCTNG.repOrderItem2017()
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
        CType(Me.RepOrderItem20171, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'RepOrderItem20171
        '
        Me.RepOrderItem20171.Name = "repOrderItem"
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
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPONoCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.fldOrderSupplierCaptionTextBox, Me.fldOrderDescCaptionTextBox, Me.fldQTYCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldCurrencyCaptionTextBox, Me.yENCaptionTextBox, Me.uSDCaptionTextBox, Me.pHPCaptionTextBox, Me.TextBox1, Me.TextBox3, Me.TextBox5})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1539849042892456R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "PO NO."
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1541033983230591R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4728692770004272R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "PR NO."
        '
        'fldOrderSupplierCaptionTextBox
        '
        Me.fldOrderSupplierCaptionTextBox.CanGrow = True
        Me.fldOrderSupplierCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.62705135345459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierCaptionTextBox.Name = "fldOrderSupplierCaptionTextBox"
        Me.fldOrderSupplierCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7728700637817383R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderSupplierCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderSupplierCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierCaptionTextBox.StyleName = "Caption"
        Me.fldOrderSupplierCaptionTextBox.Value = "SUPPLIER"
        '
        'fldOrderDescCaptionTextBox
        '
        Me.fldOrderDescCaptionTextBox.CanGrow = True
        Me.fldOrderDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.40000057220459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescCaptionTextBox.Name = "fldOrderDescCaptionTextBox"
        Me.fldOrderDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5269687175750732R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDescCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDescCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDescCaptionTextBox.Value = "REMARKS"
        '
        'fldQTYCaptionTextBox
        '
        Me.fldQTYCaptionTextBox.CanGrow = True
        Me.fldQTYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.9270477294921875R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYCaptionTextBox.Name = "fldQTYCaptionTextBox"
        Me.fldQTYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldQTYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldQTYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYCaptionTextBox.StyleName = "Caption"
        Me.fldQTYCaptionTextBox.Value = "QTY"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.8270483016967773R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "TOTAL PO AMOUNT "
        '
        'fldCurrencyCaptionTextBox
        '
        Me.fldCurrencyCaptionTextBox.CanGrow = True
        Me.fldCurrencyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.72705078125R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyCaptionTextBox.Name = "fldCurrencyCaptionTextBox"
        Me.fldCurrencyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.85370826721191406R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldCurrencyCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldCurrencyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyCaptionTextBox.StyleName = "Caption"
        Me.fldCurrencyCaptionTextBox.Value = "CURRENCY"
        '
        'yENCaptionTextBox
        '
        Me.yENCaptionTextBox.CanGrow = True
        Me.yENCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.580837249755859R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.yENCaptionTextBox.Name = "yENCaptionTextBox"
        Me.yENCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.yENCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.yENCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.yENCaptionTextBox.StyleName = "Caption"
        Me.yENCaptionTextBox.Value = "JPY"
        '
        'uSDCaptionTextBox
        '
        Me.uSDCaptionTextBox.CanGrow = True
        Me.uSDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.580915451049805R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uSDCaptionTextBox.Name = "uSDCaptionTextBox"
        Me.uSDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.uSDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDCaptionTextBox.StyleName = "Caption"
        Me.uSDCaptionTextBox.Value = "USD"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.580995559692383R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0000002384185791R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pHPCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.pHPCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "PHP"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.127049446105957R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "DISCOUNT "
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.427050590515137R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "DISCOUNTED PO AMOUNT"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.581073760986328R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3729113340377808R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "SIGNATURE"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value"), New Telerik.Reporting.SqlDataSourceParameter("@PO", System.Data.DbType.[String], "=Parameters.PO.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_OrderList"
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
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.83515453338623R), Telerik.Reporting.Drawing.Unit.Inch(0.24976399540901184R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.821525573730469R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1324193477630615R), Telerik.Reporting.Drawing.Unit.Inch(0.24988201260566711R))
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "PageInfo"
        Me.TextBox18.Value = "Budget Actual Program (BAP)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.24003942310810089R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
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
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.753944396972656R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.23999999463558197R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
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
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.34216213226318359R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPONoDataTextBox, Me.fldPRNoDataTextBox, Me.fldOrderSupplierDataTextBox, Me.fldOrderDescDataTextBox, Me.fldCurrencyDataTextBox, Me.yENDataTextBox, Me.uSDDataTextBox, Me.pHPDataTextBox, Me.fldAmountJPYDataTextBox, Me.fldQTYDataTextBox, Me.SubReport1, Me.TextBox2, Me.TextBox4, Me.TextBox6})
        Me.detail.Name = "detail"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1539849042892456R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldPONoDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "= Fields.PO"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1541033983230591R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.472948431968689R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldPRNoDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "= Fields.PRNo"
        '
        'fldOrderSupplierDataTextBox
        '
        Me.fldOrderSupplierDataTextBox.CanGrow = True
        Me.fldOrderSupplierDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.62705135345459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierDataTextBox.Name = "fldOrderSupplierDataTextBox"
        Me.fldOrderSupplierDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7728703022003174R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldOrderSupplierDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldOrderSupplierDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderSupplierDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierDataTextBox.StyleName = "Data"
        Me.fldOrderSupplierDataTextBox.Value = "= Fields.fldSupplier"
        '
        'fldOrderDescDataTextBox
        '
        Me.fldOrderDescDataTextBox.CanGrow = True
        Me.fldOrderDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.40000057220459R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescDataTextBox.Name = "fldOrderDescDataTextBox"
        Me.fldOrderDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5269687175750732R), Telerik.Reporting.Drawing.Unit.Inch(0.28999990224838257R))
        Me.fldOrderDescDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldOrderDescDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderDescDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescDataTextBox.StyleName = "Data"
        Me.fldOrderDescDataTextBox.Value = "= Fields.fldRemarks"
        '
        'fldCurrencyDataTextBox
        '
        Me.fldCurrencyDataTextBox.CanGrow = True
        Me.fldCurrencyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.72705078125R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyDataTextBox.Name = "fldCurrencyDataTextBox"
        Me.fldCurrencyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.85370951890945435R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
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
        Me.yENDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.580837249755859R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.yENDataTextBox.Name = "yENDataTextBox"
        Me.yENDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999994039535522R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
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
        Me.uSDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.580916404724121R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.uSDDataTextBox.Name = "uSDDataTextBox"
        Me.uSDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0000004768371582R), Telerik.Reporting.Drawing.Unit.Inch(0.28996053338050842R))
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
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.580995559692383R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
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
        Me.fldAmountJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.8270492553710937R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYDataTextBox.Name = "fldAmountJPYDataTextBox"
        Me.fldAmountJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldAmountJPYDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldAmountJPYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldAmountJPYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYDataTextBox.StyleName = "Data"
        Me.fldAmountJPYDataTextBox.Value = "= Fields.fldTPO"
        '
        'fldQTYDataTextBox
        '
        Me.fldQTYDataTextBox.CanGrow = True
        Me.fldQTYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.9270486831665039R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYDataTextBox.Name = "fldQTYDataTextBox"
        Me.fldQTYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992141723632813R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.fldQTYDataTextBox.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.fldQTYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldQTYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYDataTextBox.StyleName = "Data"
        Me.fldQTYDataTextBox.Value = "= Fields.SumQTY"
        '
        'SubReport1
        '
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.2900787889957428R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("POBLine", "=Fields.OB_Line"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", "= Parameters.DEPT.Value"))
        InstanceReportSource1.ReportDocument = Me.RepOrderItem20171
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(20.953947067260742R), Telerik.Reporting.Drawing.Unit.Inch(0.052083343267440796R))
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.127049446105957R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
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
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.427050590515137R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.TextBox4.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.OB_POAmt"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.581073760986328R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3729103803634644R), Telerik.Reporting.Drawing.Unit.Inch(0.28999993205070496R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.LightBlue
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "= Fields.fldSignature"
        '
        'repOrderList2017
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(20.953983306884766R)
        CType(Me.RepOrderItem20171, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RepOrderItem20171 As ACCTNG.repOrderItem2017
End Class
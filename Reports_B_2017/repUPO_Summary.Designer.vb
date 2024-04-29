Partial Class repUPO_Summary2017

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
        Me.fldUPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldCurrencyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldJPYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOAmountCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldVcodeCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldSupplierCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldUDateCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDDateCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldStatCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldUPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldCurrencyDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldJPYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOAmountDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldVcodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldSupplierDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldUDateDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDDateDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldStatDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
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
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldUPONoCaptionTextBox, Me.fldPONoCaptionTextBox, Me.fldBudRefNumCaptionTextBox, Me.fldDeptCaptionTextBox, Me.fldClassCaptionTextBox, Me.fldCurrencyCaptionTextBox, Me.fldJPYCaptionTextBox, Me.fldOAmountCaptionTextBox, Me.fldVcodeCaptionTextBox, Me.fldSupplierCaptionTextBox, Me.fldUDateCaptionTextBox, Me.fldDDateCaptionTextBox, Me.fldStatCaptionTextBox, Me.TextBox3, Me.TextBox5})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldUPONoCaptionTextBox
        '
        Me.fldUPONoCaptionTextBox.CanGrow = True
        Me.fldUPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUPONoCaptionTextBox.Name = "fldUPONoCaptionTextBox"
        Me.fldUPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldUPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUPONoCaptionTextBox.StyleName = "Caption"
        Me.fldUPONoCaptionTextBox.Value = "ID"
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.40007877349853516R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "PURCHASE ORDER NO."
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6001577377319336R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFERENCE NO."
        '
        'fldDeptCaptionTextBox
        '
        Me.fldDeptCaptionTextBox.CanGrow = True
        Me.fldDeptCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.800236701965332R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCaptionTextBox.Name = "fldDeptCaptionTextBox"
        Me.fldDeptCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDeptCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCaptionTextBox.StyleName = "Caption"
        Me.fldDeptCaptionTextBox.Value = "DEPARTMENT"
        '
        'fldClassCaptionTextBox
        '
        Me.fldClassCaptionTextBox.CanGrow = True
        Me.fldClassCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0003156661987305R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassCaptionTextBox.Name = "fldClassCaptionTextBox"
        Me.fldClassCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldClassCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassCaptionTextBox.StyleName = "Caption"
        Me.fldClassCaptionTextBox.Value = "CLASSIFICATION"
        '
        'fldCurrencyCaptionTextBox
        '
        Me.fldCurrencyCaptionTextBox.CanGrow = True
        Me.fldCurrencyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2003941535949707R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyCaptionTextBox.Name = "fldCurrencyCaptionTextBox"
        Me.fldCurrencyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldCurrencyCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldCurrencyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyCaptionTextBox.StyleName = "Caption"
        Me.fldCurrencyCaptionTextBox.Value = "CURRENCY"
        '
        'fldJPYCaptionTextBox
        '
        Me.fldJPYCaptionTextBox.CanGrow = True
        Me.fldJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.10047435760498R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldJPYCaptionTextBox.Name = "fldJPYCaptionTextBox"
        Me.fldJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5994489192962646R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldJPYCaptionTextBox.StyleName = "Caption"
        Me.fldJPYCaptionTextBox.Value = "AMOUNT JPY SAP"
        '
        'fldOAmountCaptionTextBox
        '
        Me.fldOAmountCaptionTextBox.CanGrow = True
        Me.fldOAmountCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4004731178283691R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOAmountCaptionTextBox.Name = "fldOAmountCaptionTextBox"
        Me.fldOAmountCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999220848083496R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOAmountCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOAmountCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOAmountCaptionTextBox.StyleName = "Caption"
        Me.fldOAmountCaptionTextBox.Value = "ORIGINAL AMOUNT"
        '
        'fldVcodeCaptionTextBox
        '
        Me.fldVcodeCaptionTextBox.CanGrow = True
        Me.fldVcodeCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.89905834197998R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldVcodeCaptionTextBox.Name = "fldVcodeCaptionTextBox"
        Me.fldVcodeCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000005960464478R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldVcodeCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldVcodeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldVcodeCaptionTextBox.StyleName = "Caption"
        Me.fldVcodeCaptionTextBox.Value = "VENDOR CODE"
        '
        'fldSupplierCaptionTextBox
        '
        Me.fldSupplierCaptionTextBox.CanGrow = True
        Me.fldSupplierCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.899136543273926R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldSupplierCaptionTextBox.Name = "fldSupplierCaptionTextBox"
        Me.fldSupplierCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999996185302734R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldSupplierCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldSupplierCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSupplierCaptionTextBox.StyleName = "Caption"
        Me.fldSupplierCaptionTextBox.Value = "SUPPLIER NAME"
        '
        'fldUDateCaptionTextBox
        '
        Me.fldUDateCaptionTextBox.CanGrow = True
        Me.fldUDateCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.299214363098145R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUDateCaptionTextBox.Name = "fldUDateCaptionTextBox"
        Me.fldUDateCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUDateCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldUDateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUDateCaptionTextBox.StyleName = "Caption"
        Me.fldUDateCaptionTextBox.Value = "UPLOADED DATE"
        '
        'fldDDateCaptionTextBox
        '
        Me.fldDDateCaptionTextBox.CanGrow = True
        Me.fldDDateCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.500158309936523R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDDateCaptionTextBox.Name = "fldDDateCaptionTextBox"
        Me.fldDDateCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDDateCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDDateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDDateCaptionTextBox.StyleName = "Caption"
        Me.fldDDateCaptionTextBox.Value = "DELIVERY DATE"
        '
        'fldStatCaptionTextBox
        '
        Me.fldStatCaptionTextBox.CanGrow = True
        Me.fldStatCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.700235366821289R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldStatCaptionTextBox.Name = "fldStatCaptionTextBox"
        Me.fldStatCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89905601739883423R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldStatCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldStatCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatCaptionTextBox.StyleName = "Caption"
        Me.fldStatCaptionTextBox.Value = "STATUS"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.70000171661377R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5994489192962646R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "AMOUNT JPY BAP"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.299530029296875R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5994489192962646R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "FOREX"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_Select_UPO"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox16, Me.TextBox1})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.300000190734863R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2999613285064697R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.StyleName = "PageInfo"
        Me.TextBox16.Value = "Budget Actual Program (BAP)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8001582622528076R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox1.StyleName = "PageInfo"
        Me.TextBox1.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000003576278687R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039458274841308594R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8001189231872559R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.299214363098145R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.300076961517334R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.45999997854232788R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(18.599292755126953R), Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Uploaded Purchase Order Summary"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldUPONoDataTextBox, Me.fldPONoDataTextBox, Me.fldBudRefNumDataTextBox, Me.fldDeptDataTextBox, Me.fldClassDataTextBox, Me.fldCurrencyDataTextBox, Me.fldJPYDataTextBox, Me.fldOAmountDataTextBox, Me.fldVcodeDataTextBox, Me.fldSupplierDataTextBox, Me.fldUDateDataTextBox, Me.fldDDateDataTextBox, Me.fldStatDataTextBox, Me.TextBox2, Me.TextBox4})
        Me.detail.Name = "detail"
        '
        'fldUPONoDataTextBox
        '
        Me.fldUPONoDataTextBox.CanGrow = True
        Me.fldUPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUPONoDataTextBox.Name = "fldUPONoDataTextBox"
        Me.fldUPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldUPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUPONoDataTextBox.StyleName = "Data"
        Me.fldUPONoDataTextBox.Value = "=Fields.fldUPONo"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.40007877349853516R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "=Fields.fldPONo"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6001577377319336R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=Fields.fldBudRefNum"
        '
        'fldDeptDataTextBox
        '
        Me.fldDeptDataTextBox.CanGrow = True
        Me.fldDeptDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.800236701965332R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptDataTextBox.Name = "fldDeptDataTextBox"
        Me.fldDeptDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptDataTextBox.StyleName = "Data"
        Me.fldDeptDataTextBox.Value = "=Fields.fldDept"
        '
        'fldClassDataTextBox
        '
        Me.fldClassDataTextBox.CanGrow = True
        Me.fldClassDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0003151893615723R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassDataTextBox.Name = "fldClassDataTextBox"
        Me.fldClassDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldClassDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassDataTextBox.StyleName = "Data"
        Me.fldClassDataTextBox.Value = "=Fields.fldClass"
        '
        'fldCurrencyDataTextBox
        '
        Me.fldCurrencyDataTextBox.CanGrow = True
        Me.fldCurrencyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2003941535949707R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyDataTextBox.Name = "fldCurrencyDataTextBox"
        Me.fldCurrencyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldCurrencyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldCurrencyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldCurrencyDataTextBox.StyleName = "Data"
        Me.fldCurrencyDataTextBox.Value = "=Fields.fldCurrency"
        '
        'fldJPYDataTextBox
        '
        Me.fldJPYDataTextBox.CanGrow = True
        Me.fldJPYDataTextBox.Format = "{0:N2}"
        Me.fldJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.10047435760498R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldJPYDataTextBox.Name = "fldJPYDataTextBox"
        Me.fldJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5994476079940796R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldJPYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldJPYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldJPYDataTextBox.StyleName = "Data"
        Me.fldJPYDataTextBox.Value = "=Fields.fldJPY"
        '
        'fldOAmountDataTextBox
        '
        Me.fldOAmountDataTextBox.CanGrow = True
        Me.fldOAmountDataTextBox.Format = "{0:N2}"
        Me.fldOAmountDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4004731178283691R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldOAmountDataTextBox.Name = "fldOAmountDataTextBox"
        Me.fldOAmountDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999220848083496R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOAmountDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOAmountDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOAmountDataTextBox.StyleName = "Data"
        Me.fldOAmountDataTextBox.Value = "=Fields.fldOAmount"
        '
        'fldVcodeDataTextBox
        '
        Me.fldVcodeDataTextBox.CanGrow = True
        Me.fldVcodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.89905834197998R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldVcodeDataTextBox.Name = "fldVcodeDataTextBox"
        Me.fldVcodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000005960464478R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldVcodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldVcodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldVcodeDataTextBox.StyleName = "Data"
        Me.fldVcodeDataTextBox.Value = "=Fields.fldVcode"
        '
        'fldSupplierDataTextBox
        '
        Me.fldSupplierDataTextBox.CanGrow = True
        Me.fldSupplierDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.899136543273926R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldSupplierDataTextBox.Name = "fldSupplierDataTextBox"
        Me.fldSupplierDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4008642435073853R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldSupplierDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldSupplierDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSupplierDataTextBox.StyleName = "Data"
        Me.fldSupplierDataTextBox.Value = "=Fields.fldSupplier"
        '
        'fldUDateDataTextBox
        '
        Me.fldUDateDataTextBox.CanGrow = True
        Me.fldUDateDataTextBox.Format = "{0:d}"
        Me.fldUDateDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.300079345703125R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUDateDataTextBox.Name = "fldUDateDataTextBox"
        Me.fldUDateDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUDateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldUDateDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUDateDataTextBox.StyleName = "Data"
        Me.fldUDateDataTextBox.Value = "=Fields.fldUDate"
        '
        'fldDDateDataTextBox
        '
        Me.fldDDateDataTextBox.CanGrow = True
        Me.fldDDateDataTextBox.Format = "{0:d}"
        Me.fldDDateDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.500158309936523R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDDateDataTextBox.Name = "fldDDateDataTextBox"
        Me.fldDDateDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDDateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDDateDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDDateDataTextBox.StyleName = "Data"
        Me.fldDDateDataTextBox.Value = "=Fields.fldDDate"
        '
        'fldStatDataTextBox
        '
        Me.fldStatDataTextBox.CanGrow = True
        Me.fldStatDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.700235366821289R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldStatDataTextBox.Name = "fldStatDataTextBox"
        Me.fldStatDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89905601739883423R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldStatDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldStatDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatDataTextBox.StyleName = "Data"
        Me.fldStatDataTextBox.Value = "=Fields.fldStat"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.7000036239624023R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5994476079940796R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.fldJPYBAP"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.299530029296875R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5994476079940796R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "=Fields.fldForex"
        '
        'repUPO_Summary2017
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repUPO_Summary"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "DEPT"
        ReportParameter1.Text = "DEPT"
        ReportParameter2.Name = "D1"
        ReportParameter2.Text = "D1"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "D2"
        ReportParameter3.Text = "D2"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(18.59996223449707R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fldUPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldCurrencyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldJPYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOAmountCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldVcodeCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSupplierCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUDateCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDDateCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fldUPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldCurrencyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldJPYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOAmountDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldVcodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSupplierDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUDateDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDDateDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
End Class
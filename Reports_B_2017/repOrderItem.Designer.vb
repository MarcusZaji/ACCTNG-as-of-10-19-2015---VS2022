Partial Class repOrderItem2017

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDescCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldICodeCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMOIIDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthDeliveryCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldStatCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldTotalCostCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldUnitCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldUPriceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldSignatureCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDescDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldICodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMOIIDDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthDeliveryDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldUPriceDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldUnitDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldTotalCostDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldStatDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldSignatureDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumCaptionTextBox, Me.fldDescCaptionTextBox, Me.fldICodeCaptionTextBox, Me.fldMOIIDCaptionTextBox, Me.fldMonthDeliveryCaptionTextBox, Me.fldQTYCaptionTextBox, Me.fldStatCaptionTextBox, Me.fldTotalCostCaptionTextBox, Me.fldUnitCaptionTextBox, Me.fldUPriceCaptionTextBox, Me.fldSignatureCaptionTextBox, Me.TextBox1, Me.TextBox3})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.647727370262146R), Telerik.Reporting.Drawing.Unit.Inch(0.29992127418518066R))
        Me.fldBudRefNumCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFFERENCE NO."
        '
        'fldDescCaptionTextBox
        '
        Me.fldDescCaptionTextBox.CanGrow = True
        Me.fldDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2747790813446045R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDescCaptionTextBox.Name = "fldDescCaptionTextBox"
        Me.fldDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.29996061325073242R))
        Me.fldDescCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldDescCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDescCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDescCaptionTextBox.StyleName = "Caption"
        Me.fldDescCaptionTextBox.Value = "DESCRIPTION"
        '
        'fldICodeCaptionTextBox
        '
        Me.fldICodeCaptionTextBox.CanGrow = True
        Me.fldICodeCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6478067636489868R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldICodeCaptionTextBox.Name = "fldICodeCaptionTextBox"
        Me.fldICodeCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldICodeCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldICodeCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldICodeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldICodeCaptionTextBox.StyleName = "Caption"
        Me.fldICodeCaptionTextBox.Value = "ITEM CODE"
        '
        'fldMOIIDCaptionTextBox
        '
        Me.fldMOIIDCaptionTextBox.CanGrow = True
        Me.fldMOIIDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9017524719238281R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMOIIDCaptionTextBox.Name = "fldMOIIDCaptionTextBox"
        Me.fldMOIIDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldMOIIDCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldMOIIDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMOIIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMOIIDCaptionTextBox.StyleName = "Caption"
        Me.fldMOIIDCaptionTextBox.Value = "PR NUMBER"
        '
        'fldMonthDeliveryCaptionTextBox
        '
        Me.fldMonthDeliveryCaptionTextBox.CanGrow = True
        Me.fldMonthDeliveryCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5287261009216309R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMonthDeliveryCaptionTextBox.Name = "fldMonthDeliveryCaptionTextBox"
        Me.fldMonthDeliveryCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2712745666503906R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldMonthDeliveryCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldMonthDeliveryCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMonthDeliveryCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMonthDeliveryCaptionTextBox.StyleName = "Caption"
        Me.fldMonthDeliveryCaptionTextBox.Value = "DELIVERY MONTH"
        '
        'fldQTYCaptionTextBox
        '
        Me.fldQTYCaptionTextBox.CanGrow = True
        Me.fldQTYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0714321136474609R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYCaptionTextBox.Name = "fldQTYCaptionTextBox"
        Me.fldQTYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8443024754524231R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldQTYCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldQTYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldQTYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYCaptionTextBox.StyleName = "Caption"
        Me.fldQTYCaptionTextBox.Value = "QTY"
        '
        'fldStatCaptionTextBox
        '
        Me.fldStatCaptionTextBox.CanGrow = True
        Me.fldStatCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.5427827835083R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldStatCaptionTextBox.Name = "fldStatCaptionTextBox"
        Me.fldStatCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldStatCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldStatCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldStatCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatCaptionTextBox.StyleName = "Caption"
        Me.fldStatCaptionTextBox.Value = "CURRENCY"
        '
        'fldTotalCostCaptionTextBox
        '
        Me.fldTotalCostCaptionTextBox.CanGrow = True
        Me.fldTotalCostCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.169756889343262R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldTotalCostCaptionTextBox.Name = "fldTotalCostCaptionTextBox"
        Me.fldTotalCostCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldTotalCostCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldTotalCostCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldTotalCostCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldTotalCostCaptionTextBox.StyleName = "Caption"
        Me.fldTotalCostCaptionTextBox.Value = "TOTAL COST"
        '
        'fldUnitCaptionTextBox
        '
        Me.fldUnitCaptionTextBox.CanGrow = True
        Me.fldUnitCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.796732902526855R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUnitCaptionTextBox.Name = "fldUnitCaptionTextBox"
        Me.fldUnitCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldUnitCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldUnitCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldUnitCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUnitCaptionTextBox.StyleName = "Caption"
        Me.fldUnitCaptionTextBox.Value = "UNIT"
        '
        'fldUPriceCaptionTextBox
        '
        Me.fldUPriceCaptionTextBox.CanGrow = True
        Me.fldUPriceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.4237117767334R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUPriceCaptionTextBox.Name = "fldUPriceCaptionTextBox"
        Me.fldUPriceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldUPriceCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldUPriceCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldUPriceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUPriceCaptionTextBox.StyleName = "Caption"
        Me.fldUPriceCaptionTextBox.Value = "UNIT PRICE"
        '
        'fldSignatureCaptionTextBox
        '
        Me.fldSignatureCaptionTextBox.CanGrow = True
        Me.fldSignatureCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.050682067871094R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldSignatureCaptionTextBox.Name = "fldSignatureCaptionTextBox"
        Me.fldSignatureCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.fldSignatureCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.fldSignatureCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldSignatureCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSignatureCaptionTextBox.StyleName = "Caption"
        Me.fldSignatureCaptionTextBox.Value = "SIGNATURE"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.9158124923706055R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "JPY AMOUNT"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.8000783920288086R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2712745666503906R), Telerik.Reporting.Drawing.Unit.Inch(0.2999606728553772R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "MONTH ORDERED"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@POB_Line", System.Data.DbType.[String], "=Parameters.POBLine.Value"), New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_OrderItems"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2791273295879364R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumDataTextBox, Me.fldDescDataTextBox, Me.fldICodeDataTextBox, Me.fldMOIIDDataTextBox, Me.fldMonthDeliveryDataTextBox, Me.fldQTYDataTextBox, Me.fldUPriceDataTextBox, Me.fldUnitDataTextBox, Me.fldTotalCostDataTextBox, Me.fldStatDataTextBox, Me.fldSignatureDataTextBox, Me.TextBox2, Me.TextBox4})
        Me.detail.Name = "detail"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(-0.000000013245476715439963R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.647727370262146R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldBudRefNumDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "= Fields.fldBudRefNum"
        '
        'fldDescDataTextBox
        '
        Me.fldDescDataTextBox.CanGrow = True
        Me.fldDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6478067636489868R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDescDataTextBox.Name = "fldDescDataTextBox"
        Me.fldDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldDescDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldDescDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDescDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDescDataTextBox.StyleName = "Data"
        Me.fldDescDataTextBox.Value = "= Fields.fldICode"
        '
        'fldICodeDataTextBox
        '
        Me.fldICodeDataTextBox.CanGrow = True
        Me.fldICodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2747793197631836R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldICodeDataTextBox.Name = "fldICodeDataTextBox"
        Me.fldICodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldICodeDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldICodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldICodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldICodeDataTextBox.StyleName = "Data"
        Me.fldICodeDataTextBox.Value = "= Fields.fldDesc"
        '
        'fldMOIIDDataTextBox
        '
        Me.fldMOIIDDataTextBox.CanGrow = True
        Me.fldMOIIDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9017524719238281R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMOIIDDataTextBox.Name = "fldMOIIDDataTextBox"
        Me.fldMOIIDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldMOIIDDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldMOIIDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMOIIDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMOIIDDataTextBox.StyleName = "Data"
        Me.fldMOIIDDataTextBox.Value = "= Fields.fldPRNo"
        '
        'fldMonthDeliveryDataTextBox
        '
        Me.fldMonthDeliveryDataTextBox.CanGrow = True
        Me.fldMonthDeliveryDataTextBox.Format = "{0:d}"
        Me.fldMonthDeliveryDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5287251472473145R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMonthDeliveryDataTextBox.Name = "fldMonthDeliveryDataTextBox"
        Me.fldMonthDeliveryDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2712745666503906R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldMonthDeliveryDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldMonthDeliveryDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMonthDeliveryDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMonthDeliveryDataTextBox.StyleName = "Data"
        Me.fldMonthDeliveryDataTextBox.Value = "= Fields.fldMonthDelivery"
        '
        'fldQTYDataTextBox
        '
        Me.fldQTYDataTextBox.CanGrow = True
        Me.fldQTYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0714330673217773R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYDataTextBox.Name = "fldQTYDataTextBox"
        Me.fldQTYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8443024754524231R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldQTYDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldQTYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldQTYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYDataTextBox.StyleName = "Data"
        Me.fldQTYDataTextBox.Value = "= Fields.fldQTY"
        '
        'fldUPriceDataTextBox
        '
        Me.fldUPriceDataTextBox.CanGrow = True
        Me.fldUPriceDataTextBox.Format = "{0:N2}"
        Me.fldUPriceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.4237117767334R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUPriceDataTextBox.Name = "fldUPriceDataTextBox"
        Me.fldUPriceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldUPriceDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldUPriceDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldUPriceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUPriceDataTextBox.StyleName = "Data"
        Me.fldUPriceDataTextBox.Value = "= Fields.fldUPrice"
        '
        'fldUnitDataTextBox
        '
        Me.fldUnitDataTextBox.CanGrow = True
        Me.fldUnitDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.796737670898437R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUnitDataTextBox.Name = "fldUnitDataTextBox"
        Me.fldUnitDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldUnitDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldUnitDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldUnitDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUnitDataTextBox.StyleName = "Data"
        Me.fldUnitDataTextBox.Value = "= Fields.fldUnit"
        '
        'fldTotalCostDataTextBox
        '
        Me.fldTotalCostDataTextBox.CanGrow = True
        Me.fldTotalCostDataTextBox.Format = "{0:N2}"
        Me.fldTotalCostDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.169765472412109R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldTotalCostDataTextBox.Name = "fldTotalCostDataTextBox"
        Me.fldTotalCostDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldTotalCostDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldTotalCostDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldTotalCostDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldTotalCostDataTextBox.StyleName = "Data"
        Me.fldTotalCostDataTextBox.Value = "= Fields.fldTotalCost"
        '
        'fldStatDataTextBox
        '
        Me.fldStatDataTextBox.CanGrow = True
        Me.fldStatDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.542784690856934R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldStatDataTextBox.Name = "fldStatDataTextBox"
        Me.fldStatDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldStatDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldStatDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldStatDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatDataTextBox.StyleName = "Data"
        Me.fldStatDataTextBox.Value = "= Fields.fldCurrency"
        '
        'fldSignatureDataTextBox
        '
        Me.fldSignatureDataTextBox.CanGrow = True
        Me.fldSignatureDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.050683975219727R), Telerik.Reporting.Drawing.Unit.Inch(0.00011813640594482422R))
        Me.fldSignatureDataTextBox.Name = "fldSignatureDataTextBox"
        Me.fldSignatureDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.fldSignatureDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldSignatureDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldSignatureDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSignatureDataTextBox.StyleName = "Data"
        Me.fldSignatureDataTextBox.Value = "= Fields.fldSignature"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.9158134460449219R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6268939971923828R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.fldYenSap"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:d}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.8000788688659668R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2712745666503906R), Telerik.Reporting.Drawing.Unit.Inch(0.279127299785614R))
        Me.TextBox4.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.fldMO"
        '
        'repOrderItem2017
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.detail})
        Me.Name = "repOrderItem"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "POBLine"
        ReportParameter1.Text = "POBLine"
        ReportParameter2.Name = "DEPT"
        ReportParameter2.Text = "DEPT"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(19.677576065063477R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDescDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldICodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMOIIDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthDeliveryDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSignatureDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUPriceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUnitDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldTotalCostDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDescCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldICodeCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMOIIDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthDeliveryCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSignatureCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldTotalCostCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUnitCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUPriceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
End Class
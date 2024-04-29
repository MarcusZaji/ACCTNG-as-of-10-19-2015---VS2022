Partial Class repAAItems2017

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.byearCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldCurrencyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthAcquiredCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDescCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldUOMCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pHPCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.uSDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.yENCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderSupplierCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderRemarksCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.byearDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldCurrencyDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthAcquiredDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDescDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderRemarksDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderSupplierDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldUOMDataTextBox = New Telerik.Reporting.TextBox()
        Me.pHPDataTextBox = New Telerik.Reporting.TextBox()
        Me.uSDDataTextBox = New Telerik.Reporting.TextBox()
        Me.yENDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentDataTextBox = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052083350718021393R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4000394344329834R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.byearCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldBudRefNumCaptionTextBox, Me.fldClassificationCaptionTextBox, Me.fldCurrencyCaptionTextBox, Me.fldMonthAcquiredCaptionTextBox, Me.fldOrderDepartmentCaptionTextBox, Me.fldOrderDescCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.fldUOMCaptionTextBox, Me.pHPCaptionTextBox, Me.uSDCaptionTextBox, Me.yENCaptionTextBox, Me.fldQTYCaptionTextBox, Me.fldPONoCaptionTextBox, Me.fldOrderSupplierCaptionTextBox, Me.fldOrderRemarksCaptionTextBox})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'byearCaptionTextBox
        '
        Me.byearCaptionTextBox.CanGrow = True
        Me.byearCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.byearCaptionTextBox.Name = "byearCaptionTextBox"
        Me.byearCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.byearCaptionTextBox.StyleName = "Caption"
        Me.byearCaptionTextBox.Value = "YEAR"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1844552755355835R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "Original Amount"
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3480768203735352R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "Ref Num"
        '
        'fldClassificationCaptionTextBox
        '
        Me.fldClassificationCaptionTextBox.CanGrow = True
        Me.fldClassificationCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5116996765136719R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldClassificationCaptionTextBox.Name = "fldClassificationCaptionTextBox"
        Me.fldClassificationCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassificationCaptionTextBox.StyleName = "Caption"
        Me.fldClassificationCaptionTextBox.Value = "Classification"
        '
        'fldCurrencyCaptionTextBox
        '
        Me.fldCurrencyCaptionTextBox.CanGrow = True
        Me.fldCurrencyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6753196716308594R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyCaptionTextBox.Name = "fldCurrencyCaptionTextBox"
        Me.fldCurrencyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldCurrencyCaptionTextBox.StyleName = "Caption"
        Me.fldCurrencyCaptionTextBox.Value = "Currency"
        '
        'fldMonthAcquiredCaptionTextBox
        '
        Me.fldMonthAcquiredCaptionTextBox.CanGrow = True
        Me.fldMonthAcquiredCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8389420509338379R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMonthAcquiredCaptionTextBox.Name = "fldMonthAcquiredCaptionTextBox"
        Me.fldMonthAcquiredCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMonthAcquiredCaptionTextBox.StyleName = "Caption"
        Me.fldMonthAcquiredCaptionTextBox.Value = "Month Acquired"
        '
        'fldOrderDepartmentCaptionTextBox
        '
        Me.fldOrderDepartmentCaptionTextBox.CanGrow = True
        Me.fldOrderDepartmentCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.0025639533996582R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDepartmentCaptionTextBox.Name = "fldOrderDepartmentCaptionTextBox"
        Me.fldOrderDepartmentCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDepartmentCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDepartmentCaptionTextBox.Value = "Order Department"
        '
        'fldOrderDescCaptionTextBox
        '
        Me.fldOrderDescCaptionTextBox.CanGrow = True
        Me.fldOrderDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1661834716796875R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescCaptionTextBox.Name = "fldOrderDescCaptionTextBox"
        Me.fldOrderDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDescCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDescCaptionTextBox.Value = "Description"
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.820667266845703R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "PR"
        '
        'fldUOMCaptionTextBox
        '
        Me.fldUOMCaptionTextBox.CanGrow = True
        Me.fldUOMCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.147910118103027R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldUOMCaptionTextBox.Name = "fldUOMCaptionTextBox"
        Me.fldUOMCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUOMCaptionTextBox.StyleName = "Caption"
        Me.fldUOMCaptionTextBox.Value = "UOM"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.320661544799805R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "PHP"
        '
        'uSDCaptionTextBox
        '
        Me.uSDCaptionTextBox.CanGrow = True
        Me.uSDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.484281539916992R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.uSDCaptionTextBox.Name = "uSDCaptionTextBox"
        Me.uSDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDCaptionTextBox.StyleName = "Caption"
        Me.uSDCaptionTextBox.Value = "USD"
        '
        'yENCaptionTextBox
        '
        Me.yENCaptionTextBox.CanGrow = True
        Me.yENCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.647903442382813R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.yENCaptionTextBox.Name = "yENCaptionTextBox"
        Me.yENCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.yENCaptionTextBox.StyleName = "Caption"
        Me.yENCaptionTextBox.Value = "YEN"
        '
        'fldQTYCaptionTextBox
        '
        Me.fldQTYCaptionTextBox.CanGrow = True
        Me.fldQTYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.984291076660156R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYCaptionTextBox.Name = "fldQTYCaptionTextBox"
        Me.fldQTYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldQTYCaptionTextBox.StyleName = "Caption"
        Me.fldQTYCaptionTextBox.Value = "QTY"
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.657044410705566R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "PO"
        '
        'fldOrderSupplierCaptionTextBox
        '
        Me.fldOrderSupplierCaptionTextBox.CanGrow = True
        Me.fldOrderSupplierCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.493424415588379R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierCaptionTextBox.Name = "fldOrderSupplierCaptionTextBox"
        Me.fldOrderSupplierCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderSupplierCaptionTextBox.StyleName = "Caption"
        Me.fldOrderSupplierCaptionTextBox.Value = "Supplier"
        '
        'fldOrderRemarksCaptionTextBox
        '
        Me.fldOrderRemarksCaptionTextBox.CanGrow = True
        Me.fldOrderRemarksCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.329803466796875R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderRemarksCaptionTextBox.Name = "fldOrderRemarksCaptionTextBox"
        Me.fldOrderRemarksCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderRemarksCaptionTextBox.StyleName = "Caption"
        Me.fldOrderRemarksCaptionTextBox.Value = "Remarks"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000003576278687R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.byearDataTextBox, Me.fldAmountJPYDataTextBox, Me.fldBudRefNumDataTextBox, Me.fldClassificationDataTextBox, Me.fldCurrencyDataTextBox, Me.fldMonthAcquiredDataTextBox, Me.fldOrderDescDataTextBox, Me.fldOrderRemarksDataTextBox, Me.fldOrderSupplierDataTextBox, Me.fldPONoDataTextBox, Me.fldUOMDataTextBox, Me.pHPDataTextBox, Me.uSDDataTextBox, Me.yENDataTextBox, Me.fldQTYDataTextBox, Me.fldPRNoDataTextBox, Me.fldOrderDepartmentDataTextBox})
        Me.detail.Name = "detail"
        '
        'byearDataTextBox
        '
        Me.byearDataTextBox.CanGrow = True
        Me.byearDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.byearDataTextBox.Name = "byearDataTextBox"
        Me.byearDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.byearDataTextBox.StyleName = "Data"
        Me.byearDataTextBox.Value = "=Fields.Byear"
        '
        'fldAmountJPYDataTextBox
        '
        Me.fldAmountJPYDataTextBox.CanGrow = True
        Me.fldAmountJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1844557523727417R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYDataTextBox.Name = "fldAmountJPYDataTextBox"
        Me.fldAmountJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountJPYDataTextBox.StyleName = "Data"
        Me.fldAmountJPYDataTextBox.Value = "=Fields.fldAmountJPY"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3480777740478516R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=Fields.fldBudRefNum"
        '
        'fldClassificationDataTextBox
        '
        Me.fldClassificationDataTextBox.CanGrow = True
        Me.fldClassificationDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.51170015335083R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassificationDataTextBox.Name = "fldClassificationDataTextBox"
        Me.fldClassificationDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassificationDataTextBox.StyleName = "Data"
        Me.fldClassificationDataTextBox.Value = "=Fields.fldClassification"
        '
        'fldCurrencyDataTextBox
        '
        Me.fldCurrencyDataTextBox.CanGrow = True
        Me.fldCurrencyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6753206253051758R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldCurrencyDataTextBox.Name = "fldCurrencyDataTextBox"
        Me.fldCurrencyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldCurrencyDataTextBox.StyleName = "Data"
        Me.fldCurrencyDataTextBox.Value = "=Fields.fldCurrency"
        '
        'fldMonthAcquiredDataTextBox
        '
        Me.fldMonthAcquiredDataTextBox.CanGrow = True
        Me.fldMonthAcquiredDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8389420509338379R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMonthAcquiredDataTextBox.Name = "fldMonthAcquiredDataTextBox"
        Me.fldMonthAcquiredDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMonthAcquiredDataTextBox.StyleName = "Data"
        Me.fldMonthAcquiredDataTextBox.Value = "=Fields.fldMonthAcquired"
        '
        'fldOrderDescDataTextBox
        '
        Me.fldOrderDescDataTextBox.CanGrow = True
        Me.fldOrderDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1661825180053711R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescDataTextBox.Name = "fldOrderDescDataTextBox"
        Me.fldOrderDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDescDataTextBox.StyleName = "Data"
        Me.fldOrderDescDataTextBox.Value = "=Fields.fldOrderDesc"
        '
        'fldOrderRemarksDataTextBox
        '
        Me.fldOrderRemarksDataTextBox.CanGrow = True
        Me.fldOrderRemarksDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3298025131225586R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderRemarksDataTextBox.Name = "fldOrderRemarksDataTextBox"
        Me.fldOrderRemarksDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderRemarksDataTextBox.StyleName = "Data"
        Me.fldOrderRemarksDataTextBox.Value = "=Fields.fldOrderRemarks"
        '
        'fldOrderSupplierDataTextBox
        '
        Me.fldOrderSupplierDataTextBox.CanGrow = True
        Me.fldOrderSupplierDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.493424415588379R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierDataTextBox.Name = "fldOrderSupplierDataTextBox"
        Me.fldOrderSupplierDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderSupplierDataTextBox.StyleName = "Data"
        Me.fldOrderSupplierDataTextBox.Value = "=Fields.fldOrderSupplier"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.657044410705566R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "=Fields.fldPONo"
        '
        'fldUOMDataTextBox
        '
        Me.fldUOMDataTextBox.CanGrow = True
        Me.fldUOMDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.147910118103027R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUOMDataTextBox.Name = "fldUOMDataTextBox"
        Me.fldUOMDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUOMDataTextBox.StyleName = "Data"
        Me.fldUOMDataTextBox.Value = "=Fields.fldUOM"
        '
        'pHPDataTextBox
        '
        Me.pHPDataTextBox.CanGrow = True
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.320663452148437R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pHPDataTextBox.StyleName = "Data"
        Me.pHPDataTextBox.Value = "=Fields.PHP"
        '
        'uSDDataTextBox
        '
        Me.uSDDataTextBox.CanGrow = True
        Me.uSDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.484287261962891R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uSDDataTextBox.Name = "uSDDataTextBox"
        Me.uSDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDDataTextBox.StyleName = "Data"
        Me.uSDDataTextBox.Value = "=Fields.USD"
        '
        'yENDataTextBox
        '
        Me.yENDataTextBox.CanGrow = True
        Me.yENDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.647903442382813R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.yENDataTextBox.Name = "yENDataTextBox"
        Me.yENDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.yENDataTextBox.StyleName = "Data"
        Me.yENDataTextBox.Value = "=Fields.YEN"
        '
        'fldQTYDataTextBox
        '
        Me.fldQTYDataTextBox.CanGrow = True
        Me.fldQTYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.984291076660156R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYDataTextBox.Name = "fldQTYDataTextBox"
        Me.fldQTYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldQTYDataTextBox.StyleName = "Data"
        Me.fldQTYDataTextBox.Value = "=Fields.fldQTY"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.820667266845703R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "=Fields.fldPRNo"
        '
        'fldOrderDepartmentDataTextBox
        '
        Me.fldOrderDepartmentDataTextBox.CanGrow = True
        Me.fldOrderDepartmentDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.0025639533996582R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDepartmentDataTextBox.Name = "fldOrderDepartmentDataTextBox"
        Me.fldOrderDepartmentDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1635422706604004R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDepartmentDataTextBox.StyleName = "Data"
        Me.fldOrderDepartmentDataTextBox.Value = "=Fields.fldOrderDepartment"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@TC222", System.Data.DbType.[String], "=Parameters.TC.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_AAItems"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'repAAItems2017
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.detail})
        Me.Name = "repAAItems"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "TC"
        ReportParameter1.Text = "TC"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(19.811445236206055R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents byearCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldCurrencyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthAcquiredCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDescCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUOMCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents yENCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderSupplierCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderRemarksCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents byearDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldCurrencyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthAcquiredDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDescDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderRemarksDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderSupplierDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUOMDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents yENDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
End Class
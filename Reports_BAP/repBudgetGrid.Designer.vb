Partial Class repBudgetGrid

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.fldStatCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldProcessCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pHPCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.uSDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.byearCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMBudgetedCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMForecastedCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.byearDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMBudgetedDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMForecastedDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldProcessDataTextBox = New Telerik.Reporting.TextBox()
        Me.pHPDataTextBox = New Telerik.Reporting.TextBox()
        Me.uSDDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldStatDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.ReportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4000396728515625R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldStatCaptionTextBox, Me.fldBudRefNumCaptionTextBox, Me.fldProcessCaptionTextBox, Me.pHPCaptionTextBox, Me.uSDCaptionTextBox, Me.byearCaptionTextBox, Me.fldDeptCaptionTextBox, Me.fldClassCaptionTextBox, Me.fldMBudgetedCaptionTextBox, Me.fldAmountCaptionTextBox, Me.fldMForecastedCaptionTextBox, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox1})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldStatCaptionTextBox
        '
        Me.fldStatCaptionTextBox.CanGrow = True
        Me.fldStatCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6501575708389282R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldStatCaptionTextBox.Name = "fldStatCaptionTextBox"
        Me.fldStatCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.44984236359596252R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldStatCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldStatCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldStatCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatCaptionTextBox.StyleName = "Caption"
        Me.fldStatCaptionTextBox.Value = "STATUS"
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.56007885932922363R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0900000333786011R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFERENCE NO."
        '
        'fldProcessCaptionTextBox
        '
        Me.fldProcessCaptionTextBox.CanGrow = True
        Me.fldProcessCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.4729213714599609R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldProcessCaptionTextBox.Name = "fldProcessCaptionTextBox"
        Me.fldProcessCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69992125034332275R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldProcessCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldProcessCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldProcessCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldProcessCaptionTextBox.StyleName = "Caption"
        Me.fldProcessCaptionTextBox.Value = "PROCESS"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2800788879394531R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pHPCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.pHPCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.pHPCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "PHP AMOUNT"
        '
        'uSDCaptionTextBox
        '
        Me.uSDCaptionTextBox.CanGrow = True
        Me.uSDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.46015739440918R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.uSDCaptionTextBox.Name = "uSDCaptionTextBox"
        Me.uSDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.uSDCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.uSDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDCaptionTextBox.StyleName = "Caption"
        Me.uSDCaptionTextBox.Value = "USD AMOUNT"
        '
        'byearCaptionTextBox
        '
        Me.byearCaptionTextBox.CanGrow = True
        Me.byearCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.byearCaptionTextBox.Name = "byearCaptionTextBox"
        Me.byearCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.56000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.byearCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.byearCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.byearCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.byearCaptionTextBox.StyleName = "Caption"
        Me.byearCaptionTextBox.Value = "YEAR"
        '
        'fldDeptCaptionTextBox
        '
        Me.fldDeptCaptionTextBox.CanGrow = True
        Me.fldDeptCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6402363777160645R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCaptionTextBox.Name = "fldDeptCaptionTextBox"
        Me.fldDeptCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0326061248779297R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDeptCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldDeptCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCaptionTextBox.StyleName = "Caption"
        Me.fldDeptCaptionTextBox.Value = "DEPARTMENT"
        '
        'fldClassCaptionTextBox
        '
        Me.fldClassCaptionTextBox.CanGrow = True
        Me.fldClassCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6729211807250977R), Telerik.Reporting.Drawing.Unit.Inch(0.000039656955777900293R))
        Me.fldClassCaptionTextBox.Name = "fldClassCaptionTextBox"
        Me.fldClassCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992127418518066R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldClassCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldClassCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassCaptionTextBox.StyleName = "Caption"
        Me.fldClassCaptionTextBox.Value = "CLASSIFICATION"
        '
        'fldMBudgetedCaptionTextBox
        '
        Me.fldMBudgetedCaptionTextBox.CanGrow = True
        Me.fldMBudgetedCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.700003623962402R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldMBudgetedCaptionTextBox.Name = "fldMBudgetedCaptionTextBox"
        Me.fldMBudgetedCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMBudgetedCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMBudgetedCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldMBudgetedCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMBudgetedCaptionTextBox.StyleName = "Caption"
        Me.fldMBudgetedCaptionTextBox.Value = "MONTH BUDGETED"
        '
        'fldAmountCaptionTextBox
        '
        Me.fldAmountCaptionTextBox.CanGrow = True
        Me.fldAmountCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountCaptionTextBox.Name = "fldAmountCaptionTextBox"
        Me.fldAmountCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldAmountCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountCaptionTextBox.StyleName = "Caption"
        Me.fldAmountCaptionTextBox.Value = "JPY AMOUNT"
        '
        'fldMForecastedCaptionTextBox
        '
        Me.fldMForecastedCaptionTextBox.CanGrow = True
        Me.fldMForecastedCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.600003242492676R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMForecastedCaptionTextBox.Name = "fldMForecastedCaptionTextBox"
        Me.fldMForecastedCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89995890855789185R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMForecastedCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMForecastedCaptionTextBox.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.fldMForecastedCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMForecastedCaptionTextBox.StyleName = "Caption"
        Me.fldMForecastedCaptionTextBox.Value = "MONTH FORECASTED"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0000038146972656R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox2.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "UNIT OF MEASUREMENT"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.9000043869018555R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "DESCRIPTION"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.800004005432129R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "START OF USE"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1729221343994141R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82700282335281372R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "QUANTITY"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox13})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4166665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.367539405822754R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1324193477630615R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "Budget Actual Program (BAP)"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29003947973251343R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.byearDataTextBox, Me.fldClassDataTextBox, Me.fldDeptDataTextBox, Me.fldMBudgetedDataTextBox, Me.fldMForecastedDataTextBox, Me.fldProcessDataTextBox, Me.pHPDataTextBox, Me.uSDDataTextBox, Me.fldAmountDataTextBox, Me.fldBudRefNumDataTextBox, Me.fldStatDataTextBox, Me.TextBox5, Me.TextBox7, Me.TextBox8, Me.TextBox6})
        Me.detail.Name = "detail"
        '
        'byearDataTextBox
        '
        Me.byearDataTextBox.CanGrow = True
        Me.byearDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.byearDataTextBox.Name = "byearDataTextBox"
        Me.byearDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.56000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.byearDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.byearDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.byearDataTextBox.StyleName = "Data"
        Me.byearDataTextBox.Value = "=YEAR"
        '
        'fldClassDataTextBox
        '
        Me.fldClassDataTextBox.CanGrow = True
        Me.fldClassDataTextBox.Format = "{0:N2}"
        Me.fldClassDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1002364158630371R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldClassDataTextBox.Name = "fldClassDataTextBox"
        Me.fldClassDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1797637939453125R), Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R))
        Me.fldClassDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldClassDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassDataTextBox.StyleName = "Data"
        Me.fldClassDataTextBox.Value = "=ORIGINAL_AMOUNT"
        '
        'fldDeptDataTextBox
        '
        Me.fldDeptDataTextBox.CanGrow = True
        Me.fldDeptDataTextBox.Format = "{0:N2}"
        Me.fldDeptDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2803144454956055R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldDeptDataTextBox.Name = "fldDeptDataTextBox"
        Me.fldDeptDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1797642707824707R), Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R))
        Me.fldDeptDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptDataTextBox.StyleName = "Data"
        Me.fldDeptDataTextBox.Value = "=PHP_AMOUNT"
        '
        'fldMBudgetedDataTextBox
        '
        Me.fldMBudgetedDataTextBox.CanGrow = True
        Me.fldMBudgetedDataTextBox.Format = "{0:N2}"
        Me.fldMBudgetedDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.46015739440918R), Telerik.Reporting.Drawing.Unit.Inch(0.00011804368841694668R))
        Me.fldMBudgetedDataTextBox.Name = "fldMBudgetedDataTextBox"
        Me.fldMBudgetedDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.fldMBudgetedDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMBudgetedDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMBudgetedDataTextBox.StyleName = "Data"
        Me.fldMBudgetedDataTextBox.Value = "=USD_AMOUNT"
        '
        'fldMForecastedDataTextBox
        '
        Me.fldMForecastedDataTextBox.CanGrow = True
        Me.fldMForecastedDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6402363777160645R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldMForecastedDataTextBox.Name = "fldMForecastedDataTextBox"
        Me.fldMForecastedDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0326061248779297R), Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R))
        Me.fldMForecastedDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMForecastedDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMForecastedDataTextBox.StyleName = "Data"
        Me.fldMForecastedDataTextBox.Value = "=DEPARTMENT"
        '
        'fldProcessDataTextBox
        '
        Me.fldProcessDataTextBox.CanGrow = True
        Me.fldProcessDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6729207038879395R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldProcessDataTextBox.Name = "fldProcessDataTextBox"
        Me.fldProcessDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992127418518066R), Telerik.Reporting.Drawing.Unit.Inch(0.28996062278747559R))
        Me.fldProcessDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldProcessDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldProcessDataTextBox.StyleName = "Data"
        Me.fldProcessDataTextBox.Value = "=CLASSIFICATION"
        '
        'pHPDataTextBox
        '
        Me.pHPDataTextBox.CanGrow = True
        Me.pHPDataTextBox.Format = "{0:dd-MM-yyyy}"
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.700003623962402R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.28996062278747559R))
        Me.pHPDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.pHPDataTextBox.StyleName = "Data"
        Me.pHPDataTextBox.Value = "=MONTH_BUDGETED"
        '
        'uSDDataTextBox
        '
        Me.uSDDataTextBox.CanGrow = True
        Me.uSDDataTextBox.Format = "{0:d}"
        Me.uSDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.600079536437988R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.uSDDataTextBox.Name = "uSDDataTextBox"
        Me.uSDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89988195896148682R), Telerik.Reporting.Drawing.Unit.Inch(0.28996062278747559R))
        Me.uSDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.uSDDataTextBox.StyleName = "Data"
        Me.uSDDataTextBox.Value = "=MONTH_FORECASTED"
        '
        'fldAmountDataTextBox
        '
        Me.fldAmountDataTextBox.CanGrow = True
        Me.fldAmountDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.56007885932922363R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldAmountDataTextBox.Name = "fldAmountDataTextBox"
        Me.fldAmountDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0900000333786011R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.fldAmountDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldAmountDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountDataTextBox.StyleName = "Data"
        Me.fldAmountDataTextBox.Value = "=BUDGET_REFERENCE_NO"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6501574516296387R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.44999995827674866R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=STATUS"
        '
        'fldStatDataTextBox
        '
        Me.fldStatDataTextBox.CanGrow = True
        Me.fldStatDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.4728813171386719R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldStatDataTextBox.Name = "fldStatDataTextBox"
        Me.fldStatDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69992125034332275R), Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R))
        Me.fldStatDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldStatDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatDataTextBox.StyleName = "Data"
        Me.fldStatDataTextBox.Value = "=PROCESS"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Format = "{0:dd-MM-yyyy}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.800003051757813R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.28996062278747559R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "=START_OF_USE"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:d}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0000381469726562R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.28996062278747559R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "=MEASUREMENT_UNIT"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:d}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.9000387191772461R), Telerik.Reporting.Drawing.Unit.Inch(0.00015735626220703125R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992135763168335R), Telerik.Reporting.Drawing.Unit.Inch(0.28996062278747559R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "=DESCRIPTION"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1729211807250977R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82708162069320679R), Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "=QUANTITY"
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
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(13.499959945678711R), Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Budget Filtered Report"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29000002145767212R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.399883270263672R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1000778675079346R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.259921133518219R)
        Me.ReportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12})
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.92015731334686279R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1798425912857056R), Telerik.Reporting.Drawing.Unit.Inch(0.25992092490196228R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox9.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "TOTAL"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1797637939453125R), Telerik.Reporting.Drawing.Unit.Inch(0.25992098450660706R))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "= Sum(ORIGINAL_AMOUNT)"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Format = "{0:N2}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2803144454956055R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1797642707824707R), Telerik.Reporting.Drawing.Unit.Inch(0.259921133518219R))
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Data"
        Me.TextBox11.Value = "=Sum(PHP_AMOUNT)"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:N2}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.46015739440918R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1797642707824707R), Telerik.Reporting.Drawing.Unit.Inch(0.259921133518219R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "=Sum(USD_AMOUNT)"
        '
        'repBudgetGrid
        '
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail, Me.ReportFooterSection1})
        Me.Name = "BudgetGrid"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(13.500001907348633R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents byearCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMBudgetedCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMForecastedCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldProcessCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents byearDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMBudgetedDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMForecastedDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldProcessDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents ReportFooterSection1 As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
End Class
Partial Class repAA
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.byearCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthAcquiredCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDescCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderRemarksCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderSupplierCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPONoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldSignatureCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldUOMCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.uSDCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.byearDataTextBox = New Telerik.Reporting.TextBox()
        Me.PurchOrd = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthAcquiredDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDescDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderSupplierDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPONoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldSignatureDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldUOMDataTextBox = New Telerik.Reporting.TextBox()
        Me.uSDDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderRemarksDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3437502384185791R), Telerik.Reporting.Drawing.Unit.Inch(0.17187501490116119R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.TextBox12.Style.Color = System.Drawing.Color.Black
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "DEPARTMENT CODE"
        '
        'TextBox14
        '
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0104165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.17187501490116119R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.TextBox14.Style.Color = System.Drawing.Color.Black
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "FORCE PO AND UPLOADED PO"
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.17291679978370667R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.byearCaptionTextBox, Me.fldBudRefNumCaptionTextBox, Me.fldClassificationCaptionTextBox, Me.fldMonthAcquiredCaptionTextBox, Me.fldOrderDescCaptionTextBox, Me.fldOrderRemarksCaptionTextBox, Me.fldOrderSupplierCaptionTextBox, Me.fldPONoCaptionTextBox, Me.fldSignatureCaptionTextBox, Me.fldUOMCaptionTextBox, Me.uSDCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldOrderDepartmentCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.TextBox5, Me.TextBox1, Me.TextBox3, Me.TextBox9, Me.TextBox11, Me.TextBox16})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'byearCaptionTextBox
        '
        Me.byearCaptionTextBox.CanGrow = True
        Me.byearCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.byearCaptionTextBox.Name = "byearCaptionTextBox"
        Me.byearCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.56000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.byearCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.byearCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.byearCaptionTextBox.StyleName = "Caption"
        Me.byearCaptionTextBox.Value = "YEAR"
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.56007862091064453R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFERENCE NO."
        '
        'fldClassificationCaptionTextBox
        '
        Me.fldClassificationCaptionTextBox.CanGrow = True
        Me.fldClassificationCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.280393123626709R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassificationCaptionTextBox.Name = "fldClassificationCaptionTextBox"
        Me.fldClassificationCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0395278930664062R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassificationCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldClassificationCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassificationCaptionTextBox.StyleName = "Caption"
        Me.fldClassificationCaptionTextBox.Value = "CLASSIFICATION"
        '
        'fldMonthAcquiredCaptionTextBox
        '
        Me.fldMonthAcquiredCaptionTextBox.CanGrow = True
        Me.fldMonthAcquiredCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.361090660095215R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMonthAcquiredCaptionTextBox.Name = "fldMonthAcquiredCaptionTextBox"
        Me.fldMonthAcquiredCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89370507001876831R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMonthAcquiredCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMonthAcquiredCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMonthAcquiredCaptionTextBox.StyleName = "Caption"
        Me.fldMonthAcquiredCaptionTextBox.Value = "MONTH ACQUIRED"
        '
        'fldOrderDescCaptionTextBox
        '
        Me.fldOrderDescCaptionTextBox.CanGrow = True
        Me.fldOrderDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.530156135559082R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescCaptionTextBox.Name = "fldOrderDescCaptionTextBox"
        Me.fldOrderDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8614513874053955R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDescCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDescCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDescCaptionTextBox.Value = "DESCRIPTION"
        '
        'fldOrderRemarksCaptionTextBox
        '
        Me.fldOrderRemarksCaptionTextBox.CanGrow = True
        Me.fldOrderRemarksCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.254875183105469R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderRemarksCaptionTextBox.Name = "fldOrderRemarksCaptionTextBox"
        Me.fldOrderRemarksCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2302234172821045R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderRemarksCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderRemarksCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderRemarksCaptionTextBox.StyleName = "Caption"
        Me.fldOrderRemarksCaptionTextBox.Value = "REMARKS"
        '
        'fldOrderSupplierCaptionTextBox
        '
        Me.fldOrderSupplierCaptionTextBox.CanGrow = True
        Me.fldOrderSupplierCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.891391754150391R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierCaptionTextBox.Name = "fldOrderSupplierCaptionTextBox"
        Me.fldOrderSupplierCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4696184396743774R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderSupplierCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderSupplierCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierCaptionTextBox.StyleName = "Caption"
        Me.fldOrderSupplierCaptionTextBox.Value = "SUPPLIER"
        '
        'fldPONoCaptionTextBox
        '
        Me.fldPONoCaptionTextBox.CanGrow = True
        Me.fldPONoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.865411758422852R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoCaptionTextBox.Name = "fldPONoCaptionTextBox"
        Me.fldPONoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPONoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoCaptionTextBox.StyleName = "Caption"
        Me.fldPONoCaptionTextBox.Value = "PRICE"
        '
        'fldSignatureCaptionTextBox
        '
        Me.fldSignatureCaptionTextBox.CanGrow = True
        Me.fldSignatureCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.485177993774414R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldSignatureCaptionTextBox.Name = "fldSignatureCaptionTextBox"
        Me.fldSignatureCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldSignatureCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldSignatureCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSignatureCaptionTextBox.StyleName = "Caption"
        Me.fldSignatureCaptionTextBox.Value = "SIGNATURE"
        '
        'fldUOMCaptionTextBox
        '
        Me.fldUOMCaptionTextBox.CanGrow = True
        Me.fldUOMCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.39168643951416R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUOMCaptionTextBox.Name = "fldUOMCaptionTextBox"
        Me.fldUOMCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49962779879570007R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUOMCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldUOMCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUOMCaptionTextBox.StyleName = "Caption"
        Me.fldUOMCaptionTextBox.Value = "U.O.M"
        '
        'uSDCaptionTextBox
        '
        Me.uSDCaptionTextBox.CanGrow = True
        Me.uSDCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.920236349105835R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uSDCaptionTextBox.Name = "uSDCaptionTextBox"
        Me.uSDCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.uSDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDCaptionTextBox.StyleName = "Caption"
        Me.uSDCaptionTextBox.Value = "PO Quantity"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7401574850082397R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "PO NUMBER"
        '
        'fldOrderDepartmentCaptionTextBox
        '
        Me.fldOrderDepartmentCaptionTextBox.CanGrow = True
        Me.fldOrderDepartmentCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3199996948242188R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldOrderDepartmentCaptionTextBox.Name = "fldOrderDepartmentCaptionTextBox"
        Me.fldOrderDepartmentCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDepartmentCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDepartmentCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDepartmentCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDepartmentCaptionTextBox.Value = "DEPARTMENT"
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3500771522521973R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "PURCHASE REQUEST NO."
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1003146171569824R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "GRPO Quantity"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.585258483886719R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "ORDER DATE"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.045488357543945R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8786760568618774R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "GRPO AMOUNT"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.685335159301758R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "CURRENCY"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(22.924245834350586R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "SAP YEN AMOUNT"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(24.104324340820313R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Caption"
        Me.TextBox16.Value = "SAP ID"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6600000262260437R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.titleTextBox, Me.TextBox6})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.319920539855957R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039378803194267675R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(25.183376312255859R), Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Acquisition Report"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.017196655273437R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0870475769042969R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "Budget Actual Program (BAP)"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:d}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9201574325561523R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.045486450195313R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.0587565898895264R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.33858099579811096R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.reportFooter.Name = "reportFooter"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.3437503576278687R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.0104165077209473R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.16666655242443085R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox13)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox15)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.TextBox12
        TableGroup2.Name = "tableGroup1"
        TableGroup2.ReportItem = Me.TextBox14
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox13, Me.TextBox15, Me.TextBox12, Me.TextBox14})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.Table1.Name = "Table1"
        TableGroup3.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup3.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup3)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.3541669845581055R), Telerik.Reporting.Drawing.Unit.Inch(0.33854156732559204R))
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3437502384185791R), Telerik.Reporting.Drawing.Unit.Inch(0.16666655242443085R))
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Value = "= Fields.fldDeptCode"
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0104165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.16666655242443085R))
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Value = "= Fields.FPOUPO"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40015736222267151R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.byearDataTextBox, Me.PurchOrd, Me.fldBudRefNumDataTextBox, Me.fldClassificationDataTextBox, Me.fldMonthAcquiredDataTextBox, Me.fldOrderDescDataTextBox, Me.fldOrderSupplierDataTextBox, Me.fldPONoDataTextBox, Me.fldPRNoDataTextBox, Me.fldSignatureDataTextBox, Me.fldUOMDataTextBox, Me.uSDDataTextBox, Me.fldOrderRemarksDataTextBox, Me.fldOrderDepartmentDataTextBox, Me.TextBox4, Me.TextBox2, Me.TextBox7, Me.TextBox8, Me.TextBox10, Me.TextBox17})
        Me.detail.Name = "detail"
        '
        'byearDataTextBox
        '
        Me.byearDataTextBox.CanGrow = True
        Me.byearDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.byearDataTextBox.Name = "byearDataTextBox"
        Me.byearDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.559999942779541R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.byearDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.byearDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.byearDataTextBox.StyleName = "Data"
        Me.byearDataTextBox.Value = "=Fields.Byear"
        '
        'PurchOrd
        '
        Me.PurchOrd.CanGrow = True
        Me.PurchOrd.Format = "{0}"
        Me.PurchOrd.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7401572465896606R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.PurchOrd.Name = "PurchOrd"
        Me.PurchOrd.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.PurchOrd.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.PurchOrd.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.PurchOrd.StyleName = "Data"
        Me.PurchOrd.Value = "= Fields.[Purch-Ord]"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.56007862091064453R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=Fields.U_BudgetRef"
        '
        'fldClassificationDataTextBox
        '
        Me.fldClassificationDataTextBox.CanGrow = True
        Me.fldClassificationDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.280393123626709R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassificationDataTextBox.Name = "fldClassificationDataTextBox"
        Me.fldClassificationDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0395277738571167R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassificationDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldClassificationDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassificationDataTextBox.StyleName = "Data"
        Me.fldClassificationDataTextBox.Value = "=Fields.fldClass"
        '
        'fldMonthAcquiredDataTextBox
        '
        Me.fldMonthAcquiredDataTextBox.CanGrow = True
        Me.fldMonthAcquiredDataTextBox.Format = "{0:d}"
        Me.fldMonthAcquiredDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.361090660095215R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMonthAcquiredDataTextBox.Name = "fldMonthAcquiredDataTextBox"
        Me.fldMonthAcquiredDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89370507001876831R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMonthAcquiredDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMonthAcquiredDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMonthAcquiredDataTextBox.StyleName = "Data"
        Me.fldMonthAcquiredDataTextBox.Value = "= Fields.[Rcpt-Date]"
        '
        'fldOrderDescDataTextBox
        '
        Me.fldOrderDescDataTextBox.CanGrow = True
        Me.fldOrderDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.530156135559082R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderDescDataTextBox.Name = "fldOrderDescDataTextBox"
        Me.fldOrderDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8614511489868164R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDescDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderDescDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDescDataTextBox.StyleName = "Data"
        Me.fldOrderDescDataTextBox.Value = "=Fields.fldDesc"
        '
        'fldOrderSupplierDataTextBox
        '
        Me.fldOrderSupplierDataTextBox.CanGrow = True
        Me.fldOrderSupplierDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.891391754150391R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderSupplierDataTextBox.Name = "fldOrderSupplierDataTextBox"
        Me.fldOrderSupplierDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4696191549301147R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderSupplierDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderSupplierDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderSupplierDataTextBox.StyleName = "Data"
        Me.fldOrderSupplierDataTextBox.Value = "=Fields.fldSup"
        '
        'fldPONoDataTextBox
        '
        Me.fldPONoDataTextBox.CanGrow = True
        Me.fldPONoDataTextBox.Format = "{0:N2}"
        Me.fldPONoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.865411758422852R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPONoDataTextBox.Name = "fldPONoDataTextBox"
        Me.fldPONoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPONoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPONoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPONoDataTextBox.StyleName = "Data"
        Me.fldPONoDataTextBox.Value = "= Fields.Price"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3500785827636719R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "=Fields.PRNO"
        '
        'fldSignatureDataTextBox
        '
        Me.fldSignatureDataTextBox.CanGrow = True
        Me.fldSignatureDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.485177993774414R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldSignatureDataTextBox.Name = "fldSignatureDataTextBox"
        Me.fldSignatureDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldSignatureDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldSignatureDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSignatureDataTextBox.StyleName = "Data"
        Me.fldSignatureDataTextBox.Value = "=Fields.fldSignature"
        '
        'fldUOMDataTextBox
        '
        Me.fldUOMDataTextBox.CanGrow = True
        Me.fldUOMDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.39168643951416R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUOMDataTextBox.Name = "fldUOMDataTextBox"
        Me.fldUOMDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49962779879570007R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUOMDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldUOMDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUOMDataTextBox.StyleName = "Data"
        Me.fldUOMDataTextBox.Value = "= Fields.fldUnit"
        '
        'uSDDataTextBox
        '
        Me.uSDDataTextBox.CanGrow = True
        Me.uSDDataTextBox.Format = "{0:N2}"
        Me.uSDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.920236349105835R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.uSDDataTextBox.Name = "uSDDataTextBox"
        Me.uSDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.uSDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.uSDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.uSDDataTextBox.StyleName = "Data"
        Me.uSDDataTextBox.Value = "=Fields.Quantity"
        '
        'fldOrderRemarksDataTextBox
        '
        Me.fldOrderRemarksDataTextBox.CanGrow = True
        Me.fldOrderRemarksDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.254875183105469R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldOrderRemarksDataTextBox.Name = "fldOrderRemarksDataTextBox"
        Me.fldOrderRemarksDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2302234172821045R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderRemarksDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderRemarksDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderRemarksDataTextBox.StyleName = "Data"
        Me.fldOrderRemarksDataTextBox.Value = "=Fields.fldRemarks"
        '
        'fldOrderDepartmentDataTextBox
        '
        Me.fldOrderDepartmentDataTextBox.CanGrow = True
        Me.fldOrderDepartmentDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3199996948242188R), Telerik.Reporting.Drawing.Unit.Inch(0.00015735626220703125R))
        Me.fldOrderDepartmentDataTextBox.Name = "fldOrderDepartmentDataTextBox"
        Me.fldOrderDepartmentDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0299999713897705R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldOrderDepartmentDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldOrderDepartmentDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDepartmentDataTextBox.StyleName = "Data"
        Me.fldOrderDepartmentDataTextBox.Value = "=Fields.Dept"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1003146171569824R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "=Fields.GRPO_QTY"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:d}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.585258483886719R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999976396560669R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.[Ord-Date]"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.045492172241211R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8786760568618774R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "= Fields.Price * Fields.GRPO_QTY"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.685335159301758R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= Fields.Currency"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(22.924245834350586R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "= Fields.SAPYEN"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(24.104286193847656R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "= Fields.U_Detail_ID"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" & _
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "= Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "= Parameters.D2.Value"), New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "= Parameters.Dept.Value"), New Telerik.Reporting.SqlDataSourceParameter("@Class", System.Data.DbType.[String], "= Parameters.Class.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_SAA"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'repAA
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportFooter, Me.detail})
        Me.Name = "repAA"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "D1"
        ReportParameter1.Text = "D1"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Name = "D2"
        ReportParameter2.Text = "D2"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "Class"
        ReportParameter3.Text = "Class"
        ReportParameter4.Name = "Dept"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(25.284324645996094R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents byearCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthAcquiredCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDescCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderRemarksCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderSupplierCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSignatureCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUOMCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents byearDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents PurchOrd As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthAcquiredDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDescDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderRemarksDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderSupplierDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSignatureDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUOMDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents uSDDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPONoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
End Class
Partial Class repPrintPR2017

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
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pHPCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.txtPRno = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldAmountJPYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoDataTextBox = New Telerik.Reporting.TextBox()
        Me.pHPDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.txtIN = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.txtRemarks = New Telerik.Reporting.TextBox()
        Me.txtMoldDie = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.txtDeptBud = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.txtEPA = New Telerik.Reporting.TextBox()
        Me.txtTOPDRA = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.txtRemDBLPR = New Telerik.Reporting.TextBox()
        Me.txtAmount = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.txtCurrency = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.txtMonthBudget = New Telerik.Reporting.TextBox()
        Me.txtMonthBudgetBalance = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833358168602R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupFooterSection.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupFooterSection.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30007895827293396R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumCaptionTextBox, Me.fldClassificationCaptionTextBox, Me.pHPCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldOrderDepartmentCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.TextBox1, Me.TextBox36})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        Me.labelsGroupHeaderSection.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.39999982714653015R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.87999993562698364R), Telerik.Reporting.Drawing.Unit.Inch(0.30000016093254089R))
        Me.fldBudRefNumCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldBudRefNumCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldBudRefNumCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldBudRefNumCaptionTextBox.Style.Font.Bold = True
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFERENCE NO."
        '
        'fldClassificationCaptionTextBox
        '
        Me.fldClassificationCaptionTextBox.CanGrow = True
        Me.fldClassificationCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.280078649520874R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassificationCaptionTextBox.Name = "fldClassificationCaptionTextBox"
        Me.fldClassificationCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9996064305305481R), Telerik.Reporting.Drawing.Unit.Inch(0.30007869005203247R))
        Me.fldClassificationCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldClassificationCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldClassificationCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldClassificationCaptionTextBox.Style.Font.Bold = True
        Me.fldClassificationCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldClassificationCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassificationCaptionTextBox.StyleName = "Caption"
        Me.fldClassificationCaptionTextBox.Value = "CLASSIFICATION"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4999210834503174R), Telerik.Reporting.Drawing.Unit.Inch(0.30007869005203247R))
        Me.pHPCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.pHPCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.pHPCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.pHPCaptionTextBox.Style.Font.Bold = True
        Me.pHPCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.pHPCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "DESCRIPTION"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.27976393699646R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92015737295150757R), Telerik.Reporting.Drawing.Unit.Inch(0.30007869005203247R))
        Me.fldAmountJPYCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldAmountJPYCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldAmountJPYCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldAmountJPYCaptionTextBox.Style.Font.Bold = True
        Me.fldAmountJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "ITEM CODE"
        '
        'fldOrderDepartmentCaptionTextBox
        '
        Me.fldOrderDepartmentCaptionTextBox.CanGrow = True
        Me.fldOrderDepartmentCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldOrderDepartmentCaptionTextBox.Name = "fldOrderDepartmentCaptionTextBox"
        Me.fldOrderDepartmentCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.61960506439208984R), Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373R))
        Me.fldOrderDepartmentCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldOrderDepartmentCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldOrderDepartmentCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldOrderDepartmentCaptionTextBox.Style.Font.Bold = True
        Me.fldOrderDepartmentCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDepartmentCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDepartmentCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDepartmentCaptionTextBox.Value = "QTY"
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3196845054626465R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.48031583428382874R), Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373R))
        Me.fldPRNoCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldPRNoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldPRNoCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldPRNoCaptionTextBox.Style.Font.Bold = True
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "UNIT"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.800079345703125R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0998804569244385R), Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox1.Style.Color = System.Drawing.Color.Black
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "REMAINING BUDGET LESS PR (JPY)"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = True
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.000078625147580169141R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.399881511926651R), Telerik.Reporting.Drawing.Unit.Inch(0.30000016093254089R))
        Me.TextBox36.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox36.Style.Color = System.Drawing.Color.Black
        Me.TextBox36.Style.Font.Bold = True
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.StyleName = "Caption"
        Me.TextBox36.Value = "ITEM NO."
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.5R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox16, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.txtPRno, Me.TextBox13, Me.TextBox12, Me.TextBox14, Me.TextBox15, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox30, Me.TextBox31})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9999604225158691R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0294880867004395R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8704723119735718R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.StyleName = "PageInfo"
        Me.TextBox16.Value = "Budget Actual Program (BAP)"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.59999996423721313R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "TO"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.80007869005203247R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "FROM"
        '
        'TextBox11
        '
        Me.TextBox11.Format = "{0:d}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6094474792480469R), Telerik.Reporting.Drawing.Unit.Inch(1.0000787973403931R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2905128002166748R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox11.StyleName = "PageInfo"
        Me.TextBox11.Value = "=NOW()"
        '
        'txtPRno
        '
        Me.txtPRno.CanGrow = True
        Me.txtPRno.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6094474792480469R), Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269R))
        Me.txtPRno.Name = "txtPRno"
        Me.txtPRno.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2905124425888062R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.txtPRno.Style.Font.Bold = True
        Me.txtPRno.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtPRno.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtPRno.StyleName = "Data"
        Me.txtPRno.Value = "= Fields.fldPRNo"
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0:d}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6094474792480469R), Telerik.Reporting.Drawing.Unit.Inch(1.2001577615737915R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2905128002166748R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "= Fields.fldDN"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1800788640975952R), Telerik.Reporting.Drawing.Unit.Inch(0.8000788688659668R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "= Fields.Department"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1800788640975952R), Telerik.Reporting.Drawing.Unit.Inch(0.599999725818634R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "PC DEPT."
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.920039176940918R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "PURCHASE REQUISITION"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(1.0000791549682617R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90936887264251709R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "Date"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.60000020265579224R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90936928987503052R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "PR No."
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(1.2001577615737915R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90936887264251709R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox19.StyleName = "Data"
        Me.TextBox19.Value = "Date Needed"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.80007904767990112R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.909368097782135R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox30.StyleName = "Data"
        Me.TextBox30.Value = "Reimbursement No."
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6094474792480469R), Telerik.Reporting.Drawing.Unit.Inch(0.80007904767990112R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2904733419418335R), Telerik.Reporting.Drawing.Unit.Inch(0.19992104172706604R))
        Me.TextBox31.Style.Font.Bold = True
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox31.StyleName = "Data"
        Me.TextBox31.Value = "= Fields.fldRN"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20007903873920441R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageInfoTextBox, Me.TextBox27})
        Me.pageFooter.Name = "pageFooter"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4803556203842163R), Telerik.Reporting.Drawing.Unit.Inch(0.20003961026668549R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4195656776428223R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4803556203842163R), Telerik.Reporting.Drawing.Unit.Inch(0.20003961026668549R))
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.StyleName = "PageInfo"
        Me.TextBox27.Value = "APBS-20034 Form 1-2"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.35192635655403137R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldAmountJPYDataTextBox, Me.fldBudRefNumDataTextBox, Me.fldClassificationDataTextBox, Me.fldPRNoDataTextBox, Me.pHPDataTextBox, Me.fldOrderDepartmentDataTextBox, Me.TextBox2, Me.txtIN})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'fldAmountJPYDataTextBox
        '
        Me.fldAmountJPYDataTextBox.CanGrow = True
        Me.fldAmountJPYDataTextBox.Format = "{0:N2}"
        Me.fldAmountJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.27976393699646R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountJPYDataTextBox.Name = "fldAmountJPYDataTextBox"
        Me.fldAmountJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92015737295150757R), Telerik.Reporting.Drawing.Unit.Inch(0.35192623734474182R))
        Me.fldAmountJPYDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.fldAmountJPYDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldAmountJPYDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldAmountJPYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountJPYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldAmountJPYDataTextBox.StyleName = "Data"
        Me.fldAmountJPYDataTextBox.Value = "= Fields.fldICode"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.39999949932098389R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.88000005483627319R), Telerik.Reporting.Drawing.Unit.Inch(0.3519260585308075R))
        Me.fldBudRefNumDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.fldBudRefNumDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldBudRefNumDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "= Fields.fldBudRefNum"
        '
        'fldClassificationDataTextBox
        '
        Me.fldClassificationDataTextBox.CanGrow = True
        Me.fldClassificationDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.280078649520874R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassificationDataTextBox.Name = "fldClassificationDataTextBox"
        Me.fldClassificationDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99960654973983765R), Telerik.Reporting.Drawing.Unit.Inch(0.35192623734474182R))
        Me.fldClassificationDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.fldClassificationDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldClassificationDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldClassificationDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldClassificationDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassificationDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldClassificationDataTextBox.StyleName = "Data"
        Me.fldClassificationDataTextBox.Value = "= Fields.fldClass"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3196849822998047R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.48031583428382874R), Telerik.Reporting.Drawing.Unit.Inch(0.35192623734474182R))
        Me.fldPRNoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.fldPRNoDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldPRNoDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "= Fields.fldUnit"
        '
        'pHPDataTextBox
        '
        Me.pHPDataTextBox.CanGrow = True
        Me.pHPDataTextBox.Format = "{0:N2}"
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4999213218688965R), Telerik.Reporting.Drawing.Unit.Inch(0.35192623734474182R))
        Me.pHPDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.pHPDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.pHPDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.pHPDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.pHPDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.pHPDataTextBox.StyleName = "Data"
        Me.pHPDataTextBox.Value = "= Fields.fldDesc"
        '
        'fldOrderDepartmentDataTextBox
        '
        Me.fldOrderDepartmentDataTextBox.CanGrow = True
        Me.fldOrderDepartmentDataTextBox.Format = "{0:N2}"
        Me.fldOrderDepartmentDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.00015735626220703125R))
        Me.fldOrderDepartmentDataTextBox.Name = "fldOrderDepartmentDataTextBox"
        Me.fldOrderDepartmentDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.619605302810669R), Telerik.Reporting.Drawing.Unit.Inch(0.35176888108253479R))
        Me.fldOrderDepartmentDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.fldOrderDepartmentDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldOrderDepartmentDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldOrderDepartmentDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldOrderDepartmentDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDepartmentDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldOrderDepartmentDataTextBox.StyleName = "Data"
        Me.fldOrderDepartmentDataTextBox.Value = "= Fields.fldQTY"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.800079345703125R), Telerik.Reporting.Drawing.Unit.Inch(0.00015735626220703125R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0998798608779907R), Telerik.Reporting.Drawing.Unit.Inch(0.35176900029182434R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= Fields.fldRBLPR"
        '
        'txtIN
        '
        Me.txtIN.CanGrow = True
        Me.txtIN.Format = "{0:#.}"
        Me.txtIN.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.00015725029516033828R))
        Me.txtIN.Name = "txtIN"
        Me.txtIN.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39992102980613708R), Telerik.Reporting.Drawing.Unit.Inch(0.35176882147789R))
        Me.txtIN.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.txtIN.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtIN.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtIN.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.txtIN.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtIN.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtIN.StyleName = "Data"
        Me.txtIN.Value = "= RowNumber()"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@PR", System.Data.DbType.[String], "=Parameters.PR.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_PRForm"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(2.8959503173828125R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox39, Me.TextBox38, Me.TextBox3, Me.txtRemarks, Me.txtDeptBud, Me.TextBox8, Me.TextBox7, Me.TextBox5, Me.TextBox4, Me.txtEPA, Me.txtTOPDRA, Me.TextBox22, Me.TextBox23, Me.txtRemDBLPR, Me.txtAmount, Me.TextBox20, Me.txtCurrency, Me.TextBox6, Me.TextBox21, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox28, Me.TextBox29, Me.TextBox35, Me.TextBox37, Me.TextBox40, Me.TextBox41, Me.TextBox32, Me.txtMonthBudget, Me.txtMonthBudgetBalance, Me.TextBox34, Me.txtMoldDie, Me.TextBox42})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Ridge
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.095951080322265625R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "Reason for Request:"
        '
        'txtRemarks
        '
        Me.txtRemarks.CanGrow = True
        Me.txtRemarks.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.095951288938522339R))
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.9999985694885254R), Telerik.Reporting.Drawing.Unit.Inch(0.1999996155500412R))
        Me.txtRemarks.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtRemarks.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtRemarks.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtRemarks.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtRemarks.StyleName = "Data"
        Me.txtRemarks.Value = ""
        '
        'txtMoldDie
        '
        Me.txtMoldDie.CanGrow = True
        Me.txtMoldDie.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.29587206244468689R))
        Me.txtMoldDie.Name = "txtMoldDie"
        Me.txtMoldDie.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.9999985694885254R), Telerik.Reporting.Drawing.Unit.Inch(0.1999996155500412R))
        Me.txtMoldDie.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtMoldDie.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtMoldDie.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtMoldDie.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtMoldDie.StyleName = "Data"
        Me.txtMoldDie.Value = ""
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0020834605675190687R), Telerik.Reporting.Drawing.Unit.Inch(0.29587206244468689R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox42.StyleName = "Data"
        Me.TextBox42.Value = "Mold Die Name:"
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.300079345703125R), Telerik.Reporting.Drawing.Unit.Inch(2.0397894382476807R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5998423099517822R), Telerik.Reporting.Drawing.Unit.Inch(0.85616099834442139R))
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "Data"
        Me.TextBox39.Value = ""
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(2.0397894382476807R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.85616070032119751R))
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "Data"
        Me.TextBox38.Value = ""
        '
        'txtDeptBud
        '
        Me.txtDeptBud.CanGrow = True
        Me.txtDeptBud.Format = "{0:N2}"
        Me.txtDeptBud.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.4418544769287109R))
        Me.txtDeptBud.Name = "txtDeptBud"
        Me.txtDeptBud.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Inch(0.19999982416629791R))
        Me.txtDeptBud.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtDeptBud.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtDeptBud.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtDeptBud.StyleName = "Data"
        Me.txtDeptBud.Value = ""
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(2.4397108554840088R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.Font.Underline = False
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= Fields.fldSignature"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Inch(2.0397894382476807R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4796848297119141R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "Prepared by:"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(1.3959907293319702R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.29996100068092346R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "Remaining Departmental Budget(before PR) (JPY)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.79183417558670044R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.29996100068092346R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "Estimated PR (Original Amount)"
        '
        'txtEPA
        '
        Me.txtEPA.CanGrow = True
        Me.txtEPA.Format = "{0}"
        Me.txtEPA.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.1356598138809204R))
        Me.txtEPA.Name = "txtEPA"
        Me.txtEPA.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Inch(0.20415636897087097R))
        Me.txtEPA.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtEPA.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtEPA.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtEPA.StyleName = "Data"
        Me.txtEPA.Value = ""
        '
        'txtTOPDRA
        '
        Me.txtTOPDRA.CanGrow = True
        Me.txtTOPDRA.Format = "{0:N2}"
        Me.txtTOPDRA.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.69591140747070313R))
        Me.txtTOPDRA.Name = "txtTOPDRA"
        Me.txtTOPDRA.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999996423721313R), Telerik.Reporting.Drawing.Unit.Inch(0.20415657758712769R))
        Me.txtTOPDRA.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtTOPDRA.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtTOPDRA.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtTOPDRA.StyleName = "Data"
        Me.txtTOPDRA.Value = ""
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0R), Telerik.Reporting.Drawing.Unit.Inch(0.64800930023193359R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.29996100068092346R))
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "Total Departmental Open PR (JPY)"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0R), Telerik.Reporting.Drawing.Unit.Inch(0.94804888963699341R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.29996100068092346R))
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox23.StyleName = "Data"
        Me.TextBox23.Value = "Remaining Departmental Budget Less PR (JPY)"
        '
        'txtRemDBLPR
        '
        Me.txtRemDBLPR.CanGrow = True
        Me.txtRemDBLPR.Format = "{0:N2}"
        Me.txtRemDBLPR.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.69999885559082R), Telerik.Reporting.Drawing.Unit.Inch(0.99183493852615356R))
        Me.txtRemDBLPR.Name = "txtRemDBLPR"
        Me.txtRemDBLPR.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Inch(0.20415614545345306R))
        Me.txtRemDBLPR.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtRemDBLPR.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtRemDBLPR.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtRemDBLPR.StyleName = "Data"
        Me.txtRemDBLPR.Value = ""
        '
        'txtAmount
        '
        Me.txtAmount.CanGrow = True
        Me.txtAmount.Format = "{0}"
        Me.txtAmount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0000791549682617R), Telerik.Reporting.Drawing.Unit.Inch(0.83973628282547R))
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999207735061646R), Telerik.Reporting.Drawing.Unit.Inch(0.20415636897087097R))
        Me.txtAmount.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtAmount.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtAmount.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtAmount.StyleName = "Data"
        Me.txtAmount.Value = ""
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0959504842758179R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.29996100068092346R))
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "Estimated PR Amount (JPY)"
        '
        'txtCurrency
        '
        Me.txtCurrency.CanGrow = True
        Me.txtCurrency.Format = "{0:N2}"
        Me.txtCurrency.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.83973628282547R))
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Inch(0.20415636897087097R))
        Me.txtCurrency.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtCurrency.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtCurrency.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCurrency.StyleName = "Data"
        Me.txtCurrency.Value = ""
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(2.6397898197174072R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "Section    /    Dept. Manager    /    FGM"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7999992370605469R), Telerik.Reporting.Drawing.Unit.Inch(2.6397898197174072R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "Section / Dept. Manager"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(2.0397894382476807R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "Approved by:"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7999992370605469R), Telerik.Reporting.Drawing.Unit.Inch(2.0397894382476807R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999999761581421R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.Visible = True
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "Noted by:"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373R), Telerik.Reporting.Drawing.Unit.Inch(2.6397898197174072R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5000002384185791R), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R))
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox26.StyleName = "Data"
        Me.TextBox26.Value = "Dept. Staff / Dept. Supervisor"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.27976393699646R), Telerik.Reporting.Drawing.Unit.Inch(2.4797894954681396R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7999997138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.15992157161235809R))
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.Font.Underline = True
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "__________________________________________"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7999992370605469R), Telerik.Reporting.Drawing.Unit.Inch(2.4939558506011963R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Inch(0.14583389461040497R))
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.Font.Underline = True
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "_____________________________"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999956786632538R), Telerik.Reporting.Drawing.Unit.Inch(2.4940345287323R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9000002145767212R), Telerik.Reporting.Drawing.Unit.Inch(0.14575505256652832R))
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox35.Style.Font.Underline = True
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.StyleName = "Data"
        Me.TextBox35.Value = "_____________________________"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.5960693359375R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1800000667572021R), Telerik.Reporting.Drawing.Unit.Inch(0.19568592309951782R))
        Me.TextBox37.Style.Font.Italic = True
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox37.StyleName = "Data"
        Me.TextBox37.Value = "Budget Particulars:"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.795989990234375R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.24372059106826782R))
        Me.TextBox40.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox40.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox40.Style.Font.Bold = True
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox40.StyleName = "Data"
        Me.TextBox40.Value = "REQUISITIONER"
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = True
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.300079345703125R), Telerik.Reporting.Drawing.Unit.Inch(1.7959903478622437R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5998423099517822R), Telerik.Reporting.Drawing.Unit.Inch(0.24372056126594543R))
        Me.TextBox41.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox41.Style.Font.Bold = True
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.StyleName = "Data"
        Me.TextBox41.Value = "PURCHASING"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = True
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0R), Telerik.Reporting.Drawing.Unit.Inch(1.341893196105957R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.20415614545345306R))
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox32.StyleName = "Data"
        Me.TextBox32.Value = "Total Month Budget(JPY)"
        '
        'txtMonthBudget
        '
        Me.txtMonthBudget.CanGrow = True
        Me.txtMonthBudget.Format = "{0:N2}"
        Me.txtMonthBudget.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6999983787536621R), Telerik.Reporting.Drawing.Unit.Inch(1.341893196105957R))
        Me.txtMonthBudget.Name = "txtMonthBudget"
        Me.txtMonthBudget.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Inch(0.20415614545345306R))
        Me.txtMonthBudget.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtMonthBudget.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtMonthBudget.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtMonthBudget.StyleName = "Data"
        Me.txtMonthBudget.Value = ""
        '
        'txtMonthBudgetBalance
        '
        Me.txtMonthBudgetBalance.CanGrow = True
        Me.txtMonthBudgetBalance.Format = "{0:N2}"
        Me.txtMonthBudgetBalance.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6979165077209473R), Telerik.Reporting.Drawing.Unit.Inch(1.5461282730102539R))
        Me.txtMonthBudgetBalance.Name = "txtMonthBudgetBalance"
        Me.txtMonthBudgetBalance.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Inch(0.20415614545345306R))
        Me.txtMonthBudgetBalance.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtMonthBudgetBalance.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtMonthBudgetBalance.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtMonthBudgetBalance.StyleName = "Data"
        Me.txtMonthBudgetBalance.Value = ""
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0R), Telerik.Reporting.Drawing.Unit.Inch(1.5461282730102539R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6978380680084229R), Telerik.Reporting.Drawing.Unit.Inch(0.20415614545345306R))
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox34.StyleName = "Data"
        Me.TextBox34.Value = "Total Month Budget Balance(JPY)"
        '
        'repPrintPR2017
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportFooter, Me.detail})
        Me.Name = "repPrintPR"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "PR"
        ReportParameter1.Text = "PR"
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.899960994720459R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fldAmountJPYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fldAmountJPYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents txtPRno As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents txtIN As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents txtRemarks As Telerik.Reporting.TextBox
    Friend WithEvents txtDeptBud As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents txtEPA As Telerik.Reporting.TextBox
    Friend WithEvents txtTOPDRA As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents txtRemDBLPR As Telerik.Reporting.TextBox
    Friend WithEvents txtAmount As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents txtCurrency As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents txtMonthBudget As Telerik.Reporting.TextBox
    Friend WithEvents txtMonthBudgetBalance As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents txtMoldDie As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
End Class
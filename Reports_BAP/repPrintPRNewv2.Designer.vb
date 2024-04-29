Partial Class repPrintPRNewv2

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule3 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule4 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule5 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim TextWatermark1 As Telerik.Reporting.Drawing.TextWatermark = New Telerik.Reporting.Drawing.TextWatermark()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter5 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter6 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter7 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter8 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter9 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.textBox36 = New Telerik.Reporting.TextBox()
        Me.textBox55 = New Telerik.Reporting.TextBox()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pHPCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.textBox53 = New Telerik.Reporting.TextBox()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.textBox54 = New Telerik.Reporting.TextBox()
        Me.table2 = New Telerik.Reporting.Table()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.textBox47 = New Telerik.Reporting.TextBox()
        Me.sqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldPRNoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldOrderDepartmentDataTextBox = New Telerik.Reporting.TextBox()
        Me.pHPDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassificationDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountJPYDataTextBox = New Telerik.Reporting.TextBox()
        Me.txtIN = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.textBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.txtRemarks = New Telerik.Reporting.TextBox()
        Me.textBox49 = New Telerik.Reporting.TextBox()
        Me.textBox50 = New Telerik.Reporting.TextBox()
        Me.checkBox1 = New Telerik.Reporting.CheckBox()
        Me.checkBox2 = New Telerik.Reporting.CheckBox()
        Me.checkBox3 = New Telerik.Reporting.CheckBox()
        Me.txtMoldDie = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.txtInvestmentNo = New Telerik.Reporting.TextBox()
        Me.txtInvestmentBal = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.txtDeptBud = New Telerik.Reporting.TextBox()
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
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.txtPRno = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.textBox52 = New Telerik.Reporting.TextBox()
        Me.textBox51 = New Telerik.Reporting.TextBox()
        Me.textBox58 = New Telerik.Reporting.TextBox()
        Me.textBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'textBox36
        '
        Me.textBox36.Format = "{0:N2}"
        Me.textBox36.Name = "textBox36"
        Me.textBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.126R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox36.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.textBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox36.StyleName = "Corporate.TableBody"
        Me.textBox36.Value = "Remaining MAJOR Budget Less PR"
        '
        'textBox55
        '
        Me.textBox55.Format = "{0:N2}"
        Me.textBox55.Name = "textBox55"
        Me.textBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.864R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox55.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.textBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox55.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox55.StyleName = "Corporate.TableBody"
        Me.textBox55.Value = "= Fields.JPYAmount - (Fields.OpenPR+ Fields.POI+ Fields.UPO)"
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupFooterSection.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupFooterSection.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.8R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumCaptionTextBox, Me.fldClassificationCaptionTextBox, Me.pHPCaptionTextBox, Me.fldAmountJPYCaptionTextBox, Me.fldOrderDepartmentCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.textBox53, Me.textBox1, Me.textBox54, Me.table2, Me.TextBox61})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        Me.labelsGroupHeaderSection.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.405R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.88R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.fldBudRefNumCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldBudRefNumCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldBudRefNumCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldBudRefNumCaptionTextBox.Style.Font.Bold = True
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "REFERENCE NO."
        '
        'fldClassificationCaptionTextBox
        '
        Me.fldClassificationCaptionTextBox.CanGrow = True
        Me.fldClassificationCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.fldClassificationCaptionTextBox.Name = "fldClassificationCaptionTextBox"
        Me.fldClassificationCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.fldClassificationCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldClassificationCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldClassificationCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldClassificationCaptionTextBox.Style.Font.Bold = True
        Me.fldClassificationCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.fldClassificationCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassificationCaptionTextBox.StyleName = "Caption"
        Me.fldClassificationCaptionTextBox.Value = "CLASSIFICATION"
        '
        'pHPCaptionTextBox
        '
        Me.pHPCaptionTextBox.CanGrow = True
        Me.pHPCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.pHPCaptionTextBox.Name = "pHPCaptionTextBox"
        Me.pHPCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.896R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.pHPCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.pHPCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.pHPCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.pHPCaptionTextBox.Style.Font.Bold = True
        Me.pHPCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.pHPCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPCaptionTextBox.StyleName = "Caption"
        Me.pHPCaptionTextBox.Value = "ITEM DESCRIPTION"
        '
        'fldAmountJPYCaptionTextBox
        '
        Me.fldAmountJPYCaptionTextBox.CanGrow = True
        Me.fldAmountJPYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.42R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.fldAmountJPYCaptionTextBox.Name = "fldAmountJPYCaptionTextBox"
        Me.fldAmountJPYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.585R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.fldAmountJPYCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldAmountJPYCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldAmountJPYCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldAmountJPYCaptionTextBox.Style.Font.Bold = True
        Me.fldAmountJPYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.fldAmountJPYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYCaptionTextBox.StyleName = "Caption"
        Me.fldAmountJPYCaptionTextBox.Value = "Directly used in PEZA Registered Activity"
        '
        'fldOrderDepartmentCaptionTextBox
        '
        Me.fldOrderDepartmentCaptionTextBox.CanGrow = True
        Me.fldOrderDepartmentCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.496R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.fldOrderDepartmentCaptionTextBox.Name = "fldOrderDepartmentCaptionTextBox"
        Me.fldOrderDepartmentCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.fldOrderDepartmentCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldOrderDepartmentCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldOrderDepartmentCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldOrderDepartmentCaptionTextBox.Style.Font.Bold = True
        Me.fldOrderDepartmentCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.fldOrderDepartmentCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDepartmentCaptionTextBox.StyleName = "Caption"
        Me.fldOrderDepartmentCaptionTextBox.Value = "QTY"
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.796R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.38R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.fldPRNoCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.fldPRNoCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldPRNoCaptionTextBox.Style.Color = System.Drawing.Color.Black
        Me.fldPRNoCaptionTextBox.Style.Font.Bold = True
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "UNIT"
        '
        'textBox53
        '
        Me.textBox53.CanGrow = True
        Me.textBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.005R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.textBox53.Name = "textBox53"
        Me.textBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.textBox53.Style.BackgroundColor = System.Drawing.Color.White
        Me.textBox53.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.textBox53.Style.Color = System.Drawing.Color.Black
        Me.textBox53.Style.Font.Bold = True
        Me.textBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.textBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox53.StyleName = "Caption"
        Me.textBox53.Value = "ITEM NO."
        '
        'textBox1
        '
        Me.textBox1.CanGrow = True
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.176R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.textBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.textBox1.Style.Color = System.Drawing.Color.Black
        Me.textBox1.Style.Font.Bold = True
        Me.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox1.StyleName = "Caption"
        Me.textBox1.Value = "SUB FORECAST BALANCE"
        '
        'textBox54
        '
        Me.textBox54.CanGrow = True
        Me.textBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.286R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.textBox54.Name = "textBox54"
        Me.textBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.214R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.textBox54.Style.BackgroundColor = System.Drawing.Color.White
        Me.textBox54.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.textBox54.Style.Color = System.Drawing.Color.Black
        Me.textBox54.Style.Font.Bold = True
        Me.textBox54.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.textBox54.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox54.StyleName = "Caption"
        Me.textBox54.Value = "SUB BUDGET DESCRIPTION"
        '
        'table2
        '
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.126R)))
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.864R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.219R)))
        Me.table2.Body.SetCellContent(0, 0, Me.TextBox32)
        Me.table2.Body.SetCellContent(0, 1, Me.textBox47)
        TableGroup1.Name = "jPYAmount"
        TableGroup1.ReportItem = Me.textBox36
        TableGroup2.Name = "group1"
        TableGroup2.ReportItem = Me.textBox55
        Me.table2.ColumnGroups.Add(TableGroup1)
        Me.table2.ColumnGroups.Add(TableGroup2)
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("=Fields.GetProject", Telerik.Reporting.FilterOperator.NotEqual, "PROJECT"))
        FormattingRule1.Style.Visible = True
        Me.table2.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.table2.DataSource = Me.sqlDataSource2
        Me.table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox32, Me.textBox47, Me.textBox36, Me.textBox55})
        Me.table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.table2.Name = "table2"
        TableGroup3.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup3.Name = "detail"
        Me.table2.RowGroups.Add(TableGroup3)
        Me.table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.99R), Telerik.Reporting.Drawing.Unit.Inch(0.419R))
        Me.table2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.table2.Style.Font.Bold = True
        Me.table2.StyleName = "Corporate.TableNormal"
        '
        'TextBox32
        '
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.126R), Telerik.Reporting.Drawing.Unit.Inch(0.219R))
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.StyleName = "Corporate.TableBody"
        Me.TextBox32.Value = "Remaining MAJOR Forecast Less PR"
        '
        'textBox47
        '
        Me.textBox47.Format = "{0:N2}"
        Me.textBox47.Name = "textBox47"
        Me.textBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.864R), Telerik.Reporting.Drawing.Unit.Inch(0.219R))
        Me.textBox47.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.textBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox47.StyleName = "Corporate.TableBody"
        Me.textBox47.Value = "= Fields.CurrentAmount - (Fields.OpenPR+ Fields.POI+ Fields.UPO)"
        '
        'sqlDataSource2
        '
        Me.sqlDataSource2.ConnectionString = "server=192.168.191.12;uid=feap;pwd=45|iF$;Convert Zero Datetime=True;database=dbB" &
    "AP"
        Me.sqlDataSource2.Name = "sqlDataSource2"
        Me.sqlDataSource2.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@MajorRefNum", System.Data.DbType.[String], "= Parameters.MajorBud.Value"))
        Me.sqlDataSource2.ProviderName = "MySql.Data.MySqlClient"
        Me.sqlDataSource2.SelectCommand = "dbBAP.SP_GetSummaryTotalbyMajorOrgAmt"
        Me.sqlDataSource2.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'TextBox61
        '
        Me.TextBox61.CanGrow = True
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.005R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.595R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox61.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox61.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox61.Style.Color = System.Drawing.Color.Black
        Me.TextBox61.Style.Font.Bold = True
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox61.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox61.StyleName = "Caption"
        Me.TextBox61.Value = "ITEM CODE"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageInfoTextBox, Me.TextBox27})
        Me.pageFooter.Name = "pageFooter"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.48R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.32R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.48R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.StyleName = "PageInfo"
        Me.TextBox27.Value = "APBS-20034 Form 1-6"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldPRNoDataTextBox, Me.fldOrderDepartmentDataTextBox, Me.pHPDataTextBox, Me.fldBudRefNumDataTextBox, Me.fldClassificationDataTextBox, Me.fldAmountJPYDataTextBox, Me.txtIN, Me.TextBox2, Me.textBox56, Me.TextBox62})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.796R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.38R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.fldPRNoDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldPRNoDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldPRNoDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "= Fields.fldUnit"
        '
        'fldOrderDepartmentDataTextBox
        '
        Me.fldOrderDepartmentDataTextBox.CanGrow = True
        Me.fldOrderDepartmentDataTextBox.Format = "{0:N2}"
        Me.fldOrderDepartmentDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.496R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldOrderDepartmentDataTextBox.Name = "fldOrderDepartmentDataTextBox"
        Me.fldOrderDepartmentDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.fldOrderDepartmentDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldOrderDepartmentDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldOrderDepartmentDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldOrderDepartmentDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.fldOrderDepartmentDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldOrderDepartmentDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldOrderDepartmentDataTextBox.StyleName = "Data"
        Me.fldOrderDepartmentDataTextBox.Value = "= CDbl(Fields.fldQTY)"
        '
        'pHPDataTextBox
        '
        Me.pHPDataTextBox.CanGrow = True
        Me.pHPDataTextBox.Format = "{0:N2}"
        Me.pHPDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pHPDataTextBox.Name = "pHPDataTextBox"
        Me.pHPDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.896R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.pHPDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.pHPDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.pHPDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.pHPDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.pHPDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pHPDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.pHPDataTextBox.StyleName = "Data"
        Me.pHPDataTextBox.Value = "= Fields.fldDesc"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.405R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.88R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.fldBudRefNumDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldBudRefNumDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldBudRefNumDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "= Fields.fldSubRefNo"
        '
        'fldClassificationDataTextBox
        '
        Me.fldClassificationDataTextBox.CanGrow = True
        Me.fldClassificationDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldClassificationDataTextBox.Name = "fldClassificationDataTextBox"
        Me.fldClassificationDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.92R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.fldClassificationDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldClassificationDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldClassificationDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldClassificationDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.fldClassificationDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassificationDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldClassificationDataTextBox.StyleName = "Data"
        Me.fldClassificationDataTextBox.Value = "= Fields.fldClass"
        '
        'fldAmountJPYDataTextBox
        '
        Me.fldAmountJPYDataTextBox.CanGrow = True
        Me.fldAmountJPYDataTextBox.Format = "{0:N2}"
        Me.fldAmountJPYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.42R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.fldAmountJPYDataTextBox.Name = "fldAmountJPYDataTextBox"
        Me.fldAmountJPYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.585R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.fldAmountJPYDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.fldAmountJPYDataTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldAmountJPYDataTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.fldAmountJPYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.fldAmountJPYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountJPYDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.fldAmountJPYDataTextBox.StyleName = "Data"
        Me.fldAmountJPYDataTextBox.Value = "= Fields.fldPeza"
        '
        'txtIN
        '
        Me.txtIN.CanGrow = True
        Me.txtIN.Format = "{0:#.}"
        Me.txtIN.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.005R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.txtIN.Name = "txtIN"
        Me.txtIN.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtIN.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.txtIN.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtIN.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtIN.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.txtIN.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtIN.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtIN.StyleName = "Data"
        Me.txtIN.Value = "= RowNumber()"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.176R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "= CDbl(Fields.YenBud) - (CDbl(Fields.UPO) + CDbl(Fields.UUPO) + CDbl(Fields.PO) +" &
    " CDbl(Fields.FPO) + CDbl(Fields.GetSumMOI))"
        '
        'textBox56
        '
        Me.textBox56.CanGrow = True
        Me.textBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.286R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox56.Name = "textBox56"
        Me.textBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.214R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox56.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox56.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.textBox56.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.textBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.textBox56.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox56.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.textBox56.StyleName = "Data"
        Me.textBox56.Value = "= Fields.SubDesc"
        '
        'TextBox62
        '
        Me.TextBox62.CanGrow = True
        Me.TextBox62.Format = "{0:N2}"
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.005R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.595R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox62.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox62.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox62.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.TextBox62.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox62.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox62.StyleName = "Data"
        Me.TextBox62.Value = "= Fields.fldICode"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(5.896R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox43, Me.TextBox44, Me.TextBox46, Me.txtRemarks, Me.textBox49, Me.textBox50, Me.checkBox1, Me.checkBox2, Me.checkBox3, Me.txtMoldDie, Me.TextBox42, Me.TextBox45, Me.txtInvestmentNo, Me.txtInvestmentBal, Me.TextBox33, Me.txtDeptBud, Me.TextBox5, Me.TextBox4, Me.txtEPA, Me.txtTOPDRA, Me.TextBox22, Me.TextBox23, Me.txtRemDBLPR, Me.txtAmount, Me.TextBox20, Me.txtCurrency, Me.TextBox37, Me.TextBox39, Me.TextBox38, Me.TextBox8, Me.TextBox7, Me.TextBox6, Me.TextBox21, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox28, Me.TextBox29, Me.TextBox40, Me.TextBox41, Me.TextBox35, Me.TextBox48, Me.TextBox34, Me.TextBox60, Me.TextBox59})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Ridge
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.096R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "Reason for Request:"
        '
        'TextBox43
        '
        Me.TextBox43.CanGrow = True
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.396R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.777R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.TextBox43.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox43.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox43.StyleName = "Data"
        Me.TextBox43.Value = "= Fields.fldNReason"
        '
        'TextBox44
        '
        Me.TextBox44.CanGrow = True
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.396R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox44.StyleName = "Data"
        Me.TextBox44.Value = "Necessary:"
        '
        'TextBox46
        '
        Me.TextBox46.CanGrow = True
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.002R), Telerik.Reporting.Drawing.Unit.Inch(0.596R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox46.StyleName = "Data"
        Me.TextBox46.Value = "Reason Details"
        '
        'txtRemarks
        '
        Me.txtRemarks.CanGrow = True
        Me.txtRemarks.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.129R))
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.777R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtRemarks.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtRemarks.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtRemarks.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtRemarks.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtRemarks.StyleName = "Data"
        Me.txtRemarks.Value = "=Fields.fldOrderRemarks"
        '
        'textBox49
        '
        Me.textBox49.CanGrow = True
        Me.textBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(1.796R))
        Me.textBox49.Name = "textBox49"
        Me.textBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.textBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox49.StyleName = "Data"
        Me.textBox49.Value = "Inspection requirement for standard parts"
        '
        'textBox50
        '
        Me.textBox50.CanGrow = True
        Me.textBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(1.996R))
        Me.textBox50.Name = "textBox50"
        Me.textBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.textBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox50.StyleName = "Data"
        Me.textBox50.Value = "and fabricated items after receiving"
        '
        'checkBox1
        '
        Me.checkBox1.CheckedImage = Nothing
        Me.checkBox1.IndeterminateImage = Nothing
        Me.checkBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(1.796R))
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.checkBox1.Text = " Immediate inspection (within the day)"
        Me.checkBox1.UncheckedImage = Nothing
        Me.checkBox1.Value = "= IIf(Fields.fldInsRequirements = ""Immediate inspection (within the day)"",true,fa" &
    "lse)"
        '
        'checkBox2
        '
        Me.checkBox2.CheckedImage = Nothing
        Me.checkBox2.IndeterminateImage = Nothing
        Me.checkBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(1.996R))
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.checkBox2.Text = " 2-3 days inspection"
        Me.checkBox2.UncheckedImage = Nothing
        Me.checkBox2.Value = "= IIf(Fields.fldInsRequirements = ""2-3 days inspection"",true,false)"
        '
        'checkBox3
        '
        Me.checkBox3.CheckedImage = Nothing
        Me.checkBox3.IndeterminateImage = Nothing
        Me.checkBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(2.196R))
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.checkBox3.Text = " N/A"
        Me.checkBox3.UncheckedImage = Nothing
        Me.checkBox3.Value = "= IIf(Fields.fldInsRequirements = ""N/A"",true,false)"
        '
        'txtMoldDie
        '
        Me.txtMoldDie.CanGrow = True
        Me.txtMoldDie.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(2.496R))
        Me.txtMoldDie.Name = "txtMoldDie"
        Me.txtMoldDie.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtMoldDie.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtMoldDie.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtMoldDie.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtMoldDie.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtMoldDie.Style.Visible = False
        Me.txtMoldDie.StyleName = "Data"
        Me.txtMoldDie.Value = "= Fields.fldMoldDie"
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = True
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.496R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox42.Style.Visible = False
        Me.TextBox42.StyleName = "Data"
        Me.TextBox42.Value = "Mold Die Name:"
        '
        'TextBox45
        '
        Me.TextBox45.CanGrow = True
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.796R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox45.StyleName = "Data"
        Me.TextBox45.Value = "Investment Project"
        '
        'txtInvestmentNo
        '
        Me.txtInvestmentNo.CanGrow = True
        Me.txtInvestmentNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(2.796R))
        Me.txtInvestmentNo.Name = "txtInvestmentNo"
        Me.txtInvestmentNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.81R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtInvestmentNo.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtInvestmentNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtInvestmentNo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtInvestmentNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.txtInvestmentNo.StyleName = "Data"
        Me.txtInvestmentNo.Value = "= IsNull(Fields.fldInvestmentNo,'N/A')"
        '
        'txtInvestmentBal
        '
        Me.txtInvestmentBal.CanGrow = True
        Me.txtInvestmentBal.Format = "{0:N2}"
        Me.txtInvestmentBal.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(2.996R))
        Me.txtInvestmentBal.Name = "txtInvestmentBal"
        Me.txtInvestmentBal.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.81R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtInvestmentBal.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtInvestmentBal.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtInvestmentBal.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtInvestmentBal.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtInvestmentBal.StyleName = "Data"
        Me.txtInvestmentBal.Value = "= IsNull(Fields.TotalInvestmentBal,'N/A')"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = True
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.996R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox33.StyleName = "Data"
        Me.TextBox33.Value = "Investment Project Balance (JPY)"
        '
        'txtDeptBud
        '
        Me.txtDeptBud.CanGrow = True
        Me.txtDeptBud.Format = "{0:N2}"
        Me.txtDeptBud.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.705R), Telerik.Reporting.Drawing.Unit.Inch(4.142R))
        Me.txtDeptBud.Name = "txtDeptBud"
        Me.txtDeptBud.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtDeptBud.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtDeptBud.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtDeptBud.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtDeptBud.Style.Visible = False
        Me.txtDeptBud.StyleName = "Data"
        Me.txtDeptBud.Value = ""
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.105R), Telerik.Reporting.Drawing.Unit.Inch(4.096R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Style.Visible = False
        Me.TextBox5.StyleName = "Data"
        Me.TextBox5.Value = "Remaining Departmental Budget(before PR) (JPY)"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.105R), Telerik.Reporting.Drawing.Unit.Inch(3.492R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "Estimated PR (Original Amount)"
        '
        'txtEPA
        '
        Me.txtEPA.CanGrow = True
        Me.txtEPA.Format = "{0:N2}"
        Me.txtEPA.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.705R), Telerik.Reporting.Drawing.Unit.Inch(3.836R))
        Me.txtEPA.Name = "txtEPA"
        Me.txtEPA.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.204R))
        Me.txtEPA.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtEPA.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtEPA.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtEPA.StyleName = "Data"
        Me.txtEPA.Value = "= CDbl(Fields.TPR)"
        '
        'txtTOPDRA
        '
        Me.txtTOPDRA.CanGrow = True
        Me.txtTOPDRA.Format = "{0:N2}"
        Me.txtTOPDRA.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.705R), Telerik.Reporting.Drawing.Unit.Inch(3.396R))
        Me.txtTOPDRA.Name = "txtTOPDRA"
        Me.txtTOPDRA.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.204R))
        Me.txtTOPDRA.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtTOPDRA.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtTOPDRA.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtTOPDRA.Style.Visible = False
        Me.txtTOPDRA.StyleName = "Data"
        Me.txtTOPDRA.Value = ""
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.005R), Telerik.Reporting.Drawing.Unit.Inch(3.348R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Style.Visible = False
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "Total Departmental Open PR (JPY)"
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = True
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.005R), Telerik.Reporting.Drawing.Unit.Inch(3.648R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox23.Style.Visible = False
        Me.TextBox23.StyleName = "Data"
        Me.TextBox23.Value = "Remaining Departmental Budget Less PR (JPY)"
        '
        'txtRemDBLPR
        '
        Me.txtRemDBLPR.CanGrow = True
        Me.txtRemDBLPR.Format = "{0:N2}"
        Me.txtRemDBLPR.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.705R), Telerik.Reporting.Drawing.Unit.Inch(3.692R))
        Me.txtRemDBLPR.Name = "txtRemDBLPR"
        Me.txtRemDBLPR.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.204R))
        Me.txtRemDBLPR.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtRemDBLPR.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtRemDBLPR.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtRemDBLPR.Style.Visible = False
        Me.txtRemDBLPR.StyleName = "Data"
        Me.txtRemDBLPR.Value = ""
        '
        'txtAmount
        '
        Me.txtAmount.CanGrow = True
        Me.txtAmount.Format = "{0}"
        Me.txtAmount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.005R), Telerik.Reporting.Drawing.Unit.Inch(3.54R))
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7R), Telerik.Reporting.Drawing.Unit.Inch(0.204R))
        Me.txtAmount.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtAmount.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtAmount.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtAmount.StyleName = "Data"
        Me.txtAmount.Value = "= Fields.fldEC + "" "" + Fields.TPRO"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.105R), Telerik.Reporting.Drawing.Unit.Inch(3.796R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "Estimated PR Amount (JPY)"
        '
        'txtCurrency
        '
        Me.txtCurrency.CanGrow = True
        Me.txtCurrency.Format = "{0:N2}"
        Me.txtCurrency.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.705R), Telerik.Reporting.Drawing.Unit.Inch(3.54R))
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.204R))
        Me.txtCurrency.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.txtCurrency.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.txtCurrency.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCurrency.StyleName = "Data"
        Me.txtCurrency.Value = ""
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = True
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.105R), Telerik.Reporting.Drawing.Unit.Inch(3.296R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.196R))
        Me.TextBox37.Style.Font.Italic = True
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox37.StyleName = "Data"
        Me.TextBox37.Value = "Budget Particulars:"
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3R), Telerik.Reporting.Drawing.Unit.Inch(4.696R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.856R))
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox39.StyleName = "Data"
        Me.TextBox39.Value = ""
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = True
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(4.696R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3R), Telerik.Reporting.Drawing.Unit.Inch(0.856R))
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox38.StyleName = "Data"
        Me.TextBox38.Value = ""
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(5.096R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.Font.Underline = False
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "= Fields.fldSignature"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.057R), Telerik.Reporting.Drawing.Unit.Inch(4.696R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.48R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "Prepared by:"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.128R), Telerik.Reporting.Drawing.Unit.Inch(5.296R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.643R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "Section    /    Dept. Manager    /    Division Manager"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(5.296R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "Section / Dept. Manager"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = True
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.457R), Telerik.Reporting.Drawing.Unit.Inch(4.696R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.StyleName = "Data"
        Me.TextBox24.Value = "Approved by:"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = True
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(4.696R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.Visible = True
        Me.TextBox25.StyleName = "Data"
        Me.TextBox25.Value = "Noted by:"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = True
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.057R), Telerik.Reporting.Drawing.Unit.Inch(5.296R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox26.StyleName = "Data"
        Me.TextBox26.Value = "Dept. Staff / Dept. Supervisor"
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = True
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.037R), Telerik.Reporting.Drawing.Unit.Inch(5.152R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8R), Telerik.Reporting.Drawing.Unit.Inch(0.16R))
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.Font.Underline = True
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.StyleName = "Data"
        Me.TextBox28.Value = "__________________________________________"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = True
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(5.15R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.146R))
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.Font.Underline = True
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox29.StyleName = "Data"
        Me.TextBox29.Value = "_____________________________"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = True
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(4.452R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.3R), Telerik.Reporting.Drawing.Unit.Inch(0.244R))
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
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3R), Telerik.Reporting.Drawing.Unit.Inch(4.452R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.244R))
        Me.TextBox41.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox41.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox41.Style.Font.Bold = True
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.StyleName = "Data"
        Me.TextBox41.Value = "PURCHASING"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = True
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(5.15R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.146R))
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox35.Style.Font.Underline = True
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.StyleName = "Data"
        Me.TextBox35.Value = "_____________________________"
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = True
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.91R), Telerik.Reporting.Drawing.Unit.Inch(1.086R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox48.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox48.Style.Visible = True
        Me.TextBox48.StyleName = "Data"
        Me.TextBox48.Value = "= Fields.GetActivity"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = True
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.11R), Telerik.Reporting.Drawing.Unit.Inch(1.086R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox34.Style.Visible = True
        Me.TextBox34.StyleName = "Data"
        Me.TextBox34.Value = "Activity"
        '
        'TextBox60
        '
        Me.TextBox60.CanGrow = True
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.91R), Telerik.Reporting.Drawing.Unit.Inch(1.336R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.8R), Telerik.Reporting.Drawing.Unit.Inch(0.36R))
        Me.TextBox60.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.TextBox60.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox60.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox60.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox60.Style.Visible = True
        Me.TextBox60.StyleName = "Data"
        Me.TextBox60.Value = "= Fields.GetModel"
        '
        'TextBox59
        '
        Me.TextBox59.CanGrow = True
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.11R), Telerik.Reporting.Drawing.Unit.Inch(1.336R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox59.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox59.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox59.Style.Visible = True
        Me.TextBox59.StyleName = "Data"
        Me.TextBox59.Value = "Model / By-product"
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.5R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox16, Me.TextBox11, Me.txtPRno, Me.TextBox13, Me.TextBox15, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox30, Me.TextBox31, Me.textBox52, Me.textBox51, Me.textBox58, Me.textBox57, Me.TextBox9, Me.TextBox10, Me.TextBox12, Me.TextBox14})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.029R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.87R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox16.StyleName = "PageInfo"
        Me.TextBox16.Value = "Budget Actual Program (BAP)"
        '
        'TextBox11
        '
        Me.TextBox11.Format = "{0:d}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.609R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.291R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox11.StyleName = "PageInfo"
        Me.TextBox11.Value = "=NOW()"
        '
        'txtPRno
        '
        Me.txtPRno.CanGrow = True
        Me.txtPRno.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.609R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.txtPRno.Name = "txtPRno"
        Me.txtPRno.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.291R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.txtPRno.Style.Font.Bold = True
        Me.txtPRno.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtPRno.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtPRno.StyleName = "Data"
        Me.txtPRno.Value = "= Fields.fldPRNo"
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0:d}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.609R), Telerik.Reporting.Drawing.Unit.Inch(1.2R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.291R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox13.StyleName = "PageInfo"
        Me.TextBox13.Value = "= Fields.fldDN"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.92R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "PURCHASE REQUISITION"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.909R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.StyleName = "Data"
        Me.TextBox17.Value = "Date"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.909R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "PR No."
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(1.2R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.909R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox19.StyleName = "Data"
        Me.TextBox19.Value = "Date Needed"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = True
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.909R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox30.StyleName = "Data"
        Me.TextBox30.Value = "Reimbursement No."
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = True
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.609R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.29R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox31.Style.Font.Bold = True
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox31.StyleName = "Data"
        Me.TextBox31.Value = "= Fields.fldRN"
        '
        'textBox52
        '
        Me.textBox52.CanGrow = True
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("=Fields.GetProject", Telerik.Reporting.FilterOperator.NotEqual, "PROJECT"))
        FormattingRule2.Style.Visible = True
        Me.textBox52.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.textBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.128R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.textBox52.Name = "textBox52"
        Me.textBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.229R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox52.Style.Font.Bold = True
        Me.textBox52.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox52.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox52.StyleName = "Data"
        Me.textBox52.Value = "= Fields.MajorBud"
        '
        'textBox51
        '
        Me.textBox51.CanGrow = True
        FormattingRule3.Filters.Add(New Telerik.Reporting.Filter("=Fields.GetProject", Telerik.Reporting.FilterOperator.NotEqual, "PROJECT"))
        FormattingRule3.Style.Visible = True
        Me.textBox51.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule3})
        Me.textBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.002R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.textBox51.Name = "textBox51"
        Me.textBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.126R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox51.Style.Font.Bold = True
        Me.textBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox51.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox51.StyleName = "Data"
        Me.textBox51.Value = "Major Budget"
        '
        'textBox58
        '
        Me.textBox58.CanGrow = True
        FormattingRule4.Filters.Add(New Telerik.Reporting.Filter("=Fields.GetProject", Telerik.Reporting.FilterOperator.NotEqual, "PROJECT"))
        FormattingRule4.Style.Visible = True
        Me.textBox58.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule4})
        Me.textBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.002R), Telerik.Reporting.Drawing.Unit.Inch(1.2R))
        Me.textBox58.Name = "textBox58"
        Me.textBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.126R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox58.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox58.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox58.StyleName = "Data"
        Me.textBox58.Value = "Major Description"
        '
        'textBox57
        '
        Me.textBox57.CanGrow = True
        FormattingRule5.Filters.Add(New Telerik.Reporting.Filter("=Fields.GetProject", Telerik.Reporting.FilterOperator.NotEqual, "PROJECT"))
        FormattingRule5.Style.Visible = True
        Me.textBox57.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule5})
        Me.textBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.128R), Telerik.Reporting.Drawing.Unit.Inch(1.2R))
        Me.textBox57.Name = "textBox57"
        Me.textBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.374R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.textBox57.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox57.StyleName = "Data"
        Me.textBox57.Value = "= Fields.MajorDesc"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.126R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "TO"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.126R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "FROM"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.128R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.229R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "= Fields.Department"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.128R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.229R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "PC DEPT."
        '
        'repPrintPRNewv2
        '
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportFooter, Me.detail})
        Me.Name = "repPrintPR"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        TextWatermark1.Color = System.Drawing.Color.Gray
        TextWatermark1.Font.Bold = True
        TextWatermark1.Font.Name = "Arial Narrow"
        TextWatermark1.Font.Size = Telerik.Reporting.Drawing.Unit.Point(85.0R)
        TextWatermark1.Opacity = 0.17R
        TextWatermark1.Orientation = Telerik.Reporting.Drawing.WatermarkOrientation.Diagonal
        TextWatermark1.Position = Telerik.Reporting.Drawing.WatermarkPosition.Front
        TextWatermark1.Text = "= Parameters.PrintStat.Value"
        Me.PageSettings.Watermarks.Add(TextWatermark1)
        ReportParameter1.Name = "PR"
        ReportParameter1.Text = "PR"
        ReportParameter2.Name = "Remarks"
        ReportParameter3.Name = "DeptBud"
        ReportParameter4.Name = "MoldDie"
        ReportParameter5.Name = "RemDBLPR"
        ReportParameter6.Name = "Currency"
        ReportParameter7.Name = "TOPDRA"
        ReportParameter8.Name = "PrintStat"
        ReportParameter9.Name = "MajorBud"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.ReportParameters.Add(ReportParameter5)
        Me.ReportParameters.Add(ReportParameter6)
        Me.ReportParameters.Add(ReportParameter7)
        Me.ReportParameters.Add(ReportParameter8)
        Me.ReportParameters.Add(ReportParameter9)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.Style.Font.Name = "Arial"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents txtPRno As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents textBox52 As Telerik.Reporting.TextBox
    Friend WithEvents textBox51 As Telerik.Reporting.TextBox
    Friend WithEvents textBox58 As Telerik.Reporting.TextBox
    Friend WithEvents textBox57 As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents textBox53 As Telerik.Reporting.TextBox
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents textBox54 As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldOrderDepartmentDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pHPDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassificationDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountJPYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents txtIN As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents textBox56 As Telerik.Reporting.TextBox
    Friend WithEvents txtRemarks As Telerik.Reporting.TextBox
    Friend WithEvents textBox49 As Telerik.Reporting.TextBox
    Friend WithEvents textBox50 As Telerik.Reporting.TextBox
    Friend WithEvents checkBox1 As Telerik.Reporting.CheckBox
    Friend WithEvents checkBox2 As Telerik.Reporting.CheckBox
    Friend WithEvents checkBox3 As Telerik.Reporting.CheckBox
    Friend WithEvents txtMoldDie As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents txtInvestmentNo As Telerik.Reporting.TextBox
    Friend WithEvents txtInvestmentBal As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents txtDeptBud As Telerik.Reporting.TextBox
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
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents table2 As Telerik.Reporting.Table
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents textBox47 As Telerik.Reporting.TextBox
    Friend WithEvents textBox36 As Telerik.Reporting.TextBox
    Friend WithEvents textBox55 As Telerik.Reporting.TextBox
    Friend WithEvents sqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
End Class
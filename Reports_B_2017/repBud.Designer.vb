Partial Class repBud2017

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
        Me.balanceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMForecastedCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.onGoingOrderCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMBudgetedCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.aAWithBgtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.balanceDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMBudgetedDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMForecastedDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldAmountDataTextBox = New Telerik.Reporting.TextBox()
        Me.onGoingOrderDataTextBox = New Telerik.Reporting.TextBox()
        Me.aAWithBgtDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40007892251014709R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.balanceCaptionTextBox, Me.fldAmountCaptionTextBox, Me.fldMForecastedCaptionTextBox, Me.onGoingOrderCaptionTextBox, Me.fldDeptCaptionTextBox, Me.fldMBudgetedCaptionTextBox, Me.aAWithBgtCaptionTextBox, Me.TextBox3, Me.fldBudRefNumCaptionTextBox, Me.TextBox1, Me.TextBox8, Me.TextBox5})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'balanceCaptionTextBox
        '
        Me.balanceCaptionTextBox.CanGrow = True
        Me.balanceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.407883644104004R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.balanceCaptionTextBox.Name = "balanceCaptionTextBox"
        Me.balanceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5992236137390137R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.balanceCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.balanceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.balanceCaptionTextBox.StyleName = "Caption"
        Me.balanceCaptionTextBox.Value = "PURCHASE ORDER BUDGET BALANCE"
        '
        'fldAmountCaptionTextBox
        '
        Me.fldAmountCaptionTextBox.CanGrow = True
        Me.fldAmountCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.7612953186035156R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldAmountCaptionTextBox.Name = "fldAmountCaptionTextBox"
        Me.fldAmountCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1847603321075439R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldAmountCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldAmountCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountCaptionTextBox.StyleName = "Caption"
        Me.fldAmountCaptionTextBox.Value = "ORIGINAL BUDGET"
        '
        'fldMForecastedCaptionTextBox
        '
        Me.fldMForecastedCaptionTextBox.CanGrow = True
        Me.fldMForecastedCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.89121675491333R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMForecastedCaptionTextBox.Name = "fldMForecastedCaptionTextBox"
        Me.fldMForecastedCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.87000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMForecastedCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMForecastedCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMForecastedCaptionTextBox.StyleName = "Caption"
        Me.fldMForecastedCaptionTextBox.Value = "MONTH FORECASTED"
        '
        'onGoingOrderCaptionTextBox
        '
        Me.onGoingOrderCaptionTextBox.CanGrow = True
        Me.onGoingOrderCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.126252174377441R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.onGoingOrderCaptionTextBox.Name = "onGoingOrderCaptionTextBox"
        Me.onGoingOrderCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.100698709487915R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.onGoingOrderCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.onGoingOrderCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.onGoingOrderCaptionTextBox.StyleName = "Caption"
        Me.onGoingOrderCaptionTextBox.Value = "UPLOADED PURCHASE ORDER"
        '
        'fldDeptCaptionTextBox
        '
        Me.fldDeptCaptionTextBox.CanGrow = True
        Me.fldDeptCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1792378425598145R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCaptionTextBox.Name = "fldDeptCaptionTextBox"
        Me.fldDeptCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.939403772354126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDeptCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCaptionTextBox.StyleName = "Caption"
        Me.fldDeptCaptionTextBox.Value = "DEPARTMENT"
        '
        'fldMBudgetedCaptionTextBox
        '
        Me.fldMBudgetedCaptionTextBox.CanGrow = True
        Me.fldMBudgetedCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1187195777893066R), Telerik.Reporting.Drawing.Unit.Inch(0.000078757606388535351R))
        Me.fldMBudgetedCaptionTextBox.Name = "fldMBudgetedCaptionTextBox"
        Me.fldMBudgetedCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.77241790294647217R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMBudgetedCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMBudgetedCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMBudgetedCaptionTextBox.StyleName = "Caption"
        Me.fldMBudgetedCaptionTextBox.Value = "MONTH BUDGETED"
        '
        'aAWithBgtCaptionTextBox
        '
        Me.aAWithBgtCaptionTextBox.CanGrow = True
        Me.aAWithBgtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.327804565429687R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.aAWithBgtCaptionTextBox.Name = "aAWithBgtCaptionTextBox"
        Me.aAWithBgtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0800000429153442R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.aAWithBgtCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.aAWithBgtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWithBgtCaptionTextBox.StyleName = "Caption"
        Me.aAWithBgtCaptionTextBox.Value = "ACTUAL ACQUISITION"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.9461736679077148R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "REVISION BUDGET"
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000281572341919R), Telerik.Reporting.Drawing.Unit.Inch(0.40007895231246948R))
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFERENCE NO."
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1001462936401367R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.0790128707885742R), Telerik.Reporting.Drawing.Unit.Inch(0.40007895231246948R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "DESCRIPTION"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.227027893066406R), Telerik.Reporting.Drawing.Unit.Inch(0.000078996024967636913R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.100698709487915R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "PURCHASE ORDER"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.007186889648437R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5992236137390137R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "ACTUAL ACQUISITION BUDGET BALANCE"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP2017;Uid=feap;Pwd=45|iF$;Convert Zero Datet" & _
    "ime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value"), New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP2017.SP_RPBudget"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox, Me.TextBox6})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.000000020489096641540527R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4200000762939453R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.550183296203613R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.056232213973999R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "Budget Actual Program (BAP)"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.45833340287208557R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(16.606410980224609R), Telerik.Reporting.Drawing.Unit.Inch(0.45833340287208557R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Report per Budget"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29158791899681091R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17})
        Me.reportFooter.Name = "reportFooter"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:N2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.007190704345703R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5992261171340942R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "=SUM(Fields.RevAmount - (Fields.GRPO + Fields.UPO + Fields.FPO))" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Format = "{0:N2}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.407885551452637R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5992261171340942R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Data"
        Me.TextBox11.Value = "= SUM(Fields.Rembud - Fields.UUPO)"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:N2}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.327805519104004R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0800000429153442R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "= SUM(Fields.GRPO)"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Format = "{0:N2}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.227066993713379R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1006598472595215R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Data"
        Me.TextBox13.Value = "= SUM(Fields.PO)"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.126328468322754R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1006598472595215R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.StyleName = "Data"
        Me.TextBox14.Value = "= SUM(Fields.UUPO)"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Format = "{0:N2}"
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.9462499618530273R), Telerik.Reporting.Drawing.Unit.Inch(0.0015878677368164063R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "= SUM(Fields.RevAmount0)"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Format = "{0:N2}"
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.7612557411193848R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1847997903823853R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "= SUM(Fields.OAmount)"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000281572341919R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.StyleName = "Caption"
        Me.TextBox17.Value = "TOTAL"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29309678077697754R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.balanceDataTextBox, Me.fldBudRefNumDataTextBox, Me.fldDeptDataTextBox, Me.fldMBudgetedDataTextBox, Me.fldMForecastedDataTextBox, Me.fldAmountDataTextBox, Me.onGoingOrderDataTextBox, Me.aAWithBgtDataTextBox, Me.TextBox4, Me.TextBox2, Me.TextBox7, Me.TextBox9})
        Me.detail.Name = "detail"
        '
        'balanceDataTextBox
        '
        Me.balanceDataTextBox.CanGrow = True
        Me.balanceDataTextBox.Format = "{0:N2}"
        Me.balanceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.407883644104004R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.balanceDataTextBox.Name = "balanceDataTextBox"
        Me.balanceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5992261171340942R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.balanceDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.balanceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.balanceDataTextBox.StyleName = "Data"
        Me.balanceDataTextBox.Value = "= Fields.Rembud - Fields.UUPO"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000281572341919R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=Fields.fldBudRefNum"
        '
        'fldDeptDataTextBox
        '
        Me.fldDeptDataTextBox.CanGrow = True
        Me.fldDeptDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1792397499084473R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptDataTextBox.Name = "fldDeptDataTextBox"
        Me.fldDeptDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.939403772354126R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.fldDeptDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptDataTextBox.StyleName = "Data"
        Me.fldDeptDataTextBox.Value = "=Fields.fldDept"
        '
        'fldMBudgetedDataTextBox
        '
        Me.fldMBudgetedDataTextBox.CanGrow = True
        Me.fldMBudgetedDataTextBox.Format = "{0:d}"
        Me.fldMBudgetedDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1187224388122559R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMBudgetedDataTextBox.Name = "fldMBudgetedDataTextBox"
        Me.fldMBudgetedDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.77241790294647217R), Telerik.Reporting.Drawing.Unit.Inch(0.29154834151268005R))
        Me.fldMBudgetedDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMBudgetedDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.fldMBudgetedDataTextBox.StyleName = "Data"
        Me.fldMBudgetedDataTextBox.Value = "=Fields.fldMBudgeted"
        '
        'fldMForecastedDataTextBox
        '
        Me.fldMForecastedDataTextBox.CanGrow = True
        Me.fldMForecastedDataTextBox.Format = "{0:d}"
        Me.fldMForecastedDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.8912186622619629R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMForecastedDataTextBox.Name = "fldMForecastedDataTextBox"
        Me.fldMForecastedDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.87000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.fldMForecastedDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMForecastedDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.fldMForecastedDataTextBox.StyleName = "Data"
        Me.fldMForecastedDataTextBox.Value = "=Fields.fldMForecasted"
        '
        'fldAmountDataTextBox
        '
        Me.fldAmountDataTextBox.CanGrow = True
        Me.fldAmountDataTextBox.Format = "{0:N2}"
        Me.fldAmountDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.7612581253051758R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldAmountDataTextBox.Name = "fldAmountDataTextBox"
        Me.fldAmountDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1847997903823853R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.fldAmountDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldAmountDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldAmountDataTextBox.StyleName = "Data"
        Me.fldAmountDataTextBox.Value = "= Fields.OAmount"
        '
        'onGoingOrderDataTextBox
        '
        Me.onGoingOrderDataTextBox.CanGrow = True
        Me.onGoingOrderDataTextBox.Format = "{0:N2}"
        Me.onGoingOrderDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.126255035400391R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.onGoingOrderDataTextBox.Name = "onGoingOrderDataTextBox"
        Me.onGoingOrderDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1006598472595215R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.onGoingOrderDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.onGoingOrderDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.onGoingOrderDataTextBox.StyleName = "Data"
        Me.onGoingOrderDataTextBox.Value = "=Fields.UUPO"
        '
        'aAWithBgtDataTextBox
        '
        Me.aAWithBgtDataTextBox.CanGrow = True
        Me.aAWithBgtDataTextBox.Format = "{0:N2}"
        Me.aAWithBgtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.327804565429687R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.aAWithBgtDataTextBox.Name = "aAWithBgtDataTextBox"
        Me.aAWithBgtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0800000429153442R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.aAWithBgtDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.aAWithBgtDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.aAWithBgtDataTextBox.StyleName = "Data"
        Me.aAWithBgtDataTextBox.Value = "= Fields.GRPO"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.9461765289306641R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1799999475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.RevAmount0"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1001464128494263R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.0790119171142578R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.fldDesc"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.227066993713379R), Telerik.Reporting.Drawing.Unit.Inch(0.0015482902526855469R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1006598472595215R), Telerik.Reporting.Drawing.Unit.Inch(0.291548490524292R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "= Fields.PO"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Format = "{0:N2}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.007189750671387R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5992261171340942R), Telerik.Reporting.Drawing.Unit.Inch(0.28999999165534973R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "= Fields.RevAmount - (Fields.GRPO + Fields.UPO + Fields.FPO)"
        '
        'repBud2017
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repBud"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "D1"
        ReportParameter1.Text = "D1"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Name = "D2"
        ReportParameter2.Text = "D2"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "DEPT"
        ReportParameter3.Text = "DEPT"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(16.606416702270508R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents aAWithBgtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents balanceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMBudgetedCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMForecastedCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents onGoingOrderCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents aAWithBgtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents balanceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldAmountDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMBudgetedDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMForecastedDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents onGoingOrderDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
End Class
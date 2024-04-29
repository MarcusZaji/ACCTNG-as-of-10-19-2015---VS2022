Partial Class rtpInvestment
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup10 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup11 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup12 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup13 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.748R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.StyleName = "Corporate.TableHeader"
        Me.TextBox1.Value = "Investment Application No."
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.019R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.StyleName = "Corporate.TableHeader"
        Me.TextBox2.Value = "Date Applied"
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.925R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.StyleName = "Corporate.TableHeader"
        Me.TextBox3.Value = "Full Description of the Project"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.769R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.StyleName = "Corporate.TableHeader"
        Me.TextBox4.Value = "Investment Type"
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.019R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.StyleName = "Corporate.TableHeader"
        Me.TextBox5.Value = "Existing Machine or machine(s)"
        '
        'TextBox25
        '
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.868R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.StyleName = "Corporate.TableHeader"
        Me.TextBox25.Value = "Department"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.102R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.StyleName = "Corporate.TableHeader"
        Me.TextBox6.Value = "Estimated amount of Investment"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.196R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.StyleName = "Corporate.TableHeader"
        Me.TextBox7.Value = "Approved Budget"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.519R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.StyleName = "Corporate.TableHeader"
        Me.TextBox8.Value = "Target Date of Start of Construction , Installation or delivery"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.456R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.StyleName = "Corporate.TableHeader"
        Me.TextBox9.Value = "Date Completion"
        '
        'TextBox21
        '
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.354R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.StyleName = "Corporate.TableHeader"
        Me.TextBox21.Value = "Start of Depreciation"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.StyleName = "Corporate.TableHeader"
        Me.TextBox10.Value = "Status"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox23, Me.TextBox24})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Value = "Furukawa Electric Autoparts Philippines Inc."
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Value = "Investment Application Register"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.detail.Name = "detail"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.748R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.019R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.925R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.769R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.019R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.868R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.102R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.196R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.519R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.456R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.354R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.0R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox12)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox13)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox14)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox15)
        Me.Table1.Body.SetCellContent(0, 6, Me.TextBox16)
        Me.Table1.Body.SetCellContent(0, 7, Me.TextBox17)
        Me.Table1.Body.SetCellContent(0, 8, Me.TextBox18)
        Me.Table1.Body.SetCellContent(0, 9, Me.TextBox19)
        Me.Table1.Body.SetCellContent(0, 10, Me.TextBox22)
        Me.Table1.Body.SetCellContent(0, 5, Me.TextBox26)
        Me.Table1.Body.SetCellContent(0, 11, Me.TextBox20)
        TableGroup1.ReportItem = Me.TextBox1
        TableGroup2.ReportItem = Me.TextBox2
        TableGroup3.ReportItem = Me.TextBox3
        TableGroup4.ReportItem = Me.TextBox4
        TableGroup5.ReportItem = Me.TextBox5
        TableGroup6.Name = "group1"
        TableGroup6.ReportItem = Me.TextBox25
        TableGroup7.ReportItem = Me.TextBox6
        TableGroup8.ReportItem = Me.TextBox7
        TableGroup9.ReportItem = Me.TextBox8
        TableGroup10.ReportItem = Me.TextBox9
        TableGroup11.Name = "group"
        TableGroup11.ReportItem = Me.TextBox21
        TableGroup12.Name = "group2"
        TableGroup12.ReportItem = Me.TextBox10
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.ColumnGroups.Add(TableGroup6)
        Me.Table1.ColumnGroups.Add(TableGroup7)
        Me.Table1.ColumnGroups.Add(TableGroup8)
        Me.Table1.ColumnGroups.Add(TableGroup9)
        Me.Table1.ColumnGroups.Add(TableGroup10)
        Me.Table1.ColumnGroups.Add(TableGroup11)
        Me.Table1.ColumnGroups.Add(TableGroup12)
        Me.Table1.DataSource = Me.SqlDataSource1
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox26, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox22, Me.TextBox20, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox25, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox21, Me.TextBox10})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.Table1.Name = "Table1"
        TableGroup13.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup13.Name = "Detail"
        Me.Table1.RowGroups.Add(TableGroup13)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(18.974R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.Table1.StyleName = "Corporate.TableNormal"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.748R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.StyleName = "Corporate.TableBody"
        Me.TextBox11.Value = "= Fields.fldInvestmentNo"
        '
        'TextBox12
        '
        Me.TextBox12.Format = "{0:d}"
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.019R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.StyleName = "Corporate.TableBody"
        Me.TextBox12.Value = "= Fields.fldDate"
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.925R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.StyleName = "Corporate.TableBody"
        Me.TextBox13.Value = "= Fields.fldProjTitle"
        '
        'TextBox14
        '
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.769R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.StyleName = "Corporate.TableBody"
        Me.TextBox14.Value = "= Fields.fldInvestmentType"
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.019R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.StyleName = "Corporate.TableBody"
        Me.TextBox15.Value = "= Fields.fldExistingMachine"
        '
        'TextBox16
        '
        Me.TextBox16.Format = "{0:N2}"
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.102R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.StyleName = "Corporate.TableBody"
        Me.TextBox16.Value = "= Fields.fldProdCostJPY"
        '
        'TextBox17
        '
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.196R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.StyleName = "Corporate.TableBody"
        Me.TextBox17.Value = "= Fields.fldApprovedBudget"
        '
        'TextBox18
        '
        Me.TextBox18.Format = "{0:d}"
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.519R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.StyleName = "Corporate.TableBody"
        Me.TextBox18.Value = "= Fields.fldDateInstallation"
        '
        'TextBox19
        '
        Me.TextBox19.Format = "{0:d}"
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.456R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.StyleName = "Corporate.TableBody"
        Me.TextBox19.Value = "= Fields.fldDateCompletion"
        '
        'TextBox22
        '
        Me.TextBox22.Format = "{0:d}"
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.354R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.StyleName = "Corporate.TableBody"
        Me.TextBox22.Value = "=Fields.fldDepreciation"
        '
        'TextBox26
        '
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.868R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.StyleName = "Corporate.TableBody"
        Me.TextBox26.Value = "=Fields.fldDept"
        '
        'TextBox20
        '
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.StyleName = "Corporate.TableBody"
        Me.TextBox20.Value = "=Fields.fldStatus"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_SelectAllInvestment"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'rtpInvestment
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rtpInvestment"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Corporate.TableNormal")})
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableBody")})
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableHeader")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.White
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(18.974R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
End Class
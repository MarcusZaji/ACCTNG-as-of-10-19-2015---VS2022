Partial Class RptPerInvNo
    
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
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7895833253860474R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox1.StyleName = "Corporate.TableHeader"
        Me.TextBox1.Value = "Investment Application No."
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1333334445953369R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox2.StyleName = "Corporate.TableHeader"
        Me.TextBox2.Value = "Date Applied"
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9041669368743896R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox3.StyleName = "Corporate.TableHeader"
        Me.TextBox3.Value = "Full Description of the Project"
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2583328485488892R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox5.StyleName = "Corporate.TableHeader"
        Me.TextBox5.Value = "Approved Budget"
        '
        'TextBox19
        '
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1111111640930176R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox19.StyleName = "Corporate.TableHeader"
        Me.TextBox19.Value = "Estimated amount of Investment"
        '
        'TextBox17
        '
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0625R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox17.StyleName = "Corporate.TableHeader"
        Me.TextBox17.Value = "PR Amount"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox6.StyleName = "Corporate.TableHeader"
        Me.TextBox6.Value = "Balance"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.53958261013031R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox7.StyleName = "Corporate.TableHeader"
        Me.TextBox7.Value = "Target Date of Start of Construction , Installation or delivery"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.341665506362915R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox8.StyleName = "Corporate.TableHeader"
        Me.TextBox8.Value = "Target Date of completion for construction / Installation"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox24, Me.TextBox23})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.20011806488037109R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(0.19999998807907104R))
        Me.TextBox24.Value = "Investment Application Register"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039365557313431054R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(0.19999998807907104R))
        Me.TextBox23.Value = "Furukawa Electric Autoparts Philippines Inc."
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4000394344329834R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.detail.Name = "detail"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.7895783185958862R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.1333328485488892R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.9041666984558105R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.25833261013031R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.1111114025115967R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.0624992847442627R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.79999738931655884R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.5395827293395996R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.3416664600372314R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox9)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox10)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox13)
        Me.Table1.Body.SetCellContent(0, 6, Me.TextBox14)
        Me.Table1.Body.SetCellContent(0, 7, Me.TextBox15)
        Me.Table1.Body.SetCellContent(0, 8, Me.TextBox16)
        Me.Table1.Body.SetCellContent(0, 5, Me.TextBox18)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox20)
        TableGroup1.ReportItem = Me.TextBox1
        TableGroup2.ReportItem = Me.TextBox2
        TableGroup3.ReportItem = Me.TextBox3
        TableGroup4.ReportItem = Me.TextBox5
        TableGroup5.Name = "group1"
        TableGroup5.ReportItem = Me.TextBox19
        TableGroup6.Name = "group"
        TableGroup6.ReportItem = Me.TextBox17
        TableGroup7.ReportItem = Me.TextBox6
        TableGroup8.ReportItem = Me.TextBox7
        TableGroup9.ReportItem = Me.TextBox8
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.ColumnGroups.Add(TableGroup6)
        Me.Table1.ColumnGroups.Add(TableGroup7)
        Me.Table1.ColumnGroups.Add(TableGroup8)
        Me.Table1.ColumnGroups.Add(TableGroup9)
        Me.Table1.DataSource = Me.SqlDataSource1
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox13, Me.TextBox20, Me.TextBox18, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox5, Me.TextBox19, Me.TextBox17, Me.TextBox6, Me.TextBox7, Me.TextBox8})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.Table1.Name = "Table1"
        TableGroup10.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup10.Name = "Detail"
        Me.Table1.RowGroups.Add(TableGroup10)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(12.940267562866211R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.Table1.StyleName = "Corporate.TableNormal"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7895833253860474R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox9.StyleName = "Corporate.TableBody"
        Me.TextBox9.Value = "= Fields.fldInvestmentNo"
        '
        'TextBox10
        '
        Me.TextBox10.Format = "{0:d}"
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1333334445953369R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox10.StyleName = "Corporate.TableBody"
        Me.TextBox10.Value = "= Fields.fldDate"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9041669368743896R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox11.StyleName = "Corporate.TableBody"
        Me.TextBox11.Value = "= Fields.fldProjTitle"
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0:N2}"
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2583328485488892R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox13.StyleName = "Corporate.TableBody"
        Me.TextBox13.Value = "=Fields.fldApprovedBudget"
        '
        'TextBox14
        '
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox14.StyleName = "Corporate.TableBody"
        Me.TextBox14.Value = "=isnull(Fields.fldProdCostJPY,0) - isnull(Fields.TotalPRAmount,0)"
        '
        'TextBox15
        '
        Me.TextBox15.Format = "{0:d}"
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.53958261013031R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox15.StyleName = "Corporate.TableBody"
        Me.TextBox15.Value = "= Fields.fldDateInstallation"
        '
        'TextBox16
        '
        Me.TextBox16.Format = "{0:d}"
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.341665506362915R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox16.StyleName = "Corporate.TableBody"
        Me.TextBox16.Value = "= Fields.fldDateCompletion"
        '
        'TextBox18
        '
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0625R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox18.StyleName = "Corporate.TableBody"
        Me.TextBox18.Value = "= isnull(Fields.TotalPRAmount,0)"
        '
        'TextBox20
        '
        Me.TextBox20.Format = "{0:N2}"
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1111111640930176R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox20.StyleName = "Corporate.TableBody"
        Me.TextBox20.Value = "= Fields.fldProdCostJPY"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" & _
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@InvestmentNo", System.Data.DbType.[String], "= Parameters.InvestmentNo.Value"), New Telerik.Reporting.SqlDataSourceParameter("@Dept", System.Data.DbType.[String], "= Parameters.Dept.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_SelectInvestmentPerInvNoDept"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.299999862909317R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'RptPerInvNo
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "RptPerInvNo"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "InvestmentNo"
        ReportParameter1.Text = "InvestmentNo"
        ReportParameter2.Name = "Dept"
        ReportParameter2.Text = "Dept"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(12.952075004577637R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
End Class
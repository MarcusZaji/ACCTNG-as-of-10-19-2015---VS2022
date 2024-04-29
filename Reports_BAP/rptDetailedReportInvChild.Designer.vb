Partial Class RptPerInvPODetailsChild

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
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0187499523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox1.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox1.StyleName = "Solstice.TableHeader"
        Me.TextBox1.Value = "BUDGET REFFERENCE NO."
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6437497138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox3.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox3.StyleName = "Solstice.TableHeader"
        Me.TextBox3.Value = "JPY AMOUNT"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4562495946884155R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox4.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox4.StyleName = "Solstice.TableHeader"
        Me.TextBox4.Value = "ORIGINAL AMOUNT"
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.362499475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox5.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox5.StyleName = "Solstice.TableHeader"
        Me.TextBox5.Value = "INVESTMENT NO"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3781247138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox6.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox6.StyleName = "Solstice.TableHeader"
        Me.TextBox6.Value = "MONTH ORDER"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6593748331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox7.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox7.StyleName = "Solstice.TableHeader"
        Me.TextBox7.Value = "DEPARTMENT"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2999997138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox8.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox8.StyleName = "Solstice.TableHeader"
        Me.TextBox8.Value = "DESCRIPTION"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6749998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox9.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox9.StyleName = "Solstice.TableHeader"
        Me.TextBox9.Value = "P.R. NO"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox10.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox10.StyleName = "Solstice.TableHeader"
        Me.TextBox10.Value = "QTY"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4093747138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox11.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox11.StyleName = "Solstice.TableHeader"
        Me.TextBox11.Value = "SIGNATURE"
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3333332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox2.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox2.StyleName = "Solstice.TableHeader"
        Me.TextBox2.Value = "STATUS"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000012516975403R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.detail.Name = "detail"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.0187497138977051R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.6437473297119141R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.4562492370605469R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.3625004291534424R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.3781254291534424R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.6593749523162842R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.2999999523162842R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.6749993562698364R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.79999935626983643R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.4093747138977051R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.3333333730697632R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox12)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox14)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox15)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox16)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox17)
        Me.Table1.Body.SetCellContent(0, 5, Me.TextBox18)
        Me.Table1.Body.SetCellContent(0, 6, Me.TextBox19)
        Me.Table1.Body.SetCellContent(0, 7, Me.TextBox20)
        Me.Table1.Body.SetCellContent(0, 8, Me.TextBox21)
        Me.Table1.Body.SetCellContent(0, 9, Me.TextBox22)
        Me.Table1.Body.SetCellContent(0, 10, Me.TextBox13)
        TableGroup1.ReportItem = Me.TextBox1
        TableGroup2.ReportItem = Me.TextBox3
        TableGroup3.ReportItem = Me.TextBox4
        TableGroup4.ReportItem = Me.TextBox5
        TableGroup5.ReportItem = Me.TextBox6
        TableGroup6.ReportItem = Me.TextBox7
        TableGroup7.ReportItem = Me.TextBox8
        TableGroup8.ReportItem = Me.TextBox9
        TableGroup9.ReportItem = Me.TextBox10
        TableGroup10.ReportItem = Me.TextBox11
        TableGroup11.Name = "group"
        TableGroup11.ReportItem = Me.TextBox2
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
        Me.Table1.DataSource = Me.SqlDataSource1
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox12, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox13, Me.TextBox1, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox2})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Table1.Name = "Table1"
        TableGroup12.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup12.Name = "Detail"
        Me.Table1.RowGroups.Add(TableGroup12)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(17.036453247070313R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.Table1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.Table1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.Table1.StyleName = "Solstice.TableNormal"
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0187499523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox12.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox12.StyleName = "Solstice.TableBody"
        Me.TextBox12.Value = "= Fields.fldBudRefNum"
        '
        'TextBox14
        '
        Me.TextBox14.Format = "{0:N2}"
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6437497138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox14.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox14.StyleName = "Solstice.TableBody"
        Me.TextBox14.Value = "= Fields.fldEJPY"
        '
        'TextBox15
        '
        Me.TextBox15.Format = "{0:N2}"
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4562495946884155R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox15.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox15.StyleName = "Solstice.TableBody"
        Me.TextBox15.Value = "= Fields.fldEOA"
        '
        'TextBox16
        '
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.362499475479126R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox16.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox16.StyleName = "Solstice.TableBody"
        Me.TextBox16.Value = "= Fields.fldInvestmentNo"
        '
        'TextBox17
        '
        Me.TextBox17.Format = "{0:d}"
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3781247138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox17.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox17.StyleName = "Solstice.TableBody"
        Me.TextBox17.Value = "= Fields.fldMonthOrder"
        '
        'TextBox18
        '
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6593748331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox18.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox18.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox18.StyleName = "Solstice.TableBody"
        Me.TextBox18.Value = "= Fields.fldOrderDepartment"
        '
        'TextBox19
        '
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2999997138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox19.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox19.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox19.StyleName = "Solstice.TableBody"
        Me.TextBox19.Value = "= Fields.fldOrderRemarks"
        '
        'TextBox20
        '
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6749998331069946R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox20.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox20.StyleName = "Solstice.TableBody"
        Me.TextBox20.Value = "= Fields.fldPRNo"
        '
        'TextBox21
        '
        Me.TextBox21.Format = "{0:N2}"
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox21.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox21.StyleName = "Solstice.TableBody"
        Me.TextBox21.Value = "= Fields.fldQTY"
        '
        'TextBox22
        '
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4093747138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox22.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox22.StyleName = "Solstice.TableBody"
        Me.TextBox22.Value = "= Fields.fldSignature"
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3333332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.LightGray
        Me.TextBox13.Style.Font.Name = "Microsoft Sans Serif"
        Me.TextBox13.StyleName = "Solstice.TableBody"
        Me.TextBox13.Value = "=Fields.fldStatus"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" & _
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@InvestmentNo", System.Data.DbType.[String], "= Parameters.InvestmentNo.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_DetailedReportInvChild"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'RptPerInvPODetailsChild
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "RptPerInvPODetailsChild"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "InvestmentNo"
        ReportParameter1.Text = "InvestmentNo"
        Me.ReportParameters.Add(ReportParameter1)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Solstice.TableNormal")})
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule2.Style.Font.Name = "Gill Sans MT"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.TableBody")})
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule3.Style.Font.Name = "Gill Sans MT"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.TableHeader")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(28, Byte), Integer))
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(201, Byte), Integer))
        StyleRule4.Style.Font.Name = "Gill Sans MT"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(15.703120231628418R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
End Class
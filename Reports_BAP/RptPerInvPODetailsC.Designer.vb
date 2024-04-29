Partial Class RptPerInvPODetailsC
    
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
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector3 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector4 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector5 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule8 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule9 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector6 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule10 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector7 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule11 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector8 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule12 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector9 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule13 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector10 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.Crosstab1 = New Telerik.Reporting.Crosstab()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox65 = New Telerik.Reporting.TextBox()
        Me.TextBox66 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.60003960132598877R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Crosstab1})
        Me.detail.Name = "detail"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" & _
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@InvNo", System.Data.DbType.[String], "= Parameters.InvNo.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_SelectInvPOByInvNo"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'Crosstab1
        '
        Me.Crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.5753124952316284R)))
        Me.Crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.5753124952316284R)))
        Me.Crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R)))
        Me.Crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R)))
        Me.Crosstab1.Body.SetCellContent(0, 0, Me.TextBox47)
        Me.Crosstab1.Body.SetCellContent(0, 1, Me.TextBox48)
        Me.Crosstab1.Body.SetCellContent(1, 0, Me.TextBox65)
        Me.Crosstab1.Body.SetCellContent(1, 1, Me.TextBox66)
        TableGroup1.ReportItem = Me.TextBox13
        TableGroup2.ReportItem = Me.TextBox16
        Me.Crosstab1.ColumnGroups.Add(TableGroup1)
        Me.Crosstab1.ColumnGroups.Add(TableGroup2)
        Me.Crosstab1.Corner.SetCellContent(0, 0, Me.TextBox39)
        Me.Crosstab1.Corner.SetCellContent(0, 1, Me.TextBox40)
        Me.Crosstab1.Corner.SetCellContent(0, 2, Me.TextBox41)
        Me.Crosstab1.Corner.SetCellContent(0, 3, Me.TextBox42)
        Me.Crosstab1.Corner.SetCellContent(0, 4, Me.TextBox43)
        Me.Crosstab1.Corner.SetCellContent(0, 5, Me.TextBox44)
        Me.Crosstab1.Corner.SetCellContent(0, 6, Me.TextBox45)
        Me.Crosstab1.Corner.SetCellContent(0, 7, Me.TextBox46)
        Me.Crosstab1.DataSource = Me.SqlDataSource1
        Me.Crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox47, Me.TextBox48, Me.TextBox65, Me.TextBox66, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.TextBox13, Me.TextBox16, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox38})
        Me.Crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.Crosstab1.Name = "Crosstab1"
        TableGroup11.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup11.Name = "Detail"
        TableGroup10.ChildGroups.Add(TableGroup11)
        TableGroup10.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldSignature"))
        TableGroup10.Name = "fldSignature1"
        TableGroup10.ReportItem = Me.TextBox30
        TableGroup10.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldSignature", Telerik.Reporting.SortDirection.Asc))
        TableGroup9.ChildGroups.Add(TableGroup10)
        TableGroup9.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldQTY"))
        TableGroup9.Name = "fldQTY1"
        TableGroup9.ReportItem = Me.TextBox29
        TableGroup9.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldQTY", Telerik.Reporting.SortDirection.Asc))
        TableGroup8.ChildGroups.Add(TableGroup9)
        TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldPRNo"))
        TableGroup8.Name = "fldPRNo1"
        TableGroup8.ReportItem = Me.TextBox28
        TableGroup8.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldPRNo", Telerik.Reporting.SortDirection.Asc))
        TableGroup7.ChildGroups.Add(TableGroup8)
        TableGroup7.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDesc"))
        TableGroup7.Name = "fldDesc1"
        TableGroup7.ReportItem = Me.TextBox27
        TableGroup7.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDesc", Telerik.Reporting.SortDirection.Asc))
        TableGroup6.ChildGroups.Add(TableGroup7)
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDept"))
        TableGroup6.Name = "fldDept1"
        TableGroup6.ReportItem = Me.TextBox26
        TableGroup6.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDept", Telerik.Reporting.SortDirection.Asc))
        TableGroup5.ChildGroups.Add(TableGroup6)
        TableGroup5.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldMO"))
        TableGroup5.Name = "fldMO1"
        TableGroup5.ReportItem = Me.TextBox25
        TableGroup5.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldMO", Telerik.Reporting.SortDirection.Asc))
        TableGroup4.ChildGroups.Add(TableGroup5)
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldInvestmentNo"))
        TableGroup4.Name = "fldInvestmentNo1"
        TableGroup4.ReportItem = Me.TextBox24
        TableGroup4.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldInvestmentNo", Telerik.Reporting.SortDirection.Asc))
        TableGroup3.ChildGroups.Add(TableGroup4)
        TableGroup3.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldBudRefNum"))
        TableGroup3.Name = "fldBudRefNum1"
        TableGroup3.ReportItem = Me.TextBox23
        TableGroup3.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldBudRefNum", Telerik.Reporting.SortDirection.Asc))
        TableGroup12.ReportItem = Me.TextBox38
        Me.Crosstab1.RowGroups.Add(TableGroup3)
        Me.Crosstab1.RowGroups.Add(TableGroup12)
        Me.Crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(16.206249237060547R), Telerik.Reporting.Drawing.Unit.Inch(0.59999996423721313R))
        Me.Crosstab1.StyleName = "Aspect.TableNormal"
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox13.StyleName = "Aspect.TableHeader"
        Me.TextBox13.Value = "JPY AMOUNT"
        '
        'TextBox16
        '
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox16.StyleName = "Aspect.TableHeader"
        Me.TextBox16.Value = "ORIGINAL AMOUNT"
        '
        'TextBox23
        '
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.028437614440918R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox23.StyleName = "Aspect.TableGroup"
        Me.TextBox23.Value = "= Fields.fldBudRefNum"
        '
        'TextBox24
        '
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox24.StyleName = "Aspect.TableGroup"
        Me.TextBox24.Value = "= Fields.fldInvestmentNo"
        '
        'TextBox25
        '
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox25.StyleName = "Aspect.TableGroup"
        Me.TextBox25.Value = "= Fields.fldMO"
        '
        'TextBox26
        '
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox26.StyleName = "Aspect.TableGroup"
        Me.TextBox26.Value = "= Fields.fldDept"
        '
        'TextBox27
        '
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox27.StyleName = "Aspect.TableGroup"
        Me.TextBox27.Value = "= Fields.fldDesc"
        '
        'TextBox28
        '
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox28.StyleName = "Aspect.TableGroup"
        Me.TextBox28.Value = "= Fields.fldPRNo"
        '
        'TextBox29
        '
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox29.StyleName = "Aspect.TableGroup"
        Me.TextBox29.Value = "= Fields.fldQTY"
        '
        'TextBox30
        '
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753124952316284R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox30.StyleName = "Aspect.TableGroup"
        Me.TextBox30.Value = "= Fields.fldSignature"
        '
        'TextBox38
        '
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(13.055624961853027R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox38.StyleName = "Aspect.GrandTotal"
        Me.TextBox38.Value = "Total"
        '
        'TextBox39
        '
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.028437614440918R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox39.StyleName = "Aspect.TableHeader"
        Me.TextBox39.Value = "BUDGET REFFERENCE NO."
        '
        'TextBox40
        '
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox40.StyleName = "Aspect.TableHeader"
        Me.TextBox40.Value = "INVESTMENT NO"
        '
        'TextBox41
        '
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox41.StyleName = "Aspect.TableHeader"
        Me.TextBox41.Value = "MONTH ORDER"
        '
        'TextBox42
        '
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox42.StyleName = "Aspect.TableHeader"
        Me.TextBox42.Value = "DEPARTMENT"
        '
        'TextBox43
        '
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox43.StyleName = "Aspect.TableHeader"
        Me.TextBox43.Value = "DESCRIPTION"
        '
        'TextBox44
        '
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox44.StyleName = "Aspect.TableHeader"
        Me.TextBox44.Value = "P.R. NO"
        '
        'TextBox45
        '
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox45.StyleName = "Aspect.TableHeader"
        Me.TextBox45.Value = "QTY"
        '
        'TextBox46
        '
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753124952316284R), Telerik.Reporting.Drawing.Unit.Inch(0.20000001788139343R))
        Me.TextBox46.StyleName = "Aspect.TableHeader"
        Me.TextBox46.Value = "SIGNATURE"
        '
        'TextBox47
        '
        Me.TextBox47.Format = "{0:N2}"
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox47.StyleName = "Aspect.TableBody"
        Me.TextBox47.Value = "= Fields.fldYen"
        '
        'TextBox48
        '
        Me.TextBox48.Format = "{0:N2}"
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox48.StyleName = "Aspect.TableBody"
        Me.TextBox48.Value = "= Fields.fldTotalCost"
        '
        'TextBox65
        '
        Me.TextBox65.Format = "{0:N2}"
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox65.StyleName = "Aspect.GrandTotal"
        Me.TextBox65.Value = "= Sum(Fields.fldYen)"
        '
        'TextBox66
        '
        Me.TextBox66.Format = "{0:N2}"
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5753123760223389R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox66.StyleName = "Aspect.GrandTotal"
        Me.TextBox66.Value = "= Sum(Fields.fldTotalCost)"
        '
        'RptPerInvPODetailsC
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "RptPerInvPODetailsC"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "InvNo"
        ReportParameter1.Text = "InvNo"
        ReportParameter1.Value = ""
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
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.SubTotal")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(228, Byte), Integer))
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule4.Style.Font.Name = "Gill Sans MT"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.GrandTotal")})
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule5.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(189, Byte), Integer))
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule5.Style.Font.Bold = True
        StyleRule5.Style.Font.Italic = False
        StyleRule5.Style.Font.Name = "Gill Sans MT"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule5.Style.Font.Strikeout = False
        StyleRule5.Style.Font.Underline = False
        DescendantSelector4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.TableHeader")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector4})
        StyleRule6.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(28, Byte), Integer))
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(201, Byte), Integer))
        StyleRule6.Style.Font.Name = "Gill Sans MT"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.TableGroup")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector5})
        StyleRule7.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(201, Byte), Integer))
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule7.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule7.Style.Font.Name = "Gill Sans MT"
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Aspect.TableNormal")})
        StyleRule8.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule8.Style.Color = System.Drawing.Color.Black
        StyleRule8.Style.Font.Name = "Verdana"
        StyleRule8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Aspect.SubTotal")})
        StyleRule9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector6})
        StyleRule9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(209, Byte), Integer))
        StyleRule9.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule9.Style.Font.Name = "Verdana"
        StyleRule9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        DescendantSelector7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Aspect.TableBody")})
        StyleRule10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector7})
        StyleRule10.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule10.Style.Font.Name = "Verdana"
        StyleRule10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Aspect.GrandTotal")})
        StyleRule11.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector8})
        StyleRule11.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(143, Byte), Integer))
        StyleRule11.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule11.Style.Color = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        StyleRule11.Style.Font.Bold = True
        StyleRule11.Style.Font.Italic = False
        StyleRule11.Style.Font.Name = "Verdana"
        StyleRule11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule11.Style.Font.Strikeout = False
        StyleRule11.Style.Font.Underline = False
        DescendantSelector9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Aspect.TableHeader")})
        StyleRule12.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector9})
        StyleRule12.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        StyleRule12.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule12.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule12.Style.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(209, Byte), Integer))
        StyleRule12.Style.Font.Name = "Verdana"
        StyleRule12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Aspect.TableGroup")})
        StyleRule13.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector10})
        StyleRule13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        StyleRule13.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule13.Style.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        StyleRule13.Style.Font.Name = "Verdana"
        StyleRule13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8, StyleRule9, StyleRule10, StyleRule11, StyleRule12, StyleRule13})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(16.206249237060547R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents Crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox65 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox66 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
End Class
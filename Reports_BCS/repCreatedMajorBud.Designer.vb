Partial Class repCreatedMajorBud

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
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.552R), Telerik.Reporting.Drawing.Unit.Inch(0.385R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "MAJOR REF NO"
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.257R), Telerik.Reporting.Drawing.Unit.Inch(0.385R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.StyleName = ""
        Me.TextBox1.Value = "DESCRIPTION"
        '
        'TextBox37
        '
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.385R))
        Me.TextBox37.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox37.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox37.Style.Font.Bold = True
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.StyleName = ""
        Me.TextBox37.Value = "ORIGINAL AMOUNT"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.385R))
        Me.TextBox7.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.StyleName = ""
        Me.TextBox7.Value = "DEPARTMENT"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.094R), Telerik.Reporting.Drawing.Unit.Inch(0.385R))
        Me.TextBox4.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.StyleName = ""
        Me.TextBox4.Value = "PROJECT / NON PROJECT"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.593R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.detail.Name = "detail"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.552R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.257R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.094R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.208R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox3)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox38)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox5)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox8)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox6)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.TextBox2
        TableGroup2.Name = "group1"
        TableGroup2.ReportItem = Me.TextBox1
        TableGroup3.Name = "group7"
        TableGroup3.ReportItem = Me.TextBox37
        TableGroup4.Name = "group2"
        TableGroup4.ReportItem = Me.TextBox7
        TableGroup5.Name = "group3"
        TableGroup5.ReportItem = Me.TextBox4
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.DataSource = Me.SqlDataSource1
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox5, Me.TextBox38, Me.TextBox8, Me.TextBox6, Me.TextBox2, Me.TextBox1, Me.TextBox37, Me.TextBox7, Me.TextBox4})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Table1.Name = "Table1"
        TableGroup8.Name = "group"
        TableGroup7.ChildGroups.Add(TableGroup8)
        TableGroup7.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup7.Name = "detailTableGroup"
        TableGroup6.ChildGroups.Add(TableGroup7)
        TableGroup6.Name = "fldClass1"
        Me.Table1.RowGroups.Add(TableGroup6)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.903R), Telerik.Reporting.Drawing.Unit.Inch(0.593R))
        Me.Table1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Table1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.Table1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.Table1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.552R), Telerik.Reporting.Drawing.Unit.Inch(0.208R))
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Value = "=Fields.fldSubRefNo"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:N2}"
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.208R))
        Me.TextBox38.Style.BackgroundColor = System.Drawing.Color.Transparent
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.StyleName = ""
        Me.TextBox38.Value = "= Fields.totalamount"
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.257R), Telerik.Reporting.Drawing.Unit.Inch(0.208R))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox5.StyleName = ""
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.208R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.Transparent
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.StyleName = ""
        Me.TextBox8.Value = "= Fields.fldDept"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.094R), Telerik.Reporting.Drawing.Unit.Inch(0.208R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.Transparent
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.StyleName = ""
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.252; Database = dbBCS; Uid = feap; Pwd = 45|iF$; Convert Zer" &
    "o Datetime=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@SetYear", System.Data.DbType.[String], "= Parameters.BYEAR.Value"))
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBCS.SP_SelectAllMajorBud"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'repCreatedMajorBud
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "repUserBudCreated"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "BYEAR"
        ReportParameter1.Text = "BYEAR"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(6.521R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
End Class
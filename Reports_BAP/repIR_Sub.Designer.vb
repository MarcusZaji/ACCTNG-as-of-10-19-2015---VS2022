Partial Class repIR_Sub

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
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldICodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldtxtUPrice = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.ReportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30000013113021851R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldICodeDataTextBox, Me.fldtxtUPrice, Me.TextBox4})
        Me.detail.Name = "detail"
        '
        'fldICodeDataTextBox
        '
        Me.fldICodeDataTextBox.CanGrow = True
        Me.fldICodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.fldICodeDataTextBox.Name = "fldICodeDataTextBox"
        Me.fldICodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.fldICodeDataTextBox.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldICodeDataTextBox.Style.Font.Name = "Times New Roman"
        Me.fldICodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.fldICodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.fldICodeDataTextBox.StyleName = "Data"
        Me.fldICodeDataTextBox.Value = "= Fields.fldICode"
        '
        'fldtxtUPrice
        '
        Me.fldtxtUPrice.CanGrow = True
        Me.fldtxtUPrice.Format = "{0:N2}"
        Me.fldtxtUPrice.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.fldtxtUPrice.Name = "fldtxtUPrice"
        Me.fldtxtUPrice.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.15000000596046448R))
        Me.fldtxtUPrice.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.fldtxtUPrice.Style.Font.Name = "Times New Roman"
        Me.fldtxtUPrice.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.fldtxtUPrice.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.fldtxtUPrice.StyleName = "Data"
        Me.fldtxtUPrice.Value = "= Fields.fldUPrice"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.15011808276176453R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4999604225158691R), Telerik.Reporting.Drawing.Unit.Inch(0.14988201856613159R))
        Me.TextBox4.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox4.Style.Font.Name = "Times New Roman"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.StyleName = "Data"
        Me.TextBox4.Value = "= Fields.fldRD"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "ACCTNG.My.MySettings.dbcihvbox2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@CPONo", System.Data.DbType.[String], Nothing)})
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_CPOReport"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R)
        Me.ReportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox1})
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.19996066391468048R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox3.Style.Font.Name = "Times New Roman"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.StyleName = "Data"
        Me.TextBox3.Value = "TOTAL PREVIOUS AMOUNT"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Format = "{0:N2}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5000789165496826R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999605417251587R), Telerik.Reporting.Drawing.Unit.Inch(0.19996066391468048R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox1.Style.Font.Name = "Times New Roman"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "= Fields.LTPO"
        '
        'repIR_Sub
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.detail, Me.ReportFooterSection1})
        Me.Name = "repOrderItem"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "CPONo"
        ReportParameter1.Text = "CPONo"
        Me.ReportParameters.Add(ReportParameter1)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.7000002861022949R)
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fldICodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldtxtUPrice As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents ReportFooterSection1 As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class
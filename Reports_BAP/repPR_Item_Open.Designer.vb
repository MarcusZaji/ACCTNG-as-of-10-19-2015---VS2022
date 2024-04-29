Partial Class repPR_Item_Open

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
        Me.fldClassCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDescCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldICodeCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMOCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthDeliveryCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldProcessCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldBudRefNumCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldUnitCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.fldRSCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.fldStatCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.fldSignatureCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.fldBudRefNumDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDeptDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldDescDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldICodeDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMODataTextBox = New Telerik.Reporting.TextBox()
        Me.fldPRNoDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldProcessDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldQTYDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldRSDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldUnitDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldClassDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldMonthDeliveryDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.fldStatDataTextBox = New Telerik.Reporting.TextBox()
        Me.fldSignatureDataTextBox = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40007886290550232R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldClassCaptionTextBox, Me.fldDescCaptionTextBox, Me.fldICodeCaptionTextBox, Me.fldMOCaptionTextBox, Me.fldMonthDeliveryCaptionTextBox, Me.fldPRNoCaptionTextBox, Me.fldProcessCaptionTextBox, Me.fldBudRefNumCaptionTextBox, Me.fldDeptCaptionTextBox, Me.fldQTYCaptionTextBox, Me.fldUnitCaptionTextBox, Me.fldRSCaptionTextBox, Me.TextBox3, Me.fldStatCaptionTextBox, Me.TextBox1, Me.fldSignatureCaptionTextBox, Me.TextBox4, Me.TextBox5})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'fldClassCaptionTextBox
        '
        Me.fldClassCaptionTextBox.CanGrow = True
        Me.fldClassCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.077085018157959R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassCaptionTextBox.Name = "fldClassCaptionTextBox"
        Me.fldClassCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992120265960693R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldClassCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassCaptionTextBox.StyleName = "Caption"
        Me.fldClassCaptionTextBox.Value = "CLASSIFICATION"
        '
        'fldDescCaptionTextBox
        '
        Me.fldDescCaptionTextBox.CanGrow = True
        Me.fldDescCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0770840644836426R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldDescCaptionTextBox.Name = "fldDescCaptionTextBox"
        Me.fldDescCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.97233510017395R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDescCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDescCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDescCaptionTextBox.StyleName = "Caption"
        Me.fldDescCaptionTextBox.Value = "DESCRIPTION"
        '
        'fldICodeCaptionTextBox
        '
        Me.fldICodeCaptionTextBox.CanGrow = True
        Me.fldICodeCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0770859718322754R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldICodeCaptionTextBox.Name = "fldICodeCaptionTextBox"
        Me.fldICodeCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992156028747559R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldICodeCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldICodeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldICodeCaptionTextBox.StyleName = "Caption"
        Me.fldICodeCaptionTextBox.Value = "ITEM CODE"
        '
        'fldMOCaptionTextBox
        '
        Me.fldMOCaptionTextBox.CanGrow = True
        Me.fldMOCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0494956970214844R), Telerik.Reporting.Drawing.Unit.Inch(0.000078678131103515625R))
        Me.fldMOCaptionTextBox.Name = "fldMOCaptionTextBox"
        Me.fldMOCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0915874242782593R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMOCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMOCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMOCaptionTextBox.StyleName = "Caption"
        Me.fldMOCaptionTextBox.Value = "MONTH ORDER"
        '
        'fldMonthDeliveryCaptionTextBox
        '
        Me.fldMonthDeliveryCaptionTextBox.CanGrow = True
        Me.fldMonthDeliveryCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.141168594360352R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldMonthDeliveryCaptionTextBox.Name = "fldMonthDeliveryCaptionTextBox"
        Me.fldMonthDeliveryCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2229175567626953R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMonthDeliveryCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldMonthDeliveryCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMonthDeliveryCaptionTextBox.StyleName = "Caption"
        Me.fldMonthDeliveryCaptionTextBox.Value = "MONTH DELIVERY"
        '
        'fldPRNoCaptionTextBox
        '
        Me.fldPRNoCaptionTextBox.CanGrow = True
        Me.fldPRNoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.10007905960083R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoCaptionTextBox.Name = "fldPRNoCaptionTextBox"
        Me.fldPRNoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.97692722082138062R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldPRNoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoCaptionTextBox.StyleName = "Caption"
        Me.fldPRNoCaptionTextBox.Value = "PURCHASED REQUISITION NO."
        '
        'fldProcessCaptionTextBox
        '
        Me.fldProcessCaptionTextBox.CanGrow = True
        Me.fldProcessCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.364164352416992R), Telerik.Reporting.Drawing.Unit.Inch(0.0000787973403930664R))
        Me.fldProcessCaptionTextBox.Name = "fldProcessCaptionTextBox"
        Me.fldProcessCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldProcessCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldProcessCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldProcessCaptionTextBox.StyleName = "Caption"
        Me.fldProcessCaptionTextBox.Value = "PROCESS"
        '
        'fldBudRefNumCaptionTextBox
        '
        Me.fldBudRefNumCaptionTextBox.CanGrow = True
        Me.fldBudRefNumCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000000013535221832228217R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldBudRefNumCaptionTextBox.Name = "fldBudRefNumCaptionTextBox"
        Me.fldBudRefNumCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldBudRefNumCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumCaptionTextBox.StyleName = "Caption"
        Me.fldBudRefNumCaptionTextBox.Value = "BUDGET REFERENCE NO."
        '
        'fldDeptCaptionTextBox
        '
        Me.fldDeptCaptionTextBox.CanGrow = True
        Me.fldDeptCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0770859718322754R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptCaptionTextBox.Name = "fldDeptCaptionTextBox"
        Me.fldDeptCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992120265960693R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldDeptCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptCaptionTextBox.StyleName = "Caption"
        Me.fldDeptCaptionTextBox.Value = "DEPARTMENT"
        '
        'fldQTYCaptionTextBox
        '
        Me.fldQTYCaptionTextBox.CanGrow = True
        Me.fldQTYCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.764163970947266R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldQTYCaptionTextBox.Name = "fldQTYCaptionTextBox"
        Me.fldQTYCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.88854193687438965R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldQTYCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldQTYCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYCaptionTextBox.StyleName = "Caption"
        Me.fldQTYCaptionTextBox.Value = "QTY"
        '
        'fldUnitCaptionTextBox
        '
        Me.fldUnitCaptionTextBox.CanGrow = True
        Me.fldUnitCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.652785301208496R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldUnitCaptionTextBox.Name = "fldUnitCaptionTextBox"
        Me.fldUnitCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71122080087661743R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUnitCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldUnitCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUnitCaptionTextBox.StyleName = "Caption"
        Me.fldUnitCaptionTextBox.Value = "UNIT"
        '
        'fldRSCaptionTextBox
        '
        Me.fldRSCaptionTextBox.CanGrow = True
        Me.fldRSCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.36408519744873R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldRSCaptionTextBox.Name = "fldRSCaptionTextBox"
        Me.fldRSCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999204158782959R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldRSCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldRSCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldRSCaptionTextBox.StyleName = "Caption"
        Me.fldRSCaptionTextBox.Value = "RS"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.564084053039551R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "ESTIMATED PR AMOUNT"
        '
        'fldStatCaptionTextBox
        '
        Me.fldStatCaptionTextBox.CanGrow = True
        Me.fldStatCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.894918441772461R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldStatCaptionTextBox.Name = "fldStatCaptionTextBox"
        Me.fldStatCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldStatCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldStatCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatCaptionTextBox.StyleName = "Caption"
        Me.fldStatCaptionTextBox.Value = "STATUS"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.757608413696289R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1372299194335937R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.StyleName = "Caption"
        Me.TextBox1.Value = "PO AMOUNT"
        '
        'fldSignatureCaptionTextBox
        '
        Me.fldSignatureCaptionTextBox.CanGrow = True
        Me.fldSignatureCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(23.194921493530273R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldSignatureCaptionTextBox.Name = "fldSignatureCaptionTextBox"
        Me.fldSignatureCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldSignatureCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.fldSignatureCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSignatureCaptionTextBox.StyleName = "Caption"
        Me.fldSignatureCaptionTextBox.Value = "SIGNATURE"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.96192741394043R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "ESTIMATED JPY AMOUNT"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.359769821166992R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "CURRENCY"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CommandTimeout = 0
        Me.SqlDataSource1.ConnectionString = "Server = 192.168.191.12;Database=dbBAP;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=" & _
    "True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@DEPT", System.Data.DbType.[String], "=Parameters.DEPT.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D1", System.Data.DbType.DateTime, "=Parameters.D1.Value"), New Telerik.Reporting.SqlDataSourceParameter("@D2", System.Data.DbType.DateTime, "=Parameters.D2.Value")})
        Me.SqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.SqlDataSource1.SelectCommand = "dbBAP.SP_PRListOpen"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(22.929445266723633R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6618484258651733R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.StyleName = "PageInfo"
        Me.TextBox6.Value = "Budget Actual Program (BAP)"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(22.929372787475586R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Furukawa Electric Autoparts Phil. Inc."
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(23.193532943725586R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977229595184326R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.45999997854232788R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(24.59129524230957R), Telerik.Reporting.Drawing.Unit.Inch(0.46000000834465027R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Purchase Requisition List"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.43992114067077637R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.fldBudRefNumDataTextBox, Me.fldDeptDataTextBox, Me.fldDescDataTextBox, Me.fldICodeDataTextBox, Me.fldMODataTextBox, Me.fldPRNoDataTextBox, Me.fldProcessDataTextBox, Me.fldQTYDataTextBox, Me.fldRSDataTextBox, Me.fldUnitDataTextBox, Me.fldClassDataTextBox, Me.fldMonthDeliveryDataTextBox, Me.TextBox2, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.fldStatDataTextBox, Me.fldSignatureDataTextBox})
        Me.detail.Name = "detail"
        '
        'fldBudRefNumDataTextBox
        '
        Me.fldBudRefNumDataTextBox.CanGrow = True
        Me.fldBudRefNumDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(-0.000000019868215517249155R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldBudRefNumDataTextBox.Name = "fldBudRefNumDataTextBox"
        Me.fldBudRefNumDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldBudRefNumDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldBudRefNumDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldBudRefNumDataTextBox.StyleName = "Data"
        Me.fldBudRefNumDataTextBox.Value = "=Fields.fldBudRefNum"
        '
        'fldDeptDataTextBox
        '
        Me.fldDeptDataTextBox.CanGrow = True
        Me.fldDeptDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0770857334136963R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldDeptDataTextBox.Name = "fldDeptDataTextBox"
        Me.fldDeptDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992120265960693R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDeptDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDeptDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDeptDataTextBox.StyleName = "Data"
        Me.fldDeptDataTextBox.Value = "=Fields.fldDept"
        '
        'fldDescDataTextBox
        '
        Me.fldDescDataTextBox.CanGrow = True
        Me.fldDescDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0770845413208008R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldDescDataTextBox.Name = "fldDescDataTextBox"
        Me.fldDescDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.97233510017395R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldDescDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldDescDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldDescDataTextBox.StyleName = "Data"
        Me.fldDescDataTextBox.Value = "=Fields.fldDesc"
        '
        'fldICodeDataTextBox
        '
        Me.fldICodeDataTextBox.CanGrow = True
        Me.fldICodeDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0770859718322754R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldICodeDataTextBox.Name = "fldICodeDataTextBox"
        Me.fldICodeDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992156028747559R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldICodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldICodeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldICodeDataTextBox.StyleName = "Data"
        Me.fldICodeDataTextBox.Value = "=Fields.fldICode"
        '
        'fldMODataTextBox
        '
        Me.fldMODataTextBox.CanGrow = True
        Me.fldMODataTextBox.Format = "{0:d}"
        Me.fldMODataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0494956970214844R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldMODataTextBox.Name = "fldMODataTextBox"
        Me.fldMODataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0915874242782593R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMODataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMODataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMODataTextBox.StyleName = "Data"
        Me.fldMODataTextBox.Value = "=Fields.fldMO"
        '
        'fldPRNoDataTextBox
        '
        Me.fldPRNoDataTextBox.CanGrow = True
        Me.fldPRNoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1000789403915405R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldPRNoDataTextBox.Name = "fldPRNoDataTextBox"
        Me.fldPRNoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.97692722082138062R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldPRNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldPRNoDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldPRNoDataTextBox.StyleName = "Data"
        Me.fldPRNoDataTextBox.Value = "=Fields.fldPRNo"
        '
        'fldProcessDataTextBox
        '
        Me.fldProcessDataTextBox.CanGrow = True
        Me.fldProcessDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.364164352416992R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldProcessDataTextBox.Name = "fldProcessDataTextBox"
        Me.fldProcessDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldProcessDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldProcessDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldProcessDataTextBox.StyleName = "Data"
        Me.fldProcessDataTextBox.Value = "=Fields.fldProcess"
        '
        'fldQTYDataTextBox
        '
        Me.fldQTYDataTextBox.CanGrow = True
        Me.fldQTYDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.764163970947266R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldQTYDataTextBox.Name = "fldQTYDataTextBox"
        Me.fldQTYDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.88854193687438965R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldQTYDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldQTYDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldQTYDataTextBox.StyleName = "Data"
        Me.fldQTYDataTextBox.Value = "=Fields.fldQTY"
        '
        'fldRSDataTextBox
        '
        Me.fldRSDataTextBox.CanGrow = True
        Me.fldRSDataTextBox.Format = ""
        Me.fldRSDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.364086151123047R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldRSDataTextBox.Name = "fldRSDataTextBox"
        Me.fldRSDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999204158782959R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldRSDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldRSDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldRSDataTextBox.StyleName = "Data"
        Me.fldRSDataTextBox.Value = "=Fields.fldRS"
        '
        'fldUnitDataTextBox
        '
        Me.fldUnitDataTextBox.CanGrow = True
        Me.fldUnitDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.652785301208496R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldUnitDataTextBox.Name = "fldUnitDataTextBox"
        Me.fldUnitDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.71122080087661743R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldUnitDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldUnitDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldUnitDataTextBox.StyleName = "Data"
        Me.fldUnitDataTextBox.Value = "=Fields.fldUnit"
        '
        'fldClassDataTextBox
        '
        Me.fldClassDataTextBox.CanGrow = True
        Me.fldClassDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.07708477973938R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.fldClassDataTextBox.Name = "fldClassDataTextBox"
        Me.fldClassDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992120265960693R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldClassDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldClassDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldClassDataTextBox.StyleName = "Data"
        Me.fldClassDataTextBox.Value = "=Fields.fldClass"
        '
        'fldMonthDeliveryDataTextBox
        '
        Me.fldMonthDeliveryDataTextBox.CanGrow = True
        Me.fldMonthDeliveryDataTextBox.Format = "{0:d}"
        Me.fldMonthDeliveryDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.141167640686035R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldMonthDeliveryDataTextBox.Name = "fldMonthDeliveryDataTextBox"
        Me.fldMonthDeliveryDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2229175567626953R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldMonthDeliveryDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldMonthDeliveryDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldMonthDeliveryDataTextBox.StyleName = "Data"
        Me.fldMonthDeliveryDataTextBox.Value = "=Fields.fldMonthDelivery"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.757612228393555R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1372284889221191R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Data"
        Me.TextBox2.Value = "=Fields.POAmount"
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.564084053039551R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "=Fields.fldEOA"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.96192741394043R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "=Fields.fldEJPY"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.359769821166992R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "=Fields.fldEC"
        '
        'fldStatDataTextBox
        '
        Me.fldStatDataTextBox.CanGrow = True
        Me.fldStatDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.894918441772461R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.fldStatDataTextBox.Name = "fldStatDataTextBox"
        Me.fldStatDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldStatDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldStatDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldStatDataTextBox.StyleName = "Data"
        Me.fldStatDataTextBox.Value = "=Fields.fldStat"
        '
        'fldSignatureDataTextBox
        '
        Me.fldSignatureDataTextBox.CanGrow = True
        Me.fldSignatureDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(23.194921493530273R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.fldSignatureDataTextBox.Name = "fldSignatureDataTextBox"
        Me.fldSignatureDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3977644443511963R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.fldSignatureDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.fldSignatureDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.fldSignatureDataTextBox.StyleName = "Data"
        Me.fldSignatureDataTextBox.Value = "=Fields.fldSignature"
        '
        'repPR_Item_Open
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "repPR_Item"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "DEPT"
        ReportParameter1.Text = "DEPT"
        ReportParameter2.Name = "D1"
        ReportParameter2.Text = "D1"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "D2"
        ReportParameter3.Text = "D2"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(24.592683792114258R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents fldBudRefNumCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDescCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldICodeCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMOCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthDeliveryCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldProcessCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldRSCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSignatureCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldStatCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUnitCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents fldBudRefNumDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldClassDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDeptDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldDescDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldICodeDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMODataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldMonthDeliveryDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldPRNoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldProcessDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldQTYDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldRSDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldSignatureDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents fldUnitDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents fldStatDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
End Class
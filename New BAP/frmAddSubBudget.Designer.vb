<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddSubBudget
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddSubBudget))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbPaste = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbStartImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteSelected = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClearList = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBRNum = New Telerik.WinControls.UI.RadTextBox()
        Me.dtpSOU = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.mebQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlProcess = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.mebJPY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.mebAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.dtpMBudgeted = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlStat = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.ddlMBudget = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCommandBar1.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSOU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebJPY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMBudgeted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlMBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlMBudget.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlMBudget.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Controls.Add(Me.RadPanel1)
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1065, 83)
        Me.RadCommandBar1.TabIndex = 7
        Me.RadCommandBar1.ThemeName = "Fluent"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RadProgressBar1)
        Me.RadPanel1.Controls.Add(Me.dtpDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel22)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadPanel1.Location = New System.Drawing.Point(770, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(295, 83)
        Me.RadPanel1.TabIndex = 24
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(153, 22)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(139, 24)
        Me.RadProgressBar1.TabIndex = 136
        Me.RadProgressBar1.ThemeName = "Fluent"
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(58, 22)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(89, 24)
        Me.dtpDate.TabIndex = 135
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "9/11/2014"
        Me.dtpDate.ThemeName = "Fluent"
        Me.dtpDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel22
        '
        Me.RadLabel22.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel22.Location = New System.Drawing.Point(7, 23)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(33, 21)
        Me.RadLabel22.TabIndex = 134
        Me.RadLabel22.Text = "Year"
        Me.RadLabel22.ThemeName = "Windows8"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        Me.CommandBarRowElement1.Text = ""
        Me.CommandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.UseCompatibleTextRendering = False
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.DisplayName = "Tool Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbPaste, Me.cbbStartImport, Me.cbbDeleteSelected, Me.cbbClearList, Me.btnExport})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbPaste
        '
        Me.cbbPaste.AutoSize = False
        Me.cbbPaste.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbPaste.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbPaste.DisplayName = "Paste Data"
        Me.cbbPaste.DrawText = True
        Me.cbbPaste.Image = CType(resources.GetObject("cbbPaste.Image"), System.Drawing.Image)
        Me.cbbPaste.Name = "cbbPaste"
        Me.cbbPaste.Text = "Paste Data"
        Me.cbbPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbPaste.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbPaste.UseCompatibleTextRendering = False
        '
        'cbbStartImport
        '
        Me.cbbStartImport.AutoSize = False
        Me.cbbStartImport.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbStartImport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbStartImport.DisplayName = "Start Import"
        Me.cbbStartImport.DrawText = True
        Me.cbbStartImport.Image = CType(resources.GetObject("cbbStartImport.Image"), System.Drawing.Image)
        Me.cbbStartImport.Name = "cbbStartImport"
        Me.cbbStartImport.Text = "Start Import"
        Me.cbbStartImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbStartImport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbStartImport.UseCompatibleTextRendering = False
        '
        'cbbDeleteSelected
        '
        Me.cbbDeleteSelected.AutoSize = False
        Me.cbbDeleteSelected.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbDeleteSelected.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDeleteSelected.DisplayName = "Delete Selected"
        Me.cbbDeleteSelected.DrawText = True
        Me.cbbDeleteSelected.Image = CType(resources.GetObject("cbbDeleteSelected.Image"), System.Drawing.Image)
        Me.cbbDeleteSelected.Name = "cbbDeleteSelected"
        Me.cbbDeleteSelected.Text = "Delete Selected"
        Me.cbbDeleteSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbDeleteSelected.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDeleteSelected.UseCompatibleTextRendering = False
        '
        'cbbClearList
        '
        Me.cbbClearList.AutoSize = False
        Me.cbbClearList.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbClearList.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClearList.DisplayName = "Clear List"
        Me.cbbClearList.DrawText = True
        Me.cbbClearList.Image = CType(resources.GetObject("cbbClearList.Image"), System.Drawing.Image)
        Me.cbbClearList.Name = "cbbClearList"
        Me.cbbClearList.Text = "Clear List"
        Me.cbbClearList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbClearList.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClearList.UseCompatibleTextRendering = False
        '
        'btnExport
        '
        Me.btnExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnExport.DisplayName = "Export Data"
        Me.btnExport.DrawText = True
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Text = "Export Data"
        Me.btnExport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnExport.UseCompatibleTextRendering = False
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvList.Location = New System.Drawing.Point(0, 290)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.MultiSelect = True
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(1065, 296)
        Me.rgvList.TabIndex = 9
        Me.rgvList.ThemeName = "Fluent"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(12, 97)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel6.TabIndex = 404
        Me.RadLabel6.Text = "Budget Reference Number"
        Me.RadLabel6.ThemeName = "Fluent"
        '
        'txtBRNum
        '
        Me.txtBRNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBRNum.Location = New System.Drawing.Point(187, 97)
        Me.txtBRNum.Name = "txtBRNum"
        Me.txtBRNum.Size = New System.Drawing.Size(189, 24)
        Me.txtBRNum.TabIndex = 2
        Me.txtBRNum.ThemeName = "Fluent"
        '
        'dtpSOU
        '
        Me.dtpSOU.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpSOU.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSOU.Location = New System.Drawing.Point(555, 98)
        Me.dtpSOU.Name = "dtpSOU"
        Me.dtpSOU.Size = New System.Drawing.Size(189, 24)
        Me.dtpSOU.TabIndex = 9
        Me.dtpSOU.TabStop = False
        Me.dtpSOU.Text = "9/11/2014"
        Me.dtpSOU.ThemeName = "Fluent"
        Me.dtpSOU.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel17.Location = New System.Drawing.Point(396, 98)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(76, 21)
        Me.RadLabel17.TabIndex = 216
        Me.RadLabel17.Text = "Start of Use"
        Me.RadLabel17.ThemeName = "Fluent"
        '
        'mebQTY
        '
        Me.mebQTY.Location = New System.Drawing.Point(187, 234)
        Me.mebQTY.Mask = "N2"
        Me.mebQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebQTY.Name = "mebQTY"
        Me.mebQTY.Size = New System.Drawing.Size(189, 24)
        Me.mebQTY.TabIndex = 7
        Me.mebQTY.TabStop = False
        Me.mebQTY.Tag = "C"
        Me.mebQTY.Text = "0.00"
        Me.mebQTY.ThemeName = "Fluent"
        '
        'RadLabel16
        '
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(396, 72)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel16.TabIndex = 215
        Me.RadLabel16.Text = "Unit of Measurement"
        Me.RadLabel16.ThemeName = "Fluent"
        '
        'ddlUOM
        '
        Me.ddlUOM.DropDownAnimationEnabled = True
        Me.ddlUOM.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PCS"
        RadListDataItem2.Text = "LOT"
        Me.ddlUOM.Items.Add(RadListDataItem1)
        Me.ddlUOM.Items.Add(RadListDataItem2)
        Me.ddlUOM.Location = New System.Drawing.Point(555, 72)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(189, 24)
        Me.ddlUOM.TabIndex = 8
        Me.ddlUOM.ThemeName = "Fluent"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(12, 237)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel15.TabIndex = 214
        Me.RadLabel15.Text = "Quantity"
        Me.RadLabel15.ThemeName = "Fluent"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(12, 176)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel14.TabIndex = 213
        Me.RadLabel14.Text = "Description"
        Me.RadLabel14.ThemeName = "Fluent"
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.Location = New System.Drawing.Point(187, 176)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 21)
        Me.txtDesc.TabIndex = 5
        Me.txtDesc.ThemeName = "Fluent"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownAnimationEnabled = True
        Me.ddlDept.DropDownHeight = 200
        Me.ddlDept.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Location = New System.Drawing.Point(187, 123)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 24)
        Me.ddlDept.TabIndex = 3
        Me.ddlDept.ThemeName = "Fluent"
        '
        'ddlProcess
        '
        Me.ddlProcess.DropDownAnimationEnabled = True
        Me.ddlProcess.DropDownHeight = 200
        Me.ddlProcess.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlProcess.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlProcess.Location = New System.Drawing.Point(187, 204)
        Me.ddlProcess.Name = "ddlProcess"
        Me.ddlProcess.Size = New System.Drawing.Size(189, 24)
        Me.ddlProcess.TabIndex = 6
        Me.ddlProcess.ThemeName = "Fluent"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownAnimationEnabled = True
        Me.ddlClass.DropDownHeight = 200
        Me.ddlClass.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(187, 150)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(189, 24)
        Me.ddlClass.TabIndex = 4
        Me.ddlClass.ThemeName = "Fluent"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(12, 204)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 21)
        Me.RadLabel3.TabIndex = 212
        Me.RadLabel3.Text = "Process"
        Me.RadLabel3.ThemeName = "Fluent"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(12, 150)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel2.TabIndex = 211
        Me.RadLabel2.Text = "Classification"
        Me.RadLabel2.ThemeName = "Fluent"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(12, 123)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 210
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Fluent"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownAnimationEnabled = True
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "PHP"
        RadListDataItem4.Text = "JPY"
        RadListDataItem5.Text = "USD"
        Me.ddlCurrency.Items.Add(RadListDataItem3)
        Me.ddlCurrency.Items.Add(RadListDataItem4)
        Me.ddlCurrency.Items.Add(RadListDataItem5)
        Me.ddlCurrency.Location = New System.Drawing.Point(554, 124)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(58, 24)
        Me.ddlCurrency.TabIndex = 10
        Me.ddlCurrency.ThemeName = "Fluent"
        '
        'mebJPY
        '
        Me.mebJPY.Location = New System.Drawing.Point(555, 150)
        Me.mebJPY.Mask = "N2"
        Me.mebJPY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebJPY.Name = "mebJPY"
        Me.mebJPY.ReadOnly = True
        Me.mebJPY.Size = New System.Drawing.Size(189, 24)
        Me.mebJPY.TabIndex = 12
        Me.mebJPY.TabStop = False
        Me.mebJPY.Tag = "C"
        Me.mebJPY.Text = "0.00"
        Me.mebJPY.ThemeName = "Fluent"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(396, 124)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(105, 21)
        Me.RadLabel19.TabIndex = 212
        Me.RadLabel19.Text = "Original Amount"
        Me.RadLabel19.ThemeName = "Fluent"
        '
        'mebAmount
        '
        Me.mebAmount.Location = New System.Drawing.Point(611, 124)
        Me.mebAmount.Mask = "N2"
        Me.mebAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebAmount.Name = "mebAmount"
        Me.mebAmount.Size = New System.Drawing.Size(133, 24)
        Me.mebAmount.TabIndex = 11
        Me.mebAmount.TabStop = False
        Me.mebAmount.Tag = "C"
        Me.mebAmount.Text = "0.00"
        Me.mebAmount.ThemeName = "Fluent"
        '
        'dtpMBudgeted
        '
        Me.dtpMBudgeted.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpMBudgeted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMBudgeted.Location = New System.Drawing.Point(555, 176)
        Me.dtpMBudgeted.Name = "dtpMBudgeted"
        Me.dtpMBudgeted.Size = New System.Drawing.Size(189, 24)
        Me.dtpMBudgeted.TabIndex = 13
        Me.dtpMBudgeted.TabStop = False
        Me.dtpMBudgeted.Text = "9/11/2014"
        Me.dtpMBudgeted.ThemeName = "Fluent"
        Me.dtpMBudgeted.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(396, 176)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(108, 21)
        Me.RadLabel5.TabIndex = 210
        Me.RadLabel5.Text = "Month Budgeted"
        Me.RadLabel5.ThemeName = "Fluent"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(396, 150)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel4.TabIndex = 209
        Me.RadLabel4.Text = "Amount JPY"
        Me.RadLabel4.ThemeName = "Fluent"
        '
        'ddlStat
        '
        Me.ddlStat.DropDownAnimationEnabled = True
        Me.ddlStat.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlStat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem6.Text = "OPEN"
        RadListDataItem7.Text = "CLOSE"
        Me.ddlStat.Items.Add(RadListDataItem6)
        Me.ddlStat.Items.Add(RadListDataItem7)
        Me.ddlStat.Location = New System.Drawing.Point(880, 76)
        Me.ddlStat.Name = "ddlStat"
        Me.ddlStat.Size = New System.Drawing.Size(172, 24)
        Me.ddlStat.TabIndex = 16
        Me.ddlStat.Text = "OPEN"
        Me.ddlStat.ThemeName = "Fluent"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(750, 73)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel8.TabIndex = 409
        Me.RadLabel8.Text = "Status"
        Me.RadLabel8.ThemeName = "Fluent"
        '
        'RadLabel20
        '
        Me.RadLabel20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel20.Location = New System.Drawing.Point(837, 231)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(46, 21)
        Me.RadLabel20.TabIndex = 419
        Me.RadLabel20.Text = "Userlvl"
        Me.RadLabel20.ThemeName = "Fluent"
        Me.RadLabel20.Visible = False
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(839, 231)
        Me.lblUserlvl.Name = "lblUserlvl"
        Me.lblUserlvl.Size = New System.Drawing.Size(46, 21)
        Me.lblUserlvl.TabIndex = 420
        Me.lblUserlvl.Text = "Userlvl"
        Me.lblUserlvl.ThemeName = "Fluent"
        Me.lblUserlvl.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(794, 231)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 21)
        Me.lblUserID.TabIndex = 418
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.ThemeName = "Fluent"
        Me.lblUserID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(753, 230)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 417
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Fluent"
        Me.lblDept.Visible = False
        '
        'txtSignature
        '
        Me.txtSignature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSignature.Location = New System.Drawing.Point(555, 148)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(189, 24)
        Me.txtSignature.TabIndex = 14
        Me.txtSignature.ThemeName = "Fluent"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.Location = New System.Drawing.Point(880, 126)
        Me.txtRemarks.MaxLength = 100000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(172, 72)
        Me.txtRemarks.TabIndex = 17
        Me.txtRemarks.ThemeName = "Fluent"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(397, 148)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 416
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Fluent"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(750, 104)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(189, 21)
        Me.RadLabel11.TabIndex = 415
        Me.RadLabel11.Text = "Remarks : Reasons for Revision"
        Me.RadLabel11.ThemeName = "Fluent"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(12, 66)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(88, 21)
        Me.RadLabel9.TabIndex = 422
        Me.RadLabel9.Text = "Major Budget"
        Me.RadLabel9.ThemeName = "Fluent"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(965, 173)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 29)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.ThemeName = "Fluent"
        '
        'ddlMBudget
        '
        Me.ddlMBudget.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'ddlMBudget.NestedRadGridView
        '
        Me.ddlMBudget.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlMBudget.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlMBudget.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlMBudget.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlMBudget.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlMBudget.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlMBudget.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlMBudget.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlMBudget.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlMBudget.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ddlMBudget.EditorControl.Name = "NestedRadGridView"
        Me.ddlMBudget.EditorControl.ReadOnly = True
        Me.ddlMBudget.EditorControl.ShowGroupPanel = False
        Me.ddlMBudget.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlMBudget.EditorControl.TabIndex = 0
        Me.ddlMBudget.Location = New System.Drawing.Point(187, 70)
        Me.ddlMBudget.Name = "ddlMBudget"
        Me.ddlMBudget.Size = New System.Drawing.Size(189, 24)
        Me.ddlMBudget.TabIndex = 1
        Me.ddlMBudget.TabStop = False
        Me.ddlMBudget.ThemeName = "Fluent"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btnAdd)
        Me.RadPanel2.Controls.Add(Me.txtSignature)
        Me.RadPanel2.Controls.Add(Me.RadLabel12)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Location = New System.Drawing.Point(0, 83)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1065, 207)
        Me.RadPanel2.TabIndex = 0
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'FrmAddSubBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 586)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.ddlMBudget)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.RadLabel20)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.ddlStat)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.dtpMBudgeted)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.dtpSOU)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.mebJPY)
        Me.Controls.Add(Me.mebAmount)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.ddlUOM)
        Me.Controls.Add(Me.mebQTY)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.txtBRNum)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.ddlProcess)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "FrmAddSubBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add sub budget"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCommandBar1.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSOU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebJPY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMBudgeted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlMBudget.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlMBudget.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlMBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        Me.RadPanel2.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbPaste As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbStartImport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteSelected As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClearList As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBRNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtpSOU As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlProcess As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents mebJPY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents dtpMBudgeted As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlStat As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlMBudget As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
End Class


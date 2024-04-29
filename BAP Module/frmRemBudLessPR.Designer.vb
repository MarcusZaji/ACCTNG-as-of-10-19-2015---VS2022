<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemBudLessPR
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemBud = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.rgbPO = New Telerik.WinControls.UI.RadGridView()
        Me.rgbOpenPR = New Telerik.WinControls.UI.RadGridView()
        Me.btnCalculate = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvUPO = New Telerik.WinControls.UI.RadGridView()
        Me.txtOPR = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtUPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBudget = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        Me.ddlMajorBud = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbPO.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbOpenPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbOpenPR.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCalculate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvUPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvUPO.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlMajorBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlMajorBud.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlMajorBud.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(12, 19)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel8.TabIndex = 220
        Me.RadLabel8.Text = "Budget Reference Number"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'txtRemBud
        '
        Me.txtRemBud.BackColor = System.Drawing.Color.Transparent
        Me.txtRemBud.Location = New System.Drawing.Point(1037, 534)
        Me.txtRemBud.Mask = "N2"
        Me.txtRemBud.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtRemBud.Name = "txtRemBud"
        Me.txtRemBud.ReadOnly = True
        Me.txtRemBud.Size = New System.Drawing.Size(189, 20)
        Me.txtRemBud.TabIndex = 324
        Me.txtRemBud.TabStop = False
        Me.txtRemBud.Text = "0.00"
        Me.txtRemBud.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(823, 534)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(163, 21)
        Me.RadLabel13.TabIndex = 325
        Me.RadLabel13.Text = "Remaining Budget Less PR"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'rgbPO
        '
        Me.rgbPO.BackColor = System.Drawing.Color.White
        Me.rgbPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgbPO.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgbPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rgbPO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgbPO.Location = New System.Drawing.Point(441, 81)
        '
        '
        '
        Me.rgbPO.MasterTemplate.AllowAddNewRow = False
        Me.rgbPO.MasterTemplate.AllowCellContextMenu = False
        Me.rgbPO.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgbPO.MasterTemplate.AllowEditRow = False
        Me.rgbPO.MasterTemplate.EnableGrouping = False
        Me.rgbPO.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgbPO.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgbPO.Name = "rgbPO"
        Me.rgbPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgbPO.Size = New System.Drawing.Size(390, 332)
        Me.rgbPO.TabIndex = 327
        Me.rgbPO.ThemeName = "Windows8"
        '
        'rgbOpenPR
        '
        Me.rgbOpenPR.BackColor = System.Drawing.Color.White
        Me.rgbOpenPR.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgbOpenPR.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgbOpenPR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rgbOpenPR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgbOpenPR.Location = New System.Drawing.Point(837, 81)
        '
        '
        '
        Me.rgbOpenPR.MasterTemplate.AllowAddNewRow = False
        Me.rgbOpenPR.MasterTemplate.AllowCellContextMenu = False
        Me.rgbOpenPR.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgbOpenPR.MasterTemplate.AllowEditRow = False
        Me.rgbOpenPR.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgbOpenPR.MasterTemplate.EnableGrouping = False
        Me.rgbOpenPR.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        SortDescriptor1.PropertyName = "column1"
        Me.rgbOpenPR.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.rgbOpenPR.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgbOpenPR.Name = "rgbOpenPR"
        Me.rgbOpenPR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgbOpenPR.Size = New System.Drawing.Size(390, 332)
        Me.rgbOpenPR.TabIndex = 328
        Me.rgbOpenPR.ThemeName = "Windows8"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCalculate.Location = New System.Drawing.Point(606, 9)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 36)
        Me.btnCalculate.TabIndex = 329
        Me.btnCalculate.Text = "View Record"
        Me.btnCalculate.ThemeName = "MaterialPink"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(29, 54)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(189, 21)
        Me.RadLabel1.TabIndex = 330
        Me.RadLabel1.Text = "UPLOADED PURCHASE ORDER"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(441, 54)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(118, 21)
        Me.RadLabel2.TabIndex = 331
        Me.RadLabel2.Text = "PURCHASE ORDER"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(837, 54)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(228, 21)
        Me.RadLabel3.TabIndex = 332
        Me.RadLabel3.Text = "PURCHASE REQUSITION NOT YET PO"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'rgvUPO
        '
        Me.rgvUPO.BackColor = System.Drawing.Color.White
        Me.rgvUPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgvUPO.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgvUPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rgvUPO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgvUPO.Location = New System.Drawing.Point(29, 81)
        '
        '
        '
        Me.rgvUPO.MasterTemplate.AllowAddNewRow = False
        Me.rgvUPO.MasterTemplate.AllowCellContextMenu = False
        Me.rgvUPO.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvUPO.MasterTemplate.AllowEditRow = False
        Me.rgvUPO.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvUPO.MasterTemplate.EnableGrouping = False
        Me.rgvUPO.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvUPO.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.rgvUPO.Name = "rgvUPO"
        Me.rgvUPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgvUPO.Size = New System.Drawing.Size(390, 332)
        Me.rgvUPO.TabIndex = 328
        Me.rgvUPO.ThemeName = "Windows8"
        '
        'txtOPR
        '
        Me.txtOPR.BackColor = System.Drawing.Color.Transparent
        Me.txtOPR.Location = New System.Drawing.Point(1037, 508)
        Me.txtOPR.Mask = "N2"
        Me.txtOPR.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtOPR.Name = "txtOPR"
        Me.txtOPR.ReadOnly = True
        Me.txtOPR.Size = New System.Drawing.Size(189, 20)
        Me.txtOPR.TabIndex = 333
        Me.txtOPR.TabStop = False
        Me.txtOPR.Text = "0.00"
        Me.txtOPR.ThemeName = "Windows8"
        '
        'txtPO
        '
        Me.txtPO.BackColor = System.Drawing.Color.Transparent
        Me.txtPO.Location = New System.Drawing.Point(1037, 482)
        Me.txtPO.Mask = "N2"
        Me.txtPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtPO.Name = "txtPO"
        Me.txtPO.ReadOnly = True
        Me.txtPO.Size = New System.Drawing.Size(189, 20)
        Me.txtPO.TabIndex = 334
        Me.txtPO.TabStop = False
        Me.txtPO.Text = "0.00"
        Me.txtPO.ThemeName = "Windows8"
        '
        'txtUPO
        '
        Me.txtUPO.BackColor = System.Drawing.Color.Transparent
        Me.txtUPO.Location = New System.Drawing.Point(1037, 456)
        Me.txtUPO.Mask = "N2"
        Me.txtUPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtUPO.Name = "txtUPO"
        Me.txtUPO.ReadOnly = True
        Me.txtUPO.Size = New System.Drawing.Size(189, 20)
        Me.txtUPO.TabIndex = 335
        Me.txtUPO.TabStop = False
        Me.txtUPO.Text = "0.00"
        Me.txtUPO.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(823, 506)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(91, 21)
        Me.RadLabel4.TabIndex = 336
        Me.RadLabel4.Text = "PR Not yet PO"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(823, 479)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(92, 21)
        Me.RadLabel5.TabIndex = 337
        Me.RadLabel5.Text = "Purhase Order"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(823, 456)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(86, 21)
        Me.RadLabel6.TabIndex = 326
        Me.RadLabel6.Text = "Uploaded PO"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(823, 430)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(49, 21)
        Me.RadLabel7.TabIndex = 339
        Me.RadLabel7.Text = "Budget"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'txtBudget
        '
        Me.txtBudget.BackColor = System.Drawing.Color.Transparent
        Me.txtBudget.Location = New System.Drawing.Point(1037, 430)
        Me.txtBudget.Mask = "N2"
        Me.txtBudget.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.ReadOnly = True
        Me.txtBudget.Size = New System.Drawing.Size(189, 20)
        Me.txtBudget.TabIndex = 340
        Me.txtBudget.TabStop = False
        Me.txtBudget.Text = "0.00"
        Me.txtBudget.ThemeName = "Windows8"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(29, 524)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 36)
        Me.btnPrint.TabIndex = 341
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ThemeName = "MaterialPink"
        '
        'ddlMajorBud
        '
        Me.ddlMajorBud.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlMajorBud.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        '
        'ddlMajorBud.NestedRadGridView
        '
        Me.ddlMajorBud.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlMajorBud.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlMajorBud.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlMajorBud.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlMajorBud.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlMajorBud.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlMajorBud.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlMajorBud.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlMajorBud.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlMajorBud.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.ddlMajorBud.EditorControl.Name = "NestedRadGridView"
        Me.ddlMajorBud.EditorControl.ReadOnly = True
        Me.ddlMajorBud.EditorControl.ShowGroupPanel = False
        Me.ddlMajorBud.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlMajorBud.EditorControl.TabIndex = 0
        Me.ddlMajorBud.Location = New System.Drawing.Point(184, 9)
        Me.ddlMajorBud.Name = "ddlMajorBud"
        Me.ddlMajorBud.Size = New System.Drawing.Size(407, 36)
        Me.ddlMajorBud.TabIndex = 394
        Me.ddlMajorBud.TabStop = False
        Me.ddlMajorBud.ThemeName = "MaterialPink"
        '
        'FrmRemBudLessPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 570)
        Me.Controls.Add(Me.ddlMajorBud)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.txtBudget)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtUPO)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.txtOPR)
        Me.Controls.Add(Me.rgvUPO)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.rgbOpenPR)
        Me.Controls.Add(Me.rgbPO)
        Me.Controls.Add(Me.txtRemBud)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.RadLabel8)
        Me.Name = "FrmRemBudLessPR"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Remaining Budget Less PR"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbPO.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbOpenPR.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbOpenPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCalculate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvUPO.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvUPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlMajorBud.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlMajorBud.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlMajorBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemBud As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgbPO As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgbOpenPR As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnCalculate As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvUPO As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtOPR As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtUPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBudget As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlMajorBud As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class


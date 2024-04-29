<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnSaveImport = New Telerik.WinControls.UI.RadButton()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.rbeGetData = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.rgvImport = New Telerik.WinControls.UI.RadGridView()
        Me.txtSuppliersName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtSupplierCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.RadLabel26 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTIN = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTemrs = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtAddress = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvImport.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppliersName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(805, 470)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(210, 24)
        Me.RadProgressBar1.TabIndex = 444
        Me.RadProgressBar1.ThemeName = "Windows8"
        '
        'btnSaveImport
        '
        Me.btnSaveImport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSaveImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveImport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImport.Location = New System.Drawing.Point(679, 463)
        Me.btnSaveImport.Name = "btnSaveImport"
        Me.btnSaveImport.Size = New System.Drawing.Size(120, 31)
        Me.btnSaveImport.TabIndex = 443
        Me.btnSaveImport.Text = "Save Import"
        Me.btnSaveImport.ThemeName = "Fluent"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(928, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 29)
        Me.btnAdd.TabIndex = 442
        Me.btnAdd.Text = "Import"
        Me.btnAdd.ThemeName = "Fluent"
        '
        'RadLabel24
        '
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(679, 264)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(66, 21)
        Me.RadLabel24.TabIndex = 441
        Me.RadLabel24.Text = "Select File"
        Me.RadLabel24.ThemeName = "Windows8"
        '
        'rbeGetData
        '
        Me.rbeGetData.Location = New System.Drawing.Point(679, 291)
        Me.rbeGetData.Name = "rbeGetData"
        '
        '
        '
        Me.rbeGetData.RootElement.StretchVertically = True
        Me.rbeGetData.Size = New System.Drawing.Size(243, 26)
        Me.rbeGetData.TabIndex = 440
        Me.rbeGetData.ThemeName = "Windows8"
        '
        'rgvImport
        '
        Me.rgvImport.Location = New System.Drawing.Point(679, 325)
        '
        '
        '
        Me.rgvImport.MasterTemplate.AllowCellContextMenu = False
        Me.rgvImport.MasterTemplate.AllowColumnReorder = False
        Me.rgvImport.MasterTemplate.AllowDeleteRow = False
        Me.rgvImport.MasterTemplate.AllowEditRow = False
        Me.rgvImport.MasterTemplate.AllowRowResize = False
        Me.rgvImport.MasterTemplate.EnableGrouping = False
        Me.rgvImport.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvImport.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvImport.Name = "rgvImport"
        Me.rgvImport.Size = New System.Drawing.Size(336, 132)
        Me.rgvImport.TabIndex = 439
        Me.rgvImport.ThemeName = "Windows8"
        '
        'txtSuppliersName
        '
        Me.txtSuppliersName.Location = New System.Drawing.Point(170, 328)
        Me.txtSuppliersName.Name = "txtSuppliersName"
        Me.txtSuppliersName.Size = New System.Drawing.Size(271, 20)
        Me.txtSuppliersName.TabIndex = 438
        Me.txtSuppliersName.ThemeName = "Windows8"
        '
        'txtSupplierCode
        '
        Me.txtSupplierCode.Location = New System.Drawing.Point(170, 298)
        Me.txtSupplierCode.Name = "txtSupplierCode"
        Me.txtSupplierCode.Size = New System.Drawing.Size(271, 20)
        Me.txtSupplierCode.TabIndex = 437
        Me.txtSupplierCode.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(51, 332)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(94, 21)
        Me.RadLabel11.TabIndex = 435
        Me.RadLabel11.Text = "Supplier Name"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel25
        '
        Me.RadLabel25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel25.Location = New System.Drawing.Point(51, 296)
        Me.RadLabel25.Name = "RadLabel25"
        Me.RadLabel25.Size = New System.Drawing.Size(90, 21)
        Me.RadLabel25.TabIndex = 436
        Me.RadLabel25.Text = "Supplier Code"
        Me.RadLabel25.ThemeName = "Windows8"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(52, 267)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 434
        Me.txtID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Brown
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(170, 509)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 31)
        Me.btnUpdate.TabIndex = 433
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "Fluent"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(28, 509)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 31)
        Me.btnSave.TabIndex = 432
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Fluent"
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvList.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AllowRowResize = False
        Me.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvList.MasterTemplate.EnableFiltering = True
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(1043, 259)
        Me.rgvList.TabIndex = 431
        Me.rgvList.ThemeName = "Windows8"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'RadLabel26
        '
        Me.RadLabel26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel26.Location = New System.Drawing.Point(52, 360)
        Me.RadLabel26.Name = "RadLabel26"
        Me.RadLabel26.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel26.TabIndex = 446
        Me.RadLabel26.Text = "Currency"
        Me.RadLabel26.ThemeName = "Fluent"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PHP"
        RadListDataItem2.Text = "JPY"
        RadListDataItem3.Text = "USD"
        Me.ddlCurrency.Items.Add(RadListDataItem1)
        Me.ddlCurrency.Items.Add(RadListDataItem2)
        Me.ddlCurrency.Items.Add(RadListDataItem3)
        Me.ddlCurrency.Location = New System.Drawing.Point(170, 358)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(271, 20)
        Me.ddlCurrency.TabIndex = 445
        Me.ddlCurrency.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(52, 385)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(54, 21)
        Me.RadLabel1.TabIndex = 448
        Me.RadLabel1.Text = "Address"
        Me.RadLabel1.ThemeName = "Fluent"
        '
        'txtTIN
        '
        Me.txtTIN.Location = New System.Drawing.Point(170, 452)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(271, 20)
        Me.txtTIN.TabIndex = 450
        Me.txtTIN.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(52, 452)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(27, 21)
        Me.RadLabel2.TabIndex = 449
        Me.RadLabel2.Text = "TIN"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtTemrs
        '
        Me.txtTemrs.Location = New System.Drawing.Point(170, 478)
        Me.txtTemrs.Name = "txtTemrs"
        Me.txtTemrs.Size = New System.Drawing.Size(271, 20)
        Me.txtTemrs.TabIndex = 452
        Me.txtTemrs.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(52, 478)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel3.TabIndex = 451
        Me.RadLabel3.Text = "Terms"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(170, 386)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        '
        '
        '
        Me.txtAddress.RootElement.StretchVertically = True
        Me.txtAddress.Size = New System.Drawing.Size(271, 60)
        Me.txtAddress.TabIndex = 439
        Me.txtAddress.ThemeName = "Windows8"
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 552)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtTemrs)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel26)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.RadProgressBar1)
        Me.Controls.Add(Me.btnSaveImport)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.RadLabel24)
        Me.Controls.Add(Me.rbeGetData)
        Me.Controls.Add(Me.rgvImport)
        Me.Controls.Add(Me.txtSuppliersName)
        Me.Controls.Add(Me.txtSupplierCode)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel25)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "FrmSupplier"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmSupplier"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvImport.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppliersName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnSaveImport As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbeGetData As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents rgvImport As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtSuppliersName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtSupplierCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel25 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabel26 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTIN As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTemrs As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtAddress As Telerik.WinControls.UI.RadTextBox
End Class


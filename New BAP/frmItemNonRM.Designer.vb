<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemNonRM
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
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.txtIMDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.txtItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvImport = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.rbeGetData = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.btnSaveImport = New Telerik.WinControls.UI.RadButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIMDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvImport.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(1135, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 420
        Me.txtID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Brown
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(1041, 150)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 31)
        Me.btnUpdate.TabIndex = 419
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "Fluent"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(899, 150)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 31)
        Me.btnSave.TabIndex = 418
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Fluent"
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Left
        Me.rgvList.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AllowRowResize = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(853, 504)
        Me.rgvList.TabIndex = 412
        Me.rgvList.ThemeName = "Windows8"
        '
        'txtIMDesc
        '
        Me.txtIMDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIMDesc.Location = New System.Drawing.Point(974, 83)
        Me.txtIMDesc.Name = "txtIMDesc"
        Me.txtIMDesc.Size = New System.Drawing.Size(211, 24)
        Me.txtIMDesc.TabIndex = 424
        Me.txtIMDesc.ThemeName = "Fluent"
        '
        'txtItemCode
        '
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Location = New System.Drawing.Point(974, 53)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(211, 24)
        Me.txtItemCode.TabIndex = 423
        Me.txtItemCode.ThemeName = "Fluent"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(877, 85)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel11.TabIndex = 421
        Me.RadLabel11.Text = "Description"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel25
        '
        Me.RadLabel25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel25.Location = New System.Drawing.Point(877, 49)
        Me.RadLabel25.Name = "RadLabel25"
        Me.RadLabel25.Size = New System.Drawing.Size(68, 21)
        Me.RadLabel25.TabIndex = 422
        Me.RadLabel25.Text = "Item Code"
        Me.RadLabel25.ThemeName = "Windows8"
        '
        'rgvImport
        '
        Me.rgvImport.Location = New System.Drawing.Point(899, 326)
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
        Me.rgvImport.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvImport.Name = "rgvImport"
        Me.rgvImport.Size = New System.Drawing.Size(336, 132)
        Me.rgvImport.TabIndex = 425
        Me.rgvImport.ThemeName = "Windows8"
        '
        'RadLabel24
        '
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(899, 265)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(66, 21)
        Me.RadLabel24.TabIndex = 427
        Me.RadLabel24.Text = "Select File"
        Me.RadLabel24.ThemeName = "Fluent"
        '
        'rbeGetData
        '
        Me.rbeGetData.Location = New System.Drawing.Point(899, 292)
        Me.rbeGetData.Name = "rbeGetData"
        '
        '
        '
        Me.rbeGetData.RootElement.StretchVertically = True
        Me.rbeGetData.Size = New System.Drawing.Size(243, 26)
        Me.rbeGetData.TabIndex = 426
        Me.rbeGetData.ThemeName = "Fluent"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1148, 291)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 29)
        Me.btnAdd.TabIndex = 428
        Me.btnAdd.Text = "Import"
        Me.btnAdd.ThemeName = "Fluent"
        '
        'btnSaveImport
        '
        Me.btnSaveImport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSaveImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveImport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImport.Location = New System.Drawing.Point(899, 464)
        Me.btnSaveImport.Name = "btnSaveImport"
        Me.btnSaveImport.Size = New System.Drawing.Size(120, 31)
        Me.btnSaveImport.TabIndex = 429
        Me.btnSaveImport.Text = "Save Import"
        Me.btnSaveImport.ThemeName = "Fluent"
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(1025, 471)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(210, 24)
        Me.RadProgressBar1.TabIndex = 430
        Me.RadProgressBar1.ThemeName = "Fluent"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'FrmItemNonRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 504)
        Me.Controls.Add(Me.RadProgressBar1)
        Me.Controls.Add(Me.btnSaveImport)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.RadLabel24)
        Me.Controls.Add(Me.rbeGetData)
        Me.Controls.Add(Me.rgvImport)
        Me.Controls.Add(Me.txtIMDesc)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel25)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "FrmItemNonRM"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM NON RM"
        Me.ThemeName = "MaterialPink"
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIMDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvImport.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtIMDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel25 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvImport As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbeGetData As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSaveImport As Telerik.WinControls.UI.RadButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
End Class


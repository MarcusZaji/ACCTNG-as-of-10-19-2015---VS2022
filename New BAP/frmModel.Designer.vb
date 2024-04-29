<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModel
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtModel = New Telerik.WinControls.UI.RadTextBox()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.RadLabel26 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlActivity = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.btnSaveImport = New Telerik.WinControls.UI.RadButton()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.rbeGetData = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.rgvImport = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvImport.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(399, 12)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(50, 21)
        Me.RadLabel4.TabIndex = 413
        Me.RadLabel4.Text = "Activity"
        Me.RadLabel4.ThemeName = "Fluent"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(399, 107)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(346, 36)
        Me.txtModel.TabIndex = 412
        Me.txtModel.ThemeName = "MaterialPink"
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(372, 481)
        Me.rgvList.TabIndex = 411
        Me.rgvList.ThemeName = "Fluent"
        '
        'RadLabel26
        '
        Me.RadLabel26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel26.Location = New System.Drawing.Point(399, 83)
        Me.RadLabel26.Name = "RadLabel26"
        Me.RadLabel26.Size = New System.Drawing.Size(45, 21)
        Me.RadLabel26.TabIndex = 448
        Me.RadLabel26.Text = "Model"
        Me.RadLabel26.ThemeName = "Fluent"
        '
        'ddlActivity
        '
        Me.ddlActivity.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlActivity.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PHP"
        RadListDataItem2.Text = "JPY"
        RadListDataItem3.Text = "USD"
        Me.ddlActivity.Items.Add(RadListDataItem1)
        Me.ddlActivity.Items.Add(RadListDataItem2)
        Me.ddlActivity.Items.Add(RadListDataItem3)
        Me.ddlActivity.Location = New System.Drawing.Point(399, 38)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(346, 36)
        Me.ddlActivity.TabIndex = 447
        Me.ddlActivity.ThemeName = "MaterialPink"
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(532, 176)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 38)
        Me.btnUpdate.TabIndex = 450
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "Fluent"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(399, 176)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 38)
        Me.btnSave.TabIndex = 451
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Fluent"
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(146, 214)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(210, 24)
        Me.RadProgressBar1.TabIndex = 457
        Me.RadProgressBar1.ThemeName = "Windows8"
        '
        'btnSaveImport
        '
        Me.btnSaveImport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSaveImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveImport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImport.Location = New System.Drawing.Point(20, 207)
        Me.btnSaveImport.Name = "btnSaveImport"
        Me.btnSaveImport.Size = New System.Drawing.Size(120, 31)
        Me.btnSaveImport.TabIndex = 456
        Me.btnSaveImport.Text = "Save Import"
        Me.btnSaveImport.ThemeName = "Fluent"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(269, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 29)
        Me.btnAdd.TabIndex = 455
        Me.btnAdd.Text = "Import"
        Me.btnAdd.ThemeName = "Fluent"
        '
        'RadLabel24
        '
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(20, 8)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(50, 21)
        Me.RadLabel24.TabIndex = 454
        Me.RadLabel24.Text = "Upload"
        Me.RadLabel24.ThemeName = "Windows8"
        '
        'rbeGetData
        '
        Me.rbeGetData.Location = New System.Drawing.Point(20, 35)
        Me.rbeGetData.Name = "rbeGetData"
        '
        '
        '
        Me.rbeGetData.RootElement.StretchVertically = True
        Me.rbeGetData.Size = New System.Drawing.Size(243, 26)
        Me.rbeGetData.TabIndex = 453
        Me.rbeGetData.ThemeName = "Windows8"
        '
        'rgvImport
        '
        Me.rgvImport.Location = New System.Drawing.Point(20, 69)
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
        Me.rgvImport.TabIndex = 452
        Me.rgvImport.ThemeName = "Windows8"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RadProgressBar1)
        Me.RadPanel1.Controls.Add(Me.RadLabel24)
        Me.RadPanel1.Controls.Add(Me.btnSaveImport)
        Me.RadPanel1.Controls.Add(Me.rgvImport)
        Me.RadPanel1.Controls.Add(Me.btnAdd)
        Me.RadPanel1.Controls.Add(Me.rbeGetData)
        Me.RadPanel1.Location = New System.Drawing.Point(378, 234)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(372, 247)
        Me.RadPanel1.TabIndex = 458
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'FrmModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 481)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.RadLabel26)
        Me.Controls.Add(Me.ddlActivity)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "FrmModel"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MODEL"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvImport.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents RadLabel26 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlActivity As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents btnSaveImport As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbeGetData As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents rgvImport As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class


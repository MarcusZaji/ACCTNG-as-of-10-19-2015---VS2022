<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInactiveSupp
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInactiveSupp))
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.rgvItemSelect = New Telerik.WinControls.UI.RadGridView()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.dtpAppDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpInactiveDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ddlStat = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.txtReason = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvSupplier = New Telerik.WinControls.UI.RadGridView()
        Me.ddlVenCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlSup = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.txtApprovedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.cbInactive = New Telerik.WinControls.UI.RadCheckBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.rgvItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvItemSelect.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAppDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInactiveDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSupplier.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlVenCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApprovedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvItemSelect
        '
        Me.rgvItemSelect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rgvItemSelect.Location = New System.Drawing.Point(0, 313)
        '
        '
        '
        Me.rgvItemSelect.MasterTemplate.AllowAddNewRow = False
        Me.rgvItemSelect.MasterTemplate.AllowCellContextMenu = False
        Me.rgvItemSelect.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvItemSelect.MasterTemplate.AllowDeleteRow = False
        Me.rgvItemSelect.MasterTemplate.AllowEditRow = False
        Me.rgvItemSelect.MasterTemplate.EnableFiltering = True
        Me.rgvItemSelect.MasterTemplate.EnableGrouping = False
        Me.rgvItemSelect.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvItemSelect.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvItemSelect.Name = "rgvItemSelect"
        Me.rgvItemSelect.Size = New System.Drawing.Size(1030, 235)
        Me.rgvItemSelect.TabIndex = 281
        Me.rgvItemSelect.ThemeName = "Windows8"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(684, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 36)
        Me.btnSave.TabIndex = 390
        Me.btnSave.Text = "&Save"
        Me.btnSave.ThemeName = "MaterialPink"
        '
        'dtpAppDate
        '
        Me.dtpAppDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAppDate.Location = New System.Drawing.Point(600, 207)
        Me.dtpAppDate.Name = "dtpAppDate"
        Me.dtpAppDate.Size = New System.Drawing.Size(203, 24)
        Me.dtpAppDate.TabIndex = 391
        Me.dtpAppDate.TabStop = False
        Me.dtpAppDate.Text = "6/18/2019"
        Me.dtpAppDate.ThemeName = "Fluent"
        Me.dtpAppDate.Value = New Date(2019, 6, 18, 15, 10, 29, 0)
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(488, 209)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(92, 21)
        Me.RadLabel6.TabIndex = 392
        Me.RadLabel6.Text = "Approval Date"
        Me.RadLabel6.ThemeName = "Fluent"
        '
        'dtpInactiveDate
        '
        Me.dtpInactiveDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpInactiveDate.Enabled = False
        Me.dtpInactiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInactiveDate.Location = New System.Drawing.Point(716, 231)
        Me.dtpInactiveDate.Name = "dtpInactiveDate"
        Me.dtpInactiveDate.Size = New System.Drawing.Size(88, 24)
        Me.dtpInactiveDate.TabIndex = 395
        Me.dtpInactiveDate.TabStop = False
        Me.dtpInactiveDate.Text = "6/18/2019"
        Me.dtpInactiveDate.ThemeName = "Fluent"
        Me.dtpInactiveDate.Value = New Date(2019, 6, 18, 15, 10, 29, 0)
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(488, 234)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(110, 21)
        Me.RadLabel3.TabIndex = 396
        Me.RadLabel3.Text = "SAP Inactive Date"
        Me.RadLabel3.ThemeName = "Fluent"
        '
        'ddlStat
        '
        Me.ddlStat.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlStat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "INACTIVE"
        RadListDataItem2.Text = "INACTIVE SOON"
        Me.ddlStat.Items.Add(RadListDataItem1)
        Me.ddlStat.Items.Add(RadListDataItem2)
        Me.ddlStat.Location = New System.Drawing.Point(600, 181)
        Me.ddlStat.Name = "ddlStat"
        Me.ddlStat.Size = New System.Drawing.Size(202, 24)
        Me.ddlStat.TabIndex = 397
        Me.ddlStat.ThemeName = "Fluent"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(488, 181)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel9.TabIndex = 398
        Me.RadLabel9.Text = "Status"
        Me.RadLabel9.ThemeName = "Fluent"
        '
        'txtReason
        '
        Me.txtReason.AutoScroll = True
        Me.txtReason.Location = New System.Drawing.Point(127, 230)
        Me.txtReason.MaxLength = 100000
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(343, 50)
        Me.txtReason.TabIndex = 399
        Me.txtReason.ThemeName = "Fluent"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(12, 233)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(114, 21)
        Me.RadLabel4.TabIndex = 400
        Me.RadLabel4.Text = "Reason of Inactive"
        Me.RadLabel4.ThemeName = "Fluent"
        '
        'rgvSupplier
        '
        Me.rgvSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvSupplier.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvSupplier.MasterTemplate.AllowAddNewRow = False
        Me.rgvSupplier.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSupplier.MasterTemplate.AllowColumnReorder = False
        Me.rgvSupplier.MasterTemplate.AllowDeleteRow = False
        Me.rgvSupplier.MasterTemplate.AllowEditRow = False
        Me.rgvSupplier.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvSupplier.MasterTemplate.EnableGrouping = False
        Me.rgvSupplier.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvSupplier.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvSupplier.Name = "rgvSupplier"
        Me.rgvSupplier.Padding = New System.Windows.Forms.Padding(1)
        Me.rgvSupplier.Size = New System.Drawing.Size(1030, 174)
        Me.rgvSupplier.TabIndex = 401
        Me.rgvSupplier.ThemeName = "Windows8"
        '
        'ddlVenCode
        '
        Me.ddlVenCode.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlVenCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlVenCode.Enabled = False
        Me.ddlVenCode.Location = New System.Drawing.Point(127, 204)
        Me.ddlVenCode.Name = "ddlVenCode"
        Me.ddlVenCode.Size = New System.Drawing.Size(181, 20)
        Me.ddlVenCode.TabIndex = 405
        Me.ddlVenCode.ThemeName = "Windows8"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(11, 206)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(85, 21)
        Me.RadLabel8.TabIndex = 404
        Me.RadLabel8.Text = "Vendor Code"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'ddlSup
        '
        Me.ddlSup.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlSup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlSup.Location = New System.Drawing.Point(127, 180)
        Me.ddlSup.Name = "ddlSup"
        Me.ddlSup.ReadOnly = True
        Me.ddlSup.Size = New System.Drawing.Size(343, 20)
        Me.ddlSup.TabIndex = 402
        Me.ddlSup.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(11, 180)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(55, 21)
        Me.RadLabel15.TabIndex = 403
        Me.RadLabel15.Text = "Supplier"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApprovedBy.Location = New System.Drawing.Point(127, 286)
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.Size = New System.Drawing.Size(343, 20)
        Me.txtApprovedBy.TabIndex = 407
        Me.txtApprovedBy.ThemeName = "Windows8"
        '
        'RadLabel25
        '
        Me.RadLabel25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel25.Location = New System.Drawing.Point(11, 286)
        Me.RadLabel25.Name = "RadLabel25"
        Me.RadLabel25.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel25.TabIndex = 406
        Me.RadLabel25.Text = "Approved By"
        Me.RadLabel25.ThemeName = "Windows8"
        '
        'cbInactive
        '
        Me.cbInactive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbInactive.Location = New System.Drawing.Point(600, 234)
        Me.cbInactive.Name = "cbInactive"
        Me.cbInactive.Size = New System.Drawing.Size(116, 18)
        Me.cbInactive.TabIndex = 408
        Me.cbInactive.Text = "Uncheck to enable"
        Me.cbInactive.ThemeName = "Windows8"
        Me.cbInactive.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Crimson
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(684, 265)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 36)
        Me.btnUpdate.TabIndex = 409
        Me.btnUpdate.Text = " Update"
        Me.btnUpdate.ThemeName = "MaterialPink"
        Me.btnUpdate.Visible = False
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(966, 179)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(52, 20)
        Me.txtID.TabIndex = 410
        Me.txtID.ThemeName = "Windows8"
        Me.txtID.Visible = False
        '
        'FrmInactiveSupp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 548)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbInactive)
        Me.Controls.Add(Me.txtApprovedBy)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel25)
        Me.Controls.Add(Me.dtpAppDate)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.ddlVenCode)
        Me.Controls.Add(Me.dtpInactiveDate)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.ddlSup)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.rgvSupplier)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.ddlStat)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rgvItemSelect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInactiveSupp"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " INACTIVE SUPPLIER"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvItemSelect.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAppDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInactiveDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSupplier.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlVenCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApprovedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbInactive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvItemSelect As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtpAppDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpInactiveDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ddlStat As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents txtReason As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvSupplier As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ddlVenCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlSup As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtApprovedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel25 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents cbInactive As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
End Class


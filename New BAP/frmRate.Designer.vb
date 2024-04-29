<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRate
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel26 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel30 = New Telerik.WinControls.UI.RadLabel()
        Me.mebRate = New Telerik.WinControls.UI.RadSpinEditor()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(372, 510)
        Me.rgvList.TabIndex = 158
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabel26
        '
        Me.RadLabel26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel26.Location = New System.Drawing.Point(393, 125)
        Me.RadLabel26.Name = "RadLabel26"
        Me.RadLabel26.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel26.TabIndex = 404
        Me.RadLabel26.Text = "Currency"
        Me.RadLabel26.ThemeName = "Fluent"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem4.Text = "PHP"
        RadListDataItem5.Text = "JPY"
        RadListDataItem6.Text = "USD"
        Me.ddlCurrency.Items.Add(RadListDataItem4)
        Me.ddlCurrency.Items.Add(RadListDataItem5)
        Me.ddlCurrency.Items.Add(RadListDataItem6)
        Me.ddlCurrency.Location = New System.Drawing.Point(395, 152)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(189, 24)
        Me.ddlCurrency.TabIndex = 403
        Me.ddlCurrency.ThemeName = "Fluent"
        '
        'RadLabel30
        '
        Me.RadLabel30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel30.Location = New System.Drawing.Point(393, 64)
        Me.RadLabel30.Name = "RadLabel30"
        Me.RadLabel30.Size = New System.Drawing.Size(33, 21)
        Me.RadLabel30.TabIndex = 405
        Me.RadLabel30.Text = "Rate"
        Me.RadLabel30.ThemeName = "Fluent"
        '
        'mebRate
        '
        Me.mebRate.DecimalPlaces = 4
        Me.mebRate.Location = New System.Drawing.Point(393, 89)
        Me.mebRate.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mebRate.Name = "mebRate"
        Me.mebRate.Size = New System.Drawing.Size(189, 24)
        Me.mebRate.TabIndex = 406
        Me.mebRate.ThemeName = "Fluent"
        Me.mebRate.ThousandsSeparator = True
        '
        'dtpDate
        '
        Me.dtpDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(393, 34)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(189, 24)
        Me.dtpDate.TabIndex = 407
        Me.dtpDate.TabStop = False
        Me.dtpDate.ThemeName = "Fluent"
        Me.dtpDate.Value = New Date(CType(0, Long))
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(395, 7)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(35, 21)
        Me.RadLabel4.TabIndex = 408
        Me.RadLabel4.Text = "Date"
        Me.RadLabel4.ThemeName = "Fluent"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(395, 203)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 31)
        Me.btnSave.TabIndex = 409
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Fluent"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Brown
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(537, 203)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 31)
        Me.btnUpdate.TabIndex = 410
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "Fluent"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(629, 34)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 411
        Me.txtID.Visible = False
        '
        'FrmRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 510)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel30)
        Me.Controls.Add(Me.mebRate)
        Me.Controls.Add(Me.RadLabel26)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "FrmRate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRate"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel26 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel30 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebRate As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
End Class


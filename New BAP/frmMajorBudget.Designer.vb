<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMajorBudget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMajorBudget))
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.rgvMBudget = New Telerik.WinControls.UI.RadGridView()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.rgvSBudget = New Telerik.WinControls.UI.RadGridView()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.txtAddSubBudget = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbHistory = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbMajorBudgetHistory = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnExportSub = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.btnView = New Telerik.WinControls.UI.RadButton()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.rgvMBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvMBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        Me.ToolWindow2.SuspendLayout()
        CType(Me.rgvSBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCommandBar1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow1
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip2)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 58)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.MainDocumentContainerVisible = False
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(0)
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.Size = New System.Drawing.Size(1174, 564)
        Me.RadDock1.SplitterWidth = 8
        Me.RadDock1.TabIndex = 22
        Me.RadDock1.TabStop = False
        Me.RadDock1.ThemeName = "Fluent"
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.rgvMBudget)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(4, 34)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(1166, 255)
        Me.ToolWindow1.Text = "Major Budget"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'rgvMBudget
        '
        Me.rgvMBudget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvMBudget.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvMBudget.MasterTemplate.AllowCellContextMenu = False
        Me.rgvMBudget.MasterTemplate.AllowColumnReorder = False
        Me.rgvMBudget.MasterTemplate.AllowDeleteRow = False
        Me.rgvMBudget.MasterTemplate.AllowEditRow = False
        Me.rgvMBudget.MasterTemplate.EnableGrouping = False
        Me.rgvMBudget.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvMBudget.Name = "rgvMBudget"
        Me.rgvMBudget.Size = New System.Drawing.Size(1166, 255)
        Me.rgvMBudget.TabIndex = 22
        Me.rgvMBudget.ThemeName = "Fluent"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Collapsed = True
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SplitterWidth = 8
        Me.DocumentContainer1.ThemeName = "Fluent"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(1174, 293)
        Me.ToolTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.02737226!)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 15)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        Me.ToolTabStrip1.ThemeName = "Fluent"
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(0, 301)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(1174, 263)
        Me.ToolTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.02737226!)
        Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -15)
        Me.ToolTabStrip2.TabIndex = 2
        Me.ToolTabStrip2.TabStop = False
        Me.ToolTabStrip2.ThemeName = "Fluent"
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Caption = Nothing
        Me.ToolWindow2.Controls.Add(Me.rgvSBudget)
        Me.ToolWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow2.Location = New System.Drawing.Point(4, 34)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow2.Size = New System.Drawing.Size(1166, 225)
        Me.ToolWindow2.Text = "Sub Budget"
        Me.ToolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'rgvSBudget
        '
        Me.rgvSBudget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvSBudget.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvSBudget.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSBudget.MasterTemplate.AllowColumnReorder = False
        Me.rgvSBudget.MasterTemplate.AllowDeleteRow = False
        Me.rgvSBudget.MasterTemplate.AllowEditRow = False
        Me.rgvSBudget.MasterTemplate.EnableGrouping = False
        Me.rgvSBudget.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvSBudget.Name = "rgvSBudget"
        Me.rgvSBudget.Size = New System.Drawing.Size(1166, 225)
        Me.rgvSBudget.TabIndex = 23
        Me.rgvSBudget.ThemeName = "Fluent"
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbEdit, Me.txtAddSubBudget, Me.cbbDelete, Me.cbImportData, Me.cbExport, Me.cbHistory, Me.cbMajorBudgetHistory, Me.btnExportSub})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbRefresh.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbRefresh.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbRefresh.UseCompatibleTextRendering = False
        '
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAdd.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAdd.DisplayName = "Add Record"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Enabled = False
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add Record"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAdd.UseCompatibleTextRendering = False
        '
        'cbbEdit
        '
        Me.cbbEdit.AutoSize = False
        Me.cbbEdit.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbEdit.DisplayName = "Edit Record"
        Me.cbbEdit.DrawText = True
        Me.cbbEdit.Enabled = False
        Me.cbbEdit.Image = CType(resources.GetObject("cbbEdit.Image"), System.Drawing.Image)
        Me.cbbEdit.Name = "cbbEdit"
        Me.cbbEdit.Text = "Edit Record"
        Me.cbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbEdit.UseCompatibleTextRendering = False
        '
        'txtAddSubBudget
        '
        Me.txtAddSubBudget.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.txtAddSubBudget.DisplayName = "Add Sub Budget"
        Me.txtAddSubBudget.DrawText = True
        Me.txtAddSubBudget.Enabled = False
        Me.txtAddSubBudget.Image = CType(resources.GetObject("txtAddSubBudget.Image"), System.Drawing.Image)
        Me.txtAddSubBudget.Name = "txtAddSubBudget"
        Me.txtAddSubBudget.Text = "Add Sub Budget"
        Me.txtAddSubBudget.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.txtAddSubBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.txtAddSubBudget.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.txtAddSubBudget.UseCompatibleTextRendering = False
        '
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = False
        Me.cbbDelete.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbDelete.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDelete.DisplayName = "Delete Record"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Enabled = False
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete Record"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDelete.UseCompatibleTextRendering = False
        '
        'cbImportData
        '
        Me.cbImportData.AutoSize = False
        Me.cbImportData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbImportData.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbImportData.DisplayName = "Import Data"
        Me.cbImportData.DrawText = True
        Me.cbImportData.Enabled = False
        Me.cbImportData.Image = CType(resources.GetObject("cbImportData.Image"), System.Drawing.Image)
        Me.cbImportData.Name = "cbImportData"
        Me.cbImportData.Text = "Import Data"
        Me.cbImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbImportData.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbImportData.UseCompatibleTextRendering = False
        '
        'cbExport
        '
        Me.cbExport.AutoSize = False
        Me.cbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbExport.DisplayName = "Export Data"
        Me.cbExport.DrawText = True
        Me.cbExport.Image = CType(resources.GetObject("cbExport.Image"), System.Drawing.Image)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Text = "Export Major"
        Me.cbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbExport.UseCompatibleTextRendering = False
        '
        'cbHistory
        '
        Me.cbHistory.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbHistory.DisplayName = "History"
        Me.cbHistory.DrawText = True
        Me.cbHistory.Image = CType(resources.GetObject("cbHistory.Image"), System.Drawing.Image)
        Me.cbHistory.Name = "cbHistory"
        Me.cbHistory.Text = "View Sub Budget History"
        Me.cbHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbHistory.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbHistory.UseCompatibleTextRendering = False
        '
        'cbMajorBudgetHistory
        '
        Me.cbMajorBudgetHistory.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbMajorBudgetHistory.DisplayName = "CommandBarButton1"
        Me.cbMajorBudgetHistory.DrawText = True
        Me.cbMajorBudgetHistory.Image = CType(resources.GetObject("cbMajorBudgetHistory.Image"), System.Drawing.Image)
        Me.cbMajorBudgetHistory.Name = "cbMajorBudgetHistory"
        Me.cbMajorBudgetHistory.Text = "View Major Bud History"
        Me.cbMajorBudgetHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbMajorBudgetHistory.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbMajorBudgetHistory.UseCompatibleTextRendering = False
        '
        'btnExportSub
        '
        Me.btnExportSub.DisplayName = "CommandBarButton1"
        Me.btnExportSub.DrawText = True
        Me.btnExportSub.Image = CType(resources.GetObject("btnExportSub.Image"), System.Drawing.Image)
        Me.btnExportSub.Name = "btnExportSub"
        Me.btnExportSub.Text = "Export Sub"
        Me.btnExportSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RadProgressBar1)
        Me.RadPanel1.Controls.Add(Me.btnView)
        Me.RadPanel1.Controls.Add(Me.dtpDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel13)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadPanel1.Location = New System.Drawing.Point(913, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(261, 58)
        Me.RadPanel1.TabIndex = 23
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(7, 3)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(249, 16)
        Me.RadProgressBar1.TabIndex = 137
        Me.RadProgressBar1.ThemeName = "Fluent"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.SeaGreen
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnView.Location = New System.Drawing.Point(153, 22)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(73, 28)
        Me.btnView.TabIndex = 136
        Me.btnView.Text = "View"
        Me.btnView.ThemeName = "Fluent"
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(59, 24)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(89, 24)
        Me.dtpDate.TabIndex = 135
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "9/11/2014"
        Me.dtpDate.ThemeName = "Fluent"
        Me.dtpDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel13
        '
        Me.RadLabel13.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(8, 25)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(33, 21)
        Me.RadLabel13.TabIndex = 134
        Me.RadLabel13.Text = "Year"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Controls.Add(Me.RadPanel1)
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1174, 58)
        Me.RadCommandBar1.TabIndex = 21
        Me.RadCommandBar1.ThemeName = "Fluent"
        '
        'FrmMajorBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 622)
        Me.Controls.Add(Me.RadDock1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "FrmMajorBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Major Budget"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.rgvMBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvMBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        Me.ToolWindow2.ResumeLayout(False)
        CType(Me.rgvSBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCommandBar1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents rgvMBudget As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvSBudget As Telerik.WinControls.UI.RadGridView
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents txtAddSubBudget As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbImportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbHistory As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbMajorBudgetHistory As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnView As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents btnExportSub As Telerik.WinControls.UI.CommandBarButton
End Class


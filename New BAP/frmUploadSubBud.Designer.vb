<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUploadSubBud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUploadSubBud))
        Me.MaterialTealTheme1 = New Telerik.WinControls.Themes.MaterialTealTheme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.cbExport = New Telerik.WinControls.UI.RadCommandBar()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbPaste = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbExport2 = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cbExport.SuspendLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvList.Location = New System.Drawing.Point(0, 54)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableFiltering = True
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(835, 350)
        Me.rgvList.TabIndex = 24
        Me.rgvList.ThemeName = "Fluent"
        '
        'cbExport
        '
        Me.cbExport.Controls.Add(Me.RadProgressBar1)
        Me.cbExport.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbExport.Location = New System.Drawing.Point(0, 0)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.cbExport.Size = New System.Drawing.Size(835, 54)
        Me.cbExport.TabIndex = 25
        Me.cbExport.ThemeName = "Fluent"
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadProgressBar1.Location = New System.Drawing.Point(587, 0)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(248, 54)
        Me.RadProgressBar1.TabIndex = 138
        Me.RadProgressBar1.ThemeName = "Fluent"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbPaste, Me.cbExport2, Me.CommandBarSeparator1, Me.cbImport})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cbPaste
        '
        Me.cbPaste.DisplayName = "IMPORT"
        Me.cbPaste.DrawText = True
        Me.cbPaste.Image = CType(resources.GetObject("cbPaste.Image"), System.Drawing.Image)
        Me.cbPaste.Name = "cbPaste"
        Me.cbPaste.Text = "PASTE DATA"
        Me.cbPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbExport2
        '
        Me.cbExport2.DisplayName = "CommandBarButton1"
        Me.cbExport2.DrawText = True
        Me.cbExport2.Image = CType(resources.GetObject("cbExport2.Image"), System.Drawing.Image)
        Me.cbExport2.Name = "cbExport2"
        Me.cbExport2.Text = "EXPORT"
        Me.cbExport2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbImport
        '
        Me.cbImport.DisplayName = "CommandBarButton1"
        Me.cbImport.DrawImage = True
        Me.cbImport.DrawText = True
        Me.cbImport.Image = CType(resources.GetObject("cbImport.Image"), System.Drawing.Image)
        Me.cbImport.Name = "cbImport"
        Me.cbImport.Text = "IMPORT"
        Me.cbImport.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.cbImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'FrmUploadSubBud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 404)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.cbExport)
        Me.Name = "FrmUploadSubBud"
        Me.Text = "UPLOAD SUB BUDGET"
        Me.ThemeName = "MaterialTeal"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cbExport.ResumeLayout(False)
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTealTheme1 As Telerik.WinControls.Themes.MaterialTealTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents cbExport As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbPaste As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents cbExport2 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbImport As Telerik.WinControls.UI.CommandBarButton
End Class


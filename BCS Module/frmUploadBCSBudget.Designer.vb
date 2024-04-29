<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUploadBCSBudget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUploadBCSBudget))
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.btnPasteData = New Telerik.WinControls.UI.RadButton()
        Me.btnImport = New Telerik.WinControls.UI.RadButton()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        Me.ToolWindow2.SuspendLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPasteData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvList.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableFiltering = True
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(1140, 609)
        Me.rgvList.TabIndex = 22
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow1
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip2)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.MainDocumentContainerVisible = False
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.Size = New System.Drawing.Size(1152, 767)
        Me.RadDock1.TabIndex = 25
        Me.RadDock1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.rgvList)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(1140, 609)
        Me.ToolWindow1.Text = "GRID"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(1142, 633)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 198)
        Me.ToolTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.3401048!)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 198)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Collapsed = True
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 108)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 108)
        Me.DocumentContainer1.TabIndex = 2
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(5, 642)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(1142, 120)
        Me.ToolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 91)
        Me.ToolTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.3401048!)
        Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -306)
        Me.ToolTabStrip2.TabIndex = 2
        Me.ToolTabStrip2.TabStop = False
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Caption = Nothing
        Me.ToolWindow2.Controls.Add(Me.RadProgressBar1)
        Me.ToolWindow2.Controls.Add(Me.btnPasteData)
        Me.ToolWindow2.Controls.Add(Me.btnImport)
        Me.ToolWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow2.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow2.Size = New System.Drawing.Size(1140, 96)
        Me.ToolWindow2.Text = "BUTTONS"
        Me.ToolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(280, 64)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(859, 24)
        Me.RadProgressBar1.TabIndex = 25
        Me.RadProgressBar1.ThemeName = "VisualStudio2012Light"
        '
        'btnPasteData
        '
        Me.btnPasteData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasteData.Image = CType(resources.GetObject("btnPasteData.Image"), System.Drawing.Image)
        Me.btnPasteData.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPasteData.Location = New System.Drawing.Point(8, 8)
        Me.btnPasteData.Name = "btnPasteData"
        Me.btnPasteData.Size = New System.Drawing.Size(123, 80)
        Me.btnPasteData.TabIndex = 23
        Me.btnPasteData.Text = "PASTE DATA"
        Me.btnPasteData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPasteData.ThemeName = "TelerikMetroBlue"
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImport.Location = New System.Drawing.Point(137, 8)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(123, 80)
        Me.btnImport.TabIndex = 24
        Me.btnImport.Text = "IMPORT TO DB"
        Me.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnImport.ThemeName = "TelerikMetroBlue"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'FrmUploadBCSBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 767)
        Me.Controls.Add(Me.RadDock1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUploadBCSBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPLOAD BUDGET (BCS)"
        Me.ThemeName = "Windows8"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        Me.ToolWindow2.ResumeLayout(False)
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPasteData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnImport As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnPasteData As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
End Class


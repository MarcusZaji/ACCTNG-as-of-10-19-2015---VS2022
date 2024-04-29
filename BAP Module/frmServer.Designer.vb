<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServer))
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.btnSavE = New Telerik.WinControls.UI.RadButton()
        Me.btnRef = New Telerik.WinControls.UI.RadButton()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.pbOlrayt = New Telerik.WinControls.UI.RadProgressBar()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSavE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOlrayt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.rgvList.Size = New System.Drawing.Size(480, 232)
        Me.rgvList.TabIndex = 158
        Me.rgvList.ThemeName = "Windows8"
        '
        'btnSavE
        '
        Me.btnSavE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavE.Location = New System.Drawing.Point(7, 238)
        Me.btnSavE.Name = "btnSavE"
        Me.btnSavE.Size = New System.Drawing.Size(120, 28)
        Me.btnSavE.TabIndex = 159
        Me.btnSavE.Text = "&Save"
        Me.btnSavE.ThemeName = "Windows8"
        '
        'btnRef
        '
        Me.btnRef.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRef.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRef.Location = New System.Drawing.Point(142, 238)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(120, 28)
        Me.btnRef.TabIndex = 160
        Me.btnRef.Text = "&Refresh"
        Me.btnRef.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'pbOlrayt
        '
        Me.pbOlrayt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pbOlrayt.ForeColor = System.Drawing.Color.White
        Me.pbOlrayt.Location = New System.Drawing.Point(272, 238)
        Me.pbOlrayt.Name = "pbOlrayt"
        Me.pbOlrayt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbOlrayt.SeparatorWidth = 2
        Me.pbOlrayt.Size = New System.Drawing.Size(205, 28)
        Me.pbOlrayt.Step = 1
        Me.pbOlrayt.TabIndex = 341
        Me.pbOlrayt.Text = "Loading..."
        Me.pbOlrayt.ThemeName = "TelerikMetroBlue"
        Me.pbOlrayt.Value2 = 1
        Me.pbOlrayt.Visible = False
        '
        'FrmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 270)
        Me.Controls.Add(Me.pbOlrayt)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.btnSavE)
        Me.Controls.Add(Me.rgvList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmServer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "SERVER"
        Me.ThemeName = "Windows8"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSavE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOlrayt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnSavE As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRef As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbOlrayt As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
End Class


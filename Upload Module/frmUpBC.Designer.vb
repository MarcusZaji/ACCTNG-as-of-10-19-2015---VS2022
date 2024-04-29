<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpBC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpBC))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.ssRmDetails = New Telerik.WinControls.UI.RadStatusStrip()
        Me.pbOlrayt = New System.Windows.Forms.ProgressBar()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leRecordCount = New Telerik.WinControls.UI.RadLabelElement()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.btnUpload = New Telerik.WinControls.UI.RadButton()
        Me.btnViewData = New Telerik.WinControls.UI.RadButton()
        Me.rbeGetData = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.ssRmDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssRmDetails.SuspendLayout()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssRmDetails
        '
        Me.ssRmDetails.Controls.Add(Me.pbOlrayt)
        Me.ssRmDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssRmDetails.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leRecordCount})
        Me.ssRmDetails.Location = New System.Drawing.Point(0, 355)
        Me.ssRmDetails.Name = "ssRmDetails"
        Me.ssRmDetails.Size = New System.Drawing.Size(776, 27)
        Me.ssRmDetails.TabIndex = 230
        Me.ssRmDetails.Text = "RadStatusStrip1"
        Me.ssRmDetails.ThemeName = "Windows8"
        '
        'pbOlrayt
        '
        Me.pbOlrayt.Location = New System.Drawing.Point(282, 3)
        Me.pbOlrayt.Name = "pbOlrayt"
        Me.pbOlrayt.Size = New System.Drawing.Size(494, 18)
        Me.pbOlrayt.Step = 1
        Me.pbOlrayt.TabIndex = 345
        Me.pbOlrayt.UseWaitCursor = True
        Me.pbOlrayt.Visible = False
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Records Found"
        Me.RadLabelElement1.AccessibleName = "Records Found"
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.ssRmDetails.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Data Count"
        Me.RadLabelElement1.TextWrap = True
        '
        'leRecordCount
        '
        Me.leRecordCount.AccessibleDescription = "0"
        Me.leRecordCount.AccessibleName = "0"
        Me.leRecordCount.Name = "leRecordCount"
        Me.ssRmDetails.SetSpring(Me.leRecordCount, False)
        Me.leRecordCount.Text = "0"
        Me.leRecordCount.TextWrap = True
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(3, 296)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 229
        Me.lblBack.ThemeName = "Windows8"
        '
        'rgvList
        '
        Me.rgvList.AutoSizeRows = True
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Right
        Me.rgvList.Location = New System.Drawing.Point(282, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(494, 355)
        Me.rgvList.TabIndex = 231
        Me.rgvList.Text = "s"
        Me.rgvList.ThemeName = "Windows8"
        '
        'btnUpload
        '
        Me.btnUpload.Enabled = False
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(127, 145)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(149, 54)
        Me.btnUpload.TabIndex = 236
        Me.btnUpload.Text = "Upload Data"
        Me.btnUpload.ThemeName = "Windows8"
        '
        'btnViewData
        '
        Me.btnViewData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewData.Location = New System.Drawing.Point(127, 85)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(149, 54)
        Me.btnViewData.TabIndex = 235
        Me.btnViewData.Text = "View Data"
        Me.btnViewData.ThemeName = "Windows8"
        '
        'rbeGetData
        '
        Me.rbeGetData.Location = New System.Drawing.Point(12, 45)
        Me.rbeGetData.Name = "rbeGetData"
        '
        '
        '
        Me.rbeGetData.RootElement.StretchVertically = True
        Me.rbeGetData.Size = New System.Drawing.Size(264, 34)
        Me.rbeGetData.TabIndex = 234
        Me.rbeGetData.Text = "RadBrowseEditor1"
        Me.rbeGetData.ThemeName = "Windows8"
        '
        'RadLabel24
        '
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(12, 18)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(66, 21)
        Me.RadLabel24.TabIndex = 402
        Me.RadLabel24.Text = "Select File"
        Me.RadLabel24.ThemeName = "Windows8"
        '
        'frmUpBC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadLabel24)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnViewData)
        Me.Controls.Add(Me.rbeGetData)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.ssRmDetails)
        Me.Controls.Add(Me.lblBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUpBC"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Upload Consolidated Budget"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.ssRmDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssRmDetails.ResumeLayout(False)
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnViewData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents ssRmDetails As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leRecordCount As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnUpload As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnViewData As Telerik.WinControls.UI.RadButton
    Friend WithEvents rbeGetData As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbOlrayt As System.Windows.Forms.ProgressBar
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBOI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBOI))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.txtDept = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBRNum = New Telerik.WinControls.UI.RadTextBox()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mebTOO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.bwLoadPOUploaded = New System.ComponentModel.BackgroundWorker()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.rgvPOUploaded = New Telerik.WinControls.UI.RadGridView()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.btnExportPO = New Telerik.WinControls.UI.RadButton()
        Me.btnExportUPO = New Telerik.WinControls.UI.RadButton()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebTOO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOUploaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOUploaded.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportUPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDept
        '
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Location = New System.Drawing.Point(217, 48)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(189, 20)
        Me.txtDept.TabIndex = 249
        Me.txtDept.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(37, 22)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel6.TabIndex = 248
        Me.RadLabel6.Text = "Budget Reference Number"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(37, 48)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 247
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtBRNum
        '
        Me.txtBRNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBRNum.Location = New System.Drawing.Point(217, 18)
        Me.txtBRNum.Name = "txtBRNum"
        Me.txtBRNum.ReadOnly = True
        Me.txtBRNum.Size = New System.Drawing.Size(189, 20)
        Me.txtBRNum.TabIndex = 246
        Me.txtBRNum.ThemeName = "Windows8"
        '
        'rgvList
        '
        Me.rgvList.AutoSizeRows = True
        Me.rgvList.Location = New System.Drawing.Point(16, 76)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(735, 283)
        Me.rgvList.TabIndex = 244
        Me.rgvList.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(421, 49)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(135, 21)
        Me.RadLabel2.TabIndex = 251
        Me.RadLabel2.Text = "On-Going Order (JPY)"
        Me.RadLabel2.ThemeName = "Windows8"
        Me.RadLabel2.Visible = False
        '
        'mebTOO
        '
        Me.mebTOO.Location = New System.Drawing.Point(562, 49)
        Me.mebTOO.Mask = "N2"
        Me.mebTOO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebTOO.Name = "mebTOO"
        Me.mebTOO.ReadOnly = True
        Me.mebTOO.Size = New System.Drawing.Size(189, 20)
        Me.mebTOO.TabIndex = 250
        Me.mebTOO.TabStop = False
        Me.mebTOO.Tag = "C"
        Me.mebTOO.Text = "0.00"
        Me.mebTOO.ThemeName = "Windows8"
        Me.mebTOO.Visible = False
        '
        'bwLoadPOUploaded
        '
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(2, 591)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 252
        Me.lblBack.ThemeName = "Windows8"
        '
        'rgvPOUploaded
        '
        Me.rgvPOUploaded.AutoSizeRows = True
        Me.rgvPOUploaded.Location = New System.Drawing.Point(16, 365)
        '
        '
        '
        Me.rgvPOUploaded.MasterTemplate.AllowAddNewRow = False
        Me.rgvPOUploaded.MasterTemplate.AllowCellContextMenu = False
        Me.rgvPOUploaded.MasterTemplate.AllowEditRow = False
        Me.rgvPOUploaded.MasterTemplate.EnableGrouping = False
        Me.rgvPOUploaded.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvPOUploaded.Name = "rgvPOUploaded"
        Me.rgvPOUploaded.Size = New System.Drawing.Size(735, 220)
        Me.rgvPOUploaded.TabIndex = 253
        Me.rgvPOUploaded.ThemeName = "Windows8"
        '
        'btnExportPO
        '
        Me.btnExportPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportPO.Image = CType(resources.GetObject("btnExportPO.Image"), System.Drawing.Image)
        Me.btnExportPO.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExportPO.Location = New System.Drawing.Point(486, 600)
        Me.btnExportPO.Name = "btnExportPO"
        Me.btnExportPO.Size = New System.Drawing.Size(123, 80)
        Me.btnExportPO.TabIndex = 254
        Me.btnExportPO.Text = "EXPORT PO"
        Me.btnExportPO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportPO.ThemeName = "VisualStudio2012Dark"
        '
        'btnExportUPO
        '
        Me.btnExportUPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportUPO.Image = CType(resources.GetObject("btnExportUPO.Image"), System.Drawing.Image)
        Me.btnExportUPO.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExportUPO.Location = New System.Drawing.Point(625, 600)
        Me.btnExportUPO.Name = "btnExportUPO"
        Me.btnExportUPO.Size = New System.Drawing.Size(123, 80)
        Me.btnExportUPO.TabIndex = 255
        Me.btnExportUPO.Text = "EXPORT UPO"
        Me.btnExportUPO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportUPO.ThemeName = "VisualStudio2012Dark"
        '
        'frmBOI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExportUPO)
        Me.Controls.Add(Me.btnExportPO)
        Me.Controls.Add(Me.rgvPOUploaded)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtBRNum)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.mebTOO)
        Me.Controls.Add(Me.lblBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBOI"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Ordered Items"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebTOO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOUploaded.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOUploaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportUPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents txtDept As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBRNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebTOO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents bwLoadPOUploaded As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvPOUploaded As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents btnExportPO As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExportUPO As Telerik.WinControls.UI.RadButton
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBAI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBAI))
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
        Me.bwLoadItem = New System.ComponentModel.BackgroundWorker()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.rgvListItem = New Telerik.WinControls.UI.MasterGridViewTemplate()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebTOO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvListItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDept
        '
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Location = New System.Drawing.Point(217, 44)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(189, 20)
        Me.txtDept.TabIndex = 250
        Me.txtDept.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(37, 18)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel6.TabIndex = 249
        Me.RadLabel6.Text = "Budget Reference Number"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(37, 44)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 248
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
        Me.txtBRNum.TabIndex = 247
        Me.txtBRNum.ThemeName = "Windows8"
        '
        'rgvList
        '
        Me.rgvList.AutoSizeRows = True
        Me.rgvList.Location = New System.Drawing.Point(12, 72)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(735, 512)
        Me.rgvList.TabIndex = 245
        Me.rgvList.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(421, 45)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(135, 21)
        Me.RadLabel2.TabIndex = 252
        Me.RadLabel2.Text = "On-Going Order (JPY)"
        Me.RadLabel2.ThemeName = "Windows8"
        Me.RadLabel2.Visible = False
        '
        'mebTOO
        '
        Me.mebTOO.Location = New System.Drawing.Point(562, 45)
        Me.mebTOO.Mask = "N2"
        Me.mebTOO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebTOO.Name = "mebTOO"
        Me.mebTOO.ReadOnly = True
        Me.mebTOO.Size = New System.Drawing.Size(185, 20)
        Me.mebTOO.TabIndex = 251
        Me.mebTOO.TabStop = False
        Me.mebTOO.Tag = "C"
        Me.mebTOO.Text = "0.00"
        Me.mebTOO.ThemeName = "Windows8"
        Me.mebTOO.Visible = False
        '
        'bwLoadItem
        '
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(1, 590)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 253
        Me.lblBack.ThemeName = "Windows8"
        '
        'rgvListItem
        '
        Me.rgvListItem.AllowAddNewRow = False
        Me.rgvListItem.AllowCellContextMenu = False
        Me.rgvListItem.AllowEditRow = False
        Me.rgvListItem.EnableGrouping = False
        Me.rgvListItem.ViewDefinition = TableViewDefinition2
        '
        'frmBAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(759, 683)
        Me.ControlBox = False
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
        Me.Name = "frmBAI"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Delivered Items"
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
        CType(Me.rgvListItem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bwLoadItem As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvListItem As Telerik.WinControls.UI.MasterGridViewTemplate
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


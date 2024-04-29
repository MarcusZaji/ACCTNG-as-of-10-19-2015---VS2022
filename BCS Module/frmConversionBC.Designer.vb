<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversionBC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversionBC))
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.btnGen = New Telerik.WinControls.UI.RadButton()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.mebUSD_JPY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.mebPHP_USD = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.mebJPY_PHP = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.btnLockModule = New Telerik.WinControls.UI.RadToggleButton()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.btnLogs = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebUSD_JPY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebPHP_USD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebJPY_PHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLockModule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RadLabel8.Location = New System.Drawing.Point(5, 70)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(149, 30)
        Me.RadLabel8.TabIndex = 228
        Me.RadLabel8.Text = "Conversion Rate"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGen.Location = New System.Drawing.Point(289, 230)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(120, 40)
        Me.btnGen.TabIndex = 226
        Me.btnGen.Text = "OK"
        Me.btnGen.ThemeName = "Windows8"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(163, 195)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(174, 20)
        Me.dtpDate.TabIndex = 231
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "9/11/2014"
        Me.dtpDate.ThemeName = "Windows8"
        Me.dtpDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'mebUSD_JPY
        '
        Me.mebUSD_JPY.Location = New System.Drawing.Point(163, 143)
        Me.mebUSD_JPY.Mask = "N4"
        Me.mebUSD_JPY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebUSD_JPY.Name = "mebUSD_JPY"
        Me.mebUSD_JPY.Size = New System.Drawing.Size(174, 20)
        Me.mebUSD_JPY.TabIndex = 230
        Me.mebUSD_JPY.TabStop = False
        Me.mebUSD_JPY.Text = "0.0000"
        Me.mebUSD_JPY.ThemeName = "Windows8"
        '
        'mebPHP_USD
        '
        Me.mebPHP_USD.Location = New System.Drawing.Point(163, 117)
        Me.mebPHP_USD.Mask = "N4"
        Me.mebPHP_USD.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebPHP_USD.Name = "mebPHP_USD"
        Me.mebPHP_USD.Size = New System.Drawing.Size(174, 20)
        Me.mebPHP_USD.TabIndex = 229
        Me.mebPHP_USD.TabStop = False
        Me.mebPHP_USD.Text = "0.0000"
        Me.mebPHP_USD.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(84, 117)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(70, 21)
        Me.RadLabel6.TabIndex = 232
        Me.RadLabel6.Text = "PHP - USD"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(84, 143)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(65, 21)
        Me.RadLabel1.TabIndex = 233
        Me.RadLabel1.Text = "USD - JPY"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(84, 195)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(33, 21)
        Me.RadLabel2.TabIndex = 234
        Me.RadLabel2.Text = "Year"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(84, 169)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(64, 21)
        Me.RadLabel3.TabIndex = 236
        Me.RadLabel3.Text = "JPY - PHP"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'mebJPY_PHP
        '
        Me.mebJPY_PHP.Location = New System.Drawing.Point(163, 169)
        Me.mebJPY_PHP.Mask = "N4"
        Me.mebJPY_PHP.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebJPY_PHP.Name = "mebJPY_PHP"
        Me.mebJPY_PHP.Size = New System.Drawing.Size(174, 20)
        Me.mebJPY_PHP.TabIndex = 235
        Me.mebJPY_PHP.TabStop = False
        Me.mebJPY_PHP.Text = "0.0000"
        Me.mebJPY_PHP.ThemeName = "Windows8"
        '
        'btnLockModule
        '
        Me.btnLockModule.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLockModule.Location = New System.Drawing.Point(163, 18)
        Me.btnLockModule.Name = "btnLockModule"
        Me.btnLockModule.Size = New System.Drawing.Size(110, 29)
        Me.btnLockModule.TabIndex = 238
        Me.btnLockModule.Text = "YES"
        Me.btnLockModule.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(66, 18)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel5.TabIndex = 239
        Me.RadLabel5.Text = "Lock Module"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(5, 229)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 227
        Me.lblBack.ThemeName = "Windows8"
        '
        'btnLogs
        '
        Me.btnLogs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.Location = New System.Drawing.Point(163, 230)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(120, 40)
        Me.btnLogs.TabIndex = 240
        Me.btnLogs.Text = "Logs"
        Me.btnLogs.ThemeName = "Windows8"
        '
        'frmConversionBC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogs)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.btnLockModule)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.mebJPY_PHP)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.mebUSD_JPY)
        Me.Controls.Add(Me.mebPHP_USD)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnGen)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmConversionBC"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Settings"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebUSD_JPY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebPHP_USD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebJPY_PHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLockModule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGen As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents mebUSD_JPY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents mebPHP_USD As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebJPY_PHP As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents btnLockModule As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents btnLogs As Telerik.WinControls.UI.RadButton
End Class


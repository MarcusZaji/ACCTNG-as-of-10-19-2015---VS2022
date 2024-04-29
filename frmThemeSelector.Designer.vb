<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThemeSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmThemeSelector))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.btnSetTheme = New Telerik.WinControls.UI.RadButton()
        Me.lblClose = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.rcbTheme = New Telerik.WinControls.UI.RadColorBox()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.btnSetTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcbTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSetTheme
        '
        Me.btnSetTheme.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetTheme.Location = New System.Drawing.Point(323, 23)
        Me.btnSetTheme.Name = "btnSetTheme"
        Me.btnSetTheme.Size = New System.Drawing.Size(93, 27)
        Me.btnSetTheme.TabIndex = 239
        Me.btnSetTheme.Text = "Set Theme"
        Me.btnSetTheme.ThemeName = "Windows8"
        '
        'lblClose
        '
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Image = CType(resources.GetObject("lblClose.Image"), System.Drawing.Image)
        Me.lblClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblClose.Location = New System.Drawing.Point(3, 53)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(61, 57)
        Me.lblClose.TabIndex = 240
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(70, 23)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(39, 21)
        Me.RadLabel1.TabIndex = 248
        Me.RadLabel1.Text = "Color"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'rcbTheme
        '
        Me.rcbTheme.Location = New System.Drawing.Point(139, 23)
        Me.rcbTheme.Name = "rcbTheme"
        Me.rcbTheme.Size = New System.Drawing.Size(155, 20)
        Me.rcbTheme.TabIndex = 249
        Me.rcbTheme.ThemeName = "Windows8"
        '
        'FrmThemeSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 119)
        Me.ControlBox = False
        Me.Controls.Add(Me.rcbTheme)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.btnSetTheme)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmThemeSelector"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Theme Settings"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.btnSetTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcbTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents btnSetTheme As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblClose As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rcbTheme As Telerik.WinControls.UI.RadColorBox
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


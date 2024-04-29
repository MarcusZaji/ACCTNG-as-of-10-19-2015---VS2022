<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetDataConn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetDataConn))
        Me.mebServerIp = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUsername = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDbName = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.lblClose = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.mebServerIp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mebServerIp
        '
        Me.mebServerIp.Location = New System.Drawing.Point(181, 18)
        Me.mebServerIp.MaskType = Telerik.WinControls.UI.MaskType.IP
        Me.mebServerIp.Name = "mebServerIp"
        '
        '
        '
        Me.mebServerIp.RootElement.StretchVertically = True
        Me.mebServerIp.Size = New System.Drawing.Size(138, 20)
        Me.mebServerIp.TabIndex = 1
        Me.mebServerIp.TabStop = False
        Me.mebServerIp.Text = "   .   .   .   "
        Me.mebServerIp.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(73, 111)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel4.TabIndex = 13
        Me.RadLabel4.Text = "Password"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(73, 80)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(66, 21)
        Me.RadLabel3.TabIndex = 11
        Me.RadLabel3.Text = "Username"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(73, 49)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(101, 21)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Database Name"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(73, 18)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(102, 21)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Server IP Adress"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(180, 111)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        '
        '
        Me.txtPassword.RootElement.StretchVertically = True
        Me.txtPassword.Size = New System.Drawing.Size(138, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.ThemeName = "Windows8"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(180, 80)
        Me.txtUsername.Name = "txtUsername"
        '
        '
        '
        Me.txtUsername.RootElement.StretchVertically = True
        Me.txtUsername.Size = New System.Drawing.Size(138, 20)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.ThemeName = "Windows8"
        '
        'txtDbName
        '
        Me.txtDbName.Location = New System.Drawing.Point(180, 49)
        Me.txtDbName.Name = "txtDbName"
        '
        '
        '
        Me.txtDbName.RootElement.StretchVertically = True
        Me.txtDbName.Size = New System.Drawing.Size(138, 20)
        Me.txtDbName.TabIndex = 2
        Me.txtDbName.ThemeName = "Windows8"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(317, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Windows8"
        '
        'lblClose
        '
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Image = CType(resources.GetObject("lblClose.Image"), System.Drawing.Image)
        Me.lblClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblClose.Location = New System.Drawing.Point(2, 149)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(61, 57)
        Me.lblClose.TabIndex = 88
        '
        'frmSetDataConn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.mebServerIp)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtDbName)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetDataConn"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Connection Settings"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.mebServerIp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mebServerIp As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtUsername As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDbName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblClose As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtUN = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPW = New Telerik.WinControls.UI.RadTextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblcompany = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLogin = New System.Windows.Forms.PictureBox()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.btnSetting = New System.Windows.Forms.PictureBox()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadLabel2.Location = New System.Drawing.Point(136, 103)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(91, 30)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "username"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadLabel3.Location = New System.Drawing.Point(136, 142)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(89, 30)
        Me.RadLabel3.TabIndex = 2
        Me.RadLabel3.Text = "password"
        '
        'txtUN
        '
        Me.txtUN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUN.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUN.Location = New System.Drawing.Point(247, 102)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.NullText = "username"
        '
        '
        '
        Me.txtUN.RootElement.StretchVertically = True
        Me.txtUN.Size = New System.Drawing.Size(185, 33)
        Me.txtUN.TabIndex = 3
        Me.txtUN.ThemeName = "Windows8"
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(247, 141)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.NullText = "password"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        '
        '
        '
        Me.txtPW.RootElement.StretchVertically = True
        Me.txtPW.Size = New System.Drawing.Size(151, 33)
        Me.txtPW.TabIndex = 4
        Me.txtPW.ThemeName = "Windows8"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(544, 28)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblVersion.TabIndex = 10
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblcompany.Location = New System.Drawing.Point(192, 215)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(227, 21)
        Me.lblcompany.TabIndex = 11
        Me.lblcompany.Text = "Furukawa Electric Autoparts Phil."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(252, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Budget Actual Program 3.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ACCTNG.My.Resources.Resources.BAP_logo_2_0
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(176, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'picLogin
        '
        Me.picLogin.BackgroundImage = Global.ACCTNG.My.Resources.Resources.login
        Me.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogin.Location = New System.Drawing.Point(399, 141)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(33, 33)
        Me.picLogin.TabIndex = 58
        Me.picLogin.TabStop = False
        '
        'PicExit
        '
        Me.PicExit.BackgroundImage = Global.ACCTNG.My.Resources.Resources.Exit2
        Me.PicExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Location = New System.Drawing.Point(547, 216)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(28, 27)
        Me.PicExit.TabIndex = 57
        Me.PicExit.TabStop = False
        '
        'btnSetting
        '
        Me.btnSetting.BackgroundImage = Global.ACCTNG.My.Resources.Resources.Settings
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.Location = New System.Drawing.Point(513, 216)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(28, 27)
        Me.btnSetting.TabIndex = 62
        Me.btnSetting.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLogin)
        Me.Controls.Add(Me.PicExit)
        Me.Controls.Add(Me.lblcompany)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtPW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "MaterialPink"
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtUN As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPW As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents PicExit As System.Windows.Forms.PictureBox
    Friend WithEvents picLogin As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSetting As System.Windows.Forms.PictureBox
    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
End Class


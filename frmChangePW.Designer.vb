<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePW))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtconPW = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPW = New Telerik.WinControls.UI.RadTextBox()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.lblID = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(47, 44)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(112, 21)
        Me.RadLabel3.TabIndex = 83
        Me.RadLabel3.Text = "confirm password"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(96, 21)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel2.TabIndex = 82
        Me.RadLabel2.Text = "password"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtconPW
        '
        Me.txtconPW.Location = New System.Drawing.Point(161, 44)
        Me.txtconPW.Name = "txtconPW"
        Me.txtconPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconPW.Size = New System.Drawing.Size(159, 20)
        Me.txtconPW.TabIndex = 81
        Me.txtconPW.ThemeName = "Windows8"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(161, 18)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(159, 20)
        Me.txtPW.TabIndex = 80
        Me.txtPW.ThemeName = "Windows8"
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(199, 70)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(120, 40)
        Me.btnGo.TabIndex = 230
        Me.btnGo.Text = "&Go"
        Me.btnGo.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(1, 71)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 231
        Me.lblBack.ThemeName = "Windows8"
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(73, 24)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(17, 18)
        Me.lblID.TabIndex = 232
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'FrmChangePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtconPW)
        Me.Controls.Add(Me.txtPW)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmChangePW"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Change Password"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtconPW As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPW As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


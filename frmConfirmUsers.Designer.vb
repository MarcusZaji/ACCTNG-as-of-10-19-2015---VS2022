<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmUsers))
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnConfirm = New Telerik.WinControls.UI.RadButton()
        Me.txtPW = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUN = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(45, 44)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel2.TabIndex = 229
        Me.RadLabel2.Text = "password"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(3, 80)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 232
        Me.lblBack.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(45, 18)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(65, 21)
        Me.RadLabel1.TabIndex = 228
        Me.RadLabel1.Text = "username"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(248, 80)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(114, 48)
        Me.btnConfirm.TabIndex = 231
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.ThemeName = "Windows8"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(159, 44)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(159, 20)
        Me.txtPW.TabIndex = 227
        Me.txtPW.ThemeName = "Windows8"
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(159, 18)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(159, 20)
        Me.txtUN.TabIndex = 226
        Me.txtUN.ThemeName = "Windows8"
        '
        'frmConfirmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUN)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmConfirmUsers"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.Text = " Confirm User"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnConfirm As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtPW As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtUN As Telerik.WinControls.UI.RadTextBox
End Class


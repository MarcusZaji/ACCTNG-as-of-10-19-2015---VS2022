<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderPicker))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rbMO = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbSO = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        CType(Me.rbMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbMO
        '
        Me.rbMO.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbMO.Location = New System.Drawing.Point(89, 54)
        Me.rbMO.Name = "rbMO"
        Me.rbMO.Size = New System.Drawing.Size(166, 21)
        Me.rbMO.TabIndex = 8
        Me.rbMO.Text = "New Purchased Request"
        Me.rbMO.ThemeName = "Windows8"
        '
        'rbSO
        '
        Me.rbSO.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbSO.Location = New System.Drawing.Point(89, 18)
        Me.rbSO.Name = "rbSO"
        Me.rbSO.Size = New System.Drawing.Size(168, 21)
        Me.rbSO.TabIndex = 7
        Me.rbSO.Text = "View Purchased Request"
        Me.rbSO.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(2, 81)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 225
        Me.lblBack.ThemeName = "Windows8"
        '
        'frmOrderPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(386, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.rbMO)
        Me.Controls.Add(Me.rbSO)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmOrderPicker"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Request Picker"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.rbMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rbMO As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbSO As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
End Class


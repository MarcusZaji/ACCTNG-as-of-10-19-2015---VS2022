<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadPicker))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rbUpBudget = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbUpItem = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbUpPO = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbUpBC = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.rbUpBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbUpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbUpPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbUpBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbUpBudget
        '
        Me.rbUpBudget.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbUpBudget.Location = New System.Drawing.Point(81, 22)
        Me.rbUpBudget.Name = "rbUpBudget"
        Me.rbUpBudget.Size = New System.Drawing.Size(113, 21)
        Me.rbUpBudget.TabIndex = 8
        Me.rbUpBudget.Text = "Upload Budget"
        Me.rbUpBudget.ThemeName = "Windows8"
        '
        'rbUpItem
        '
        Me.rbUpItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbUpItem.Location = New System.Drawing.Point(271, 146)
        Me.rbUpItem.Name = "rbUpItem"
        Me.rbUpItem.Size = New System.Drawing.Size(103, 21)
        Me.rbUpItem.TabIndex = 7
        Me.rbUpItem.Text = "Upload Items"
        Me.rbUpItem.ThemeName = "Windows8"
        Me.rbUpItem.Visible = False
        '
        'rbUpPO
        '
        Me.rbUpPO.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbUpPO.Location = New System.Drawing.Point(81, 53)
        Me.rbUpPO.Name = "rbUpPO"
        Me.rbUpPO.Size = New System.Drawing.Size(88, 21)
        Me.rbUpPO.TabIndex = 227
        Me.rbUpPO.Text = "Upload PO"
        Me.rbUpPO.ThemeName = "Windows8"
        '
        'rbUpBC
        '
        Me.rbUpBC.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbUpBC.Location = New System.Drawing.Point(81, 84)
        Me.rbUpBC.Name = "rbUpBC"
        Me.rbUpBC.Size = New System.Drawing.Size(194, 21)
        Me.rbUpBC.TabIndex = 228
        Me.rbUpBC.Text = "Upload Consolidated Budget"
        Me.rbUpBC.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(4, 110)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 225
        Me.lblBack.ThemeName = "Windows8"
        '
        'frmUploadPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(386, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbUpBC)
        Me.Controls.Add(Me.rbUpPO)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.rbUpBudget)
        Me.Controls.Add(Me.rbUpItem)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUploadPicker"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Upload Data"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.rbUpBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbUpItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbUpPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbUpBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rbUpBudget As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbUpItem As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbUpPO As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbUpBC As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBudgetSetting))
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.lblClose = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.mebYear = New Telerik.WinControls.UI.RadMaskedEditBox()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(95, 35)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(55, 21)
        Me.RadLabel4.TabIndex = 13
        Me.RadLabel4.Text = "Set Year"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(335, 53)
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
        Me.lblClose.Location = New System.Drawing.Point(3, 53)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(61, 57)
        Me.lblClose.TabIndex = 88
        '
        'mebYear
        '
        Me.mebYear.Location = New System.Drawing.Point(167, 35)
        Me.mebYear.Name = "mebYear"
        Me.mebYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mebYear.Size = New System.Drawing.Size(139, 20)
        Me.mebYear.TabIndex = 351
        Me.mebYear.TabStop = False
        Me.mebYear.Tag = "C"
        Me.mebYear.ThemeName = "Windows8"
        '
        'frmBudgetSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.mebYear)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBudgetSetting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Budget Settings"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblClose As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents mebYear As Telerik.WinControls.UI.RadMaskedEditBox
End Class


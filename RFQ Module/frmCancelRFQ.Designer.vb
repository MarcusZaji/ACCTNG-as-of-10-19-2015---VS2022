<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCancelRFQ
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
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.txtReason = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.txtRFQNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFQNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.White
        Me.txtReason.Location = New System.Drawing.Point(12, 53)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        '
        '
        '
        Me.txtReason.RootElement.StretchVertically = True
        Me.txtReason.Size = New System.Drawing.Size(356, 86)
        Me.txtReason.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 18)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(225, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Please input your reasons for canceling RFQ"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.Location = New System.Drawing.Point(285, 149)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(83, 36)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.ThemeName = "MaterialPink"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSubmit.Location = New System.Drawing.Point(167, 149)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 36)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.ThemeName = "MaterialPink"
        '
        'txtRFQNo
        '
        Me.txtRFQNo.Enabled = False
        Me.txtRFQNo.Location = New System.Drawing.Point(243, 18)
        Me.txtRFQNo.Name = "txtRFQNo"
        Me.txtRFQNo.ReadOnly = True
        Me.txtRFQNo.Size = New System.Drawing.Size(125, 20)
        Me.txtRFQNo.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(12, 164)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(61, 20)
        Me.txtID.TabIndex = 4
        Me.txtID.Visible = False
        '
        'FrmCancelRFQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 196)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtRFQNo)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtReason)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCancelRFQ"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CANCEL RFQ"
        Me.ThemeName = "MaterialPink"
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFQNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents txtReason As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtRFQNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
End Class


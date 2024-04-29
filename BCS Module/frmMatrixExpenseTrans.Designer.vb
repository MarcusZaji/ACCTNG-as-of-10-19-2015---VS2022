<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatrixExpenseTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatrixExpenseTrans))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.txtDefinition = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtThreshold = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSample = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnNewMatrix = New Telerik.WinControls.UI.RadButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        CType(Me.txtDefinition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDefinition
        '
        Me.txtDefinition.AutoScroll = True
        Me.txtDefinition.Location = New System.Drawing.Point(239, 44)
        Me.txtDefinition.MaxLength = 100000
        Me.txtDefinition.Multiline = True
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(308, 83)
        Me.txtDefinition.TabIndex = 343
        Me.txtDefinition.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(29, 45)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(173, 21)
        Me.RadLabel14.TabIndex = 342
        Me.RadLabel14.Text = "Definition / Criteria / Nature"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownHeight = 200
        Me.ddlClass.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(239, 18)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(308, 20)
        Me.ddlClass.TabIndex = 345
        Me.ddlClass.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(29, 18)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel2.TabIndex = 346
        Me.RadLabel2.Text = "Classification"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtThreshold
        '
        Me.txtThreshold.AutoScroll = True
        Me.txtThreshold.Location = New System.Drawing.Point(239, 133)
        Me.txtThreshold.MaxLength = 100000
        Me.txtThreshold.Multiline = True
        Me.txtThreshold.Name = "txtThreshold"
        Me.txtThreshold.Size = New System.Drawing.Size(308, 83)
        Me.txtThreshold.TabIndex = 348
        Me.txtThreshold.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(29, 134)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(204, 21)
        Me.RadLabel3.TabIndex = 347
        Me.RadLabel3.Text = "Threshold / Capitalizable Amount"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'txtSample
        '
        Me.txtSample.AutoScroll = True
        Me.txtSample.Location = New System.Drawing.Point(239, 222)
        Me.txtSample.MaxLength = 100000
        Me.txtSample.Multiline = True
        Me.txtSample.Name = "txtSample"
        Me.txtSample.Size = New System.Drawing.Size(308, 83)
        Me.txtSample.TabIndex = 350
        Me.txtSample.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(29, 223)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(50, 21)
        Me.RadLabel1.TabIndex = 349
        Me.RadLabel1.Text = "Sample"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'btnNewMatrix
        '
        Me.btnNewMatrix.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMatrix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMatrix.Location = New System.Drawing.Point(427, 311)
        Me.btnNewMatrix.Name = "btnNewMatrix"
        Me.btnNewMatrix.Size = New System.Drawing.Size(120, 40)
        Me.btnNewMatrix.TabIndex = 356
        Me.btnNewMatrix.Text = "Save"
        Me.btnNewMatrix.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(0, 311)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 357
        '
        'frmMatrixExpenseAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnNewMatrix)
        Me.Controls.Add(Me.txtSample)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtThreshold)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.RadLabel14)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMatrixExpenseAddEdit"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " New Matrix Expense"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.txtDefinition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents txtDefinition As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtThreshold As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSample As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnNewMatrix As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
End Class


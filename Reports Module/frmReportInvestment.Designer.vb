<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportInvestment
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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rptPerPO = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
        Me.rptPerInv = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbInvestment = New Telerik.WinControls.UI.RadRadioButton()
        Me.btnGen = New Telerik.WinControls.UI.RadButton()
        Me.ddlInvestment = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.cbAll = New Telerik.WinControls.UI.RadCheckBox()
        Me.rptPerPODetail = New Telerik.WinControls.UI.RadRadioButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rptPerPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPerInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbInvestment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlInvestment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPerPODetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.rptPerPODetail)
        Me.RadGroupBox1.Controls.Add(Me.rptPerPO)
        Me.RadGroupBox1.Controls.Add(Me.RadRadioButton2)
        Me.RadGroupBox1.Controls.Add(Me.rptPerInv)
        Me.RadGroupBox1.Controls.Add(Me.rbInvestment)
        Me.RadGroupBox1.HeaderText = "Select Report"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(375, 181)
        Me.RadGroupBox1.TabIndex = 231
        Me.RadGroupBox1.Text = "Select Report"
        Me.RadGroupBox1.ThemeName = "Windows8"
        '
        'rptPerPO
        '
        Me.rptPerPO.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rptPerPO.Location = New System.Drawing.Point(23, 110)
        Me.rptPerPO.Name = "rptPerPO"
        Me.rptPerPO.Size = New System.Drawing.Size(136, 21)
        Me.rptPerPO.TabIndex = 32
        Me.rptPerPO.TabStop = False
        Me.rptPerPO.Text = " Report per PO No"
        Me.rptPerPO.ThemeName = "Windows8"
        '
        'RadRadioButton2
        '
        Me.RadRadioButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadRadioButton2.Location = New System.Drawing.Point(23, 83)
        Me.RadRadioButton2.Name = "RadRadioButton2"
        Me.RadRadioButton2.Size = New System.Drawing.Size(119, 21)
        Me.RadRadioButton2.TabIndex = 32
        Me.RadRadioButton2.TabStop = False
        Me.RadRadioButton2.Text = "Detailed Report"
        Me.RadRadioButton2.ThemeName = "Windows8"
        '
        'rptPerInv
        '
        Me.rptPerInv.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rptPerInv.Location = New System.Drawing.Point(23, 56)
        Me.rptPerInv.Name = "rptPerInv"
        Me.rptPerInv.Size = New System.Drawing.Size(185, 21)
        Me.rptPerInv.TabIndex = 31
        Me.rptPerInv.TabStop = False
        Me.rptPerInv.Text = " Report per Investment No"
        Me.rptPerInv.ThemeName = "Windows8"
        '
        'rbInvestment
        '
        Me.rbInvestment.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbInvestment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbInvestment.Location = New System.Drawing.Point(23, 29)
        Me.rbInvestment.Name = "rbInvestment"
        Me.rbInvestment.Size = New System.Drawing.Size(95, 21)
        Me.rbInvestment.TabIndex = 30
        Me.rbInvestment.Text = " Investment"
        Me.rbInvestment.ThemeName = "Windows8"
        Me.rbInvestment.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGen.Location = New System.Drawing.Point(472, 144)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(134, 54)
        Me.btnGen.TabIndex = 232
        Me.btnGen.Text = "Generate &Report"
        Me.btnGen.ThemeName = "Windows8"
        '
        'ddlInvestment
        '
        Me.ddlInvestment.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlInvestment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlInvestment.Location = New System.Drawing.Point(448, 50)
        Me.ddlInvestment.Name = "ddlInvestment"
        Me.ddlInvestment.Size = New System.Drawing.Size(158, 20)
        Me.ddlInvestment.TabIndex = 331
        Me.ddlInvestment.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(393, 23)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(94, 21)
        Me.RadLabel14.TabIndex = 330
        Me.RadLabel14.Text = "Investment No"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(393, 76)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel2.TabIndex = 333
        Me.RadLabel2.Text = "Department"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownHeight = 200
        Me.ddlDept.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Location = New System.Drawing.Point(417, 98)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 332
        Me.ddlDept.ThemeName = "Windows8"
        '
        'cbAll
        '
        Me.cbAll.Location = New System.Drawing.Point(401, 50)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(41, 18)
        Me.cbAll.TabIndex = 334
        Me.cbAll.Text = "ALL"
        Me.cbAll.ThemeName = "Windows8"
        '
        'rptPerPODetail
        '
        Me.rptPerPODetail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rptPerPODetail.Location = New System.Drawing.Point(23, 132)
        Me.rptPerPODetail.Name = "rptPerPODetail"
        Me.rptPerPODetail.Size = New System.Drawing.Size(190, 21)
        Me.rptPerPODetail.TabIndex = 33
        Me.rptPerPODetail.TabStop = False
        Me.rptPerPODetail.Text = " Report per PO No Detailed"
        Me.rptPerPODetail.ThemeName = "Windows8"
        '
        'FrmReportInvestment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 205)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.ddlInvestment)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "FrmReportInvestment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "REPORTS FOR INVESTMENT"
        Me.ThemeName = "Windows8"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rptPerPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPerInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbInvestment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlInvestment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPerPODetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rbInvestment As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rptPerInv As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents btnGen As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlInvestment As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cbAll As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rptPerPO As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rptPerPODetail As Telerik.WinControls.UI.RadRadioButton
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenReportBC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenReportBC))
        Me.btnGen = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rbRepAA = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cbMajorBud = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepCombine = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepBC = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepQTYClass = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepAmountClass = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepQTY = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepAmount = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbRepConBC = New Telerik.WinControls.UI.RadRadioButton()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlYear = New Telerik.WinControls.UI.RadDropDownList()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        CType(Me.btnGen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepAA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.cbMajorBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepCombine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepQTYClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepAmountClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepConBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGen.Location = New System.Drawing.Point(279, 442)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(134, 54)
        Me.btnGen.TabIndex = 219
        Me.btnGen.Text = "Generate &Report"
        Me.btnGen.ThemeName = "Windows8"
        '
        'rbRepAA
        '
        Me.rbRepAA.BackColor = System.Drawing.Color.Transparent
        Me.rbRepAA.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbRepAA.Location = New System.Drawing.Point(12, 145)
        Me.rbRepAA.Name = "rbRepAA"
        Me.rbRepAA.Size = New System.Drawing.Size(33, 21)
        Me.rbRepAA.TabIndex = 228
        Me.rbRepAA.Text = "Year"
        Me.rbRepAA.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.rbRepAA.ThemeName = "Windows8"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.cbMajorBud)
        Me.RadGroupBox1.Controls.Add(Me.rbRepCombine)
        Me.RadGroupBox1.Controls.Add(Me.rbRepBC)
        Me.RadGroupBox1.Controls.Add(Me.rbRepQTYClass)
        Me.RadGroupBox1.Controls.Add(Me.rbRepAmountClass)
        Me.RadGroupBox1.Controls.Add(Me.rbRepQTY)
        Me.RadGroupBox1.Controls.Add(Me.rbRepAmount)
        Me.RadGroupBox1.HeaderText = "Select Report"
        Me.RadGroupBox1.Location = New System.Drawing.Point(33, 199)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(380, 237)
        Me.RadGroupBox1.TabIndex = 230
        Me.RadGroupBox1.Text = "Select Report"
        Me.RadGroupBox1.ThemeName = "Windows8"
        '
        'cbMajorBud
        '
        Me.cbMajorBud.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMajorBud.Location = New System.Drawing.Point(31, 187)
        Me.cbMajorBud.Name = "cbMajorBud"
        Me.cbMajorBud.Size = New System.Drawing.Size(154, 21)
        Me.cbMajorBud.TabIndex = 12
        Me.cbMajorBud.TabStop = False
        Me.cbMajorBud.Text = "Created Major Budget"
        Me.cbMajorBud.ThemeName = "Windows8"
        '
        'rbRepCombine
        '
        Me.rbRepCombine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbRepCombine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepCombine.Location = New System.Drawing.Point(31, 25)
        Me.rbRepCombine.Name = "rbRepCombine"
        Me.rbRepCombine.Size = New System.Drawing.Size(204, 21)
        Me.rbRepCombine.TabIndex = 11
        Me.rbRepCombine.Text = "Created Budget (Amount& QTY)"
        Me.rbRepCombine.ThemeName = "Windows8"
        Me.rbRepCombine.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rbRepBC
        '
        Me.rbRepBC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepBC.Location = New System.Drawing.Point(31, 160)
        Me.rbRepBC.Name = "rbRepBC"
        Me.rbRepBC.Size = New System.Drawing.Size(116, 21)
        Me.rbRepBC.TabIndex = 7
        Me.rbRepBC.TabStop = False
        Me.rbRepBC.Text = "Created Budget"
        Me.rbRepBC.ThemeName = "Windows8"
        '
        'rbRepQTYClass
        '
        Me.rbRepQTYClass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepQTYClass.Location = New System.Drawing.Point(31, 133)
        Me.rbRepQTYClass.Name = "rbRepQTYClass"
        Me.rbRepQTYClass.Size = New System.Drawing.Size(257, 21)
        Me.rbRepQTYClass.TabIndex = 10
        Me.rbRepQTYClass.TabStop = False
        Me.rbRepQTYClass.Text = "Created Budget per QTY - Classification"
        Me.rbRepQTYClass.ThemeName = "Windows8"
        '
        'rbRepAmountClass
        '
        Me.rbRepAmountClass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepAmountClass.Location = New System.Drawing.Point(31, 106)
        Me.rbRepAmountClass.Name = "rbRepAmountClass"
        Me.rbRepAmountClass.Size = New System.Drawing.Size(303, 21)
        Me.rbRepAmountClass.TabIndex = 9
        Me.rbRepAmountClass.TabStop = False
        Me.rbRepAmountClass.Text = "Created Budget per Amount JPY - Classification"
        Me.rbRepAmountClass.ThemeName = "Windows8"
        '
        'rbRepQTY
        '
        Me.rbRepQTY.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepQTY.Location = New System.Drawing.Point(31, 79)
        Me.rbRepQTY.Name = "rbRepQTY"
        Me.rbRepQTY.Size = New System.Drawing.Size(168, 21)
        Me.rbRepQTY.TabIndex = 6
        Me.rbRepQTY.TabStop = False
        Me.rbRepQTY.Text = "Created Budget per QTY"
        Me.rbRepQTY.ThemeName = "Windows8"
        '
        'rbRepAmount
        '
        Me.rbRepAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepAmount.Location = New System.Drawing.Point(31, 52)
        Me.rbRepAmount.Name = "rbRepAmount"
        Me.rbRepAmount.Size = New System.Drawing.Size(214, 21)
        Me.rbRepAmount.TabIndex = 5
        Me.rbRepAmount.TabStop = False
        Me.rbRepAmount.Text = "Created Budget per Amount JPY"
        Me.rbRepAmount.ThemeName = "Windows8"
        '
        'rbRepConBC
        '
        Me.rbRepConBC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepConBC.Location = New System.Drawing.Point(104, 470)
        Me.rbRepConBC.Name = "rbRepConBC"
        Me.rbRepConBC.Size = New System.Drawing.Size(148, 21)
        Me.rbRepConBC.TabIndex = 8
        Me.rbRepConBC.TabStop = False
        Me.rbRepConBC.Text = "Consolidated Budget"
        Me.rbRepConBC.ThemeName = "Windows8"
        Me.rbRepConBC.Visible = False
        '
        'ddlDept
        '
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Enabled = False
        Me.ddlDept.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ddlDept.Location = New System.Drawing.Point(12, 66)
        Me.ddlDept.Name = "ddlDept"
        '
        '
        '
        Me.ddlDept.RootElement.StretchVertically = True
        Me.ddlDept.Size = New System.Drawing.Size(401, 20)
        Me.ddlDept.TabIndex = 269
        Me.ddlDept.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(12, 39)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel2.TabIndex = 268
        Me.RadLabel2.Text = "Department"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'ddlYear
        '
        Me.ddlYear.DropDownHeight = 200
        Me.ddlYear.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlYear.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ddlYear.Location = New System.Drawing.Point(12, 172)
        Me.ddlYear.Name = "ddlYear"
        '
        '
        '
        Me.ddlYear.RootElement.StretchVertically = True
        Me.ddlYear.Size = New System.Drawing.Size(108, 20)
        Me.ddlYear.TabIndex = 353
        Me.ddlYear.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Enabled = False
        Me.ddlClass.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ddlClass.Location = New System.Drawing.Point(11, 119)
        Me.ddlClass.Name = "ddlClass"
        '
        '
        '
        Me.ddlClass.RootElement.StretchVertically = True
        Me.ddlClass.Size = New System.Drawing.Size(402, 20)
        Me.ddlClass.TabIndex = 355
        Me.ddlClass.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(12, 92)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel1.TabIndex = 354
        Me.RadLabel1.Text = "Classification"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(11, 442)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 224
        Me.lblBack.ThemeName = "Windows8"
        '
        'frmGenReportBC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbRepConBC)
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ddlYear)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.rbRepAA)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnGen)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmGenReportBC"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.btnGen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepAA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.cbMajorBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepCombine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepQTYClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepAmountClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepConBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGen As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbRepAA As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rbRepQTY As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbRepAmount As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlYear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents rbRepBC As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbRepConBC As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents rbRepQTYClass As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbRepAmountClass As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbRepCombine As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents cbMajorBud As Telerik.WinControls.UI.RadRadioButton
End Class


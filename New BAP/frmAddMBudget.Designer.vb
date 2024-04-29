<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddMBudget
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
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBRNum = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.mebJPY = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlProject = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebJPY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(12, 17)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(202, 21)
        Me.RadLabel6.TabIndex = 122
        Me.RadLabel6.Text = "Major Budget Reference Number"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'txtBRNum
        '
        Me.txtBRNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBRNum.Location = New System.Drawing.Point(227, 17)
        Me.txtBRNum.Name = "txtBRNum"
        Me.txtBRNum.Size = New System.Drawing.Size(189, 24)
        Me.txtBRNum.TabIndex = 121
        Me.txtBRNum.ThemeName = "Fluent"
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.Location = New System.Drawing.Point(227, 74)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 62)
        Me.txtDesc.TabIndex = 123
        Me.txtDesc.ThemeName = "Fluent"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(12, 75)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel11.TabIndex = 124
        Me.RadLabel11.Text = "Description"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownHeight = 200
        Me.ddlDept.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Location = New System.Drawing.Point(227, 142)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 24)
        Me.ddlDept.TabIndex = 127
        Me.ddlDept.ThemeName = "Fluent"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(12, 142)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel2.TabIndex = 128
        Me.RadLabel2.Text = "Department"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(227, 172)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(189, 24)
        Me.dtpDate.TabIndex = 134
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "12/4/2018"
        Me.dtpDate.ThemeName = "Fluent"
        Me.dtpDate.Value = New Date(2018, 12, 4, 13, 33, 4, 90)
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(12, 178)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(28, 18)
        Me.RadLabel5.TabIndex = 133
        Me.RadLabel5.Text = "Year"
        Me.RadLabel5.ThemeName = "Fluent"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnSave.Location = New System.Drawing.Point(17, 267)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 28)
        Me.btnSave.TabIndex = 138
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Fluent"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(343, 268)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(73, 24)
        Me.txtID.TabIndex = 140
        Me.txtID.ThemeName = "Fluent"
        Me.txtID.Visible = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(12, 47)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel4.TabIndex = 211
        Me.RadLabel4.Text = "Amount JPY"
        Me.RadLabel4.ThemeName = "Fluent"
        '
        'mebJPY
        '
        Me.mebJPY.DecimalPlaces = 6
        Me.mebJPY.Location = New System.Drawing.Point(227, 45)
        Me.mebJPY.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mebJPY.Minimum = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.mebJPY.Name = "mebJPY"
        Me.mebJPY.Size = New System.Drawing.Size(189, 24)
        Me.mebJPY.TabIndex = 460
        Me.mebJPY.ThemeName = "Fluent"
        Me.mebJPY.ThousandsSeparator = True
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(12, 204)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(48, 21)
        Me.RadLabel7.TabIndex = 462
        Me.RadLabel7.Text = "Project"
        Me.RadLabel7.ThemeName = "Fluent"
        '
        'ddlProject
        '
        Me.ddlProject.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlProject.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "PROJECT"
        RadListDataItem4.Text = "NON-PROJECT"
        Me.ddlProject.Items.Add(RadListDataItem3)
        Me.ddlProject.Items.Add(RadListDataItem4)
        Me.ddlProject.Location = New System.Drawing.Point(227, 202)
        Me.ddlProject.Name = "ddlProject"
        Me.ddlProject.Size = New System.Drawing.Size(189, 24)
        Me.ddlProject.TabIndex = 461
        Me.ddlProject.ThemeName = "Fluent"
        '
        'FrmAddMBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 319)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.ddlProject)
        Me.Controls.Add(Me.mebJPY)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.txtBRNum)
        Me.Name = "FrmAddMBudget"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Budget"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebJPY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBRNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebJPY As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlProject As Telerik.WinControls.UI.RadDropDownList
End Class


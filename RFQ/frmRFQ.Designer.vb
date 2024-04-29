<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRFQ
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSection = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDept = New Telerik.WinControls.UI.RadTextBox()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtApprovedby = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCheckedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.btnOI = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBudRevNum = New Telerik.WinControls.UI.RadTextBox()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApprovedby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBudRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rgvList.Location = New System.Drawing.Point(0, 158)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(1038, 356)
        Me.rgvList.TabIndex = 22
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(9, 37)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(35, 21)
        Me.RadLabel13.TabIndex = 128
        Me.RadLabel13.Text = "Date"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(9, 90)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(50, 21)
        Me.RadLabel1.TabIndex = 130
        Me.RadLabel1.Text = "Section"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtSection
        '
        Me.txtSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSection.Enabled = False
        Me.txtSection.Location = New System.Drawing.Point(136, 92)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(189, 20)
        Me.txtSection.TabIndex = 129
        Me.txtSection.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(9, 116)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel2.TabIndex = 132
        Me.RadLabel2.Text = "Department"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtDept
        '
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Enabled = False
        Me.txtDept.Location = New System.Drawing.Point(136, 118)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(189, 20)
        Me.txtDept.TabIndex = 131
        Me.txtDept.ThemeName = "Windows8"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(136, 39)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpDate.TabIndex = 133
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "9/11/2014"
        Me.dtpDate.ThemeName = "Windows8"
        Me.dtpDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(9, 64)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(106, 21)
        Me.RadLabel3.TabIndex = 135
        Me.RadLabel3.Text = "Requestor Name"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(136, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(189, 20)
        Me.txtName.TabIndex = 134
        Me.txtName.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(398, 10)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel4.TabIndex = 137
        Me.RadLabel4.Text = "Approved by"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'txtApprovedby
        '
        Me.txtApprovedby.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApprovedby.Enabled = False
        Me.txtApprovedby.Location = New System.Drawing.Point(525, 12)
        Me.txtApprovedby.Name = "txtApprovedby"
        Me.txtApprovedby.ReadOnly = True
        Me.txtApprovedby.Size = New System.Drawing.Size(189, 20)
        Me.txtApprovedby.TabIndex = 136
        Me.txtApprovedby.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(398, 37)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(75, 21)
        Me.RadLabel5.TabIndex = 139
        Me.RadLabel5.Text = "Checked by"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'txtCheckedBy
        '
        Me.txtCheckedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckedBy.Enabled = False
        Me.txtCheckedBy.Location = New System.Drawing.Point(525, 39)
        Me.txtCheckedBy.Name = "txtCheckedBy"
        Me.txtCheckedBy.ReadOnly = True
        Me.txtCheckedBy.Size = New System.Drawing.Size(189, 20)
        Me.txtCheckedBy.TabIndex = 138
        Me.txtCheckedBy.ThemeName = "Windows8"
        '
        'btnOI
        '
        Me.btnOI.BackColor = System.Drawing.Color.Teal
        Me.btnOI.Enabled = False
        Me.btnOI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOI.ForeColor = System.Drawing.Color.White
        Me.btnOI.Location = New System.Drawing.Point(747, 101)
        Me.btnOI.Name = "btnOI"
        Me.btnOI.Size = New System.Drawing.Size(138, 36)
        Me.btnOI.TabIndex = 208
        Me.btnOI.Text = "Save"
        Me.btnOI.ThemeName = "MaterialPink"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(10, 11)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(49, 21)
        Me.RadLabel6.TabIndex = 210
        Me.RadLabel6.Text = "RFQNo"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'txtBudRevNum
        '
        Me.txtBudRevNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBudRevNum.Enabled = False
        Me.txtBudRevNum.Location = New System.Drawing.Point(136, 11)
        Me.txtBudRevNum.Name = "txtBudRevNum"
        Me.txtBudRevNum.ReadOnly = True
        Me.txtBudRevNum.Size = New System.Drawing.Size(189, 20)
        Me.txtBudRevNum.TabIndex = 209
        Me.txtBudRevNum.ThemeName = "Windows8"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Teal
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(891, 101)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 36)
        Me.btnPrint.TabIndex = 209
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ThemeName = "MaterialPink"
        '
        'FrmRFQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 514)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.txtBudRevNum)
        Me.Controls.Add(Me.btnOI)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.txtCheckedBy)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtApprovedby)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "FrmRFQ"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "REQUEST FOR QUOTATION"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApprovedby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBudRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSection As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDept As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtCheckedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtApprovedby As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnOI As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBudRevNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRFQPur
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
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.ddlContactPerson = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvSupplier = New Telerik.WinControls.UI.RadGridView()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.txtAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPhone = New Telerik.WinControls.UI.RadTextBox()
        Me.rgvItems = New Telerik.WinControls.UI.RadGridView()
        Me.btnItems = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCreate = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btnPrint = New Telerik.WinControls.UI.RadButton()
        Me.btnSaveMe = New Telerik.WinControls.UI.RadButton()
        Me.bwSaveRFQ = New System.ComponentModel.BackgroundWorker()
        Me.bwRFQItems = New System.ComponentModel.BackgroundWorker()
        Me.btnView = New Telerik.WinControls.UI.RadButton()
        Me.txtName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtSection = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDept = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.txtContactPerson = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlRFQNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpDateNeeded = New Telerik.WinControls.UI.RadDateTimePicker()
        CType(Me.ddlContactPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlContactPerson.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlContactPerson.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSupplier.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlRFQNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlRFQNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlRFQNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddlContactPerson
        '
        '
        'ddlContactPerson.NestedRadGridView
        '
        Me.ddlContactPerson.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlContactPerson.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlContactPerson.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlContactPerson.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlContactPerson.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlContactPerson.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlContactPerson.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlContactPerson.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlContactPerson.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlContactPerson.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.ddlContactPerson.EditorControl.Name = "NestedRadGridView"
        Me.ddlContactPerson.EditorControl.ReadOnly = True
        Me.ddlContactPerson.EditorControl.ShowGroupPanel = False
        Me.ddlContactPerson.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlContactPerson.EditorControl.TabIndex = 0
        Me.ddlContactPerson.Location = New System.Drawing.Point(12, 71)
        Me.ddlContactPerson.Name = "ddlContactPerson"
        Me.ddlContactPerson.NullText = "Contact Person"
        Me.ddlContactPerson.Size = New System.Drawing.Size(472, 20)
        Me.ddlContactPerson.TabIndex = 0
        Me.ddlContactPerson.TabStop = False
        Me.ddlContactPerson.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(11, 52)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "SUPPLIER"
        '
        'rgvSupplier
        '
        Me.rgvSupplier.Location = New System.Drawing.Point(11, 149)
        '
        '
        '
        Me.rgvSupplier.MasterTemplate.AllowAddNewRow = False
        Me.rgvSupplier.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSupplier.MasterTemplate.AllowColumnReorder = False
        Me.rgvSupplier.MasterTemplate.AllowEditRow = False
        Me.rgvSupplier.MasterTemplate.EnableGrouping = False
        Me.rgvSupplier.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.rgvSupplier.Name = "rgvSupplier"
        Me.rgvSupplier.Size = New System.Drawing.Size(511, 385)
        Me.rgvSupplier.TabIndex = 23
        Me.rgvSupplier.ThemeName = "Windows8"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(490, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 24)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.ThemeName = "Windows8"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Location = New System.Drawing.Point(11, 97)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.NullText = "Address"
        Me.txtAddress.Size = New System.Drawing.Size(272, 20)
        Me.txtAddress.TabIndex = 212
        Me.txtAddress.ThemeName = "Windows8"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone.Location = New System.Drawing.Point(289, 123)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.NullText = "Phone"
        Me.txtPhone.Size = New System.Drawing.Size(233, 20)
        Me.txtPhone.TabIndex = 212
        Me.txtPhone.ThemeName = "Windows8"
        '
        'rgvItems
        '
        Me.rgvItems.Location = New System.Drawing.Point(572, 149)
        '
        '
        '
        Me.rgvItems.MasterTemplate.AllowAddNewRow = False
        Me.rgvItems.MasterTemplate.AllowCellContextMenu = False
        Me.rgvItems.MasterTemplate.AllowColumnReorder = False
        Me.rgvItems.MasterTemplate.AllowEditRow = False
        Me.rgvItems.MasterTemplate.EnableGrouping = False
        Me.rgvItems.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.rgvItems.Name = "rgvItems"
        Me.rgvItems.Size = New System.Drawing.Size(511, 385)
        Me.rgvItems.TabIndex = 213
        Me.rgvItems.ThemeName = "Windows8"
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnItems.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.Color.White
        Me.btnItems.Location = New System.Drawing.Point(934, 107)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(139, 36)
        Me.btnItems.TabIndex = 211
        Me.btnItems.Text = "Select Items"
        Me.btnItems.ThemeName = "MaterialPink"
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(16, 9)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(49, 21)
        Me.RadLabel6.TabIndex = 215
        Me.RadLabel6.Text = "RFQNo"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(462, 9)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(88, 24)
        Me.btnCreate.TabIndex = 216
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.ThemeName = "Windows8"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.RadPanel1.Controls.Add(Me.RadProgressBar1)
        Me.RadPanel1.Controls.Add(Me.RadPanel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel1.Location = New System.Drawing.Point(0, 544)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1096, 56)
        Me.RadPanel1.TabIndex = 217
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(572, 20)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(521, 24)
        Me.RadProgressBar1.TabIndex = 212
        Me.RadProgressBar1.ThemeName = "MaterialPink"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btnPrint)
        Me.RadPanel2.Controls.Add(Me.btnSaveMe)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(214, 56)
        Me.RadPanel2.TabIndex = 211
        CType(Me.RadPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(111, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 36)
        Me.btnPrint.TabIndex = 210
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ThemeName = "MaterialPink"
        '
        'btnSaveMe
        '
        Me.btnSaveMe.BackColor = System.Drawing.Color.Teal
        Me.btnSaveMe.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveMe.ForeColor = System.Drawing.Color.White
        Me.btnSaveMe.Location = New System.Drawing.Point(3, 8)
        Me.btnSaveMe.Name = "btnSaveMe"
        Me.btnSaveMe.Size = New System.Drawing.Size(102, 36)
        Me.btnSaveMe.TabIndex = 209
        Me.btnSaveMe.Text = "SAVE"
        Me.btnSaveMe.ThemeName = "MaterialPink"
        '
        'bwSaveRFQ
        '
        Me.bwSaveRFQ.WorkerReportsProgress = True
        '
        'bwRFQItems
        '
        Me.bwRFQItems.WorkerReportsProgress = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(556, 9)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(88, 24)
        Me.btnView.TabIndex = 219
        Me.btnView.Text = "VIEW"
        Me.btnView.ThemeName = "Windows8"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(11, 123)
        Me.txtName.Name = "txtName"
        Me.txtName.NullText = "Name"
        Me.txtName.Size = New System.Drawing.Size(272, 20)
        Me.txtName.TabIndex = 220
        Me.txtName.ThemeName = "Windows8"
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.Color.White
        Me.txtSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSection.Enabled = False
        Me.txtSection.Location = New System.Drawing.Point(840, 39)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(233, 20)
        Me.txtSection.TabIndex = 224
        Me.txtSection.ThemeName = "Windows8"
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.Color.White
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Enabled = False
        Me.txtDept.Location = New System.Drawing.Point(840, 13)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(233, 20)
        Me.txtDept.TabIndex = 223
        Me.txtDept.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RadLabel14.Location = New System.Drawing.Point(746, 41)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(39, 14)
        Me.RadLabel14.TabIndex = 222
        Me.RadLabel14.Text = "Section"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.RadLabel17.Location = New System.Drawing.Point(746, 14)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(58, 14)
        Me.RadLabel17.TabIndex = 221
        Me.RadLabel17.Text = "Department"
        Me.RadLabel17.ThemeName = "Windows8"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.BackColor = System.Drawing.Color.White
        Me.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPerson.Location = New System.Drawing.Point(289, 97)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.NullText = "CONTACT PERSON"
        Me.txtContactPerson.Size = New System.Drawing.Size(233, 20)
        Me.txtContactPerson.TabIndex = 225
        Me.txtContactPerson.ThemeName = "Windows8"
        '
        'ddlRFQNo
        '
        '
        'ddlRFQNo.NestedRadGridView
        '
        Me.ddlRFQNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlRFQNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlRFQNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlRFQNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlRFQNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlRFQNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlRFQNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlRFQNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlRFQNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlRFQNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition8
        Me.ddlRFQNo.EditorControl.Name = "NestedRadGridView"
        Me.ddlRFQNo.EditorControl.ReadOnly = True
        Me.ddlRFQNo.EditorControl.ShowGroupPanel = False
        Me.ddlRFQNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlRFQNo.EditorControl.TabIndex = 0
        Me.ddlRFQNo.Location = New System.Drawing.Point(71, 11)
        Me.ddlRFQNo.Name = "ddlRFQNo"
        Me.ddlRFQNo.Size = New System.Drawing.Size(385, 20)
        Me.ddlRFQNo.TabIndex = 218
        Me.ddlRFQNo.TabStop = False
        Me.ddlRFQNo.ThemeName = "Windows8"
        '
        'RadLabel9
        '
        Me.RadLabel9.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(746, 67)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(47, 16)
        Me.RadLabel9.TabIndex = 226
        Me.RadLabel9.Text = "Due Date"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'dtpDateNeeded
        '
        Me.dtpDateNeeded.BackColor = System.Drawing.Color.Transparent
        Me.dtpDateNeeded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateNeeded.Location = New System.Drawing.Point(840, 65)
        Me.dtpDateNeeded.Name = "dtpDateNeeded"
        Me.dtpDateNeeded.Size = New System.Drawing.Size(81, 20)
        Me.dtpDateNeeded.TabIndex = 227
        Me.dtpDateNeeded.TabStop = False
        Me.dtpDateNeeded.Text = "9/11/2014"
        Me.dtpDateNeeded.ThemeName = "Windows8"
        Me.dtpDateNeeded.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'FrmRFQPur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 600)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.dtpDateNeeded)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.ddlRFQNo)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.rgvItems)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.rgvSupplier)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ddlContactPerson)
        Me.Name = "FrmRFQPur"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RFQ PURCHASING"
        Me.ThemeName = "MaterialPink"
        CType(Me.ddlContactPerson.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlContactPerson.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlContactPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSupplier.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlRFQNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlRFQNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlRFQNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents ddlContactPerson As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvSupplier As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPhone As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rgvItems As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnItems As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCreate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnSaveMe As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwSaveRFQ As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents bwRFQItems As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnView As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtSection As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDept As Telerik.WinControls.UI.RadTextBox
    Private WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Private WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtContactPerson As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlRFQNo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpDateNeeded As Telerik.WinControls.UI.RadDateTimePicker
End Class


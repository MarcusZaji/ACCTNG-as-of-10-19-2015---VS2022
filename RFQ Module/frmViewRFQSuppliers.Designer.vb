<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmViewRFQSuppliers
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewRFQSuppliers))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbReport = New Telerik.WinControls.UI.CommandBarButton()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.txtQuote = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlClosed = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpDueDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlSection = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCompanyName = New Telerik.WinControls.UI.RadTextBox()
        Me.dtpDCreated = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtContact = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSupName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRFQNo = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClosed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDCreated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFQNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(893, 54)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.ThemeName = "Fluent"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbReport})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cbReport
        '
        Me.cbReport.DisplayName = "View Report"
        Me.cbReport.DrawText = True
        Me.cbReport.Image = CType(resources.GetObject("cbReport.Image"), System.Drawing.Image)
        Me.cbReport.Name = "cbReport"
        Me.cbReport.Text = "View Report"
        Me.cbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvList.Location = New System.Drawing.Point(0, 54)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(893, 589)
        Me.rgvList.TabIndex = 24
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.txtID)
        Me.RadPanel1.Controls.Add(Me.btnUpdate)
        Me.RadPanel1.Controls.Add(Me.RadLabel9)
        Me.RadPanel1.Controls.Add(Me.txtQuote)
        Me.RadPanel1.Controls.Add(Me.ddlClosed)
        Me.RadPanel1.Controls.Add(Me.RadLabel8)
        Me.RadPanel1.Controls.Add(Me.dtpDueDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel7)
        Me.RadPanel1.Controls.Add(Me.ddlSection)
        Me.RadPanel1.Controls.Add(Me.ddlDept)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.RadLabel21)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.txtCompanyName)
        Me.RadPanel1.Controls.Add(Me.dtpDCreated)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.txtAddress)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.txtContact)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.txtSupName)
        Me.RadPanel1.Controls.Add(Me.RadLabel13)
        Me.RadPanel1.Controls.Add(Me.txtRFQNo)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadPanel1.Location = New System.Drawing.Point(893, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(245, 643)
        Me.RadPanel1.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(19, 618)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(49, 20)
        Me.txtID.TabIndex = 411
        Me.txtID.ThemeName = "Windows8"
        Me.txtID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(152, 610)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 30)
        Me.btnUpdate.TabIndex = 410
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.ThemeName = "Windows8"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(19, 559)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(91, 21)
        Me.RadLabel9.TabIndex = 141
        Me.RadLabel9.Text = "Quotation No."
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'txtQuote
        '
        Me.txtQuote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuote.Location = New System.Drawing.Point(19, 586)
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.Size = New System.Drawing.Size(189, 20)
        Me.txtQuote.TabIndex = 140
        Me.txtQuote.ThemeName = "Windows8"
        '
        'ddlClosed
        '
        Me.ddlClosed.DropDownHeight = 200
        Me.ddlClosed.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlClosed.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "YES"
        RadListDataItem2.Text = "NO"
        Me.ddlClosed.Items.Add(RadListDataItem1)
        Me.ddlClosed.Items.Add(RadListDataItem2)
        Me.ddlClosed.Location = New System.Drawing.Point(19, 533)
        Me.ddlClosed.Name = "ddlClosed"
        Me.ddlClosed.Size = New System.Drawing.Size(189, 20)
        Me.ddlClosed.TabIndex = 408
        Me.ddlClosed.ThemeName = "Windows8"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(18, 506)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(67, 21)
        Me.RadLabel8.TabIndex = 409
        Me.RadLabel8.Text = "Close RFQ"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(17, 480)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpDueDate.TabIndex = 407
        Me.dtpDueDate.TabStop = False
        Me.dtpDueDate.Text = "9/11/2014"
        Me.dtpDueDate.ThemeName = "Windows8"
        Me.dtpDueDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(15, 453)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(62, 21)
        Me.RadLabel7.TabIndex = 406
        Me.RadLabel7.Text = "Due Date"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'ddlSection
        '
        Me.ddlSection.DropDownHeight = 200
        Me.ddlSection.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlSection.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlSection.Enabled = False
        Me.ddlSection.Location = New System.Drawing.Point(18, 427)
        Me.ddlSection.Name = "ddlSection"
        Me.ddlSection.Size = New System.Drawing.Size(189, 20)
        Me.ddlSection.TabIndex = 404
        Me.ddlSection.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownHeight = 200
        Me.ddlDept.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Enabled = False
        Me.ddlDept.Location = New System.Drawing.Point(16, 374)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 402
        Me.ddlDept.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(17, 400)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(50, 21)
        Me.RadLabel6.TabIndex = 405
        Me.RadLabel6.Text = "Section"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel21
        '
        Me.RadLabel21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel21.Location = New System.Drawing.Point(15, 347)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel21.TabIndex = 403
        Me.RadLabel21.Text = "Department"
        Me.RadLabel21.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(16, 294)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(102, 21)
        Me.RadLabel5.TabIndex = 139
        Me.RadLabel5.Text = "Company Name"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Location = New System.Drawing.Point(16, 321)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(189, 20)
        Me.txtCompanyName.TabIndex = 138
        Me.txtCompanyName.ThemeName = "Windows8"
        '
        'dtpDCreated
        '
        Me.dtpDCreated.Enabled = False
        Me.dtpDCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDCreated.Location = New System.Drawing.Point(16, 268)
        Me.dtpDCreated.Name = "dtpDCreated"
        Me.dtpDCreated.Size = New System.Drawing.Size(189, 20)
        Me.dtpDCreated.TabIndex = 137
        Me.dtpDCreated.TabStop = False
        Me.dtpDCreated.Text = "9/11/2014"
        Me.dtpDCreated.ThemeName = "Windows8"
        Me.dtpDCreated.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(15, 241)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(84, 21)
        Me.RadLabel4.TabIndex = 136
        Me.RadLabel4.Text = "Date Created"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(16, 171)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(54, 21)
        Me.RadLabel3.TabIndex = 134
        Me.RadLabel3.Text = "Address"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Location = New System.Drawing.Point(16, 198)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        '
        '
        '
        Me.txtAddress.RootElement.StretchVertically = True
        Me.txtAddress.Size = New System.Drawing.Size(189, 37)
        Me.txtAddress.TabIndex = 133
        Me.txtAddress.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(16, 118)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(53, 21)
        Me.RadLabel2.TabIndex = 132
        Me.RadLabel2.Text = "Contact"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtContact
        '
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.Location = New System.Drawing.Point(16, 145)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(189, 20)
        Me.txtContact.TabIndex = 131
        Me.txtContact.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(16, 65)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(94, 21)
        Me.RadLabel1.TabIndex = 130
        Me.RadLabel1.Text = "Supplier Name"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtSupName
        '
        Me.txtSupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupName.Location = New System.Drawing.Point(16, 92)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(189, 20)
        Me.txtSupName.TabIndex = 129
        Me.txtSupName.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(16, 12)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(79, 21)
        Me.RadLabel13.TabIndex = 128
        Me.RadLabel13.Text = "RFQ Pur. No"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'txtRFQNo
        '
        Me.txtRFQNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFQNo.Enabled = False
        Me.txtRFQNo.Location = New System.Drawing.Point(16, 39)
        Me.txtRFQNo.Name = "txtRFQNo"
        Me.txtRFQNo.ReadOnly = True
        Me.txtRFQNo.Size = New System.Drawing.Size(189, 20)
        Me.txtRFQNo.TabIndex = 127
        Me.txtRFQNo.ThemeName = "Windows8"
        '
        'FrmViewRFQSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 643)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmViewRFQSuppliers"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RFQ Suppliers"
        Me.ThemeName = "Material"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClosed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDCreated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFQNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbReport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtContact As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSupName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRFQNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpDCreated As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCompanyName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtQuote As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlClosed As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpDueDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlSection As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
End Class


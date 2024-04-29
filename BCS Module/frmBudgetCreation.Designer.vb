<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetCreation
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBudgetCreation))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.dtpMBudgeted = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSaveBC = New Telerik.WinControls.UI.RadButton()
        Me.btnFinalize = New Telerik.WinControls.UI.RadButton()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leRecordCount = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement4 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement5 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lblRevNum = New Telerik.WinControls.UI.RadLabel()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.mebAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.mebQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpSOU = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.mebJPY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.ddlProcess = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnConversion = New Telerik.WinControls.UI.RadButton()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.chkEdit = New Telerik.WinControls.UI.RadCheckBox()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.pbOlrayt = New System.Windows.Forms.ProgressBar()
        Me.btnGenBCReport = New Telerik.WinControls.UI.RadButton()
        Me.txtBCRefNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCLS = New Telerik.WinControls.UI.RadButton()
        Me.ddlClassCode = New Telerik.WinControls.UI.RadTextBox()
        Me.mebUnitPrice = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlYear = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnYV = New Telerik.WinControls.UI.RadButton()
        Me.pbOhYeah = New Telerik.WinControls.UI.RadProgressBar()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.ddlSubClassCode = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlSubClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txtActivityCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.btnMatrix = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSubRefNo = New Telerik.WinControls.UI.RadTextBox()
        Me.btnCalc = New Telerik.WinControls.UI.RadButton()
        Me.btnRefresh = New Telerik.WinControls.UI.RadButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMBudgeted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFinalize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSOU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebJPY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenBCReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBCRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClassCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnYV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOhYeah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSubClassCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSubClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivityCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(24, 444)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel4.TabIndex = 98
        Me.RadLabel4.Text = "Amount JPY"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(24, 278)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 21)
        Me.RadLabel3.TabIndex = 97
        Me.RadLabel3.Text = "Process"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(24, 158)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel2.TabIndex = 96
        Me.RadLabel2.Text = "Classification"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(24, 106)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 95
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(24, 470)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(108, 21)
        Me.RadLabel5.TabIndex = 101
        Me.RadLabel5.Text = "Month Budgeted"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(24, 496)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(57, 21)
        Me.RadLabel11.TabIndex = 106
        Me.RadLabel11.Text = "Remarks"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(24, 579)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 107
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownHeight = 200
        Me.ddlClass.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(192, 158)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(189, 20)
        Me.ddlClass.TabIndex = 4
        Me.ddlClass.ThemeName = "Windows8"
        '
        'dtpMBudgeted
        '
        Me.dtpMBudgeted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMBudgeted.Location = New System.Drawing.Point(192, 470)
        Me.dtpMBudgeted.Name = "dtpMBudgeted"
        Me.dtpMBudgeted.Size = New System.Drawing.Size(189, 20)
        Me.dtpMBudgeted.TabIndex = 11
        Me.dtpMBudgeted.TabStop = False
        Me.dtpMBudgeted.Text = "1/1/2015"
        Me.dtpMBudgeted.ThemeName = "Windows8"
        Me.dtpMBudgeted.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.Location = New System.Drawing.Point(192, 496)
        Me.txtRemarks.MaxLength = 100000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(189, 62)
        Me.txtRemarks.TabIndex = 15
        Me.txtRemarks.ThemeName = "Windows8"
        '
        'txtSignature
        '
        Me.txtSignature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSignature.Location = New System.Drawing.Point(192, 579)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(189, 20)
        Me.txtSignature.TabIndex = 16
        Me.txtSignature.ThemeName = "Windows8"
        '
        'btnSaveBC
        '
        Me.btnSaveBC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveBC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBC.Location = New System.Drawing.Point(387, 624)
        Me.btnSaveBC.Name = "btnSaveBC"
        Me.btnSaveBC.Size = New System.Drawing.Size(120, 40)
        Me.btnSaveBC.TabIndex = 17
        Me.btnSaveBC.Text = "&Save"
        Me.btnSaveBC.ThemeName = "Windows8"
        '
        'btnFinalize
        '
        Me.btnFinalize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalize.Location = New System.Drawing.Point(880, 624)
        Me.btnFinalize.Name = "btnFinalize"
        Me.btnFinalize.Size = New System.Drawing.Size(120, 40)
        Me.btnFinalize.TabIndex = 129
        Me.btnFinalize.Text = "&Finalize"
        Me.btnFinalize.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownHeight = 200
        Me.ddlDept.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Location = New System.Drawing.Point(192, 106)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 3
        Me.ddlDept.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'rgvList
        '
        Me.rgvList.Location = New System.Drawing.Point(387, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(876, 618)
        Me.rgvList.TabIndex = 21
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Records Found"
        Me.RadLabelElement1.AccessibleName = "Records Found"
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadLabelElement1.Text = "User Count"
        Me.RadLabelElement1.TextWrap = True
        '
        'leRecordCount
        '
        Me.leRecordCount.Name = "leRecordCount"
        Me.leRecordCount.Text = "0"
        Me.leRecordCount.TextWrap = True
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.AccessibleDescription = "Records Found"
        Me.RadLabelElement2.AccessibleName = "Records Found"
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadLabelElement2.Text = "User Count"
        Me.RadLabelElement2.TextWrap = True
        '
        'RadLabelElement3
        '
        Me.RadLabelElement3.Name = "RadLabelElement3"
        Me.RadLabelElement3.Text = "0"
        Me.RadLabelElement3.TextWrap = True
        '
        'RadLabelElement4
        '
        Me.RadLabelElement4.AccessibleDescription = "Records Found"
        Me.RadLabelElement4.AccessibleName = "Records Found"
        Me.RadLabelElement4.Name = "RadLabelElement4"
        Me.RadLabelElement4.Text = "User Count"
        Me.RadLabelElement4.TextWrap = True
        '
        'RadLabelElement5
        '
        Me.RadLabelElement5.Name = "RadLabelElement5"
        Me.RadLabelElement5.Text = "0"
        Me.RadLabelElement5.TextWrap = True
        '
        'lblRevNum
        '
        Me.lblRevNum.Location = New System.Drawing.Point(425, 64)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(2, 2)
        Me.lblRevNum.TabIndex = 127
        Me.lblRevNum.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(261, 605)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear Field"
        Me.btnClear.ThemeName = "Windows8"
        '
        'mebAmount
        '
        Me.mebAmount.Location = New System.Drawing.Point(192, 418)
        Me.mebAmount.Mask = "N2"
        Me.mebAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebAmount.Name = "mebAmount"
        Me.mebAmount.ReadOnly = True
        Me.mebAmount.Size = New System.Drawing.Size(189, 20)
        Me.mebAmount.TabIndex = 10
        Me.mebAmount.TabStop = False
        Me.mebAmount.Tag = "C"
        Me.mebAmount.Text = "0.00"
        Me.mebAmount.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(24, 211)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel14.TabIndex = 174
        Me.RadLabel14.Text = "Description"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(24, 304)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel15.TabIndex = 175
        Me.RadLabel15.Text = "Quantity"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'ddlUOM
        '
        Me.ddlUOM.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlUOM.Location = New System.Drawing.Point(192, 330)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(189, 20)
        Me.ddlUOM.TabIndex = 8
        Me.ddlUOM.ThemeName = "Windows8"
        '
        'RadLabel16
        '
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(24, 330)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel16.TabIndex = 177
        Me.RadLabel16.Text = "Unit of Measurement"
        Me.RadLabel16.ThemeName = "Windows8"
        '
        'mebQTY
        '
        Me.mebQTY.Location = New System.Drawing.Point(192, 304)
        Me.mebQTY.Mask = "N2"
        Me.mebQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebQTY.Name = "mebQTY"
        Me.mebQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebQTY.TabIndex = 7
        Me.mebQTY.TabStop = False
        Me.mebQTY.Tag = "C"
        Me.mebQTY.Text = "0.00"
        Me.mebQTY.ThemeName = "Windows8"
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel17.Location = New System.Drawing.Point(24, 356)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(76, 21)
        Me.RadLabel17.TabIndex = 179
        Me.RadLabel17.Text = "Start of Use"
        Me.RadLabel17.ThemeName = "Windows8"
        '
        'dtpSOU
        '
        Me.dtpSOU.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSOU.Location = New System.Drawing.Point(192, 356)
        Me.dtpSOU.Name = "dtpSOU"
        Me.dtpSOU.Size = New System.Drawing.Size(189, 20)
        Me.dtpSOU.TabIndex = 9
        Me.dtpSOU.TabStop = False
        Me.dtpSOU.Text = "1/1/2015"
        Me.dtpSOU.ThemeName = "Windows8"
        Me.dtpSOU.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(24, 418)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(105, 21)
        Me.RadLabel19.TabIndex = 203
        Me.RadLabel19.Text = "Original Amount"
        Me.RadLabel19.ThemeName = "Windows8"
        '
        'mebJPY
        '
        Me.mebJPY.Location = New System.Drawing.Point(192, 444)
        Me.mebJPY.Mask = "N2"
        Me.mebJPY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebJPY.Name = "mebJPY"
        Me.mebJPY.ReadOnly = True
        Me.mebJPY.Size = New System.Drawing.Size(189, 20)
        Me.mebJPY.TabIndex = 204
        Me.mebJPY.TabStop = False
        Me.mebJPY.Tag = "C"
        Me.mebJPY.Text = "0.00"
        Me.mebJPY.ThemeName = "Windows8"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PHP"
        RadListDataItem2.Text = "JPY"
        RadListDataItem3.Text = "USD"
        Me.ddlCurrency.Items.Add(RadListDataItem1)
        Me.ddlCurrency.Items.Add(RadListDataItem2)
        Me.ddlCurrency.Items.Add(RadListDataItem3)
        Me.ddlCurrency.Location = New System.Drawing.Point(192, 392)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(51, 20)
        Me.ddlCurrency.TabIndex = 205
        Me.ddlCurrency.ThemeName = "Windows8"
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(114, 606)
        Me.lblUserlvl.Name = "lblUserlvl"
        Me.lblUserlvl.Size = New System.Drawing.Size(46, 21)
        Me.lblUserlvl.TabIndex = 214
        Me.lblUserlvl.Text = "Userlvl"
        Me.lblUserlvl.ThemeName = "Windows8"
        Me.lblUserlvl.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(66, 606)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 21)
        Me.lblUserID.TabIndex = 213
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.ThemeName = "Windows8"
        Me.lblUserID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(24, 606)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 212
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Windows8"
        Me.lblDept.Visible = False
        '
        'ddlProcess
        '
        Me.ddlProcess.DropDownHeight = 200
        Me.ddlProcess.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlProcess.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlProcess.Location = New System.Drawing.Point(192, 278)
        Me.ddlProcess.Name = "ddlProcess"
        Me.ddlProcess.Size = New System.Drawing.Size(189, 20)
        Me.ddlProcess.TabIndex = 6
        Me.ddlProcess.ThemeName = "Windows8"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(334, 25)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblVersion.TabIndex = 339
        Me.lblVersion.Visible = False
        '
        'btnConversion
        '
        Me.btnConversion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConversion.Location = New System.Drawing.Point(639, 624)
        Me.btnConversion.Name = "btnConversion"
        Me.btnConversion.Size = New System.Drawing.Size(120, 40)
        Me.btnConversion.TabIndex = 340
        Me.btnConversion.Text = "Setting"
        Me.btnConversion.ThemeName = "Windows8"
        Me.btnConversion.Visible = False
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.Location = New System.Drawing.Point(192, 210)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 62)
        Me.txtDesc.TabIndex = 341
        Me.txtDesc.ThemeName = "Windows8"
        '
        'chkEdit
        '
        Me.chkEdit.Location = New System.Drawing.Point(192, 20)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(42, 18)
        Me.chkEdit.TabIndex = 342
        Me.chkEdit.Text = "Edit"
        Me.chkEdit.ThemeName = "Windows8"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(513, 624)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 40)
        Me.btnDelete.TabIndex = 343
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.ThemeName = "Windows8"
        '
        'pbOlrayt
        '
        Me.pbOlrayt.Location = New System.Drawing.Point(66, 668)
        Me.pbOlrayt.Name = "pbOlrayt"
        Me.pbOlrayt.Size = New System.Drawing.Size(311, 18)
        Me.pbOlrayt.Step = 1
        Me.pbOlrayt.TabIndex = 344
        Me.pbOlrayt.UseWaitCursor = True
        Me.pbOlrayt.Visible = False
        '
        'btnGenBCReport
        '
        Me.btnGenBCReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenBCReport.Location = New System.Drawing.Point(1132, 624)
        Me.btnGenBCReport.Name = "btnGenBCReport"
        Me.btnGenBCReport.Size = New System.Drawing.Size(120, 40)
        Me.btnGenBCReport.TabIndex = 345
        Me.btnGenBCReport.Text = "Report"
        Me.btnGenBCReport.ThemeName = "Windows8"
        '
        'txtBCRefNo
        '
        Me.txtBCRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBCRefNo.Location = New System.Drawing.Point(192, 80)
        Me.txtBCRefNo.Name = "txtBCRefNo"
        Me.txtBCRefNo.ReadOnly = True
        Me.txtBCRefNo.Size = New System.Drawing.Size(163, 20)
        Me.txtBCRefNo.TabIndex = 346
        Me.txtBCRefNo.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(24, 80)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(123, 21)
        Me.RadLabel6.TabIndex = 347
        Me.RadLabel6.Text = "Sub Budget Ref. No"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'btnCLS
        '
        Me.btnCLS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCLS.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLS.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCLS.Location = New System.Drawing.Point(354, 80)
        Me.btnCLS.Name = "btnCLS"
        Me.btnCLS.Size = New System.Drawing.Size(27, 20)
        Me.btnCLS.TabIndex = 348
        Me.btnCLS.Text = "New"
        Me.btnCLS.ThemeName = "Windows8"
        '
        'ddlClassCode
        '
        Me.ddlClassCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ddlClassCode.Location = New System.Drawing.Point(143, 158)
        Me.ddlClassCode.Name = "ddlClassCode"
        Me.ddlClassCode.ReadOnly = True
        Me.ddlClassCode.Size = New System.Drawing.Size(43, 20)
        Me.ddlClassCode.TabIndex = 349
        Me.ddlClassCode.ThemeName = "Windows8"
        Me.ddlClassCode.Visible = False
        '
        'mebUnitPrice
        '
        Me.mebUnitPrice.Location = New System.Drawing.Point(242, 392)
        Me.mebUnitPrice.Mask = "N2"
        Me.mebUnitPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebUnitPrice.Name = "mebUnitPrice"
        Me.mebUnitPrice.Size = New System.Drawing.Size(139, 20)
        Me.mebUnitPrice.TabIndex = 350
        Me.mebUnitPrice.TabStop = False
        Me.mebUnitPrice.Tag = "C"
        Me.mebUnitPrice.Text = "0.00"
        Me.mebUnitPrice.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(24, 392)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(64, 21)
        Me.RadLabel7.TabIndex = 351
        Me.RadLabel7.Text = "Unit Price"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'ddlYear
        '
        Me.ddlYear.DropDownHeight = 200
        Me.ddlYear.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlYear.Location = New System.Drawing.Point(240, 18)
        Me.ddlYear.Name = "ddlYear"
        Me.ddlYear.Size = New System.Drawing.Size(68, 20)
        Me.ddlYear.TabIndex = 352
        Me.ddlYear.ThemeName = "Windows8"
        '
        'btnYV
        '
        Me.btnYV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYV.Location = New System.Drawing.Point(314, 18)
        Me.btnYV.Name = "btnYV"
        Me.btnYV.Size = New System.Drawing.Size(67, 20)
        Me.btnYV.TabIndex = 353
        Me.btnYV.Text = "View &Year"
        Me.btnYV.ThemeName = "Windows8"
        '
        'pbOhYeah
        '
        Me.pbOhYeah.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pbOhYeah.ForeColor = System.Drawing.Color.White
        Me.pbOhYeah.Location = New System.Drawing.Point(66, 669)
        Me.pbOhYeah.Name = "pbOhYeah"
        Me.pbOhYeah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbOhYeah.SeparatorWidth = 2
        Me.pbOhYeah.Size = New System.Drawing.Size(311, 15)
        Me.pbOhYeah.Step = 1
        Me.pbOhYeah.TabIndex = 354
        Me.pbOhYeah.Text = "Loading..."
        Me.pbOhYeah.ThemeName = "TelerikMetroBlue"
        Me.pbOhYeah.Value2 = 1
        Me.pbOhYeah.Visible = False
        '
        'ddlSubClassCode
        '
        Me.ddlSubClassCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ddlSubClassCode.Location = New System.Drawing.Point(143, 184)
        Me.ddlSubClassCode.Name = "ddlSubClassCode"
        Me.ddlSubClassCode.ReadOnly = True
        Me.ddlSubClassCode.Size = New System.Drawing.Size(43, 20)
        Me.ddlSubClassCode.TabIndex = 357
        Me.ddlSubClassCode.ThemeName = "Windows8"
        Me.ddlSubClassCode.Visible = False
        '
        'ddlSubClass
        '
        Me.ddlSubClass.DropDownHeight = 200
        Me.ddlSubClass.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlSubClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlSubClass.Location = New System.Drawing.Point(192, 184)
        Me.ddlSubClass.Name = "ddlSubClass"
        Me.ddlSubClass.Size = New System.Drawing.Size(189, 20)
        Me.ddlSubClass.TabIndex = 355
        Me.ddlSubClass.ThemeName = "Windows8"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(24, 184)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(110, 21)
        Me.RadLabel8.TabIndex = 356
        Me.RadLabel8.Text = "Sub Classification"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'txtActivityCode
        '
        Me.txtActivityCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActivityCode.Location = New System.Drawing.Point(192, 132)
        Me.txtActivityCode.Name = "txtActivityCode"
        Me.txtActivityCode.ReadOnly = True
        Me.txtActivityCode.Size = New System.Drawing.Size(189, 20)
        Me.txtActivityCode.TabIndex = 359
        Me.txtActivityCode.ThemeName = "Windows8"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(24, 132)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(85, 21)
        Me.RadLabel9.TabIndex = 358
        Me.RadLabel9.Text = "Activity Code"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'btnMatrix
        '
        Me.btnMatrix.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnMatrix.Location = New System.Drawing.Point(1006, 624)
        Me.btnMatrix.Name = "btnMatrix"
        Me.btnMatrix.Size = New System.Drawing.Size(120, 40)
        Me.btnMatrix.TabIndex = 360
        Me.btnMatrix.Text = "Matrix for &Expenses"
        Me.btnMatrix.ThemeName = "Windows8"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(24, 54)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(135, 21)
        Me.RadLabel10.TabIndex = 362
        Me.RadLabel10.Text = "Major Budget Ref. No"
        Me.RadLabel10.ThemeName = "Windows8"
        '
        'txtSubRefNo
        '
        Me.txtSubRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubRefNo.Location = New System.Drawing.Point(192, 54)
        Me.txtSubRefNo.Name = "txtSubRefNo"
        Me.txtSubRefNo.ReadOnly = True
        Me.txtSubRefNo.Size = New System.Drawing.Size(189, 20)
        Me.txtSubRefNo.TabIndex = 361
        Me.txtSubRefNo.ThemeName = "Windows8"
        '
        'btnCalc
        '
        Me.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Image = Global.ACCTNG.My.Resources.Resources.Calc
        Me.btnCalc.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCalc.Location = New System.Drawing.Point(143, 605)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(43, 40)
        Me.btnCalc.TabIndex = 317
        Me.btnCalc.ThemeName = "Windows8"
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.ACCTNG.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(192, 605)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(63, 40)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(0, 651)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 200
        '
        'frmBudgetCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1210, 856)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.btnMatrix)
        Me.Controls.Add(Me.txtActivityCode)
        Me.Controls.Add(Me.txtSubRefNo)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.ddlSubClassCode)
        Me.Controls.Add(Me.ddlSubClass)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.pbOhYeah)
        Me.Controls.Add(Me.btnYV)
        Me.Controls.Add(Me.ddlYear)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.mebUnitPrice)
        Me.Controls.Add(Me.ddlClassCode)
        Me.Controls.Add(Me.btnCLS)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.txtBCRefNo)
        Me.Controls.Add(Me.btnGenBCReport)
        Me.Controls.Add(Me.pbOlrayt)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.chkEdit)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnConversion)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.mebJPY)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.btnSaveBC)
        Me.Controls.Add(Me.dtpSOU)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.mebQTY)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.ddlUOM)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.mebAmount)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRevNum)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.dtpMBudgeted)
        Me.Controls.Add(Me.ddlProcess)
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnFinalize)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBudgetCreation"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Create Budget"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMBudgeted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFinalize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSOU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebJPY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConversion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenBCReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBCRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClassCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnYV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOhYeah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSubClassCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSubClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivityCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpMBudgeted As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSaveBC As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leRecordCount As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement4 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement5 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lblRevNum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnFinalize As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents mebAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents btnRefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpSOU As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebJPY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCalc As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlProcess As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnConversion As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents chkEdit As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents pbOlrayt As System.Windows.Forms.ProgressBar
    Friend WithEvents btnGenBCReport As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtBCRefNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCLS As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlClassCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mebUnitPrice As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlYear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnYV As Telerik.WinControls.UI.RadButton
    Friend WithEvents pbOhYeah As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents ddlSubClassCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlSubClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtActivityCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnMatrix As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSubRefNo As Telerik.WinControls.UI.RadTextBox
End Class


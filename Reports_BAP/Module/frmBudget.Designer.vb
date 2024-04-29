<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBudget))
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBRNum = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlBRNum = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlProcess = New Telerik.WinControls.UI.RadDropDownList()
        Me.dtpMBudgeted = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpMForecasted = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.ddlStat = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSaveBud = New Telerik.WinControls.UI.RadButton()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.chkRevision = New Telerik.WinControls.UI.RadCheckBox()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.mebRemBal = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leRecordCount = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement4 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement5 = New Telerik.WinControls.UI.RadLabelElement()
        Me.txtBudRevNum = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.lblRevNum = New Telerik.WinControls.UI.RadLabel()
        Me.rgvRevList = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadRevList = New System.ComponentModel.BackgroundWorker()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.mebAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.btnRefresh = New Telerik.WinControls.UI.RadButton()
        Me.btnCR = New Telerik.WinControls.UI.RadButton()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.mebQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpSOU = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.mebRemQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.mebYEN = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnUpd8dRep = New Telerik.WinControls.UI.RadButton()
        Me.btnOI = New Telerik.WinControls.UI.RadButton()
        Me.btnDI = New Telerik.WinControls.UI.RadButton()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMBudgeted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMForecasted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRevision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemBal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBudRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvRevList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvRevList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSOU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebYEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpd8dRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(3, 764)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 200
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(136, 56)
        Me.RadLabel8.TabIndex = 89
        Me.RadLabel8.Text = "Budget"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'txtBRNum
        '
        Me.txtBRNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBRNum.Location = New System.Drawing.Point(238, 114)
        Me.txtBRNum.Name = "txtBRNum"
        Me.txtBRNum.Size = New System.Drawing.Size(189, 20)
        Me.txtBRNum.TabIndex = 2
        Me.txtBRNum.ThemeName = "Windows8"
        '
        'ddlBRNum
        '
        Me.ddlBRNum.Location = New System.Drawing.Point(238, 114)
        Me.ddlBRNum.Name = "ddlBRNum"
        Me.ddlBRNum.Size = New System.Drawing.Size(189, 20)
        Me.ddlBRNum.TabIndex = 120
        Me.ddlBRNum.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(24, 114)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel6.TabIndex = 99
        Me.RadLabel6.Text = "Budget Reference Number"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(24, 421)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel4.TabIndex = 98
        Me.RadLabel4.Text = "Amount JPY"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(24, 253)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 21)
        Me.RadLabel3.TabIndex = 97
        Me.RadLabel3.Text = "Process"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(24, 200)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel2.TabIndex = 96
        Me.RadLabel2.Text = "Classification"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(24, 173)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 95
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(24, 461)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(108, 21)
        Me.RadLabel5.TabIndex = 101
        Me.RadLabel5.Text = "Month Budgeted"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(24, 487)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(114, 21)
        Me.RadLabel7.TabIndex = 103
        Me.RadLabel7.Text = "Month Forecasted"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(24, 535)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel9.TabIndex = 104
        Me.RadLabel9.Text = "Status"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(24, 539)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(119, 21)
        Me.RadLabel10.TabIndex = 105
        Me.RadLabel10.Text = "Remaining Balance"
        Me.RadLabel10.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(24, 565)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(189, 21)
        Me.RadLabel11.TabIndex = 106
        Me.RadLabel11.Text = "Remarks : Reasons for Revision"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(24, 633)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 107
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(238, 200)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(189, 20)
        Me.ddlClass.TabIndex = 4
        Me.ddlClass.ThemeName = "Windows8"
        '
        'ddlProcess
        '
        Me.ddlProcess.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlProcess.Location = New System.Drawing.Point(238, 253)
        Me.ddlProcess.Name = "ddlProcess"
        Me.ddlProcess.Size = New System.Drawing.Size(189, 20)
        Me.ddlProcess.TabIndex = 6
        Me.ddlProcess.ThemeName = "Windows8"
        '
        'dtpMBudgeted
        '
        Me.dtpMBudgeted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMBudgeted.Location = New System.Drawing.Point(238, 461)
        Me.dtpMBudgeted.Name = "dtpMBudgeted"
        Me.dtpMBudgeted.Size = New System.Drawing.Size(189, 20)
        Me.dtpMBudgeted.TabIndex = 11
        Me.dtpMBudgeted.TabStop = False
        Me.dtpMBudgeted.Text = "9/11/2014"
        Me.dtpMBudgeted.ThemeName = "Windows8"
        Me.dtpMBudgeted.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'dtpMForecasted
        '
        Me.dtpMForecasted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMForecasted.Location = New System.Drawing.Point(238, 487)
        Me.dtpMForecasted.Name = "dtpMForecasted"
        Me.dtpMForecasted.Size = New System.Drawing.Size(189, 20)
        Me.dtpMForecasted.TabIndex = 12
        Me.dtpMForecasted.TabStop = False
        Me.dtpMForecasted.Text = "9/11/2014"
        Me.dtpMForecasted.ThemeName = "Windows8"
        Me.dtpMForecasted.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'ddlStat
        '
        Me.ddlStat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "OPEN"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "CLOSE"
        RadListDataItem2.TextWrap = True
        Me.ddlStat.Items.Add(RadListDataItem1)
        Me.ddlStat.Items.Add(RadListDataItem2)
        Me.ddlStat.Location = New System.Drawing.Point(238, 513)
        Me.ddlStat.Name = "ddlStat"
        Me.ddlStat.Size = New System.Drawing.Size(189, 20)
        Me.ddlStat.TabIndex = 13
        Me.ddlStat.ThemeName = "Windows8"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.Location = New System.Drawing.Point(238, 565)
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
        Me.txtSignature.Location = New System.Drawing.Point(238, 633)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(189, 20)
        Me.txtSignature.TabIndex = 16
        Me.txtSignature.ThemeName = "Windows8"
        '
        'btnSaveBud
        '
        Me.btnSaveBud.Enabled = False
        Me.btnSaveBud.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBud.Location = New System.Drawing.Point(1145, 764)
        Me.btnSaveBud.Name = "btnSaveBud"
        Me.btnSaveBud.Size = New System.Drawing.Size(120, 40)
        Me.btnSaveBud.TabIndex = 17
        Me.btnSaveBud.Text = "&Save"
        Me.btnSaveBud.ThemeName = "Windows8"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1145, 764)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 40)
        Me.btnUpdate.TabIndex = 129
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.ThemeName = "Windows8"
        Me.btnUpdate.Visible = False
        '
        'chkRevision
        '
        Me.chkRevision.Location = New System.Drawing.Point(238, 64)
        Me.chkRevision.Name = "chkRevision"
        Me.chkRevision.Size = New System.Drawing.Size(65, 18)
        Me.chkRevision.TabIndex = 121
        Me.chkRevision.Text = "Revision"
        Me.chkRevision.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Location = New System.Drawing.Point(238, 173)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 3
        Me.ddlDept.ThemeName = "Windows8"
        '
        'mebRemBal
        '
        Me.mebRemBal.Location = New System.Drawing.Point(238, 539)
        Me.mebRemBal.Mask = "N2"
        Me.mebRemBal.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemBal.Name = "mebRemBal"
        Me.mebRemBal.ReadOnly = True
        Me.mebRemBal.Size = New System.Drawing.Size(189, 20)
        Me.mebRemBal.TabIndex = 14
        Me.mebRemBal.TabStop = False
        Me.mebRemBal.Text = "0.00"
        Me.mebRemBal.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        '
        'rgvList
        '
        Me.rgvList.Location = New System.Drawing.Point(433, 0)
        '
        'rgvList
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(841, 482)
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
        Me.RadLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'leRecordCount
        '
        Me.leRecordCount.AccessibleDescription = "0"
        Me.leRecordCount.AccessibleName = "0"
        Me.leRecordCount.Name = "leRecordCount"
        Me.leRecordCount.Text = "0"
        Me.leRecordCount.TextWrap = True
        Me.leRecordCount.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.AccessibleDescription = "Records Found"
        Me.RadLabelElement2.AccessibleName = "Records Found"
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadLabelElement2.Text = "User Count"
        Me.RadLabelElement2.TextWrap = True
        Me.RadLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadLabelElement3
        '
        Me.RadLabelElement3.AccessibleDescription = "0"
        Me.RadLabelElement3.AccessibleName = "0"
        Me.RadLabelElement3.Name = "RadLabelElement3"
        Me.RadLabelElement3.Text = "0"
        Me.RadLabelElement3.TextWrap = True
        Me.RadLabelElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadLabelElement4
        '
        Me.RadLabelElement4.AccessibleDescription = "Records Found"
        Me.RadLabelElement4.AccessibleName = "Records Found"
        Me.RadLabelElement4.Name = "RadLabelElement4"
        Me.RadLabelElement4.Text = "User Count"
        Me.RadLabelElement4.TextWrap = True
        Me.RadLabelElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadLabelElement5
        '
        Me.RadLabelElement5.AccessibleDescription = "0"
        Me.RadLabelElement5.AccessibleName = "0"
        Me.RadLabelElement5.Name = "RadLabelElement5"
        Me.RadLabelElement5.Text = "0"
        Me.RadLabelElement5.TextWrap = True
        Me.RadLabelElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'txtBudRevNum
        '
        Me.txtBudRevNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBudRevNum.Enabled = False
        Me.txtBudRevNum.Location = New System.Drawing.Point(238, 88)
        Me.txtBudRevNum.Name = "txtBudRevNum"
        Me.txtBudRevNum.ReadOnly = True
        Me.txtBudRevNum.Size = New System.Drawing.Size(189, 20)
        Me.txtBudRevNum.TabIndex = 1
        Me.txtBudRevNum.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(24, 88)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(108, 21)
        Me.RadLabel13.TabIndex = 126
        Me.RadLabel13.Text = "Revision Number"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'lblRevNum
        '
        Me.lblRevNum.Location = New System.Drawing.Point(425, 64)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(2, 2)
        Me.lblRevNum.TabIndex = 127
        Me.lblRevNum.Visible = False
        '
        'rgvRevList
        '
        Me.rgvRevList.Location = New System.Drawing.Point(433, 487)
        '
        'rgvRevList
        '
        Me.rgvRevList.MasterTemplate.AllowColumnReorder = False
        Me.rgvRevList.MasterTemplate.AllowDeleteRow = False
        Me.rgvRevList.MasterTemplate.EnableGrouping = False
        Me.rgvRevList.Name = "rgvRevList"
        Me.rgvRevList.Size = New System.Drawing.Size(841, 262)
        Me.rgvRevList.TabIndex = 128
        Me.rgvRevList.Text = "22"
        Me.rgvRevList.ThemeName = "Windows8"
        '
        'bwLoadRevList
        '
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(307, 659)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear Field"
        Me.btnClear.ThemeName = "Windows8"
        '
        'mebAmount
        '
        Me.mebAmount.Location = New System.Drawing.Point(288, 395)
        Me.mebAmount.Mask = "N2"
        Me.mebAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebAmount.Name = "mebAmount"
        Me.mebAmount.Size = New System.Drawing.Size(139, 20)
        Me.mebAmount.TabIndex = 10
        Me.mebAmount.TabStop = False
        Me.mebAmount.Tag = "C"
        Me.mebAmount.Text = "0.00"
        Me.mebAmount.ThemeName = "Windows8"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.ACCTNG.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(238, 659)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(63, 40)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.ThemeName = "Windows8"
        '
        'btnCR
        '
        Me.btnCR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCR.Location = New System.Drawing.Point(1019, 764)
        Me.btnCR.Name = "btnCR"
        Me.btnCR.Size = New System.Drawing.Size(120, 40)
        Me.btnCR.TabIndex = 20
        Me.btnCR.Text = "&Create Report"
        Me.btnCR.ThemeName = "Windows8"
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.Location = New System.Drawing.Point(238, 226)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 21)
        Me.txtDesc.TabIndex = 5
        Me.txtDesc.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(24, 226)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel14.TabIndex = 174
        Me.RadLabel14.Text = "Description"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(24, 279)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel15.TabIndex = 175
        Me.RadLabel15.Text = "Quantity"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'ddlUOM
        '
        Me.ddlUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "PCS"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "LOT"
        RadListDataItem4.TextWrap = True
        Me.ddlUOM.Items.Add(RadListDataItem3)
        Me.ddlUOM.Items.Add(RadListDataItem4)
        Me.ddlUOM.Location = New System.Drawing.Point(238, 331)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(189, 20)
        Me.ddlUOM.TabIndex = 8
        Me.ddlUOM.ThemeName = "Windows8"
        '
        'RadLabel16
        '
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(24, 331)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel16.TabIndex = 177
        Me.RadLabel16.Text = "Unit of Measurement"
        Me.RadLabel16.ThemeName = "Windows8"
        '
        'mebQTY
        '
        Me.mebQTY.Location = New System.Drawing.Point(238, 279)
        Me.mebQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebQTY.Name = "mebQTY"
        Me.mebQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebQTY.TabIndex = 7
        Me.mebQTY.TabStop = False
        Me.mebQTY.Tag = "C"
        Me.mebQTY.Text = "0"
        Me.mebQTY.ThemeName = "Windows8"
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel17.Location = New System.Drawing.Point(24, 357)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(76, 21)
        Me.RadLabel17.TabIndex = 179
        Me.RadLabel17.Text = "Start of Use"
        Me.RadLabel17.ThemeName = "Windows8"
        '
        'dtpSOU
        '
        Me.dtpSOU.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSOU.Location = New System.Drawing.Point(238, 357)
        Me.dtpSOU.Name = "dtpSOU"
        Me.dtpSOU.Size = New System.Drawing.Size(189, 20)
        Me.dtpSOU.TabIndex = 9
        Me.dtpSOU.TabStop = False
        Me.dtpSOU.Text = "9/11/2014"
        Me.dtpSOU.ThemeName = "Windows8"
        Me.dtpSOU.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'mebRemQTY
        '
        Me.mebRemQTY.Location = New System.Drawing.Point(238, 305)
        Me.mebRemQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemQTY.Name = "mebRemQTY"
        Me.mebRemQTY.ReadOnly = True
        Me.mebRemQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebRemQTY.TabIndex = 201
        Me.mebRemQTY.TabStop = False
        Me.mebRemQTY.Tag = "C"
        Me.mebRemQTY.Text = "0"
        Me.mebRemQTY.ThemeName = "Windows8"
        '
        'RadLabel18
        '
        Me.RadLabel18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel18.Location = New System.Drawing.Point(24, 305)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(124, 21)
        Me.RadLabel18.TabIndex = 202
        Me.RadLabel18.Text = "Remaining Quantity"
        Me.RadLabel18.ThemeName = "Windows8"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(24, 395)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(105, 21)
        Me.RadLabel19.TabIndex = 203
        Me.RadLabel19.Text = "Original Amount"
        Me.RadLabel19.ThemeName = "Windows8"
        '
        'mebYEN
        '
        Me.mebYEN.Location = New System.Drawing.Point(238, 421)
        Me.mebYEN.Mask = "N2"
        Me.mebYEN.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebYEN.Name = "mebYEN"
        Me.mebYEN.ReadOnly = True
        Me.mebYEN.Size = New System.Drawing.Size(189, 20)
        Me.mebYEN.TabIndex = 204
        Me.mebYEN.TabStop = False
        Me.mebYEN.Tag = "C"
        Me.mebYEN.Text = "0.00"
        Me.mebYEN.ThemeName = "Windows8"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem5.Text = "PHP"
        RadListDataItem5.TextWrap = True
        RadListDataItem6.Text = "YEN"
        RadListDataItem6.TextWrap = True
        RadListDataItem7.Text = "USD"
        RadListDataItem7.TextWrap = True
        Me.ddlCurrency.Items.Add(RadListDataItem5)
        Me.ddlCurrency.Items.Add(RadListDataItem6)
        Me.ddlCurrency.Items.Add(RadListDataItem7)
        Me.ddlCurrency.Location = New System.Drawing.Point(238, 395)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(51, 20)
        Me.ddlCurrency.TabIndex = 205
        Me.ddlCurrency.ThemeName = "Windows8"
        '
        'btnUpd8dRep
        '
        Me.btnUpd8dRep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpd8dRep.Location = New System.Drawing.Point(893, 764)
        Me.btnUpd8dRep.Name = "btnUpd8dRep"
        Me.btnUpd8dRep.Size = New System.Drawing.Size(120, 40)
        Me.btnUpd8dRep.TabIndex = 206
        Me.btnUpd8dRep.Text = "Updated Report"
        Me.btnUpd8dRep.ThemeName = "Windows8"
        '
        'btnOI
        '
        Me.btnOI.Enabled = False
        Me.btnOI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOI.Location = New System.Drawing.Point(238, 140)
        Me.btnOI.Name = "btnOI"
        Me.btnOI.Size = New System.Drawing.Size(93, 27)
        Me.btnOI.TabIndex = 207
        Me.btnOI.Text = "&Ordered Items"
        Me.btnOI.ThemeName = "Windows8"
        '
        'btnDI
        '
        Me.btnDI.Enabled = False
        Me.btnDI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDI.Location = New System.Drawing.Point(337, 140)
        Me.btnDI.Name = "btnDI"
        Me.btnDI.Size = New System.Drawing.Size(90, 27)
        Me.btnDI.TabIndex = 208
        Me.btnDI.Text = "&Delivered Items"
        Me.btnDI.ThemeName = "Windows8"
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(183, 633)
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
        Me.lblUserID.Location = New System.Drawing.Point(135, 633)
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
        Me.lblDept.Location = New System.Drawing.Point(93, 633)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 212
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Windows8"
        Me.lblDept.Visible = False
        '
        'frmBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1277, 823)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.btnDI)
        Me.Controls.Add(Me.btnOI)
        Me.Controls.Add(Me.btnUpd8dRep)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.mebYEN)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.RadLabel18)
        Me.Controls.Add(Me.mebRemQTY)
        Me.Controls.Add(Me.btnSaveBud)
        Me.Controls.Add(Me.dtpSOU)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.mebQTY)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.ddlUOM)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnCR)
        Me.Controls.Add(Me.chkRevision)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.mebAmount)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRevNum)
        Me.Controls.Add(Me.rgvRevList)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.txtBudRevNum)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.mebRemBal)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.ddlStat)
        Me.Controls.Add(Me.dtpMForecasted)
        Me.Controls.Add(Me.dtpMBudgeted)
        Me.Controls.Add(Me.ddlProcess)
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.txtBRNum)
        Me.Controls.Add(Me.ddlBRNum)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBudget"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.ThemeName = "Windows8"
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMBudgeted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMForecasted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRevision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemBal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBudRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvRevList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvRevList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSOU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebYEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpd8dRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBRNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlProcess As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dtpMBudgeted As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpMForecasted As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents ddlStat As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSaveBud As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlBRNum As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents chkRevision As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents mebRemBal As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leRecordCount As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement4 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement5 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents txtBudRevNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblRevNum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvRevList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwLoadRevList As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents mebAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents btnRefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCR As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpSOU As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents mebRemQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebYEN As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnUpd8dRep As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnOI As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDI As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
End Class


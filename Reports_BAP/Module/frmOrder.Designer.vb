<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.lblRevNum = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPONum = New Telerik.WinControls.UI.RadTextBox()
        Me.mebRemBud = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.ddlStat = New Telerik.WinControls.UI.RadDropDownList()
        Me.dtpMDelivery = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpMOrder = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.ddlProcess = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPRNum = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlBRNum = New Telerik.WinControls.UI.RadDropDownList()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSupplier = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.btnSaveOrder = New Telerik.WinControls.UI.RadButton()
        Me.btnCopyTo = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.txtReason = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.btnRefresh = New Telerik.WinControls.UI.RadButton()
        Me.chkNewOrder = New Telerik.WinControls.UI.RadCheckBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.lblOrderID = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.mebQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.mebRemQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnMultiOrder = New Telerik.WinControls.UI.RadButton()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.mebYEN = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.mebJPYAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTC = New Telerik.WinControls.UI.RadTextBox()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.btnCPO = New Telerik.WinControls.UI.RadButton()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCopyTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMultiOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebYEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebJPYAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRevNum
        '
        Me.lblRevNum.Location = New System.Drawing.Point(329, 64)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(2, 2)
        Me.lblRevNum.TabIndex = 156
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(24, 162)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(150, 21)
        Me.RadLabel13.TabIndex = 155
        Me.RadLabel13.Text = "Purchase Order Number"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'txtPONum
        '
        Me.txtPONum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPONum.Location = New System.Drawing.Point(238, 162)
        Me.txtPONum.Name = "txtPONum"
        Me.txtPONum.Size = New System.Drawing.Size(189, 20)
        Me.txtPONum.TabIndex = 4
        Me.txtPONum.ThemeName = "Windows8"
        '
        'mebRemBud
        '
        Me.mebRemBud.Location = New System.Drawing.Point(238, 581)
        Me.mebRemBud.Mask = "N2"
        Me.mebRemBud.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemBud.Name = "mebRemBud"
        Me.mebRemBud.ReadOnly = True
        Me.mebRemBud.Size = New System.Drawing.Size(189, 20)
        Me.mebRemBud.TabIndex = 16
        Me.mebRemBud.TabStop = False
        Me.mebRemBud.Text = "0.00"
        Me.mebRemBud.ThemeName = "Windows8"
        '
        'txtSignature
        '
        Me.txtSignature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSignature.Location = New System.Drawing.Point(238, 663)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Size = New System.Drawing.Size(189, 20)
        Me.txtSignature.TabIndex = 18
        Me.txtSignature.ThemeName = "Windows8"
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.Location = New System.Drawing.Point(238, 240)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 43)
        Me.txtDesc.TabIndex = 8
        Me.txtDesc.ThemeName = "Windows8"
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
        Me.ddlStat.Location = New System.Drawing.Point(238, 499)
        Me.ddlStat.Name = "ddlStat"
        Me.ddlStat.Size = New System.Drawing.Size(189, 20)
        Me.ddlStat.TabIndex = 14
        Me.ddlStat.ThemeName = "Windows8"
        '
        'dtpMDelivery
        '
        Me.dtpMDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMDelivery.Location = New System.Drawing.Point(238, 472)
        Me.dtpMDelivery.Name = "dtpMDelivery"
        Me.dtpMDelivery.Size = New System.Drawing.Size(189, 20)
        Me.dtpMDelivery.TabIndex = 13
        Me.dtpMDelivery.TabStop = False
        Me.dtpMDelivery.Text = "9/11/2014"
        Me.dtpMDelivery.ThemeName = "Windows8"
        Me.dtpMDelivery.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'dtpMOrder
        '
        Me.dtpMOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMOrder.Location = New System.Drawing.Point(238, 188)
        Me.dtpMOrder.Name = "dtpMOrder"
        Me.dtpMOrder.Size = New System.Drawing.Size(189, 20)
        Me.dtpMOrder.TabIndex = 6
        Me.dtpMOrder.TabStop = False
        Me.dtpMOrder.Text = "9/11/2014"
        Me.dtpMOrder.ThemeName = "Windows8"
        Me.dtpMOrder.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'ddlProcess
        '
        Me.ddlProcess.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlProcess.Location = New System.Drawing.Point(238, 315)
        Me.ddlProcess.Name = "ddlProcess"
        Me.ddlProcess.Size = New System.Drawing.Size(189, 20)
        Me.ddlProcess.TabIndex = 11
        Me.ddlProcess.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(238, 289)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(189, 20)
        Me.ddlClass.TabIndex = 9
        Me.ddlClass.ThemeName = "Windows8"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(24, 663)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 151
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(24, 240)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel11.TabIndex = 150
        Me.RadLabel11.Text = "Description"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(24, 581)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(116, 21)
        Me.RadLabel10.TabIndex = 149
        Me.RadLabel10.Text = "Remaining Budget"
        Me.RadLabel10.ThemeName = "Windows8"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(24, 499)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel9.TabIndex = 148
        Me.RadLabel9.Text = "Status"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(24, 472)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(113, 21)
        Me.RadLabel7.TabIndex = 147
        Me.RadLabel7.Text = "Month of Delivery"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(24, 188)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(99, 21)
        Me.RadLabel5.TabIndex = 146
        Me.RadLabel5.Text = "Month Ordered"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(24, 110)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel6.TabIndex = 145
        Me.RadLabel6.Text = "Budget Reference Number"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(24, 315)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 21)
        Me.RadLabel3.TabIndex = 143
        Me.RadLabel3.Text = "Process"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(24, 289)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel2.TabIndex = 142
        Me.RadLabel2.Text = "Classification"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(3, 740)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 139
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(312, 56)
        Me.RadLabel8.TabIndex = 140
        Me.RadLabel8.Text = "Purchase Request"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'txtPRNum
        '
        Me.txtPRNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRNum.Location = New System.Drawing.Point(238, 136)
        Me.txtPRNum.Name = "txtPRNum"
        Me.txtPRNum.Size = New System.Drawing.Size(189, 20)
        Me.txtPRNum.TabIndex = 5
        Me.txtPRNum.ThemeName = "Windows8"
        '
        'ddlBRNum
        '
        Me.ddlBRNum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlBRNum.Location = New System.Drawing.Point(238, 110)
        Me.ddlBRNum.Name = "ddlBRNum"
        Me.ddlBRNum.Size = New System.Drawing.Size(189, 20)
        Me.ddlBRNum.TabIndex = 3
        Me.ddlBRNum.ThemeName = "Windows8"
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
        Me.rgvList.MasterTemplate.AllowRowResize = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(844, 729)
        Me.rgvList.TabIndex = 157
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(24, 136)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(182, 21)
        Me.RadLabel14.TabIndex = 158
        Me.RadLabel14.Text = "Purchase Requisition Number"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(24, 214)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(55, 21)
        Me.RadLabel15.TabIndex = 159
        Me.RadLabel15.Text = "Supplier"
        Me.RadLabel15.ThemeName = "Windows8"
        Me.RadLabel15.Visible = False
        '
        'txtSupplier
        '
        Me.txtSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplier.Location = New System.Drawing.Point(238, 214)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(189, 20)
        Me.txtSupplier.TabIndex = 7
        Me.txtSupplier.ThemeName = "Windows8"
        Me.txtSupplier.Visible = False
        '
        'RadLabel16
        '
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(24, 607)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(57, 21)
        Me.RadLabel16.TabIndex = 162
        Me.RadLabel16.Text = "Remarks"
        Me.RadLabel16.ThemeName = "Windows8"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.Location = New System.Drawing.Point(238, 607)
        Me.txtRemarks.MaxLength = 100000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(189, 50)
        Me.txtRemarks.TabIndex = 17
        Me.txtRemarks.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Enabled = False
        Me.btnSaveOrder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOrder.Location = New System.Drawing.Point(1145, 744)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(120, 40)
        Me.btnSaveOrder.TabIndex = 19
        Me.btnSaveOrder.Text = "&Save"
        Me.btnSaveOrder.ThemeName = "Windows8"
        Me.btnSaveOrder.Visible = False
        '
        'btnCopyTo
        '
        Me.btnCopyTo.Enabled = False
        Me.btnCopyTo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyTo.Location = New System.Drawing.Point(1019, 744)
        Me.btnCopyTo.Name = "btnCopyTo"
        Me.btnCopyTo.Size = New System.Drawing.Size(120, 40)
        Me.btnCopyTo.TabIndex = 20
        Me.btnCopyTo.Text = "&Copy To"
        Me.btnCopyTo.ThemeName = "Windows8"
        Me.btnCopyTo.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(24, 84)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 166
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(307, 689)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "C&lear Field"
        Me.btnClear.ThemeName = "Windows8"
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel17.Location = New System.Drawing.Point(24, 526)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(194, 21)
        Me.RadLabel17.TabIndex = 167
        Me.RadLabel17.Text = "Reason: Cancellation / Received"
        Me.RadLabel17.ThemeName = "Windows8"
        '
        'txtReason
        '
        Me.txtReason.AutoScroll = True
        Me.txtReason.Location = New System.Drawing.Point(238, 525)
        Me.txtReason.MaxLength = 100000
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(189, 50)
        Me.txtReason.TabIndex = 15
        Me.txtReason.ThemeName = "Windows8"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.ACCTNG.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(238, 689)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(63, 40)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.ThemeName = "Windows8"
        '
        'chkNewOrder
        '
        Me.chkNewOrder.Location = New System.Drawing.Point(238, 59)
        Me.chkNewOrder.Name = "chkNewOrder"
        Me.chkNewOrder.Size = New System.Drawing.Size(78, 18)
        Me.chkNewOrder.TabIndex = 2
        Me.chkNewOrder.Text = "New Order"
        Me.chkNewOrder.ThemeName = "Windows8"
        Me.chkNewOrder.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1145, 744)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 40)
        Me.btnUpdate.TabIndex = 174
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.ThemeName = "Windows8"
        Me.btnUpdate.Visible = False
        '
        'lblOrderID
        '
        Me.lblOrderID.Location = New System.Drawing.Point(238, 32)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(64, 18)
        Me.lblOrderID.TabIndex = 175
        Me.lblOrderID.Text = "RadLabel18"
        Me.lblOrderID.Visible = False
        '
        'RadLabel18
        '
        Me.RadLabel18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel18.Location = New System.Drawing.Point(24, 342)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel18.TabIndex = 176
        Me.RadLabel18.Text = "Quantity"
        Me.RadLabel18.ThemeName = "Windows8"
        '
        'mebQTY
        '
        Me.mebQTY.Location = New System.Drawing.Point(238, 341)
        Me.mebQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebQTY.Name = "mebQTY"
        Me.mebQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebQTY.TabIndex = 177
        Me.mebQTY.TabStop = False
        Me.mebQTY.Text = "0"
        Me.mebQTY.ThemeName = "Windows8"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(24, 367)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel19.TabIndex = 179
        Me.RadLabel19.Text = "Unit of Measurement"
        Me.RadLabel19.ThemeName = "Windows8"
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
        Me.ddlUOM.Location = New System.Drawing.Point(238, 368)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(189, 20)
        Me.ddlUOM.TabIndex = 180
        Me.ddlUOM.ThemeName = "Windows8"
        '
        'RadLabel20
        '
        Me.RadLabel20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel20.Location = New System.Drawing.Point(24, 394)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(124, 21)
        Me.RadLabel20.TabIndex = 181
        Me.RadLabel20.Text = "Remaining Quantity"
        Me.RadLabel20.ThemeName = "Windows8"
        '
        'mebRemQTY
        '
        Me.mebRemQTY.Location = New System.Drawing.Point(238, 394)
        Me.mebRemQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemQTY.Name = "mebRemQTY"
        Me.mebRemQTY.ReadOnly = True
        Me.mebRemQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebRemQTY.TabIndex = 182
        Me.mebRemQTY.TabStop = False
        Me.mebRemQTY.Text = "0"
        Me.mebRemQTY.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Location = New System.Drawing.Point(238, 84)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 183
        Me.ddlDept.ThemeName = "Windows8"
        '
        'btnMultiOrder
        '
        Me.btnMultiOrder.Enabled = False
        Me.btnMultiOrder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiOrder.Location = New System.Drawing.Point(322, 51)
        Me.btnMultiOrder.Name = "btnMultiOrder"
        Me.btnMultiOrder.Size = New System.Drawing.Size(105, 27)
        Me.btnMultiOrder.TabIndex = 184
        Me.btnMultiOrder.Text = "&Items"
        Me.btnMultiOrder.ThemeName = "Windows8"
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
        Me.ddlCurrency.Location = New System.Drawing.Point(238, 420)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(51, 20)
        Me.ddlCurrency.TabIndex = 210
        Me.ddlCurrency.ThemeName = "Windows8"
        '
        'mebYEN
        '
        Me.mebYEN.Location = New System.Drawing.Point(238, 446)
        Me.mebYEN.Mask = "N2"
        Me.mebYEN.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebYEN.Name = "mebYEN"
        Me.mebYEN.ReadOnly = True
        Me.mebYEN.Size = New System.Drawing.Size(189, 20)
        Me.mebYEN.TabIndex = 209
        Me.mebYEN.TabStop = False
        Me.mebYEN.Tag = "C"
        Me.mebYEN.Text = "0.00"
        Me.mebYEN.ThemeName = "Windows8"
        '
        'RadLabel21
        '
        Me.RadLabel21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel21.Location = New System.Drawing.Point(24, 420)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(105, 21)
        Me.RadLabel21.TabIndex = 208
        Me.RadLabel21.Text = "Original Amount"
        Me.RadLabel21.ThemeName = "Windows8"
        '
        'mebJPYAmount
        '
        Me.mebJPYAmount.Location = New System.Drawing.Point(288, 420)
        Me.mebJPYAmount.Mask = "N2"
        Me.mebJPYAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebJPYAmount.Name = "mebJPYAmount"
        Me.mebJPYAmount.Size = New System.Drawing.Size(139, 20)
        Me.mebJPYAmount.TabIndex = 206
        Me.mebJPYAmount.TabStop = False
        Me.mebJPYAmount.Tag = "C"
        Me.mebJPYAmount.Text = "0.00"
        Me.mebJPYAmount.ThemeName = "Windows8"
        '
        'RadLabel22
        '
        Me.RadLabel22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel22.Location = New System.Drawing.Point(24, 446)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel22.TabIndex = 207
        Me.RadLabel22.Text = "Amount JPY"
        Me.RadLabel22.ThemeName = "Windows8"
        '
        'txtTC
        '
        Me.txtTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTC.Location = New System.Drawing.Point(238, 10)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.ReadOnly = True
        Me.txtTC.Size = New System.Drawing.Size(189, 20)
        Me.txtTC.TabIndex = 248
        Me.txtTC.ThemeName = "Windows8"
        Me.txtTC.Visible = False
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(183, 662)
        Me.lblUserlvl.Name = "lblUserlvl"
        Me.lblUserlvl.Size = New System.Drawing.Size(46, 21)
        Me.lblUserlvl.TabIndex = 254
        Me.lblUserlvl.Text = "Userlvl"
        Me.lblUserlvl.ThemeName = "Windows8"
        Me.lblUserlvl.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(135, 662)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 21)
        Me.lblUserID.TabIndex = 253
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.ThemeName = "Windows8"
        Me.lblUserID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(93, 662)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 252
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Windows8"
        Me.lblDept.Visible = False
        '
        'btnCPO
        '
        Me.btnCPO.Enabled = False
        Me.btnCPO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPO.Location = New System.Drawing.Point(893, 744)
        Me.btnCPO.Name = "btnCPO"
        Me.btnCPO.Size = New System.Drawing.Size(120, 40)
        Me.btnCPO.TabIndex = 255
        Me.btnCPO.Text = "Create PO"
        Me.btnCPO.ThemeName = "Windows8"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1277, 799)
        Me.Controls.Add(Me.btnCPO)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.txtTC)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.mebYEN)
        Me.Controls.Add(Me.RadLabel21)
        Me.Controls.Add(Me.mebJPYAmount)
        Me.Controls.Add(Me.RadLabel22)
        Me.Controls.Add(Me.btnMultiOrder)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.mebRemQTY)
        Me.Controls.Add(Me.RadLabel20)
        Me.Controls.Add(Me.ddlUOM)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.mebQTY)
        Me.Controls.Add(Me.RadLabel18)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.chkNewOrder)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnCopyTo)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.lblRevNum)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.txtPONum)
        Me.Controls.Add(Me.mebRemBud)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.ddlStat)
        Me.Controls.Add(Me.dtpMDelivery)
        Me.Controls.Add(Me.dtpMOrder)
        Me.Controls.Add(Me.ddlProcess)
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.txtPRNum)
        Me.Controls.Add(Me.ddlBRNum)
        Me.Controls.Add(Me.btnUpdate)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrder"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.ThemeName = "Windows8"
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCopyTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMultiOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebYEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebJPYAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblRevNum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPONum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mebRemBud As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents ddlStat As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dtpMDelivery As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpMOrder As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents ddlProcess As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPRNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlBRNum As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSupplier As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSaveOrder As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCopyTo As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtReason As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents btnRefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents chkNewOrder As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblOrderID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebRemQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnMultiOrder As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents mebYEN As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebJPYAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCPO As Telerik.WinControls.UI.RadButton
End Class


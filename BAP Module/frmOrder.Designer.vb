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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.lblRevNum = New Telerik.WinControls.UI.RadLabel()
        Me.mebRemBud = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.ddlStat = New Telerik.WinControls.UI.RadDropDownList()
        Me.dtpMOrder = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.ddlProcess = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblOrderID = New Telerik.WinControls.UI.RadLabel()
        Me.txtTC = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPRNum = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlBRNum = New Telerik.WinControls.UI.RadDropDownList()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.Remarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.btnSaveOrder = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.txtReason = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.chkNewOrder = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.mebQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.mebRemQTY = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.btnCPO = New Telerik.WinControls.UI.RadButton()
        Me.rgvListItem = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData2 = New System.ComponentModel.BackgroundWorker()
        Me.btnPrintPR = New Telerik.WinControls.UI.RadButton()
        Me.RemDeptBud = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.mebRemDBLPR = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.mebRemBLPR = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.mebTOPRA = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.mebEPA = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.mebAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.dtpMDelivery = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtPONum = New Telerik.WinControls.UI.RadTextBox()
        Me.mebJPYAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.mebTOPDRA = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel27 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRN = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel23 = New Telerik.WinControls.UI.RadLabel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtSupplier = New Telerik.WinControls.UI.RadTextBox()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.pbOlrayt = New Telerik.WinControls.UI.RadProgressBar()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.dtpTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txtMoldDie = New Telerik.WinControls.UI.RadTextBox()
        Me.txtExistingPR = New Telerik.WinControls.UI.RadButton()
        Me.btnSearch = New Telerik.WinControls.UI.RadButton()
        Me.txtSearchPR = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCalc = New Telerik.WinControls.UI.RadButton()
        Me.btnRefresh = New Telerik.WinControls.UI.RadButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlBRNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvListItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvListItem.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrintPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemDeptBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemDBLPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebRemBLPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebTOPRA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebEPA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebJPYAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mebTOPDRA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOlrayt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoldDie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistingPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRevNum
        '
        Me.lblRevNum.Location = New System.Drawing.Point(192, 1)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(2, 2)
        Me.lblRevNum.TabIndex = 156
        '
        'mebRemBud
        '
        Me.mebRemBud.BackColor = System.Drawing.Color.Transparent
        Me.mebRemBud.ForeColor = System.Drawing.Color.Black
        Me.mebRemBud.Location = New System.Drawing.Point(238, 597)
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
        Me.txtSignature.Location = New System.Drawing.Point(238, 705)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(189, 20)
        Me.txtSignature.TabIndex = 18
        Me.txtSignature.ThemeName = "Windows8"
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.IsReadOnly = True
        Me.txtDesc.Location = New System.Drawing.Point(238, 159)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 43)
        Me.txtDesc.TabIndex = 8
        Me.txtDesc.ThemeName = "Windows8"
        '
        'ddlStat
        '
        Me.ddlStat.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlStat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "OPEN"
        RadListDataItem2.Text = "CLOSE"
        Me.ddlStat.Items.Add(RadListDataItem1)
        Me.ddlStat.Items.Add(RadListDataItem2)
        Me.ddlStat.Location = New System.Drawing.Point(238, 360)
        Me.ddlStat.Name = "ddlStat"
        Me.ddlStat.Size = New System.Drawing.Size(189, 20)
        Me.ddlStat.TabIndex = 14
        Me.ddlStat.ThemeName = "Windows8"
        '
        'dtpMOrder
        '
        Me.dtpMOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMOrder.Location = New System.Drawing.Point(238, 135)
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
        Me.ddlProcess.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlProcess.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlProcess.Location = New System.Drawing.Point(238, 255)
        Me.ddlProcess.Name = "ddlProcess"
        Me.ddlProcess.Size = New System.Drawing.Size(189, 20)
        Me.ddlProcess.TabIndex = 11
        Me.ddlProcess.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(238, 229)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(189, 20)
        Me.ddlClass.TabIndex = 9
        Me.ddlClass.ThemeName = "Windows8"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(24, 705)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 151
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(24, 161)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel11.TabIndex = 150
        Me.RadLabel11.Text = "Description"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(24, 597)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(116, 21)
        Me.RadLabel10.TabIndex = 149
        Me.RadLabel10.Text = "Remaining Budget"
        Me.RadLabel10.ThemeName = "Windows8"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(24, 360)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(43, 21)
        Me.RadLabel9.TabIndex = 148
        Me.RadLabel9.Text = "Status"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(24, 135)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(99, 21)
        Me.RadLabel5.TabIndex = 146
        Me.RadLabel5.Text = "Month Ordered"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(24, 57)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(164, 21)
        Me.RadLabel6.TabIndex = 145
        Me.RadLabel6.Text = "Budget Reference Number"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(24, 255)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 21)
        Me.RadLabel3.TabIndex = 143
        Me.RadLabel3.Text = "Process"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(24, 229)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel2.TabIndex = 142
        Me.RadLabel2.Text = "Classification"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'lblOrderID
        '
        Me.lblOrderID.Location = New System.Drawing.Point(159, 229)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(64, 18)
        Me.lblOrderID.TabIndex = 175
        Me.lblOrderID.Text = "RadLabel18"
        Me.lblOrderID.Visible = False
        '
        'txtTC
        '
        Me.txtTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTC.Location = New System.Drawing.Point(142, 229)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.ReadOnly = True
        Me.txtTC.Size = New System.Drawing.Size(15, 20)
        Me.txtTC.TabIndex = 248
        Me.txtTC.ThemeName = "Windows8"
        Me.txtTC.Visible = False
        '
        'txtPRNum
        '
        Me.txtPRNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRNum.Location = New System.Drawing.Point(238, 83)
        Me.txtPRNum.Name = "txtPRNum"
        Me.txtPRNum.ReadOnly = True
        Me.txtPRNum.Size = New System.Drawing.Size(189, 20)
        Me.txtPRNum.TabIndex = 5
        Me.txtPRNum.ThemeName = "Windows8"
        '
        'ddlBRNum
        '
        Me.ddlBRNum.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlBRNum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlBRNum.Location = New System.Drawing.Point(238, 57)
        Me.ddlBRNum.Name = "ddlBRNum"
        Me.ddlBRNum.Size = New System.Drawing.Size(189, 20)
        Me.ddlBRNum.TabIndex = 3
        Me.ddlBRNum.ThemeName = "Windows8"
        '
        'rgvList
        '
        Me.rgvList.Location = New System.Drawing.Point(433, 31)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AllowRowResize = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(770, 451)
        Me.rgvList.TabIndex = 157
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(24, 83)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(182, 21)
        Me.RadLabel14.TabIndex = 158
        Me.RadLabel14.Text = "Purchase Requisition Number"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'RadLabel16
        '
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(24, 649)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(121, 21)
        Me.RadLabel16.TabIndex = 162
        Me.RadLabel16.Text = "Reason for Request"
        Me.RadLabel16.ThemeName = "Windows8"
        '
        'Remarks
        '
        Me.Remarks.AutoScroll = True
        Me.Remarks.IsReadOnly = True
        Me.Remarks.Location = New System.Drawing.Point(238, 649)
        Me.Remarks.MaxLength = 100000
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(189, 50)
        Me.Remarks.TabIndex = 17
        Me.Remarks.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Enabled = False
        Me.btnSaveOrder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOrder.Location = New System.Drawing.Point(1215, 747)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(120, 40)
        Me.btnSaveOrder.TabIndex = 19
        Me.btnSaveOrder.Text = "&Save"
        Me.btnSaveOrder.ThemeName = "Windows8"
        Me.btnSaveOrder.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(24, 31)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 166
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(181, 751)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "C&lear Field"
        Me.btnClear.ThemeName = "Windows8"
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel17.Location = New System.Drawing.Point(24, 386)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(194, 21)
        Me.RadLabel17.TabIndex = 167
        Me.RadLabel17.Text = "Reason: Cancellation / Received"
        Me.RadLabel17.ThemeName = "Windows8"
        '
        'txtReason
        '
        Me.txtReason.AutoScroll = True
        Me.txtReason.IsReadOnly = True
        Me.txtReason.Location = New System.Drawing.Point(238, 386)
        Me.txtReason.MaxLength = 100000
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(189, 50)
        Me.txtReason.TabIndex = 15
        Me.txtReason.ThemeName = "Windows8"
        '
        'chkNewOrder
        '
        Me.chkNewOrder.Location = New System.Drawing.Point(142, 178)
        Me.chkNewOrder.Name = "chkNewOrder"
        Me.chkNewOrder.Size = New System.Drawing.Size(78, 18)
        Me.chkNewOrder.TabIndex = 2
        Me.chkNewOrder.Text = "New Order"
        Me.chkNewOrder.ThemeName = "Windows8"
        Me.chkNewOrder.Visible = False
        '
        'RadLabel18
        '
        Me.RadLabel18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel18.Location = New System.Drawing.Point(24, 282)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel18.TabIndex = 176
        Me.RadLabel18.Text = "Quantity"
        Me.RadLabel18.ThemeName = "Windows8"
        '
        'mebQTY
        '
        Me.mebQTY.Location = New System.Drawing.Point(238, 281)
        Me.mebQTY.Mask = "n2"
        Me.mebQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebQTY.Name = "mebQTY"
        Me.mebQTY.ReadOnly = True
        Me.mebQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebQTY.TabIndex = 177
        Me.mebQTY.TabStop = False
        Me.mebQTY.Text = "0.00"
        Me.mebQTY.ThemeName = "Windows8"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(24, 307)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel19.TabIndex = 179
        Me.RadLabel19.Text = "Unit of Measurement"
        Me.RadLabel19.ThemeName = "Windows8"
        '
        'ddlUOM
        '
        Me.ddlUOM.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "PCS"
        RadListDataItem4.Text = "LOT"
        Me.ddlUOM.Items.Add(RadListDataItem3)
        Me.ddlUOM.Items.Add(RadListDataItem4)
        Me.ddlUOM.Location = New System.Drawing.Point(238, 308)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(189, 20)
        Me.ddlUOM.TabIndex = 180
        Me.ddlUOM.ThemeName = "Windows8"
        '
        'RadLabel20
        '
        Me.RadLabel20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel20.Location = New System.Drawing.Point(24, 334)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(124, 21)
        Me.RadLabel20.TabIndex = 181
        Me.RadLabel20.Text = "Remaining Quantity"
        Me.RadLabel20.ThemeName = "Windows8"
        '
        'mebRemQTY
        '
        Me.mebRemQTY.Location = New System.Drawing.Point(238, 334)
        Me.mebRemQTY.Mask = "n2"
        Me.mebRemQTY.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemQTY.Name = "mebRemQTY"
        Me.mebRemQTY.ReadOnly = True
        Me.mebRemQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebRemQTY.TabIndex = 182
        Me.mebRemQTY.TabStop = False
        Me.mebRemQTY.Text = "0.00"
        Me.mebRemQTY.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlDept.Enabled = False
        Me.ddlDept.Location = New System.Drawing.Point(238, 31)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 183
        Me.ddlDept.ThemeName = "Windows8"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem5.Text = "PHP"
        RadListDataItem6.Text = "JPY"
        RadListDataItem7.Text = "USD"
        Me.ddlCurrency.Items.Add(RadListDataItem5)
        Me.ddlCurrency.Items.Add(RadListDataItem6)
        Me.ddlCurrency.Items.Add(RadListDataItem7)
        Me.ddlCurrency.Location = New System.Drawing.Point(238, 442)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(51, 20)
        Me.ddlCurrency.TabIndex = 210
        Me.ddlCurrency.ThemeName = "Windows8"
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(183, 704)
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
        Me.lblUserID.Location = New System.Drawing.Point(135, 704)
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
        Me.lblDept.Location = New System.Drawing.Point(93, 704)
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
        Me.btnCPO.Location = New System.Drawing.Point(1030, 747)
        Me.btnCPO.Name = "btnCPO"
        Me.btnCPO.Size = New System.Drawing.Size(120, 40)
        Me.btnCPO.TabIndex = 255
        Me.btnCPO.Text = "Create PO"
        Me.btnCPO.ThemeName = "Windows8"
        Me.btnCPO.Visible = False
        '
        'rgvListItem
        '
        Me.rgvListItem.Location = New System.Drawing.Point(433, 488)
        '
        '
        '
        Me.rgvListItem.MasterTemplate.AllowAddNewRow = False
        Me.rgvListItem.MasterTemplate.AllowCellContextMenu = False
        Me.rgvListItem.MasterTemplate.AllowColumnReorder = False
        Me.rgvListItem.MasterTemplate.AllowDeleteRow = False
        Me.rgvListItem.MasterTemplate.AllowEditRow = False
        Me.rgvListItem.MasterTemplate.EnableGrouping = False
        Me.rgvListItem.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvListItem.MasterTemplate.MultiSelect = True
        Me.rgvListItem.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvListItem.Name = "rgvListItem"
        Me.rgvListItem.Size = New System.Drawing.Size(770, 302)
        Me.rgvListItem.TabIndex = 256
        Me.rgvListItem.ThemeName = "Windows8"
        '
        'bwLoadData2
        '
        '
        'btnPrintPR
        '
        Me.btnPrintPR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPR.Enabled = False
        Me.btnPrintPR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPR.Location = New System.Drawing.Point(64, 814)
        Me.btnPrintPR.Name = "btnPrintPR"
        Me.btnPrintPR.Size = New System.Drawing.Size(120, 40)
        Me.btnPrintPR.TabIndex = 258
        Me.btnPrintPR.Text = "Print PR"
        Me.btnPrintPR.ThemeName = "Windows8"
        Me.btnPrintPR.Visible = False
        '
        'RemDeptBud
        '
        Me.RemDeptBud.BackColor = System.Drawing.Color.Transparent
        Me.RemDeptBud.Location = New System.Drawing.Point(238, 623)
        Me.RemDeptBud.Mask = "N2"
        Me.RemDeptBud.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RemDeptBud.Name = "RemDeptBud"
        Me.RemDeptBud.ReadOnly = True
        Me.RemDeptBud.Size = New System.Drawing.Size(189, 20)
        Me.RemDeptBud.TabIndex = 286
        Me.RemDeptBud.TabStop = False
        Me.RemDeptBud.Text = "0.00"
        Me.RemDeptBud.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(24, 623)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(201, 21)
        Me.RadLabel4.TabIndex = 287
        Me.RadLabel4.Text = "Remaining Departmental Budget"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'mebRemDBLPR
        '
        Me.mebRemDBLPR.BackColor = System.Drawing.Color.Transparent
        Me.mebRemDBLPR.Location = New System.Drawing.Point(238, 571)
        Me.mebRemDBLPR.Mask = "N2"
        Me.mebRemDBLPR.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemDBLPR.Name = "mebRemDBLPR"
        Me.mebRemDBLPR.ReadOnly = True
        Me.mebRemDBLPR.Size = New System.Drawing.Size(189, 20)
        Me.mebRemDBLPR.TabIndex = 332
        Me.mebRemDBLPR.TabStop = False
        Me.mebRemDBLPR.Text = "0.00"
        Me.mebRemDBLPR.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(24, 571)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(199, 21)
        Me.RadLabel15.TabIndex = 333
        Me.RadLabel15.Text = "Remaining Dept. Budget Less PR"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'mebRemBLPR
        '
        Me.mebRemBLPR.BackColor = System.Drawing.Color.Transparent
        Me.mebRemBLPR.Location = New System.Drawing.Point(238, 545)
        Me.mebRemBLPR.Mask = "N2"
        Me.mebRemBLPR.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebRemBLPR.Name = "mebRemBLPR"
        Me.mebRemBLPR.ReadOnly = True
        Me.mebRemBLPR.Size = New System.Drawing.Size(189, 20)
        Me.mebRemBLPR.TabIndex = 330
        Me.mebRemBLPR.TabStop = False
        Me.mebRemBLPR.Text = "0.00"
        Me.mebRemBLPR.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(24, 545)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(163, 21)
        Me.RadLabel13.TabIndex = 331
        Me.RadLabel13.Text = "Remaining Budget Less PR"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'mebTOPRA
        '
        Me.mebTOPRA.BackColor = System.Drawing.Color.Transparent
        Me.mebTOPRA.Location = New System.Drawing.Point(238, 494)
        Me.mebTOPRA.Mask = "N2"
        Me.mebTOPRA.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebTOPRA.Name = "mebTOPRA"
        Me.mebTOPRA.ReadOnly = True
        Me.mebTOPRA.Size = New System.Drawing.Size(189, 20)
        Me.mebTOPRA.TabIndex = 328
        Me.mebTOPRA.TabStop = False
        Me.mebTOPRA.Text = "0.00"
        Me.mebTOPRA.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(24, 494)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(174, 21)
        Me.RadLabel7.TabIndex = 329
        Me.RadLabel7.Text = "Total Open PR Amount (JPY)"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'mebEPA
        '
        Me.mebEPA.BackColor = System.Drawing.Color.Transparent
        Me.mebEPA.Location = New System.Drawing.Point(238, 468)
        Me.mebEPA.Mask = "N2"
        Me.mebEPA.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebEPA.Name = "mebEPA"
        Me.mebEPA.Size = New System.Drawing.Size(189, 20)
        Me.mebEPA.TabIndex = 326
        Me.mebEPA.TabStop = False
        Me.mebEPA.Text = "0.00"
        Me.mebEPA.ThemeName = "Windows8"
        '
        'RadLabel21
        '
        Me.RadLabel21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel21.Location = New System.Drawing.Point(24, 468)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(167, 21)
        Me.RadLabel21.TabIndex = 327
        Me.RadLabel21.Text = "Estimated PR Amount (JPY)"
        Me.RadLabel21.ThemeName = "Windows8"
        '
        'RadLabel22
        '
        Me.RadLabel22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel22.Location = New System.Drawing.Point(24, 442)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(105, 21)
        Me.RadLabel22.TabIndex = 336
        Me.RadLabel22.Text = "Original Amount"
        Me.RadLabel22.ThemeName = "Windows8"
        '
        'mebAmount
        '
        Me.mebAmount.Location = New System.Drawing.Point(288, 442)
        Me.mebAmount.Mask = "N2"
        Me.mebAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebAmount.Name = "mebAmount"
        Me.mebAmount.Size = New System.Drawing.Size(139, 20)
        Me.mebAmount.TabIndex = 335
        Me.mebAmount.TabStop = False
        Me.mebAmount.Tag = "C"
        Me.mebAmount.Text = "0.00"
        Me.mebAmount.ThemeName = "Windows8"
        '
        'dtpMDelivery
        '
        Me.dtpMDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMDelivery.Location = New System.Drawing.Point(93, 679)
        Me.dtpMDelivery.Name = "dtpMDelivery"
        Me.dtpMDelivery.Size = New System.Drawing.Size(27, 20)
        Me.dtpMDelivery.TabIndex = 13
        Me.dtpMDelivery.TabStop = False
        Me.dtpMDelivery.Text = "9/11/2014"
        Me.dtpMDelivery.ThemeName = "Windows8"
        Me.dtpMDelivery.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        Me.dtpMDelivery.Visible = False
        '
        'txtPONum
        '
        Me.txtPONum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPONum.Location = New System.Drawing.Point(26, 675)
        Me.txtPONum.Name = "txtPONum"
        Me.txtPONum.Size = New System.Drawing.Size(28, 20)
        Me.txtPONum.TabIndex = 4
        Me.txtPONum.ThemeName = "Windows8"
        Me.txtPONum.Visible = False
        '
        'mebJPYAmount
        '
        Me.mebJPYAmount.Location = New System.Drawing.Point(126, 679)
        Me.mebJPYAmount.Mask = "N2"
        Me.mebJPYAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebJPYAmount.Name = "mebJPYAmount"
        Me.mebJPYAmount.Size = New System.Drawing.Size(28, 20)
        Me.mebJPYAmount.TabIndex = 206
        Me.mebJPYAmount.TabStop = False
        Me.mebJPYAmount.Tag = "C"
        Me.mebJPYAmount.Text = "0.00"
        Me.mebJPYAmount.ThemeName = "Windows8"
        Me.mebJPYAmount.Visible = False
        '
        'mebTOPDRA
        '
        Me.mebTOPDRA.BackColor = System.Drawing.Color.Transparent
        Me.mebTOPDRA.Location = New System.Drawing.Point(238, 521)
        Me.mebTOPDRA.Mask = "N2"
        Me.mebTOPDRA.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.mebTOPDRA.Name = "mebTOPDRA"
        Me.mebTOPDRA.ReadOnly = True
        Me.mebTOPDRA.Size = New System.Drawing.Size(189, 20)
        Me.mebTOPDRA.TabIndex = 339
        Me.mebTOPDRA.TabStop = False
        Me.mebTOPDRA.Text = "0.00"
        Me.mebTOPDRA.ThemeName = "Windows8"
        '
        'RadLabel27
        '
        Me.RadLabel27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel27.Location = New System.Drawing.Point(24, 521)
        Me.RadLabel27.Name = "RadLabel27"
        Me.RadLabel27.Size = New System.Drawing.Size(210, 21)
        Me.RadLabel27.TabIndex = 338
        Me.RadLabel27.Text = "Total Dept. Open PR Amount (JPY)"
        Me.RadLabel27.ThemeName = "Windows8"
        '
        'txtRN
        '
        Me.txtRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRN.Location = New System.Drawing.Point(238, 109)
        Me.txtRN.Name = "txtRN"
        Me.txtRN.ReadOnly = True
        Me.txtRN.Size = New System.Drawing.Size(189, 20)
        Me.txtRN.TabIndex = 340
        Me.txtRN.ThemeName = "Windows8"
        '
        'RadLabel23
        '
        Me.RadLabel23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel23.Location = New System.Drawing.Point(24, 109)
        Me.RadLabel23.Name = "RadLabel23"
        Me.RadLabel23.Size = New System.Drawing.Size(152, 21)
        Me.RadLabel23.TabIndex = 341
        Me.RadLabel23.Text = "Reimbursement Number"
        Me.RadLabel23.ThemeName = "Windows8"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(218, 31)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblVersion.TabIndex = 342
        Me.lblVersion.Visible = False
        '
        'txtSupplier
        '
        Me.txtSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplier.Location = New System.Drawing.Point(60, 679)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(27, 20)
        Me.txtSupplier.TabIndex = 7
        Me.txtSupplier.ThemeName = "Windows8"
        Me.txtSupplier.Visible = False
        '
        'btnGo
        '
        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGo.Location = New System.Drawing.Point(405, 5)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(22, 20)
        Me.btnGo.TabIndex = 397
        Me.btnGo.Text = "Go"
        Me.btnGo.ThemeName = "Windows8"
        '
        'RadLabel24
        '
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(23, 5)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(121, 21)
        Me.RadLabel24.TabIndex = 394
        Me.RadLabel24.Text = "Select Date to View"
        Me.RadLabel24.ThemeName = "Windows8"
        '
        'pbOlrayt
        '
        Me.pbOlrayt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pbOlrayt.ForeColor = System.Drawing.Color.White
        Me.pbOlrayt.Location = New System.Drawing.Point(26, 729)
        Me.pbOlrayt.Name = "pbOlrayt"
        Me.pbOlrayt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbOlrayt.SeparatorWidth = 2
        Me.pbOlrayt.Size = New System.Drawing.Size(403, 15)
        Me.pbOlrayt.Step = 1
        Me.pbOlrayt.TabIndex = 398
        Me.pbOlrayt.Text = "Loading..."
        Me.pbOlrayt.ThemeName = "TelerikMetroBlue"
        Me.pbOlrayt.Value2 = 1
        Me.pbOlrayt.Visible = False
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(323, 5)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(76, 20)
        Me.dtpTo.TabIndex = 399
        Me.dtpTo.TabStop = False
        Me.dtpTo.Text = "9/11/2014"
        Me.dtpTo.ThemeName = "Windows8"
        Me.dtpTo.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(238, 5)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(74, 20)
        Me.dtpFrom.TabIndex = 400
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Text = "9/11/2014"
        Me.dtpFrom.ThemeName = "Windows8"
        Me.dtpFrom.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(23, 205)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(100, 21)
        Me.RadLabel8.TabIndex = 402
        Me.RadLabel8.Text = "Mold Die Name"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'txtMoldDie
        '
        Me.txtMoldDie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoldDie.Location = New System.Drawing.Point(238, 205)
        Me.txtMoldDie.Name = "txtMoldDie"
        Me.txtMoldDie.ReadOnly = True
        Me.txtMoldDie.Size = New System.Drawing.Size(189, 20)
        Me.txtMoldDie.TabIndex = 401
        Me.txtMoldDie.ThemeName = "Windows8"
        '
        'txtExistingPR
        '
        Me.txtExistingPR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtExistingPR.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistingPR.Location = New System.Drawing.Point(669, 3)
        Me.txtExistingPR.Name = "txtExistingPR"
        Me.txtExistingPR.Size = New System.Drawing.Size(84, 23)
        Me.txtExistingPR.TabIndex = 406
        Me.txtExistingPR.Text = "View Existing PR"
        Me.txtExistingPR.ThemeName = "Windows8"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(604, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(59, 23)
        Me.btnSearch.TabIndex = 405
        Me.btnSearch.Text = "Search PR #"
        Me.btnSearch.ThemeName = "Windows8"
        '
        'txtSearchPR
        '
        Me.txtSearchPR.BackColor = System.Drawing.Color.Transparent
        Me.txtSearchPR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchPR.Location = New System.Drawing.Point(473, 5)
        Me.txtSearchPR.Name = "txtSearchPR"
        Me.txtSearchPR.Size = New System.Drawing.Size(128, 20)
        Me.txtSearchPR.TabIndex = 403
        Me.txtSearchPR.ThemeName = "Windows8"
        '
        'RadLabel25
        '
        Me.RadLabel25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel25.Location = New System.Drawing.Point(433, 5)
        Me.RadLabel25.Name = "RadLabel25"
        Me.RadLabel25.Size = New System.Drawing.Size(34, 21)
        Me.RadLabel25.TabIndex = 404
        Me.RadLabel25.Text = "PR #"
        Me.RadLabel25.ThemeName = "Windows8"
        '
        'btnCalc
        '
        Me.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Image = Global.ACCTNG.My.Resources.Resources.Calc
        Me.btnCalc.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCalc.Location = New System.Drawing.Point(64, 750)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(43, 40)
        Me.btnCalc.TabIndex = 337
        Me.btnCalc.ThemeName = "Windows8"
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.ACCTNG.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(112, 750)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(63, 40)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(2, 751)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 139
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1210, 1001)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtExistingPR)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.txtMoldDie)
        Me.Controls.Add(Me.RadLabel25)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.txtSearchPR)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.rgvListItem)
        Me.Controls.Add(Me.btnCPO)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.pbOlrayt)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.RadLabel24)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtTC)
        Me.Controls.Add(Me.RadLabel23)
        Me.Controls.Add(Me.txtRN)
        Me.Controls.Add(Me.mebTOPDRA)
        Me.Controls.Add(Me.RadLabel27)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.RadLabel22)
        Me.Controls.Add(Me.mebAmount)
        Me.Controls.Add(Me.mebRemDBLPR)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.mebRemBLPR)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.mebTOPRA)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.mebEPA)
        Me.Controls.Add(Me.RadLabel21)
        Me.Controls.Add(Me.RemDeptBud)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.btnPrintPR)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.mebJPYAmount)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.mebRemQTY)
        Me.Controls.Add(Me.RadLabel20)
        Me.Controls.Add(Me.ddlUOM)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.mebQTY)
        Me.Controls.Add(Me.RadLabel18)
        Me.Controls.Add(Me.chkNewOrder)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.Remarks)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.lblRevNum)
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
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.txtPRNum)
        Me.Controls.Add(Me.ddlBRNum)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmOrder"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Purchase Requisition List"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlBRNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvListItem.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvListItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrintPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemDeptBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemDBLPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebRemBLPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebTOPRA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebEPA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebJPYAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mebTOPDRA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOlrayt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoldDie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistingPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblRevNum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebRemBud As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents ddlStat As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dtpMOrder As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents ddlProcess As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPRNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlBRNum As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Remarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSaveOrder As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtReason As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents btnRefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents chkNewOrder As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents lblOrderID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebRemQTY As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtTC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCPO As Telerik.WinControls.UI.RadButton
    Friend WithEvents rgvListItem As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwLoadData2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnPrintPR As Telerik.WinControls.UI.RadButton
    Friend WithEvents RemDeptBud As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebRemDBLPR As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebRemBLPR As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebTOPRA As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebEPA As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mebAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents dtpMDelivery As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtPONum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mebJPYAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents btnCalc As Telerik.WinControls.UI.RadButton
    Friend WithEvents mebTOPDRA As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel27 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRN As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel23 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents pbOlrayt As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents dtpTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtMoldDie As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtExistingPR As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtSearchPR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel25 As Telerik.WinControls.UI.RadLabel
End Class


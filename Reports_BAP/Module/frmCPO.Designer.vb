<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCPO))
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.txtTotal = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.btnCPO = New Telerik.WinControls.UI.RadButton()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlSupSap = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpMOrder = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RTTPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RTD = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RTUPrice = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RTTotal = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtVenCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpDelDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSupSap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTTPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTUPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDelDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Location = New System.Drawing.Point(373, 3)
        '
        'rgvList
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(849, 452)
        Me.rgvList.TabIndex = 251
        Me.rgvList.Text = "5, 5"
        Me.rgvList.ThemeName = "Windows8"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(1, 461)
        '
        'txtTotal
        '
        Me.txtTotal.MasterTemplate.AllowCellContextMenu = False
        Me.txtTotal.MasterTemplate.EnableGrouping = False
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(1219, 237)
        Me.txtTotal.TabIndex = 252
        Me.txtTotal.Text = "s"
        Me.txtTotal.ThemeName = "Windows8"
        '
        'RadLabel24
        '
        Me.RadLabel24.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(274, 56)
        Me.RadLabel24.TabIndex = 284
        Me.RadLabel24.Text = "Purchase Order"
        Me.RadLabel24.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(3, 718)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 285
        '
        'btnCPO
        '
        Me.btnCPO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPO.Location = New System.Drawing.Point(1091, 718)
        Me.btnCPO.Name = "btnCPO"
        Me.btnCPO.Size = New System.Drawing.Size(120, 40)
        Me.btnCPO.TabIndex = 286
        Me.btnCPO.Text = "Create PO"
        Me.btnCPO.ThemeName = "Windows8"
        '
        'bwLoadData
        '
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(35, 85)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(55, 21)
        Me.RadLabel15.TabIndex = 288
        Me.RadLabel15.Text = "Supplier"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'ddlSupSap
        '
        Me.ddlSupSap.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlSupSap.Location = New System.Drawing.Point(140, 85)
        Me.ddlSupSap.Name = "ddlSupSap"
        Me.ddlSupSap.Size = New System.Drawing.Size(227, 20)
        Me.ddlSupSap.TabIndex = 289
        Me.ddlSupSap.ThemeName = "Windows8"
        '
        'ddlCurrency
        '
        Me.ddlCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem4.Text = "PHP"
        RadListDataItem4.TextWrap = True
        RadListDataItem5.Text = "YEN"
        RadListDataItem5.TextWrap = True
        RadListDataItem6.Text = "USD"
        RadListDataItem6.TextWrap = True
        Me.ddlCurrency.Items.Add(RadListDataItem4)
        Me.ddlCurrency.Items.Add(RadListDataItem5)
        Me.ddlCurrency.Items.Add(RadListDataItem6)
        Me.ddlCurrency.Location = New System.Drawing.Point(228, 137)
        Me.ddlCurrency.Name = "ddlCurrency"
        Me.ddlCurrency.Size = New System.Drawing.Size(139, 20)
        Me.ddlCurrency.TabIndex = 293
        Me.ddlCurrency.ThemeName = "Windows8"
        '
        'RadLabel21
        '
        Me.RadLabel21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel21.Location = New System.Drawing.Point(35, 137)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel21.TabIndex = 292
        Me.RadLabel21.Text = "Currency"
        Me.RadLabel21.ThemeName = "Windows8"
        '
        'dtpMOrder
        '
        Me.dtpMOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMOrder.Location = New System.Drawing.Point(228, 163)
        Me.dtpMOrder.Name = "dtpMOrder"
        Me.dtpMOrder.Size = New System.Drawing.Size(139, 20)
        Me.dtpMOrder.TabIndex = 290
        Me.dtpMOrder.TabStop = False
        Me.dtpMOrder.Text = "9/11/2014"
        Me.dtpMOrder.ThemeName = "Windows8"
        Me.dtpMOrder.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(35, 163)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(99, 21)
        Me.RadLabel5.TabIndex = 291
        Me.RadLabel5.Text = "Month Ordered"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(35, 267)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(36, 21)
        Me.RadLabel1.TabIndex = 294
        Me.RadLabel1.Text = "Total"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(35, 242)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel2.TabIndex = 296
        Me.RadLabel2.Text = "Discount "
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(35, 215)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel3.TabIndex = 298
        Me.RadLabel3.Text = "Total PO"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(116, 242)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(18, 21)
        Me.RadLabel4.TabIndex = 297
        Me.RadLabel4.Text = "%"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(187, 242)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(35, 21)
        Me.RadLabel6.TabIndex = 297
        Me.RadLabel6.Text = "Price"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RTTPO
        '
        Me.RTTPO.Location = New System.Drawing.Point(228, 215)
        Me.RTTPO.Mask = "N2"
        Me.RTTPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTTPO.Name = "RTTPO"
        Me.RTTPO.ReadOnly = True
        Me.RTTPO.Size = New System.Drawing.Size(139, 20)
        Me.RTTPO.TabIndex = 299
        Me.RTTPO.TabStop = False
        Me.RTTPO.Tag = "C"
        Me.RTTPO.Text = "0.00"
        Me.RTTPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTTPO.ThemeName = "Windows8"
        '
        'RTD
        '
        Me.RTD.Location = New System.Drawing.Point(140, 242)
        Me.RTD.Mask = "n2"
        Me.RTD.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTD.Name = "RTD"
        Me.RTD.Size = New System.Drawing.Size(43, 20)
        Me.RTD.TabIndex = 300
        Me.RTD.TabStop = False
        Me.RTD.Tag = "C"
        Me.RTD.Text = "0.00"
        Me.RTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTD.ThemeName = "Windows8"
        '
        'RTUPrice
        '
        Me.RTUPrice.Location = New System.Drawing.Point(228, 242)
        Me.RTUPrice.Mask = "N2"
        Me.RTUPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTUPrice.Name = "RTUPrice"
        Me.RTUPrice.Size = New System.Drawing.Size(139, 20)
        Me.RTUPrice.TabIndex = 301
        Me.RTUPrice.TabStop = False
        Me.RTUPrice.Tag = "C"
        Me.RTUPrice.Text = "0.00"
        Me.RTUPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTUPrice.ThemeName = "Windows8"
        '
        'RTTotal
        '
        Me.RTTotal.Location = New System.Drawing.Point(228, 267)
        Me.RTTotal.Mask = "N2"
        Me.RTTotal.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTTotal.Name = "RTTotal"
        Me.RTTotal.ReadOnly = True
        Me.RTTotal.Size = New System.Drawing.Size(139, 20)
        Me.RTTotal.TabIndex = 302
        Me.RTTotal.TabStop = False
        Me.RTTotal.Tag = "C"
        Me.RTTotal.Text = "0.00"
        Me.RTTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTTotal.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(35, 331)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(57, 21)
        Me.RadLabel7.TabIndex = 303
        Me.RadLabel7.Text = "Remarks"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.Location = New System.Drawing.Point(140, 331)
        Me.txtRemarks.MaxLength = 100000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(227, 62)
        Me.txtRemarks.TabIndex = 304
        Me.txtRemarks.ThemeName = "Windows8"
        '
        'txtVenCode
        '
        Me.txtVenCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVenCode.Location = New System.Drawing.Point(228, 111)
        Me.txtVenCode.Name = "txtVenCode"
        Me.txtVenCode.ReadOnly = True
        Me.txtVenCode.Size = New System.Drawing.Size(139, 20)
        Me.txtVenCode.TabIndex = 305
        Me.txtVenCode.ThemeName = "Windows8"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(35, 111)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(85, 21)
        Me.RadLabel8.TabIndex = 306
        Me.RadLabel8.Text = "Vendor Code"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'dtpDelDate
        '
        Me.dtpDelDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelDate.Location = New System.Drawing.Point(228, 189)
        Me.dtpDelDate.Name = "dtpDelDate"
        Me.dtpDelDate.Size = New System.Drawing.Size(139, 20)
        Me.dtpDelDate.TabIndex = 307
        Me.dtpDelDate.TabStop = False
        Me.dtpDelDate.Text = "9/11/2014"
        Me.dtpDelDate.ThemeName = "Windows8"
        Me.dtpDelDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(35, 189)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(86, 21)
        Me.RadLabel9.TabIndex = 308
        Me.RadLabel9.Text = "Delivery Date"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(247, 399)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 309
        Me.btnClear.Text = "C&lear Field"
        Me.btnClear.ThemeName = "Windows8"
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(129, 418)
        Me.lblUserlvl.Name = "lblUserlvl"
        Me.lblUserlvl.Size = New System.Drawing.Size(46, 21)
        Me.lblUserlvl.TabIndex = 314
        Me.lblUserlvl.Text = "Userlvl"
        Me.lblUserlvl.ThemeName = "Windows8"
        Me.lblUserlvl.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(77, 418)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 21)
        Me.lblUserID.TabIndex = 313
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.ThemeName = "Windows8"
        Me.lblUserID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(35, 418)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 312
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Windows8"
        Me.lblDept.Visible = False
        '
        'txtSignature
        '
        Me.txtSignature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSignature.Location = New System.Drawing.Point(140, 293)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(227, 20)
        Me.txtSignature.TabIndex = 310
        Me.txtSignature.ThemeName = "Windows8"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(35, 293)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 311
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'FrmCPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 778)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dtpDelDate)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.txtVenCode)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.RTTotal)
        Me.Controls.Add(Me.RTUPrice)
        Me.Controls.Add(Me.RTD)
        Me.Controls.Add(Me.RTTPO)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ddlCurrency)
        Me.Controls.Add(Me.RadLabel21)
        Me.Controls.Add(Me.dtpMOrder)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.ddlSupSap)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.btnCPO)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.RadLabel24)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.rgvList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCPO"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "Windows8"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSupSap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTTPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTUPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDelDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtTotal As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCPO As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlSupSap As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpMOrder As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RTTPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RTD As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RTUPrice As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RTTotal As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtVenCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpDelDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
End Class


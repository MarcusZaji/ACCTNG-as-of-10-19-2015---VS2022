<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOChange
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOChange))
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem15 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem16 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem17 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem18 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem19 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem20 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem21 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem22 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem23 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem24 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem25 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.bwLoadDataPO = New System.ComponentModel.BackgroundWorker()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.dtpDelDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txtVenCode = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpMOrder = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCPO = New Telerik.WinControls.UI.RadButton()
        Me.rgvPOList = New Telerik.WinControls.UI.RadGridView()
        Me.Windows8Theme2 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rgvPOIList = New Telerik.WinControls.UI.RadGridView()
        Me.txtSupName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCurrency = New Telerik.WinControls.UI.RadTextBox()
        Me.btnBack = New Telerik.WinControls.UI.RadLabel()
        Me.bwLoadDataPOI = New System.ComponentModel.BackgroundWorker()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlSupSap = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPOCNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.RTUPrice = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RTTotal = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RTD = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RTTPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtTINNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCntctPrsn = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlCancel = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnPrintPOC = New Telerik.WinControls.UI.RadButton()
        Me.lblName = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.txtLTPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCalc = New Telerik.WinControls.UI.RadButton()
        Me.ddlVenCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.pbOlrayt = New Telerik.WinControls.UI.RadProgressBar()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        Me.ddlFYear = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlFMonth = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDelDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOIList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOIList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSupSap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOCNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTUPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RTTPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTINNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCntctPrsn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrintPOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLTPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlVenCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOlrayt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlFYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlFMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwLoadDataPO
        '
        Me.bwLoadDataPO.WorkerReportsProgress = True
        Me.bwLoadDataPO.WorkerSupportsCancellation = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(247, 528)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 341
        Me.btnClear.Text = "C&lear Field"
        Me.btnClear.ThemeName = "Windows8"
        '
        'dtpDelDate
        '
        Me.dtpDelDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelDate.Location = New System.Drawing.Point(228, 266)
        Me.dtpDelDate.Name = "dtpDelDate"
        Me.dtpDelDate.Size = New System.Drawing.Size(139, 20)
        Me.dtpDelDate.TabIndex = 339
        Me.dtpDelDate.TabStop = False
        Me.dtpDelDate.Text = "9/11/2014"
        Me.dtpDelDate.ThemeName = "Windows8"
        Me.dtpDelDate.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(35, 266)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(86, 21)
        Me.RadLabel9.TabIndex = 340
        Me.RadLabel9.Text = "Delivery Date"
        Me.RadLabel9.ThemeName = "Windows8"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(35, 97)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(85, 21)
        Me.RadLabel8.TabIndex = 338
        Me.RadLabel8.Text = "Vendor Code"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'txtVenCode
        '
        Me.txtVenCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVenCode.Location = New System.Drawing.Point(172, 97)
        Me.txtVenCode.Name = "txtVenCode"
        Me.txtVenCode.ReadOnly = True
        Me.txtVenCode.Size = New System.Drawing.Size(22, 20)
        Me.txtVenCode.TabIndex = 337
        Me.txtVenCode.ThemeName = "Windows8"
        Me.txtVenCode.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.IsReadOnly = True
        Me.txtRemarks.Location = New System.Drawing.Point(143, 396)
        Me.txtRemarks.MaxLength = 100000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(224, 62)
        Me.txtRemarks.TabIndex = 336
        Me.txtRemarks.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(35, 396)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(57, 21)
        Me.RadLabel7.TabIndex = 335
        Me.RadLabel7.Text = "Remarks"
        Me.RadLabel7.ThemeName = "Windows8"
        '
        'RadLabel21
        '
        Me.RadLabel21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel21.Location = New System.Drawing.Point(35, 123)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(59, 21)
        Me.RadLabel21.TabIndex = 324
        Me.RadLabel21.Text = "Currency"
        Me.RadLabel21.ThemeName = "Windows8"
        '
        'dtpMOrder
        '
        Me.dtpMOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMOrder.Location = New System.Drawing.Point(228, 240)
        Me.dtpMOrder.Name = "dtpMOrder"
        Me.dtpMOrder.Size = New System.Drawing.Size(139, 20)
        Me.dtpMOrder.TabIndex = 322
        Me.dtpMOrder.TabStop = False
        Me.dtpMOrder.Text = "9/11/2014"
        Me.dtpMOrder.ThemeName = "Windows8"
        Me.dtpMOrder.Value = New Date(2014, 9, 11, 11, 3, 56, 552)
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(35, 240)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(99, 21)
        Me.RadLabel5.TabIndex = 323
        Me.RadLabel5.Text = "Month Ordered"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(35, 71)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(55, 21)
        Me.RadLabel15.TabIndex = 320
        Me.RadLabel15.Text = "Supplier"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'btnCPO
        '
        Me.btnCPO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPO.Location = New System.Drawing.Point(247, 574)
        Me.btnCPO.Name = "btnCPO"
        Me.btnCPO.Size = New System.Drawing.Size(120, 40)
        Me.btnCPO.TabIndex = 319
        Me.btnCPO.Text = "Change PO"
        Me.btnCPO.ThemeName = "Windows8"
        '
        'rgvPOList
        '
        Me.rgvPOList.Location = New System.Drawing.Point(373, 1)
        '
        '
        '
        Me.rgvPOList.MasterTemplate.AllowAddNewRow = False
        Me.rgvPOList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvPOList.MasterTemplate.AllowColumnReorder = False
        Me.rgvPOList.MasterTemplate.AllowDeleteRow = False
        Me.rgvPOList.MasterTemplate.AllowEditRow = False
        Me.rgvPOList.MasterTemplate.EnableGrouping = False
        Me.rgvPOList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvPOList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvPOList.Name = "rgvPOList"
        Me.rgvPOList.Size = New System.Drawing.Size(852, 389)
        Me.rgvPOList.TabIndex = 316
        Me.rgvPOList.ThemeName = "Windows8"
        '
        'rgvPOIList
        '
        Me.rgvPOIList.Location = New System.Drawing.Point(373, 396)
        '
        '
        '
        Me.rgvPOIList.MasterTemplate.AllowAddNewRow = False
        Me.rgvPOIList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvPOIList.MasterTemplate.AllowColumnReorder = False
        Me.rgvPOIList.MasterTemplate.AllowEditRow = False
        Me.rgvPOIList.MasterTemplate.EnableGrouping = False
        Me.rgvPOIList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvPOIList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvPOIList.Name = "rgvPOIList"
        Me.rgvPOIList.Size = New System.Drawing.Size(852, 264)
        Me.rgvPOIList.TabIndex = 348
        Me.rgvPOIList.ThemeName = "Windows8"
        '
        'txtSupName
        '
        Me.txtSupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupName.Location = New System.Drawing.Point(200, 97)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.ReadOnly = True
        Me.txtSupName.Size = New System.Drawing.Size(22, 20)
        Me.txtSupName.TabIndex = 349
        Me.txtSupName.ThemeName = "Windows8"
        Me.txtSupName.Visible = False
        '
        'txtCurrency
        '
        Me.txtCurrency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrency.Location = New System.Drawing.Point(228, 123)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.ReadOnly = True
        Me.txtCurrency.Size = New System.Drawing.Size(139, 20)
        Me.txtCurrency.TabIndex = 350
        Me.txtCurrency.ThemeName = "Windows8"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack.Location = New System.Drawing.Point(2, 603)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(61, 57)
        Me.btnBack.TabIndex = 351
        '
        'bwLoadDataPOI
        '
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(88, 555)
        Me.lblUserlvl.Name = "lblUserlvl"
        Me.lblUserlvl.Size = New System.Drawing.Size(46, 21)
        Me.lblUserlvl.TabIndex = 356
        Me.lblUserlvl.Text = "Userlvl"
        Me.lblUserlvl.ThemeName = "Windows8"
        Me.lblUserlvl.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(81, 528)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 21)
        Me.lblUserID.TabIndex = 355
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.ThemeName = "Windows8"
        Me.lblUserID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(39, 528)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 354
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Windows8"
        Me.lblDept.Visible = False
        '
        'txtSignature
        '
        Me.txtSignature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSignature.Location = New System.Drawing.Point(178, 464)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(189, 20)
        Me.txtSignature.TabIndex = 352
        Me.txtSignature.ThemeName = "Windows8"
        Me.txtSignature.WordWrap = False
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(35, 464)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 353
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'ddlSupSap
        '
        Me.ddlSupSap.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlSupSap.Location = New System.Drawing.Point(140, 71)
        Me.ddlSupSap.Name = "ddlSupSap"
        Me.ddlSupSap.Size = New System.Drawing.Size(227, 20)
        Me.ddlSupSap.TabIndex = 357
        Me.ddlSupSap.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(187, 319)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(35, 21)
        Me.RadLabel6.TabIndex = 364
        Me.RadLabel6.Text = "Price"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(116, 319)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(18, 21)
        Me.RadLabel4.TabIndex = 365
        Me.RadLabel4.Text = "%"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(35, 292)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel3.TabIndex = 366
        Me.RadLabel3.Text = "Total PO"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(35, 319)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel2.TabIndex = 363
        Me.RadLabel2.Text = "Discount "
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(35, 344)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(36, 21)
        Me.RadLabel1.TabIndex = 362
        Me.RadLabel1.Text = "Total"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtPOCNo
        '
        Me.txtPOCNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOCNo.Location = New System.Drawing.Point(140, 45)
        Me.txtPOCNo.MaxLength = 11
        Me.txtPOCNo.Name = "txtPOCNo"
        Me.txtPOCNo.Size = New System.Drawing.Size(227, 20)
        Me.txtPOCNo.TabIndex = 367
        Me.txtPOCNo.ThemeName = "Windows8"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(35, 45)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(98, 21)
        Me.RadLabel10.TabIndex = 368
        Me.RadLabel10.Text = "PO Change No."
        Me.RadLabel10.ThemeName = "Windows8"
        '
        'RTUPrice
        '
        Me.RTUPrice.Location = New System.Drawing.Point(228, 318)
        Me.RTUPrice.Mask = "N6"
        Me.RTUPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTUPrice.Name = "RTUPrice"
        Me.RTUPrice.Size = New System.Drawing.Size(139, 20)
        Me.RTUPrice.TabIndex = 372
        Me.RTUPrice.TabStop = False
        Me.RTUPrice.Tag = "C"
        Me.RTUPrice.Text = "0.000000"
        Me.RTUPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTUPrice.ThemeName = "Windows8"
        '
        'RTTotal
        '
        Me.RTTotal.Location = New System.Drawing.Point(228, 344)
        Me.RTTotal.Mask = "N6"
        Me.RTTotal.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTTotal.Name = "RTTotal"
        Me.RTTotal.ReadOnly = True
        Me.RTTotal.Size = New System.Drawing.Size(139, 20)
        Me.RTTotal.TabIndex = 371
        Me.RTTotal.TabStop = False
        Me.RTTotal.Tag = "C"
        Me.RTTotal.Text = "0.000000"
        Me.RTTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTTotal.ThemeName = "Windows8"
        '
        'RTD
        '
        Me.RTD.Location = New System.Drawing.Point(140, 319)
        Me.RTD.Mask = "n6"
        Me.RTD.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTD.Name = "RTD"
        Me.RTD.Size = New System.Drawing.Size(43, 20)
        Me.RTD.TabIndex = 370
        Me.RTD.TabStop = False
        Me.RTD.Tag = "C"
        Me.RTD.Text = "0.000000"
        Me.RTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTD.ThemeName = "Windows8"
        '
        'RTTPO
        '
        Me.RTTPO.Location = New System.Drawing.Point(228, 292)
        Me.RTTPO.Mask = "N6"
        Me.RTTPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RTTPO.Name = "RTTPO"
        Me.RTTPO.ReadOnly = True
        Me.RTTPO.Size = New System.Drawing.Size(139, 20)
        Me.RTTPO.TabIndex = 369
        Me.RTTPO.TabStop = False
        Me.RTTPO.Tag = "C"
        Me.RTTPO.Text = "0.000000"
        Me.RTTPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RTTPO.ThemeName = "Windows8"
        '
        'txtTINNo
        '
        Me.txtTINNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTINNo.Location = New System.Drawing.Point(228, 149)
        Me.txtTINNo.Name = "txtTINNo"
        Me.txtTINNo.ReadOnly = True
        Me.txtTINNo.Size = New System.Drawing.Size(139, 20)
        Me.txtTINNo.TabIndex = 373
        Me.txtTINNo.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(35, 149)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(52, 21)
        Me.RadLabel11.TabIndex = 374
        Me.RadLabel11.Text = "TIN No."
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(35, 175)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(40, 21)
        Me.RadLabel13.TabIndex = 376
        Me.RadLabel13.Text = "ATTN"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'txtCntctPrsn
        '
        Me.txtCntctPrsn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCntctPrsn.Location = New System.Drawing.Point(228, 175)
        Me.txtCntctPrsn.Name = "txtCntctPrsn"
        Me.txtCntctPrsn.ReadOnly = True
        Me.txtCntctPrsn.Size = New System.Drawing.Size(139, 20)
        Me.txtCntctPrsn.TabIndex = 375
        Me.txtCntctPrsn.ThemeName = "Windows8"
        '
        'ddlCancel
        '
        Me.ddlCancel.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        RadListDataItem1.Text = "YES"
        RadListDataItem1.TextWrap = False
        RadListDataItem2.Text = "NO"
        Me.ddlCancel.Items.Add(RadListDataItem1)
        Me.ddlCancel.Items.Add(RadListDataItem2)
        Me.ddlCancel.Location = New System.Drawing.Point(228, 201)
        Me.ddlCancel.Name = "ddlCancel"
        Me.ddlCancel.Size = New System.Drawing.Size(139, 20)
        Me.ddlCancel.TabIndex = 377
        Me.ddlCancel.ThemeName = "Windows8"
        '
        'btnPrintPOC
        '
        Me.btnPrintPOC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPOC.Location = New System.Drawing.Point(247, 620)
        Me.btnPrintPOC.Name = "btnPrintPOC"
        Me.btnPrintPOC.Size = New System.Drawing.Size(120, 40)
        Me.btnPrintPOC.TabIndex = 378
        Me.btnPrintPOC.Text = "Print"
        Me.btnPrintPOC.ThemeName = "Windows8"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(39, 555)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 21)
        Me.lblName.TabIndex = 379
        Me.lblName.Text = "Name"
        Me.lblName.ThemeName = "Windows8"
        Me.lblName.Visible = False
        '
        'RadLabel14
        '
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel14.Location = New System.Drawing.Point(35, 201)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(46, 21)
        Me.RadLabel14.TabIndex = 380
        Me.RadLabel14.Text = "Cancel"
        Me.RadLabel14.ThemeName = "Windows8"
        '
        'txtLTPO
        '
        Me.txtLTPO.Location = New System.Drawing.Point(228, 370)
        Me.txtLTPO.Mask = "N6"
        Me.txtLTPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtLTPO.Name = "txtLTPO"
        Me.txtLTPO.ReadOnly = True
        Me.txtLTPO.Size = New System.Drawing.Size(139, 20)
        Me.txtLTPO.TabIndex = 381
        Me.txtLTPO.TabStop = False
        Me.txtLTPO.Tag = "C"
        Me.txtLTPO.Text = "0.000000"
        Me.txtLTPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLTPO.ThemeName = "Windows8"
        Me.txtLTPO.Visible = False
        '
        'RadLabel16
        '
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(35, 370)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(122, 21)
        Me.RadLabel16.TabIndex = 382
        Me.RadLabel16.Text = "Total Previous Price"
        Me.RadLabel16.ThemeName = "Windows8"
        Me.RadLabel16.Visible = False
        '
        'btnCalc
        '
        Me.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Image = Global.ACCTNG.My.Resources.Resources.Calc
        Me.btnCalc.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCalc.Location = New System.Drawing.Point(200, 528)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(43, 40)
        Me.btnCalc.TabIndex = 383
        Me.btnCalc.ThemeName = "Windows8"
        '
        'ddlVenCode
        '
        Me.ddlVenCode.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlVenCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlVenCode.Location = New System.Drawing.Point(228, 97)
        Me.ddlVenCode.Name = "ddlVenCode"
        Me.ddlVenCode.Size = New System.Drawing.Size(139, 20)
        Me.ddlVenCode.TabIndex = 384
        Me.ddlVenCode.ThemeName = "Windows8"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(279, 28)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblVersion.TabIndex = 385
        Me.lblVersion.Visible = False
        '
        'pbOlrayt
        '
        Me.pbOlrayt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pbOlrayt.ForeColor = System.Drawing.Color.White
        Me.pbOlrayt.Location = New System.Drawing.Point(12, 495)
        Me.pbOlrayt.Name = "pbOlrayt"
        Me.pbOlrayt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbOlrayt.SeparatorWidth = 2
        Me.pbOlrayt.Size = New System.Drawing.Size(355, 15)
        Me.pbOlrayt.Step = 1
        Me.pbOlrayt.TabIndex = 386
        Me.pbOlrayt.Text = "Loading..."
        Me.pbOlrayt.ThemeName = "TelerikMetroBlue"
        Me.pbOlrayt.Value2 = 1
        Me.pbOlrayt.Visible = False
        '
        'btnGo
        '
        Me.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGo.Location = New System.Drawing.Point(345, 18)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(22, 21)
        Me.btnGo.TabIndex = 397
        Me.btnGo.Text = "Go"
        Me.btnGo.ThemeName = "Windows8"
        '
        'ddlFYear
        '
        RadListDataItem3.Text = "2015"
        RadListDataItem4.Text = "2016"
        RadListDataItem5.Text = "2017"
        RadListDataItem6.Text = "2018"
        RadListDataItem7.Text = "2019"
        RadListDataItem8.Text = "2020"
        RadListDataItem9.Text = "2021"
        RadListDataItem10.Text = "2022"
        RadListDataItem11.Text = "2023"
        RadListDataItem12.Text = "2024"
        RadListDataItem13.Text = "2025"
        Me.ddlFYear.Items.Add(RadListDataItem3)
        Me.ddlFYear.Items.Add(RadListDataItem4)
        Me.ddlFYear.Items.Add(RadListDataItem5)
        Me.ddlFYear.Items.Add(RadListDataItem6)
        Me.ddlFYear.Items.Add(RadListDataItem7)
        Me.ddlFYear.Items.Add(RadListDataItem8)
        Me.ddlFYear.Items.Add(RadListDataItem9)
        Me.ddlFYear.Items.Add(RadListDataItem10)
        Me.ddlFYear.Items.Add(RadListDataItem11)
        Me.ddlFYear.Items.Add(RadListDataItem12)
        Me.ddlFYear.Items.Add(RadListDataItem13)
        Me.ddlFYear.Location = New System.Drawing.Point(278, 18)
        Me.ddlFYear.Name = "ddlFYear"
        Me.ddlFYear.Size = New System.Drawing.Size(64, 20)
        Me.ddlFYear.TabIndex = 396
        Me.ddlFYear.ThemeName = "Windows8"
        '
        'ddlFMonth
        '
        RadListDataItem14.Text = "01"
        RadListDataItem15.Text = "02"
        RadListDataItem16.Text = "03"
        RadListDataItem17.Text = "04"
        RadListDataItem18.Text = "05"
        RadListDataItem19.Text = "06"
        RadListDataItem20.Text = "07"
        RadListDataItem21.Text = "08"
        RadListDataItem22.Text = "09"
        RadListDataItem23.Text = "10"
        RadListDataItem24.Text = "11"
        RadListDataItem25.Text = "12"
        Me.ddlFMonth.Items.Add(RadListDataItem14)
        Me.ddlFMonth.Items.Add(RadListDataItem15)
        Me.ddlFMonth.Items.Add(RadListDataItem16)
        Me.ddlFMonth.Items.Add(RadListDataItem17)
        Me.ddlFMonth.Items.Add(RadListDataItem18)
        Me.ddlFMonth.Items.Add(RadListDataItem19)
        Me.ddlFMonth.Items.Add(RadListDataItem20)
        Me.ddlFMonth.Items.Add(RadListDataItem21)
        Me.ddlFMonth.Items.Add(RadListDataItem22)
        Me.ddlFMonth.Items.Add(RadListDataItem23)
        Me.ddlFMonth.Items.Add(RadListDataItem24)
        Me.ddlFMonth.Items.Add(RadListDataItem25)
        Me.ddlFMonth.Location = New System.Drawing.Point(228, 18)
        Me.ddlFMonth.Name = "ddlFMonth"
        Me.ddlFMonth.Size = New System.Drawing.Size(51, 20)
        Me.ddlFMonth.TabIndex = 395
        Me.ddlFMonth.ThemeName = "Windows8"
        '
        'RadLabel17
        '
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel17.Location = New System.Drawing.Point(35, 18)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(133, 21)
        Me.RadLabel17.TabIndex = 394
        Me.RadLabel17.Text = "Select Month to View"
        Me.RadLabel17.ThemeName = "Windows8"
        '
        'frmPOChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1210, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.ddlFYear)
        Me.Controls.Add(Me.ddlFMonth)
        Me.Controls.Add(Me.RadLabel17)
        Me.Controls.Add(Me.pbOlrayt)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.ddlVenCode)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.txtLTPO)
        Me.Controls.Add(Me.RadLabel14)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnPrintPOC)
        Me.Controls.Add(Me.ddlCancel)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.txtCntctPrsn)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.txtTINNo)
        Me.Controls.Add(Me.RTUPrice)
        Me.Controls.Add(Me.RTTotal)
        Me.Controls.Add(Me.RTD)
        Me.Controls.Add(Me.RTTPO)
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.txtPOCNo)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtSupName)
        Me.Controls.Add(Me.ddlSupSap)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.rgvPOIList)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dtpDelDate)
        Me.Controls.Add(Me.RadLabel9)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.txtVenCode)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.RadLabel21)
        Me.Controls.Add(Me.dtpMOrder)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.btnCPO)
        Me.Controls.Add(Me.rgvPOList)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPOChange"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Purchase Order Change"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDelDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOIList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOIList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSupSap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOCNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTUPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RTTPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTINNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCntctPrsn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrintPOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLTPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlVenCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOlrayt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlFYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlFMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents bwLoadDataPO As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtpDelDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtVenCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpMOrder As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCPO As Telerik.WinControls.UI.RadButton
    Friend WithEvents rgvPOList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Windows8Theme2 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rgvPOIList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtSupName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCurrency As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadDataPOI As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlSupSap As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPOCNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RTUPrice As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RTTotal As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RTD As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RTTPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtTINNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCntctPrsn As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCancel As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnPrintPOC As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtLTPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCalc As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlVenCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents pbOlrayt As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents btnGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlFYear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlFMonth As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
End Class


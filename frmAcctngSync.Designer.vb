<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcctngSync
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
        Me.components = New System.ComponentModel.Container()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcctngSync))
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition9 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition10 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition11 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition12 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition13 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rgvPOR1 = New Telerik.WinControls.UI.RadGridView()
        Me.rgvOPOR = New Telerik.WinControls.UI.RadGridView()
        Me.rgvPDN1 = New Telerik.WinControls.UI.RadGridView()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.rgvOPDN = New Telerik.WinControls.UI.RadGridView()
        Me.Windows8Theme2 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rgvOPCH = New Telerik.WinControls.UI.RadGridView()
        Me.rgvPCH1 = New Telerik.WinControls.UI.RadGridView()
        Me.rgvORPD = New Telerik.WinControls.UI.RadGridView()
        Me.rgvRPD1 = New Telerik.WinControls.UI.RadGridView()
        Me.rgvORPC = New Telerik.WinControls.UI.RadGridView()
        Me.rgvRPC1 = New Telerik.WinControls.UI.RadGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvOLDDATA = New Telerik.WinControls.UI.RadGridView()
        Me.rpvMain = New Telerik.WinControls.UI.RadPageView()
        Me.pvPOR1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataPOR1 = New Telerik.WinControls.UI.RadButton()
        Me.btnDeletePOR1 = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataPOR1 = New Telerik.WinControls.UI.RadButton()
        Me.pvOPOR = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataOPOR = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteOPOR = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataOPOR = New Telerik.WinControls.UI.RadButton()
        Me.pvPDN1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataPDN1 = New Telerik.WinControls.UI.RadButton()
        Me.btnDeletePDN1 = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataPDN1 = New Telerik.WinControls.UI.RadButton()
        Me.pvOPDN = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataOPDN = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteOPDN = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataOPDN = New Telerik.WinControls.UI.RadButton()
        Me.rvRPD1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataRPD1 = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteRPD1 = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataRPD1 = New Telerik.WinControls.UI.RadButton()
        Me.pvORPD = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataORPD = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteORPD = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataORPD = New Telerik.WinControls.UI.RadButton()
        Me.pvPCH1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblPCH1 = New System.Windows.Forms.Label()
        Me.btnGetDataPCH1 = New Telerik.WinControls.UI.RadButton()
        Me.btnDeletePCH1 = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataPCH1 = New Telerik.WinControls.UI.RadButton()
        Me.pvOPCH = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataOPCH = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteOPCH = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataOPCH = New Telerik.WinControls.UI.RadButton()
        Me.pvRPC1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataRPC1 = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteRPC1 = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataRPC1 = New Telerik.WinControls.UI.RadButton()
        Me.pvORPC = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnGetDataORPC = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteORPC = New Telerik.WinControls.UI.RadButton()
        Me.btnSyncDataORPC = New Telerik.WinControls.UI.RadButton()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvGetData = New Telerik.WinControls.UI.RadButton()
        Me.rgvSAP = New Telerik.WinControls.UI.RadGridView()
        Me.rgvBAP = New Telerik.WinControls.UI.RadGridView()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.lblCountMe = New Telerik.WinControls.UI.RadLabel()
        CType(Me.rgvPOR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPOR1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOPOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOPOR.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPDN1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPDN1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOPDN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOPDN.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOPCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOPCH.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPCH1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvPCH1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvORPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvORPD.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvRPD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvRPD1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvORPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvORPC.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvRPC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvRPC1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOLDDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOLDDATA.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rpvMain.SuspendLayout()
        Me.pvPOR1.SuspendLayout()
        CType(Me.btnGetDataPOR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeletePOR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataPOR1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvOPOR.SuspendLayout()
        CType(Me.btnGetDataOPOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteOPOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataOPOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvPDN1.SuspendLayout()
        CType(Me.btnGetDataPDN1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeletePDN1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataPDN1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvOPDN.SuspendLayout()
        CType(Me.btnGetDataOPDN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteOPDN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataOPDN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rvRPD1.SuspendLayout()
        CType(Me.btnGetDataRPD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteRPD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataRPD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvORPD.SuspendLayout()
        CType(Me.btnGetDataORPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteORPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataORPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvPCH1.SuspendLayout()
        CType(Me.btnGetDataPCH1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeletePCH1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataPCH1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvOPCH.SuspendLayout()
        CType(Me.btnGetDataOPCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteOPCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataOPCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvRPC1.SuspendLayout()
        CType(Me.btnGetDataRPC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteRPC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataRPC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvORPC.SuspendLayout()
        CType(Me.btnGetDataORPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteORPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSyncDataORPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSAP.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvBAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvBAP.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvPOR1
        '
        Me.rgvPOR1.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvPOR1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvPOR1.MasterTemplate.AllowCellContextMenu = False
        Me.rgvPOR1.MasterTemplate.AllowColumnReorder = False
        Me.rgvPOR1.MasterTemplate.AllowDeleteRow = False
        Me.rgvPOR1.MasterTemplate.AllowEditRow = False
        Me.rgvPOR1.MasterTemplate.EnableGrouping = False
        Me.rgvPOR1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvPOR1.Name = "rgvPOR1"
        Me.rgvPOR1.Size = New System.Drawing.Size(910, 454)
        Me.rgvPOR1.TabIndex = 23
        Me.rgvPOR1.ThemeName = "Windows8"
        '
        'rgvOPOR
        '
        Me.rgvOPOR.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvOPOR.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvOPOR.MasterTemplate.AllowCellContextMenu = False
        Me.rgvOPOR.MasterTemplate.AllowColumnReorder = False
        Me.rgvOPOR.MasterTemplate.AllowDeleteRow = False
        Me.rgvOPOR.MasterTemplate.AllowEditRow = False
        Me.rgvOPOR.MasterTemplate.EnableGrouping = False
        Me.rgvOPOR.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvOPOR.Name = "rgvOPOR"
        Me.rgvOPOR.Size = New System.Drawing.Size(910, 454)
        Me.rgvOPOR.TabIndex = 228
        Me.rgvOPOR.ThemeName = "Windows8"
        '
        'rgvPDN1
        '
        Me.rgvPDN1.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvPDN1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvPDN1.MasterTemplate.AllowCellContextMenu = False
        Me.rgvPDN1.MasterTemplate.AllowColumnReorder = False
        Me.rgvPDN1.MasterTemplate.AllowDeleteRow = False
        Me.rgvPDN1.MasterTemplate.AllowEditRow = False
        Me.rgvPDN1.MasterTemplate.EnableGrouping = False
        Me.rgvPDN1.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.rgvPDN1.Name = "rgvPDN1"
        Me.rgvPDN1.Size = New System.Drawing.Size(910, 454)
        Me.rgvPDN1.TabIndex = 291
        Me.rgvPDN1.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(0, 569)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 293
        '
        'rgvOPDN
        '
        Me.rgvOPDN.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvOPDN.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvOPDN.MasterTemplate.AllowCellContextMenu = False
        Me.rgvOPDN.MasterTemplate.AllowColumnReorder = False
        Me.rgvOPDN.MasterTemplate.AllowDeleteRow = False
        Me.rgvOPDN.MasterTemplate.AllowEditRow = False
        Me.rgvOPDN.MasterTemplate.EnableGrouping = False
        Me.rgvOPDN.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.rgvOPDN.Name = "rgvOPDN"
        Me.rgvOPDN.Size = New System.Drawing.Size(910, 454)
        Me.rgvOPDN.TabIndex = 294
        Me.rgvOPDN.ThemeName = "Windows8"
        '
        'rgvOPCH
        '
        Me.rgvOPCH.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvOPCH.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvOPCH.MasterTemplate.AllowCellContextMenu = False
        Me.rgvOPCH.MasterTemplate.AllowColumnReorder = False
        Me.rgvOPCH.MasterTemplate.AllowDeleteRow = False
        Me.rgvOPCH.MasterTemplate.AllowEditRow = False
        Me.rgvOPCH.MasterTemplate.EnableGrouping = False
        Me.rgvOPCH.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.rgvOPCH.Name = "rgvOPCH"
        Me.rgvOPCH.Size = New System.Drawing.Size(910, 454)
        Me.rgvOPCH.TabIndex = 302
        Me.rgvOPCH.ThemeName = "Windows8"
        '
        'rgvPCH1
        '
        Me.rgvPCH1.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvPCH1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvPCH1.MasterTemplate.AllowCellContextMenu = False
        Me.rgvPCH1.MasterTemplate.AllowColumnReorder = False
        Me.rgvPCH1.MasterTemplate.AllowDeleteRow = False
        Me.rgvPCH1.MasterTemplate.AllowEditRow = False
        Me.rgvPCH1.MasterTemplate.EnableGrouping = False
        Me.rgvPCH1.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.rgvPCH1.Name = "rgvPCH1"
        Me.rgvPCH1.Size = New System.Drawing.Size(910, 454)
        Me.rgvPCH1.TabIndex = 300
        Me.rgvPCH1.ThemeName = "Windows8"
        '
        'rgvORPD
        '
        Me.rgvORPD.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvORPD.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvORPD.MasterTemplate.AllowCellContextMenu = False
        Me.rgvORPD.MasterTemplate.AllowColumnReorder = False
        Me.rgvORPD.MasterTemplate.AllowDeleteRow = False
        Me.rgvORPD.MasterTemplate.AllowEditRow = False
        Me.rgvORPD.MasterTemplate.EnableGrouping = False
        Me.rgvORPD.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.rgvORPD.Name = "rgvORPD"
        Me.rgvORPD.Size = New System.Drawing.Size(910, 454)
        Me.rgvORPD.TabIndex = 297
        Me.rgvORPD.ThemeName = "Windows8"
        '
        'rgvRPD1
        '
        Me.rgvRPD1.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvRPD1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvRPD1.MasterTemplate.AllowCellContextMenu = False
        Me.rgvRPD1.MasterTemplate.AllowColumnReorder = False
        Me.rgvRPD1.MasterTemplate.AllowDeleteRow = False
        Me.rgvRPD1.MasterTemplate.AllowEditRow = False
        Me.rgvRPD1.MasterTemplate.EnableGrouping = False
        Me.rgvRPD1.MasterTemplate.ViewDefinition = TableViewDefinition8
        Me.rgvRPD1.Name = "rgvRPD1"
        Me.rgvRPD1.Size = New System.Drawing.Size(910, 454)
        Me.rgvRPD1.TabIndex = 296
        Me.rgvRPD1.ThemeName = "Windows8"
        '
        'rgvORPC
        '
        Me.rgvORPC.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvORPC.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvORPC.MasterTemplate.AllowCellContextMenu = False
        Me.rgvORPC.MasterTemplate.AllowColumnReorder = False
        Me.rgvORPC.MasterTemplate.AllowDeleteRow = False
        Me.rgvORPC.MasterTemplate.AllowEditRow = False
        Me.rgvORPC.MasterTemplate.EnableGrouping = False
        Me.rgvORPC.MasterTemplate.ViewDefinition = TableViewDefinition9
        Me.rgvORPC.Name = "rgvORPC"
        Me.rgvORPC.Size = New System.Drawing.Size(910, 454)
        Me.rgvORPC.TabIndex = 305
        Me.rgvORPC.ThemeName = "Windows8"
        '
        'rgvRPC1
        '
        Me.rgvRPC1.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvRPC1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvRPC1.MasterTemplate.AllowCellContextMenu = False
        Me.rgvRPC1.MasterTemplate.AllowColumnReorder = False
        Me.rgvRPC1.MasterTemplate.AllowDeleteRow = False
        Me.rgvRPC1.MasterTemplate.AllowEditRow = False
        Me.rgvRPC1.MasterTemplate.EnableGrouping = False
        Me.rgvRPC1.MasterTemplate.ViewDefinition = TableViewDefinition10
        Me.rgvRPC1.Name = "rgvRPC1"
        Me.rgvRPC1.Size = New System.Drawing.Size(910, 454)
        Me.rgvRPC1.TabIndex = 304
        Me.rgvRPC1.ThemeName = "Windows8"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(472, 562)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(70, 21)
        Me.RadLabel10.TabIndex = 312
        Me.RadLabel10.Text = "OLD DATA"
        Me.RadLabel10.ThemeName = "Windows8"
        Me.RadLabel10.Visible = False
        '
        'rgvOLDDATA
        '
        Me.rgvOLDDATA.Location = New System.Drawing.Point(548, 562)
        '
        '
        '
        Me.rgvOLDDATA.MasterTemplate.AllowCellContextMenu = False
        Me.rgvOLDDATA.MasterTemplate.AllowColumnReorder = False
        Me.rgvOLDDATA.MasterTemplate.AllowDeleteRow = False
        Me.rgvOLDDATA.MasterTemplate.AllowEditRow = False
        Me.rgvOLDDATA.MasterTemplate.EnableGrouping = False
        Me.rgvOLDDATA.MasterTemplate.ViewDefinition = TableViewDefinition11
        Me.rgvOLDDATA.Name = "rgvOLDDATA"
        Me.rgvOLDDATA.Size = New System.Drawing.Size(155, 64)
        Me.rgvOLDDATA.TabIndex = 311
        Me.rgvOLDDATA.ThemeName = "Windows8"
        Me.rgvOLDDATA.Visible = False
        '
        'rpvMain
        '
        Me.rpvMain.Controls.Add(Me.pvPOR1)
        Me.rpvMain.Controls.Add(Me.pvOPOR)
        Me.rpvMain.Controls.Add(Me.pvPDN1)
        Me.rpvMain.Controls.Add(Me.pvOPDN)
        Me.rpvMain.Controls.Add(Me.rvRPD1)
        Me.rpvMain.Controls.Add(Me.pvORPD)
        Me.rpvMain.Controls.Add(Me.pvPCH1)
        Me.rpvMain.Controls.Add(Me.pvOPCH)
        Me.rpvMain.Controls.Add(Me.pvRPC1)
        Me.rpvMain.Controls.Add(Me.pvORPC)
        Me.rpvMain.Controls.Add(Me.RadPageViewPage1)
        Me.rpvMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.rpvMain.Location = New System.Drawing.Point(0, 0)
        Me.rpvMain.Name = "rpvMain"
        Me.rpvMain.SelectedPage = Me.pvPDN1
        Me.rpvMain.Size = New System.Drawing.Size(920, 556)
        Me.rpvMain.TabIndex = 313
        Me.rpvMain.ThemeName = "TelerikMetroBlue"
        '
        'pvPOR1
        '
        Me.pvPOR1.Controls.Add(Me.btnGetDataPOR1)
        Me.pvPOR1.Controls.Add(Me.btnDeletePOR1)
        Me.pvPOR1.Controls.Add(Me.btnSyncDataPOR1)
        Me.pvPOR1.Controls.Add(Me.rgvPOR1)
        Me.pvPOR1.ItemSize = New System.Drawing.SizeF(43.0!, 25.0!)
        Me.pvPOR1.Location = New System.Drawing.Point(5, 31)
        Me.pvPOR1.Name = "pvPOR1"
        Me.pvPOR1.Size = New System.Drawing.Size(910, 520)
        Me.pvPOR1.Text = "POR1"
        '
        'btnGetDataPOR1
        '
        Me.btnGetDataPOR1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataPOR1.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataPOR1.Name = "btnGetDataPOR1"
        Me.btnGetDataPOR1.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataPOR1.TabIndex = 316
        Me.btnGetDataPOR1.Text = "Data from SAP"
        Me.btnGetDataPOR1.ThemeName = "Windows8"
        '
        'btnDeletePOR1
        '
        Me.btnDeletePOR1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePOR1.Location = New System.Drawing.Point(0, 460)
        Me.btnDeletePOR1.Name = "btnDeletePOR1"
        Me.btnDeletePOR1.Size = New System.Drawing.Size(120, 40)
        Me.btnDeletePOR1.TabIndex = 315
        Me.btnDeletePOR1.Text = "Delete"
        Me.btnDeletePOR1.ThemeName = "Windows8"
        '
        'btnSyncDataPOR1
        '
        Me.btnSyncDataPOR1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataPOR1.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataPOR1.Name = "btnSyncDataPOR1"
        Me.btnSyncDataPOR1.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataPOR1.TabIndex = 314
        Me.btnSyncDataPOR1.Text = "Sync Data"
        Me.btnSyncDataPOR1.ThemeName = "Windows8"
        '
        'pvOPOR
        '
        Me.pvOPOR.Controls.Add(Me.btnGetDataOPOR)
        Me.pvOPOR.Controls.Add(Me.btnDeleteOPOR)
        Me.pvOPOR.Controls.Add(Me.btnSyncDataOPOR)
        Me.pvOPOR.Controls.Add(Me.rgvOPOR)
        Me.pvOPOR.ItemSize = New System.Drawing.SizeF(45.0!, 25.0!)
        Me.pvOPOR.Location = New System.Drawing.Point(5, 31)
        Me.pvOPOR.Name = "pvOPOR"
        Me.pvOPOR.Size = New System.Drawing.Size(910, 520)
        Me.pvOPOR.Text = "OPOR"
        '
        'btnGetDataOPOR
        '
        Me.btnGetDataOPOR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataOPOR.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataOPOR.Name = "btnGetDataOPOR"
        Me.btnGetDataOPOR.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataOPOR.TabIndex = 319
        Me.btnGetDataOPOR.Text = "Data from SAP"
        Me.btnGetDataOPOR.ThemeName = "Windows8"
        '
        'btnDeleteOPOR
        '
        Me.btnDeleteOPOR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOPOR.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteOPOR.Name = "btnDeleteOPOR"
        Me.btnDeleteOPOR.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteOPOR.TabIndex = 318
        Me.btnDeleteOPOR.Text = "Delete"
        Me.btnDeleteOPOR.ThemeName = "Windows8"
        '
        'btnSyncDataOPOR
        '
        Me.btnSyncDataOPOR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataOPOR.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataOPOR.Name = "btnSyncDataOPOR"
        Me.btnSyncDataOPOR.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataOPOR.TabIndex = 317
        Me.btnSyncDataOPOR.Text = "Sync Data"
        Me.btnSyncDataOPOR.ThemeName = "Windows8"
        '
        'pvPDN1
        '
        Me.pvPDN1.Controls.Add(Me.btnGetDataPDN1)
        Me.pvPDN1.Controls.Add(Me.rgvPDN1)
        Me.pvPDN1.Controls.Add(Me.btnDeletePDN1)
        Me.pvPDN1.Controls.Add(Me.btnSyncDataPDN1)
        Me.pvPDN1.ItemSize = New System.Drawing.SizeF(44.0!, 25.0!)
        Me.pvPDN1.Location = New System.Drawing.Point(5, 31)
        Me.pvPDN1.Name = "pvPDN1"
        Me.pvPDN1.Size = New System.Drawing.Size(910, 520)
        Me.pvPDN1.Text = "PDN1"
        '
        'btnGetDataPDN1
        '
        Me.btnGetDataPDN1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataPDN1.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataPDN1.Name = "btnGetDataPDN1"
        Me.btnGetDataPDN1.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataPDN1.TabIndex = 319
        Me.btnGetDataPDN1.Text = "Data from SAP"
        Me.btnGetDataPDN1.ThemeName = "Windows8"
        '
        'btnDeletePDN1
        '
        Me.btnDeletePDN1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePDN1.Location = New System.Drawing.Point(0, 460)
        Me.btnDeletePDN1.Name = "btnDeletePDN1"
        Me.btnDeletePDN1.Size = New System.Drawing.Size(120, 40)
        Me.btnDeletePDN1.TabIndex = 318
        Me.btnDeletePDN1.Text = "Delete"
        Me.btnDeletePDN1.ThemeName = "Windows8"
        '
        'btnSyncDataPDN1
        '
        Me.btnSyncDataPDN1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataPDN1.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataPDN1.Name = "btnSyncDataPDN1"
        Me.btnSyncDataPDN1.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataPDN1.TabIndex = 317
        Me.btnSyncDataPDN1.Text = "Sync Data"
        Me.btnSyncDataPDN1.ThemeName = "Windows8"
        '
        'pvOPDN
        '
        Me.pvOPDN.Controls.Add(Me.btnGetDataOPDN)
        Me.pvOPDN.Controls.Add(Me.btnDeleteOPDN)
        Me.pvOPDN.Controls.Add(Me.btnSyncDataOPDN)
        Me.pvOPDN.Controls.Add(Me.rgvOPDN)
        Me.pvOPDN.ItemSize = New System.Drawing.SizeF(47.0!, 25.0!)
        Me.pvOPDN.Location = New System.Drawing.Point(5, 31)
        Me.pvOPDN.Name = "pvOPDN"
        Me.pvOPDN.Size = New System.Drawing.Size(910, 520)
        Me.pvOPDN.Text = "OPDN"
        '
        'btnGetDataOPDN
        '
        Me.btnGetDataOPDN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataOPDN.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataOPDN.Name = "btnGetDataOPDN"
        Me.btnGetDataOPDN.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataOPDN.TabIndex = 319
        Me.btnGetDataOPDN.Text = "Data from SAP"
        Me.btnGetDataOPDN.ThemeName = "Windows8"
        '
        'btnDeleteOPDN
        '
        Me.btnDeleteOPDN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOPDN.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteOPDN.Name = "btnDeleteOPDN"
        Me.btnDeleteOPDN.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteOPDN.TabIndex = 318
        Me.btnDeleteOPDN.Text = "Delete"
        Me.btnDeleteOPDN.ThemeName = "Windows8"
        '
        'btnSyncDataOPDN
        '
        Me.btnSyncDataOPDN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataOPDN.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataOPDN.Name = "btnSyncDataOPDN"
        Me.btnSyncDataOPDN.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataOPDN.TabIndex = 317
        Me.btnSyncDataOPDN.Text = "Sync Data"
        Me.btnSyncDataOPDN.ThemeName = "Windows8"
        '
        'rvRPD1
        '
        Me.rvRPD1.Controls.Add(Me.btnGetDataRPD1)
        Me.rvRPD1.Controls.Add(Me.rgvRPD1)
        Me.rvRPD1.Controls.Add(Me.btnDeleteRPD1)
        Me.rvRPD1.Controls.Add(Me.btnSyncDataRPD1)
        Me.rvRPD1.ItemSize = New System.Drawing.SizeF(42.0!, 25.0!)
        Me.rvRPD1.Location = New System.Drawing.Point(5, 31)
        Me.rvRPD1.Name = "rvRPD1"
        Me.rvRPD1.Size = New System.Drawing.Size(910, 520)
        Me.rvRPD1.Text = "RPD1"
        '
        'btnGetDataRPD1
        '
        Me.btnGetDataRPD1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataRPD1.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataRPD1.Name = "btnGetDataRPD1"
        Me.btnGetDataRPD1.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataRPD1.TabIndex = 319
        Me.btnGetDataRPD1.Text = "Data from SAP"
        Me.btnGetDataRPD1.ThemeName = "Windows8"
        '
        'btnDeleteRPD1
        '
        Me.btnDeleteRPD1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRPD1.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteRPD1.Name = "btnDeleteRPD1"
        Me.btnDeleteRPD1.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteRPD1.TabIndex = 318
        Me.btnDeleteRPD1.Text = "Delete"
        Me.btnDeleteRPD1.ThemeName = "Windows8"
        '
        'btnSyncDataRPD1
        '
        Me.btnSyncDataRPD1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataRPD1.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataRPD1.Name = "btnSyncDataRPD1"
        Me.btnSyncDataRPD1.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataRPD1.TabIndex = 317
        Me.btnSyncDataRPD1.Text = "Sync Data"
        Me.btnSyncDataRPD1.ThemeName = "Windows8"
        '
        'pvORPD
        '
        Me.pvORPD.Controls.Add(Me.btnGetDataORPD)
        Me.pvORPD.Controls.Add(Me.rgvORPD)
        Me.pvORPD.Controls.Add(Me.btnDeleteORPD)
        Me.pvORPD.Controls.Add(Me.btnSyncDataORPD)
        Me.pvORPD.ItemSize = New System.Drawing.SizeF(45.0!, 25.0!)
        Me.pvORPD.Location = New System.Drawing.Point(5, 31)
        Me.pvORPD.Name = "pvORPD"
        Me.pvORPD.Size = New System.Drawing.Size(910, 520)
        Me.pvORPD.Text = "ORPD"
        '
        'btnGetDataORPD
        '
        Me.btnGetDataORPD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataORPD.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataORPD.Name = "btnGetDataORPD"
        Me.btnGetDataORPD.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataORPD.TabIndex = 319
        Me.btnGetDataORPD.Text = "Data from SAP"
        Me.btnGetDataORPD.ThemeName = "Windows8"
        '
        'btnDeleteORPD
        '
        Me.btnDeleteORPD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteORPD.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteORPD.Name = "btnDeleteORPD"
        Me.btnDeleteORPD.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteORPD.TabIndex = 318
        Me.btnDeleteORPD.Text = "Delete"
        Me.btnDeleteORPD.ThemeName = "Windows8"
        '
        'btnSyncDataORPD
        '
        Me.btnSyncDataORPD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataORPD.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataORPD.Name = "btnSyncDataORPD"
        Me.btnSyncDataORPD.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataORPD.TabIndex = 317
        Me.btnSyncDataORPD.Text = "Sync Data"
        Me.btnSyncDataORPD.ThemeName = "Windows8"
        '
        'pvPCH1
        '
        Me.pvPCH1.Controls.Add(Me.lblPCH1)
        Me.pvPCH1.Controls.Add(Me.btnGetDataPCH1)
        Me.pvPCH1.Controls.Add(Me.btnDeletePCH1)
        Me.pvPCH1.Controls.Add(Me.btnSyncDataPCH1)
        Me.pvPCH1.Controls.Add(Me.rgvPCH1)
        Me.pvPCH1.ItemSize = New System.Drawing.SizeF(43.0!, 25.0!)
        Me.pvPCH1.Location = New System.Drawing.Point(5, 31)
        Me.pvPCH1.Name = "pvPCH1"
        Me.pvPCH1.Size = New System.Drawing.Size(910, 520)
        Me.pvPCH1.Text = "PCH1"
        '
        'lblPCH1
        '
        Me.lblPCH1.AutoSize = True
        Me.lblPCH1.Location = New System.Drawing.Point(617, 475)
        Me.lblPCH1.Name = "lblPCH1"
        Me.lblPCH1.Size = New System.Drawing.Size(40, 15)
        Me.lblPCH1.TabIndex = 320
        Me.lblPCH1.Text = "Count"
        '
        'btnGetDataPCH1
        '
        Me.btnGetDataPCH1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataPCH1.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataPCH1.Name = "btnGetDataPCH1"
        Me.btnGetDataPCH1.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataPCH1.TabIndex = 319
        Me.btnGetDataPCH1.Text = "Data from SAP"
        Me.btnGetDataPCH1.ThemeName = "Windows8"
        '
        'btnDeletePCH1
        '
        Me.btnDeletePCH1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePCH1.Location = New System.Drawing.Point(0, 460)
        Me.btnDeletePCH1.Name = "btnDeletePCH1"
        Me.btnDeletePCH1.Size = New System.Drawing.Size(120, 40)
        Me.btnDeletePCH1.TabIndex = 318
        Me.btnDeletePCH1.Text = "Delete"
        Me.btnDeletePCH1.ThemeName = "Windows8"
        '
        'btnSyncDataPCH1
        '
        Me.btnSyncDataPCH1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataPCH1.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataPCH1.Name = "btnSyncDataPCH1"
        Me.btnSyncDataPCH1.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataPCH1.TabIndex = 317
        Me.btnSyncDataPCH1.Text = "Sync Data"
        Me.btnSyncDataPCH1.ThemeName = "Windows8"
        '
        'pvOPCH
        '
        Me.pvOPCH.Controls.Add(Me.btnGetDataOPCH)
        Me.pvOPCH.Controls.Add(Me.btnDeleteOPCH)
        Me.pvOPCH.Controls.Add(Me.btnSyncDataOPCH)
        Me.pvOPCH.Controls.Add(Me.rgvOPCH)
        Me.pvOPCH.ItemSize = New System.Drawing.SizeF(45.0!, 25.0!)
        Me.pvOPCH.Location = New System.Drawing.Point(5, 31)
        Me.pvOPCH.Name = "pvOPCH"
        Me.pvOPCH.Size = New System.Drawing.Size(910, 520)
        Me.pvOPCH.Text = "OPCH"
        '
        'btnGetDataOPCH
        '
        Me.btnGetDataOPCH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataOPCH.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataOPCH.Name = "btnGetDataOPCH"
        Me.btnGetDataOPCH.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataOPCH.TabIndex = 319
        Me.btnGetDataOPCH.Text = "Data from SAP"
        Me.btnGetDataOPCH.ThemeName = "Windows8"
        '
        'btnDeleteOPCH
        '
        Me.btnDeleteOPCH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOPCH.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteOPCH.Name = "btnDeleteOPCH"
        Me.btnDeleteOPCH.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteOPCH.TabIndex = 318
        Me.btnDeleteOPCH.Text = "Delete"
        Me.btnDeleteOPCH.ThemeName = "Windows8"
        '
        'btnSyncDataOPCH
        '
        Me.btnSyncDataOPCH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataOPCH.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataOPCH.Name = "btnSyncDataOPCH"
        Me.btnSyncDataOPCH.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataOPCH.TabIndex = 317
        Me.btnSyncDataOPCH.Text = "Sync Data"
        Me.btnSyncDataOPCH.ThemeName = "Windows8"
        '
        'pvRPC1
        '
        Me.pvRPC1.Controls.Add(Me.btnGetDataRPC1)
        Me.pvRPC1.Controls.Add(Me.btnDeleteRPC1)
        Me.pvRPC1.Controls.Add(Me.btnSyncDataRPC1)
        Me.pvRPC1.Controls.Add(Me.rgvRPC1)
        Me.pvRPC1.ItemSize = New System.Drawing.SizeF(41.0!, 25.0!)
        Me.pvRPC1.Location = New System.Drawing.Point(5, 31)
        Me.pvRPC1.Name = "pvRPC1"
        Me.pvRPC1.Size = New System.Drawing.Size(910, 520)
        Me.pvRPC1.Text = "RPC1"
        '
        'btnGetDataRPC1
        '
        Me.btnGetDataRPC1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataRPC1.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataRPC1.Name = "btnGetDataRPC1"
        Me.btnGetDataRPC1.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataRPC1.TabIndex = 319
        Me.btnGetDataRPC1.Text = "Data from SAP"
        Me.btnGetDataRPC1.ThemeName = "Windows8"
        '
        'btnDeleteRPC1
        '
        Me.btnDeleteRPC1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRPC1.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteRPC1.Name = "btnDeleteRPC1"
        Me.btnDeleteRPC1.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteRPC1.TabIndex = 318
        Me.btnDeleteRPC1.Text = "Delete"
        Me.btnDeleteRPC1.ThemeName = "Windows8"
        '
        'btnSyncDataRPC1
        '
        Me.btnSyncDataRPC1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataRPC1.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataRPC1.Name = "btnSyncDataRPC1"
        Me.btnSyncDataRPC1.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataRPC1.TabIndex = 317
        Me.btnSyncDataRPC1.Text = "Sync Data"
        Me.btnSyncDataRPC1.ThemeName = "Windows8"
        '
        'pvORPC
        '
        Me.pvORPC.Controls.Add(Me.btnGetDataORPC)
        Me.pvORPC.Controls.Add(Me.btnDeleteORPC)
        Me.pvORPC.Controls.Add(Me.btnSyncDataORPC)
        Me.pvORPC.Controls.Add(Me.rgvORPC)
        Me.pvORPC.ItemSize = New System.Drawing.SizeF(44.0!, 25.0!)
        Me.pvORPC.Location = New System.Drawing.Point(5, 31)
        Me.pvORPC.Name = "pvORPC"
        Me.pvORPC.Size = New System.Drawing.Size(910, 520)
        Me.pvORPC.Text = "ORPC"
        '
        'btnGetDataORPC
        '
        Me.btnGetDataORPC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDataORPC.Location = New System.Drawing.Point(664, 460)
        Me.btnGetDataORPC.Name = "btnGetDataORPC"
        Me.btnGetDataORPC.Size = New System.Drawing.Size(120, 40)
        Me.btnGetDataORPC.TabIndex = 319
        Me.btnGetDataORPC.Text = "Data from SAP"
        Me.btnGetDataORPC.ThemeName = "Windows8"
        '
        'btnDeleteORPC
        '
        Me.btnDeleteORPC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteORPC.Location = New System.Drawing.Point(0, 460)
        Me.btnDeleteORPC.Name = "btnDeleteORPC"
        Me.btnDeleteORPC.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteORPC.TabIndex = 318
        Me.btnDeleteORPC.Text = "Delete"
        Me.btnDeleteORPC.ThemeName = "Windows8"
        '
        'btnSyncDataORPC
        '
        Me.btnSyncDataORPC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncDataORPC.Location = New System.Drawing.Point(790, 460)
        Me.btnSyncDataORPC.Name = "btnSyncDataORPC"
        Me.btnSyncDataORPC.Size = New System.Drawing.Size(120, 40)
        Me.btnSyncDataORPC.TabIndex = 317
        Me.btnSyncDataORPC.Text = "Sync Data"
        Me.btnSyncDataORPC.ThemeName = "Windows8"
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.RadLabel2)
        Me.RadPageViewPage1.Controls.Add(Me.RadLabel1)
        Me.RadPageViewPage1.Controls.Add(Me.rgvGetData)
        Me.RadPageViewPage1.Controls.Add(Me.rgvSAP)
        Me.RadPageViewPage1.Controls.Add(Me.rgvBAP)
        Me.RadPageViewPage1.ItemSize = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(5, 31)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(910, 520)
        Me.RadPageViewPage1.Text = "CHECK"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(0, 108)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(26, 18)
        Me.RadLabel2.TabIndex = 310
        Me.RadLabel2.Text = "SAP"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(0, 9)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(26, 18)
        Me.RadLabel1.TabIndex = 309
        Me.RadLabel1.Text = "BAP"
        '
        'rgvGetData
        '
        Me.rgvGetData.Location = New System.Drawing.Point(0, 225)
        Me.rgvGetData.Name = "rgvGetData"
        Me.rgvGetData.Size = New System.Drawing.Size(114, 40)
        Me.rgvGetData.TabIndex = 308
        Me.rgvGetData.Text = "CHECK DATA"
        Me.rgvGetData.ThemeName = "VisualStudio2012Dark"
        '
        'rgvSAP
        '
        Me.rgvSAP.Location = New System.Drawing.Point(0, 132)
        '
        '
        '
        Me.rgvSAP.MasterTemplate.AllowAddNewRow = False
        Me.rgvSAP.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSAP.MasterTemplate.AllowColumnReorder = False
        Me.rgvSAP.MasterTemplate.AllowDeleteRow = False
        Me.rgvSAP.MasterTemplate.AllowEditRow = False
        Me.rgvSAP.MasterTemplate.EnableGrouping = False
        Me.rgvSAP.MasterTemplate.EnableSorting = False
        Me.rgvSAP.MasterTemplate.ViewDefinition = TableViewDefinition12
        Me.rgvSAP.Name = "rgvSAP"
        Me.rgvSAP.Size = New System.Drawing.Size(515, 53)
        Me.rgvSAP.TabIndex = 307
        Me.rgvSAP.ThemeName = "VisualStudio2012Dark"
        '
        'rgvBAP
        '
        Me.rgvBAP.Location = New System.Drawing.Point(0, 33)
        '
        '
        '
        Me.rgvBAP.MasterTemplate.AllowAddNewRow = False
        Me.rgvBAP.MasterTemplate.AllowCellContextMenu = False
        Me.rgvBAP.MasterTemplate.AllowColumnReorder = False
        Me.rgvBAP.MasterTemplate.AllowDeleteRow = False
        Me.rgvBAP.MasterTemplate.AllowEditRow = False
        Me.rgvBAP.MasterTemplate.EnableGrouping = False
        Me.rgvBAP.MasterTemplate.EnableSorting = False
        Me.rgvBAP.MasterTemplate.ViewDefinition = TableViewDefinition13
        Me.rgvBAP.Name = "rgvBAP"
        Me.rgvBAP.Size = New System.Drawing.Size(515, 53)
        Me.rgvBAP.TabIndex = 306
        Me.rgvBAP.ThemeName = "VisualStudio2012Dark"
        '
        'lblCountMe
        '
        Me.lblCountMe.Location = New System.Drawing.Point(259, 569)
        Me.lblCountMe.Name = "lblCountMe"
        Me.lblCountMe.Size = New System.Drawing.Size(36, 18)
        Me.lblCountMe.TabIndex = 314
        Me.lblCountMe.Text = "Count"
        '
        'frmAcctngSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 666)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCountMe)
        Me.Controls.Add(Me.rpvMain)
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.rgvOLDDATA)
        Me.Controls.Add(Me.lblBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAcctngSync"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Sync Data from SAPB1"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.rgvPOR1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPOR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOPOR.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOPOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPDN1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPDN1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOPDN.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOPDN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOPCH.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOPCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPCH1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvPCH1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvORPD.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvORPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvRPD1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvRPD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvORPC.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvORPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvRPC1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvRPC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOLDDATA.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOLDDATA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rpvMain.ResumeLayout(False)
        Me.pvPOR1.ResumeLayout(False)
        CType(Me.btnGetDataPOR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeletePOR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataPOR1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvOPOR.ResumeLayout(False)
        CType(Me.btnGetDataOPOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteOPOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataOPOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvPDN1.ResumeLayout(False)
        CType(Me.btnGetDataPDN1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeletePDN1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataPDN1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvOPDN.ResumeLayout(False)
        CType(Me.btnGetDataOPDN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteOPDN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataOPDN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rvRPD1.ResumeLayout(False)
        CType(Me.btnGetDataRPD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteRPD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataRPD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvORPD.ResumeLayout(False)
        CType(Me.btnGetDataORPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteORPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataORPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvPCH1.ResumeLayout(False)
        Me.pvPCH1.PerformLayout()
        CType(Me.btnGetDataPCH1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeletePCH1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataPCH1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvOPCH.ResumeLayout(False)
        CType(Me.btnGetDataOPCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteOPCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataOPCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvRPC1.ResumeLayout(False)
        CType(Me.btnGetDataRPC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteRPC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataRPC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvORPC.ResumeLayout(False)
        CType(Me.btnGetDataORPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteORPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSyncDataORPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage1.ResumeLayout(False)
        Me.RadPageViewPage1.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvGetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSAP.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvBAP.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvBAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rgvPOR1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvOPOR As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvPDN1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvOPDN As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvPCH1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Windows8Theme2 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rgvOPCH As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvORPD As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvRPD1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvORPC As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvRPC1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvOLDDATA As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rpvMain As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pvPOR1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvOPOR As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvPDN1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvOPDN As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rvRPD1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvORPD As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvPCH1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvOPCH As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvRPC1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvORPC As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents btnGetDataPOR1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeletePOR1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataPOR1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataOPOR As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteOPOR As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataOPOR As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataPDN1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeletePDN1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataPDN1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataOPDN As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteOPDN As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataOPDN As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataRPD1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteRPD1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataRPD1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataORPD As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteORPD As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataORPD As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataPCH1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeletePCH1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataPCH1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataOPCH As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteOPCH As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataOPCH As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataRPC1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteRPC1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataRPC1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGetDataORPC As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteORPC As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSyncDataORPC As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblPCH1 As System.Windows.Forms.Label
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rgvSAP As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvBAP As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvGetData As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents lblCountMe As Telerik.WinControls.UI.RadLabel
End Class


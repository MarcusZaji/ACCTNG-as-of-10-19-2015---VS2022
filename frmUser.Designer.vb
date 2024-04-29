<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.gvList = New Telerik.WinControls.UI.MasterGridViewTemplate()
        Me.btnDel = New Telerik.WinControls.UI.RadButton()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.txtName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddlUserlvl = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtconPW = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPW = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUN = New Telerik.WinControls.UI.RadTextBox()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.ssRmDetails = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leRecordCount = New Telerik.WinControls.UI.RadLabelElement()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.btnChangePW = New Telerik.WinControls.UI.RadButton()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtconPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssRmDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChangePW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwLoadData
        '
        '
        'RadSplitContainer1
        '
        Me.RadSplitContainer1.IsCleanUpTarget = True
        Me.RadSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.RadSplitContainer1.Name = "RadSplitContainer1"
        '
        '
        '
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(263, 68)
        Me.RadSplitContainer1.SplitterWidth = 2
        Me.RadSplitContainer1.TabIndex = 2
        Me.RadSplitContainer1.TabStop = False
        Me.RadSplitContainer1.ThemeName = "Windows8"
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Caption = Nothing
        Me.ToolWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow2.Location = New System.Drawing.Point(4, 27)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow2.Size = New System.Drawing.Size(192, 169)
        Me.ToolWindow2.Text = "ToolWindow2"
        '
        'gvList
        '
        Me.gvList.ViewDefinition = TableViewDefinition1
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(140, 292)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(149, 54)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "&Delete User"
        Me.btnDel.ThemeName = "Windows8"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.Size = New System.Drawing.Size(263, 79)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(130, 124)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-70, -76)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(198, 261)
        Me.ToolWindow1.Text = "ToolWindow1"
        '
        'ToolWindow3
        '
        Me.ToolWindow3.Caption = Nothing
        Me.ToolWindow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow3.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow3.Name = "ToolWindow3"
        Me.ToolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow3.Size = New System.Drawing.Size(198, 261)
        Me.ToolWindow3.Text = "ToolWindow3"
        '
        'ToolTabStrip4
        '
        Me.ToolTabStrip4.CanUpdateChildIndex = True
        Me.ToolTabStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip4.Name = "ToolTabStrip4"
        '
        '
        '
        Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip4.Size = New System.Drawing.Size(292, 270)
        Me.ToolTabStrip4.TabIndex = 0
        Me.ToolTabStrip4.TabStop = False
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(130, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(159, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.ThemeName = "Windows8"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(16, 20)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(40, 21)
        Me.RadLabel6.TabIndex = 82
        Me.RadLabel6.Text = "name"
        Me.RadLabel6.ThemeName = "Windows8"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(16, 146)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(76, 21)
        Me.RadLabel5.TabIndex = 81
        Me.RadLabel5.Text = "department"
        Me.RadLabel5.ThemeName = "Windows8"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(16, 120)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(62, 21)
        Me.RadLabel4.TabIndex = 80
        Me.RadLabel4.Text = "user level"
        Me.RadLabel4.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(16, 96)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(112, 21)
        Me.RadLabel3.TabIndex = 79
        Me.RadLabel3.Text = "confirm password"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(16, 70)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel2.TabIndex = 78
        Me.RadLabel2.Text = "password"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(16, 44)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(65, 21)
        Me.RadLabel1.TabIndex = 77
        Me.RadLabel1.Text = "username"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'ddlDept
        '
        Me.ddlDept.Location = New System.Drawing.Point(130, 146)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(159, 20)
        Me.ddlDept.TabIndex = 6
        Me.ddlDept.ThemeName = "Windows8"
        '
        'ddlUserlvl
        '
        RadListDataItem1.Text = "ADMINISTRATOR"
        RadListDataItem2.Text = "USER"
        RadListDataItem3.Text = "PROFESSIONAL"
        RadListDataItem4.Text = "MANAGER"
        Me.ddlUserlvl.Items.Add(RadListDataItem1)
        Me.ddlUserlvl.Items.Add(RadListDataItem2)
        Me.ddlUserlvl.Items.Add(RadListDataItem3)
        Me.ddlUserlvl.Items.Add(RadListDataItem4)
        Me.ddlUserlvl.Location = New System.Drawing.Point(130, 120)
        Me.ddlUserlvl.Name = "ddlUserlvl"
        Me.ddlUserlvl.Size = New System.Drawing.Size(159, 20)
        Me.ddlUserlvl.TabIndex = 5
        Me.ddlUserlvl.ThemeName = "Windows8"
        '
        'txtconPW
        '
        Me.txtconPW.Location = New System.Drawing.Point(130, 96)
        Me.txtconPW.Name = "txtconPW"
        Me.txtconPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconPW.Size = New System.Drawing.Size(159, 20)
        Me.txtconPW.TabIndex = 4
        Me.txtconPW.ThemeName = "Windows8"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(130, 70)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(159, 20)
        Me.txtPW.TabIndex = 3
        Me.txtPW.ThemeName = "Windows8"
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(130, 44)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(159, 20)
        Me.txtUN.TabIndex = 2
        Me.txtUN.ThemeName = "Windows8"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(140, 172)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 54)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add &New User"
        Me.btnAdd.ThemeName = "Windows8"
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadLabel7.Image = CType(resources.GetObject("RadLabel7.Image"), System.Drawing.Image)
        Me.RadLabel7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel7.Location = New System.Drawing.Point(0, 344)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(61, 57)
        Me.RadLabel7.TabIndex = 85
        '
        'ssRmDetails
        '
        Me.ssRmDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssRmDetails.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leRecordCount})
        Me.ssRmDetails.Location = New System.Drawing.Point(0, 443)
        Me.ssRmDetails.Name = "ssRmDetails"
        Me.ssRmDetails.Size = New System.Drawing.Size(1048, 27)
        Me.ssRmDetails.TabIndex = 90
        Me.ssRmDetails.Text = "RadStatusStrip1"
        Me.ssRmDetails.ThemeName = "Windows8"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Records Found"
        Me.RadLabelElement1.AccessibleName = "Records Found"
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.ssRmDetails.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "User Count"
        Me.RadLabelElement1.TextWrap = True
        '
        'leRecordCount
        '
        Me.leRecordCount.AccessibleDescription = "0"
        Me.leRecordCount.AccessibleName = "0"
        Me.leRecordCount.Name = "leRecordCount"
        Me.ssRmDetails.SetSpring(Me.leRecordCount, False)
        Me.leRecordCount.Text = "0"
        Me.leRecordCount.TextWrap = True
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Right
        Me.rgvList.Location = New System.Drawing.Point(307, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableFiltering = True
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(741, 443)
        Me.rgvList.TabIndex = 91
        Me.rgvList.Text = "s"
        Me.rgvList.ThemeName = "Windows8"
        '
        'btnChangePW
        '
        Me.btnChangePW.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePW.Location = New System.Drawing.Point(140, 232)
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.Size = New System.Drawing.Size(149, 54)
        Me.btnChangePW.TabIndex = 92
        Me.btnChangePW.Text = "Change &Password"
        Me.btnChangePW.ThemeName = "Windows8"
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1048, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnChangePW)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.ssRmDetails)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.ddlUserlvl)
        Me.Controls.Add(Me.txtconPW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUN)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUser"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " User List"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtconPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssRmDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChangePW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents gvList As Telerik.WinControls.UI.MasterGridViewTemplate
    Friend WithEvents btnDel As Telerik.WinControls.UI.RadButton
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents txtName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddlUserlvl As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtconPW As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPW As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtUN As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ssRmDetails As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leRecordCount As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnChangePW As Telerik.WinControls.UI.RadButton
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


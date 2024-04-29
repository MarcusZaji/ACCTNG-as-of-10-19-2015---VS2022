<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHomeNew
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
        Dim ListViewDataItemGroup1 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("BUDGET")
        Dim ListViewDataItemGroup2 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("PURCHASE REQUISITION")
        Dim ListViewDataItemGroup3 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("PURCHASE ORDER")
        Dim ListViewDataItemGroup4 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("ACTUAL ACQUISITION")
        Dim ListViewDataItemGroup5 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("REPORTS")
        Dim ListViewDataItemGroup6 As Telerik.WinControls.UI.ListViewDataItemGroup = New Telerik.WinControls.UI.ListViewDataItemGroup("RFQ")
        Dim ListViewDataItem1 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("View Budget")
        Dim ListViewDataItem2 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Create Budget")
        Dim ListViewDataItem3 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Old Create Budget")
        Dim ListViewDataItem4 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Investment")
        Dim ListViewDataItem5 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Upload Budget")
        Dim ListViewDataItem6 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("View Purchase Requisition")
        Dim ListViewDataItem7 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Create Purchase Requisition")
        Dim ListViewDataItem8 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Budget Summary")
        Dim ListViewDataItem9 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Old Purchase Requisition")
        Dim ListViewDataItem10 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("View Purchase Order")
        Dim ListViewDataItem11 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Create Purchase Requisition")
        Dim ListViewDataItem12 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Purchase Order Change")
        Dim ListViewDataItem13 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Force Purchase Order")
        Dim ListViewDataItem14 As Telerik.WinControls.UI.ListViewDataItem = New Telerik.WinControls.UI.ListViewDataItem("Inactive Supplier")
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.btbSearch = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.btnSearch = New Telerik.WinControls.UI.RadButtonElement()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rlvMenu = New Telerik.WinControls.UI.RadListView()
        Me.MaterialBlueGreyTheme1 = New Telerik.WinControls.Themes.MaterialBlueGreyTheme()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radLabel1.SuspendLayout()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPanel4.SuspendLayout()
        CType(Me.btbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadPanel1.Controls.Add(Me.radLabel1)
        Me.RadPanel1.Controls.Add(Me.PictureBox1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1090, 100)
        Me.RadPanel1.TabIndex = 0
        '
        'radLabel1
        '
        Me.radLabel1.Controls.Add(Me.radLabel2)
        Me.radLabel1.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.radLabel1.Location = New System.Drawing.Point(95, 19)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(549, 74)
        Me.radLabel1.TabIndex = 63
        Me.radLabel1.Text = "Budget Actual Program"
        '
        'radLabel2
        '
        Me.radLabel2.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.radLabel2.Location = New System.Drawing.Point(519, 46)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(36, 29)
        Me.radLabel2.TabIndex = 64
        Me.radLabel2.Text = "3.0"
        '
        'radPanel4
        '
        Me.radPanel4.Controls.Add(Me.btbSearch)
        Me.radPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.radPanel4.Location = New System.Drawing.Point(0, 100)
        Me.radPanel4.Name = "radPanel4"
        Me.radPanel4.Size = New System.Drawing.Size(1090, 44)
        Me.radPanel4.TabIndex = 4
        '
        'btbSearch
        '
        Me.btbSearch.Location = New System.Drawing.Point(5, 6)
        Me.btbSearch.Name = "btbSearch"
        Me.btbSearch.NullText = "SEARCH"
        Me.btbSearch.RightButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.btnSearch})
        Me.btbSearch.Size = New System.Drawing.Size(509, 30)
        Me.btbSearch.TabIndex = 1
        Me.btbSearch.ThemeName = "Fluent"
        '
        'btnSearch
        '
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShowBorder = False
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseCompatibleTextRendering = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ACCTNG.My.Resources.Resources.BAP_logo_2_0
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 85)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'rlvMenu
        '
        Me.rlvMenu.AllowEdit = False
        Me.rlvMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rlvMenu.GroupItemSize = New System.Drawing.Size(200, 36)
        ListViewDataItemGroup1.Text = "BUDGET"
        ListViewDataItemGroup2.Text = "PURCHASE REQUISITION"
        ListViewDataItemGroup3.Text = "PURCHASE ORDER"
        ListViewDataItemGroup4.Text = "ACTUAL ACQUISITION"
        ListViewDataItemGroup5.Text = "REPORTS"
        ListViewDataItemGroup6.Text = "RFQ"
        Me.rlvMenu.Groups.AddRange(New Telerik.WinControls.UI.ListViewDataItemGroup() {ListViewDataItemGroup1, ListViewDataItemGroup2, ListViewDataItemGroup3, ListViewDataItemGroup4, ListViewDataItemGroup5, ListViewDataItemGroup6})
        ListViewDataItem1.Group = ListViewDataItemGroup1
        ListViewDataItem1.Text = "View Budget"
        ListViewDataItem2.Group = ListViewDataItemGroup1
        ListViewDataItem2.Text = "Create Budget"
        ListViewDataItem3.Group = ListViewDataItemGroup2
        ListViewDataItem3.Text = "Old Create Budget"
        ListViewDataItem4.Group = ListViewDataItemGroup1
        ListViewDataItem4.Text = "Investment"
        ListViewDataItem5.Group = ListViewDataItemGroup1
        ListViewDataItem5.Text = "Upload Budget"
        ListViewDataItem6.Group = ListViewDataItemGroup2
        ListViewDataItem6.Text = "View Purchase Requisition"
        ListViewDataItem7.Group = ListViewDataItemGroup2
        ListViewDataItem7.Text = "Create Purchase Requisition"
        ListViewDataItem8.Group = ListViewDataItemGroup1
        ListViewDataItem8.Text = "Budget Summary"
        ListViewDataItem9.Group = ListViewDataItemGroup2
        ListViewDataItem9.Text = "Old Purchase Requisition"
        ListViewDataItem10.Group = ListViewDataItemGroup3
        ListViewDataItem10.Text = "View Purchase Order"
        ListViewDataItem11.Group = ListViewDataItemGroup2
        ListViewDataItem11.Text = "Create Purchase Requisition"
        ListViewDataItem12.Group = ListViewDataItemGroup3
        ListViewDataItem12.Text = "Purchase Order Change"
        ListViewDataItem13.Group = ListViewDataItemGroup3
        ListViewDataItem13.Text = "Force Purchase Order"
        ListViewDataItem14.Group = ListViewDataItemGroup3
        ListViewDataItem14.Text = "Inactive Supplier"
        Me.rlvMenu.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {ListViewDataItem1, ListViewDataItem2, ListViewDataItem3, ListViewDataItem4, ListViewDataItem5, ListViewDataItem6, ListViewDataItem7, ListViewDataItem8, ListViewDataItem9, ListViewDataItem10, ListViewDataItem11, ListViewDataItem12, ListViewDataItem13, ListViewDataItem14})
        Me.rlvMenu.ItemSize = New System.Drawing.Size(200, 36)
        Me.rlvMenu.Location = New System.Drawing.Point(0, 144)
        Me.rlvMenu.Name = "rlvMenu"
        Me.rlvMenu.ShowGroups = True
        Me.rlvMenu.Size = New System.Drawing.Size(1090, 471)
        Me.rlvMenu.TabIndex = 5
        Me.rlvMenu.ThemeName = "MaterialBlueGrey"
        '
        'FrmHomeNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 615)
        Me.Controls.Add(Me.rlvMenu)
        Me.Controls.Add(Me.radPanel4)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmHomeNew"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BAP"
        Me.ThemeName = "Material"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radLabel1.ResumeLayout(False)
        Me.radLabel1.PerformLayout()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPanel4.ResumeLayout(False)
        Me.radPanel4.PerformLayout()
        CType(Me.btbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Private WithEvents radLabel2 As Telerik.WinControls.UI.RadLabel
    Private WithEvents radPanel4 As Telerik.WinControls.UI.RadPanel
    Private WithEvents btbSearch As Telerik.WinControls.UI.RadButtonTextBox
    Private WithEvents btnSearch As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Private WithEvents rlvMenu As Telerik.WinControls.UI.RadListView
    Friend WithEvents MaterialBlueGreyTheme1 As Telerik.WinControls.Themes.MaterialBlueGreyTheme
End Class


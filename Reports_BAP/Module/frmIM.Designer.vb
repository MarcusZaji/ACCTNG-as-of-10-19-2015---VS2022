<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIM))
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txtIC = New Telerik.WinControls.UI.RadTextBox()
        Me.txtItemDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.btnAddItem = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteItem = New Telerik.WinControls.UI.RadButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.txtSignature = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlCat = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlItemUOM = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlItemUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel24
        '
        Me.RadLabel24.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(325, 56)
        Me.RadLabel24.TabIndex = 241
        Me.RadLabel24.Text = "Item Management"
        Me.RadLabel24.ThemeName = "Windows8"
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Right
        Me.rgvList.Location = New System.Drawing.Point(368, 0)
        '
        'rgvList
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(628, 489)
        Me.rgvList.TabIndex = 242
        Me.rgvList.Text = "8"
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(34, 121)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(68, 21)
        Me.RadLabel13.TabIndex = 244
        Me.RadLabel13.Text = "Item Code"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'txtIC
        '
        Me.txtIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIC.Location = New System.Drawing.Point(173, 121)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(189, 20)
        Me.txtIC.TabIndex = 2
        Me.txtIC.ThemeName = "Windows8"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.AutoScroll = True
        Me.txtItemDesc.Location = New System.Drawing.Point(173, 147)
        Me.txtItemDesc.MaxLength = 100000
        Me.txtItemDesc.Multiline = True
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(189, 43)
        Me.txtItemDesc.TabIndex = 3
        Me.txtItemDesc.ThemeName = "Windows8"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(34, 147)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel11.TabIndex = 247
        Me.RadLabel11.Text = "Description"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(242, 248)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(120, 40)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "&Add"
        Me.btnAddItem.ThemeName = "Windows8"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(242, 294)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteItem.TabIndex = 7
        Me.btnDeleteItem.Text = "&Delete"
        Me.btnDeleteItem.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(3, 429)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 251
        '
        'bwLoadData
        '
        '
        'txtSignature
        '
        Me.txtSignature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSignature.Location = New System.Drawing.Point(173, 222)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(189, 20)
        Me.txtSignature.TabIndex = 5
        Me.txtSignature.ThemeName = "Windows8"
        '
        'RadLabel12
        '
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel12.Location = New System.Drawing.Point(34, 222)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(63, 21)
        Me.RadLabel12.TabIndex = 253
        Me.RadLabel12.Text = "Signature"
        Me.RadLabel12.ThemeName = "Windows8"
        '
        'ddlCat
        '
        Me.ddlCat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PCS"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "LOT"
        RadListDataItem2.TextWrap = True
        Me.ddlCat.Items.Add(RadListDataItem1)
        Me.ddlCat.Items.Add(RadListDataItem2)
        Me.ddlCat.Location = New System.Drawing.Point(173, 95)
        Me.ddlCat.Name = "ddlCat"
        Me.ddlCat.Size = New System.Drawing.Size(189, 20)
        Me.ddlCat.TabIndex = 1
        Me.ddlCat.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(34, 95)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(60, 21)
        Me.RadLabel1.TabIndex = 255
        Me.RadLabel1.Text = "Category"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(34, 196)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel19.TabIndex = 248
        Me.RadLabel19.Text = "Unit of Measurement"
        Me.RadLabel19.ThemeName = "Windows8"
        '
        'ddlItemUOM
        '
        Me.ddlItemUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "PCS"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "LOT"
        RadListDataItem4.TextWrap = True
        Me.ddlItemUOM.Items.Add(RadListDataItem3)
        Me.ddlItemUOM.Items.Add(RadListDataItem4)
        Me.ddlItemUOM.Location = New System.Drawing.Point(173, 196)
        Me.ddlItemUOM.Name = "ddlItemUOM"
        Me.ddlItemUOM.Size = New System.Drawing.Size(189, 20)
        Me.ddlItemUOM.TabIndex = 4
        Me.ddlItemUOM.ThemeName = "Windows8"
        '
        'frmIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 489)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ddlCat)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.RadLabel12)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.ddlItemUOM)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.RadLabel11)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.RadLabel24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIM"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Management"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlItemUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtIC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtItemDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnAddItem As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteItem As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtSignature As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCat As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlItemUOM As Telerik.WinControls.UI.RadDropDownList
End Class


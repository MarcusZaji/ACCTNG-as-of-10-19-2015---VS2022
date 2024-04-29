<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewPR
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
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.txtExistingPR = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSearch = New Telerik.WinControls.UI.RadButton()
        Me.txtSearchPR = New Telerik.WinControls.UI.RadTextBox()
        Me.rgvListItem = New Telerik.WinControls.UI.RadGridView()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistingPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvListItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvListItem.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Location = New System.Drawing.Point(12, 38)
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
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(819, 271)
        Me.rgvList.TabIndex = 158
        Me.rgvList.ThemeName = "Fluent"
        '
        'txtExistingPR
        '
        Me.txtExistingPR.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtExistingPR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtExistingPR.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistingPR.Location = New System.Drawing.Point(269, 9)
        Me.txtExistingPR.Name = "txtExistingPR"
        Me.txtExistingPR.Size = New System.Drawing.Size(96, 23)
        Me.txtExistingPR.TabIndex = 410
        Me.txtExistingPR.Text = "View Existing PR"
        Me.txtExistingPR.ThemeName = "Fluent"
        '
        'RadLabel25
        '
        Me.RadLabel25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel25.Location = New System.Drawing.Point(12, 8)
        Me.RadLabel25.Name = "RadLabel25"
        Me.RadLabel25.Size = New System.Drawing.Size(34, 21)
        Me.RadLabel25.TabIndex = 408
        Me.RadLabel25.Text = "PR #"
        Me.RadLabel25.ThemeName = "Fluent"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(183, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 23)
        Me.btnSearch.TabIndex = 409
        Me.btnSearch.Text = "Search PR #"
        Me.btnSearch.ThemeName = "Fluent"
        '
        'txtSearchPR
        '
        Me.txtSearchPR.BackColor = System.Drawing.Color.Transparent
        Me.txtSearchPR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchPR.Location = New System.Drawing.Point(52, 8)
        Me.txtSearchPR.Name = "txtSearchPR"
        Me.txtSearchPR.Size = New System.Drawing.Size(128, 24)
        Me.txtSearchPR.TabIndex = 407
        Me.txtSearchPR.ThemeName = "Fluent"
        '
        'rgvListItem
        '
        Me.rgvListItem.Location = New System.Drawing.Point(12, 315)
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
        Me.rgvListItem.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.rgvListItem.Name = "rgvListItem"
        Me.rgvListItem.Size = New System.Drawing.Size(819, 302)
        Me.rgvListItem.TabIndex = 411
        Me.rgvListItem.ThemeName = "Fluent"
        '
        'FrmViewPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 625)
        Me.Controls.Add(Me.rgvListItem)
        Me.Controls.Add(Me.txtExistingPR)
        Me.Controls.Add(Me.RadLabel25)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchPR)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "FrmViewPR"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "VIEW PURCHASE REQUISITION"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistingPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvListItem.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvListItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtExistingPR As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel25 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtSearchPR As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rgvListItem As Telerik.WinControls.UI.RadGridView
End Class


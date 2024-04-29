<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportSubBud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportSubBud))
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialTealTheme1 = New Telerik.WinControls.Themes.MaterialTealTheme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CBYear = New Telerik.WinControls.UI.CommandBarDropDownList()
        Me.cbSubmit = New Telerik.WinControls.UI.CommandBarButton()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCommandBar1.SuspendLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvList.Location = New System.Drawing.Point(0, 54)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.MultiSelect = True
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(1148, 478)
        Me.rgvList.TabIndex = 10
        Me.rgvList.ThemeName = "Fluent"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Controls.Add(Me.RadProgressBar1)
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1148, 54)
        Me.RadCommandBar1.TabIndex = 11
        Me.RadCommandBar1.ThemeName = "Fluent"
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Location = New System.Drawing.Point(997, 24)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(139, 24)
        Me.RadProgressBar1.TabIndex = 137
        Me.RadProgressBar1.ThemeName = "Fluent"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbExport, Me.CBYear, Me.cbSubmit})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cbExport
        '
        Me.cbExport.DisplayName = "EXPORT"
        Me.cbExport.DrawText = True
        Me.cbExport.Image = CType(resources.GetObject("cbExport.Image"), System.Drawing.Image)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Text = "EXPORT"
        Me.cbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CBYear
        '
        Me.CBYear.AutoCompleteDisplayMember = "2020"
        Me.CBYear.DisplayMember = "2020"
        Me.CBYear.DisplayName = "CommandBarDropDownList1"
        Me.CBYear.DrawText = False
        Me.CBYear.DropDownAnimationEnabled = True
        RadListDataItem1.Text = "2024"
        RadListDataItem2.Text = "2023"
        RadListDataItem3.Text = "2022"
        RadListDataItem4.Text = "2021"
        RadListDataItem5.Text = "2020"
        RadListDataItem6.Text = "2019"
        RadListDataItem7.Text = "2018"
        Me.CBYear.Items.Add(RadListDataItem1)
        Me.CBYear.Items.Add(RadListDataItem2)
        Me.CBYear.Items.Add(RadListDataItem3)
        Me.CBYear.Items.Add(RadListDataItem4)
        Me.CBYear.Items.Add(RadListDataItem5)
        Me.CBYear.Items.Add(RadListDataItem6)
        Me.CBYear.Items.Add(RadListDataItem7)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Text = "2020"
        '
        'cbSubmit
        '
        Me.cbSubmit.DisplayName = "CommandBarButton1"
        Me.cbSubmit.Image = CType(resources.GetObject("cbSubmit.Image"), System.Drawing.Image)
        Me.cbSubmit.Name = "cbSubmit"
        Me.cbSubmit.Text = "GO"
        '
        'FrmExportSubBud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 532)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "FrmExportSubBud"
        Me.Text = "Export Grid"
        Me.ThemeName = "MaterialTeal"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCommandBar1.ResumeLayout(False)
        Me.RadCommandBar1.PerformLayout()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTealTheme1 As Telerik.WinControls.Themes.MaterialTealTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents CBYear As Telerik.WinControls.UI.CommandBarDropDownList
    Friend WithEvents cbSubmit As Telerik.WinControls.UI.CommandBarButton
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRFQItems
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
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.rgvlIST = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        CType(Me.rgvlIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvlIST.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvlIST
        '
        Me.rgvlIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvlIST.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvlIST.MasterTemplate.AllowAddNewRow = False
        Me.rgvlIST.MasterTemplate.AllowCellContextMenu = False
        Me.rgvlIST.MasterTemplate.AllowColumnReorder = False
        Me.rgvlIST.MasterTemplate.AllowDeleteRow = False
        Me.rgvlIST.MasterTemplate.AllowSearchRow = True
        Me.rgvlIST.MasterTemplate.EnableFiltering = True
        Me.rgvlIST.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvlIST.Name = "rgvlIST"
        Me.rgvlIST.Size = New System.Drawing.Size(901, 509)
        Me.rgvlIST.TabIndex = 24
        Me.rgvlIST.ThemeName = "Windows8"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.RadPanel1.Controls.Add(Me.RadPanel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel1.Location = New System.Drawing.Point(0, 509)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(901, 56)
        Me.RadPanel1.TabIndex = 211
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btnAdd)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(182, 56)
        Me.RadPanel2.TabIndex = 211
        CType(Me.RadPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Teal
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(12, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(152, 36)
        Me.btnAdd.TabIndex = 209
        Me.btnAdd.Text = "Add Items"
        Me.btnAdd.ThemeName = "MaterialPink"
        '
        'FrmRFQItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 565)
        Me.Controls.Add(Me.rgvlIST)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmRFQItems"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RFQ ITEMS"
        Me.ThemeName = "MaterialPink"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rgvlIST.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvlIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvlIST As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
End Class


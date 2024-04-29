<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRFQList
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
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.btnAddRFQ = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btnViewRFQ = New Telerik.WinControls.UI.RadButton()
        Me.btnRFQPur = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddRFQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.btnViewRFQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRFQPur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvList.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowAddNewRow = False
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(803, 441)
        Me.rgvList.TabIndex = 23
        Me.rgvList.ThemeName = "Windows8"
        '
        'btnAddRFQ
        '
        Me.btnAddRFQ.BackColor = System.Drawing.Color.Teal
        Me.btnAddRFQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRFQ.ForeColor = System.Drawing.Color.White
        Me.btnAddRFQ.Location = New System.Drawing.Point(12, 9)
        Me.btnAddRFQ.Name = "btnAddRFQ"
        Me.btnAddRFQ.Size = New System.Drawing.Size(152, 36)
        Me.btnAddRFQ.TabIndex = 209
        Me.btnAddRFQ.Text = "Create New RFQ"
        Me.btnAddRFQ.ThemeName = "MaterialPink"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.RadPanel1.Controls.Add(Me.RadPanel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel1.Location = New System.Drawing.Point(0, 441)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(803, 56)
        Me.RadPanel1.TabIndex = 210
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btnViewRFQ)
        Me.RadPanel2.Controls.Add(Me.btnRFQPur)
        Me.RadPanel2.Controls.Add(Me.btnAddRFQ)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(538, 56)
        Me.RadPanel2.TabIndex = 211
        CType(Me.RadPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnViewRFQ
        '
        Me.btnViewRFQ.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnViewRFQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRFQ.ForeColor = System.Drawing.Color.White
        Me.btnViewRFQ.Location = New System.Drawing.Point(404, 9)
        Me.btnViewRFQ.Name = "btnViewRFQ"
        Me.btnViewRFQ.Size = New System.Drawing.Size(120, 36)
        Me.btnViewRFQ.TabIndex = 211
        Me.btnViewRFQ.Text = "View RFQ"
        Me.btnViewRFQ.ThemeName = "MaterialPink"
        Me.btnViewRFQ.Visible = False
        '
        'btnRFQPur
        '
        Me.btnRFQPur.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRFQPur.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFQPur.ForeColor = System.Drawing.Color.White
        Me.btnRFQPur.Location = New System.Drawing.Point(179, 9)
        Me.btnRFQPur.Name = "btnRFQPur"
        Me.btnRFQPur.Size = New System.Drawing.Size(219, 36)
        Me.btnRFQPur.TabIndex = 210
        Me.btnRFQPur.Text = "Create New RFQ Purchasing"
        Me.btnRFQPur.ThemeName = "MaterialPink"
        '
        'FrmRFQList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 497)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmRFQList"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RFQ LIST"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddRFQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.btnViewRFQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRFQPur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnAddRFQ As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnRFQPur As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents btnViewRFQ As Telerik.WinControls.UI.RadButton
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBudgetHistory
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
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.rgvSBudget = New Telerik.WinControls.UI.RadGridView()
        CType(Me.rgvSBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvSBudget
        '
        Me.rgvSBudget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvSBudget.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvSBudget.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSBudget.MasterTemplate.AllowColumnReorder = False
        Me.rgvSBudget.MasterTemplate.AllowDeleteRow = False
        Me.rgvSBudget.MasterTemplate.AllowEditRow = False
        Me.rgvSBudget.MasterTemplate.EnableGrouping = False
        Me.rgvSBudget.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvSBudget.Name = "rgvSBudget"
        Me.rgvSBudget.Size = New System.Drawing.Size(1200, 536)
        Me.rgvSBudget.TabIndex = 24
        Me.rgvSBudget.ThemeName = "Fluent"
        '
        'FrmBudgetHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 536)
        Me.Controls.Add(Me.rgvSBudget)
        Me.Name = "FrmBudgetHistory"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget History"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvSBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents rgvSBudget As Telerik.WinControls.UI.RadGridView
End Class


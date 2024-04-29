<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMajorBudHistory
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
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.rgvMBudget = New Telerik.WinControls.UI.RadGridView()
        CType(Me.rgvMBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvMBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvMBudget
        '
        Me.rgvMBudget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvMBudget.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvMBudget.MasterTemplate.AllowCellContextMenu = False
        Me.rgvMBudget.MasterTemplate.AllowColumnReorder = False
        Me.rgvMBudget.MasterTemplate.AllowDeleteRow = False
        Me.rgvMBudget.MasterTemplate.AllowEditRow = False
        Me.rgvMBudget.MasterTemplate.EnableGrouping = False
        Me.rgvMBudget.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvMBudget.Name = "rgvMBudget"
        Me.rgvMBudget.Size = New System.Drawing.Size(1071, 562)
        Me.rgvMBudget.TabIndex = 25
        Me.rgvMBudget.ThemeName = "Fluent"
        '
        'FrmMajorBudHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 562)
        Me.Controls.Add(Me.rgvMBudget)
        Me.Name = "FrmMajorBudHistory"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAJOR BUDGET HISTORY"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvMBudget.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvMBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvMBudget As Telerik.WinControls.UI.RadGridView
End Class


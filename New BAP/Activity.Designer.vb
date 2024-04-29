<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.txtActivity = New Telerik.WinControls.UI.RadTextBox()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgvList
        '
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Left
        Me.rgvList.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.AllowEditRow = False
        Me.rgvList.MasterTemplate.AllowRowResize = False
        Me.rgvList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(372, 508)
        Me.rgvList.TabIndex = 159
        Me.rgvList.ThemeName = "Fluent"
        '
        'txtActivity
        '
        Me.txtActivity.Location = New System.Drawing.Point(398, 48)
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.Size = New System.Drawing.Size(346, 36)
        Me.txtActivity.TabIndex = 160
        Me.txtActivity.ThemeName = "MaterialPink"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(401, 21)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(50, 21)
        Me.RadLabel4.TabIndex = 409
        Me.RadLabel4.Text = "Activity"
        Me.RadLabel4.ThemeName = "Fluent"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(401, 109)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 36)
        Me.btnSave.TabIndex = 410
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "MaterialPink"
        '
        'Activity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 508)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtActivity)
        Me.Controls.Add(Me.rgvList)
        Me.Name = "Activity"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTIVITY"
        Me.ThemeName = "MaterialPink"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtActivity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
End Class


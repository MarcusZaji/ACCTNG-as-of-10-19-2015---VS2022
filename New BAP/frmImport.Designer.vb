<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImport
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
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.rbeGetData = New Telerik.WinControls.UI.RadBrowseEditor()
        Me.FluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.MaterialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel24
        '
        Me.RadLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel24.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(66, 21)
        Me.RadLabel24.TabIndex = 405
        Me.RadLabel24.Text = "Select File"
        Me.RadLabel24.ThemeName = "Fluent"
        '
        'rbeGetData
        '
        Me.rbeGetData.Location = New System.Drawing.Point(12, 39)
        Me.rbeGetData.Name = "rbeGetData"
        '
        '
        '
        Me.rbeGetData.RootElement.StretchVertically = True
        Me.rbeGetData.Size = New System.Drawing.Size(264, 26)
        Me.rbeGetData.TabIndex = 404
        Me.rbeGetData.ThemeName = "Fluent"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(189, 71)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 29)
        Me.btnAdd.TabIndex = 406
        Me.btnAdd.Text = "Import"
        Me.btnAdd.ThemeName = "Fluent"
        '
        'FrmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 108)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.RadLabel24)
        Me.Controls.Add(Me.rbeGetData)
        Me.Name = "FrmImport"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPORT"
        Me.ThemeName = "MaterialPink"
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeGetData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbeGetData As Telerik.WinControls.UI.RadBrowseEditor
    Friend WithEvents FluentTheme1 As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents MaterialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
End Class


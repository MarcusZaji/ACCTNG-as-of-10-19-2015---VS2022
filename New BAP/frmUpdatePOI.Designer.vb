<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdatePOI
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
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.txtIMDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlItemUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.txtIMDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlItemUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIMDesc
        '
        Me.txtIMDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIMDesc.Location = New System.Drawing.Point(118, 51)
        Me.txtIMDesc.Name = "txtIMDesc"
        Me.txtIMDesc.Size = New System.Drawing.Size(211, 24)
        Me.txtIMDesc.TabIndex = 297
        Me.txtIMDesc.ThemeName = "Fluent"
        '
        'RadLabel11
        '
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel11.Location = New System.Drawing.Point(21, 53)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel11.TabIndex = 294
        Me.RadLabel11.Text = "Description"
        Me.RadLabel11.ThemeName = "Windows8"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(21, 99)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 40)
        Me.btnUpdate.TabIndex = 384
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.ThemeName = "Fluent"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Location = New System.Drawing.Point(284, 99)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(45, 24)
        Me.txtID.TabIndex = 385
        Me.txtID.ThemeName = "Fluent"
        Me.txtID.Visible = False
        '
        'ddlItemUOM
        '
        Me.ddlItemUOM.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.ddlItemUOM.Location = New System.Drawing.Point(118, 21)
        Me.ddlItemUOM.Name = "ddlItemUOM"
        Me.ddlItemUOM.Size = New System.Drawing.Size(211, 24)
        Me.ddlItemUOM.TabIndex = 386
        Me.ddlItemUOM.ThemeName = "Fluent"
        '
        'RadLabel19
        '
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(21, 24)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(38, 21)
        Me.RadLabel19.TabIndex = 387
        Me.RadLabel19.Text = "UOM"
        Me.RadLabel19.ThemeName = "Fluent"
        '
        'FrmUpdatePOI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 163)
        Me.Controls.Add(Me.ddlItemUOM)
        Me.Controls.Add(Me.RadLabel19)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtIMDesc)
        Me.Controls.Add(Me.RadLabel11)
        Me.Name = "FrmUpdatePOI"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update PO"
        Me.ThemeName = "MaterialPink"
        CType(Me.txtIMDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlItemUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents txtIMDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlItemUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
End Class


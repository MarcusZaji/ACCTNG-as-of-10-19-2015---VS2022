<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateRFQChild
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
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.mebQTY = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtDesc = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mebQTY
        '
        Me.mebQTY.DecimalPlaces = 2
        Me.mebQTY.Location = New System.Drawing.Point(482, 25)
        Me.mebQTY.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mebQTY.Name = "mebQTY"
        Me.mebQTY.Size = New System.Drawing.Size(189, 20)
        Me.mebQTY.TabIndex = 402
        Me.mebQTY.ThemeName = "Windows8"
        Me.mebQTY.ThousandsSeparator = True
        '
        'RadLabel10
        '
        Me.RadLabel10.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(325, 81)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(57, 21)
        Me.RadLabel10.TabIndex = 400
        Me.RadLabel10.Text = "Remarks"
        Me.RadLabel10.ThemeName = "Windows8"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Teal
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(573, 168)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 36)
        Me.btnUpdate.TabIndex = 389
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "MaterialPink"
        '
        'txtRemarks
        '
        Me.txtRemarks.AutoScroll = True
        Me.txtRemarks.BackColor = System.Drawing.Color.Transparent
        Me.txtRemarks.Location = New System.Drawing.Point(482, 77)
        Me.txtRemarks.MaxLength = 100000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(189, 71)
        Me.txtRemarks.TabIndex = 399
        Me.txtRemarks.ThemeName = "Windows8"
        '
        'txtDesc
        '
        Me.txtDesc.AutoScroll = True
        Me.txtDesc.BackColor = System.Drawing.Color.Transparent
        Me.txtDesc.Location = New System.Drawing.Point(112, 26)
        Me.txtDesc.MaxLength = 100000
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(189, 67)
        Me.txtDesc.TabIndex = 392
        Me.txtDesc.ThemeName = "Windows8"
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(3, 26)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(104, 21)
        Me.RadLabel8.TabIndex = 393
        Me.RadLabel8.Text = "Item Description"
        Me.RadLabel8.ThemeName = "Windows8"
        '
        'RadLabel16
        '
        Me.RadLabel16.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel16.Location = New System.Drawing.Point(324, 54)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(132, 21)
        Me.RadLabel16.TabIndex = 396
        Me.RadLabel16.Text = "Unit of Measurement"
        Me.RadLabel16.ThemeName = "Windows8"
        '
        'RadLabel15
        '
        Me.RadLabel15.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel15.Location = New System.Drawing.Point(324, 26)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(58, 21)
        Me.RadLabel15.TabIndex = 394
        Me.RadLabel15.Text = "Quantity"
        Me.RadLabel15.ThemeName = "Windows8"
        '
        'ddlUOM
        '
        Me.ddlUOM.BackColor = System.Drawing.Color.Transparent
        Me.ddlUOM.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        RadListDataItem5.Text = "PCS"
        RadListDataItem6.Text = "LOT"
        RadListDataItem7.Text = "PC"
        RadListDataItem8.Text = "PCS"
        Me.ddlUOM.Items.Add(RadListDataItem5)
        Me.ddlUOM.Items.Add(RadListDataItem6)
        Me.ddlUOM.Items.Add(RadListDataItem7)
        Me.ddlUOM.Items.Add(RadListDataItem8)
        Me.ddlUOM.Location = New System.Drawing.Point(482, 51)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(189, 20)
        Me.ddlUOM.TabIndex = 395
        Me.ddlUOM.ThemeName = "Windows8"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(3, 195)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(54, 20)
        Me.txtID.TabIndex = 403
        Me.txtID.ThemeName = "Windows8"
        '
        'FrmUpdateRFQChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 216)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.mebQTY)
        Me.Controls.Add(Me.RadLabel10)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.RadLabel16)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.ddlUOM)
        Me.Name = "FrmUpdateRFQChild"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update RFQ Items"
        Me.ThemeName = "Material"
        CType(Me.mebQTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents mebQTY As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtDesc As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
End Class


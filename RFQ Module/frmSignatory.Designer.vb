<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignatory
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPreparedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPDesignation = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCDesignation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCheckBy = New Telerik.WinControls.UI.RadTextBox()
        Me.txtADesignation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtApprovedby = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.ddlCategory = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreparedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPDesignation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCDesignation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtADesignation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApprovedby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(12, 59)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(81, 21)
        Me.RadLabel1.TabIndex = 132
        Me.RadLabel1.Text = "Prepared by:"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreparedBy.Location = New System.Drawing.Point(12, 86)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.NullText = "Name"
        Me.txtPreparedBy.Size = New System.Drawing.Size(254, 24)
        Me.txtPreparedBy.TabIndex = 131
        Me.txtPreparedBy.ThemeName = "Fluent"
        '
        'txtPDesignation
        '
        Me.txtPDesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPDesignation.Location = New System.Drawing.Point(12, 112)
        Me.txtPDesignation.Name = "txtPDesignation"
        Me.txtPDesignation.NullText = "Designation"
        Me.txtPDesignation.Size = New System.Drawing.Size(254, 24)
        Me.txtPDesignation.TabIndex = 132
        Me.txtPDesignation.ThemeName = "Fluent"
        '
        'txtCDesignation
        '
        Me.txtCDesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCDesignation.Location = New System.Drawing.Point(273, 112)
        Me.txtCDesignation.Name = "txtCDesignation"
        Me.txtCDesignation.NullText = "Designation"
        Me.txtCDesignation.Size = New System.Drawing.Size(254, 24)
        Me.txtCDesignation.TabIndex = 135
        Me.txtCDesignation.ThemeName = "Fluent"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(273, 59)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel2.TabIndex = 134
        Me.RadLabel2.Text = "Checked by:"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtCheckBy
        '
        Me.txtCheckBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckBy.Location = New System.Drawing.Point(273, 86)
        Me.txtCheckBy.Name = "txtCheckBy"
        Me.txtCheckBy.NullText = "Name"
        Me.txtCheckBy.Size = New System.Drawing.Size(254, 24)
        Me.txtCheckBy.TabIndex = 133
        Me.txtCheckBy.ThemeName = "Fluent"
        '
        'txtADesignation
        '
        Me.txtADesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtADesignation.Location = New System.Drawing.Point(533, 112)
        Me.txtADesignation.Name = "txtADesignation"
        Me.txtADesignation.NullText = "Designation"
        Me.txtADesignation.Size = New System.Drawing.Size(254, 24)
        Me.txtADesignation.TabIndex = 138
        Me.txtADesignation.ThemeName = "Fluent"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(533, 59)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(86, 21)
        Me.RadLabel3.TabIndex = 137
        Me.RadLabel3.Text = "Approved by:"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'txtApprovedby
        '
        Me.txtApprovedby.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApprovedby.Location = New System.Drawing.Point(533, 86)
        Me.txtApprovedby.Name = "txtApprovedby"
        Me.txtApprovedby.NullText = "Name"
        Me.txtApprovedby.Size = New System.Drawing.Size(254, 24)
        Me.txtApprovedby.TabIndex = 136
        Me.txtApprovedby.ThemeName = "Fluent"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Teal
        Me.btnUpdate.Location = New System.Drawing.Point(668, 149)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 36)
        Me.btnUpdate.TabIndex = 139
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "Material"
        '
        'ddlCategory
        '
        Me.ddlCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlCategory.Enabled = False
        RadListDataItem1.Text = "Purchasing"
        RadListDataItem2.Text = "PC"
        Me.ddlCategory.Items.Add(RadListDataItem1)
        Me.ddlCategory.Items.Add(RadListDataItem2)
        Me.ddlCategory.Location = New System.Drawing.Point(12, 12)
        Me.ddlCategory.Name = "ddlCategory"
        Me.ddlCategory.Size = New System.Drawing.Size(189, 24)
        Me.ddlCategory.TabIndex = 140
        Me.ddlCategory.Text = "Purchasing"
        Me.ddlCategory.ThemeName = "Fluent"
        '
        'FrmSignatory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 197)
        Me.Controls.Add(Me.ddlCategory)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtADesignation)
        Me.Controls.Add(Me.txtCDesignation)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.txtApprovedby)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtCheckBy)
        Me.Controls.Add(Me.txtPDesignation)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtPreparedBy)
        Me.Name = "FrmSignatory"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Signatory"
        Me.ThemeName = "Material"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreparedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPDesignation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCDesignation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtADesignation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApprovedby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPreparedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPDesignation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCDesignation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCheckBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtADesignation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtApprovedby As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddlCategory As Telerik.WinControls.UI.RadDropDownList
End Class


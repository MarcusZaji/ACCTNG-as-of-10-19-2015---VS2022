<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenUpd8dBud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenUpd8dBud))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.ddlDept = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.rbRepAA = New Telerik.WinControls.UI.RadLabel()
        Me.dtpFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.btnGenRep = New Telerik.WinControls.UI.RadButton()
        Me.ddlClass = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbRepAA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddlDept
        '
        Me.ddlDept.AutoCompleteDisplayMember = "none"
        Me.ddlDept.DisplayMember = "none"
        Me.ddlDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "ALL"
        Me.ddlDept.Items.Add(RadListDataItem1)
        Me.ddlDept.Location = New System.Drawing.Point(145, 18)
        Me.ddlDept.Name = "ddlDept"
        Me.ddlDept.Size = New System.Drawing.Size(189, 20)
        Me.ddlDept.TabIndex = 96
        Me.ddlDept.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(61, 17)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 21)
        Me.RadLabel1.TabIndex = 97
        Me.RadLabel1.Text = "Department"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(61, 96)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(22, 21)
        Me.RadLabel2.TabIndex = 233
        Me.RadLabel2.Text = "To"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'rbRepAA
        '
        Me.rbRepAA.BackColor = System.Drawing.Color.Transparent
        Me.rbRepAA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRepAA.Location = New System.Drawing.Point(61, 70)
        Me.rbRepAA.Name = "rbRepAA"
        Me.rbRepAA.Size = New System.Drawing.Size(37, 21)
        Me.rbRepAA.TabIndex = 232
        Me.rbRepAA.Text = "From"
        Me.rbRepAA.ThemeName = "Windows8"
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(145, 70)
        Me.dtpFrom.Name = "dtpFrom"
        '
        '
        '
        Me.dtpFrom.RootElement.StretchVertically = True
        Me.dtpFrom.Size = New System.Drawing.Size(190, 20)
        Me.dtpFrom.TabIndex = 231
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Text = "10/13/2014"
        Me.dtpFrom.ThemeName = "Windows8"
        Me.dtpFrom.Value = New Date(2014, 10, 13, 8, 33, 35, 403)
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(145, 96)
        Me.dtpTo.Name = "dtpTo"
        '
        '
        '
        Me.dtpTo.RootElement.StretchVertically = True
        Me.dtpTo.Size = New System.Drawing.Size(190, 20)
        Me.dtpTo.TabIndex = 230
        Me.dtpTo.TabStop = False
        Me.dtpTo.Text = "10/13/2014"
        Me.dtpTo.ThemeName = "Windows8"
        Me.dtpTo.Value = New Date(2014, 10, 13, 8, 33, 35, 403)
        '
        'btnGenRep
        '
        Me.btnGenRep.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGenRep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenRep.Location = New System.Drawing.Point(263, 122)
        Me.btnGenRep.Name = "btnGenRep"
        Me.btnGenRep.Size = New System.Drawing.Size(120, 40)
        Me.btnGenRep.TabIndex = 262
        Me.btnGenRep.Text = "&Generate"
        Me.btnGenRep.ThemeName = "Windows8"
        '
        'ddlClass
        '
        Me.ddlClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlClass.Location = New System.Drawing.Point(145, 44)
        Me.ddlClass.Name = "ddlClass"
        Me.ddlClass.Size = New System.Drawing.Size(189, 20)
        Me.ddlClass.TabIndex = 264
        Me.ddlClass.ThemeName = "Windows8"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(61, 44)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(83, 21)
        Me.RadLabel3.TabIndex = 265
        Me.RadLabel3.Text = "Classification"
        Me.RadLabel3.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(5, 122)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 263
        Me.lblBack.ThemeName = "Windows8"
        '
        'frmGenUpd8dBud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(408, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.ddlClass)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnGenRep)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.rbRepAA)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.ddlDept)
        Me.Controls.Add(Me.RadLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmGenUpd8dBud"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Updated Budget Report"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.ddlDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbRepAA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents ddlDept As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rbRepAA As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents btnGenRep As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlClass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class


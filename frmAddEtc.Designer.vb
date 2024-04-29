<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEtc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEtc))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.rbAddClass = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbAddDept = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbAddProcess = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txtAddCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtAddDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.btnAddEtc = New Telerik.WinControls.UI.RadButton()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwLoadData2 = New System.ComponentModel.BackgroundWorker()
        Me.bwLoadData3 = New System.ComponentModel.BackgroundWorker()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.btnDeleteEtc = New Telerik.WinControls.UI.RadButton()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.rbAddSC = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtActivityCode = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.rbAddClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbAddDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbAddProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddEtc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteEtc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbAddSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivityCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbAddClass
        '
        Me.rbAddClass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbAddClass.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbAddClass.Location = New System.Drawing.Point(9, 18)
        Me.rbAddClass.Name = "rbAddClass"
        Me.rbAddClass.Size = New System.Drawing.Size(100, 21)
        Me.rbAddClass.TabIndex = 6
        Me.rbAddClass.Text = "Classification"
        Me.rbAddClass.ThemeName = "Windows8"
        Me.rbAddClass.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rbAddDept
        '
        Me.rbAddDept.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbAddDept.Location = New System.Drawing.Point(115, 18)
        Me.rbAddDept.Name = "rbAddDept"
        Me.rbAddDept.Size = New System.Drawing.Size(95, 21)
        Me.rbAddDept.TabIndex = 7
        Me.rbAddDept.Text = "Department"
        Me.rbAddDept.ThemeName = "Windows8"
        '
        'rbAddProcess
        '
        Me.rbAddProcess.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbAddProcess.Location = New System.Drawing.Point(216, 18)
        Me.rbAddProcess.Name = "rbAddProcess"
        Me.rbAddProcess.Size = New System.Drawing.Size(68, 21)
        Me.rbAddProcess.TabIndex = 8
        Me.rbAddProcess.Text = "Process"
        Me.rbAddProcess.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(2, 217)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 226
        Me.lblBack.ThemeName = "Windows8"
        '
        'RadLabel13
        '
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(71, 58)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(38, 21)
        Me.RadLabel13.TabIndex = 229
        Me.RadLabel13.Text = "Code"
        Me.RadLabel13.ThemeName = "Windows8"
        '
        'txtAddCode
        '
        Me.txtAddCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddCode.Location = New System.Drawing.Point(181, 59)
        Me.txtAddCode.Name = "txtAddCode"
        Me.txtAddCode.Size = New System.Drawing.Size(189, 20)
        Me.txtAddCode.TabIndex = 228
        Me.txtAddCode.ThemeName = "Windows8"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(71, 84)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(74, 21)
        Me.RadLabel1.TabIndex = 231
        Me.RadLabel1.Text = "Description"
        Me.RadLabel1.ThemeName = "Windows8"
        '
        'txtAddDesc
        '
        Me.txtAddDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddDesc.Location = New System.Drawing.Point(181, 85)
        Me.txtAddDesc.Name = "txtAddDesc"
        Me.txtAddDesc.Size = New System.Drawing.Size(189, 20)
        Me.txtAddDesc.TabIndex = 230
        Me.txtAddDesc.ThemeName = "Windows8"
        '
        'btnAddEtc
        '
        Me.btnAddEtc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEtc.Location = New System.Drawing.Point(250, 137)
        Me.btnAddEtc.Name = "btnAddEtc"
        Me.btnAddEtc.Size = New System.Drawing.Size(120, 40)
        Me.btnAddEtc.TabIndex = 232
        Me.btnAddEtc.Text = "&Add"
        Me.btnAddEtc.ThemeName = "Windows8"
        '
        'rgvList
        '
        Me.rgvList.AutoSizeRows = True
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Right
        Me.rgvList.Location = New System.Drawing.Point(376, 0)
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
        Me.rgvList.Size = New System.Drawing.Size(386, 315)
        Me.rgvList.TabIndex = 233
        Me.rgvList.ThemeName = "Windows8"
        '
        'btnDeleteEtc
        '
        Me.btnDeleteEtc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEtc.Location = New System.Drawing.Point(250, 183)
        Me.btnDeleteEtc.Name = "btnDeleteEtc"
        Me.btnDeleteEtc.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteEtc.TabIndex = 234
        Me.btnDeleteEtc.Text = "&Delete"
        Me.btnDeleteEtc.ThemeName = "Windows8"
        '
        'rbAddSC
        '
        Me.rbAddSC.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.rbAddSC.Location = New System.Drawing.Point(290, 18)
        Me.rbAddSC.Name = "rbAddSC"
        Me.rbAddSC.Size = New System.Drawing.Size(80, 21)
        Me.rbAddSC.TabIndex = 235
        Me.rbAddSC.Text = "Sub Class"
        Me.rbAddSC.ThemeName = "Windows8"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(71, 110)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(85, 21)
        Me.RadLabel2.TabIndex = 237
        Me.RadLabel2.Text = "Activity Code"
        Me.RadLabel2.ThemeName = "Windows8"
        '
        'txtActivityCode
        '
        Me.txtActivityCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActivityCode.Enabled = False
        Me.txtActivityCode.Location = New System.Drawing.Point(181, 111)
        Me.txtActivityCode.Name = "txtActivityCode"
        Me.txtActivityCode.Size = New System.Drawing.Size(189, 20)
        Me.txtActivityCode.TabIndex = 236
        Me.txtActivityCode.ThemeName = "Windows8"
        '
        'frmAddEtc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtActivityCode)
        Me.Controls.Add(Me.rbAddSC)
        Me.Controls.Add(Me.btnDeleteEtc)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.btnAddEtc)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtAddDesc)
        Me.Controls.Add(Me.RadLabel13)
        Me.Controls.Add(Me.txtAddCode)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.rbAddProcess)
        Me.Controls.Add(Me.rbAddDept)
        Me.Controls.Add(Me.rbAddClass)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmAddEtc"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Fields"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.rbAddClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbAddDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbAddProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddEtc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteEtc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbAddSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivityCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents rbAddClass As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbAddDept As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbAddProcess As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtAddCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtAddDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnAddEtc As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadData2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadData3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnDeleteEtc As Telerik.WinControls.UI.RadButton
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents rbAddSC As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtActivityCode As Telerik.WinControls.UI.RadTextBox
End Class


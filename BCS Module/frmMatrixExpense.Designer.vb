<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatrixExpense
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatrixExpense))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.rgvList = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leRecordCount = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement4 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement5 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lblRevNum = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserlvl = New Telerik.WinControls.UI.RadLabel()
        Me.lblUserID = New Telerik.WinControls.UI.RadLabel()
        Me.lblDept = New Telerik.WinControls.UI.RadLabel()
        Me.pbOlrayt = New System.Windows.Forms.ProgressBar()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.pbOhYeah = New Telerik.WinControls.UI.RadProgressBar()
        Me.btnNewMatrix = New Telerik.WinControls.UI.RadButton()
        Me.btnRefresh = New Telerik.WinControls.UI.RadButton()
        Me.lblBack = New Telerik.WinControls.UI.RadLabel()
        Me.btnEditMatrix = New Telerik.WinControls.UI.RadButton()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOhYeah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'rgvList
        '
        Me.rgvList.AutoScroll = True
        Me.rgvList.AutoSizeRows = True
        Me.rgvList.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvList.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.rgvList.MasterTemplate.AllowCellContextMenu = False
        Me.rgvList.MasterTemplate.AllowColumnReorder = False
        Me.rgvList.MasterTemplate.AllowDeleteRow = False
        Me.rgvList.MasterTemplate.EnableGrouping = False
        Me.rgvList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvList.Name = "rgvList"
        Me.rgvList.Size = New System.Drawing.Size(1264, 618)
        Me.rgvList.TabIndex = 21
        Me.rgvList.ThemeName = "Windows8"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Records Found"
        Me.RadLabelElement1.AccessibleName = "Records Found"
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadLabelElement1.Text = "User Count"
        Me.RadLabelElement1.TextWrap = True
        '
        'leRecordCount
        '
        Me.leRecordCount.AccessibleDescription = "0"
        Me.leRecordCount.AccessibleName = "0"
        Me.leRecordCount.Name = "leRecordCount"
        Me.leRecordCount.Text = "0"
        Me.leRecordCount.TextWrap = True
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.AccessibleDescription = "Records Found"
        Me.RadLabelElement2.AccessibleName = "Records Found"
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadLabelElement2.Text = "User Count"
        Me.RadLabelElement2.TextWrap = True
        '
        'RadLabelElement3
        '
        Me.RadLabelElement3.AccessibleDescription = "0"
        Me.RadLabelElement3.AccessibleName = "0"
        Me.RadLabelElement3.Name = "RadLabelElement3"
        Me.RadLabelElement3.Text = "0"
        Me.RadLabelElement3.TextWrap = True
        '
        'RadLabelElement4
        '
        Me.RadLabelElement4.AccessibleDescription = "Records Found"
        Me.RadLabelElement4.AccessibleName = "Records Found"
        Me.RadLabelElement4.Name = "RadLabelElement4"
        Me.RadLabelElement4.Text = "User Count"
        Me.RadLabelElement4.TextWrap = True
        '
        'RadLabelElement5
        '
        Me.RadLabelElement5.AccessibleDescription = "0"
        Me.RadLabelElement5.AccessibleName = "0"
        Me.RadLabelElement5.Name = "RadLabelElement5"
        Me.RadLabelElement5.Text = "0"
        Me.RadLabelElement5.TextWrap = True
        '
        'lblRevNum
        '
        Me.lblRevNum.Location = New System.Drawing.Point(425, 64)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(2, 2)
        Me.lblRevNum.TabIndex = 127
        Me.lblRevNum.Visible = False
        '
        'lblUserlvl
        '
        Me.lblUserlvl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserlvl.Location = New System.Drawing.Point(893, 624)
        Me.lblUserlvl.Name = "lblUserlvl"
        Me.lblUserlvl.Size = New System.Drawing.Size(46, 21)
        Me.lblUserlvl.TabIndex = 214
        Me.lblUserlvl.Text = "Userlvl"
        Me.lblUserlvl.ThemeName = "Windows8"
        Me.lblUserlvl.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(845, 624)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(46, 21)
        Me.lblUserID.TabIndex = 213
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.ThemeName = "Windows8"
        Me.lblUserID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(803, 624)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(36, 21)
        Me.lblDept.TabIndex = 212
        Me.lblDept.Text = "Dept"
        Me.lblDept.ThemeName = "Windows8"
        Me.lblDept.Visible = False
        '
        'pbOlrayt
        '
        Me.pbOlrayt.Location = New System.Drawing.Point(66, 641)
        Me.pbOlrayt.Name = "pbOlrayt"
        Me.pbOlrayt.Size = New System.Drawing.Size(311, 18)
        Me.pbOlrayt.Step = 1
        Me.pbOlrayt.TabIndex = 344
        Me.pbOlrayt.UseWaitCursor = True
        Me.pbOlrayt.Visible = False
        '
        'pbOhYeah
        '
        Me.pbOhYeah.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pbOhYeah.ForeColor = System.Drawing.Color.White
        Me.pbOhYeah.Location = New System.Drawing.Point(66, 642)
        Me.pbOhYeah.Name = "pbOhYeah"
        Me.pbOhYeah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbOhYeah.SeparatorWidth = 2
        Me.pbOhYeah.Size = New System.Drawing.Size(311, 15)
        Me.pbOhYeah.Step = 1
        Me.pbOhYeah.TabIndex = 354
        Me.pbOhYeah.Text = "Loading..."
        Me.pbOhYeah.ThemeName = "TelerikMetroBlue"
        Me.pbOhYeah.Value2 = 1
        Me.pbOhYeah.Visible = False
        '
        'btnNewMatrix
        '
        Me.btnNewMatrix.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMatrix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMatrix.Location = New System.Drawing.Point(1075, 624)
        Me.btnNewMatrix.Name = "btnNewMatrix"
        Me.btnNewMatrix.Size = New System.Drawing.Size(120, 40)
        Me.btnNewMatrix.TabIndex = 355
        Me.btnNewMatrix.Text = "&Add New"
        Me.btnNewMatrix.ThemeName = "Windows8"
        Me.btnNewMatrix.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.ACCTNG.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh.Location = New System.Drawing.Point(1201, 624)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(63, 40)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.ThemeName = "Windows8"
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = CType(resources.GetObject("lblBack.Image"), System.Drawing.Image)
        Me.lblBack.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Location = New System.Drawing.Point(0, 624)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(61, 57)
        Me.lblBack.TabIndex = 200
        '
        'btnEditMatrix
        '
        Me.btnEditMatrix.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditMatrix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMatrix.Location = New System.Drawing.Point(949, 624)
        Me.btnEditMatrix.Name = "btnEditMatrix"
        Me.btnEditMatrix.Size = New System.Drawing.Size(120, 40)
        Me.btnEditMatrix.TabIndex = 356
        Me.btnEditMatrix.Text = "&Edit"
        Me.btnEditMatrix.ThemeName = "Windows8"
        Me.btnEditMatrix.Visible = False
        '
        'frmMatrixExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 723)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEditMatrix)
        Me.Controls.Add(Me.btnNewMatrix)
        Me.Controls.Add(Me.pbOhYeah)
        Me.Controls.Add(Me.pbOlrayt)
        Me.Controls.Add(Me.lblUserlvl)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblRevNum)
        Me.Controls.Add(Me.rgvList)
        Me.Controls.Add(Me.lblBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMatrixExpense"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Matrix for Expenses"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.rgvList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserlvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOhYeah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents lblBack As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents rgvList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leRecordCount As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement4 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement5 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lblRevNum As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnRefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblUserlvl As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblUserID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDept As Telerik.WinControls.UI.RadLabel
    Friend WithEvents pbOlrayt As System.Windows.Forms.ProgressBar
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents pbOhYeah As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents btnNewMatrix As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEditMatrix As Telerik.WinControls.UI.RadButton
End Class


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsplash))
        Me.lblcompany = New System.Windows.Forms.Label()
        Me.lbllogo = New System.Windows.Forms.Label()
        Me.pbOhYeah = New Telerik.WinControls.UI.RadProgressBar()
        Me.bwOhYeah = New System.ComponentModel.BackgroundWorker()
        Me.tmrOhYeah = New System.Windows.Forms.Timer(Me.components)
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbOhYeah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompany.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblcompany.Location = New System.Drawing.Point(193, 215)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(226, 21)
        Me.lblcompany.TabIndex = 4
        Me.lblcompany.Text = "Furukawa Electric Autoparts Phil."
        '
        'lbllogo
        '
        Me.lbllogo.AutoSize = True
        Me.lbllogo.Font = New System.Drawing.Font("Segoe UI Semilight", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbllogo.Location = New System.Drawing.Point(57, 44)
        Me.lbllogo.Name = "lbllogo"
        Me.lbllogo.Size = New System.Drawing.Size(169, 98)
        Me.lbllogo.TabIndex = 3
        Me.lbllogo.Text = "BAP"
        '
        'pbOhYeah
        '
        Me.pbOhYeah.ForeColor = System.Drawing.Color.White
        Me.pbOhYeah.Location = New System.Drawing.Point(77, 145)
        Me.pbOhYeah.Name = "pbOhYeah"
        Me.pbOhYeah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbOhYeah.SeparatorWidth = 2
        Me.pbOhYeah.Size = New System.Drawing.Size(428, 15)
        Me.pbOhYeah.Step = 1
        Me.pbOhYeah.TabIndex = 6
        Me.pbOhYeah.Text = "Loading..."
        Me.pbOhYeah.ThemeName = "TelerikMetroBlue"
        Me.pbOhYeah.Value2 = 1
        '
        'bwOhYeah
        '
        Me.bwOhYeah.WorkerReportsProgress = True
        '
        'tmrOhYeah
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(215, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Budget Actual Program"
        '
        'frmsplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 245)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbOhYeah)
        Me.Controls.Add(Me.lbllogo)
        Me.Controls.Add(Me.lblcompany)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsplash"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        CType(Me.pbOhYeah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents lbllogo As System.Windows.Forms.Label
    Friend WithEvents pbOhYeah As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents bwOhYeah As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrOhYeah As System.Windows.Forms.Timer
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class


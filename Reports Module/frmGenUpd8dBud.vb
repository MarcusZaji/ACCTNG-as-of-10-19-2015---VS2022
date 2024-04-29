Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmGenUpd8dBud

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmGenUpd8dBud_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmGenUpd8dBud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) 'moveable form :)

        DepartmentReport()
        ClassReport()

        ddlDept.Text = ""
        ddlClass.Text = ""

        dtpFrom.Value = Today
        dtpTo.Value = Today

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub btnGenRep_Click(sender As Object, e As EventArgs) Handles btnGenRep.Click
        Try
            reporttype = 6
            frmReport.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
        
    End Sub

End Class

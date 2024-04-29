Imports Telerik.WinControls

Public Class frmBudgetSetting

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmBudgetSetting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmBudgetSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim drYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
        Dim drYearNow As String = drYear.Item("fldLimit").ToString
        mebYear.Value = drYearNow

        'moveCtrl = New MoveControl(Me) 'moveable form :)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to set this year?",
                  "Budget Settings", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            Tomboy.UpdateBudgetSetting(mebYear.Value)
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Settings Ok! You must restart the system to take effect the changes.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)

        End If

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

End Class

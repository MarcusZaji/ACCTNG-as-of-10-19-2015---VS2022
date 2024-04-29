Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class FrmChangePW

    Private Sub FrmChangePW_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmChangePW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsername()
    End Sub

    Private Sub LoadUsername()
        Dim dr As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & lblID.Text & "'")
        Me.Text = "Change Password - " & "[" & dr.Item("fldUsername").ToString & "]"
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub FrmChangePW_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim Match = String.Compare(txtPW.Text, txtconPW.Text, ignoreCase:=False)

        If Not Match = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("The same password should be entered in both fields. Please re-enter the password correctly.", "Password Mismatch", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            If Tomboy.ChangePassword(Convert.ToInt32(lblID.Text), Chinita.getMD5Hash(txtPW.Text)) Then
                Me.Close()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Password changed successfully!", "Password Change", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End If
    End Sub

End Class

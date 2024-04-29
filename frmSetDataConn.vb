Imports Telerik.WinControls

Public Class frmSetDataConn

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmSetDataConn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmSetDataConn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mebServerIp.Text = My.Settings.setServerAddress
        txtDbName.Text = My.Settings.setServerDBName
        txtUsername.Text = My.Settings.setUsername
        txtPassword.Text = My.Settings.setPassword

        'moveCtrl = New MoveControl(Me) 'moveable form :)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim TestConnString As String = "server=" & mebServerIp.Value.ToString & ";" & "uid=" & txtUsername.Text & ";" & "pwd=" & txtPassword.Text & ";" & "Convert Zero Datetime=True;" & "database=" & txtDbName.Text & ";"

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(TestConnString)

        Try
            conn.Open()
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Settings Ok! You must restart the system to take effect the changes.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
            conn.Close()
            conn = Nothing

            My.Settings.setServerAddress = mebServerIp.Value.ToString
            My.Settings.setServerDBName = txtDbName.Text
            My.Settings.setUsername = txtUsername.Text
            My.Settings.setPassword = txtPassword.Text

            My.Settings.Save()

        Catch ex As Exception
            RadMessageBox.Show("Invalid Settings", "Failed", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

End Class

Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class FrmThemeSelector
    Dim moveCtrl As MoveControl = Nothing

    Public Sub ChangeFontColor(ByVal root As Control)

        If rcbTheme.Value = Color.White Then
            For Each ctrl As Control In root.Controls
                ChangeFontColor(ctrl)
                If TypeOf ctrl Is Telerik.WinControls.UI.RadLabel Then
                    CType(ctrl, Telerik.WinControls.UI.RadLabel).ForeColor = Color.Black
                End If

            Next ctrl

        Else
            For Each ctrl As Control In root.Controls
                ChangeFontColor(ctrl)
                If TypeOf ctrl Is Telerik.WinControls.UI.RadLabel Then
                    CType(ctrl, Telerik.WinControls.UI.RadLabel).ForeColor = Color.White
                End If

            Next ctrl

        End If

    End Sub

    Private Sub btnSetTheme_Click(sender As Object, e As EventArgs) Handles btnSetTheme.Click
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim Theme As String

        frmMain.BackColor = rcbTheme.Value

        ChangeFontColor(frmMain)

        Try
            Theme = ColorTranslator.ToHtml(rcbTheme.Value)

            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "UPDATE tblUser SET fldThemeColor=@fldThemeColor WHERE fldUID='" & frmMain.lblId.Text & "'"
            myCmd.Parameters.AddWithValue("@fldThemeColor", Theme)
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub FrmThemeSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) 'moveable form :)
    End Sub
End Class

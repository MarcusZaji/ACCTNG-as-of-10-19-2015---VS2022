Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Diagnostics

Public Class frmLogin
    Dim moveCtrl As MoveControl = Nothing

    Private Sub txtPW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPW.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            picLogin_Click(e, System.EventArgs.Empty)
        Else

        End If
    End Sub

    Private Sub txtUN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUN.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            txtPW.Focus()
        Else

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dtRate Is Nothing Then
            If RadMessageBox.Show("No Rate found. The system will close automatically") Then
                For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                    If My.Application.OpenForms.Item(i) IsNot Me Then
                        My.Application.OpenForms.Item(i).Dispose()
                    End If
                Next i

                Application.Exit()
            End If
        End If

        If dtItemCode Is Nothing Then
            If RadMessageBox.Show("No Item Code found. The system will close automatically") Then
                For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                    If My.Application.OpenForms.Item(i) IsNot Me Then
                        My.Application.OpenForms.Item(i).Dispose()
                    End If
                Next i

                Application.Exit()
            End If
        End If

        moveCtrl = New MoveControl(Me) 'moveable form :)

        'Dim Version As Integer = 9

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT fldProName, fldLimit, fldName FROM tblSettings WHERE fldProID = 2")
        Dim BAP_Version As Integer = drUser.Item("fldLimit")
        Dim Bap_VerLabel As String = drUser.Item("fldProName")
        Dim Bap_VerName As String = drUser.Item("fldName")

        lblVersion.Text = Bap_VerName

        If Version <> BAP_Version Then

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Program is not Updated. " & Environment.NewLine &
                                  "Do you want to Update BAP to latest version - '" & Bap_VerName & "' ?",
                                  "Update BAP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                System.Diagnostics.Process.Start(Application.StartupPath + "\BAPUpdateManager.exe")

            End If

            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me Then
                    My.Application.OpenForms.Item(i).Dispose()
                End If
            Next i

            Application.Exit()

        End If

    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        'frmsplash.busy()
        'GTG = True
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i

        Application.Exit()
    End Sub

    Private Sub picLogin_Click(sender As Object, e As EventArgs) Handles picLogin.Click
        Dim password As String = Chinita.getMD5Hash(txtPW.Text)

        Dim myData As DataTable = Chinita.fetchDBTable("SELECT * FROM tblUser WHERE fldUsername ='" & txtUN.Text & "' AND fldPassword = '" & password & "'")

        If String.IsNullOrEmpty(txtUN.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Null username is invalid", "Invalid Username", MessageBoxButtons.OK, RadMessageIcon.Info)
            txtUN.Focus()
            txtUN.SelectAll()
        ElseIf myData.Rows.Count = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Access Denied! Please check your username and password.", "Login Failed", MessageBoxButtons.OK, RadMessageIcon.Info)
            txtPW.SelectAll()
        Else
            MyGlobal.EmpNo = txtUN.Text
            frmsplash.busy()
            Me.Hide()
            frmMain.lblId.Text = myData.Rows(0).Item("fldUID")
            frmMain.Show()
        End If
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        FrmServer.ShowDialog()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchReportServer()
    End Sub
    Private Sub FetchReportServer()
        Dim drConfig As DataRow = Nothing

        Dim dtConfig As DataTable = ReportServer.dbSelect("SP_SelectConfig")
        drConfig = dtConfig.Rows(0)

        globalVariables.ReportServer = drConfig.Item("fldServer")
        globalVariables.ReportUser = drConfig.Item("fldUser")
        globalVariables.ReportPass = drConfig.Item("fldPass")
    End Sub
End Class

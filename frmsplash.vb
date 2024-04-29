Imports Telerik.WinControls
Imports System.Windows.Forms

Public Class frmsplash

    Implements IMessageFilter

    Private Const LButtonDown As Integer = &H201
    Private Const LButtonUp As Integer = &H202
    Private Const LButtonDoubleClick As Integer = &H203


    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage

        Select Case m.Msg
            Case LButtonDown, LButtonUp, LButtonDoubleClick
                Dim ctl As Control = Control.FromHandle(m.HWnd)
                If Not ctl.Name = "picExit" Then
                    Return True
                End If
        End Select

        Return False

    End Function

    Private Sub frmsplash_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        busy()
        bwOhYeah.RunWorkerAsync()
    End Sub

    Public Sub busy(Optional displayProcessStatus As Boolean = False)
        tmrOhYeah.Start()

        For Each frm As Form In My.Application.OpenForms

            frm.Cursor = Cursors.WaitCursor
        Next
        imBusy = True

        If displayProcessStatus = True Then
            frmLongProcess.Show(frmMain)
        End If

        Application.AddMessageFilter(Me)

    End Sub

    Private Sub frmsplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Settings.Save()
        Me.Text = My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString

        My.Settings.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    End Sub

    Private Sub bwOhYeah_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwOhYeah.DoWork
        GetItemCodeSapFordt()
        GetRateAll()

        For x As Integer = 0 To 100
            Threading.Thread.Sleep(DelaySplash)
            bwOhYeah.ReportProgress(x)
        Next
    End Sub

    Private Sub bwOhYeah_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwOhYeah.ProgressChanged
        pbOhYeah.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwOhYeah_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwOhYeah.RunWorkerCompleted
        imBusy = False
        If connection_ok() = True Then
            frmLogin.Show()
            Me.Hide()
        Else
            frmSetDataConn.Show(Me)
            Me.Hide()
        End If
    End Sub

    Private Function connection_ok() As Boolean
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        connection_ok = False
        Try
            conn.Open()
            connection_ok = True
            conn.Close()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return connection_ok

    End Function

    Private Sub tmrOhYeah_Tick(sender As Object, e As EventArgs) Handles tmrOhYeah.Tick
        If imBusy = False Then
            tmrOhYeah.Stop()
            For Each frm As Form In My.Application.OpenForms
                frm.Cursor = Cursors.Arrow
            Next
            Application.RemoveMessageFilter(Me)
            frmLongProcess.Dispose()
        End If

        If GTG = True Then
            Me.Close()
        End If

    End Sub

End Class

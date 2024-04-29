Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class FrmServer
    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub FrmServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        imBusy = True
        dtLoadData = Chinita.fetchDBTable("select * from tblServer")
    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        pbOlrayt.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        Try
            rgvList.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOlrayt.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmServer_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        bwLoadData.RunWorkerAsync()
    End Sub


    Private Sub ReadyGrid()

        Dim fldSID As New GridViewDecimalColumn("ID")
        With fldSID
            .FieldName = "fldSID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldSID)

        Dim fldName As New GridViewTextBoxColumn("NAME")
        With fldName
            .FieldName = "fldName"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldName)

        Dim fldIP As New GridViewTextBoxColumn("IP ADDRESS")
        With fldIP
            .FieldName = "fldIP"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldIP)

        Dim fldDBName As New GridViewTextBoxColumn("DATABASE NAME")
        With fldDBName
            .FieldName = "fldDBName"
            .Width = 158
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDBName)
    End Sub

    Private Sub btnSavE_Click(sender As Object, e As EventArgs) Handles btnSavE.Click
       

        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("WARNING. Are you sure you want to change settings?",
                  "Budget Settings", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            My.Settings.BAPServerName = rgvList.CurrentRow.Cells("fldName").Value.ToString
            My.Settings.BAPServerAddress = rgvList.CurrentRow.Cells("fldIP").Value.ToString
            My.Settings.BAPDBName = rgvList.CurrentRow.Cells("fldDBName").Value.ToString
            ' My.Settings.dbBAP = "Server =" & My.Settings.BAPServerAddress & ";Database=" & My.Settings.BAPDBName & ";Uid=feap;Pwd=45|iF$;Convert Zero Datetime=True"

            My.Settings.Save()

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Settings Ok! You must restart the system to take effect the changes.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)

            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i

            Application.Exit()

        End If
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        MessageBox.Show(My.Settings.BAPServerName)
        MessageBox.Show(My.Settings.BAPServerAddress)
        MessageBox.Show(My.Settings.BAPDBName)
        ' MessageBox.Show(My.Settings.dbBAPFinalCon)
    End Sub
End Class

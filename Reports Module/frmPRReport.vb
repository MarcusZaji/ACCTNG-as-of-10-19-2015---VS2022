Imports Telerik.WinControls

Public Class FrmPRReport
    Private Sub FrmPRReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If reporttype = 1 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repPrintPRNewv2, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
            ReportViewer1.RefreshReport()
        ElseIf reporttype = 2 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.rptRemBudLessPR, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ' ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
            ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub FrmPRReport_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ReportViewer1_PrintEnd(sender As Object, args As Telerik.ReportViewer.Common.PrintEndEventArgs) Handles ReportViewer1.PrintEnd
        If reporttype = 1 Then
            If MyGlobal.PrintStat = "ORIGINAL" Then
                Dim myCmd As New MySqlCommand
                Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
                '------------------------------------PRINT PR------------------------------------------
                Try
                    conn.Open()
                    myCmd.Connection = conn

                    myCmd.CommandText = "UPDATE `tblPrintPR` SET `fldPrinted`= 'COPY' WHERE fldPRNo = '" & MyGlobal.PRNo & "' "

                    myCmd.ExecuteNonQuery()
                    conn.Close()

                Catch ex As Exception
                    conn.Close()
                End Try
                '-------------------------------------------------------------------------------------
            End If
        End If
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.Print
        Dim drPR As DataRow = Chinita.fetchMySqlRow("select fldPrinted from tblPrintPR where fldPRNo = '" & MyGlobal.PRNo & "'")
        If MyGlobal.PrintStat <> drPR.Item("fldPrinted").ToString Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("This PR will be close automatically. Please reopen the PR to print again Thank you", "Notification", MessageBoxButtons.OK)
            Me.Close()
            Exit Sub
        End If
    End Sub
End Class
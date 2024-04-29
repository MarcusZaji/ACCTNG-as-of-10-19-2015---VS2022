Imports Telerik.WinControls
Imports ACCTNG

Public Class frmReport

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        If reporttype = 1 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repBudgetGrid, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 2 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repDept, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 3 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repBud, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 4 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repMonth, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 5 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repAA, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                'typeReportSource.TypeName = "ACCTNG.Report1, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 6 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repBudUpdated, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 7 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repIR2, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 8 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repOrderList, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 9 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repSOrderList, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 10 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repRWG, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 11 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repRWGC, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 12 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repMonthAll, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 13 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repRWG_PO, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 14 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repRWG_POClass, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 15 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repPrintPRNew, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 16 Then
                'Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                'typeReportSource.TypeName = "ACCTNG.repPR_Item, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                'Me.ReportViewer1.ReportSource = typeReportSource
                'ReportViewer1.RefreshReport()


            ElseIf reporttype = 17 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repUPO_Summary, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 18 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repFPO_Summary_List, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 19 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repPR_Item_All, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 20 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repPR_Item_Open, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 21 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repPR_Item_Open_All, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 101 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repFBperAmount, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 201 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repRWG_POClassByClass, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 202 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.repRWGC_Class, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()

            ElseIf reporttype = 963 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.rptPRHeader, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()
                '------------------------------------Investment Report--------------------------------------------------
            ElseIf reporttype = 1025 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.rtpInvestment, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()
            ElseIf reporttype = 1026 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.RptPerInvNo, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()
            ElseIf reporttype = 1027 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.rptDetailedReportInv, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()
            ElseIf reporttype = 1028 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.RptPerInvPO, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()
            ElseIf reporttype = 1029 Then
                Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
                typeReportSource.TypeName = "ACCTNG.RptPerInvPODetails, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                Me.ReportViewer1.ReportSource = typeReportSource
                ReportViewer1.RefreshReport()
                '-------------------------------------------------------------------------------------------------------
            End If
        'ElseIf My.Settings.BAPServerName = "BAP 2017" Then

        '    If reporttype = 1 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repBudgetGrid2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 2 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repDept2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 3 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repBud2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 4 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repMonth2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 5 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        ' typeReportSource.TypeName = "ACCTNG.repAA2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        typeReportSource.TypeName = "ACCTNG.Report1, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 6 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repBudUpdated2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 7 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repIR22017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 8 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repOrderList2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 9 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repSOrderList2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 10 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repRWG2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 11 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repRWGC2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 12 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repMonthAll2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 13 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repRWG_PO2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 14 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repRWG_POClass2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 15 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repPrintPR2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        Me.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 16 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repPR_Item2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 17 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repUPO_Summary2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 18 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repFPO_Summary_List2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 19 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repPR_Item_All2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 20 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repPR_Item_Open2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 21 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repPR_Item_Open_All2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 101 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repFBperAmount2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 201 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repRWG_POClassByClass2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    ElseIf reporttype = 202 Then
        '        Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
        '        typeReportSource.TypeName = "ACCTNG.repRWGC_Class2017, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        '        Me.ReportViewer1.ReportSource = typeReportSource
        '        ReportViewer1.RefreshReport()

        '    End If
        'ElseIf My.Settings.BAPServerName = "BAP 2017" Then
        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show("Sorry No Data for 2016 DATA", "Notification", MessageBoxButtons.OK)
        'End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ReportViewer1_PrintEnd(sender As Object, e As EventArgs) Handles ReportViewer1.PrintEnd
        'MessageBox.Show(frmOrder.txtPRNum.Text)
        If reporttype = 15 Then
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

    Private Sub ReportViewer1_Export(sender As Object, args As Telerik.ReportViewer.WinForms.ExportEventArgs) Handles ReportViewer1.Export

    End Sub
End Class

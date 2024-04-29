Imports System
Imports System.Data
Imports Telerik.Reporting
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmReportServer
    Private uriReportSource = New Telerik.Reporting.UriReportSource

    Private Sub FrmReportServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ReportViewer1.ReportEngineConnection = New Telerik.ReportViewer.Common.ReportServerConnectionInfo("https://repsrv.furukawa.com.ph", "reportViewer", "WebSlinger15", 10000).ConnectionString
        ReportViewer1.ReportEngineConnection = New Telerik.ReportViewer.Common.ReportServerConnectionInfo(globalVariables.ReportServer, globalVariables.ReportUser, globalVariables.ReportPass, 10000).ConnectionString
        Select Case reporttype
            Case 0
                Me.Text = "REQUEST FOR QUOTATION REPORT"
                uriReportSource.Uri = "BAP/rptRFQUsersV2"
                'uriReportSource.Uri = "\\" + "\\192.168.191.20\\public\\rpt\\rptRFQUsers.trdp"  
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("RFQNo", globalVariables.RID))
                ReportViewer1.ReportSource = uriReportSource
            Case 1
                Me.Text = "REQUEST FOR QUOTATION REPORT"
                uriReportSource.Uri = "BAP/rptRFQPurv3"
                'uriReportSource.Uri = "\\" + "\\192.168.191.20\\public\\rpt\\rptRFQPur.trdp"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Category", globalVariables.LoginRFQSection))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("RFQPurNo", globalVariables.RFQNo))
                ReportViewer1.ReportSource = uriReportSource
            Case 2
                uriReportSource.Uri = "\\" + "\\192.168.191.20\\public\\rpt\\repPR_Item.trdp"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource
            Case 3
                uriReportSource.Uri = "\\" + "\\192.168.191.20\\public\\rpt\\rptRemBudLessPR.trdp"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("BudRefNum", globalVariables.BudRefNo))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("budget", globalVariables.Budget))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("UPO", globalVariables.UPO))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("PO", globalVariables.PO))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("PRNPO", globalVariables.PRNPO))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("RBLessPR", globalVariables.RBLessPR))
                ReportViewer1.ReportSource = uriReportSource
            Case 4
                Me.Text = "PR AND BUDGET SUMMARY"
                uriReportSource.Uri = "BAP/rptPRWithSummaryv3"
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                'uriReportSource.Uri = "\\" + "\\192.168.191.20\\public\\rpt\\rptPRWithSummary.trbp"
                uriReportSource.Parameters.Add(New Parameter("BudRefNum", globalVariables.PassBudRefNo))
                uriReportSource.Parameters.Add(New Parameter("PR", MyGlobal.PR))
                uriReportSource.Parameters.Add(New Parameter("Remarks", MyGlobal.Remarks))
                uriReportSource.Parameters.Add(New Parameter("DeptBud", MyGlobal.DeptBud))
                uriReportSource.Parameters.Add(New Parameter("MoldDie", MyGlobal.MoldDie))
                uriReportSource.Parameters.Add(New Parameter("RemDBLPR", MyGlobal.RemDBLPR))
                uriReportSource.Parameters.Add(New Parameter("Currency", MyGlobal.Currency))
                uriReportSource.Parameters.Add(New Parameter("TOPDRA", MyGlobal.TOPDRA))
                uriReportSource.Parameters.Add(New Parameter("PrintStat", MyGlobal.PrintStat))
                uriReportSource.Parameters.Add(New Parameter("MajorBud", MyGlobal.MajorBud))
                ReportViewer1.ReportSource = uriReportSource
            Case 5

                Me.Text = "REPORT PER DEPARTMENT"
                uriReportSource.Uri = "BAP/repDept"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource
            Case 6
                Me.Text = "REPORT PER Major Budget"
                uriReportSource.Uri = "BAP/repBudV3"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choose", globalVariables.Choose))
                ReportViewer1.ReportSource = uriReportSource
            Case 7
                Me.Text = "REPORT PER SUB Budget"
                uriReportSource.Uri = "BAP/rptSubBudget"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choose", globalVariables.Choose))
                ReportViewer1.ReportSource = uriReportSource
            Case 8
                Me.Text = "REPORT PER Month"
                uriReportSource.Uri = "BAP/repMonth"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource
            Case 9
                Me.Text = "REPORT PER ACQUISITION"
                uriReportSource.Uri = "BAP/repAA"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Class", globalVariables._Class))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource

            Case 10
                Me.Text = "REPORT PER ORDER"
                uriReportSource.Uri = "BAP/repOrderList"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("DEPT", globalVariables.Department))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("PO", globalVariables._PO))
                ReportViewer1.ReportSource = uriReportSource
            Case 11
                Me.Text = "DEPARTMENT EXPENSE VS ACTUAL ACQUSITION"
                uriReportSource.Uri = "BAP/repRWG"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choice", globalVariables.Choice))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource
            Case 12
                Me.Text = "BUDGET SUMMARY"
                uriReportSource.Uri = "BAP/rptRemBudLessPRV3"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("BudRefNum", globalVariables.BudRefNo))
            Case 13
                Me.Text = "Classification Expense vs Actual Acquisition"
                uriReportSource.Uri = "BAP/repRWGC"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choice", globalVariables.Choice))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Class", globalVariables._Class))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource
            Case 14
                Me.Text = "Department Expense vs Purchase Order"
                uriReportSource.Uri = "BAP/repRWG_PO"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choice", globalVariables.Choice))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource
            Case 15
                Dim PassClass = ""
                If globalVariables._Class = "ALL" Then
                    PassClass = "%"
                Else
                    PassClass = globalVariables._Class
                End If

                Me.Text = "Classification Expense vs Purchase Order"
                uriReportSource.Uri = "BAP/repRWG_POClass"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choice", globalVariables.Choice))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Class", PassClass))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource
            Case 16
                Me.Text = "Purchase Requisition"
                uriReportSource.Uri = "BAP/repPR_Item_All"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource
            Case 17
                Me.Text = "Open Purchase Requisition"
                uriReportSource.Uri = "BAP/repPR_Item_Open"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource
            Case 18
                Dim PassDept = ""
                If globalVariables.Department = "ALL" Then
                    PassDept = "%"
                Else
                    PassDept = globalVariables.Department
                End If
                Me.Text = "Uploaded PO Summary"
                uriReportSource.Uri = "BAP/repUPO_Summary"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept", PassDept))
                ReportViewer1.ReportSource = uriReportSource
            Case 19
                Me.Text = "Force PO Summary"
                uriReportSource.Uri = "BAP/rptFPOSummary"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource
            Case 20
                Dim PassClass = ""
                If globalVariables._Class = "ALL" Then
                    PassClass = "%"
                Else
                    PassClass = globalVariables._Class
                End If

                Me.Text = "Classification Expense vs Purchase Order Class"
                uriReportSource.Uri = "BAP/repRWG_POClassByClass"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choice", globalVariables.Choice))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Class", PassClass))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept", globalVariables.Department))
                ReportViewer1.ReportSource = uriReportSource
            Case 21
                Dim PassClass = ""
                If globalVariables._Class = "ALL" Then
                    PassClass = "%"
                Else
                    PassClass = globalVariables._Class
                End If

                Me.Text = "Classification Expense vs Purchase Order Class"
                uriReportSource.Uri = "BAP/repRWGC_Class"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept", globalVariables.Department))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Class", PassClass))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Choice", globalVariables.Choice))
                ReportViewer1.ReportSource = uriReportSource
            Case 22
                Me.Text = "PR Report Parent"
                uriReportSource.Uri = "BAP/rptPRHeader"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("Dept1", globalVariables.Department))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource
            Case 23
                Me.Text = "Investment Report"
                uriReportSource.Uri = "BAP/rtpInvestment"
                ReportViewer1.ReportSource = uriReportSource
            Case 24
                Me.Text = "Report per Investment No"
                uriReportSource.Uri = "BAP/rptInvNo"
                uriReportSource.Parameters.Add(New Parameter("Dept", globalVariables.Department))
                uriReportSource.Parameters.Add(New Parameter("InvestmentNo", globalVariables.InvstmentNo))
                ReportViewer1.ReportSource = uriReportSource
            Case 25
                Me.Text = "Purchase Order"
                uriReportSource.Uri = "BAP/rptPurchaseOrderv2"
                uriReportSource.Parameters.Add(New Parameter("OBLine", globalVariables.OBLine))
                uriReportSource.Parameters.Add(New Parameter("POID", globalVariables.POID))
                ReportViewer1.ReportSource = uriReportSource
            Case 26
                Me.Text = "Purchase Order Report"
                'uriReportSource.Uri = "BAP/rptPurchasingReport"
                uriReportSource.Uri = "BAP/rptPOforSAP"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D1", globalVariables.d1))
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("D2", globalVariables.d2))
                ReportViewer1.ReportSource = uriReportSource

            Case 27
                'MessageBox.Show(globalVariables._Class)
                'MessageBox.Show(globalVariables.YearReport)
                Me.Text = "Sub Budget Report"
                uriReportSource.Uri = "BAP/rptSubBudgetClaire"
                ReportViewer1.ReportSource = uriReportSource

            Case 28
                Me.Text = "Request for quotation monitoring"
                uriReportSource.Uri = "BAP/rptRFQPurlist"
                uriReportSource.Parameters.Add(New Telerik.Reporting.Parameter("RFQby", globalVariables.EmpName))
                ReportViewer1.ReportSource = uriReportSource
        End Select


        '  myReportParam.ForEach(Function(p) uriReportSource.Parameters.Add(p))


        ReportViewer1.ReportSource = uriReportSource

        'ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview

        ReportViewer1.ZoomPercent = 100

        ReportViewer1.RefreshReport()

        myReportParam.Clear()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_PrintEnd(sender As Object, args As Telerik.ReportViewer.Common.PrintEndEventArgs) Handles ReportViewer1.PrintEnd
        'MessageBox.Show(frmOrder.txtPRNum.Text)
        If reporttype = 4 Then
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

    Private Sub ReportViewer1_Print(sender As Object, e As ComponentModel.CancelEventArgs) Handles ReportViewer1.Print
        If reporttype = 4 Then
            Dim drPR As DataRow = Chinita.fetchMySqlRow("select fldPrinted from tblPrintPR where fldPRNo = '" & MyGlobal.PRNo & "'")
            If MyGlobal.PrintStat <> drPR.Item("fldPrinted").ToString Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("This PR will be close automatically. Please reopen the PR to print again Thank you", "Notification", MessageBoxButtons.OK)
                Me.Close()
                Exit Sub
            End If
        End If
    End Sub

End Class

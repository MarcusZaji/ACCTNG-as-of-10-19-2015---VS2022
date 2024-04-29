Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repPrintPR2017

    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()

        Dim RDBBPR As Decimal = frmOrder.RemDeptBud.Value
        Dim EPRA As Decimal = frmOrder.Cookies
        Dim RDBLPR As Decimal = frmOrder.mebRemDBLPR.Text
        Dim TOPDRA As Decimal
        Dim PR As String = frmOrder.txtPRNum.Text
        Dim MOrder As Date = frmOrder.dtpMOrder.Text
        Dim Dept As String = frmOrder.ddlDept.Text

        Dim myDataTPR As DataTable = Chinita.fetchDBTable("SELECT format(if(PRD.fldEJPY is not null,sum(PRD.fldEJPY),0),2) as TPR FROM tblOrder PRD " _
                                                        & "where PRD.fldOrderStatus = 'OPEN' and PRD.fldPRNo = '" & PR & "'")
        Dim TPR As String = myDataTPR.Rows(0).Item("TPR").ToString

        Dim myDataTPRO As DataTable = Chinita.fetchDBTable("SELECT format(if(PRD.fldEOA is not null,sum(PRD.fldEOA),0),2) as TPRO FROM tblOrder PRD " _
                                                         & "where PRD.fldOrderStatus = 'OPEN' and PRD.fldPRNo = '" & PR & "'")

        Dim myDataMonthBudget As DataTable = Chinita.fetchDBTable("select if(Bud.fldYen is null,0,sum(Bud.fldYen)) as monthsum from tblBudget Bud " _
                                                        & "left join tblRevision Rev on Rev.fldBudRefNum = Bud.fldBudRefNum " _
                                                        & " where month(Bud.fldMBudgeted) = '" & MOrder.Month & "' and YEAR(Bud.fldMBudgeted) = '" & MOrder.Year & "' " _
                                                        & " and Rev.fldStat != 'CLOSE' and Bud.fldDept = '" & Dept & "'")

        Dim myDataMonthBudgetPR As DataTable = Chinita.fetchDBTable("SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY' " _
                                                        & "FROM tblOrder PR where  " _
                                                        & " PR.fldOrderDepartment = '" & Dept & "' AND month(PR.fldMO) = '" & MOrder.Month & "' and  " _
                                                        & " YEAR(PR.fldMO) = '" & MOrder.Year & "' and PR.fldOrderStatus = 'OPEN'")

        Dim MonthBudgetPR As Decimal = Convert.ToDecimal(myDataMonthBudgetPR.Rows(0).Item("TJPY").ToString)

        Dim MonthBudget As Decimal = Convert.ToDecimal(myDataMonthBudget.Rows(0).Item("monthsum").ToString)

        Dim TPRO As String = myDataTPRO.Rows(0).Item("TPRO").ToString

        txtRemarks.Value = frmOrder.Remarks.Text

        txtDeptBud.Value = frmOrder.RemDeptBud.Text

        txtMoldDie.Value = frmOrder.txtMoldDie.Text

        'txtEPA.Value = frmOrder.mebEPA.Text

        'txtTOPDRA.Value = frmOrder.mebTOPDRA.Text

        txtRemDBLPR.Value = frmOrder.mebRemDBLPR.Text

        txtCurrency.Value = frmOrder.ddlCurrency.Text

        txtEPA.Value = TPR
        txtAmount.Value = TPRO

        Me.ReportParameters("PR").Value = frmOrder.txtPRNum.Text

        TOPDRA = RDBBPR - EPRA - RDBLPR
        txtTOPDRA.Value = String.Format("{0:N2}", TOPDRA)

        txtMonthBudget.Value = String.Format("{0:N2}", MonthBudget)
        txtMonthBudgetBalance.Value = String.Format("{0:N2}", MonthBudget - MonthBudgetPR)

    End Sub

End Class
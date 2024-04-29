Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports MySql.Data.MySqlClient
Imports System.Linq

Partial Public Class RptPerInvPO
    Inherits Telerik.Reporting.Report
    Private dtLoadInvRec As DataTable
    Private dtLoadInv As DataTable
    Private dtLoadPO As DataTable
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("Dept").Value = FrmReportInvestment.ddlDept.Text
        Me.ReportParameters("InvestmentNo").Value = FrmReportInvestment.ddlInvestment.Text

        InvList(FrmReportInvestment.ddlDept.Text, FrmReportInvestment.ddlInvestment.Text)


    End Sub
    Public Sub InvList(ByVal Dept As String, ByVal InvNo As String)
        dtLoadInvRec = Chinita.fetchDBTable("call SP_SelectAllInvestmentRecord()")
        dtLoadPO = Chinita.fetchDBTable("select * from tblPOI")
        dtLoadInv = Chinita.fetchDBTable("call SP_SelectInvestmentPerInvNoDeptNew('" & InvNo & "','" & Dept & "')")
        Dim query = (From I In dtLoadInv.AsEnumerable()
                     Let AmountYen = FetchMeInv(I("fldInvestmentNo"))
                     Let AmountOrg = FetchMeInvOrg(I("fldInvestmentNo"))
        Select New With {
            Key .fldInvestmentNo = I("fldInvestmentNo"),
            Key .fldDate = I("fldDate"),
            Key .fldProjTitle = I("fldProjTitle"),
            Key .fldApprovedBudget = I("fldApprovedBudget"),
            Key .fldProdCostJPY = I("fldProdCostJPY"),
            Key .fldDateInstallation = I("fldDateInstallation"),
            Key .fldDateCompletion = I("fldDateCompletion"),
            Key .POYen = AmountYen,
            Key .POOrg = AmountOrg
        }).ToList
        Table1.DataSource = query
    End Sub


    Function FetchMeInv(ByVal InvNo As String) As Decimal
        Dim F = (From Inv In dtLoadInvRec.AsEnumerable()
                     Join PO In dtLoadPO.AsEnumerable() On Inv("fldPRNo") Equals PO("fldPRNo")
                     Where Inv("fldInvestmentNo") = InvNo
                     Select PO.Field(Of Decimal)("fldYen")).Sum()

        Dim Yen = F
        Return Yen
    End Function

    Function FetchMeInvOrg(ByVal InvNo As String) As Decimal
        Dim O = (From Inv In dtLoadInvRec.AsEnumerable()
                     Join PO In dtLoadPO.AsEnumerable() On Inv("fldPRNo") Equals PO("fldPRNo")
                     Where Inv("fldInvestmentNo") = InvNo
                     Select PO.Field(Of Decimal)("fldTotalCost")).Sum()

        Dim Org = O
        Return Org
    End Function

End Class
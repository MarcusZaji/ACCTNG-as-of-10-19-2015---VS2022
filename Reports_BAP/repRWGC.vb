Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repRWGC
    Inherits Telerik.Reporting.Report
    Private dtLoadData As DataTable
    Private dtDept As DataTable
    Private dtBudget As DataTable
    Private dtActual As DataTable
    Private dtPO As DataTable
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("d1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("d2").Value = frmGenReport.dtpTo.Value
        Me.ReportParameters("Class").Value = frmGenReport.ddlClass.Text
        Me.ReportParameters("Choice").Value = frmGenReport.ddlBT.Text

        'dtDept = Chinita.fetchDBTable("call SP_SelectAllDeptByDate('" & frmGenReport.dtpFrom.Value & "','" & frmGenReport.dtpTo.Value & "','" & frmGenReport.ddlClass.Text & "')")
        'dtBudget = Chinita.fetchDBTable("call SP_SelectBudgetByDate('" & frmGenReport.dtpFrom.Value & "','" & frmGenReport.dtpTo.Value & "')")
        'dtActual = Chinita.fetchDbTableSAPSupp("EXEC SP_SelectActualByDate @d1 = '" & frmGenReport.dtpFrom.Value & "',@d2 ='" & frmGenReport.dtpTo.Value & "'")
        'dtPO = Chinita.fetchDBTable("call SP_SelectAllPOI")

        'Dim Query = (From Dept In dtDept.AsEnumerable()
        '             Let Budget = GetBudget(Dept("fldDeptCode"), frmGenReport.ddlClass.Text)
        '    Select New With {
        '        Key .fldDeptCode = Dept("fldDeptCode"),
        '        Key .Bmonth = Dept("Bmonth"),
        '        Key .Budget = Budget
        '    }).ToList
        'dtLoadData = Chinita.convertToDatatable(Query)
        'Me.DataSource = dtLoadDat\a
    End Sub

    'Function GetBudget(ByVal DeptCode As String, ByVal PClass As String)

    '    If PClass = "ALL" Then
    '        Dim QueryBud = dtBudget.AsEnumerable().Where(Function(r) CStr(r("fldDept")) = DeptCode) _
    '                .Sum(Function(r) CType(r("YenOrg"), Decimal))
    '        Return Convert.ToString(QueryBud)
    '    Else
    '        Dim QueryBud = dtBudget.AsEnumerable().Where(Function(r) CStr(r("fldDept")) = DeptCode _
    '                AndAlso CStr(r("fldClass")) = PClass) _
    '                .Sum(Function(r) CType(r("YenOrg"), Decimal))
    '        Return Convert.ToString(QueryBud)
    '    End If

    'End Function

    'Function GetActual(ByVal D1 As DateTime, ByVal D2 As DateTime)
    '    Dim QueryAct = dtActual.AsEnumerable() _
    '                   .Where(Function(r) CStr(r(""))
    'End Function

End Class
Imports Telerik.WinControls

Public Class FrmPleaseWait
    Private dtLoadData As DataTable
    Private dtClass As DataTable
    Private dtBudget As DataTable
    Private dtActual As DataTable
    Private dtAllBudget As DataTable
    Private dtPO As DataTable
    Private dtBudYTD As DataTable
    Private dtFActual As DataTable
    Private dtFPO As DataTable
    Private Sub FrmPleaseWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtBudYTD = Chinita.fetchDBTable("call SP_SelectBudgetYTD('" & String.Format("{0:yyyy-MM-dd}", globalVariables.d1) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", globalVariables.d2)) & "','" & globalVariables.Department & "')")
        dtFActual = Chinita.fetchDBTable("call SP_SelectFActualByDateandDept('" & String.Format("{0:yyyy-MM-dd}", globalVariables.d1) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", globalVariables.d2)) & "','" & globalVariables.Department & "')")
        dtClass = Chinita.fetchDBTable("call SP_SelectAllClass('" & String.Format("{0:yyyy-MM-dd}", globalVariables.d1) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", globalVariables.d2)) & "','" & globalVariables._Class & "')")
        dtBudget = Chinita.fetchDBTable("call SP_SelectBudgetByDate('" & String.Format("{0:yyyy-MM-dd}", globalVariables.d1) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", globalVariables.d2)) & "')")
        dtActual = Chinita.fetchDBTable("call SP_SelectActualByDate('" & String.Format("{0:yyyy-MM-dd}", globalVariables.d1) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", globalVariables.d2)) & "')")
        dtFPO = Chinita.fetchDBTable("call SP_SelectFPOByDateDept('" & String.Format("{0:yyyy-MM-dd}", globalVariables.d1) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", globalVariables.d2)) & "','" & globalVariables.Department & "')")
        Dim Query = (From CL In dtClass.AsEnumerable()
                     Let Budget = GetBudget(frmGenReport.ddlDept.Text, CL("fldClassDesc"))
                     Let Actual = GetActual(frmGenReport.ddlDept.Text, CL("fldClassDesc"))
                     Let BudgetYTD = GetBudgetYTD(CL("fldClassDesc"))
                     Let FActual = GetFActual(CL("fldClassDesc"))
                     Select New With {
                        Key .fldClassCode = CL("fldClassCode"),
                        Key .fldClassDesc = CL("fldClassDesc"),
                        Key .Bmonth = CL("Bmonth"),
                        Key .Budget = Budget,
                        Key .Actual = Actual,
                        Key .BudgetYTD = BudgetYTD,
                        Key .FActual = FActual
                        }).ToList
        dtLoadData = Chinita.convertToDatatable(Query)
        globalVariables.dtRepSource = dtLoadData
        If Zaji.IsFormOpen(frmReport) Then
            frmReport.Focus()
        Else
            frmReport.Show()
        End If

        ' budgetCaptionTextBox.Value = frmGenReport.ddlBT.Text + "BUDGET"
    End Sub

    Function GetBudget(ByVal DeptCode As String, ByVal PClass As String)
        Dim BT As String = frmGenReport.ddlBT.Text
        If PClass = "ALL" Then
            If BT = "REVISED" Then
                Dim QueryBud = dtBudget.AsEnumerable().Where(Function(r) CStr(r("fldDept")) = DeptCode) _
                    .Sum(Function(r) CType(r("YenRev"), Decimal))
                Return Convert.ToString(QueryBud)
            Else
                Dim QueryBud = dtBudget.AsEnumerable().Where(Function(r) CStr(r("fldDept")) = DeptCode) _
                    .Sum(Function(r) CType(r("YenOrg"), Decimal))
                Return Convert.ToString(QueryBud)
            End If

        Else
            If BT = "REVISED" Then
                Dim QueryBud = dtBudget.AsEnumerable().Where(Function(r) CStr(r("fldDept")) = DeptCode _
                    AndAlso CStr(r("fldClass")) = PClass) _
                    .Sum(Function(r) CType(r("YenRev"), Decimal))
                Return Convert.ToString(QueryBud)
            Else
                Dim QueryBud = dtBudget.AsEnumerable().Where(Function(r) CStr(r("fldDept")) = DeptCode _
                    AndAlso CStr(r("fldClass")) = PClass) _
                    .Sum(Function(r) CType(r("YenOrg"), Decimal))
                Return Convert.ToString(QueryBud)
            End If

        End If

    End Function
    'Function GetActual(ByVal DeptCode As String, ByVal PClass As String)
    '    Dim QueryAct As Decimal = (From Ac In dtActual.AsEnumerable()
    '                    Join Bud In dtAllBudget.AsEnumerable() On Ac("U_BudgetRef") Equals Bud("fldBudRefNum")
    '                    Join PO In dtPO.AsEnumerable() On Ac("U_Detail_ID") Equals PO("OB_Detail_ID")
    '                    Where Bud.Field(Of String)("fldDept") = DeptCode AndAlso PO.Field(Of String)("fldClass") = PClass
    '                    Select Ac.Field(Of Decimal)("U_fldYenSap")).Sum()
    '    Return Convert.ToString(QueryAct)
    'End Function
    Function GetActual(ByVal DeptCode As String, ByVal MYCL As String)

        Dim QueryAct = dtActual.AsEnumerable().Where(Function(r) CStr(r("DEPT")) = DeptCode AndAlso CStr(r("fldClass")) = MYCL) _
                       .Sum(Function(r) CType(r("U_fldYenSap"), Decimal))
        Return Convert.ToString(QueryAct)
    End Function
    Function GetBudgetYTD(ByVal MYCL As String)

        '---------------------------------------
        Dim BT As String = frmGenReport.ddlBT.Text
        If BT = "REVISED" Then
            Dim QueryBudYTD = dtBudYTD.AsEnumerable().Where(Function(r) CStr(r("fldClass")) = MYCL) _
                   .Sum(Function(r) CType(r("YenRev"), Decimal))
            Return Convert.ToString(QueryBudYTD)
        Else
            Dim QueryBudYTD = dtBudYTD.AsEnumerable().Where(Function(r) CStr(r("fldClass")) = MYCL) _
                   .Sum(Function(r) CType(r("YenOrg"), Decimal))
            Return Convert.ToString(QueryBudYTD)
        End If
    End Function
    Function GetFActual(ByVal MYCL As String)
        Dim QueryFAct = dtFActual.AsEnumerable().Where(Function(r) CStr(r("fldClass")) = MYCL) _
                       .Sum(Function(r) CType(r("fldJPY"), Decimal))

        Dim QueryFPO = dtFPO.AsEnumerable().Where(Function(r) CStr(r("fldClass")) = MYCL) _
                       .Sum(Function(r) CType(r("fldYenSap"), Decimal))

        Dim FA As Decimal
        Dim FPO As Decimal
        Dim Total As Decimal
        FA = Convert.ToDecimal(QueryFAct)
        FPO = Convert.ToDecimal(QueryFPO)
        Total = FA + FPO
        '------------to be continued
        Return Convert.ToString(Total)
    End Function
End Class

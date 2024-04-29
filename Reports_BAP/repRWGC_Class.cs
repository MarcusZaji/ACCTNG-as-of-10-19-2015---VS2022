// Function GetActual(ByVal DeptCode As String, ByVal PClass As String)
// Dim QueryAct As Decimal = (From Ac In dtActual.AsEnumerable()
// Join Bud In dtAllBudget.AsEnumerable() On Ac("U_BudgetRef") Equals Bud("fldBudRefNum")
// Join PO In dtPO.AsEnumerable() On Ac("U_Detail_ID") Equals PO("OB_Detail_ID")
// Where Bud.Field(Of String)("fldDept") = DeptCode AndAlso PO.Field(Of String)("fldClass") = PClass
// Select Ac.Field(Of Decimal)("U_fldYenSap")).Sum()
// Return Convert.ToString(QueryAct)
// End Function
public void GetActual(string DeptCode, string MYCL)
{
    var QueryAct = dtActual.AsEnumerable().Where(r => (System.Convert.ToString(r["DEPT"]) ?? "") == (DeptCode ?? "") && (System.Convert.ToString(r["fldClass"]) ?? "") == (MYCL ?? ""))
                  .Sum(r => System.Convert.ToDecimal(r["U_fldYenSap"]));
    return Convert.ToString(QueryAct);
}

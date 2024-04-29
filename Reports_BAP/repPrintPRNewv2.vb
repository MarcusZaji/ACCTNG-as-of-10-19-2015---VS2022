Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repPrintPRNewv2

    Inherits Telerik.Reporting.Report
    Private DTGetAllBudget As DataTable = New DataTable()
    Private DTALLUPO As DataTable = New DataTable()
    Private DTPOI As DataTable = New DataTable()
    Private DTGRPO As DataTable = New DataTable()
    Private DtSelectPOI As DataTable = New DataTable()
    Private DTPO As DataTable = New DataTable()
    Private DTAllDept As DataTable = New DataTable()
    Private DTOPOR As DataTable = New DataTable()
    Private DTConv As DataTable = New DataTable()
    Private DTActual As DataTable = New DataTable()
    Private DTAllBudget As DataTable = New DataTable()
    Private DTRWG As DataTable = New DataTable()
    Private DTRate As DataTable = New DataTable()
    Private ActualList As DataTable = New DataTable()
    Private DTBud As DataTable = New DataTable()
    Private DTActualFinal As DataTable = New DataTable()
    Private PRList As DataTable = New DataTable()
    Private FPO As DataTable = New DataTable()
    Private DTClass As DataTable = New DataTable()
    Private dtFActual As DataTable = New DataTable()
    Private dtFPO As DataTable = New DataTable()
    Private DTPRListFromQuery As DataTable = New DataTable()
    Private DTPrntPR As DataTable = New DataTable()
    Private DTAllPOI As DataTable = New DataTable()
    Private DTActualDept As DataTable = New DataTable()
    Private DTOpenMOI As DataTable = New DataTable()
    Private DTSubBud As DataTable = New DataTable()
    Private DTModelActivity As DataTable = New DataTable()

    Public Sub New()
        InitializeComponent()


        Dim PR As String = MyGlobal.PR
        Dim Remarks As String = MyGlobal.Remarks
        Dim DeptBud As String = MyGlobal.DeptBud
        Dim MoldDie As String = MyGlobal.MoldDie
        Dim RemDBLPR As String = MyGlobal.RemDBLPR
        Dim Currency As String = MyGlobal.Currency
        Dim TOPDRA As String = MyGlobal.TOPDRA
        Dim PrintStat As String = MyGlobal.PrintStat
        Dim MajorBud As String = MyGlobal.MajorBud

        Me.ReportParameters("PR").Value = PR
        Me.ReportParameters("Remarks").Value = Remarks
        Me.ReportParameters("DeptBud").Value = DeptBud
        Me.ReportParameters("MoldDie").Value = MoldDie
        Me.ReportParameters("RemDBLPR").Value = RemDBLPR
        Me.ReportParameters("Currency").Value = Currency
        Me.ReportParameters("TOPDRA").Value = TOPDRA
        Me.ReportParameters("PrintStat").Value = PrintStat
        Me.ReportParameters("MajorBud").Value = MajorBud

        DTPrntPR = Chinita.fetchDBTable("SP_PRFormNew('" & PR & "')")
        DTALLUPO = Chinita.fetchDBTable("SP_SelectAllUPO")
        DTAllPOI = Chinita.fetchDBTable("SP_SelectAllPOI")
        DTOpenMOI = Chinita.fetchDBTable("SP_SelectMOIOpenbyYear")
        DTAllBudget = Chinita.fetchDBTable("SP_SelectAllMajorBudget")
        DTModelActivity = Chinita.fetchDBTable("SP_SelectModelActivitybyPRNo('" & PR & "')")

        Dim DTPOPOI = (From i In DTAllPOI.AsEnumerable()
                       Let _GetForcePO = GetForcePO(Convert.ToString(i("OB_Line"))) Select New With {
            .fldYenSap = i("fldYenSap"),
            .fldSubRefNo = i("fldSubRefNo"),
            .fldMO = i("fldMO"),
            .OB_Line = i("OB_Line"),
            .fldStat = i("fldStat"),
            .fldForcePO = _GetForcePO
        }).ToList()

        DTPOI = convertToDatatable(DTPOPOI)
        Dim query = (From i In DTPrntPR.AsEnumerable()
                     Let _GetSumUPO = GetSumUPO(Convert.ToString(i("fldSubRefNo")))
                     Let _GetSumUUPO = GetSumUUPO(Convert.ToString(i("fldSubRefNo")))
                     Let _GetPO = GetPO(Convert.ToString(i("fldSubRefNo")))
                     Let _GetFPO = GetFPO(Convert.ToString(i("fldSubRefNo")))
                     Let _GetSumMOI = GetSumMOI(Convert.ToString(i("fldSubRefNo")))
                     Let _GetProject = GetProject(Convert.ToString(i("MajorBud")))
                     Let _GetActivity = GetActivity()
                     Let _GetModel = GetModel()
                     Select New With {
                        .fldPRNo = i("fldPRNo"),
                        .fldRN = i("fldRN"),
                        .fldDN = String.Format("{0:MMM dd, yyyy}", i("fldDN")),
                        .Department = i("Department"),
                        .MajorBud = i("MajorBud"),
                        .fldSubRefNo = i("fldSubRefNo"),
                        .MajorDesc = i("MajorDesc"),
                        .fldClass = i("fldClass"),
                        .fldICode = i("fldICode"),
                        .fldDesc = i("fldDesc"),
                        .fldQTY = i("fldQTY"),
                        .fldUnit = i("fldUnit"),
                        .fldOrderRemarks = i("fldOrderRemarks"),
                        .fldNReason = i("fldNReason"),
                        .fldInsRequirements = i("fldInsRequirements"),
                        .fldMoldDie = i("fldMoldDie"),
                        .fldInvestmentNo = i("fldInvestmentNo"),
                        .TotalInvestmentBal = i("TotalInvestmentBal"),
                        .fldEC = i("fldEC"),
                        .TPRO = i("TPRO"),
                        .TPR = i("TPR"),
                        .fldSignature = i("fldSignature"),
                        .YenBud = i("YenBud"),
                        .SubDesc = i("SubDesc"),
                        .fldPeza = i("fldPeza"),
                        .UPO = _GetSumUPO,
                        .UUPO = _GetSumUUPO,
                        .PO = _GetPO,
                        .FPO = _GetFPO,
                        .GetSumMOI = _GetSumMOI,
                        .GetProject = _GetProject,
                        .GetActivity = _GetActivity,
                        .GetModel = _GetModel
                    }).ToList()
        Dim dtList As DataTable = convertToDatatable(query)

        Me.DataSource = dtList

    End Sub
    Public Function GetActivity()
        Dim query = (From i In DTModelActivity.AsEnumerable() Select Convert.ToString(i("fldActivity"))).FirstOrDefault()
        Return Convert.ToString(query)
    End Function
    Public Function GetModel()
        Dim query = (From i In DTModelActivity.AsEnumerable() Select Convert.ToString(i("fldModel"))).FirstOrDefault()
        Return Convert.ToString(query)
    End Function
    Public Function GetSumMOI(ByVal SubRef As String) As String
        Dim QueryMOI = DTOpenMOI.AsEnumerable().Where(Function(r) (Convert.ToString(r("fldSubRefNo")) = SubRef)).Sum(Function(r) Convert.ToDecimal(r("fldTotalCostJPY")))
        Return Convert.ToString(QueryMOI)
    End Function

    Public Function GetProject(ByVal MjrBud As String) As String
        Dim query = (From i In DTAllBudget.AsEnumerable() Where Convert.ToString(i("fldMajorRefNo")) = MjrBud Select (Convert.ToString(i("fldProject")))).FirstOrDefault()
        Return Convert.ToString(query)
    End Function
    Public Function GetSumUPO(ByVal _SubRefNo As String) As String
        Dim n = DTALLUPO.AsEnumerable().Where(Function(r) Convert.ToString(r("fldSubRefNo")) = _SubRefNo AndAlso Convert.ToString(r("fldPOOnly")) Is "NO").Sum(Function(r) Convert.ToDecimal(r("fldJPY")))
        Return Convert.ToString(String.Format("{0:N2}", n))
    End Function

    Public Function GetSumUUPO(ByVal _SubRefNo As String) As String
        Dim n = DTALLUPO.AsEnumerable().Where(Function(r) Convert.ToString(r("fldSubRefNo")) = _SubRefNo).Sum(Function(r) Convert.ToDecimal(r("fldJPY")))
        Return Convert.ToString(String.Format("{0:N2}", n))
    End Function

    Public Function GetPO(ByVal _SubRefNo As String) As String
        Dim n = DTPOI.AsEnumerable().Where(Function(r) Convert.ToString(r("fldSubRefNo")) = _SubRefNo AndAlso Convert.ToString(r("fldStat")) IsNot "CLOSE").Sum(Function(r) Convert.ToDecimal(r("fldYenSap")))
        Return Convert.ToString(String.Format("{0:N2}", n))
    End Function

    Public Function GetFPO(ByVal _SubRefNo As String) As String
        Dim n = DTPOI.AsEnumerable().Where(Function(r) Convert.ToString(r("fldSubRefNo")) = _SubRefNo AndAlso Convert.ToString(r("fldForcePO")) Is "YES").Sum(Function(r) Convert.ToDecimal(r("fldYenSap")))
        Return Convert.ToString(String.Format("{0:N2}", n))
    End Function
    Public Function GetForcePO(ByVal _OBLine As String) As String
        Dim query = (From i In DTPO.AsEnumerable() Where Convert.ToString(i("OB_Line")) = _OBLine Select Convert.ToString(i("fldForcePO"))).FirstOrDefault()
        Return Convert.ToString(query)
    End Function
    Public Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()

        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()

            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function
End Class
Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Text.RegularExpressions

Public Class frmCreatePR
    Private dtLoadData2 As DataTable
    Private dtSBudRec As DataTable
    Private DTItemsNonRM As DataTable
    Private DTModelList As DataTable
    Private Sub btnCreatePR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpMOrder.Value = Date.Today
        dtpDN.Value = Date.Today
        txtDept.Text = globalVariables.LoginDept
        ReadyGrid()
        GenTCNo()
        LoadBudRef()
        txtSignature.Text = globalVariables.LoginSignature
        ddlModel.DropDownListElement.AutoCompleteAppend = New MyAutoCompleteAppendHelper(ddlModel.DropDownListElement)
    End Sub
    Class MyAutoCompleteAppendHelper
        Inherits AutoCompleteAppendHelper

        Public Sub New(ByVal ddList As RadDropDownListElement)
            MyBase.New(ddList)
        End Sub

        Protected Overrides Function DefaultCompare(ByVal item As RadListDataItem) As Boolean
            Return item.Text = Me.FindString
        End Function
    End Class

    Private Sub frmCreatePR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchAllItemNonRM()
        SelectSubBudget()
        ClassificationCreatePR()
        GetProcess()
        'comment due to SAP problem
        ddlDataUOM()
        LoadSelectItem()
        LoadSelectItemByItemName()
        ' GetInvestment()
        '----------------------------
        ' New Item Non RM replace SAP
        'LoadSelectItemNew()
        'LoadSelectItemByItemNameNew()
        '------------------------------
        LoadInvestment()
        RemoveHandler ddlMajorBud.SelectedIndexChanged, AddressOf ddlMajorBud_SelectedIndexChanged
        GetMajorBudgetByDept()
        ddlMajorBud.SelectedIndex = -1
        ddlMajorBud.Text = ""
        AddHandler ddlMajorBud.SelectedIndexChanged, AddressOf ddlMajorBud_SelectedIndexChanged
        ClearField()
        FetchModel()
        Activity()
    End Sub

    Public Sub FetchModel()
        DTModelList = Zaji.dbSelect("SP_SelectAllModel")
    End Sub
    Public Sub Activity()
        Dim dtAct As DataTable = Zaji.dbSelect("SP_SelectAllActivity")
        ddlActivity.DataSource = dtAct
        ddlActivity.DisplayMember = "fldActivity"
        ddlActivity.Text = ""
    End Sub
    Public Sub GetRateToday(ByVal _Currency As String)
        If ddlCurrency.Text = "JPY" Or String.IsNullOrEmpty(ddlCurrency.Text) Then
            mebXRate.Value = 0.0
        Else
            Dim Query = (From i In dtRate.AsEnumerable()
                         Where i("Currency") = _Currency
                         Select fldRate = i("Rate")).FirstOrDefault()

            mebXRate.Value = Convert.ToDecimal(Query)

            btnSaveMulOrder.Enabled = True
        End If
    End Sub
    Public Sub FetchAllItemNonRM()
        DTItemsNonRM = Zaji.dbSelect("SP_SelectAllItemNonRM")
    End Sub
    Function TJPYLinq()
        Zaji.addParameter("BudRefNum", ddlMajorBud.Text)
        Dim DTTJPY As DataTable = Zaji.dbSelect("SP_GetTJPY")
        Dim QueryTJPY = DTTJPY.AsEnumerable().Sum(Function(r) CType(r("fldEJPY"), Decimal))
        Return Convert.ToString(QueryTJPY)
    End Function
    Public Sub SelectSubBudget()
        Zaji.addParameter("Dept", globalVariables.LoginDept)
        dtSBudRec = Zaji.dbSelect("SP_SelectAllSubBudBydDept")
    End Sub
    Public Sub GetTJPY()
        Dim TJPY As Decimal = TJPYLinq()
        mebTOPRA.Value = TJPY
    End Sub
    Public Sub GetAllSummaryByMBud()
        '------------------------------Get Summary of Marjor Budget---------------------------------
        Zaji.addParameter("MajorRefNum", ddlMajorBud.Text)
        Dim dtSummary As DataTable = Zaji.dbSelect("SP_GetSummaryTotalbyMajor")

        Dim UPO = (From i In dtSummary.AsEnumerable()
                   Select Convert.ToString(i("UPO"))).FirstOrDefault()

        Dim POI = (From i In dtSummary.AsEnumerable()
                   Select Convert.ToString(i("POI"))).FirstOrDefault()
        mebUPO.Value = UPO
        mebPO.Value = POI
    End Sub
    Function GetTotalBudget(ByVal MajorBdget As String)
        Dim TotalBud = dtSBudRec.AsEnumerable() _
        .Where(Function(x) CStr(x("MarjoRefNo")) = MajorBdget) _
        .Sum(Function(x) CType(x("fldYen"), Decimal))
        Return Convert.ToDecimal(TotalBud)
    End Function
    Public Sub GetMajorBudgetByDept()
        Zaji.addParameter("Dept", globalVariables.LoginDept)
        Zaji.addParameter("_Year", DateTime.Today.Year())
        Dim DTMBud As DataTable = Zaji.dbSelect("SP_SelectAllMjrByDept")

        Dim BudQuery = (From x In DTMBud.AsEnumerable()
                        Let _BudTotal = GetTotalBudget(Convert.ToString(x("fldMajorRefNo")))
                        Select New With
                         {
                            .fldMID = x("fldMID"),
                            .fldMajorRefNo = x("fldMajorRefNo"),
                            .fldDesc = x("fldDesc"),
                            .fldJpyAmount = x("fldJpyAmount"),
                            .fldDept = x("fldDept"),
                            .fldYear = x("fldYear"),
                            .fldDateAdded = x("fldDateAdded"),
                            .fldSubRefNo = x("fldSubRefNo"),
                            .fldSubRefDesc = x("fldSubRefDesc"),
                            .fldProject = x("fldProject"),
                            .BudTotal = String.Format("{0:N2}", _BudTotal)
                         }).ToList

        Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REF NO.")
        fldMajorRefNo.FieldName = "fldMajorRefNo"
        fldMajorRefNo.Width = 150
        ddlMajorBud.MultiColumnComboBoxElement.Columns.Add(fldMajorRefNo)

        Dim fldJpyAmount As New GridViewTextBoxColumn("JPY AMOUNT")
        fldJpyAmount.FieldName = "BudTotal"
        fldJpyAmount.Width = 150
        fldJpyAmount.IsVisible = True
        ddlMajorBud.MultiColumnComboBoxElement.Columns.Add(fldJpyAmount)
        ddlMajorBud.MultiColumnComboBoxElement.Columns("BudTotal").FormatString = "{0:N2}"

        Dim fldProject As New GridViewTextBoxColumn("PROJECT")
        fldProject.FieldName = "fldProject"
        fldProject.Width = 150
        ddlMajorBud.MultiColumnComboBoxElement.Columns.Add(fldProject)

        ddlMajorBud.DataSource = Zaji.convertToDatatable(BudQuery)
        ddlMajorBud.DisplayMember = "fldMajorRefNo"
        ddlMajorBud.ValueMember = "fldMajorRefNo"
        ddlMajorBud.MultiColumnComboBoxElement.DropDownWidth = 365

        ddlMajorBud.AutoFilter = True
        ddlMajorBud.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim RefNo As New FilterDescriptor()
        RefNo.PropertyName = "fldMajorRefNo"
        RefNo.Operator = FilterOperator.Contains
        ddlMajorBud.EditorControl.MasterTemplate.FilterDescriptors.Add(RefNo)
    End Sub
    Public Sub GetClass()
        Dim DTClass As DataTable = Zaji.dbSelect("SP_SelectClass")
        ddlClass.DataSource = DTClass
        ddlClass.DisplayMember = "fldClassDesc"
    End Sub
    Public Sub GetProcess()
        Dim DTProc As DataTable = Zaji.dbSelect("SP_SelectProcess")
        ddlProcess.DataSource = DTProc
        ddlProcess.DisplayMember = "fldProcessCode"
    End Sub
    Private Sub ddlDataUOM()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "select distinct T0.BuyUnitMsr from OITM T0 where T0.BuyUnitMsr is not null ORDER BY BuyUnitMsr"

            ddlvalues = myCmd.ExecuteReader
            ddlItemUOM.DataSource = ddlvalues
            ddlItemUOM.DisplayMember = "BuyUnitMsr"

            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnSaveMulOrder_Click(sender As Object, e As EventArgs) Handles btnSaveMulOrder.Click

        If String.IsNullOrEmpty(ddlMajorBud.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please select Major Budget Reference Number.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If

        If ddlStat.Text = "CLOSE" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. Cannot Add Order with CLOSE Status!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlMajorBud.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Major Budget Reference Number Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Currency Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlProcess.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Process Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlClass.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Classification Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf mebAmount.Value <= 0.0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Estimated PR Amount!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlInvestment.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No selected Investment!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtMoldDie.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Mold Die Name!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlInsRequirement.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Inspection requirement!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtRemarks.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Reason(s) for request.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(txtNReason.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Necessary Reason details.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            ' Comment waiting for maam jenny 
        ElseIf String.IsNullOrEmpty(ddlActivity.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Activity", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            ' Comment waiting for maam jenny
        ElseIf String.IsNullOrEmpty(ddlModel.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Model", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf rgvList.RowCount = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. Add Item(s) to Continue", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf RadMessageBox.Show("Are you sure you want to Order this item?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            ' Comment waiting for maam jenny ''-----------------------Change model comma separated values------------------------------
            If Not (ddlModel.Text = "" OrElse ddlModel.Text Is Nothing) Then
                Dim your_String As String = ddlModel.Text
                Dim my_String As String = Regex.Replace(your_String, ";", ",")
                Dim strgroupids As String = my_String.Remove(my_String.Length - 1)
                globalVariables.ModelSearchValue = strgroupids
            End If
            ''------------------------------------------------------------------------------------------


            Dim TransCode, Curr As String

            TransCode = "TC00" + globalVariables.LoginUID + "-" + lblTCID.Text + "-" + txtDept.Text
            Curr = ddlCurrency.Text

            '----------------------------Insert PR Record------------------------------------
            Zaji.addParameter("pryear", dtpMOrder.Value.Year)
            Zaji.addParameter("TC", TransCode)
            Zaji.addParameter("dept", txtDept.Text)
            Zaji.dbAED("PR_Insert")

            '----------------------------Insert Major PR--------------------------------
            Zaji.addParameter("BudRefNum", ddlMajorBud.Text)
            Zaji.addParameter("TransCode", TransCode)
            Zaji.addParameter("MonthOrder", dtpMOrder.Value)
            Zaji.addParameter("OrderDesc", txtDesc.Text)
            Zaji.addParameter("Classification", "Check Classification in PR Items")
            Zaji.addParameter("OrderDepartment", txtDept.Text)
            Zaji.addParameter("_Process", ddlProcess.Text)
            Zaji.addParameter("QTY", txtTQTY.Value)
            Zaji.addParameter("UOM", ddlItemUOM.Text)
            Zaji.addParameter("OrderStatus", ddlStat.Text)
            Zaji.addParameter("OrderRemarks", txtRemarks.Text)
            Zaji.addParameter("Signature", txtSignature.Text)
            Zaji.addParameter("MO", dtpMOrder.Value)
            Zaji.addParameter("DN", dtpDN.Value)
            Zaji.addParameter("EC", ddlCurrency.Text)
            Zaji.addParameter("EOA", mebAmount.Value)
            Zaji.addParameter("EJPY", mebEPA.Value)
            Zaji.addParameter("TOPRA", mebTOPRA.Value)
            Zaji.addParameter("RN", txtRN.Text)
            Zaji.addParameter("Rate", mebXRate.Value)
            Zaji.addParameter("MoldDie", txtMoldDie.Text)
            Zaji.addParameter("NReason", txtNReason.Text)
            Zaji.addParameter("InsRequirements", ddlInsRequirement.Text)
            Zaji.dbAED("SP_InsertOrderv2")
            '----------------------------Insert Major PR ends---------------------------
            '----------------------------Insert PR Items--------------------------------
            For x As Integer = 0 To rgvList.Rows.Count - 1
                Zaji.addParameter("TransCode", TransCode)
                Zaji.addParameter("BudRefNum", ddlMajorBud.Text)
                Zaji.addParameter("ICode", rgvList.Rows(x).Cells("fldItemCode").Value)
                Zaji.addParameter("_Desc", rgvList.Rows(x).Cells("fldDesc").Value)
                Zaji.addParameter("QTY", rgvList.Rows(x).Cells("fldQTY").Value)
                Zaji.addParameter("Unit", rgvList.Rows(x).Cells("fldUnit").Value)
                Zaji.addParameter("Signature", txtSignature.Text)
                Zaji.addParameter("MO", dtpMOrder.Value)
                Zaji.addParameter("Class", rgvList.Rows(x).Cells("fldClass").Value)
                Zaji.addParameter("Dept", txtDept.Text)
                Zaji.addParameter("_Process", ddlProcess.Text)
                Zaji.addParameter("Rate", mebXRate.Value)
                Zaji.addParameter("UnitPrice", rgvList.Rows(x).Cells("fldUPrice").Value)
                Zaji.addParameter("TotalCost", rgvList.Rows(x).Cells("fldTotalCost").Value)
                Zaji.addParameter("SubRefNo", rgvList.Rows(x).Cells("fldSubRefNo").Value)
                Zaji.addParameter("UnitPriceJPY", rgvList.Rows(x).Cells("fldUPriceJPY").Value)
                Zaji.addParameter("TotalCostJPY", rgvList.Rows(x).Cells("fldTotalCostJPY").Value)
                Zaji.addParameter("Peza", rgvList.Rows(x).Cells("fldPeza").Value)
                Zaji.dbAED("SP_InsertMOIv2")
            Next

            '----------------------------Insert PR Items end--------------------------------

            '----------------------------Insert Investment----------------------------------
            If cbInvestment.Checked = False Then
                Zaji.addParameter("BudRefNum", ddlMajorBud.Text)
                Zaji.addParameter("TransCode", TransCode)
                Zaji.addParameter("MonthOrder", dtpMOrder.Value)
                Zaji.addParameter("OrderDesc", txtDesc.Text)
                Zaji.addParameter("Classification", ddlClass.Text)
                Zaji.addParameter("OrderDepartment", txtDept.Text)
                Zaji.addParameter("_Process", ddlProcess.Text)
                Zaji.addParameter("QTY", txtTQTY.Value)
                Zaji.addParameter("UOM", ddlItemUOM.Text)
                Zaji.addParameter("OrderStatus", ddlStat.Text)
                Zaji.addParameter("OrderRemarks", txtRemarks.Text)
                Zaji.addParameter("Signature", txtSignature.Text)
                Zaji.addParameter("MO", dtpMOrder.Value)
                Zaji.addParameter("DN", dtpDN.Value)
                Zaji.addParameter("EC", ddlCurrency.Text)
                Zaji.addParameter("EOA", mebAmount.Value)
                Zaji.addParameter("EJPY", mebEPA.Value)
                Zaji.addParameter("TOPRA", mebTOPRA.Value)
                Zaji.addParameter("RN", txtRN.Text)
                Zaji.addParameter("Rate", mebXRate.Value)
                Zaji.addParameter("MoldDie", txtMoldDie.Text)
                Zaji.addParameter("InvestmentNo", ddlInvestment.Text)
                Zaji.dbAED("SP_InsertInvestmentRecord")
            End If
            '----------------------------Insert Investment end------------------------------
            '-----------------------------Insert Remaining Budget History------------------------------
            Zaji.addParameter("TransCode", TransCode)
            Zaji.addParameter("RemBud", txtRemBudBalance.Value)
            Zaji.addParameter("UPO", mebUPO.Value)
            Zaji.addParameter("PO", mebPO.Value)
            Zaji.addParameter("PRNotPO", mebTOPRA.Value)
            Zaji.addParameter("Budget", txtMBAmount.Value)
            Zaji.dbAED("SP_InsertRemBudHistory")
            '-----------------------------End Insert Remaining Budget History----------------------------------

            'Comment waiting for maam jenny  '----------------------------Insert Activity And model --------------------------------------
            Zaji.addParameter("Activity", ddlActivity.Text)
            Zaji.addParameter("Model", globalVariables.ModelSearchValue)
            Zaji.addParameter("TransCode", TransCode)
            Zaji.dbAED("SP_InsertActivityModelbyPR")
            ''------------------------------End of Insert Activity and Model -------------------------------------


            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            RadMessageBox.Show("This Module will be close automatically. Please reopen theis Module to Create PR again Thank you", "Notification", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub
    Public Sub LoadSelectItem()
        Dim fldItemCodeColumn As New GridViewTextBoxColumn("ITEM_CODE") With {
            .FieldName = "ItemCode",
            .Width = 100
        }
        ddlSelectItem.MultiColumnComboBoxElement.Columns.Add(fldItemCodeColumn)

        Dim ItemName As New GridViewTextBoxColumn("ITEM_NAME") With {
            .FieldName = "ItemName",
            .Width = 300
        }
        ddlSelectItem.MultiColumnComboBoxElement.Columns.Add(ItemName)

        Dim Category As New GridViewTextBoxColumn("CATEGORY") With {
            .FieldName = "Category",
            .Width = 150,
            .IsVisible = False
        }
        ddlSelectItem.MultiColumnComboBoxElement.Columns.Add(Category)

        Dim fldItemUOMColumn As New GridViewTextBoxColumn("UNIT") With {
            .FieldName = "BuyUnitMsr",
            .Width = 150,
            .IsVisible = False
        }
        ddlSelectItem.MultiColumnComboBoxElement.Columns.Add(fldItemUOMColumn)

        'GetItemCodeSapForPR()

        ddlSelectItem.DataSource = dtItemCode
        ddlSelectItem.ValueMember = "ItemCode"
        ddlSelectItem.DisplayMember = "ItemCode"
        ddlSelectItem.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlSelectItem.AutoFilter = True
        ddlSelectItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim ICode As New FilterDescriptor("ItemCode", FilterOperator.Contains, "")


        compositeFilter.FilterDescriptors.Add(ICode)


        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        ddlSelectItem.EditorControl.FilterDescriptors.Add(compositeFilter)
        ddlSelectItem.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Public Sub LoadSelectItemNew()
        Dim fldItemCodeColumn As New GridViewTextBoxColumn("ITEM_CODE")
        fldItemCodeColumn.FieldName = "fldItemNo"
        fldItemCodeColumn.Width = 100
        ddlSelectItem.MultiColumnComboBoxElement.Columns.Add(fldItemCodeColumn)

        Dim ItemName As New GridViewTextBoxColumn("ITEM_NAME")
        ItemName.FieldName = "fldDesc"
        ItemName.Width = 300
        ddlSelectItem.MultiColumnComboBoxElement.Columns.Add(ItemName)

        ddlSelectItem.DataSource = DTItemsNonRM
        ddlSelectItem.ValueMember = "fldItemNo"
        ddlSelectItem.DisplayMember = "fldItemNo"
        ddlSelectItem.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlSelectItem.AutoFilter = True
        ddlSelectItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim ICode As New FilterDescriptor("fldItemNo", FilterOperator.Contains, "")

        compositeFilter.FilterDescriptors.Add(ICode)

        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        ddlSelectItem.EditorControl.FilterDescriptors.Add(compositeFilter)
        ddlSelectItem.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub
    Public Sub LoadSelectItemByItemName()
        Dim fldItemCodeColumn As New GridViewTextBoxColumn("ITEM_CODE")
        fldItemCodeColumn.FieldName = "ItemCode"
        fldItemCodeColumn.Width = 100
        ddlItemCodeDesc.MultiColumnComboBoxElement.Columns.Add(fldItemCodeColumn)

        Dim ItemName As New GridViewTextBoxColumn("ITEM_NAME")
        ItemName.FieldName = "ItemName"
        ItemName.Width = 300
        ddlItemCodeDesc.MultiColumnComboBoxElement.Columns.Add(ItemName)

        Dim Category As New GridViewTextBoxColumn("CATEGORY")
        Category.FieldName = "Category"
        Category.Width = 150
        Category.IsVisible = False
        ddlItemCodeDesc.MultiColumnComboBoxElement.Columns.Add(Category)

        Dim fldItemUOMColumn As New GridViewTextBoxColumn("UNIT")
        fldItemUOMColumn.FieldName = "BuyUnitMsr"
        fldItemUOMColumn.Width = 150
        fldItemUOMColumn.IsVisible = False
        ddlItemCodeDesc.MultiColumnComboBoxElement.Columns.Add(fldItemUOMColumn)

        '  GetItemCodeSapForPRItemName()
        ddlItemCodeDesc.DataSource = dtItemCode
        ddlItemCodeDesc.ValueMember = "ItemName"
        ddlItemCodeDesc.DisplayMember = "ItemName"
        ddlItemCodeDesc.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlItemCodeDesc.AutoFilter = True
        ddlItemCodeDesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim IName As New FilterDescriptor("ItemName", FilterOperator.Contains, "")

        compositeFilter.FilterDescriptors.Add(IName)

        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        ddlItemCodeDesc.EditorControl.FilterDescriptors.Add(compositeFilter)
        ddlItemCodeDesc.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub
    Public Sub LoadSelectItemByItemNameNew()
        Dim fldItemCodeColumn As New GridViewTextBoxColumn("ITEM_CODE")
        fldItemCodeColumn.FieldName = "fldItemNo"
        fldItemCodeColumn.Width = 100
        ddlItemCodeDesc.MultiColumnComboBoxElement.Columns.Add(fldItemCodeColumn)

        Dim ItemName As New GridViewTextBoxColumn("ITEM_NAME")
        ItemName.FieldName = "fldDesc"
        ItemName.Width = 300
        ddlItemCodeDesc.MultiColumnComboBoxElement.Columns.Add(ItemName)

        ddlItemCodeDesc.DataSource = DTItemsNonRM
        ddlItemCodeDesc.ValueMember = "fldDesc"
        ddlItemCodeDesc.DisplayMember = "fldDesc"
        ddlItemCodeDesc.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlItemCodeDesc.AutoFilter = True
        ddlItemCodeDesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim IName As New FilterDescriptor("fldDesc", FilterOperator.Contains, "")

        compositeFilter.FilterDescriptors.Add(IName)

        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        ddlItemCodeDesc.EditorControl.FilterDescriptors.Add(compositeFilter)
        ddlItemCodeDesc.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub

    Public Sub LoadDataBudRef()
        Zaji.addParameter("RefNo", ddlMajorBud.Text)
        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectSubBudByMRefNo")
        ddlSubRef.DataSource = DTSBud
        ddlSubRef.ValueMember = "fldBudRefNum"
        ddlSubRef.DisplayMember = "fldBudRefNum"
    End Sub
    Public Sub GetDesc()
        Zaji.addParameter("MajorRefNo", ddlMajorBud.Text)
        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectBudgetByMajorRefNo")
        If DTSBud.Rows.Count > 0 Then
            txtDesc.Text = Convert.ToString(DTSBud.Rows(0).Item("fldDesc"))
        End If
    End Sub

    Public Sub LoadBudRef()

        Dim fldBudRefNum As New GridViewTextBoxColumn("BUDGET REFERENCE NO")
        fldBudRefNum.FieldName = "fldBudRefNum"
        fldBudRefNum.Width = 150
        ddlSubRef.MultiColumnComboBoxElement.Columns.Add(fldBudRefNum)

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        fldDesc.FieldName = "fldDesc"
        fldDesc.Width = 250
        ddlSubRef.MultiColumnComboBoxElement.Columns.Add(fldDesc)

        Dim fldClass As New GridViewTextBoxColumn("CLASSIFICATION")
        fldClass.FieldName = "fldClass"
        fldClass.Width = 150
        ddlSubRef.MultiColumnComboBoxElement.Columns.Add(fldClass)

        ddlSubRef.AutoFilter = True
        ddlSubRef.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Dim compositeFilter As New CompositeFilterDescriptor
        Dim SubBud As New FilterDescriptor("fldBudRefNum", FilterOperator.Contains, "")
        Dim Desc As New FilterDescriptor("fldDesc", FilterOperator.Contains, "")
        Dim _Class As New FilterDescriptor("fldClass", FilterOperator.Contains, "")

        compositeFilter.FilterDescriptors.Add(SubBud)
        compositeFilter.FilterDescriptors.Add(Desc)
        compositeFilter.FilterDescriptors.Add(_Class)

        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        ddlInvestment.EditorControl.FilterDescriptors.Add(compositeFilter)
        ddlInvestment.MultiColumnComboBoxElement.DropDownWidth = 730

    End Sub
    Private Sub cbInvestment_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles cbInvestment.ToggleStateChanged
        If cbInvestment.Checked = True Then
            ddlInvestment.Enabled = False
            ddlInvestment.Text = "N/A"
            txtInvestmentAppBud.Enabled = False
            txtInvestmentAppBud.Value = 0
            txtInvBudBalance.Value = 0
            txtInvBudBalance.Enabled = False
        ElseIf cbInvestment.Checked = False Then
            ddlInvestment.Enabled = True
            txtInvestmentAppBud.Enabled = True
            ddlInvestment.Text = ""
            txtInvestmentAppBud.Value = 0
            txtInvBudBalance.Value = 0
            txtInvBudBalance.Enabled = True
        End If
    End Sub

    Private Sub CBNA_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles CBNA.ToggleStateChanged
        If CBNA.Checked = True Then
            txtMoldDie.Enabled = False
            txtMoldDie.Text = "N/A"
        Else
            txtMoldDie.Enabled = True
            txtMoldDie.Text = ""
        End If
    End Sub

    Public Sub LoadInvestment()
        RemoveHandler ddlInvestment.SelectedIndexChanged, AddressOf ddlInvestment_SelectedIndexChanged
        ddlInvestment.SelectedIndex = -1

        Dim fldItemCodeColumn As New GridViewTextBoxColumn("INVESTMENT NO")
        fldItemCodeColumn.FieldName = "fldInvestmentNo"
        fldItemCodeColumn.Width = 100
        fldItemCodeColumn.IsVisible = True
        ddlInvestment.MultiColumnComboBoxElement.Columns.Add(fldItemCodeColumn)

        Dim ItemName As New GridViewTextBoxColumn("APPROVED BUDGET")
        ItemName.FieldName = "fldProdCostJPY"
        ItemName.Width = 150
        ItemName.IsVisible = True
        ddlInvestment.MultiColumnComboBoxElement.Columns.Add(ItemName)
        ddlInvestment.Columns("fldProdCostJPY").FormatString = "{0:N2}"

        Dim Category As New GridViewTextBoxColumn("PR AMOUNT")
        Category.FieldName = "PRAmount"
        Category.Width = 110
        Category.IsVisible = True
        ddlInvestment.MultiColumnComboBoxElement.Columns.Add(Category)
        ddlInvestment.Columns("PRAmount").FormatString = "{0:N2}"

        dtLoadData2 = Chinita.fetchDBTable("call SP_SelectInvestmentGood()")
        ddlInvestment.DataSource = dtLoadData2
        ddlInvestment.DisplayMember = "fldInvestmentNo"

        ddlSelectItem.AutoFilter = True
        ddlSelectItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim InvestmentNo As New FilterDescriptor("fldInvestmentNo", FilterOperator.Contains, "")

        compositeFilter.FilterDescriptors.Add(InvestmentNo)

        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        ddlInvestment.EditorControl.FilterDescriptors.Add(compositeFilter)
        ddlInvestment.MultiColumnComboBoxElement.DropDownWidth = 450
        ddlInvestment.Text = ""


        AddHandler ddlInvestment.SelectedIndexChanged, AddressOf ddlInvestment_SelectedIndexChanged
        'txtInvestmentAppBud.Value = 0
        'txtInvBudBalance.Value = 0

    End Sub

    Private Sub ddlInvestment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlInvestment.SelectedIndexChanged
        'Try
        '    Dim PRAmount As Decimal = ddlInvestment.EditorControl.CurrentRow.Cells("PR AMOUNT").Value.ToString
        '    Dim InvAppBud As Decimal = ddlInvestment.EditorControl.CurrentRow.Cells("APPROVED BUDGET").Value.ToString

        '    txtInvestmentAppBud.Value = ddlInvestment.EditorControl.CurrentRow.Cells("APPROVED BUDGET").Value.ToString
        '    txtInvBudBalance.Value = Convert.ToString(InvAppBud - PRAmount)
        'Catch ex As Exception

        'End Try

        Try
            Dim selectedRow As GridViewDataRowInfo = CType(ddlInvestment.SelectedItem, GridViewDataRowInfo)

            Dim PRAmount As Decimal = selectedRow.Cells("PRAmount").Value.ToString()
            Dim InvAppBud As Decimal = selectedRow.Cells("fldProdCostJPY").Value.ToString()

            txtInvestmentAppBud.Value = InvAppBud
            txtInvBudBalance.Value = Convert.ToString(InvAppBud - PRAmount)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyGrid()

        Dim fldNumberColumn As New GridViewTextBoxColumn("NO")
        With fldNumberColumn
            .FieldName = "Number"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
            .IsPinned = Right
        End With
        rgvList.Columns.Add(fldNumberColumn)

        Dim fldBudRefNumColumn As New GridViewTextBoxColumn("SUB REFERENCE NO.")
        With fldBudRefNumColumn
            .FieldName = "fldSubRefNo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvList.Columns.Add(fldBudRefNumColumn)

        Dim fldICColumn As New GridViewTextBoxColumn("ITEM_CODE")
        With fldICColumn
            .FieldName = "fldItemCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 200
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldICColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 300
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldQTYColumn)
        rgvList.Columns("fldQTY").FormatString = "{0:N2}"

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldUNITColumn As New GridViewTextBoxColumn("UNIT")
        With fldUNITColumn
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldUNITColumn)

        Dim fldUPColumn As New GridViewDecimalColumn("UNIT_PRICE")
        With fldUPColumn
            .FieldName = "fldUPrice"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldUPColumn)
        rgvList.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldTotalCost As New GridViewDecimalColumn("TOTAL_COST")
        With fldTotalCost
            .FieldName = "fldTotalCost"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldTotalCost)
        rgvList.Columns("fldTotalCost").FormatString = "{0:N2}"

        Dim fldUPJPYColumn As New GridViewTextBoxColumn("UNIT_PRICE JPY")
        With fldUPJPYColumn
            .FieldName = "fldUPriceJPY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldUPJPYColumn)
        rgvList.Columns("fldUPriceJPY").FormatString = "{0:N2}"

        Dim fldTotalCostJPY As New GridViewDecimalColumn("TOTAL_COST JPY")
        With fldTotalCostJPY
            .FieldName = "fldTotalCostJPY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldTotalCostJPY)
        rgvList.Columns("fldTotalCostJPY").FormatString = "{0:N2}"

        Dim fldPeza As New GridViewTextBoxColumn("PEZA")
        With fldPeza
            .FieldName = "fldPeza"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldPeza)

        Dim fldDeleteColumn As New GridViewCommandColumn("REMOVE")
        With fldDeleteColumn
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 60
            .UseDefaultText = True
            .DefaultText = "REMOVE"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With

        With rgvList
            .EnableAlternatingRowColor = True
            .ShowGroupPanel = True
            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

        AddHandler rgvList.CommandCellClick, AddressOf CloseItem
        rgvList.Columns.Add(fldDeleteColumn)
    End Sub
    Private Sub CloseItem()
        If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to remove this Item?",
                                          "Remove Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim i = rgvList.CurrentCell.RowIndex
            If rgvList.CurrentColumn.HeaderText = "REMOVE" Then
                rgvList.Rows.RemoveAt(i)
            End If
        End If
    End Sub


    Private Sub ddlSelectItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSelectItem.SelectedIndexChanged
        Try

            'Comment due to SAP Problem
            txtItemCode.Text = Convert.ToString(ddlSelectItem.EditorControl.CurrentRow.Cells("ItemCode").Value)
            txtCategory.Text = Convert.ToString(ddlSelectItem.EditorControl.CurrentRow.Cells("Category").Value)
            txtIMDesc.Text = Convert.ToString(ddlSelectItem.EditorControl.CurrentRow.Cells("ItemName").Value)
            ddlItemUOM.Text = Convert.ToString(ddlSelectItem.EditorControl.CurrentRow.Cells("BuyUnitMsr").Value)
            '  ddlItemCodeDesc.Text = ""
            '---------------------------------------
            'New Code replace SAP
            'txtItemCode.Text = Convert.ToString(ddlSelectItem.EditorControl.CurrentRow.Cells("fldItemNo").Value)
            'txtIMDesc.Text = Convert.ToString(ddlSelectItem.EditorControl.CurrentRow.Cells("fldDesc").Value)
            'ddlItemCodeDesc.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtItemCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlSubRef.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Sub Reference Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            'ElseIf String.IsNullOrEmpty(txtCategory.Text) Then
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("No Item Category Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtIMDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Description Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlItemUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Unit of Measurement Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf txtQTY.Value = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Quantity", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf txtUnitPrice.Text = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Zero unit price is not allowed", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please select Currency First!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf txtUniPriceJPY.Text = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Zero unit price is not allowed", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlPeza.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please classify if Directly used in PEZA registered Activity or not before proceeding!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else

            Dim count As Integer = rgvList.Rows.Count
            Dim row As Integer

            If count >= 10 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("10 Items only per Purchased Requisition", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                Dim Total As Decimal = Convert.ToDecimal(txtQTY.Text) * Convert.ToDecimal(txtUnitPrice.Text)
                Dim TotalJPY As Decimal = Convert.ToDecimal(txtQTY.Text) * Convert.ToDecimal(txtUniPriceJPY.Text)

                rgvList.Rows.Add(row, ddlSubRef.Text, txtItemCode.Text, txtIMDesc.Text, txtQTY.Text, ddlClass.Text, ddlItemUOM.Text,
                                          txtUnitPrice.Value, Total, txtUniPriceJPY.Value, TotalJPY, ddlPeza.Text)

                ddlCurrency.Enabled = False
                ddlMajorBud.Enabled = False
            End If

        End If
    End Sub

    Private Sub rgvList_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgvList.CellFormatting
        If e.CellElement.ColumnInfo.HeaderText = "NO" Then
            e.CellElement.Text = e.CellElement.RowIndex.ToString + 1
        End If
    End Sub

    Private Sub rgvList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.RowsChanged
        Dim TCost, QTY As Decimal
        For x As Integer = 0 To rgvList.Rows.Count - 1
            TCost = TCost + rgvList.Rows(x).Cells("fldTotalCost").Value
            QTY = QTY + rgvList.Rows(x).Cells("fldQTY").Value
        Next
        mebAmount.Value = TCost
        txtTQTY.Value = QTY

        If rgvList.Rows.Count = 0 Then
            ddlCurrency.Enabled = True
        Else
            ddlCurrency.Enabled = False
        End If
    End Sub

    Private Sub mebAmount_TextChanged(sender As Object, e As EventArgs) Handles mebAmount.TextChanged
        CurrencyRate()
    End Sub
    Private Sub CurrencyRate()

        Try
            If ddlCurrency.Text = "JPY" Then
                mebEPA.Value = mebAmount.Value
                txtUniPriceJPY.Value = txtUnitPrice.Value
            Else
                mebEPA.Value = mebAmount.Value * mebXRate.Value
                txtUniPriceJPY.Value = txtUnitPrice.Value * mebXRate.Value
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        ' GetRate()
        GetRateToday(ddlCurrency.Text)

        ' GetRateBAP()
        CurrencyRate()
        ComputeRemBud()
    End Sub
    Public Sub GetRateBAP()
        If ddlCurrency.Text = "JPY" Or String.IsNullOrEmpty(ddlCurrency.Text) Then
            mebXRate.Value = 0.000000
        Else
            Try

                Zaji.addParameter("Currency", ddlCurrency.Text)
                Zaji.addParameter("_Date", dtpMOrder.Value.Date)
                Dim DTCheck As DataTable = Zaji.dbSelect("SP_CheckRate")

                mebXRate.Value = DTCheck.Rows(0).Item("fldRate").ToString()
                btnSaveMulOrder.Enabled = True

            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Selected Date has No Convertion Rate," & Environment.NewLine &
                                      "Please Contact MIS Mark @ Local 606", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                ddlCurrency.Text = vbNullString
                btnSaveMulOrder.Enabled = False
                dtpMOrder.Focus()
            End Try

        End If

    End Sub
    Private Sub GetRate()

        If ddlCurrency.Text = "JPY" Or String.IsNullOrEmpty(ddlCurrency.Text) Then
            mebXRate.Text = 0.0
        Else
            Try
                Dim conn As New SqlClient.SqlConnection(Sapsap)
                Dim myCmd As New SqlClient.SqlCommand
                Dim myData As New DataTable
                Dim myData2 As New DataTable
                Dim myAdapter As New SqlClient.SqlDataAdapter

                myCmd.Connection = conn
                myCmd.CommandText = "select Currency, Rate from ORTT where RateDate = '" & dtpMOrder.Value.Date & "' and Currency = '" & ddlCurrency.Text & "'"

                myAdapter.SelectCommand = myCmd
                myAdapter.Fill(myData)

                mebXRate.Value = myData.Rows(0).Item("Rate")

                btnSaveMulOrder.Enabled = True

            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Selected Date has No Convertion Rate," & Environment.NewLine &
                                      "Please Contact Edgar Comia @ Local 102", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                ddlCurrency.Text = vbNullString
                btnSaveMulOrder.Enabled = False
                dtpMOrder.Focus()
            End Try

        End If

    End Sub


    Private Sub ClearField()
        ddlMajorBud.Text = ""
        ddlProcess.Text = ""
        ddlClass.Text = ""
        ddlSelectItem.Text = ""
        ddlItemCodeDesc.Text = ""
        txtItemCode.Text = ""
        txtCategory.Text = ""
        txtIMDesc.Text = ""
    End Sub

    Private Sub ddlMajorBud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlMajorBud.SelectedIndexChanged
        LoadDataBudRef()
        GetTJPY()
        GetDesc()
        GetAllSummaryByMBud()
        Try
            Dim selectedRow As GridViewDataRowInfo = CType(ddlMajorBud.SelectedItem, GridViewDataRowInfo)
            txtMBAmount.Value = selectedRow.Cells("BudTotal").Value.ToString()

            If selectedRow.Cells("fldProject").Value.ToString() = "PROJECT" Then
                cbInvestment.Enabled = False
                cbInvestment.Checked = False
            Else
                cbInvestment.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GenTCNo()
        Dim DTProc As DataTable = Zaji.dbSelect("SP_SelectTCID")
        lblTCID.Text = DTProc.Rows(0).Item("ID").ToString
    End Sub
    Public Sub ComputeRemBud()
        txtRemBudBalance.Value = txtMBAmount.Value - (mebTOPRA.Value + mebEPA.Value + mebUPO.Value + mebPO.Value)
    End Sub

    Private Sub txtMBAmount_ValueChanged(sender As Object, e As EventArgs) Handles txtMBAmount.ValueChanged
        ComputeRemBud()
    End Sub



    Private Sub txtRemBudBalance_ValueChanged(sender As Object, e As EventArgs) Handles txtRemBudBalance.ValueChanged
        If txtRemBudBalance.Value < 0 Then
            txtRemBudBalance.BackColor = Color.Red

        End If
    End Sub

    Private Sub mebEPA_ValueChanging(sender As Object, e As ValueChangingEventArgs) Handles mebEPA.ValueChanging
        ComputeRemBud()
    End Sub

    Private Sub mebEPA_ValueChanged(sender As Object, e As EventArgs) Handles mebEPA.ValueChanged
        ComputeRemBud()
    End Sub

    Private Sub txtUnitPrice_ValueChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.ValueChanged
        'GetRate()
        GetRateToday(ddlCurrency.Text)

        ' GetRateBAP()
        CurrencyRate()
        ComputeRemBud()
    End Sub

    Private Sub ddlSubRef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSubRef.SelectedIndexChanged
        'Try
        '    Dim selectedRow As GridViewDataRowInfo = CType(ddlSubRef.SelectedItem, GridViewDataRowInfo)

        '    ddlSubRef.Text = selectedRow.Cells("fldBudRefNum").Value.ToString()
        '    ddlClass.Text = selectedRow.Cells("fldClass").Value.ToString()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ddlItemCodeDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlItemCodeDesc.SelectedIndexChanged
        Try
            'Comment Due to SAP Problem
            txtItemCode.Text = Convert.ToString(ddlItemCodeDesc.EditorControl.CurrentRow.Cells("ItemCode").Value)
            txtCategory.Text = Convert.ToString(ddlItemCodeDesc.EditorControl.CurrentRow.Cells("Category").Value)
            txtIMDesc.Text = Convert.ToString(ddlItemCodeDesc.EditorControl.CurrentRow.Cells("ItemName").Value)
            ddlItemUOM.Text = Convert.ToString(ddlItemCodeDesc.EditorControl.CurrentRow.Cells("BuyUnitMsr").Value)
            ' ddlSelectItem.Text = ""
            '---------------------------------------
            'New Code replace SAP
            'txtItemCode.Text = Convert.ToString(ddlItemCodeDesc.EditorControl.CurrentRow.Cells("fldItemNo").Value)
            'txtIMDesc.Text = Convert.ToString(ddlItemCodeDesc.EditorControl.CurrentRow.Cells("fldDesc").Value)
            'ddlItemCodeDesc.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpMOrder_ValueChanged(sender As Object, e As EventArgs) Handles dtpMOrder.ValueChanged

    End Sub

    Private Sub ddlActivity_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlActivity.SelectedIndexChanged
        Dim Activity As String = ddlActivity.Text
        Dim Query = (From i In DTModelList.AsEnumerable()
                     Where i("fldActivity") = Activity
                     Select i("fldModel")).ToList
        ddlModel.DataSource = Query
        ddlModel.DisplayMember = "fldModel"
    End Sub

    Private Sub cbModelNA_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbModelNA.ToggleStateChanged
        If cbModelNA.Checked = True Then
            ddlModel.Enabled = False
            ddlModel.Text = "N/A "
        Else
            ddlModel.Enabled = True
            ddlModel.Text = ""
        End If
    End Sub


    Private Sub imgPeza_Click(sender As Object, e As EventArgs) Handles imgPeza.Click
        If Zaji.IsFormOpen(FrmPezaInfo) Then
            FrmPezaInfo.Focus()
        Else
            FrmPezaInfo.Show()
        End If
    End Sub

    Private Sub rgvList_Click(sender As Object, e As EventArgs) Handles rgvList.Click

    End Sub
End Class
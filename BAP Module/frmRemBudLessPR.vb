Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Imports System.Data.SqlClient
Public Class FrmRemBudLessPR
    Private dtSBudRec As DataTable
    Private Sub FrmRemBudLessPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RFQItems()
        SelectSubBudget()
        GetMajorBudgetByDept()
        RadGridUPO()
        RadGridPO()
        RadGridOpenPR()
    End Sub
    'Public Sub RFQItems()
    '    '---------------------------------------------------------------------
    '    Dim fldBudRefNum As New GridViewTextBoxColumn("RFQ No")
    '    fldBudRefNum.FieldName = "fldBudRefNum"
    '    fldBudRefNum.Width = 200
    '    ddlBRNum.MultiColumnComboBoxElement.Columns.Add(fldBudRefNum)

    '    Dim fldYen As New GridViewDecimalColumn("JPY AMOUNT")
    '    fldYen.FieldName = "fldYen"
    '    fldYen.Width = 120                             
    '    ddlBRNum.Columns.Add(fldYen)
    '    ddlBRNum.Columns("fldYen").FormatString = "{0:N2}"

    '    ddlBRNum.AutoFilter = True
    '    ddlBRNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    '    Zaji.addParameter("Dept", frmMain.lblDept.Text)
    '    Zaji.addParameter("_Year", Convert.ToString(DateTime.Now.Year))
    '    Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectBudRefByDept")
    '    ddlBRNum.DataSource = dtRFQRec

    '    Dim BudRefNum As New FilterDescriptor()
    '    BudRefNum.PropertyName = "fldBudRefNum"
    '    BudRefNum.Operator = FilterOperator.Contains
    '    ddlBRNum.EditorControl.MasterTemplate.FilterDescriptors.Add(BudRefNum)
    '    ddlBRNum.Text = ""

    'End Sub
    Public Sub SelectSubBudget()
        Zaji.addParameter("Dept", globalVariables.LoginDept)
        dtSBudRec = Zaji.dbSelect("SP_SelectAllSubBudBydDept")
    End Sub
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
                            .BudTotal = String.Format("{0:N2}", _BudTotal)
                         }).ToList

        Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REF NO.")
        fldMajorRefNo.FieldName = "fldMajorRefNo"
        fldMajorRefNo.Width = 150
        fldMajorRefNo.TextAlignment = ContentAlignment.MiddleCenter
        ddlMajorBud.MultiColumnComboBoxElement.Columns.Add(fldMajorRefNo)

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        fldDesc.FieldName = "fldDesc"
        fldDesc.Width = 250
        fldDesc.TextAlignment = ContentAlignment.MiddleCenter
        ddlMajorBud.MultiColumnComboBoxElement.Columns.Add(fldDesc)


        Dim fldJpyAmount As New GridViewTextBoxColumn("JPY AMOUNT")
        fldJpyAmount.FieldName = "BudTotal"
        fldJpyAmount.Width = 150
        fldJpyAmount.IsVisible = True
        fldJpyAmount.TextAlignment = ContentAlignment.MiddleCenter
        ddlMajorBud.MultiColumnComboBoxElement.Columns.Add(fldJpyAmount)
        ddlMajorBud.MultiColumnComboBoxElement.Columns("BudTotal").FormatString = "{0:N2}"

        ddlMajorBud.DataSource = Zaji.convertToDatatable(BudQuery)
        ddlMajorBud.DisplayMember = "fldMajorRefNo"
        ddlMajorBud.ValueMember = "fldMajorRefNo"
        ddlMajorBud.MultiColumnComboBoxElement.DropDownWidth = 600

        ddlMajorBud.AutoFilter = True
        ddlMajorBud.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Dim RefNo As New FilterDescriptor()
        RefNo.PropertyName = "fldMajorRefNo"
        RefNo.Operator = FilterOperator.Contains
        ddlMajorBud.EditorControl.MasterTemplate.FilterDescriptors.Add(RefNo)
    End Sub
    Function GetTotalBudget(ByVal MajorBdget As String)
        Dim TotalBud = dtSBudRec.AsEnumerable() _
        .Where(Function(x) CStr(x("MarjoRefNo")) = MajorBdget) _
        .Sum(Function(x) CType(x("fldYen"), Decimal))
        Return Convert.ToDecimal(TotalBud)
    End Function
    Public Sub getRecords()
        Zaji.addParameter("BudRefNum", Convert.ToString(ddlMajorBud.Text))
        Dim dtUPORec As DataTable = Zaji.dbSelect("SP_SelectAllUPOByBudRef")
        rgvUPO.DataSource = dtUPORec

        Zaji.addParameter("BudRefNum", Convert.ToString(ddlMajorBud.Text))
        Dim dtPOIRec As DataTable = Zaji.dbSelect("SP_SelectAllPOIByBudRef")
        rgbPO.DataSource = dtPOIRec

        Zaji.addParameter("BudRefNum", Convert.ToString(ddlMajorBud.Text))
        Dim dtOPRRec As DataTable = Zaji.dbSelect("SP_SelectOpenPRByBudRef")
        rgbOpenPR.DataSource = dtOPRRec

        Dim bud As Decimal = txtBudget.Value
        Dim UPO As Decimal = txtUPO.Value
        Dim PO As Decimal = txtPO.Value
        Dim OPO As Decimal = txtOPR.Value

        txtRemBud.Text = Convert.ToString(bud - (UPO + PO + OPO))
    End Sub

    Private Sub FrmRemBudLessPR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        getRecords()

    End Sub
    Public Sub RadGridUPO()

        Dim fldPartName As New GridViewTextBoxColumn("SUPPLIER")
        fldPartName.FieldName = "fldSupplier"
        fldPartName.Width = 200
        rgvUPO.Columns.Add(fldPartName)

        Dim fldJPY As New GridViewDecimalColumn("JPY AMOUNT")
        fldJPY.FieldName = "fldJPY"
        fldJPY.Width = 120
        rgvUPO.Columns.Add(fldJPY)
        rgvUPO.Columns("fldJPY").FormatString = "{0:N2}"

        Dim UDate As New GridViewDateTimeColumn("UPLOADED DATE")
        UDate.FieldName = "fldUDate"
        UDate.Width = 170
        UDate.Format = DateTimePickerFormat.Custom
        UDate.CustomFormat = "MMM dd, yyyy HH:mm"
        rgvUPO.Columns.Add(UDate)
        rgvUPO.Columns("fldUDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldJPYSum As New GridViewSummaryItem("fldJPY", "{0:N2}", GridAggregateFunction.Sum)
        Dim summaryRowItem As New GridViewSummaryRowItem
        summaryRowItem.Add(fldJPYSum)
        rgvUPO.SummaryRowsTop.Add(summaryRowItem)

    End Sub
    Public Sub RadGridOpenPR()
        Dim fldPartName As New GridViewTextBoxColumn("PR NO")
        fldPartName.FieldName = "fldPRNo"
        fldPartName.Width = 150
        rgbOpenPR.Columns.Add(fldPartName)

        Dim fldJPY As New GridViewDecimalColumn("JPY AMOUNT")
        fldJPY.FieldName = "fldEJPY"
        fldJPY.Width = 120
        rgbOpenPR.Columns.Add(fldJPY)
        rgbOpenPR.Columns("fldEJPY").FormatString = "{0:N2}"

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        fldDesc.FieldName = "fldOrderDesc"
        fldDesc.Width = 200
        rgbOpenPR.Columns.Add(fldDesc)

        Dim fldJPYSum As New GridViewSummaryItem("fldEJPY", "{0:N2}", GridAggregateFunction.Sum)
        Dim summaryRowItem As New GridViewSummaryRowItem
        summaryRowItem.Add(fldJPYSum)
        rgbOpenPR.SummaryRowsTop.Add(summaryRowItem)

    End Sub
    Public Sub RadGridPO()

        Dim fldPartName As New GridViewTextBoxColumn("PR NO")
        fldPartName.FieldName = "fldPRNo"
        fldPartName.Width = 150
        rgbPO.Columns.Add(fldPartName)

        Dim fldJPY As New GridViewDecimalColumn("JPY AMOUNT")
        fldJPY.FieldName = "fldYenSap"
        fldJPY.Width = 120
        rgbPO.Columns.Add(fldJPY)
        rgbPO.Columns("fldYenSap").FormatString = "{0:N2}"

        Dim fldICode As New GridViewTextBoxColumn("ITEM CODE")
        fldICode.FieldName = "fldICode"
        fldICode.Width = 150
        rgbPO.Columns.Add(fldICode)

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        fldDesc.FieldName = "fldDesc"
        fldDesc.Width = 200
        rgbPO.Columns.Add(fldDesc)

        Dim fldJPYSum As New GridViewSummaryItem("fldYenSap", "{0:N2}", GridAggregateFunction.Sum)
        Dim summaryRowItem As New GridViewSummaryRowItem
        summaryRowItem.Add(fldJPYSum)
        rgbPO.SummaryRowsTop.Add(summaryRowItem)

    End Sub

    Private Sub rgvUPO_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgvUPO.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)
        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub

    Private Sub rgbPO_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgbPO.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)
        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub

    Private Sub rgbOpenPR_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgbOpenPR.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)
        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub

    Private Sub rgvUPO_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs) Handles rgvUPO.GroupSummaryEvaluate
        txtUPO.Text = e.Value
    End Sub

    Private Sub rgbPO_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs) Handles rgbPO.GroupSummaryEvaluate
        txtPO.Text = e.Value
    End Sub

    Private Sub rgbOpenPR_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs) Handles rgbOpenPR.GroupSummaryEvaluate
        txtOPR.Text = e.Value
    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Try
        '    Dim selectedRow As GridViewDataRowInfo = CType(ddlBRNum.SelectedItem, GridViewDataRowInfo)
        '    txtBudget.Text = selectedRow.Cells("fldYen").Value.ToString()
        'Catch ex As Exception
        '    txtBudget.Text = "0.00"
        'End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            reporttype = 12
            globalVariables.BudRefNo = ddlMajorBud.Text
            FrmReportServer.Show()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub ddlMajorBud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlMajorBud.SelectedIndexChanged
        Try
            Dim selectedRow As GridViewDataRowInfo = CType(ddlMajorBud.SelectedItem, GridViewDataRowInfo)
            txtBudget.Text = selectedRow.Cells("BudTotal").Value.ToString()
        Catch ex As Exception
            txtBudget.Text = "0.00"
        End Try
    End Sub
End Class

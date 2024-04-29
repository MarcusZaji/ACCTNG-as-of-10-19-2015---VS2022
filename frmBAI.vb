Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class frmBAI

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet

    Private Sub frmBAI_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        ReadyGrid()
        'ReadyGridListItem()

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub ReadyGrid()

        Dim fldOrderIDColumn As New GridViewTextBoxColumn("ID")
        With fldOrderIDColumn
            .FieldName = "U_Detail_ID"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldOrderIDColumn)

        Dim fldTransCodeColumn As New GridViewTextBoxColumn("TransCode")
        With fldTransCodeColumn
            .FieldName = "fldTransCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldTransCodeColumn)

        Dim fldPONoColumn As New GridViewTextBoxColumn("PO NUMBER")
        With fldPONoColumn
            .FieldName = "Purch-Ord"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPONoColumn)

        Dim fldPRNoColumn As New GridViewTextBoxColumn("PR NUMBER")
        With fldPRNoColumn
            .FieldName = "PRNO"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPRNoColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldICodeColumn
            .FieldName = "Product"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldICodeColumn)

        Dim fldOrderDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldOrderDescColumn
            .FieldName = "fldDesc"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldOrderDescColumn)

        Dim fldGRPO_QTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldGRPO_QTYColumn
            .FieldName = "GRPO_QTY"
            .Width = 130
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldGRPO_QTYColumn)

        Dim fldUOMColumn As New GridViewTextBoxColumn("UNIT OF MEASUREMENT")
        With fldUOMColumn
            .FieldName = "UOM"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "Class"
            .Width = 130
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldOrderSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
        With fldOrderSupplierColumn
            .FieldName = "fldSup"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldOrderSupplierColumn)

        Dim fldStatColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldStatColumn
            .FieldName = "Dept"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvList.Columns.Add(fldStatColumn)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldOAColumn As New GridViewDecimalColumn("ORIGINAL AMOUNT")
        With fldOAColumn
            .FieldName = "fldTotalCost"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvList.Columns.Add(fldOAColumn)
        rgvList.Columns("fldTotalCost").FormatString = "{0:N2}"

        Dim fldSapYenColumn As New GridViewDecimalColumn("SAP YEN AMOUNT")
        With fldSapYenColumn
            .FieldName = "JPYSAP"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvList.Columns.Add(fldSapYenColumn)
        rgvList.Columns("JPYSAP").FormatString = "{0:N2}"

        Dim fldTotal As New GridViewSummaryItem("Purch-Ord", "TOTAL", GridAggregateFunction.Var)
        Dim fldOrigAmount As New GridViewSummaryItem("fldTotalCost", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldYEN As New GridViewSummaryItem("JPYSAP", "{0:N2}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldOrigAmount)
        SummaryRowItem.Add(fldYEN)

        rgvList.SummaryRowsBottom.Add(SummaryRowItem)

        'Dim fldYENColumn As New GridViewDecimalColumn("JPY AMOUNT")
        'With fldYENColumn
        '    .FieldName = "YEN"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 150
        'End With
        'rgvList.Columns.Add(fldYENColumn)
        'rgvList.Columns("YEN").FormatString = "{0:N2}"

        'Dim fldUSDColumn As New GridViewDecimalColumn("USD AMOUNT")
        'With fldUSDColumn
        '    .FieldName = "USD"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 150
        'End With
        'rgvList.Columns.Add(fldUSDColumn)
        'rgvList.Columns("USD").FormatString = "{0:N2}"

        'Dim fldPHPColumn As New GridViewDecimalColumn("PHP AMOUNT")
        'With fldPHPColumn
        '    .FieldName = "PHP"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 150
        'End With
        'rgvList.Columns.Add(fldPHPColumn)
        'rgvList.Columns("PHP").FormatString = "{0:N2}"


        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            '.EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub



    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        dtLoadData = Chinita.fetchDBTable("SELECT " _
                                          & "T1.U_Detail_ID," _
                                          & "T1.U_BudgetRef," _
                                          & "T2.U_HeaderID," _
                                          & "T2.DocNum AS 'Purch-Ord'," _
                                          & "T2.DocDate AS ' Ord-Date'," _
                                          & "T2.CardCode AS 'Vend-Num'," _
                                          & "T1.ItemCode AS 'Product'," _
                                          & "T1.LineStatus AS 'Row-Stat', " _
                                          & "T1.Quantity AS 'Quantity', " _
                                          & "T1.OpenQty AS 'Open-Qty', " _
                                          & "T4.DocNum AS 'Goods-Rcpt', " _
                                          & "T4.DocDueDate AS 'Rcpt-Date', " _
                                          & "T3.Quantity as 'GRPO_QTY'," _
                                          & "(" _
                                          & "case " _
                                          & "WHEN T3.Currency = 'JPY' THEN (T3.Price * T3.Quantity) - ((T3.Price * T3.Quantity)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) " _
                                          & "WHEN T3.Currency = 'USD' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) " _
                                          & "WHEN T3.Currency = 'PHP' THEN ((T3.Price * T3.Quantity) * T4.DocRate) - (((T3.Price * T3.Quantity) * T4.DocRate)*(if(T4.DiscPrcnt is not null,T4.DiscPrcnt,0))/100) " _
                                          & "End) AS 'JPYSAP', " _
                                          & "(SELECT group_concat(POI.fldPRNo) from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'PRNO', " _
                                          & "(SELECT bud.fldDept from tblBudget bud where bud.fldBudRefNum = T1.U_BudgetRef) as 'Dept', " _
                                          & "(SELECT POI.fldSignature from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'fldSignature', " _
                                          & "(SELECT POI.fldTotalCost from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'fldTotalCost', " _
                                          & "(SELECT POI.fldCurrency from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'fldCurrency', " _
                                          & "(SELECT POI.fldYen from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'fldYen', " _
                                          & "(SELECT TPO.fldSupplier from tblPO TPO where TPO.OB_Line = T2.U_HeaderID) as 'fldSup', " _
                                          & "(SELECT POI.fldDesc from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'fldDesc', " _
                                          & "(SELECT POI.fldClass from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'Class', " _
                                          & "(SELECT POI.fldUnit from tblPOI POI where POI.OB_Detail_ID = T1.U_Detail_ID) as 'UOM', " _
                                          & "(SELECT TPO.fldRemarks from tblPO TPO where TPO.OB_Line = T2.U_HeaderID) as Remarks " _
                                          & "FROM POR1 T1 " _
                                          & "LEFT OUTER JOIN OPOR T2 " _
                                          & "ON T1.DocEntry = T2.DocEntry " _
                                          & "LEFT OUTER JOIN PDN1 T3 " _
                                          & "ON T2.DocEntry = T3.BaseEntry " _
                                          & "AND T1.LineNum = T3.BaseLine " _
                                          & "AND T1.ItemCode = T3.ItemCode " _
                                          & "LEFT OUTER JOIN OPDN T4 " _
                                          & "ON T3.DocEntry = T4.DocEntry " _
                                          & "LEFT OUTER JOIN RPD1 T5 " _
                                          & "ON T4.DocEntry = T5.BaseEntry " _
                                          & "AND T3.LineNum = T5.BaseLine " _
                                          & "AND T3.ItemCode = T5.ItemCode " _
                                          & "LEFT OUTER JOIN ORPD T6 " _
                                          & "ON T5.DocEntry = T6.DocEntry " _
                                          & "LEFT OUTER JOIN PCH1 T7 " _
                                          & "ON T4.DocEntry = T7.BaseEntry " _
                                          & "AND T3.LineNum = T7.BaseLine " _
                                          & "AND T3.ItemCode = T7.ItemCode " _
                                          & "LEFT OUTER JOIN OPCH T8 " _
                                          & "ON T7.DocEntry = T8.DocEntry " _
                                          & "LEFT OUTER JOIN RPC1 T9 " _
                                          & "ON T8.DocEntry = T9.BaseEntry " _
                                          & "AND T7.LineNum = T9.BaseLine " _
                                          & "AND T7.ItemCode = T9.ItemCode " _
                                          & "LEFT OUTER JOIN ORPC T10 " _
                                          & "ON T9.DocEntry = T10.DocEntry " _
                                          & "WHERE T2.U_HeaderID Is Not null " _
                                          & "and T6.DocNum is null " _
                                          & "and T10.DocNum is null " _
                                          & "and T4.DocNum is not null " _
                                          & "AND T1.U_BudgetRef = '" & txtBRNum.Text & "'")


    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub bwLoadItem_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadItem.DoWork
        'dtLoadData2 = Chinita.fetchDBTable("SELECT year(tr2.fldMonthOrder) as Byear, tr1.fldMAIID,tr1.fldICode,tr1.fldTransCode,tr1.fldDesc,tr1.fldQTY," _
        '                                   & "tr1.fldUnit, tr1.fldUPrice, tr1.fldTotalCost, tr1.fldCurrency, tr1.fldYen, tr1.fldMonthDelivery" _
        '                                   & ",(CASE " _
        '                                   & "WHEN tr1.fldCurrency = 'USD' then tr1.fldTotalCost " _
        '                                   & "WHEN tr1.fldCurrency = 'PHP' then tr1.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
        '                                   & "WHEN tr1.fldCurrency = 'YEN' then tr1.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
        '                                   & "END) as USD, " _
        '                                   & "(CASE " _
        '                                   & "WHEN tr1.fldCurrency = 'PHP' then tr1.fldTotalCost " _
        '                                   & "WHEN tr1.fldCurrency = 'USD' then tr1.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
        '                                   & "WHEN tr1.fldCurrency = 'YEN' then tr1.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
        '                                   & "END) as PHP, " _
        '                                   & "(CASE " _
        '                                   & "WHEN tr1.fldCurrency = 'YEN' then tr1.fldTotalCost " _
        '                                   & "WHEN tr1.fldCurrency = 'USD' then tr1.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
        '                                   & "WHEN tr1.fldCurrency = 'PHP' then tr1.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
        '                                   & "END) as YEN " _
        '                                   & "FROM tblMAI tr1 left join tblOrder tr2 on tr1.fldTransCode = tr2.fldTransCode " _
        '                                   & "WHERE tr1.fldTransCode = '" & rgvList.CurrentRow.Cells("fldTransCode").Value & "'")

    End Sub

    Private Sub bwLoadItem_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadItem.RunWorkerCompleted
        rgvListItem.DataSource = dtLoadData2
    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        'bwLoadItem.RunWorkerAsync()
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub
End Class

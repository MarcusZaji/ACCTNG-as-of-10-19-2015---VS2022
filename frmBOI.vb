Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class frmBOI

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private dtOPOR As DataTable
    Private ds As DataSet

    Private Sub frmBOI_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmBOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        ReadyGrid()
        ReadyGridListItem()
        bwLoadData.RunWorkerAsync()
        bwLoadPOUploaded.RunWorkerAsync()

    End Sub

    Private Sub ReadyGrid()
        Try
            Dim fldOrderIDColumn As New GridViewTextBoxColumn("ID")
            With fldOrderIDColumn
                .FieldName = "fldPOIID"
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
                .FieldName = "PO"
                .Width = 150
                .TextAlignment = ContentAlignment.MiddleCenter
            End With
            rgvList.Columns.Add(fldPONoColumn)

            Dim fldPRNoColumn As New GridViewTextBoxColumn("PR NUMBER")
            With fldPRNoColumn
                .FieldName = "fldPRNo"
                .Width = 150
                .TextAlignment = ContentAlignment.MiddleCenter
            End With
            rgvList.Columns.Add(fldPRNoColumn)

            Dim fldOrderDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
            With fldOrderDescColumn
                .FieldName = "fldDesc"
                .Width = 200
                .TextAlignment = ContentAlignment.MiddleCenter
            End With
            rgvList.Columns.Add(fldOrderDescColumn)

            Dim fldOrderSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
            With fldOrderSupplierColumn
                .FieldName = "fldSupplier"
                .Width = 150
                .TextAlignment = ContentAlignment.MiddleCenter
            End With
            rgvList.Columns.Add(fldOrderSupplierColumn)

            Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
            With fldStatColumn
                .FieldName = "fldStat"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 80
            End With
            rgvList.Columns.Add(fldStatColumn)

            Dim fldMODateColumn As New GridViewDateTimeColumn("MONTH ORDERED")
            With fldMODateColumn
                .FieldName = "fldMO"
                .Width = 140
                .Format = DateTimePickerFormat.Custom
                '.CustomFormat = "MMM dd, yyyy"
                .TextAlignment = ContentAlignment.MiddleCenter
                .ReadOnly = True
            End With
            rgvList.Columns.Add(fldMODateColumn)
            rgvList.Columns("fldMO").FormatString = "{0:MMM dd, yyyy}"

            Dim fldQTYColumn As New GridViewTextBoxColumn("QTY")
            With fldQTYColumn
                .FieldName = "fldQTY"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 60
            End With
            rgvList.Columns.Add(fldQTYColumn)

            Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
            With fldCurrencyColumn
                .FieldName = "fldCurrency"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 80
            End With
            rgvList.Columns.Add(fldCurrencyColumn)

            Dim fldUPriceColumn As New GridViewDecimalColumn("UNIT AMOUNT")
            With fldUPriceColumn
                .FieldName = "fldUPrice"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 150
            End With
            rgvList.Columns.Add(fldUPriceColumn)
            rgvList.Columns("fldUPrice").FormatString = "{0:N2}"

            Dim fldTotalPriceColumn As New GridViewDecimalColumn("TOTAL ITEM AMOUNT")
            With fldTotalPriceColumn
                .FieldName = "TOTAL"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 150
            End With
            rgvList.Columns.Add(fldTotalPriceColumn)
            rgvList.Columns("TOTAL").FormatString = "{0:N2}"

            Dim fldTCColumn As New GridViewDecimalColumn("TOTAL PO AMOUNT")
            With fldTCColumn
                .FieldName = "fldYen"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 150
            End With
            rgvList.Columns.Add(fldTCColumn)
            rgvList.Columns("fldTotalCost").FormatString = "{0:N2}"

            Dim fldYENColumn As New GridViewDecimalColumn("PO JPY AMOUNT")
            With fldYENColumn
                .FieldName = "fldYen"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 150
            End With
            rgvList.Columns.Add(fldYENColumn)
            rgvList.Columns("fldYen").FormatString = "{0:N2}"

            Dim fldYenSapColumn As New GridViewDecimalColumn("SAP YEN AMOUNT")
            With fldYenSapColumn
                .FieldName = "fldYenSap"
                .ReadOnly = True
                .TextAlignment = ContentAlignment.MiddleCenter
                .Width = 150
            End With
            rgvList.Columns.Add(fldYenSapColumn)
            rgvList.Columns("fldJPY").FormatString = "{0:N2}"

            Dim fldTotal As New GridViewSummaryItem("PO", "TOTAL", GridAggregateFunction.Var)
            Dim fldOrigAmount As New GridViewSummaryItem("fldYen", "{0:N2}", GridAggregateFunction.Sum)
            Dim fldYEN As New GridViewSummaryItem("fldYenSap", "{0:N2}", GridAggregateFunction.Sum)

            Dim SummaryRowItem As New GridViewSummaryRowItem()
            SummaryRowItem.Add(fldTotal)
            SummaryRowItem.Add(fldOrigAmount)
            SummaryRowItem.Add(fldYEN)

            rgvList.SummaryRowsBottom.Add(SummaryRowItem)

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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyGridListItem()

        Dim fldUPOIDColumn As New GridViewTextBoxColumn("ID")
        With fldUPOIDColumn
            .FieldName = "fldUPONo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvPOUploaded.Columns.Add(fldUPOIDColumn)

        Dim fldPONoColumn As New GridViewTextBoxColumn("PO NUMBER")
        With fldPONoColumn
            .FieldName = "fldPONo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOUploaded.Columns.Add(fldPONoColumn)

        Dim fldBRNColumn As New GridViewTextBoxColumn("BUDGET REF. NO.")
        With fldBRNColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvPOUploaded.Columns.Add(fldBRNColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOUploaded.Columns.Add(fldDeptColumn)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOUploaded.Columns.Add(fldCurrencyColumn)

        Dim fldOAColumn As New GridViewDecimalColumn("ORIGINAL AMOUNT")
        With fldOAColumn
            .FieldName = "fldOAmount"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvPOUploaded.Columns.Add(fldOAColumn)
        rgvPOUploaded.Columns("fldOAmount").FormatString = "{0:N2}"

        Dim fldJPYColumn As New GridViewDecimalColumn("JPY AMOUNT")
        With fldJPYColumn
            .FieldName = "fldJPY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvPOUploaded.Columns.Add(fldJPYColumn)
        rgvPOUploaded.Columns("fldJPY").FormatString = "{0:N2}"

        Dim fldOrderSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
        With fldOrderSupplierColumn
            .FieldName = "fldSupplier"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOUploaded.Columns.Add(fldOrderSupplierColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOUploaded.Columns.Add(fldClassColumn)

        Dim fldUDateColumn As New GridViewDateTimeColumn("UPLOADED DATE")
        With fldUDateColumn
            .FieldName = "fldUDate"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvPOUploaded.Columns.Add(fldUDateColumn)
        rgvPOUploaded.Columns("fldUDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDDateColumn As New GridViewDateTimeColumn("DATE DELIVERED")
        With fldDDateColumn
            .FieldName = "fldDDate"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvPOUploaded.Columns.Add(fldDDateColumn)
        rgvPOUploaded.Columns("fldDDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldTotal As New GridViewSummaryItem("fldPONo", "TOTAL", GridAggregateFunction.Var)
        Dim fldOrigAmount As New GridViewSummaryItem("fldOAmount", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldYEN As New GridViewSummaryItem("fldJPY", "{0:N2}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldOrigAmount)
        SummaryRowItem.Add(fldYEN)

        rgvPOUploaded.SummaryRowsBottom.Add(SummaryRowItem)

        With rgvPOUploaded
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

        Zaji.addParameter("BudRefNum", globalVariables.BudRefNo)
        Dim DTMBud As DataTable = Zaji.dbSelect("SP_SelectPOPOIByRefNo")

        dtOPOR = SAP.dbSelect("SP_SelectPOinOPOR")

        Dim query = (From i In DTMBud.AsEnumerable()
                     Let _PONum = PONum(Convert.ToString(i("OB_Line")))
                     Select New With
                            {
                                .fldSupplier = i("fldSupplier"),
                                .OB_Detail_ID = i("OB_Detail_ID"),
                                .fldUC4S = i("fldUC4S"),
                                .OB_Line = i("OB_Line"),
                                .fldTransCode = i("fldTransCode"),
                                .fldBudRefNum = i("fldBudRefNum"),
                                .fldPRNo = i("fldPRNo"),
                                .fldICode = i("fldICode"),
                                .fldDesc = i("fldDesc"),
                                .fldQTY = i("fldQTY"),
                                .fldUnit = i("fldUnit"),
                                .fldUPrice = i("fldUPrice"),
                                .fldTotalCost = i("fldTotalCost"),
                                .fldYen = i("fldYen"),
                                .fldCurrency = i("fldCurrency"),
                                .fldMonthDelivery = i("fldMonthDelivery"),
                                .fldStat = i("fldStat"),
                                .fldSignature = i("fldSignature"),
                                .fldUID = i("fldUID"),
                                .fldMO = i("fldMO"),
                                .fldPOIID = i("fldPOIID"),
                                .fldMOIID = i("fldMOIID"),
                                .fldYenSap = i("fldYenSap"),
                                .TOTAL = i("TOTAL"),
                                .PO = _PONum
                             }).ToList()

        dtLoadData = Zaji.convertToDatatable(query)
    End Sub

    Public Function PONum(ByVal OB_Line As String) As String
        Dim PO = (From i In dtOPOR.AsEnumerable()
                  Where Convert.ToString(i("U_HeaderID")) = OB_Line
                  Select (Convert.ToString(i("docnum")))).FirstOrDefault()
        Return Convert.ToString(PO)
    End Function


    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        Try
            bwLoadPOUploaded.RunWorkerAsync()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub bwLoadPOUploaded_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadPOUploaded.DoWork
        dtLoadData2 = Chinita.fetchDBTable("SELECT fldUPONo, fldBudRefNum, fldDept, fldOAmount," _
                                           & "fldJPY, fldPONo, fldUDate, fldDDate, fldSupplier, " _
                                           & "fldClass, fldCurrency FROM tblUPO " _
                                           & "WHERE fldBudRefNum = '" & txtBRNum.Text & "'")
    End Sub

    Private Sub bwLoadPOUploaded_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadPOUploaded.RunWorkerCompleted
        rgvPOUploaded.DataSource = dtLoadData2
    End Sub

    Private Sub btnExportPO_Click(sender As Object, e As EventArgs) Handles btnExportPO.Click
        Dim exporter As New ExportToExcelML(rgvList)

        exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
        exporter.ExportVisualSettings = True

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog1.FileName
            exporter.RunExport(fileName)
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(Me, "EXCEL EXPORT SUCCESS", "EXPORT EXCEL", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub btnExportUPO_Click(sender As Object, e As EventArgs) Handles btnExportUPO.Click
        Dim exporter As New ExportToExcelML(rgvPOUploaded)

        exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
        exporter.ExportVisualSettings = True

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog1.FileName
            exporter.RunExport(fileName)
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(Me, "EXCEL EXPORT SUCCESS", "EXPORT EXCEL", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub frmBOI_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
End Class
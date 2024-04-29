Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient

Public Class frmPOChange

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable

    Private Sub frmPOChange_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadDataPO.IsBusy Then
                bwLoadDataPO.CancelAsync()
                imBusy = False
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmPOChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmsplash.busy()
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        GetSupSap_POC()

        ReadyPOGrid()
        ReadyPOIGrid()

        Getuser()

        dtpMOrder.Value = Today
        dtpDelDate.Value = Today
        ddlFMonth.Text = Today.Month
        ddlFYear.Text = Today.Year

        ddlSupSap.Text = ""
        txtVenCode.Text = ""
        txtCurrency.Text = ""

        ddlSupSap.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlSupSap.AutoCompleteDataSource = AutoCompleteSource.CustomSource
       
    End Sub

    Private Sub frmPOChange_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        Me.Cursor = Cursors.WaitCursor
        bwLoadDataPO.RunWorkerAsync()
        pbOlrayt.Visible = True
    End Sub

    Private Sub bwLoadDataPO_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataPO.DoWork
        Dim DEPT As String = lblDept.Text
        Dim FMONTH As Integer = ddlFMonth.Text
        Dim FYEAR As Integer = ddlFYear.Text

        If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Or lblUserlvl.Text = "PROFESSIONAL" Then
            dtLoadData = Chinita.fetchDBTable("call POC_GetPOChangeAdmin('" & FMONTH & "','" & FYEAR & "')")
        Else
            dtLoadData = Chinita.fetchDBTable("call POC_GetPOChangeNonAdmin('" & DEPT & "','" & FMONTH & "','" & FYEAR & "')")
        End If

        For counter As Integer = 0 To dtLoadData.Rows.Count - 1
            Dim x As Double = counter / dtLoadData.Rows.Count * 100
            bwLoadDataPO.ReportProgress(x)
            Threading.Thread.Sleep(Delay)
        Next

    End Sub

    Private Sub bwLoadDataPO_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadDataPO.ProgressChanged
        pbOlrayt.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadDataPO_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadDataPO.RunWorkerCompleted
        Try
            rgvPOList.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOlrayt.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Getuser()
        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

        lblName.Text = drUser.Item("fldName").ToString

    End Sub

    Private Sub bwLoadDataPOI_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataPOI.DoWork
        Try
            Dim OB_Line As String = rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString

            dtLoadData2 = Chinita.fetchDBTable("call POC_GetPOChangeItem('" & OB_Line & "')")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadDataPOI_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadDataPOI.RunWorkerCompleted
        rgvPOIList.DataSource = dtLoadData2
    End Sub

    Private Sub ReadyPOGrid()

        Dim fldPOIDColumn As New GridViewTextBoxColumn("ID")
        With fldPOIDColumn
            .FieldName = "fldPOID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvPOList.Columns.Add(fldPOIDColumn)

        Dim fldCPONoColumn As New GridViewTextBoxColumn("POC NUMBER")
        With fldCPONoColumn
            .FieldName = "fldCPONo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
        End With
        rgvPOList.Columns.Add(fldCPONoColumn)

        Dim fldPONumberColumn As New GridViewTextBoxColumn("PO NUMBER")
        With fldPONumberColumn
            .FieldName = "PO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
        End With
        rgvPOList.Columns.Add(fldPONumberColumn)

        Dim fldPRNoColumn As New GridViewTextBoxColumn("PR NUMBER")
        With fldPRNoColumn
            .FieldName = "PR"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldPRNoColumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn("Index")
        With fldIndexColumn
            .FieldName = "fldIndex"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
            .IsPinned = Left
        End With
        rgvPOList.Columns.Add(fldIndexColumn)

        Dim OB_LineColumn As New GridViewTextBoxColumn("OB LINE")
        With OB_LineColumn
            .FieldName = "OB_Line"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvPOList.Columns.Add(OB_LineColumn)

        Dim fldVCodeColumn As New GridViewTextBoxColumn("VENDOR CODE")
        With fldVCodeColumn
            .FieldName = "fldVCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvPOList.Columns.Add(fldVCodeColumn)

        Dim fldSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
        With fldSupplierColumn
            .FieldName = "fldSupplier"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 250
        End With
        rgvPOList.Columns.Add(fldSupplierColumn)

        Dim fldMOrderedColumn As New GridViewTextBoxColumn("ORDER DATE")
        With fldMOrderedColumn
            .FieldName = "fldMOrdered"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOList.Columns.Add(fldMOrderedColumn)
        rgvPOList.Columns("fldMOrdered").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDDateColumn As New GridViewTextBoxColumn("DELIVERY DATE")
        With fldDDateColumn
            .FieldName = "fldDDate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOList.Columns.Add(fldDDateColumn)
        rgvPOList.Columns("fldDDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOList.Columns.Add(fldCurrencyColumn)

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "fldStat"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = False
        End With
        rgvPOList.Columns.Add(fldStatColumn)

        Dim fldLTPOColumn As New GridViewDecimalColumn("LTPO")
        With fldLTPOColumn
            .FieldName = "LTPO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldLTPOColumn)
        rgvPOList.Columns("LTPO").FormatString = "{0:N2}"

        Dim fldTPOColumn As New GridViewDecimalColumn("TOTAL PO AMOUNT")
        With fldTPOColumn
            .FieldName = "fldTPO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldTPOColumn)
        rgvPOList.Columns("fldTPO").FormatString = "{0:N2}"

        Dim OB_POAmtColumn As New GridViewDecimalColumn("DISCOUNTED PO AMOUNT")
        With OB_POAmtColumn
            .FieldName = "OB_POAmt"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(OB_POAmtColumn)
        rgvPOList.Columns("OB_POAmt").FormatString = "{0:N2}"

        Dim fldDiscountColumn As New GridViewDecimalColumn("%")
        With fldDiscountColumn
            .FieldName = "fldDiscount"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldDiscountColumn)
        rgvPOList.Columns("fldDiscount").FormatString = "{0:N2}"

        Dim fldDAmountColumn As New GridViewDecimalColumn("DISCOUNT")
        With fldDAmountColumn
            .FieldName = "fldDAmount"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldDAmountColumn)
        rgvPOList.Columns("fldDAmount").FormatString = "{0:N2}"

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldRemarks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 250
        End With
        rgvPOList.Columns.Add(fldRemarksColumn)

        Dim fldSignatureColumn As New GridViewTextBoxColumn("SIGNATURE")
        With fldSignatureColumn
            .FieldName = "fldSignature"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 180
        End With
        rgvPOList.Columns.Add(fldSignatureColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsPinned = Left
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldDeptColumn)

        With rgvPOList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False

        End With

    End Sub

    Private Sub ReadyPOIGrid()
        Dim OB_Detail_IDColumn As New GridViewTextBoxColumn("OB_Detail_ID")
        With OB_Detail_IDColumn
            .FieldName = "OB_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(OB_Detail_IDColumn)

        Dim fldPOIDColumn As New GridViewTextBoxColumn("ID")
        With fldPOIDColumn
            .FieldName = "fldPOIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldPOIDColumn)

        Dim fldCheckBoxColumn As New GridViewCheckBoxColumn("")
        With fldCheckBoxColumn
            .DataType = GetType(Boolean)
            .Name = "CheckBox"
            .IsPinned = Left
            .Width = 30
            .AllowResize = False
        End With
        rgvPOIList.Columns.Add(fldCheckBoxColumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn("*")
        With fldIndexColumn
            .FieldName = "fldIndex"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 20
            .IsVisible = True
            .IsPinned = Left
            .AllowResize = False
        End With
        rgvPOIList.Columns.Add(fldIndexColumn)

        Dim fldPONumberColumn As New GridViewTextBoxColumn("PO NUMBER")
        With fldPONumberColumn
            .FieldName = "PO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldPONumberColumn)

        Dim OB_LineColumn As New GridViewTextBoxColumn("OB LINE")
        With OB_LineColumn
            .FieldName = "OB_Line"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(OB_LineColumn)

        Dim fldBudRefNumColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefNumColumn
            .FieldName = "fldBudRefNum"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            .IsPinned = Right
        End With
        rgvPOIList.Columns.Add(fldBudRefNumColumn)

        Dim fldPRNoColumn As New GridViewTextBoxColumn("PR NUMBER")
        With fldPRNoColumn
            .FieldName = "fldPRNo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOIList.Columns.Add(fldPRNoColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldICodeColumn
            .FieldName = "fldICode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOIList.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("REASON / DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldRD"
            '.ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 350
        End With
        rgvPOIList.Columns.Add(fldDescColumn)

        Dim fldUPriceColumn As New GridViewDecimalColumn("UNIT PRICE")
        With fldUPriceColumn
            .FieldName = "fldUPrice"
            .ReadOnly = False
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOIList.Columns.Add(fldUPriceColumn)
        rgvPOIList.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldQTYColumn As New GridViewDecimalColumn("QTY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOIList.Columns.Add(fldQTYColumn)
        rgvPOIList.Columns("fldQTY").FormatString = "{0:N2}"

        Dim fldQTYSINColumn As New GridViewDecimalColumn("MOIQTYSIN")
        With fldQTYSINColumn
            .FieldName = "MOIQTYSIN"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldQTYSINColumn)
        rgvPOIList.Columns("MOIQTYSIN").FormatString = "{0:N2}"

        Dim fldQTYSOutColumn As New GridViewDecimalColumn("QTY_SOUT")
        With fldQTYSOutColumn
            .FieldName = "fldQTYSOut"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOIList.Columns.Add(fldQTYSOutColumn)
        rgvPOIList.Columns("fldQTYSOut").FormatString = "{0:N2}"

        Dim fldUnitColumn As New GridViewTextBoxColumn("UNIT")
        With fldUnitColumn
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
        End With
        rgvPOIList.Columns.Add(fldUnitColumn)

        Dim OB_POAmtColumn As New GridViewDecimalColumn("TOTAL PO AMOUNT")
        With OB_POAmtColumn
            .FieldName = "TUPrice"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvPOIList.Columns.Add(OB_POAmtColumn)
        rgvPOIList.Columns("TUPrice").FormatString = "{0:N6}"

        Dim fldGRPOQTY As New GridViewDecimalColumn("GRPO QTY")
        With fldGRPOQTY
            .FieldName = "GRPOQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
        End With
        rgvPOIList.Columns.Add(fldGRPOQTY)
        rgvPOIList.Columns("GRPOQTY").FormatString = "{0:N2}"

        Dim fldMOIIDColumn As New GridViewTextBoxColumn("MOIID")
        With fldMOIIDColumn
            .FieldName = "fldMOIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldMOIIDColumn)

        Dim fldTotal As New GridViewSummaryItem("fldBudRefNum", "TOTAL", GridAggregateFunction.Var)
        'Dim fldTCSum As New GridViewSummaryItem("fldUPrice", "{0:N6}", GridAggregateFunction.Sum)
        Dim fldTOTAL_PO_Amount As New GridViewSummaryItem("TUPrice", "{0:N6}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        'SummaryRowItem.Add(fldTCSum)
        SummaryRowItem.Add(fldTOTAL_PO_Amount)

        With rgvPOIList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = True '------
            .AllowRowResize = False
            .AllowAddNewRow = False
            .AllowEditRow = True
            .SummaryRowsBottom.Add(SummaryRowItem)
        End With

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If bwLoadDataPO.IsBusy Then
            bwLoadDataPO.CancelAsync()
            imBusy = False
        End If

        Me.Close()
    End Sub

    Private Sub rgvPOList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvPOList.CellClick

        Try

            ddlSupSap.Text = rgvPOList.CurrentRow.Cells("fldSupplier").Value.ToString
            txtSupName.Text = rgvPOList.CurrentRow.Cells("fldSupplier").Value.ToString 'hidden txtbox
            txtVenCode.Text = rgvPOList.CurrentRow.Cells("fldVCode").Value.ToString
            txtCurrency.Text = rgvPOList.CurrentRow.Cells("fldCurrency").Value.ToString
            dtpMOrder.Value = rgvPOList.CurrentRow.Cells("fldMOrdered").Value
            dtpDelDate.Value = rgvPOList.CurrentRow.Cells("fldDDate").Value

            GetCurSap_POC()

            RTTPO.Text = rgvPOList.CurrentRow.Cells("fldTPO").Value.ToString
            RTUPrice.Text = rgvPOList.CurrentRow.Cells("fldDAmount").Value.ToString
            RTD.Text = rgvPOList.CurrentRow.Cells("fldDiscount").Value.ToString
            RTTotal.Text = rgvPOList.CurrentRow.Cells("OB_POAmt").Value.ToString
            txtRemarks.Text = rgvPOList.CurrentRow.Cells("fldRemarks").Value.ToString

            txtLTPO.Text = rgvPOList.CurrentRow.Cells("LTPO").Value.ToString

            bwLoadDataPOI.RunWorkerAsync()

            If rgvPOList.CurrentRow.Cells("fldIndex").Value.ToString <= 0 Then
                ddlCancel.Enabled = False
                ddlCancel.SelectedValue = "NO"
                btnPrintPOC.Enabled = False
            Else
                ddlCancel.Enabled = True
                ddlCancel.SelectedValue = "NO"
                btnPrintPOC.Enabled = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPOCNo.Text = ""
        ddlSupSap.Text = "'"
        txtSupName.Text = ""
        txtVenCode.Text = ""
        txtCurrency.Text = ""

        RTTPO.Text = 0.0
        RTUPrice.Text = 0.0
        RTD.Text = 0.0
        RTTotal.Text = 0.0
        txtRemarks.Text = ""

        rgvPOList.FilterDescriptors.Clear()
        'bwLoadDataPO.RunWorkerAsync()
    End Sub

    Private Sub ddlSupSap_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlSupSap.SelectedIndexChanged
        'GetCurSap_POC()
        GetSapCardCodePOChange()
    End Sub

    Private Sub rgvPOIList_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles rgvPOIList.CellEndEdit
        Try
            Dim x As Decimal = Convert.ToDecimal(rgvPOIList.CurrentRow.Cells("fldQty").Value)
            Dim y As Decimal = Convert.ToDecimal(rgvPOIList.CurrentRow.Cells("fldUPrice").Value)
            Dim z As Decimal = Convert.ToDecimal(rgvPOIList.CurrentRow.Cells("fldQTYSOUT").Value)

            rgvPOIList.CurrentRow.Cells("TUPrice").Value = (x - z) * y
            RTTPO.Text = rgvPOIList.MasterView.SummaryRows(0).Cells("TUPrice").Value

            Dim isChecked As Boolean = CBool(rgvPOIList.CurrentRow.Cells("CheckBox").Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rgvPOIList_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgvPOIList.CellFormatting
        If (e.CellElement.ColumnInfo.HeaderText = "UNIT PRICE") Or _
            (e.CellElement.ColumnInfo.HeaderText = "QTY_SOUT") Or _
            (e.CellElement.ColumnInfo.HeaderText = "REASON / DESCRIPTION") Then
            e.CellElement.DrawFill = True
            'e.CellElement.NumberOfColors = 1
            e.CellElement.BackColor = System.Drawing.Color.LightSkyBlue

        Else
            e.CellElement.DrawFill = True
            ' e.CellElement.NumberOfColors = 1
            e.CellElement.BackColor = System.Drawing.Color.Transparent
        End If
    End Sub

    Private Sub rgvPOIList_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles rgvPOIList.CellValueChanged
        Dim isChecked As Boolean = CBool(rgvPOIList.CurrentRow.Cells("CheckBox").Value)

        If isChecked = True Then
            rgvPOIList.CurrentRow.Cells("fldUPrice").ReadOnly = False
            rgvPOIList.CurrentRow.Cells("fldQTYSOUT").ReadOnly = False
            rgvPOIList.CurrentRow.Cells("fldUPrice").BeginEdit()
            'btnCPO.Enabled = True
        Else
            rgvPOIList.CurrentRow.Cells("fldUPrice").ReadOnly = True
            rgvPOIList.CurrentRow.Cells("fldQTYSOUT").ReadOnly = True

        End If
    End Sub

    Private Sub btnCPO_Click(sender As Object, e As EventArgs) Handles btnCPO.Click

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand
        Dim myCmd4 As New MySqlCommand
        Dim myCmd5 As New MySqlCommand
        Dim myCmd6 As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myAdapter3 As New MySqlDataAdapter
        Dim myAdapter4 As New MySqlDataAdapter
        Dim myAdapter5 As New MySqlDataAdapter
        Dim myAdapter6 As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myData3 As New DataTable
        Dim myData4 As New DataTable
        Dim myData5 As New DataTable
        Dim myData6 As New DataTable

        Dim POCNo As String = txtPOCNo.Text
        Dim VenCode As String = txtVenCode.Text
        Dim Remarks As String = txtRemarks.Text
        Dim Currency As String = txtCurrency.Text
        Dim CPOSignature As String = txtSignature.Text
        Dim OB_LineUp As String = rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString
        Dim Cancel As String = ddlCancel.Text
        Dim IndexPO As Integer = rgvPOList.CurrentRow.Cells("fldIndex").Value.ToString

        Dim Discount As Decimal = RTD.Text
        Dim Amount As Decimal = RTUPrice.Text
        Dim OBAmt As Decimal = RTTotal.Text
        Dim fldTotalCost As Decimal = RTTPO.Text

        Dim Supplier As String = ddlSupSap.Text

        myCmd4.Connection = conn
        myCmd5.Connection = conn


        For z As Integer = 0 To rgvPOIList.ChildRows.Count - 1
            If rgvPOIList.ChildRows(z).Cells("fldUPrice").Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please Check input. Zero unit price is not acceptable.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Exit Sub
            End If

        Next

        conn.Open()

        If String.IsNullOrEmpty(txtPOCNo.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Enter A PO Change Number.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            txtPOCNo.Focus()

        Else

            myCmd.Connection = conn
            myCmd2.Connection = conn
            myCmd3.Connection = conn

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Are you sure you want to Change this item(s)?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Dim count As Integer
                Dim count2 As Integer

                For y As Integer = 0 To rgvPOIList.ChildRows.Count - 1
                    Dim isChecked As Boolean = CBool(rgvPOIList.ChildRows(y).Cells("CheckBox").Value)

                    If isChecked = True Then
                        count = 1
                        count2 += count
                    End If
                Next

                If count2 = 0 Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Please Specify time(s) to change.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Exit Sub
                End If

                myCmd4.CommandText = "INSERT INTO tblPO" _
                                & "(fldCPONo, OB_Line, fldSupplier, fldVCode, fldMOrdered, fldDDate, fldIndex, " _
                                & "fldStat, fldCurrency, fldDiscount, fldDAmount, fldTPO, OB_POAmt, fldRemarks, fldSignature, fldCPOSignature) " _
                                & " " _
                                & "SELECT " _
                                & "'" & POCNo & "', OB_Line, '" & Replace(Supplier, "'", "''") & "', '" & VenCode & "', fldMOrdered, '" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpDelDate.Value)) & "', '" & IndexPO & "'+1, " _
                                & "'OPEN', '" & Currency & "', '" & Discount & "', '" & Amount & "', '" & fldTotalCost & "', '" & OBAmt & "', '" & Remarks & "', fldSignature, '" & CPOSignature & "' " _
                                & "from tblPO where OB_Line = '" & OB_LineUp & "' and fldIndex = '" & IndexPO & "';"
                myCmd4.ExecuteNonQuery()

                myCmd5.CommandText = "UPDATE tblPO SET fldStat = 'CLOSE', fldCancel ='" & Cancel & "' WHERE OB_Line = '" & OB_LineUp & "' and fldIndex = '" & IndexPO & "';"
                myCmd5.ExecuteNonQuery()

                For x As Integer = 0 To rgvPOIList.ChildRows.Count - 1
                    Dim isChecked As Boolean = CBool(rgvPOIList.ChildRows(x).Cells("CheckBox").Value)

                    If isChecked = True Then
                        Dim POIID As Integer = rgvPOIList.ChildRows(x).Cells("fldPOIID").Value
                        Dim Index As Integer = rgvPOIList.ChildRows(x).Cells("fldIndex").Value

                        Dim fldUPrice As Decimal = rgvPOIList.ChildRows(x).Cells("fldUPrice").Value
                        Dim fldRD As String = rgvPOIList.ChildRows(x).Cells("fldRD").Value.ToString
                        Dim SOUT As Decimal = rgvPOIList.ChildRows(x).Cells("fldQTYSOut").Value

                        Dim OB_Line As String = rgvPOIList.ChildRows(x).Cells("OB_Line").Value.ToString
                        Dim MOIQTYSIN As Integer = rgvPOIList.ChildRows(x).Cells("MOIQTYSIN").Value
                        Dim MOIID As Integer = rgvPOIList.ChildRows(x).Cells("fldMOIID").Value

                        Dim OB_Detail_ID As Integer = rgvPOIList.ChildRows(x).Cells("OB_Detail_ID").Value

                        'Dim QTYOUT As Integer = rgvList.CurrentRow.Cells("fldQTYSOUT").Value

                        Dim MonthDelivery As Date = dtpDelDate.Text

                        myCmd.CommandText = "INSERT INTO tblPOI" _
                            & "(OB_Detail_ID, fldMOIID, OB_Line, fldTransCode, fldBudRefNum, fldPRNo, fldICode, fldDesc, fldQTY, fldQTYSOut, " _
                            & "fldUnit, fldStat, fldUID, fldMO, fldSignature, fldUPrice, fldTotalCost, fldCurrency, fldMonthDelivery, " _
                            & "fldDept, fldClass, fldIndex, fldCPOSignature, fldCPONo, fldRD)" _
                            & " " _
                            & "SELECT " _
                            & "OB_Detail_ID, fldMOIID, OB_Line, fldTransCode, fldBudRefNum, fldPRNo, fldICode, fldDesc, fldQTY, '" & SOUT & "', " _
                            & "fldUnit, 'OPEN', fldUID, fldMO, fldSignature, '" & fldUPrice & "', '" & fldTotalCost & "', '" & Currency & "', '" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpDelDate.Value)) & "', " _
                            & "fldDept, fldClass, '" & Index & "'+1, '" & CPOSignature & "', '" & POCNo & "', '" & fldRD & "' " _
                            & "From tblPOI where fldPOIID = '" & POIID & "' and fldIndex = '" & Index & "';"
                        myCmd.ExecuteNonQuery()

                        myCmd2.CommandText = "UPDATE tblPOI SET fldStat = 'CLOSE', fldCancel ='" & Cancel & "'  WHERE fldPOIID = '" & POIID & "' and fldIndex = '" & Index & "';"
                        myCmd2.ExecuteNonQuery()

                        myCmd.Parameters.Clear()
                        myCmd2.Parameters.Clear()
                    Else
                        Dim POIID As Integer = rgvPOIList.ChildRows(x).Cells("fldPOIID").Value
                        Dim Index As Integer = rgvPOIList.ChildRows(x).Cells("fldIndex").Value

                        Dim fldUPrice As Decimal = rgvPOIList.ChildRows(x).Cells("fldUPrice").Value
                        Dim fldRD As String = rgvPOIList.ChildRows(x).Cells("fldRD").Value.ToString
                        Dim SOUT As Decimal = rgvPOIList.ChildRows(x).Cells("fldQTYSOut").Value

                        Dim OB_Line As String = rgvPOIList.ChildRows(x).Cells("OB_Line").Value.ToString
                        Dim MOIQTYSIN As Integer = rgvPOIList.ChildRows(x).Cells("MOIQTYSIN").Value
                        Dim MOIID As Integer = rgvPOIList.ChildRows(x).Cells("fldMOIID").Value

                        Dim OB_Detail_ID As Integer = rgvPOIList.ChildRows(x).Cells("OB_Detail_ID").Value

                        'Dim QTYOUT As Integer = rgvList.CurrentRow.Cells("fldQTYSOUT").Value

                        Dim MonthDelivery As Date = dtpDelDate.Text

                        myCmd.CommandText = "INSERT INTO tblPOI" _
                            & "(OB_Detail_ID, fldMOIID, OB_Line, fldTransCode, fldBudRefNum, fldPRNo, fldICode, fldDesc, fldQTY, fldQTYSOut, " _
                            & "fldUnit, fldStat, fldUID, fldMO, fldSignature, fldUPrice, fldTotalCost, fldCurrency, fldMonthDelivery, " _
                            & "fldDept, fldClass, fldIndex, fldCPOSignature, fldCPONo, fldRD)" _
                            & " " _
                            & "SELECT " _
                            & "OB_Detail_ID, fldMOIID, OB_Line, fldTransCode, fldBudRefNum, fldPRNo, fldICode, fldDesc, fldQTY, '" & SOUT & "', " _
                            & "fldUnit, 'OPEN', fldUID, fldMO, fldSignature, '" & fldUPrice & "', '" & fldTotalCost & "', '" & Currency & "', '" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpDelDate.Value)) & "', " _
                            & "fldDept, fldClass, '" & Index & "', '" & CPOSignature & "', '" & POCNo & "', '" & fldRD & "' " _
                            & "From tblPOI where fldPOIID = '" & POIID & "' and fldIndex = '" & Index & "';"
                        myCmd.ExecuteNonQuery()

                        myCmd2.CommandText = "UPDATE tblPOI SET fldStat = 'CLOSE', fldCancel ='" & Cancel & "', fldRemarks2 ='CLOSE BECAUSE OF CHANGE PO' WHERE fldPOIID = '" & POIID & "' and fldIndex = '" & Index & "';"
                        myCmd2.ExecuteNonQuery()

                        myCmd.Parameters.Clear()
                        myCmd2.Parameters.Clear()
                    End If

                Next

                myCmd4.Parameters.Clear()
                myCmd5.Parameters.Clear()
                myCmd6.Parameters.Clear()

                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Purchased Order Change Complete!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                btnClear.PerformClick()

            End If

        End If

        conn.Close()

    End Sub

    Public Sub ND()
        If RTTPO.Value <> "" Then
            If RTTPO.Value <> 0 Then
                RTTotal.Value = RTTPO.Value - RTUPrice.Text
                RTD.Value = (RTUPrice.Value / RTTPO.Value) * 100
            End If
        End If
    End Sub

    Private Sub RTTPO_TextChanged(sender As Object, e As EventArgs) Handles RTTPO.TextChanged
        ND()
    End Sub

    Private Sub RTD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTD.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            If RTTPO.Value <> 0 Then
                RTUPrice.Text = ((RTTPO.Text * RTD.Text) / 100)
            End If

            ' btnCPO.Enabled = True
        Else

        End If
    End Sub

    Private Sub RTD_Leave(sender As Object, e As EventArgs) Handles RTD.Leave
        RTUPrice.Text = ((RTTPO.Text * RTD.Text) / 100)

        ' btnCPO.Enabled = True
    End Sub

    Private Sub RTUPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTUPrice.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            If RTTPO.Value <> 0 Then
                RTD.Value = (RTUPrice.Value / RTTPO.Value) * 100
            End If
        Else

        End If
    End Sub

    Private Sub RTUPrice_TextChanged(sender As Object, e As EventArgs) Handles RTUPrice.TextChanged
        ND()
    End Sub

    Private Sub RTD_TextChanged(sender As Object, e As EventArgs) Handles RTD.TextChanged
        If RTD.Value > 100 Then
            RTD.Value = 100
            RTUPrice.Text = RTTPO.Text
            RTTotal.Value = RTTPO.Value - RTUPrice.Text
        End If
        ' RTUPrice.Text = ((RTTPO.Text * RTD.Text) / 100)
        '  btnCPO.Enabled = False
    End Sub

   
    Private Sub rgvPOList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvPOList.SelectionChanged
        Try

            ddlSupSap.Text = rgvPOList.CurrentRow.Cells("fldSupplier").Value.ToString
            txtSupName.Text = rgvPOList.CurrentRow.Cells("fldSupplier").Value.ToString 'hidden txtbox
            txtVenCode.Text = rgvPOList.CurrentRow.Cells("fldVCode").Value.ToString
            txtCurrency.Text = rgvPOList.CurrentRow.Cells("fldCurrency").Value.ToString
            'dtpMOrder.Value = rgvPOList.CurrentRow.Cells("fldMOrdered").Value.ToString

            RTTPO.Text = rgvPOList.CurrentRow.Cells("fldTPO").Value.ToString
            RTUPrice.Text = rgvPOList.CurrentRow.Cells("fldDAmount").Value.ToString
            RTD.Text = rgvPOList.CurrentRow.Cells("fldDiscount").Value.ToString
            RTTotal.Text = rgvPOList.CurrentRow.Cells("OB_POAmt").Value.ToString
            txtRemarks.Text = rgvPOList.CurrentRow.Cells("fldRemarks").Value.ToString

            bwLoadDataPOI.RunWorkerAsync()

            If rgvPOList.CurrentRow.Cells("fldIndex").Value <= 0 Then
                ddlCancel.Enabled = False
                ddlCancel.SelectedValue = "NO"
                btnPrintPOC.Enabled = False
            Else
                ddlCancel.Enabled = True
                ddlCancel.SelectedValue = "NO"
                btnPrintPOC.Enabled = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPrintPOC_Click(sender As Object, e As EventArgs) Handles btnPrintPOC.Click
        reporttype = 7

        dt.Rows.Clear()
        dt.Columns.Clear()

        dt.Columns.Add("ITEM_CODE", GetType(String))
        dt.Columns.Add("DESCRIPTION", GetType(String))
        dt.Columns.Add("NEW_PRICE", GetType(Decimal))

        frmReport.Show()
        frmReport.ReportViewer1.Refresh()
        frmReport.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ddlVenCode_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlVenCode.SelectedIndexChanged
        GetCurSap_POC()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            bwLoadDataPO.RunWorkerAsync()
            Me.Cursor = Cursors.WaitCursor
            pbOlrayt.Visible = True
            imBusy = True
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        End Try
    End Sub
End Class

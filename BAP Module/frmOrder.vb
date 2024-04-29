Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmOrder

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private dtLoadDataPRItem As DataTable
    Private dtLoadData4 As DataTable

    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub frmOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadData.IsBusy Then
                bwLoadData.CancelAsync()
                imBusy = False
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTo.Value = String.Format("{0:yyyy-MM-dd}", Today)
        dtpFrom.Value = String.Format("{0:yyyy-MM-dd}", (DateTime.Now.AddDays(-7)))
        imBusy = True

        'moveCtrl = New MoveControl(Me) '----- MOVEABLE FORM -----'
        txtSignature.ReadOnly = True


        DepartmentOrder()
        ClassificationOrder()
        ProcessOrder()

        UID = SelectedDetails

        ddlStat.Text = "OPEN"
        txtReason.Enabled = False

        GetBRNumData()

        ddlBRNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlBRNum.AutoCompleteDataSource = AutoCompleteSource.CustomSource

        Readybtn()

        GetUser()

        ReadyGrid()
        ReadyPRGrid()

        dtpMDelivery.Value = Today
        dtpMOrder.Value = Today




        If txtPRNum.Text = "" Then
            btnPrintPR.Enabled = False
        End If

        Clear()

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

        ddlDept.Text = drUser.Item("fldDept").ToString

    End Sub

    Private Sub Readybtn()

        chkNewOrder.Enabled = True

        'btnSaveOrder.Enabled = False
        ' btnCopyTo.Enabled = False
        btnClear.Enabled = True
        btnRefresh.Enabled = True

        'btnSaveOrder.Visible = True
        'btnUpdate.Visible = False

        mebJPYAmount.ReadOnly = False

    End Sub

    Private Sub ReadyAddNewOrder()
        txtPONum.Enabled = True
        txtPRNum.Enabled = True
        dtpMOrder.Enabled = True
        txtSupplier.Enabled = True
        txtDesc.Enabled = True
        ddlClass.Enabled = True
        ddlDept.Enabled = True
        ddlProcess.Enabled = True
        mebJPYAmount.Enabled = True '
        txtReason.Enabled = False
        Remarks.Enabled = True
    End Sub

    Private Sub GetDeptData()
        Try
            dtLoadData2 = Chinita.fetchDBTable("SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN' AND fldDept = '" & ddlDept.Text & "'")
        Catch ex As Exception

        End Try

        ddlBRNum.DataSource = dtLoadData2
        ddlBRNum.DisplayMember = "fldBudRefNum"
        ddlBRNum.ValueMember = "fldBudRefNum"
        ddlBRNum.Text = ""

    End Sub

    Private Sub frmOrder_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        Me.Cursor = Cursors.WaitCursor
        bwLoadData.RunWorkerAsync()
        pbOlrayt.Visible = True
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        Dim FMONTH As Date = dtpFrom.Value
        Dim FYEAR As Date = dtpTo.Value
        Dim DEPT As String = lblDept.Text

        imBusy = True

        If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Or lblUserlvl.Text = "MANAGER" Or lblUserlvl.Text = "PROFESSIONAL" Then
            dtLoadData = Chinita.fetchDBTable("call PR_GetPRAdmin('" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", FMONTH)) & "', '" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", FYEAR)) & "')")
        Else
            dtLoadData = Chinita.fetchDBTable("call PR_GetPRNonAdmin('" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", FMONTH)) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", FYEAR)) & "','" & DEPT & "')")
        End If

        For counter As Integer = 0 To dtLoadData.Rows.Count - 1

            Dim x As Double = counter / dtLoadData.Rows.Count * 100
            bwLoadData.ReportProgress(x)
            Threading.Thread.Sleep(Delay)

        Next

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        pbOlrayt.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        Try
            rgvList.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOlrayt.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReadyGrid()

        Dim fldOIDColumn As New GridViewDecimalColumn("ID")
        With fldOIDColumn
            .FieldName = "fldOrderID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldOIDColumn)

        Dim fldTransCodeColumn As New GridViewDecimalColumn("TransCode")
        With fldTransCodeColumn
            .FieldName = "fldTransCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldTransCodeColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim PrintMe As New GridViewCommandColumn("Print PR")
        With PrintMe
            .FieldName = "Print PR"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "Print PR"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(PrintMe)

        Dim fldPrintSum As New GridViewCommandColumn("Print")
        With fldPrintSum
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .UseDefaultText = True
            .DefaultText = "Summary"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvList.Columns.Add(fldPrintSum)

        Dim fldPRNumColumn As New GridViewTextBoxColumn("PR NUMBER")
        With fldPRNumColumn
            .FieldName = "fldPRNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = Left
        End With
        rgvList.Columns.Add(fldPRNumColumn)

        Dim fldMOrderedColumn As New GridViewDateTimeColumn("MONTH ORDERED")
        With fldMOrderedColumn
            .FieldName = "fldMonthOrder"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMOrderedColumn)
        rgvList.Columns("fldMonthOrder").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDescriptionColumn As New GridViewTextBoxColumn("DESCRITION")
        With fldDescriptionColumn
            .FieldName = "fldOrderDesc"
            .Width = 300
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDescriptionColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClassification"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldOrderDepartment"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldProcessColumn)

        'Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        'With fldCurrencyColumn
        '    .FieldName = "fldCurrency"
        '    .Width = 65
        '    .TextAlignment = ContentAlignment.MiddleCenter
        'End With
        'rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldRQTYColumn As New GridViewTextBoxColumn("REMAINING QUANTITY")
        With fldRQTYColumn
            .FieldName = "RQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldRQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldMDeliveryColumn As New GridViewDateTimeColumn("MONTH OF DELIVERY")
        With fldMDeliveryColumn
            .FieldName = "fldMonthDelivery"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMDeliveryColumn)
        rgvList.Columns("fldMonthOrder").FormatString = "{0:MMM dd, yyyy}"

        Dim fldStatusColumn As New GridViewComboBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "fldOrderStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE", "REMOVED"}
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldStatusColumn)

        Dim myStatColumn As New GridViewComboBoxColumn("myStat")
        With myStatColumn
            .FieldName = "myStat"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE", "REMOVED"}
            .IsVisible = False
        End With
        rgvList.Columns.Add(myStatColumn)

        Dim fldReasonColumn As New GridViewDecimalColumn("Reason")
        With fldReasonColumn
            .FieldName = "fldReason"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldReasonColumn)

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldOrderRemarks"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRemarksColumn)

        Dim fldEOAColumn As New GridViewDecimalColumn("ESTIMATED PR AMOUNT")
        With fldEOAColumn
            .FieldName = "fldEOA"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldEOAColumn)
        rgvList.Columns("fldEOA").FormatString = "{0:N6}"

        Dim fldECColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldECColumn
            .FieldName = "fldEC"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldECColumn)

        Dim fldEJPYColumn As New GridViewDecimalColumn("ESTIMATED PR AMOUNT (JPY)")
        With fldEJPYColumn
            .FieldName = "fldEJPY"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldEJPYColumn)
        rgvList.Columns("fldEJPY").FormatString = "{0:N6}"

        Dim fldTOPRAColumn As New GridViewDecimalColumn("OPEN PR AMOUNT")
        With fldTOPRAColumn
            .FieldName = "fldTOPRA"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTOPRAColumn)
        rgvList.Columns("fldTOPRA").FormatString = "{0:N6}"

        Dim fldTDOPRAColumn As New GridViewDecimalColumn("OPEN DEPT. PR AMOUNT")
        With fldTDOPRAColumn
            .FieldName = "fldTDOPRA"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTDOPRAColumn)
        rgvList.Columns("fldTDOPRA").FormatString = "{0:N6}"

        Dim fldRBLPRColumn As New GridViewDecimalColumn("RBLPR")
        With fldRBLPRColumn
            .FieldName = "fldRBLPR"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldRBLPRColumn)
        rgvList.Columns("fldRBLPR").FormatString = "{0:N6}"

        Dim fldRDBLPRColumn As New GridViewDecimalColumn("RDBLPR")
        With fldRDBLPRColumn
            .FieldName = "fldRDBLPR"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldRDBLPRColumn)
        rgvList.Columns("fldRDBLPR").FormatString = "{0:N6}"

        Dim fldRBColumn As New GridViewDecimalColumn("RB")
        With fldRBColumn
            .FieldName = "fldRB"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldRBColumn)
        rgvList.Columns("fldRB").FormatString = "{0:N6}"

        Dim fldRDBColumn As New GridViewDecimalColumn("RDB")
        With fldRDBColumn
            .FieldName = "fldRDB"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldRDBColumn)
        rgvList.Columns("fldRDB").FormatString = "{0:N6}"

        Dim fldTPRO As New GridViewDecimalColumn("TotalPRO")
        With fldTPRO
            .FieldName = "TPRO"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTPRO)
        rgvList.Columns("TPRO").FormatString = "{0:N6}"

        Dim fldRNColumn As New GridViewTextBoxColumn("REIMBURSEMENT NO.")
        With fldRNColumn
            .FieldName = "fldRN"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldRNColumn)

        Dim fldSignatureColumn As New GridViewTextBoxColumn("SIGNATURE")
        With fldSignatureColumn
            .FieldName = "fldSignature"
            .Width = 180
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSignatureColumn)

        Dim fldPrint As New GridViewTextBoxColumn("Print")
        With fldPrint
            .FieldName = "fldPrint"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPrint)

        Dim fldDeleteColumn As New GridViewCommandColumn("    ")
        With fldDeleteColumn
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .UseDefaultText = True
            .DefaultText = "REMOVE"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With

        Dim fldPOCountColumn As New GridViewTextBoxColumn("POCount")
        With fldPOCountColumn
            .FieldName = "POCount"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter

        End With
        rgvList.Columns.Add(fldPOCountColumn)

        Dim fldMoldDie As New GridViewTextBoxColumn("Mold Die Name")
        With fldMoldDie
            .FieldName = "fldMoldDie"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter

        End With
        rgvList.Columns.Add(fldMoldDie)





        AddHandler rgvList.CommandCellClick, AddressOf CloseItem
        rgvList.Columns.Add(fldDeleteColumn)


        'Dim fldTotal As New GridViewSummaryItem("fldBudRefNum", "TOTAL", GridAggregateFunction.Var)
        'Dim fldOrigAmount As New GridViewSummaryItem("fldAmountJPY", "{0:N2}", GridAggregateFunction.Sum)
        'Dim fldYEN As New GridViewSummaryItem("YEN", "{0:N2}", GridAggregateFunction.Sum)
        'Dim fldPHP As New GridViewSummaryItem("PHP", "{0:N2}", GridAggregateFunction.Sum)
        'Dim fldUSD As New GridViewSummaryItem("USD", "{0:N2}", GridAggregateFunction.Sum)

        'Dim SummaryRowItem As New GridViewSummaryRowItem()
        'SummaryRowItem.Add(fldTotal)
        'SummaryRowItem.Add(fldOrigAmount)
        'SummaryRowItem.Add(fldYEN)
        'SummaryRowItem.Add(fldPHP)
        'SummaryRowItem.Add(fldUSD)

        'rgvList.SummaryRowsBottom.Add(SummaryRowItem)

        '-----GRID PROPERTIES-----'

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
            '.SummaryRowsBottom.Add(SummaryRowItem)
        End With

    End Sub

    Private Sub GetData()

        'Clear()

        Try
            lblOrderID.Text = rgvList.CurrentRow.Cells("fldOrderID").Value.ToString
            txtTC.Text = rgvList.CurrentRow.Cells("fldTransCode").Value.ToString
            ddlBRNum.Text = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            txtPRNum.Text = rgvList.CurrentRow.Cells("fldPRNo").Value.ToString
            dtpMOrder.Value = rgvList.CurrentRow.Cells("fldMonthOrder").Value.ToString
            txtDesc.Text = rgvList.CurrentRow.Cells("fldOrderDesc").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("fldClassification").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldOrderDepartment").Value.ToString
            ddlProcess.Text = rgvList.CurrentRow.Cells("fldProcess").Value.ToString
            ' ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
            mebQTY.Text = rgvList.CurrentRow.Cells("fldQTY").Value.ToString
            mebRemQTY.Text = rgvList.CurrentRow.Cells("RQTY").Value.ToString
            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            dtpMDelivery.Value = rgvList.CurrentRow.Cells("fldMonthDelivery").Value.ToString
            ddlStat.Text = rgvList.CurrentRow.Cells("fldOrderStatus").Value.ToString
            Remarks.Text = rgvList.CurrentRow.Cells("fldOrderRemarks").Value.ToString
            txtReason.Text = rgvList.CurrentRow.Cells("fldReason").Value.ToString

            mebAmount.Text = rgvList.CurrentRow.Cells("fldEOA").Value.ToString
            mebEPA.Text = rgvList.CurrentRow.Cells("fldEJPY").Value.ToString
            ddlCurrency.Text = rgvList.CurrentRow.Cells("fldEC").Value.ToString

            mebTOPRA.Text = rgvList.CurrentRow.Cells("fldTOPRA").Value.ToString
            mebTOPDRA.Text = rgvList.CurrentRow.Cells("fldTDOPRA").Value.ToString
            mebRemBLPR.Text = rgvList.CurrentRow.Cells("fldRBLPR").Value.ToString
            mebRemDBLPR.Text = rgvList.CurrentRow.Cells("fldRDBLPR").Value.ToString
            mebRemBud.Text = rgvList.CurrentRow.Cells("fldRB").Value.ToString
            RemDeptBud.Text = rgvList.CurrentRow.Cells("fldRDB").Value.ToString
            txtRN.Text = rgvList.CurrentRow.Cells("fldRN").Value.ToString
            txtMoldDie.Text = rgvList.CurrentRow.Cells("fldMoldDie").Value.ToString

            TPRO()
            '  RemBudOrder()

            ' GetMultiOrder()

            If ddlStat.Text = "CLOSE" Then
                ddlBRNum.Enabled = False
                ddlDept.Enabled = False
                mebJPYAmount.Enabled = False
                ddlStat.Enabled = False

                btnCPO.Enabled = False
            Else
                ddlBRNum.Enabled = False
                ddlStat.Enabled = True
                ddlDept.Enabled = False
                mebJPYAmount.Enabled = True

                btnCPO.Enabled = True
            End If

            txtReason.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReadyPRGrid()

        Dim fldUC4SColumn As New GridViewTextBoxColumn("UC4S")
        With fldUC4SColumn
            .FieldName = "fldUC4S"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldUC4SColumn)

        Dim fldMOIIDColumn As New GridViewTextBoxColumn("MOIID")
        With fldMOIIDColumn
            .FieldName = "fldMOIID"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldMOIIDColumn)

        Dim fldTransCodeColumn As New GridViewTextBoxColumn("TransCode")
        With fldTransCodeColumn
            .FieldName = "fldTransCode"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldTransCodeColumn)

        Dim fldBudRefNumColumn As New GridViewTextBoxColumn("BUDGET REF. NO.")
        With fldBudRefNumColumn
            .FieldName = "fldBudRefNum"
            .Width = 160
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
            .ReadOnly = True
        End With
        rgvListItem.Columns.Add(fldBudRefNumColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldICodeColumn
            .FieldName = "fldICode"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 250
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("PR QTY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldQTYColumn)

        Dim fldQTYEBColumn As New GridViewTextBoxColumn("REMAINING QTY")
        With fldQTYEBColumn
            .FieldName = "fldQTYEB"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldQTYEBColumn)

        Dim fldQTYSOUTColumn As New GridViewTextBoxColumn("PO QTY")
        With fldQTYSOUTColumn
            .FieldName = "fldQTYSOUT"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldQTYSOUTColumn)

        Dim fldUnitColumn As New GridViewTextBoxColumn("UNIT")
        With fldUnitColumn
            .FieldName = "fldUnit"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldUnitColumn)

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "fldStat"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            .IsPinned = Right
        End With
        rgvListItem.Columns.Add(fldStatColumn)

        Dim fldRSColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRSColumn
            .FieldName = "fldRS"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvListItem.Columns.Add(fldRSColumn)

        'Dim fldDeleteColumn As New GridViewCommandColumn("    ")
        'With fldDeleteColumn
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 50
        '    .UseDefaultText = True
        '    .DefaultText = "REMOVE"
        '    .IsPinned = True
        '    .PinPosition = PinnedColumnPosition.Right
        'End With

        'AddHandler rgvListItem.CommandCellClick, AddressOf CloseItem
        'rgvListItem.Columns.Add(fldDeleteColumn)

        With rgvListItem
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
            ' .SummaryRowsBottom.Add(SummaryRowItem)

        End With

    End Sub
    Public Sub TOPDRA()
        Dim RDBBPR As Decimal = RemDeptBud.Value
        Dim EPRA As Decimal = Cookies
        Dim RDBLPR As Decimal = mebRemDBLPR.Text
        'Dim TOPDRA As Decimal
        Dim PR As String = txtPRNum.Text
        Dim MOrder As Date = dtpMOrder.Text
        Dim Dept As String = ddlDept.Text

        MyGlobal.Remarks = Remarks.Text

        MyGlobal.DeptBud = RemDeptBud.Text

        MyGlobal.MoldDie = txtMoldDie.Text

        MyGlobal.RemDBLPR = mebRemDBLPR.Text

        MyGlobal.Currency = ddlCurrency.Text

        MyGlobal.PR = PR
        MyGlobal.MajorBud = ddlBRNum.Text


        'Me.ReportParameters("PR").Value = txtPRNum.Text

        MyGlobal.TOPDRA = RDBBPR - EPRA - RDBLPR
        'txtTOPDRA.Value = String.Format("{0:N2}", TOPDRA)
    End Sub
    Private Sub CloseItem()
        If rgvList.CurrentColumn.HeaderText = "Print PR" Then
            If rgvList.CurrentRow.Cells("fldPrint").Value.ToString = "NO" Then

                RadMessageBox.Show("Please select the latest PR", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Else
                Dim myCmd As New MySqlCommand
                Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
                reporttype = 15

                TPRO()
                TOPDRA()
                MyGlobal.PRNo = rgvList.CurrentRow.Cells("fldPRNo").Value
                '------------------------------------PRINT PR------------------------------------------
                Try

                    conn.Open()
                    myCmd.Connection = conn

                    myCmd.CommandText = "INSERT INTO `tblPrintPR`(`fldPRNo`) VALUES('" & rgvList.CurrentRow.Cells("fldPRNo").Value & "');"

                    myCmd.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    conn.Close()
                End Try
                '-------------------------------------------------------------------------------------
                '-------------------------------------GetPrintValues----------------------------------
                Dim drPR As DataRow = Chinita.fetchMySqlRow("select fldPrinted from tblPrintPR where fldPRNo = '" & rgvList.CurrentRow.Cells("fldPRNo").Value & "'")
                MyGlobal.PrintStat = drPR.Item("fldPrinted").ToString
                '-------------------------------------------------------------------------------------
                globalVariables.PassBudRefNo = rgvList.CurrentRow.Cells("fldBudRefNum").Value

                Try
                    reporttype = 1
                    FrmPRReport.Show(Me)
                    'FrmPRReport.ReportViewer1.Refresh()

                Catch ex As Exception
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                End Try

                'Try
                '    reporttype = 4
                '    FrmReportServer.Show()
                'Catch ex As Exception
                '    RadMessageBox.SetThemeName("Windows8")
                '    RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                'End Try

                'frmReport.Show(Me)
                'frmReport.ReportViewer1.Refresh()
                'frmReport.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
            End If



        ElseIf rgvList.CurrentColumn.HeaderText = "    " Then
            Dim myCmd As New MySqlCommand
            Dim myCmd2 As New MySqlCommand
            Dim myData As New DataTable
            Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

            If rgvListItem.CurrentRow.Cells("fldStat").Value = "REMOVED" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Item is Already Removed!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf rgvListItem.CurrentRow.Cells("fldStat").Value = "CLOSE" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Item is Already Close!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else

                If rgvListItem.SelectedRows.Count > 0 Then
                    RadMessageBox.SetThemeName("Windows8")
                    If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to remove this Order?",
                                      "Remove Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                        Try

                            If rgvList.CurrentRow.Cells("POCount").Value > 0 Then
                                RadMessageBox.SetThemeName("Windows8")
                                RadMessageBox.Show("This PR already have PO!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                            Else
                                conn.Open()
                                myCmd.Connection = conn

                                myCmd.CommandText = "update tblOrder set fldOrderStatus = 'REMOVED' where fldOrderID = '" & rgvList.CurrentRow.Cells("fldOrderID").Value & "'; " _
                                & "update tblMOI set fldStat = 'REMOVED' where fldTransCode = '" & rgvList.CurrentRow.Cells("fldTransCode").Value & "';" _
                                & "UPDATE tblPRNo set fldStat = 'REMOVED' where fldPRKey = right('" & rgvList.CurrentRow.Cells("fldPRNo").Value & "',6);"

                                myCmd.ExecuteNonQuery()
                                conn.Close()

                                '-------------------------Remove Investment---------------
                                conn.Open()
                                myCmd2.Connection = conn
                                myCmd2.CommandText = "UPDATE `tblInvestmentRecord` SET `fldStatus` = 'PR REMOVED' WHERE fldPRNo = '" & rgvList.CurrentRow.Cells("fldPRNo").Value & "';"

                                myCmd2.ExecuteNonQuery()
                                conn.Close()
                                '---------------------------------------------------------
                                RadMessageBox.SetThemeName("Windows8")
                                RadMessageBox.Show("Remove Complete", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)


                            End If

                        Catch ex As Exception

                        End Try

                        bwLoadData.RunWorkerAsync()
                        bwLoadData2.RunWorkerAsync()

                    End If

                Else
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Select Item to Remove")
                End If

            End If
        ElseIf rgvList.CurrentColumn.HeaderText = "Print" Then
            globalVariables.PassBudRefNo = rgvList.CurrentRow.Cells("fldBudRefNum").Value
            Try
                reporttype = 2
                FrmPRReport.Show(Me)

            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try
        End If



    End Sub

    Private Sub Enable()

        ddlStat.Enabled = True

    End Sub

    Private Sub Clear()
        ddlDept.Text = ""
        ddlBRNum.Text = ""
        txtPRNum.Text = ""
        txtRN.Text = ""
        txtDesc.Text = ""

        ddlClass.Text = ""

        ddlProcess.Text = ""
        mebQTY.Text = ""
        mebRemQTY.Text = ""
        ddlUOM.Text = ""
        ddlStat.Text = ""

        txtPONum.Text = ""

        dtpMOrder.Value = Today
        txtSupplier.Text = ""


        mebJPYAmount.Text = ""
        dtpMDelivery.Value = Today

        mebRemBud.Text = ""
        Remarks.Text = ""

        txtReason.Enabled = False

        ddlBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlStat.Enabled = True

        mebAmount.Text = 0.0
        mebEPA.Text = 0.0
        mebTOPRA.Text = 0.0
        mebRemBLPR.Text = 0.0
        mebRemDBLPR.Text = 0.0

    End Sub

    Public Sub ClearOrder()

        ddlBRNum.Text = ""
        txtPONum.Text = ""
        txtPRNum.Text = ""
        dtpMOrder.Value = Today
        txtSupplier.Text = ""
        txtDesc.Text = ""
        ddlClass.Text = ""
        ddlDept.Text = ""
        ddlProcess.Text = ""
        mebQTY.Text = ""
        mebRemQTY.Text = ""
        ddlUOM.Text = ""
        mebJPYAmount.Text = ""
        dtpMDelivery.Value = Today
        ddlStat.Text = "OPEN"
        mebRemBud.Text = ""
        Remarks.Text = ""

        txtReason.Enabled = False

        ddlBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlStat.Enabled = True

        mebAmount.Text = 0.0
        mebEPA.Text = 0.0
        mebTOPRA.Text = 0.0
        mebRemBLPR.Text = 0.0
        mebRemDBLPR.Text = 0.0

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        If bwLoadData.IsBusy Then
            bwLoadData.CancelAsync()
            imBusy = False
        End If
        Me.Close()
        frmOrderPicker.rbMO.IsChecked = False
        frmOrderPicker.rbSO.IsChecked = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()

        rgvList.FilterDescriptors.Clear()
        'Readybtn()

        'Try
        '    bwLoadData.RunWorkerAsync()
        'Catch ex As Exception
        '    RadMessageBox.Show("Already Refreshed!", "Refresh", MessageBoxButtons.OK, RadMessageIcon.Info)
        'End Try

        'chkNewOrder.Checked = False

    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        btnpicker = 1

        Dim match = String.Compare(ddlDept.Text, lblDept.Text, ignoreCase:=False)

        If String.IsNullOrEmpty(ddlBRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Budget Reference Number Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlDept.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Department Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlClass.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Classification Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlProcess.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Process Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Description", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(Remarks.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Remarks", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf mebJPYAmount.Value = 0.0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf ddlDept.Text = "ALL" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Select Department", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else

            If ddlStat.Text = "CLOSE" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Cannot Add Order with CLOSE Status!", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            ElseIf Not match = 0 Then
                RadMessageBox.SetThemeName("Windows8")
                If RadMessageBox.Show("This Budget is from another Department. Are you sure you want to use it for your Order?",
                                    "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    frmConfirmUsers.Show(Me)

                End If

            Else

                If Tomboy.AddOrder(ddlBRNum.Text, txtPONum.Text, txtPRNum.Text, _
                               dtpMOrder.Value, txtSupplier.Text, txtDesc.Text, _
                               ddlClass.Text, ddlDept.Text, ddlProcess.Text, _
                               mebQTY.Text, ddlUOM.Text, _
                               ddlCurrency.Text, mebJPYAmount.Text, dtpMDelivery.Value, ddlStat.Text, _
                               txtReason.Text, Remarks.Text, txtSignature.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK)
                    Clear()
                    bwLoadData.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            bwLoadData.RunWorkerAsync()
            rgvList.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetBRNumData()
        Try

            dtLoadData2 = Chinita.fetchDBTable("SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN'")

        Catch ex As Exception

        End Try

        ddlBRNum.DataSource = dtLoadData2
        ddlBRNum.Text = ""
        ddlBRNum.DisplayMember = "fldBudRefNum"
        ddlBRNum.ValueMember = "fldBudRefNum"

    End Sub

    Private Sub ReadyOrder()
        If chkNewOrder.Checked = True Then
            Clear()

            Readybtn()
            ReadyAddNewOrder()

            btnSaveOrder.Enabled = True

        ElseIf chkNewOrder.Checked = False Then
            Clear()

            Readybtn()

        End If
    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlBRNum.SelectedIndexChanged

        Try
            RemBudOrder()
            OrderInfo()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkNewOrder_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkNewOrder.ToggleStateChanged

        ReadyOrder()

        ddlStat.Text = "OPEN"
    End Sub

    Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick
        GetData()
        GetMultiOrder()
        btnPrintPR.Enabled = True
       
        Try
            If rgvList.CurrentRow.Cells("fldPrint").Value.ToString = "NO" Then

                btnPrintPR.Enabled = False
            Else
                btnPrintPR.Enabled = True
            End If
            btnSaveOrder.Visible = False
            chkNewOrder.Enabled = False
            bwLoadData2.RunWorkerAsync()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeductPR()
        
        Try
            mebRemBLPR.Value = Convert.ToDecimal(mebRemBud.Value) - Convert.ToDecimal(mebEPA.Value)

            mebRemDBLPR.Value = Convert.ToDecimal(RemDeptBud.Value) - Convert.ToDecimal(mebTOPDRA.Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TOEA()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY', " _
            & "(SELECT if(PRD.fldEJPY is not null,sum(PRD.fldEJPY),0) FROM tblOrder PRD " _
            & "where PR.fldOrderStatus = 'OPEN' and fldOrderDepartment = '" & ddlDept.Text & "') as 'TDJPY' FROM tblOrder PR " _
            & "where (select count(MO.fldTransCode) from tblMOI MO " _
            & "where MO.fldTransCode = PR.fldTransCode and MO.fldStat = 'OPEN') != 0 and PR.fldBudRefNum = '" & ddlBRNum.Text & "'"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        mebTOPRA.Text = myData.Rows(0).Item("TJPY")
        mebTOPDRA.Text = myData.Rows(0).Item("TDJPY")

    End Sub

    '----- KEYPRESS OF DROP DOWN LIST -----'

    Private Sub ddlBRNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlBRNum.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlDept_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyFilter(sender, e)
    End Sub

    Private Sub ddlClass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlClass.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlProcess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlProcess.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlStat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlStat.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlDept_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlDept.SelectedIndexChanged

        GetDeptData()

        txtSupplier.Text = ""
        txtDesc.Text = ""
        ddlClass.Text = ""
        ddlProcess.Text = ""
        mebQTY.Text = ""
        mebRemQTY.Text = ""
        ddlUOM.Text = ""
        mebJPYAmount.Text = ""
        mebRemBud.Text = ""
        dtpMDelivery.Value = Today
        ddlStat.Text = "OPEN"

    End Sub

    Private Sub CurrencyRate()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim CCode As String = ""


        If (ddlCurrency.Text = "PHP") Then
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE `fldcurrency` = 'JPY-PHP'"
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

        ElseIf (ddlCurrency.Text = "USD") Then
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE `fldcurrency` = 'USD-JPY'"
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)
        End If

        If (ddlCurrency.Text = "PHP") Then
            If String.IsNullOrEmpty(mebAmount.Text) = False Then
                mebEPA.Text = mebAmount.Text / myData.Rows(0).Item("fldAmount")
            End If

        ElseIf (ddlCurrency.Text = "USD") Then
            If String.IsNullOrEmpty(mebAmount.Text) = False Then
                mebEPA.Text = mebAmount.Text * myData.Rows(0).Item("fldAmount")
            End If

        ElseIf (ddlCurrency.Text = "JPY") Then
            If String.IsNullOrEmpty(mebAmount.Text) = False Then
                mebEPA.Text = mebAmount.Text
            End If

        Else
            If String.IsNullOrEmpty(mebAmount.Text) = False Then
                mebEPA.Text = 0
            End If

        End If

        conn.Close()

    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        CurrencyRate()
    End Sub

    Private Sub mebJPYAmount_TextChanged(sender As Object, e As EventArgs) Handles mebJPYAmount.TextChanged
        CurrencyRate()
    End Sub

    Private Sub btnCPO_Click(sender As Object, e As EventArgs) Handles btnCPO.Click

        Dim dtcsv As New DataTable
        dtcsv.Columns.Add("BUDGET_REFERENCE_NO.")
        dtcsv.Columns.Add("MONTH_ORDER")

        Dim csvgrid As New DataGridView
        Me.Controls.Add(csvgrid)
        csvgrid.Visible = False
        Dim br As New GridViewTextBoxColumn()
        br.FieldName = "BUDGET_REFERENCE_NO."

        Dim mo As New GridViewTextBoxColumn()
        mo.FieldName = "MONTH_ORDER"

        Dim brnum As String = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
        Dim mon As Date = Convert.ToDateTime(rgvList.CurrentRow.Cells("fldMonthOrder").Value.ToString)
        dtcsv.Rows.Add(brnum, mon)

        csvgrid.DataSource = dtcsv
        Dim headers = (From header As DataGridViewColumn In csvgrid.Columns.Cast(Of DataGridViewColumn)() Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In csvgrid.Rows.Cast(Of DataGridViewRow)() Where Not row.IsNewRow Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Dim str As String = ""
        Dim fileName As String = My.Settings.Path & "\upload.csv"
        Using sw As New IO.StreamWriter(fileName)
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
            sw.Close()
        End Using

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Purchased Order Created", "Notification", MessageBoxButtons.OK)


    End Sub

    Private Sub bwLoadData2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData2.RunWorkerCompleted
        rgvListItem.DataSource = dtLoadDataPRItem
    End Sub

    Private Sub mebRemBud_ValueChanged(sender As Object, e As EventArgs) Handles mebRemBud.ValueChanged
        If mebRemBud.Value < 0 Then
            mebRemBud.BackColor = Color.Orange
        Else
            mebRemBud.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub rgvList_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles rgvList.RowFormatting
        If e.RowElement.RowInfo.Cells("myStat").Value = "REMOVED" Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.Pink

        Else
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.Transparent

        End If
    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        Try
            GetData()
            ' RemQTY()
            GetMultiOrder()
            GetRemDeptBud()
            'TOEA()
            'btnUpdate.Visible = True
            btnSaveOrder.Visible = False
            chkNewOrder.Enabled = False
            'bwLoadData2.RunWorkerAsync()

            If txtPRNum.Text <> "" Then
                btnPrintPR.Enabled = True
            Else
                btnPrintPR.Enabled = False
            End If

            bwLoadData2.RunWorkerAsync()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadData2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData2.DoWork
        Try
            Dim TransCode As String = rgvList.CurrentRow.Cells("fldTransCode").Value

            dtLoadDataPRItem = Chinita.fetchDBTable("call PR_GetPRItems('" & TransCode & "')")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GetRemDeptBud()

        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim drYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
        Dim drYearNow As String = drYear.Item("fldLimit").ToString

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select if(tr1.fldYen is not null,sum(tr1.fldYen),0) - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) from tblUPO UPO " _
                   & "where UPO.fldDept = '" & ddlDept.Text & "' AND year(UPO.fldDDate) = '" & drYearNow & "') - " _
                   & "(" _
                   & "SELECT if(tr2.fldYen is not null,sum(tr2.fldYen),0)FROM tblPOI tr2 where tr2.fldDept = '" & ddlDept.Text & "' and tr2.fldStat != 'CLOSE' " _
                   & ") as 'RemBudget' " _
                   & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
                   & "where tr1.fldStat != 'CLOSE' and tr7.fldDept = '" & ddlDept.Text & "' "

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)
        conn.Close()
        RemDeptBud.Text = myData.Rows(0).Item("RemBudget")


    End Sub

    Private Sub btnPrintPR_Click(sender As Object, e As EventArgs) Handles btnPrintPR.Click
        reporttype = 15

        TPRO()

        frmReport.Show(Me)
        frmReport.ReportViewer1.Refresh()
        frmReport.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
    End Sub

    Private Sub mebAmount_TextChanged(sender As Object, e As EventArgs) Handles mebAmount.TextChanged
        CurrencyRate()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TPRO()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "SELECT if(PRD.fldEJPY is not null,sum(PRD.fldEJPY),0) as TPRO FROM tblOrder PRD " _
            & "where PRD.fldOrderStatus = 'OPEN' " _
            & "and PRD.fldPRNo = '" & rgvList.CurrentRow.Cells("fldPRNo").Value.ToString & "'"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)
        conn.Close()

        Cookies = myData.Rows(0).Item("TPRO")

    End Sub

    Public Cookies As Decimal

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            bwLoadData.RunWorkerAsync()
            Me.Cursor = Cursors.WaitCursor
            pbOlrayt.Visible = True
            imBusy = True
        Catch ex As Exception

        End Try

    End Sub

 

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dtLoadData4 = Chinita.fetchDBTable("call SP_SelectPRNoForViewPR('" & txtSearchPR.Text & "')")
        rgvList.DataSource = dtLoadData4
    End Sub

    Private Sub txtExistingPR_Click(sender As Object, e As EventArgs) Handles txtExistingPR.Click
        rgvList.DataSource = dtLoadData
    End Sub
End Class
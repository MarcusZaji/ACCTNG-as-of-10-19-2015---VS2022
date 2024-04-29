Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmOrder

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '----- MOVEABLE FORM -----'
        txtSignature.ReadOnly = True

        DepartmentOrder()
        ClassificationOrder()
        ProcessOrder()

        UID = SelectedDetails

        dtpMDelivery.Value = Today
        dtpMOrder.Value = Today

        ddlStat.Text = "OPEN"
        txtReason.Enabled = False

        GetBRNumData()

        ddlBRNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlBRNum.AutoCompleteDataSource = AutoCompleteSource.CustomSource

        ReadyGrid()

        Readybtn()

        Clear()

        GetUser()

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
        mebJPYAmount.Enabled = True
        txtReason.Enabled = False
        txtRemarks.Enabled = True
    End Sub

    Private Sub GetDeptData()
        Try
            dtLoadData2 = Chinita.fetchDBTable("SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN' AND fldDept = '" & ddlDept.Text & "'")
        Catch ex As Exception

        End Try

        ddlBRNum.DataSource = dtLoadData2
        ddlBRNum.Text = ""
        ddlBRNum.DisplayMember = "fldBudRefNum"
        ddlBRNum.ValueMember = "fldBudRefNum"

    End Sub

    Private Sub frmOrder_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub ReadyGrid()

        Dim fldOIDColumn As New GridViewDecimalColumn("ID")
        With fldOIDColumn
            .FieldName = "fldOrderID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
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

        Dim fldPONumColumn As New GridViewTextBoxColumn("PURCHASED ORDER NO.")
        With fldPONumColumn
            .FieldName = "fldPONo"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPONumColumn)

        Dim fldPRNumColumn As New GridViewTextBoxColumn("PURCHASED REQUEST NO.")
        With fldPRNumColumn
            .FieldName = "fldPRNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
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

        Dim fldSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
        With fldSupplierColumn
            .FieldName = "fldOrderSupplier"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSupplierColumn)

        Dim fldDescriptionColumn As New GridViewTextBoxColumn("DESCRITION")
        With fldDescriptionColumn
            .FieldName = "fldOrderDesc"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDescriptionColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClassification"
            .Width = 120
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

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldAmountColumn As New GridViewTextBoxColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmountJPY"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountColumn)
        rgvList.Columns("fldAmountJPY").FormatString = "{0:N2}"

        Dim fldAmountJPYColumn As New GridViewTextBoxColumn("JPY AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "YEN"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountJPYColumn)
        rgvList.Columns("YEN").FormatString = "{0:N2}"

        Dim fldAmountPHPColumn As New GridViewTextBoxColumn("PHP AMOUNT")
        With fldAmountPHPColumn
            .FieldName = "PHP"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountPHPColumn)
        rgvList.Columns("PHP").FormatString = "{0:N2}"

        Dim fldAmountUSDColumn As New GridViewTextBoxColumn("USD AMOUNT")
        With fldAmountUSDColumn
            .FieldName = "USD"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountUSDColumn)
        rgvList.Columns("USD").FormatString = "{0:N2}"

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
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE"}
        End With
        rgvList.Columns.Add(fldStatusColumn)

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

        Dim fldTotal As New GridViewSummaryItem("fldBudRefNum", "TOTAL", GridAggregateFunction.Var)
        Dim fldOrigAmount As New GridViewSummaryItem("fldAmountJPY", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldYEN As New GridViewSummaryItem("YEN", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldPHP As New GridViewSummaryItem("PHP", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldUSD As New GridViewSummaryItem("USD", "{0:N2}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldOrigAmount)
        SummaryRowItem.Add(fldYEN)
        SummaryRowItem.Add(fldPHP)
        SummaryRowItem.Add(fldUSD)

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
            .SummaryRowsBottom.Add(SummaryRowItem)
        End With

    End Sub

    Private Sub GetData()

        'Clear()

        Try
            lblOrderID.Text = rgvList.CurrentRow.Cells("fldOrderID").Value.ToString
            txtTC.Text = rgvList.CurrentRow.Cells("fldTransCode").Value.ToString
            ddlBRNum.Text = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            txtPONum.Text = rgvList.CurrentRow.Cells("fldPONo").Value.ToString
            txtPRNum.Text = rgvList.CurrentRow.Cells("fldPRNo").Value.ToString
            dtpMOrder.Value = rgvList.CurrentRow.Cells("fldMonthOrder").Value.ToString
            txtSupplier.Text = rgvList.CurrentRow.Cells("fldOrderSupplier").Value.ToString
            txtDesc.Text = rgvList.CurrentRow.Cells("fldOrderDesc").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("fldClassification").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldOrderDepartment").Value.ToString
            ddlProcess.Text = rgvList.CurrentRow.Cells("fldProcess").Value.ToString
            ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
            mebQTY.Text = rgvList.CurrentRow.Cells("fldQTY").Value.ToString
            mebRemQTY.Text = rgvList.CurrentRow.Cells("RQTY").Value.ToString
            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            mebJPYAmount.Text = Format(rgvList.CurrentRow.Cells("fldAmountJPY").Value, "#,##0.00")
            dtpMDelivery.Value = rgvList.CurrentRow.Cells("fldMonthDelivery").Value.ToString
            ddlStat.Text = rgvList.CurrentRow.Cells("fldOrderStatus").Value.ToString
            txtRemarks.Text = rgvList.CurrentRow.Cells("fldOrderRemarks").Value.ToString
            txtReason.Text = rgvList.CurrentRow.Cells("fldReason").Value.ToString

            RemBudOrder()

            GetMultiOrder()

            If ddlStat.Text = "CLOSE" Then
                ddlBRNum.Enabled = False
                ddlDept.Enabled = False
                mebJPYAmount.Enabled = False
                ddlStat.Enabled = False

                btnUpdate.Enabled = False
                btnCopyTo.Enabled = False
                btnCPO.Enabled = False
            Else
                ddlBRNum.Enabled = False
                ddlStat.Enabled = True
                ddlDept.Enabled = False
                mebJPYAmount.Enabled = True

                btnUpdate.Enabled = True
                btnCopyTo.Enabled = True
                btnCPO.Enabled = True
            End If

            txtReason.Enabled = True


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Enable()

        ddlStat.Enabled = True
        btnCopyTo.Enabled = True

    End Sub

    Private Sub Clear()

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
        txtRemarks.Text = ""

        txtReason.Enabled = False

        ddlBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlStat.Enabled = True

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
        txtRemarks.Text = ""

        txtReason.Enabled = False

        ddlBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlStat.Enabled = True

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
        frmOrderPicker.rbMO.IsChecked = False
        frmOrderPicker.rbSO.IsChecked = False
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        ' dtLoadData = Chinita.fetchDBTable("SELECT * FROM tblOrder")

        dtLoadData = Chinita.fetchDBTable("SELECT tr3.fldTransCode, tr3.fldUOM,tr3.fldOrderID,tr3.fldBudRefNum,tr3.fldPONo,tr3.fldPRNo,tr3.fldMonthOrder " _
                                          & ",tr3.fldOrderSupplier,tr3.fldOrderDesc,tr3.fldClassification,tr3.fldReason " _
                                          & ",tr3.fldOrderDepartment,tr3.fldProcess,(if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) " _
                                          & "from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) as 'fldAmountJPY' " _
                                          & ", " _
                                          & "(" _
                                          & "select if(tr3.fldTransCode is not null,(select (if(trMOI.fldQTY is not null,sum(trMOI.fldQTY),0)) from tblMOI trMOI where trMOI.fldTransCode = tr3.fldTransCode and fldStat = 'OPEN'),tr3.fldqty)" _
                                          & ") as 'fldqty'," _
                                          & "(" _
                                          & "select if(tr1.fldQTY is not null,tr1.fldQTY,0) - " _
                                          & "((" _
                                          & "select " _
                                          & "if(tr2.fldTransCode is not null,(select IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0)" _
                                          & "from tblMOI tr4 where tr4.fldBudRefNum = tr3.fldBudRefNum and tr4.fldStat = 'OPEN'),if(tr2.fldQTY is not null,sum(tr2.fldQTY),0))" _
                                          & "from tblOrder tr2 where tr2.fldBudRefNum = tr3.fldBudRefNum and tr2.fldOrderStatus = 'OPEN'" _
                                          & ") + " _
                                          & "(" _
                                          & "select " _
                                          & "if(tr5.fldTransCode is not null,(select IF(tr6.fldQTY IS NOT NULL,sum(tr6.fldQTY),0) " _
                                          & "from tblMAI tr6 where tr6.fldBudRefNum = tr3.fldBudRefNum AND tr6.fldStat = 'OPEN'),if(tr5.fldQTY is not null,sum(tr5.fldQTY),0)) " _
                                          & "from tblActualAcquisition tr5 where tr5.fldBudRefNum = tr3.fldBudRefNum)) " _
                                          & "from tblRevision tr1 where tr1.fldRevNum = (SELECT MAX(`fldRevNum`) " _
                                          & "FROM tblRevision " _
                                          & "WHERE fldBudRefNum = tr3.fldBudRefNum) " _
                                          & "and  tr1.fldStat = 'OPEN' " _
                                          & "and tr1.fldBudRefNum = tr3.fldBudRefNum) " _
                                          & "as RQTY, " _
                                          & "tr3.fldMonthDelivery,tr3.fldOrderStatus,tr3.fldOrderRemarks,tr3.fldCurrency,year(tr3.fldMonthOrder) as Byear, " _
                                          & "(CASE " _
                                          & "WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) " _
                                          & "WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                          & "WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                          & "END) as USD, " _
                                          & "(CASE " _
                                          & "WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) " _
                                          & "WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                          & "WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                          & "END) as PHP, " _
                                          & "(CASE " _
                                          & "WHEN tr3.fldCurrency = 'YEN' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) " _
                                          & "WHEN tr3.fldCurrency = 'USD' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                          & "WHEN tr3.fldCurrency = 'PHP' then (if(tr3.fldTransCode is not null,(select if(tr4.fldTotalCost is not null,sum(tr4.fldTotalCost),0) from tblMOI tr4 where tr4.fldTransCode = tr3.fldTransCode and tr4.fldStat = 'OPEN'),tr3.fldAmountJPY)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                          & "END) as YEN " _
                                          & "FROM tblOrder tr3 order by tr3.fldOrderID desc")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
        Readybtn()

        Try
            bwLoadData.RunWorkerAsync()
        Catch ex As Exception
            RadMessageBox.Show("Already Refreshed!", "Refresh", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

        chkNewOrder.Checked = False

    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        btnpicker = 1

        Dim match = String.Compare(ddlDept.Text, lblDept.Text, ignoreCase:=False)

        If String.IsNullOrEmpty(ddlBRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Budget Reference Number Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlDept.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Department Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlClass.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Classification Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlProcess.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Process Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Description", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtRemarks.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Remarks", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf mebJPYAmount.Value = 0.0 Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf ddlDept.Text = "ALL" Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Please Select Department", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else

            If ddlStat.Text = "CLOSE" Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Cannot Add Order with CLOSE Status!", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            ElseIf Not match = 0 Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                If RadMessageBox.Show("This Budget is from another Department. Are you sure you want to use it for your Order?", _
                                    "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    frmConfirmUsers.Show(Me)

                End If

            Else

                If Tomboy.AddOrder(ddlBRNum.Text, txtPONum.Text, txtPRNum.Text, _
                               dtpMOrder.Value, txtSupplier.Text, txtDesc.Text, _
                               ddlClass.Text, ddlDept.Text, ddlProcess.Text, _
                               mebQTY.Text, ddlUOM.Text, _
                               ddlCurrency.Text, mebJPYAmount.Text, mebYEN.Text, dtpMDelivery.Value, ddlStat.Text, _
                               txtReason.Text, txtRemarks.Text, txtSignature.Text) Then
                    RadMessageBox.SetThemeName("Windows8Theme1")
                    RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK)
                    Clear()
                    bwLoadData.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable

        'Dim z As Integer

        If ddlStat.Text = "CLOSE" Then
            If String.IsNullOrEmpty(txtReason.Text) Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Must have reason to close/cancel this item", "Notification", MessageBoxButtons.OK)

            Else
                If String.IsNullOrEmpty(txtTC.Text) Then

                Else
                    If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to close this item?", _
                                         "Close Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                        Try
                            conn.Open()
                            myCmd.Connection = conn
                            myCmd2.Connection = conn

                            'myCmd.CommandText = "Select count(fldTransCode) as 'xcount' from tblMOI where fldTransCode = '" & txtTC.Text & "'"

                            'myCmd.ExecuteNonQuery()

                            'myAdapter.SelectCommand = myCmd
                            'myAdapter.Fill(myData)

                            'z = myData.Rows(0).Item("xcount")

                            myCmd2.CommandText = "UPDATE tblMOI SET fldStat = 'REMOVED' " _
                                    & "WHERE fldTransCode ='" & txtTC.Text & "'"

                            myCmd2.ExecuteNonQuery()


                            conn.Close()

                        Catch ex As Exception
                            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
                        End Try
                    End If
                End If

                Tomboy.CloseOrder()
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Order Closed!", "Notification", MessageBoxButtons.OK)
                Clear()
                bwLoadData.RunWorkerAsync()
                btnUpdate.Visible = False
                btnSaveOrder.Visible = True
                btnCopyTo.Enabled = False
                chkNewOrder.Enabled = True

            End If

        Else

            If ddlStat.Text = "CLOSE" Then
                If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to close this item?", _
                                          "Close Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Tomboy.CloseOrder()
                    RadMessageBox.SetThemeName("Windows8Theme1")
                    RadMessageBox.Show("Order Closed!", "Notification", MessageBoxButtons.OK)
                    Clear()
                    bwLoadData.RunWorkerAsync()
                End If
            Else
                If Tomboy.UpdateOrder(lblOrderID.Text, ddlBRNum.Text, txtPONum.Text, txtPRNum.Text, _
                           dtpMOrder.Value, txtSupplier.Text, txtDesc.Text, _
                           ddlClass.Text, ddlDept.Text, ddlProcess.Text, mebQTY.Text, ddlUOM.Text, _
                           mebJPYAmount.Text, dtpMDelivery.Value, ddlStat.Text, _
                           txtReason.Text, txtRemarks.Text, txtSignature.Text) Then
                    RadMessageBox.SetThemeName("Windows8Theme1")
                    RadMessageBox.Show("Order Updated!", "Notification", MessageBoxButtons.OK)
                    Clear()
                    bwLoadData.RunWorkerAsync()
                    btnUpdate.Visible = False
                    btnSaveOrder.Visible = True
                    btnCopyTo.Enabled = False
                    chkNewOrder.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnCopyTo_Click(sender As Object, e As EventArgs) Handles btnCopyTo.Click

        If String.IsNullOrEmpty(ddlBRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Budget Reference Number Selected! Check your input", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtPONum.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Purchased Order! Check your input", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtPRNum.Text & txtReason.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Purchased Request! Check your input", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtReason.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Reason! Check your input", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtSupplier.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Supplier! Check your input", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf mebJPYAmount.Value = 0.0 Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Amount", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)



        Else
            If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to copy this item to Acquisition?", _
                                            "Close Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Tomboy.CopyTo(ddlBRNum.Text, "WITH", txtPONum.Text, txtPRNum.Text, _
                                dtpMDelivery.Value, txtSupplier.Text, txtDesc.Text, _
                                ddlClass.Text, ddlDept.Text, ddlCurrency.Text, mebYEN.Text, _
                                mebQTY.Text, ddlUOM.Text, mebJPYAmount.Text, _
                                txtRemarks.Text, txtSignature.Text)
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Order Transfered!", "Notification", MessageBoxButtons.OK)
                Tomboy.CloseOrder()
                Clear()
                bwLoadData.RunWorkerAsync()

            End If

        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        bwLoadData.RunWorkerAsync()

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
            RemQTY()
            btnCopyTo.Enabled = False

            'ddlDept.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkNewOrder_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkNewOrder.ToggleStateChanged

        ReadyOrder()

        ddlStat.Text = "OPEN"
    End Sub

    'Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick

    '    Dim dt2 As DataTable = dataTable1.Clone()
    '    dt2.BeginLoadData()

    '    Dim innerRow As DataRow

    '    For Each row As DataGridViewRow In rgvList.SelectedRows
    '        Dim innerRow As DataRow = dt2.NewRow
    '        innerRow("ID") = row.Cells("ID").Value
    '        innerRow("FirstName") = row.Cells("FirstName").Value
    '        innerRow("LastName") = row.Cells("LastName").Value
    '        innerRow("HireDate") = row.Cells("HireDate").Value
    '        innerRow("Salary") = row.Cells("Salary").Value
    '        dt2.Rows.Add(innerRow)
    '    Next

    '    dt2.AcceptChanges()
    '    dt2.EndLoadData()

    '    Dim dv2 As DataView = New DataView(dt2, Nothing, "ID", DataViewRowState.CurrentRows)
    '    rgvPOI.DataSource = dv2

    'End Sub

    Private Sub rgvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellDoubleClick

        GetData()
        RemQTY()
        GetMultiOrder()

        'btnUpdate.Visible = True
        btnSaveOrder.Visible = False
        chkNewOrder.Enabled = False

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


    Private Sub PassData()

        frmMultiOrderUpdate.ddlDept.Text = Me.ddlDept.Text
        frmMultiOrderUpdate.ddlBRNum.Text = Me.ddlBRNum.Text
        frmMultiOrderUpdate.txtPONum.Text = Me.txtPONum.Text
        frmMultiOrderUpdate.txtPRNum.Text = Me.txtPRNum.Text
        frmMultiOrderUpdate.dtpMOrder.Value = Me.dtpMOrder.Value
        frmMultiOrderUpdate.txtSupplier.Text = Me.txtSupplier.Text
        frmMultiOrderUpdate.txtDesc.Text = Me.txtDesc.Text
        frmMultiOrderUpdate.ddlClass.Text = Me.ddlClass.Text
        frmMultiOrderUpdate.ddlProcess.Text = Me.ddlProcess.Text
        frmMultiOrderUpdate.mebQTY.Text = Me.mebQTY.Text
        frmMultiOrderUpdate.ddlUOM.Text = Me.ddlUOM.Text
        frmMultiOrderUpdate.mebRemQTY.Text = Me.mebRemQTY.Text
        frmMultiOrderUpdate.ddlCurrency.Text = Me.ddlCurrency.Text
        frmMultiOrderUpdate.mebJPYAmount.Text = Me.mebJPYAmount.Text
        ' frmMultiOrderUpdate.mebYEN.Text = Me.mebYEN.Text
        ' frmMultiOrderUpdate.dtpMDelivery.Value = Me.dtpMDelivery.Value
        frmMultiOrderUpdate.ddlStat.Text = Me.ddlStat.Text
        frmMultiOrderUpdate.txtReason.Text = Me.txtReason.Text
        frmMultiOrderUpdate.txtRemarks.Text = Me.txtRemarks.Text

        GetTransCode()
        GetItemData()

        frmMultiOrderUpdate.ddlDept.Enabled = False
        frmMultiOrderUpdate.ddlBRNum.Enabled = False
        frmMultiOrderUpdate.txtPONum.Enabled = False
        frmMultiOrderUpdate.txtPRNum.Enabled = False
        frmMultiOrderUpdate.dtpMOrder.Enabled = False
        frmMultiOrderUpdate.txtSupplier.Enabled = False
        frmMultiOrderUpdate.txtDesc.Enabled = False
        frmMultiOrderUpdate.ddlClass.Enabled = False
        frmMultiOrderUpdate.ddlProcess.Enabled = False
        frmMultiOrderUpdate.mebQTY.Enabled = False
        frmMultiOrderUpdate.ddlUOM.Enabled = False
        frmMultiOrderUpdate.mebRemQTY.Enabled = False
        frmMultiOrderUpdate.ddlCurrency.Enabled = False
        frmMultiOrderUpdate.mebJPYAmount.Enabled = False
        frmMultiOrderUpdate.mebYEN.Enabled = False
        'frmMultiOrderUpdate.dtpMDelivery.Enabled = False

        frmMultiOrderUpdate.ddlStat.Enabled = False
        frmMultiOrderUpdate.txtReason.Enabled = False

        frmMultiOrderUpdate.txtRemarks.Enabled = True
    End Sub

    Private Sub btnMultiOrder_Click(sender As Object, e As EventArgs) Handles btnMultiOrder.Click

        frmMultiOrderUpdate.Show(Me)

        PassData()

        Me.Hide()
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
            myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE `fldcurrency` = 'YEN-PHP'"
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

        ElseIf (ddlCurrency.Text = "USD") Then
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE `fldcurrency` = 'USD-YEN'"
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)
        End If

        If (ddlCurrency.Text = "PHP") Then
            mebYEN.Text = mebJPYAmount.Text / myData.Rows(0).Item("fldAmount")

        ElseIf (ddlCurrency.Text = "USD") Then
            mebYEN.Text = mebJPYAmount.Text * myData.Rows(0).Item("fldAmount")

        ElseIf (ddlCurrency.Text = "YEN") Then
            mebYEN.Text = mebJPYAmount.Text

        Else
            mebYEN.Text = 0

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


        'Dim dtcsv As New DataTable
        'dtcsv.Columns.Add("BUDGET_REFERENCE_NO.")
        'dtcsv.Columns.Add("MONTH_ORDER")


        'Dim csvgrid As New RadGridView
        'Me.Controls.Add(csvgrid)

        'Dim br As New GridViewTextBoxColumn()
        'br.FieldName = "BUDGET_REFERENCE_NO."
        'csvgrid.Columns.Add(br)

        'Dim mo As New GridViewTextBoxColumn()
        'mo.FieldName = "MONTH_ORDER"
        'csvgrid.Columns.Add(mo)


        ''For x As Integer = 0 To rgvList.ChildRows.Count - 1

        'Dim brnum As String = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
        'Dim mon As Date = Convert.ToDateTime(rgvList.CurrentRow.Cells("fldMonthOrder").Value.ToString)
        'dtcsv.Rows.Add(brnum, mon)

        ''Next

        'csvgrid.DataSource = dtcsv

        'Dim exporter As ExportToCSV = New ExportToCSV(csvgrid)
        'exporter.FileExtension = "csv"

        'Dim fileName As String = My.Settings.Path & "\upload.csv"
        'exporter.RunExport(fileName)

        'RadMessageBox.Show("Purchased Order Created", "Notification", MessageBoxButtons.OK)

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

        RadMessageBox.Show("Purchased Order Created", "Notification", MessageBoxButtons.OK)


    End Sub

    'Private Sub exporter_CSVCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventArgs)
    '    If (e.GridColumnIndex = 1 AndAlso e.GridRowInfoType.Equals(GetType(GridViewDataRowInfo))) Then
    '        e.CSVCellElement.Value = "test value"
    '    End If
    'End Sub

    'Private Sub exporter_CSVTableCreated(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Export.CSV.CSVTableCreatedEventArgs)
    '    DirectCast(sender, ExportToCSV).AddCustomCSVRow(e.CSVTableElement, "MY TABLE CAPTION")
    'End Sub

    Private Sub GenPOItem()

        

    End Sub

End Class
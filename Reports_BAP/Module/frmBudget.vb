Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class frmBudget

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub frmBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)
        txtSignature.ReadOnly = True

        DepartmentBudget()
        ClassificationBudget()
        ProcessBudget()

        dtpMForecasted.Enabled = False
        txtRemarks.Enabled = False

        ddlStat.Text = "OPEN"

        UID = SelectedDetails

        ReadyGrid()
        ReadyRevList()

        Clear()

        GetUser()

        CheckU()

    End Sub

    Private Sub CheckU()

        If lblUserlvl.Text = "USER" Then
            btnSaveBud.Enabled = False
            btnUpdate.Enabled = False

        Else
            btnSaveBud.Enabled = True
            btnUpdate.Enabled = True

        End If

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

        

        ' ddlDept.Text = drUser.Item("fldDept").ToString

    End Sub

    Private Sub frmBudget_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub GetData()
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myAdapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            txtBRNum.Text = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldDept").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("fldClass").Value.ToString
            txtDesc.Text = rgvList.CurrentRow.Cells("fldDesc").Value.ToString
            ddlProcess.Text = rgvList.CurrentRow.Cells("fldProcess").Value.ToString
            ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
            mebRemQTY.Text = rgvList.CurrentRow.Cells("RQTY").Value.ToString
            Try
                If rgvRevList.RowCount = 0 Then
                    mebQTY.Text = rgvList.CurrentRow.Cells("fldQTY").Value.ToString
                Else
                    mebQTY.Text = rgvRevList.CurrentRow.Cells("fldQTY").Value.ToString
                End If

            Catch ex As Exception

            End Try
            'mebYEN.Text = rgvList.CurrentRow.Cells("YEN").Value.ToString
            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            dtpSOU.Value = rgvList.CurrentRow.Cells("fldSOU").Value.ToString
            dtpMBudgeted.Value = rgvList.CurrentRow.Cells("fldMBudgeted").Value.ToString
            ddlStat.Text = rgvList.CurrentRow.Cells("fldStat").Value.ToString

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Error", "Invalid Selection", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Try

            conn.Open()
            myCmd.Connection = conn
            myCmd2.Connection = conn
            'Query to generate Revision Number

            myCmd.CommandText = "SELECT fldRevNum, fldRevAmount, CONCAT(`fldBudRefNum`,'-R-',`fldRevNum`+1) " _
                & "AS 'BudRevNum', fldRevAmount FROM tblRevision WHERE fldRevNum = " _
                & "(SELECT MAX(`fldRevNum`) FROM tblRevision WHERE fldBudRefNum = '" & txtBRNum.Text & "')  " _
                & "AND `fldBudRefNum` = '" & txtBRNum.Text & "'"

            RemBalance()

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            txtBudRevNum.Text = myData.Rows(0).Item("BudRevNum").ToString
            lblRevNum.Text = myData.Rows(0).Item("fldRevNum").ToString
            mebAmount.Value = Format(myData.Rows(0).Item("fldRevAmount"), "#,##0.00")

            'mebRemBal.Text = myData.Rows(0).Item("amount").ToString
            'ddlStat.Text = "OPEN"
            'myCmd.ExecuteNonQuery()
            'conn.Close()

        Catch ex As Exception
            RadMessageBox.Show("Error", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub CheckStat()
        If ddlStat.Text = "OPEN" Then
            btnSaveBud.Enabled = True
            ddlStat.Enabled = True
        Else
            btnSaveBud.Enabled = False
            ddlStat.Enabled = False
        End If
    End Sub
    Public Sub EnableField()

        txtBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlClass.Enabled = True
        ddlProcess.Enabled = True
        ddlStat.Enabled = True
        dtpMBudgeted.Enabled = True
        'dtpMForecasted.Enabled = True
        mebAmount.Enabled = True
        'mebRemBal.ReadOnly = True

    End Sub

    Private Sub EditRevision()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try

            txtBudRevNum.Text = rgvRevList.CurrentRow.Cells("fldBudRevNum").Value.ToString
            txtBRNum.Text = rgvRevList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldDept").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("fldClass").Value.ToString
            ddlProcess.Text = rgvList.CurrentRow.Cells("fldProcess").Value.ToString
            ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
            mebAmount.Value = Format(rgvRevList.CurrentRow.Cells("fldRevAmount").Value, "##0.00")
            dtpMBudgeted.Value = rgvList.CurrentRow.Cells("fldMBudgeted").Value.ToString
            dtpMForecasted.Value = rgvRevList.CurrentRow.Cells("fldMRevise").Value.ToString
            ddlStat.Text = rgvRevList.CurrentRow.Cells("fldStat").Value.ToString


            RemBalance()
            getTOMBOY()
            'RemQTYBudget()

            txtBudRevNum.Enabled = False
            txtBRNum.Enabled = False
            ddlDept.Enabled = False
            ddlClass.Enabled = False
            ddlProcess.Enabled = False
            ddlCurrency.Enabled = False
            dtpMBudgeted.Enabled = False
            dtpMForecasted.Enabled = False
            mebAmount.Enabled = False
            'mebRemBal.ReadOnly = True

        Catch ex As Exception

        End Try

    End Sub

    Public Sub ReadyRevise()

        If chkRevision.Checked = True Then
            Clear()
            GetData()

            txtBudRevNum.Enabled = True
            txtBRNum.Enabled = True
            txtRemarks.Enabled = True
            dtpMForecasted.Enabled = True
            txtDesc.Enabled = True
            dtpMBudgeted.Enabled = False
            ddlDept.Enabled = False
            ddlClass.Enabled = False
            ddlProcess.Enabled = False
            ddlCurrency.Enabled = False

        ElseIf chkRevision.Checked = False Then
            Clear()
            ddlBRNum.SendToBack()
            txtBudRevNum.Text = ""
            ' ddlBRNum.Enabled = True
            ddlDept.Enabled = True
            ddlClass.Enabled = True
            ddlProcess.Enabled = True
            txtRemarks.Enabled = False
            dtpMForecasted.Enabled = False
            dtpMBudgeted.Enabled = True
            mebRemBal.Value = ""
            mebAmount.Value = ""

        End If

    End Sub

    Private Sub ReadyGrid() '-----Master Budget

        Dim fldBIDColumn As New GridViewDecimalColumn("ID")
        With fldBIDColumn
            .FieldName = "fldBudgetID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldBIDColumn)

        Dim fldBYColumn As New GridViewComboBoxColumn("YEAR")
        With fldBYColumn
            .FieldName = "Byear"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"2014", _
                                          "2015", _
                                          "2016", _
                                          "2017", _
                                          "2018", _
                                          "2019", _
                                          "2020", _
                                          "2021", _
                                          "2022", _
                                          "2023", _
                                          "2024", _
                                          "2025"}
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldBYColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldStatusColumn As New GridViewComboBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "fldStat"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE"}
        End With
        rgvList.Columns.Add(fldStatusColumn)

        Dim fldCurrencyColumn As New GridViewComboBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PHP", "USD", "YEN"}
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        'Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        'With fldCurrencyColumn
        '    .FieldName = "fldCurrency"
        '    .Width = 65
        '    .TextAlignment = ContentAlignment.MiddleCenter
        'End With
        'rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldAmountColumn As New GridViewTextBoxColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountColumn)
        rgvList.Columns("fldAmount").FormatString = "{0:N2}"

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

        Dim fldRemBudget As New GridViewTextBoxColumn("REMAINING BUDGET")
        With fldRemBudget
            .FieldName = "RemBud"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRemBudget)
        rgvList.Columns("RemBud").FormatString = "{0:N2}"

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldProcessColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldRQTYColumn As New GridViewDecimalColumn("REMAINIG QUANTITY")
        With fldRQTYColumn
            .FieldName = "RQTY"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRQTYColumn)

        Dim fldSOUColumn As New GridViewDateTimeColumn("START OF USE")
        With fldSOUColumn
            .FieldName = "fldSOU"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldSOUColumn)
        rgvList.Columns("fldSOU").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDescColumn As New GridViewTextBoxColumn("BUDGET DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldMBudgetedColumn As New GridViewDateTimeColumn("MONTH BUDGETED")
        With fldMBudgetedColumn
            .FieldName = "fldMBudgeted"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMBudgetedColumn)
        rgvList.Columns("fldMBudgeted").FormatString = "{0:MMM dd, yyyy}"

        Dim fldMForecastedColumn As New GridViewDateTimeColumn("MONTH FORECASTED")
        With fldMForecastedColumn
            .FieldName = "fldMForecasted"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMForecastedColumn)
        rgvList.Columns("fldMForecasted").FormatString = "{0:MMM dd, yyyy}"

        ' Dim fldLoanCode As New GridViewSummaryItem("fldLoanCode", "TOTAL", GridAggregateFunction.Var)
        'Dim fldPaidInstallment As New GridViewSummaryItem("fldLoanNoOfInstallmentPaid", "{0}", GridAggregateFunction.Sum)
        Dim fldTotal As New GridViewSummaryItem("fldBudRefNum", "TOTAL", GridAggregateFunction.Var)
        Dim fldOrigAmount As New GridViewSummaryItem("fldAmount", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldYEN As New GridViewSummaryItem("YEN", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldPHP As New GridViewSummaryItem("PHP", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldUSD As New GridViewSummaryItem("USD", "{0:N2}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldOrigAmount)
        SummaryRowItem.Add(fldYEN)
        SummaryRowItem.Add(fldPHP)
        SummaryRowItem.Add(fldUSD)

        rgvList.SummaryRowsBottom.Add(SummaryRowItem)


        '-----GRID PROPERTIES-----'

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            .ShowGroupPanel = True
            .EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub ReadyRevList() ' revision list
        Dim fldBudRefNumColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefNumColumn
            .FieldName = "fldBudRefNum"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvRevList.Columns.Add(fldBudRefNumColumn)

        Dim fldBudRevNumColumn As New GridViewTextBoxColumn("BUDGET REVISION NO.")
        With fldBudRevNumColumn
            .FieldName = "fldBudRevNum"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvRevList.Columns.Add(fldBudRevNumColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvRevList.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvRevList.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewTextBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvRevList.Columns.Add(fldUOMColumn)

        Dim fldSOUColumn As New GridViewDateTimeColumn("START OF USE")
        With fldSOUColumn
            .FieldName = "fldSOU"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvRevList.Columns.Add(fldSOUColumn)
        rgvRevList.Columns("fldSOU").FormatString = "{0:MMM dd, yyyy}"

        Dim fldMReviseColumn As New GridViewDateTimeColumn("DATE REVISE")
        With fldMReviseColumn
            .FieldName = "fldMRevise"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvRevList.Columns.Add(fldMReviseColumn)
        rgvRevList.Columns("fldMRevise").FormatString = "{0:MMM dd, yyyy}"

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "fldStat"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvRevList.Columns.Add(fldStatColumn)

        Dim fldRevAmountColumn As New GridViewTextBoxColumn("REVISED AMOUNT")
        With fldRevAmountColumn
            .FieldName = "fldRevAmount"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvRevList.Columns.Add(fldRevAmountColumn)
        rgvRevList.Columns("fldRevAmount").FormatString = "{0:N2}"

        '---------------ADDITIONAL
        Dim fldAmountJPYColumn As New GridViewTextBoxColumn("JPY AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "YEN"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRevList.Columns.Add(fldAmountJPYColumn)
        rgvRevList.Columns("YEN").FormatString = "{0:N2}"

        Dim fldAmountPHPColumn As New GridViewTextBoxColumn("PHP AMOUNT")
        With fldAmountPHPColumn
            .FieldName = "PHP"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRevList.Columns.Add(fldAmountPHPColumn)
        rgvRevList.Columns("PHP").FormatString = "{0:N2}"

        Dim fldAmountUSDColumn As New GridViewTextBoxColumn("USD AMOUNT")
        With fldAmountUSDColumn
            .FieldName = "USD"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRevList.Columns.Add(fldAmountUSDColumn)
        rgvRevList.Columns("USD").FormatString = "{0:N2}"
        '--------------END ADDITIONAL

        Dim fldReviseByColumn As New GridViewTextBoxColumn("REVISED BY")
        With fldReviseByColumn
            .FieldName = "fldReviseBy"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvRevList.Columns.Add(fldReviseByColumn)

        Dim fldRevmarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRevmarksColumn
            .FieldName = "fldRemarks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 300
        End With
        rgvRevList.Columns.Add(fldRevmarksColumn)

        With rgvRevList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub chkRevision_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkRevision.ToggleStateChanged

        Try
            If chkRevision.Checked = True Then
                ReadyRevise()
                GetData()
                'RemQTYBudget()
                CheckStat()

                txtBRNum.ReadOnly = True

            ElseIf chkRevision.Checked = False Then
                ReadyRevise()
                txtBudRevNum.Enabled = False

                txtBRNum.ReadOnly = False
            End If

            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
            Dim myCmd As New MySqlCommand
            Dim myData As New DataTable
            Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
            conn.Open()
            myCmd.Connection = conn

            'myCmd.CommandText = "select count(fldBudRefNum) AS 'Count' from tblOrder WHERE fldBudRefNum = '" & txtBRNum.Text & "' AND fldOrderStatus = 'OPEN'"

            myCmd.CommandText = "select count(tr1.fldBudRefNum) as 'count' " _
                            & "from tblOrder tr1 left join tblActualAcquisition tr2 " _
                            & "ON tr1.fldBudRefNum = tr2.fldBudRefNum " _
                            & "WHERE tr1.fldBudRefNum = '" & txtBRNum.Text & "' AND " _
                            & "tr1.fldOrderStatus = 'OPEN' or tr2.fldBudRefNum = '" & txtBRNum.Text & "'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            If myData.Rows(0).Item("Count").ToString <> 0 Then
                ddlUOM.Enabled = False
            Else
                ddlUOM.Enabled = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub Clear()

        txtBudRevNum.Text = ""
        txtBRNum.Text = ""
        ddlDept.Text = ""
        ddlClass.Text = ""
        ddlProcess.Text = ""
        mebAmount.Value = ""
        txtDesc.Text = ""
        dtpMBudgeted.Value = Today
        dtpMForecasted.Value = Today
        dtpSOU.Value = Today
        ddlStat.Text = "OPEN"
        txtRemarks.Text = ""
        mebRemBal.Text = ""
        mebQTY.Text = ""
        mebRemQTY.Text = ""
        ddlUOM.Text = ""
        ddlCurrency.Text = ""
        ddlCurrency.Enabled = True
        btnSaveBud.Enabled = True

        btnOI.Enabled = False
        btnDI.Enabled = False
    End Sub

    Private Sub btnSaveBud_Click(sender As Object, e As EventArgs) Handles btnSaveBud.Click

        If chkRevision.Checked = False Then

            If String.IsNullOrEmpty(txtBRNum.Text) Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Empty Budget Ref Number", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

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
                RadMessageBox.Show("No Budget Description", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            ElseIf String.IsNullOrEmpty(ddlUOM.Text) Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("No Unit of Measurement Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            ElseIf mebQTY.Value = 0 Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("No Quantity", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            ElseIf mebAmount.Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            ElseIf lblUserlvl.Text = "USER" Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("USER Account cannot add Budget. Please contact Accounting Department", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            Else
                If ddlStat.Text = "CLOSE" Then
                    RadMessageBox.SetThemeName("Windows8Theme1")
                    RadMessageBox.Show("Cannot create New Budget with CLOSE Status!", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Error)

                Else
                    If Tomboy.AddBudget(txtBRNum.Text, ddlDept.Text, ddlClass.Text, txtDesc.Text, ddlProcess.Text, _
                                        mebQTY.Text, ddlUOM.Text, dtpSOU.Value, ddlCurrency.Text, mebAmount.Value, _
                                        mebYEN.Text, dtpMBudgeted.Text, ddlStat.Text) Then
                        RadMessageBox.SetThemeName("Windows8Theme1")
                        RadMessageBox.Show("Budget Added!", "Notification", MessageBoxButtons.OK)
                        Clear()
                        chkRevision.Checked = False
                        bwLoadData.RunWorkerAsync()
                    End If

                End If
            End If
        End If

        If chkRevision.Checked = True Then

            If String.IsNullOrEmpty(txtRemarks.Text) Then
                RadMessageBox.Show("Must have Reason for Revision", "Notification", MessageBoxButtons.OK, RadMessageIcon.Error)

            Else
                If ddlStat.Text = "CLOSE" Then
                    If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to revise this item?", _
                              "Revise Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Tomboy.ForceCloseBudget()
                        RadMessageBox.SetThemeName("Windows8Theme1")
                        RadMessageBox.Show("Budget Closed!", "Notification", MessageBoxButtons.OK)
                        bwLoadData.RunWorkerAsync()
                    End If
                End If

                If ddlStat.Text = "OPEN" Then
                    If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to revise this item?", _
                                  "Revise Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        If Tomboy.ReviseBudget(lblRevNum.Text, txtBudRevNum.Text, txtBRNum.Text, _
                                            txtDesc.Text, ddlCurrency.Text, mebYEN.Text, mebQTY.Text, ddlUOM.Text, dtpSOU.Value, _
                                            mebAmount.Text, dtpMForecasted.Text, ddlStat.Text, _
                                            mebRemBal.Text, txtRemarks.Text, txtSignature.Text) Then
                            RadMessageBox.SetThemeName("Windows8Theme1")
                            RadMessageBox.Show("Budget Revised!", "Notification", MessageBoxButtons.OK)
                            Clear()
                            chkRevision.Checked = False
                            bwLoadData.RunWorkerAsync()
                        End If
                        Clear()
                        EnableField()
                        btnUpdate.Visible = False
                        btnSaveBud.Visible = True
                        chkRevision.Enabled = True
                        chkRevision.Checked = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        If lblUserlvl.Text = "ADMINISTRATOR" Then
            dtLoadData = Chinita.fetchDBTable("select year(tr3.fldMBudgeted) as Byear,tr3.fldBudRefNum,tr3.fldDept,tr3.fldStat,tr3.fldCurrency,tr3.fldYen, " _
                                         & "(select if(tr5.fldYen is not null,tr5.fldYen,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum " _
                                         & "where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) as 'RevAmount'," _
                                         & "((select if(tr1.fldYen is not null,tr1.fldYen,0) -" _
                                         & "(((" _
                                         & "Select If(tr4.fldYen Is Not null, sum(tr4.fldYen), 0) " _
                                         & "from tblMOI tr4 where tr4.fldBudRefNum = tr3.fldBudRefNum  and tr4.fldStat = 'OPEN') + " _
                                         & "(select (IF(tr2.fldYen IS NOT NULL,sum(tr2.fldYen),0)) " _
                                         & "from tblOrder tr2 where tr2.fldBudRefNum = tr3.fldBudRefNum and tr2.fldOrderStatus = 'OPEN' And tr2.fldTransCode IS NULL)) + " _
                                         & "((select " _
                                         & "IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0) " _
                                         & "from tblMAI tr6 where tr6.fldBudRefNum = tr3.fldBudRefNum AND tr6.fldStat = 'OPEN') + " _
                                         & "(Select If(tr5.fldYen Is Not null, sum(tr5.fldYen), 0)" _
                                         & "from tblActualAcquisition tr5 where tr5.fldBudRefNum = tr3.fldBudRefNum and tr5.fldTransCode IS NULL))) " _
                                         & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
                                         & "where tr1.fldRevNum = (SELECT MAX(`fldRevNum`) " _
                                         & "FROM tblRevision WHERE fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "and  tr1.fldStat = 'OPEN' and tr1.fldBudRefNum = tr3.fldBudRefNum)) as RemBud,tr3.fldAmount," _
                                         & "(CASE " _
                                         & "WHEN tr3.fldCurrency = 'USD' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "WHEN tr3.fldCurrency = 'PHP' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                         & "WHEN tr3.fldCurrency = 'YEN' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                         & "END) as USD, " _
                                         & "(CASE " _
                                         & "WHEN tr3.fldCurrency = 'PHP' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "WHEN tr3.fldCurrency = 'USD' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                         & "WHEN tr3.fldCurrency = 'YEN' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                         & "END) as PHP, " _
                                         & "(CASE " _
                                         & "WHEN tr3.fldCurrency = 'YEN' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "WHEN tr3.fldCurrency = 'USD' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                         & "WHEN tr3.fldCurrency = 'PHP' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                         & "END) as YEN, " _
                                         & "tr3.fldClass,tr3.fldProcess,tr3.fldUOM," _
                                         & "(" _
                                         & "select if(TRQTYF.fldQTY is not null,TRQTYF.fldQTY,0) - " _
                                         & "((" _
                                         & "select " _
                                         & "if(tr2.fldTransCode is not null,(select IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0) " _
                                         & "from tblMOI tr4 where tr4.fldBudRefNum = tr3.fldBudRefNum and tr4.fldStat = 'OPEN'),if(tr2.fldQTY is not null,sum(tr2.fldQTY),0)) " _
                                         & "from tblOrder tr2 where tr2.fldBudRefNum = tr3.fldBudRefNum and tr2.fldOrderStatus = 'OPEN'" _
                                         & ") + " _
                                         & "(" _
                                         & "select " _
                                         & "if(tr5.fldTransCode is not null,(select IF(tr6.fldQTY IS NOT NULL,sum(tr6.fldQTY),0) " _
                                         & "from tblMAI tr6 where tr6.fldBudRefNum = tr3.fldBudRefNum AND tr6.fldStat = 'OPEN'),if(tr5.fldQTY is not null,sum(tr5.fldQTY),0)) " _
                                         & "from tblActualAcquisition tr5 where tr5.fldBudRefNum = tr3.fldBudRefNum " _
                                         & ")) " _
                                         & "from tblRevision TRQTYF where TRQTYF.fldRevNum = " _
                                         & "(SELECT MAX(`fldRevNum`) " _
                                         & "FROM tblRevision " _
                                         & "WHERE fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "and  TRQTYF.fldStat = 'OPEN' " _
                                         & "and TRQTYF.fldBudRefNum = tr3.fldBudRefNum" _
                                         & ") as RQTY, " _
                                         & "(If (fldQTY is not NULL, fldQTY, 0)) as fldQTY,tr3.fldDesc,tr3.fldSOU,tr3.fldMBudgeted,tr3.fldMForecasted " _
                                         & "from tblBudget tr3 ORDER BY tr3.fldBudgetID Desc")

        Else

            dtLoadData = Chinita.fetchDBTable("select year(tr3.fldMBudgeted) as Byear,tr3.fldBudRefNum,tr3.fldDept,tr3.fldStat,tr3.fldCurrency,tr3.fldYen, " _
                                         & "(select if(tr5.fldYen is not null,tr5.fldYen,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum " _
                                         & "where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) as 'RevAmount'," _
                                         & "((select if(tr1.fldYen is not null,tr1.fldYen,0) -" _
                                         & "(((" _
                                         & "Select If(tr4.fldYen Is Not null, sum(tr4.fldYen), 0) " _
                                         & "from tblMOI tr4 where tr4.fldBudRefNum = tr3.fldBudRefNum  and tr4.fldStat = 'OPEN') + " _
                                         & "(select (IF(tr2.fldYen IS NOT NULL,sum(tr2.fldYen),0)) " _
                                         & "from tblOrder tr2 where tr2.fldBudRefNum = tr3.fldBudRefNum and tr2.fldOrderStatus = 'OPEN' And tr2.fldTransCode IS NULL)) + " _
                                         & "((select " _
                                         & "IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0) " _
                                         & "from tblMAI tr6 where tr6.fldBudRefNum = tr3.fldBudRefNum AND tr6.fldStat = 'OPEN') + " _
                                         & "(Select If(tr5.fldYen Is Not null, sum(tr5.fldYen), 0)" _
                                         & "from tblActualAcquisition tr5 where tr5.fldBudRefNum = tr3.fldBudRefNum and tr5.fldTransCode IS NULL))) " _
                                         & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
                                         & "where tr1.fldRevNum = (SELECT MAX(`fldRevNum`) " _
                                         & "FROM tblRevision WHERE fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "and  tr1.fldStat = 'OPEN' and tr1.fldBudRefNum = tr3.fldBudRefNum)) as RemBud,tr3.fldAmount," _
                                         & "(CASE " _
                                         & "WHEN tr3.fldCurrency = 'USD' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "WHEN tr3.fldCurrency = 'PHP' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                         & "WHEN tr3.fldCurrency = 'YEN' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                         & "END) as USD, " _
                                         & "(CASE " _
                                         & "WHEN tr3.fldCurrency = 'PHP' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "WHEN tr3.fldCurrency = 'USD' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                         & "WHEN tr3.fldCurrency = 'YEN' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                         & "END) as PHP, " _
                                         & "(CASE " _
                                         & "WHEN tr3.fldCurrency = 'YEN' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) " _
                                         & "WHEN tr3.fldCurrency = 'USD' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                         & "WHEN tr3.fldCurrency = 'PHP' then (select if(tr5.fldRevAmount is not null,tr5.fldRevAmount,0) from tblRevision tr5 left join tblBudget trbud on tr5.fldBudRefNum = trbud.fldBudRefNum where  tr5.fldStat != 'Close' and tr5.fldBudRefNum = tr3.fldBudRefNum) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                         & "END) as YEN, " _
                                         & "tr3.fldClass,tr3.fldProcess,tr3.fldUOM," _
                                         & "(select trqty.fldQTY -" _
                                         & "(((Select (If(tr2.fldQTY Is Not null, sum(tr2.fldQTY), 0)) from tblOrder tr2 " _
                                         & "where tr2.fldOrderStatus = 'OPEN' and tr2.fldBudRefNum = tr3.fldBudRefNum " _
                                         & "and tr2.fldTransCode is null) + " _
                                         & "(select distinct if(tr6.fldQTY is not null,sum(tr6.fldQTY),0) " _
                                         & "from tblMOI tr6 left join tblOrder tr8 on tr6.fldTransCode = tr8.fldTransCode " _
                                         & "where tr8.fldBudRefNum = tr3.fldBudRefNum and tr6.fldStat = 'OPEN' and tr8.fldTransCode is not null" _
                                         & ")) + " _
                                         & "((select (IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0)) " _
                                         & "from tblActualAcquisition tr4 left join tblBudget trmain on trmain.fldBudRefNum = tr4.fldBudRefNum " _
                                         & "where trmain.fldBudRefNum = tr3.fldBudRefNum " _
                                         & "and tr4.fldTransCode is null and left(tr4.fldBudRefNum,9) != 'NO BUDGET') + " _
                                         & "(select " _
                                         & "IF(tr9.fldQTY IS NOT NULL,sum(tr9.fldQTY),0) " _
                                         & "from tblMAI tr9 left join tblOrder trqty0 on tr9.fldTransCode = trqty0.fldTransCode " _
                                         & "where trqty0.fldBudRefNum = tr3.fldBudRefNum AND tr9.fldStat = 'OPEN' AND trqty0.fldTransCode is not null))) " _
                                         & "from tblRevision trqty where trqty.fldBudRefNum = tr3.fldBudRefNum and trqty.fldRevNum = (SELECT MAX(`fldRevNum`) " _
                                         & "FROM tblRevision WHERE fldBudRefNum = tr3.fldBudRefNum)) as 'RQTY', " _
                                         & "(If (fldQTY is not NULL, fldQTY, 0)) as fldQTY,tr3.fldDesc,tr3.fldSOU,tr3.fldMBudgeted,tr3.fldMForecasted " _
                                         & "from tblBudget tr3 where tr3.fldDept = '" & lblDept.Text & "' ORDER BY tr3.fldBudgetID Desc")

        End If

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick

        Clear()

        Try
            txtBRNum.Text = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldDept").Value.ToString

            GetOI_DI()
            GetDI_AI()

            EnableField()

            btnUpdate.Visible = False
            btnSaveBud.Visible = True
            chkRevision.Enabled = True
            chkRevision.Checked = False

        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged

        Clear()

        chkRevision.Checked = False
        bwLoadRevList.RunWorkerAsync()

    End Sub

    Private Sub bwLoadRevList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadRevList.DoWork

        Try
            dtLoadData2 = Chinita.fetchDBTable("SELECT tr3.fldCurrency, year(tr3.fldSOU) as Byear,tr3.fldCurrency, tr3.fldBudRevNum,tr3.fldBudRefNum,tr3.fldDesc,tr3.fldQTY,tr3.fldUOM,tr3.fldSOU,tr3.fldMRevise,tr3.fldStat,tr3.fldRevAmount,tr3.fldReviseBy," _
                                                & "(CASE " _
                                                & " WHEN tr3.fldCurrency = 'USD' then tr3.fldRevAmount " _
                                                & " WHEN tr3.fldCurrency = 'PHP' then tr3.fldRevAmount / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                                & " WHEN tr3.fldCurrency = 'YEN' then tr3.fldRevAmount /(select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                                & " END) as USD, " _
                                                & " (CASE " _
                                                & " WHEN tr3.fldCurrency = 'PHP' then tr3.fldRevAmount " _
                                                & " WHEN tr3.fldCurrency = 'USD' then tr3.fldRevAmount * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                                & " WHEN tr3.fldCurrency = 'YEN' then tr3.fldRevAmount * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                                & " END) as PHP, " _
                                                & " (CASE " _
                                                & " WHEN tr3.fldCurrency = 'YEN' then tr3.fldRevAmount " _
                                                & " WHEN tr3.fldCurrency = 'USD' then tr3.fldRevAmount * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                                & " WHEN tr3.fldCurrency = 'PHP' then tr3.fldRevAmount / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                                & " END) as YEN, " _
                                                & "tr3.fldRemarks FROM tblRevision tr3 WHERE tr3.fldBudRefNum = '" & rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString & "' " _
                                                & "and tr3.fldBudRevNum is not null order by fldRevID desc")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadRevList_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadRevList.RunWorkerCompleted
        rgvRevList.DataSource = dtLoadData2
    End Sub

    Private Sub rgvRevList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvRevList.CellDoubleClick

        EditRevision()

        'chkRevision.Checked = False
        chkRevision.Enabled = False
        btnSaveBud.Visible = False
        btnUpdate.Visible = True

        Try
            If rgvRevList.CurrentRow.Cells("fldStat").Value.ToString = "CLOSE" Then
                ddlStat.Enabled = False
                btnUpdate.Enabled = False
            Else
                ddlStat.Enabled = True
                btnUpdate.Enabled = True
            End If

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Empty Revision Item", "Invalid Selection", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
        EnableField()
        btnUpdate.Visible = False
        btnSaveBud.Visible = True
        chkRevision.Enabled = True
        chkRevision.Checked = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        If ddlStat.Text = "OPEN" Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Budget is already OPEN", "Invalid Selection", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf ddlStat.Text = "CLOSE" Then
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to close this item?", _
                                  "Close Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Tomboy.CloseBudget()
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Budget Closed", "Notification", MessageBoxButtons.OK)
                Clear()
                chkRevision.Checked = False
                bwLoadData.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Clear()

        Try
            bwLoadData.RunWorkerAsync()
            rgvList.Refresh()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Multiple Refresh", "Fatal Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        btnSaveBud.Visible = True

    End Sub

    '----- KEYPRESS OF DROP DOWN LIST -----'

    Private Sub ddlDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlDept.KeyPress
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

    '---------------------------------------'

    Private Sub btnCR_Click(sender As Object, e As EventArgs) Handles btnCR.Click

        reporttype = 1

        dt.Rows.Clear()
        dt.Columns.Clear()

        dt.Columns.Add("YEAR", GetType(String))
        dt.Columns.Add("BUDGET_REFERENCE_NO", GetType(String))
        dt.Columns.Add("STATUS", GetType(String))
        dt.Columns.Add("ORIGINAL_AMOUNT", GetType(Decimal))
        dt.Columns.Add("PHP_AMOUNT", GetType(Decimal))
        dt.Columns.Add("USD_AMOUNT", GetType(Decimal))
        dt.Columns.Add("DEPARTMENT", GetType(String))
        dt.Columns.Add("CLASSIFICATION", GetType(String))
        dt.Columns.Add("DESCRIPTION", GetType(String))
        dt.Columns.Add("PROCESS", GetType(String))
        dt.Columns.Add("QUANTITY", GetType(Integer))
        dt.Columns.Add("MEASUREMENT_UNIT", GetType(String))
        dt.Columns.Add("START_OF_USE", GetType(String))
        dt.Columns.Add("MONTH_BUDGETED", GetType(String))
        dt.Columns.Add("MONTH_FORECASTED", GetType(String))

        For x As Integer = 0 To rgvList.ChildRows.Count - 1
            Dim yr As String = rgvList.ChildRows(x).Cells("Byear").Value.ToString
            Dim brno As String = rgvList.ChildRows(x).Cells("fldBudRefNum").Value.ToString
            Dim st As String = rgvList.ChildRows(x).Cells("fldStat").Value.ToString
            Dim oa As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("fldAmount").Value.ToString)
            Dim pha As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("PHP").Value.ToString)
            Dim usa As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("USD").Value.ToString)
            Dim dpt As String = rgvList.ChildRows(x).Cells("fldDept").Value.ToString
            Dim cls As String = rgvList.ChildRows(x).Cells("fldClass").Value.ToString
            Dim desc As String = rgvList.ChildRows(x).Cells("fldDesc").Value.ToString
            Dim pro As String = rgvList.ChildRows(x).Cells("fldProcess").Value.ToString
            Dim qty As Integer = Convert.ToInt32(rgvList.ChildRows(x).Cells("fldQTY").Value.ToString)
            Dim uom As String = rgvList.ChildRows(x).Cells("fldUOM").Value.ToString
            Dim sou As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldSOU").Value))
            Dim mb As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMBudgeted").Value))
            Dim fb As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMForecasted").Value))

            dt.Rows.Add(yr, brno, st, oa, pha, usa, dpt, cls, desc, pro, qty, uom, sou, mb, fb)
        Next

        frmReport.Show()
        frmReport.ReportViewer1.Refresh()

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
            mebYEN.Text = mebAmount.Text / myData.Rows(0).Item("fldAmount")

        ElseIf (ddlCurrency.Text = "USD") Then
            mebYEN.Text = mebAmount.Text * myData.Rows(0).Item("fldAmount")
        ElseIf (ddlCurrency.Text = "YEN") Then
            mebYEN.Text = mebAmount.Text
        Else
            mebYEN.Text = 0
        End If

        conn.Close()

    End Sub

    Private Sub mebAmount_TextChanged(sender As Object, e As EventArgs) Handles mebAmount.TextChanged
        CurrencyRate()
    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        CurrencyRate()
    End Sub

    Private Sub btnUpd8dRep_Click(sender As Object, e As EventArgs) Handles btnUpd8dRep.Click

        Try
            frmGenUpd8dBud.Show(Me)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnOI_Click(sender As Object, e As EventArgs) Handles btnOI.Click

        GetOI_TOO()

        frmBOI.txtBRNum.Text = Me.rgvList.CurrentRow.Cells("fldBudRefNum").Value
        frmBOI.txtDept.Text = Me.rgvList.CurrentRow.Cells("fldDept").Value

        frmBOI.Show(Me)

    End Sub

    Private Sub btnDI_Click(sender As Object, e As EventArgs) Handles btnDI.Click

        'GetOI_TOO()

        frmBAI.txtBRNum.Text = Me.rgvList.CurrentRow.Cells("fldBudRefNum").Value
        frmBAI.txtDept.Text = Me.rgvList.CurrentRow.Cells("fldDept").Value

        frmBAI.Show(Me)

    End Sub

End Class
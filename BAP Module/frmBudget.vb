Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.WinControls.Export
Imports System.ComponentModel

Public Class frmBudget

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub frmBudget_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadData.IsBusy Then
                bwLoadData.CancelAsync()
                imBusy = False
            End If

            Me.Close()
        End If

    End Sub

    Private Sub frmBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        txtSignature.ReadOnly = True

        DepartmentBudget()
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

        ddlFYear.Text = Today.Year

    End Sub

    Private Sub frmBudget_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Visible = True
        imBusy = True
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        Dim FYEAR As Integer = ddlFYear.Text
        Dim DEPT As String = lblDept.Text

        imBusy = True

        Try
            If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Or lblUserlvl.Text = "MANAGER" Then
                dtLoadData = Chinita.fetchDBTable("call BUDGET_GetBudAdmin('" & FYEAR & "')")
            Else
                dtLoadData = Chinita.fetchDBTable("call BUDGET_GetBudNonAdmin('" & DEPT & "','" & FYEAR & "')")
            End If

            For counter As Integer = 0 To dtLoadData.Rows.Count - 1

                Dim x As Double = counter / dtLoadData.Rows.Count * 100
                bwLoadData.ReportProgress(x)
                Threading.Thread.Sleep(Delay)

            Next

        Catch ex As Exception

        End Try

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

    Private Sub CheckU()
        Try
            If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Then
                btnSaveBud.Visible = True
                btnUpdate.Visible = True
                chkRevision.Visible = True

            Else
                btnSaveBud.Visible = False
                btnUpdate.Visible = False
                chkRevision.Visible = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

    End Sub

    Private Sub GetDataUser()
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

            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            dtpSOU.Value = rgvList.CurrentRow.Cells("fldSOU").Value.ToString
            dtpMBudgeted.Value = rgvList.CurrentRow.Cells("fldMBudgeted").Value.ToString
            ddlStat.Text = rgvList.CurrentRow.Cells("fldStat").Value.ToString
            mebRemBal.Text = rgvList.CurrentRow.Cells("RemBud").Value.ToString
            mebAmount.Text = rgvList.CurrentRow.Cells("fldAmount").Value.ToString
            mebJPY.Text = rgvList.CurrentRow.Cells("JPY").Value.ToString

        Catch ex As Exception

        End Try

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

            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            dtpSOU.Value = rgvList.CurrentRow.Cells("fldSOU").Value.ToString
            dtpMBudgeted.Value = rgvList.CurrentRow.Cells("fldMBudgeted").Value.ToString
            ddlStat.Text = rgvList.CurrentRow.Cells("fldStat").Value.ToString
            mebRemBal.Text = rgvList.CurrentRow.Cells("RemBud").Value.ToString

        Catch ex As Exception

        End Try

        Try

            conn.Open()
            myCmd.Connection = conn
            myCmd2.Connection = conn

            '---------------------------------------'
            '-- QUERY TO GENERATE REVISION NUMBER --'
            '---------------------------------------'
            myCmd.CommandText = "SELECT fldRevNum, fldRevAmount, CONCAT(`fldBudRefNum`,'-R-',`fldRevNum`+1) " _
                & "AS 'BudRevNum', fldRevAmount FROM tblRevision WHERE fldRevNum = " _
                & "(SELECT MAX(`fldRevNum`) FROM tblRevision WHERE fldBudRefNum = '" & txtBRNum.Text & "')  " _
                & "AND `fldBudRefNum` = '" & txtBRNum.Text & "'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            txtBudRevNum.Text = myData.Rows(0).Item("BudRevNum").ToString
            lblRevNum.Text = myData.Rows(0).Item("fldRevNum").ToString
            mebAmount.Value = Format(myData.Rows(0).Item("fldRevAmount"), "#,##0.00")

        Catch ex As Exception
            RadMessageBox.Show("Error", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        CheckU()

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
            txtRemarks.Text = rgvRevList.CurrentRow.Cells("FldRemarks").Value.ToString

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

        CheckU()

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

    Private Sub ReadyGrid()
        '-----------------'
        '--MASTER BUDGET--'
        '-----------------'

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
            .DataSource = New [String]() {"2014",
                                          "2015",
                                          "2016",
                                          "2017",
                                          "2018",
                                          "2019",
                                          "2020",
                                          "2021",
                                          "2022",
                                          "2023",
                                          "2024",
                                          "2025"}
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldBYColumn)

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
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

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
            .DataSource = New [String]() {"PHP", "USD", "JPY"}
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

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
            .FieldName = "JPY"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountJPYColumn)
        rgvList.Columns("JPY").FormatString = "{0:N2}"

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
            .Width = 600
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
        Dim fldYEN As New GridViewSummaryItem("JPY", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldPHP As New GridViewSummaryItem("PHP", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldUSD As New GridViewSummaryItem("USD", "{0:N2}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldOrigAmount)
        SummaryRowItem.Add(fldYEN)
        SummaryRowItem.Add(fldPHP)
        SummaryRowItem.Add(fldUSD)

        rgvList.SummaryRowsBottom.Add(SummaryRowItem)

        '-------------------------'
        '-----GRID PROPERTIES-----'
        '-------------------------'

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub ReadyRevList()
        '-----------------'
        '--REVISION LIST--'
        '-----------------'

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

        Dim fldMReviseColumn As New GridViewDateTimeColumn("MONTH FORECASTED")
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
            .FieldName = "JPY"
            .Width = 110
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRevList.Columns.Add(fldAmountJPYColumn)
        rgvRevList.Columns("JPY").FormatString = "{0:N2}"

        Dim fldAmountPHPColumn As New GridViewTextBoxColumn("PHP AMOUNT")
        With fldAmountPHPColumn
            .FieldName = "PHP"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvRevList.Columns.Add(fldAmountPHPColumn)
        rgvRevList.Columns("PHP").FormatString = "{0:N2}"

        Dim fldAmountUSDColumn As New GridViewTextBoxColumn("USD AMOUNT")
        With fldAmountUSDColumn
            .FieldName = "USD"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
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
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        If bwLoadData.IsBusy Then
            bwLoadData.CancelAsync()
            imBusy = False
        End If

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

        CheckU()

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
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Empty Budget Ref Number", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf String.IsNullOrEmpty(ddlDept.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Department Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf String.IsNullOrEmpty(ddlClass.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Classification Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf String.IsNullOrEmpty(ddlProcess.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Process Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Budget Description", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf String.IsNullOrEmpty(ddlUOM.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Unit of Measurement Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf mebQTY.Value = 0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Quantity", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf mebAmount.Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf lblUserlvl.Text = "USER" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("USER Account cannot add Budget. Please contact Accounting Department", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Else
                If ddlStat.Text = "CLOSE" Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Cannot create New Budget with CLOSE Status!", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                    If Tomboy.AddBudget(txtBRNum.Text, ddlDept.Text, ddlClass.Text, txtDesc.Text, ddlProcess.Text,
                                        mebQTY.Text, ddlUOM.Text, dtpSOU.Value, ddlCurrency.Text, mebAmount.Value,
                                        mebJPY.Text, dtpMBudgeted.Text, ddlStat.Text) Then
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("Budget Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                        Clear()
                        chkRevision.Checked = False
                        bwLoadData.RunWorkerAsync()
                    End If

                End If
            End If
        End If

        If chkRevision.Checked = True Then

            If String.IsNullOrEmpty(txtRemarks.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Must have Reason for Revision", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                If ddlStat.Text = "CLOSE" Then
                    RadMessageBox.SetThemeName("Windows8")
                    If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to revise this item?",
                              "Revise Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Tomboy.ForceCloseBudget()
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("Budget Closed!", "Notification", MessageBoxButtons.OK)
                        bwLoadData.RunWorkerAsync()
                    End If
                End If

                If ddlStat.Text = "OPEN" Then
                    RadMessageBox.SetThemeName("Windows8")
                    If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to revise this item?",
                                  "Revise Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        If Tomboy.ReviseBudget(lblRevNum.Text, txtBudRevNum.Text, txtBRNum.Text,
                                            txtDesc.Text, ddlCurrency.Text, mebJPY.Text, mebQTY.Text, ddlUOM.Text, dtpSOU.Value,
                                            mebAmount.Text, dtpMForecasted.Text, ddlStat.Text,
                                            mebRemBal.Text, txtRemarks.Text, txtSignature.Text) Then
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("Budget Revised!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
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

    Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick

        Clear()

        Try

            GetDataUser()

            GetOI_DI()
            GetDI_AI()

            EnableField()

            btnUpdate.Visible = False
            btnSaveBud.Visible = True
            chkRevision.Enabled = True
            chkRevision.Checked = False

        Catch ex As Exception

        End Try

        CheckU()

    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        Try
            Clear()

            chkRevision.Checked = False
            bwLoadRevList.RunWorkerAsync()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub bwLoadRevList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadRevList.DoWork

        Try
            Dim BudRefNum As String = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString

            dtLoadData2 = Chinita.fetchDBTable("call BUDGET_GetRevision('" & BudRefNum & "')")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadRevList_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadRevList.RunWorkerCompleted
        rgvRevList.DataSource = dtLoadData2
    End Sub

    Private Sub rgvRevList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvRevList.CellDoubleClick

        EditRevision()

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
            RadMessageBox.SetThemeName("Windows8")
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

        rgvList.FilterDescriptors.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click, RadButton1.Click
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        If ddlStat.Text = "OPEN" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Budget is already OPEN", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf ddlStat.Text = "CLOSE" Then
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to close this item?",
                                  "Close Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Tomboy.CloseBudget()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Budget Closed", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
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
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Multiple Refresh", "Notification", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
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
            Dim qty As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("fldQTY").Value.ToString)
            Dim uom As String = rgvList.ChildRows(x).Cells("fldUOM").Value.ToString
            Dim sou As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldSOU").Value))
            Dim mb As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMBudgeted").Value))
            Dim fb As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMForecasted").Value))

            dt.Rows.Add(yr, brno, st, oa, pha, usa, dpt, cls, desc, pro, qty, uom, sou, mb, fb)
        Next

        Try
            frmReport.Show()
            frmReport.ReportViewer1.Refresh()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub CurrencyRate()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim CCode As String = ""

        Try
            Dim Year As String = Me.rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString

            If (ddlCurrency.Text = "PHP") Then
                conn.Open()
                myCmd.Connection = conn
                myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE Year(fldDate) = '" & Year & "' and `fldcurrency` = 'JPY-PHP'"
                myAdapter.SelectCommand = myCmd
                myAdapter.Fill(myData)
            ElseIf (ddlCurrency.Text = "USD") Then
                conn.Open()
                myCmd.Connection = conn
                myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE Year(fldDate) = '" & Year & "' and `fldcurrency` = 'USD-JPY'"
                myAdapter.SelectCommand = myCmd
                myAdapter.Fill(myData)
            End If

            If (ddlCurrency.Text = "PHP") Then
                mebJPY.Text = mebAmount.Text / myData.Rows(0).Item("fldAmount")

            ElseIf (ddlCurrency.Text = "USD") Then
                mebJPY.Text = mebAmount.Text * myData.Rows(0).Item("fldAmount")
            ElseIf (ddlCurrency.Text = "JPY") Then
                mebJPY.Text = mebAmount.Text
            Else
                mebJPY.Text = 0
            End If

            conn.Close()

        Catch ex As Exception

        End Try

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

        'GetOI_TOO()

        frmBOI.txtBRNum.Text = Me.rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
        frmBOI.txtDept.Text = Me.rgvList.CurrentRow.Cells("fldDept").Value.ToString

        Try
            frmBOI.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub btnDI_Click(sender As Object, e As EventArgs) Handles btnDI.Click

        'GetOI_TOO()

        frmBAI.txtBRNum.Text = Me.rgvList.CurrentRow.Cells("fldBudRefNum").Value
        frmBAI.txtDept.Text = Me.rgvList.CurrentRow.Cells("fldDept").Value

        Try
            frmBAI.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub mebRemBal_TextChanged(sender As Object, e As EventArgs) Handles mebRemBal.TextChanged
        If mebRemBal.Value < 0 Then
            mebRemBal.BackColor = Color.Orange
            mebRemBal.ForeColor = Color.Orange
        Else
            mebRemBal.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            bwLoadData.RunWorkerAsync()
            Me.Cursor = Cursors.WaitCursor
            pbOlrayt.Visible = True
            imBusy = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If rgvList.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.rgvList)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub
    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub
    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        pbOlrayt.Text = e.ProgressPercentage & "%"
        pbOlrayt.Value1 = e.ProgressPercentage
    End Sub
End Class
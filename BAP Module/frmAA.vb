Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmAA

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub frmAA_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadData.IsBusy Then
                bwLoadData.CancelAsync()
                imBusy = False
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmAA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)
        txtSignature.ReadOnly = True

        DepartmentAA()
        ClassificationAA()

        Clear()

        ddlWBud.Text = "WITHOUT"

        ReadyGrid()

        GetUser()

        ddlFMonth.Text = Today.Month
        ddlFYear.Text = Today.Year

    End Sub

    Private Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

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

    Private Sub EnabledAll()
        txtPONum.Enabled = True
        txtPRNum.Enabled = True
        dtpMAcquired.Enabled = True
        txtDesc.Enabled = True
        ddlClass.Enabled = True
        ddlDept.Enabled = True
        mebJPYAmount.Enabled = True
        txtRemarks.Enabled = True

    End Sub

    Private Sub Clear()

        ddlWBud.Text = ""
        ddlBRNum.Text = ""
        txtPONum.Text = ""
        txtPRNum.Text = ""
        dtpMAcquired.Value = Today
        txtSupplier.Text = ""
        txtDesc.Text = ""
        ddlClass.Text = ""
        ddlDept.Text = ""
        mebJPYAmount.Text = ""
        mebRemBud.Text = ""
        txtRemarks.Text = ""
        ddlCurrency.Text = ""
        ddlCurrency.Text = ""

    End Sub

    Private Sub GetData()
        Try
            ddlWBud.Text = rgvList.CurrentRow.Cells("U_Detail_ID").Value.ToString
            ddlBRNum.Text = rgvList.CurrentRow.Cells("U_BudgetRef").Value.ToString
            txtPONum.Text = rgvList.CurrentRow.Cells("Purch-Ord").Value.ToString
            txtPRNum.Text = rgvList.CurrentRow.Cells("PRNO").Value.ToString
            dtpMAcquired.Value = rgvList.CurrentRow.Cells("Ord-Date").Value.ToString
            txtSupplier.Text = rgvList.CurrentRow.Cells("fldSup").Value.ToString
            txtDesc.Text = rgvList.CurrentRow.Cells("fldDesc").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("Class").Value.ToString
            mebQTY.Text = rgvList.CurrentRow.Cells("GRPO_QTY").Value.ToString
            ddlUOM.Text = rgvList.CurrentRow.Cells("UOM").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("Dept").Value.ToString
            mebJPYAmount.Text = rgvList.CurrentRow.Cells("Price").Value.ToString
            txtRemarks.Text = rgvList.CurrentRow.Cells("Remarks").Value.ToString
            mebRemBud.Text = rgvList.CurrentRow.Cells("RemBud").Value.ToString
            ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString

            'RemBudAA()

            ddlWBud.Enabled = False
            ddlBRNum.Enabled = False
            txtPONum.Enabled = False
            txtPRNum.Enabled = False
            dtpMAcquired.Enabled = False
            txtDesc.Enabled = False
            ddlClass.Enabled = False
            ddlDept.Enabled = False
            mebQTY.Enabled = False
            ddlUOM.Enabled = False
            mebJPYAmount.Enabled = False
            txtRemarks.Enabled = False
            ddlCurrency.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReadyGrid()

        Dim U_Detail_IDColumn As New GridViewTextBoxColumn("U_DETAIL_ID")
        With U_Detail_IDColumn
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(U_Detail_IDColumn)

        Dim U_BudgetRefColumn As New GridViewTextBoxColumn("BUDGET REF. NO.")
        With U_BudgetRefColumn
            .FieldName = "U_BudgetRef"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            .IsPinned = Left
        End With
        rgvList.Columns.Add(U_BudgetRefColumn)

        Dim U_HeaderIDColumn As New GridViewTextBoxColumn("U_HEADER_ID")
        With U_HeaderIDColumn
            .FieldName = "U_HeaderID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(U_HeaderIDColumn)

        Dim PurchOrdColumn As New GridViewTextBoxColumn("PO NUMBER")
        With PurchOrdColumn
            .FieldName = "Purch-Ord"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(PurchOrdColumn)

        Dim PRNoColumn As New GridViewTextBoxColumn("PR NUMBER")
        With PRNoColumn
            .FieldName = "PRNO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(PRNoColumn)

        Dim OrdDateColumn As New GridViewDateTimeColumn("ORDER DATE")
        With OrdDateColumn
            .FieldName = "Ord-Date"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(OrdDateColumn)
        rgvList.Columns("Ord-Date").FormatString = "{0:MMM dd, yyyy}"

        Dim VendNumColumn As New GridViewTextBoxColumn("SUPPLIER")
        With VendNumColumn
            .FieldName = "fldSup"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            .IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(VendNumColumn)

        Dim ProductColumn As New GridViewTextBoxColumn("ITEM CODE")
        With ProductColumn
            .FieldName = "Product"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(ProductColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("ITEM DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 350
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim QTYColumn As New GridViewTextBoxColumn("PO_QUANTITY")
        With QTYColumn
            .FieldName = "Quantity"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(QTYColumn)
        rgvList.Columns("Quantity").FormatString = "{0:N2}"

        Dim OpenQTYColumn As New GridViewTextBoxColumn("OPEN QUANTITY")
        With OpenQTYColumn
            .FieldName = "Open-Qty"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(OpenQTYColumn)
        rgvList.Columns("Open-Qty").FormatString = "{0:N2}"

        Dim RemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With RemarksColumn
            .FieldName = "Remarks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(RemarksColumn)

        Dim DeptColumn As New GridViewTextBoxColumn("DEPT")
        With DeptColumn
            .FieldName = "Dept"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(DeptColumn)

        Dim ClassColumn As New GridViewTextBoxColumn("CLASS")
        With ClassColumn
            .FieldName = "Class"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(ClassColumn)

        Dim UOMColumn As New GridViewTextBoxColumn("UOM")
        With UOMColumn
            .FieldName = "UOM"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(UOMColumn)

        Dim GRPOQTYColumn As New GridViewTextBoxColumn("GRPO_QUANTITY")
        With GRPOQTYColumn
            .FieldName = "GRPO_QTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(GRPOQTYColumn)
        rgvList.Columns("GRPO_QTY").FormatString = "{0:N2}"

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            '.IsVisible = False
            '.IsPinned = Left
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim PriceColumn As New GridViewTextBoxColumn("PRICE")
        With PriceColumn
            .FieldName = "Price"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(PriceColumn)
        rgvList.Columns("Price").FormatString = "{0:N2}"

        '-----
        Dim RateColumn As New GridViewDecimalColumn("RATE")
        With RateColumn
            .FieldName = "Rate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(RateColumn)
        rgvList.Columns("Rate").FormatString = "{0:N6}"

        Dim SAPCurrencyColumn As New GridViewTextBoxColumn("SAP CURRENCY")
        With SAPCurrencyColumn
            .FieldName = "Currency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(SAPCurrencyColumn)

        Dim JPYSAPColumn As New GridViewDecimalColumn("JPY-SAP")
        With JPYSAPColumn
            .FieldName = "JPYSAP"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(JPYSAPColumn)
        rgvList.Columns("JPYSAP").FormatString = "{0:N6}"

        Dim JPYBAPColumn As New GridViewDecimalColumn("JPY-BAP")
        With JPYBAPColumn
            .FieldName = "JPYBAP"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(JPYBAPColumn)
        rgvList.Columns("JPYBAP").FormatString = "{0:N6}"

        Dim ForexColumn As New GridViewDecimalColumn("FOREX")
        With ForexColumn
            .FieldName = "forest"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(ForexColumn)
        rgvList.Columns("forest").FormatString = "{0:N6}"

        '-----

        Dim RemBudColumn As New GridViewTextBoxColumn("RemBud")
        With RemBudColumn
            .FieldName = "RemBud"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(RemBudColumn)
        rgvList.Columns("RemBud").FormatString = "{0:N2}"

        '-----GRID PROPERTIES-----'

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            '.ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick
        GetData()
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        Dim FMONTH As Integer = ddlFMonth.Text
        Dim FYEAR As Integer = ddlFYear.Text
        Dim DEPT As String = lblDept.Text

        If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Or lblUserlvl.Text = "MANAGER" Then
            dtLoadData = Chinita.fetchDBTable("call ACQ_GetAcquisitionAdmin('" & FMONTH & "','" & FYEAR & "')")
        Else
            dtLoadData = Chinita.fetchDBTable("call ACQ_GetAcquisitionNonAdmin('" & FMONTH & "', '" & FYEAR & "', '" & DEPT & "')")
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
            imBusy = False
            Me.Cursor = Cursors.Default
            rgvList.DataSource = dtLoadData
            pbOlrayt.Visible = False
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub frmAA_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        Me.Cursor = Cursors.WaitCursor
        bwLoadData.RunWorkerAsync()
        pbOlrayt.Visible = True
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        If bwLoadData.IsBusy Then
            bwLoadData.CancelAsync()
            imBusy = False
        End If

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
        EnabledAll()
        rgvList.FilterDescriptors.Clear()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            bwLoadData.RunWorkerAsync()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Syncing Data. Please wait.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlBRNum.SelectedIndexChanged
        Try
            RemBudAA()
        Catch ex As Exception

        End Try

        ddlBRNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlBRNum.AutoCompleteDataSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub ddlWBud_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs)

        If ddlWBud.Text = "WITH" Then
            GetBRNumData()
            If ddlBRNum.Text = "" Then
                mebRemBud.Text = ""
                ddlDept.Text = ""
                ddlDept.Enabled = False
            End If

        ElseIf ddlWBud.Text = "WITHOUT" Then
            If dtLoadData2 IsNot Nothing Then
                dtLoadData2.Rows.Clear()
            End If

            ddlBRNum.Text = ""
            mebRemBud.Text = ""
            ddlDept.Text = ""

            ddlDept.Enabled = True
        End If
    End Sub

    '----- KEYPRESS OF DROP DOWN LIST -----'

    Private Sub ddlBRNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlBRNum.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlWBud_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyFilter(sender, e)
    End Sub

    Private Sub ddlClass_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyFilter(sender, e)
    End Sub

    Private Sub ddlDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlDept.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub btnCRAA_Click(sender As Object, e As EventArgs) Handles btnCRAA.Click
        reporttype = 6

        dt.Rows.Clear()
        dt.Columns.Clear()

        dt.Columns.Add("YEAR", GetType(String))
        dt.Columns.Add("BUDGET_REFERENCE_NO", GetType(String))
        dt.Columns.Add("JPY_AMOUNT", GetType(Decimal))
        dt.Columns.Add("PHP_AMOUNT", GetType(Decimal))
        dt.Columns.Add("USD_AMOUNT", GetType(Decimal))
        dt.Columns.Add("CLASSIFICATION", GetType(String))
        dt.Columns.Add("DEPARTMENT", GetType(String))
        dt.Columns.Add("PURCHASED_REQUEST_NO", GetType(String))
        dt.Columns.Add("PURCHASED_ORDER_NO", GetType(String))
        dt.Columns.Add("DESCRIPTION", GetType(String))
        dt.Columns.Add("QUANTITY", GetType(Integer))
        dt.Columns.Add("MEASUREMENT_UNIT", GetType(String))
        dt.Columns.Add("SUPPLIER", GetType(String))
        dt.Columns.Add("MONTH_ACQUIRED", GetType(String))
        dt.Columns.Add("REMARKS", GetType(String))
        dt.Columns.Add("SIGNATURE", GetType(String))

        For x As Integer = 0 To rgvList.ChildRows.Count - 1
            Dim yr As String = rgvList.ChildRows(x).Cells("Byear").Value.ToString
            Dim brno As String = rgvList.ChildRows(x).Cells("fldBudRefNum").Value.ToString
            Dim oa As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("fldAmountJPY").Value.ToString)
            Dim pha As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("PHP").Value.ToString)
            Dim usa As Decimal = Convert.ToDecimal(rgvList.ChildRows(x).Cells("USD").Value.ToString)
            Dim cls As String = rgvList.ChildRows(x).Cells("fldClassification").Value.ToString
            Dim dpt As String = rgvList.ChildRows(x).Cells("fldOrderDepartment").Value.ToString
            Dim pr As String = rgvList.ChildRows(x).Cells("fldPRNo").Value.ToString
            Dim po As String = rgvList.ChildRows(x).Cells("fldPONo").Value.ToString
            Dim desc As String = rgvList.ChildRows(x).Cells("fldOrderDesc").Value.ToString
            Dim qty As Integer = Convert.ToInt32(rgvList.ChildRows(x).Cells("fldQTY").Value.ToString)
            Dim uom As String = rgvList.ChildRows(x).Cells("fldUOM").Value.ToString
            Dim sup As String = rgvList.ChildRows(x).Cells("fldOrderSupplier").Value.ToString
            Dim ma As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMonthAcquired").Value))
            Dim rmk As String = rgvList.ChildRows(x).Cells("fldOrderRemarks").Value.ToString
            Dim sig As String = rgvList.ChildRows(x).Cells("fldSignature").Value.ToString

            dt.Rows.Add(yr, brno, oa, pha, usa, cls, dpt, pr, po, desc, qty, uom, sup, ma, rmk, sig)
        Next

        frmReport.Show()
        frmReport.ReportViewer1.Refresh()

    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        Clear()

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
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Syncing Data. Please wait.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

End Class

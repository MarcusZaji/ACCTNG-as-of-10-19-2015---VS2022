Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Imports System.Data.SqlClient

Public Class frmMultiOrder

    Dim dt As New DataTable
    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData2 As DataTable
    Private dtLoadData3 As DataTable
    Private dtLoadBud As DataTable
    Private dtLoadUPO As DataTable
    Private dtLoadPOI As DataTable
    Private dtLoadTJPY As DataTable
    Private dtLoadTDJPY As DataTable

    Private Sub frmMultiOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If rgvList.Rows.Count > 0 Then

                RadMessageBox.SetThemeName("Windows8")
                If RadMessageBox.Show("There are item(s) in request form. Are you sure you want to close this transaction?",
                                    "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Me.Close()
                    frmOrderPicker.rbMO.IsChecked = False
                    frmOrderPicker.rbSO.IsChecked = False

                End If

            Else
                Me.Close()

            End If
        End If

    End Sub

    Private Sub frmMultiOrder_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GetInvestment()
    End Sub
    Private Sub FrmMultiOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)



        GenTCNo()

        ClassMultiOrder()
        DepartmentMultiOrder()
        ProcessMultiOrder()
        'ECC()
        ddlDataUOM()

        'GetItemCodeSap()
        'ddlItemCode.Text = ""

        IMCategoryMultiOrder()
        txtIMDesc.Text = ""
        'ddlItemCode.Text = ""

        ddlStat.Text = "OPEN"

        ddlClass.Text = ""
        ddlDept.Text = ""
        ddlProcess.Text = ""
        ddlItemUOM.Text = ""
        'ddlCat.Text = ""

        ReadyGrid()
        ReadyItemSelect()

        CheckClear()

        GetUser()

        dtpMOrder.Value = Today
        dtpDN.Value = Today
        txtPRNum.Enabled = False
        chkNewPR.Checked = True
        'ddlItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'ddlItemCode.AutoCompleteDataSource = AutoCompleteSource.CustomSource
        RemoveHandler ddlDept.SelectedIndexChanged, AddressOf ddlDept_SelectedIndexChanged
        ddlDept.SelectedIndex = -1
        AddHandler ddlDept.SelectedIndexChanged, AddressOf ddlDept_SelectedIndexChanged
    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

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

    Private Sub GenTCNo()

        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "SELECT MAX(fldOrderID)+1 as ID FROM tblOrder"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            lblTCID.Text = myData.Rows(0).Item("ID").ToString

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GenTCode()

        Dim TransCode As String
        TransCode = "TC00" + lblTCID.Text + "-" + ddlDept.Text

    End Sub

    Private Sub CheckClear()
        If String.IsNullOrEmpty(txtItemCode.Text) Then
            btnClear.Enabled = False
        Else
            btnClear.Enabled = True
        End If

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

        Dim fldQTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUNITColumn As New GridViewTextBoxColumn("UNIT")
        With fldUNITColumn
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldUNITColumn)

        Dim fldUPColumn As New GridViewTextBoxColumn("UNIT_PRICE")
        With fldUPColumn
            .FieldName = "fldUPrice"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldUPColumn)
        rgvList.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldTotalCost As New GridViewDecimalColumn("TOTAL_COST")
        With fldTotalCost
            .FieldName = "fldTotalCost"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldTotalCost)
        rgvList.Columns("fldTotalCost").FormatString = "{0:N2}"

        'Dim fldTotal As New GridViewSummaryItem("Number", "Total Items = {0}", GridAggregateFunction.Count)

        'Dim SummaryRowItem As New GridViewSummaryRowItem()
        'SummaryRowItem.Add(fldTotal)

        'rgvList.SummaryRowsBottom.Add(SummaryRowItem)

        'Dim fldTotal As New GridViewSummaryItem("fldItemCode", "TOTAL", GridAggregateFunction.Var)
        'Dim fldQTY As New GridViewSummaryItem("fldQTY", "{0:N2}", GridAggregateFunction.Sum)
        'Dim fldTCost As New GridViewSummaryItem("fldTotalCost", "{0:N2}", GridAggregateFunction.Sum)

        'Dim SummaryRowItem As New GridViewSummaryRowItem()
        'SummaryRowItem.Add(fldTotal)
        'SummaryRowItem.Add(fldQTY)
        'SummaryRowItem.Add(fldTCost)

        'rgvList.SummaryRowsBottom.Add(SummaryRowItem)

        With rgvList
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
        End With

    End Sub

    Private Sub ReadyItemSelect()

        Dim fldItemCodeColumn As New GridViewTextBoxColumn("ITEM_CODE")
        With fldItemCodeColumn
            .FieldName = "ItemCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvItemSelect.Columns.Add(fldItemCodeColumn)

        Dim fldItemNameColumn As New GridViewTextBoxColumn("ITEM_NAME")
        With fldItemNameColumn
            .FieldName = "ItemName"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvItemSelect.Columns.Add(fldItemNameColumn)

        Dim fldItemCatColumn As New GridViewTextBoxColumn("CATEGORY")
        With fldItemCatColumn
            .FieldName = "Category"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvItemSelect.Columns.Add(fldItemCatColumn)

        Dim fldItemUOMColumn As New GridViewTextBoxColumn("UNIT")
        With fldItemUOMColumn
            .FieldName = "BuyUnitMsr"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvItemSelect.Columns.Add(fldItemUOMColumn)

        With rgvItemSelect
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True


            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

        GetItemCodeSap()

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click

        If rgvList.Rows.Count > 0 Then

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("There are item(s) in request form. Are you sure you want to close this transaction?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Me.Close()
                frmOrderPicker.rbMO.IsChecked = False
                frmOrderPicker.rbSO.IsChecked = False

            End If

        Else

            Me.Close()

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtItemCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtCategory.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Category Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtIMDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Description Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlItemUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Unit of Measurement Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf mebItemQTY.Text = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item Quantity", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Dim count As Integer = rgvList.Rows.Count
            Dim row As Integer

            If count >= 10 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("10 Items only per Purchased Requisition", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                rgvList.Rows.Add(row, txtItemCode.Text, txtIMDesc.Text, mebItemQTY.Text, ddlItemUOM.Text,
                                          mebItemQTY.Text)

                If rgvList.Rows.Count = 0 Then
                    ddlCurrency.Enabled = True
                Else
                    ' ddlCurency1.Enabled = False
                End If

            End If

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If rgvList.SelectedRows.Count > 0 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Are you sure you want to remove '" & rgvList.CurrentRow.Cells("fldItemCode").Value.ToString & "'?", "Remove Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                rgvList.Rows.Remove(rgvList.SelectedRows(0))
            Else
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Select Item to Remove")
            End If
        End If
    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveMulOrder.Click

        btnpicker = 2

        If String.IsNullOrEmpty(ddlBRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please select Budget Reference Number.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If

        Dim match = String.Compare(ddlDept.Text, lblDept.Text, ignoreCase:=False)

        Dim myCmd As New MySqlCommand
        Dim myCmdPR As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        GenTCNo()
        GenTCode()

        Dim myCmdRem As New MySqlCommand
        Dim myAdapterRem As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myDataRem As New DataTable
        Dim connRem As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim BR As Decimal
        connRem.Open()

        GetRate()

        myCmdRem.Connection = connRem

        myCmdRem.CommandText = "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'RemBudget' " _
           & "FROM tblOrder PR " _
           & "where (select count(MO.fldTransCode) from tblMOI MO where MO.fldTransCode = PR.fldTransCode and MO.fldStat = 'OPEN') != 0 " _
           & "and PR.fldBudRefNum = '" & ddlBRNum.Text & "'"

        '11 28 2016 commend change query validation for BR amount
        'myCmdRem.CommandText = "select ROUND(if(tr1.fldYen is not null,tr1.fldYen,0) " _
        '    & "- (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
        '    & "from tblUPO UPO where UPO.fldBudRefNum = '" & ddlBRNum.Text & "') " _
        '    & "- (SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0) " _
        '    & "FROM tblPOI tr2 where tr2.fldBudRefNum = '" & ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' ) - " _
        '    & "((" _
        '    & "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY' FROM tblOrder PR " _
        '    & "where (select count(MO.fldTransCode) from tblMOI MO " _
        '    & "where MO.fldTransCode = PR.fldTransCode and MO.fldStat = 'OPEN') != 0 " _
        '    & "and PR.fldBudRefNum = '" & ddlBRNum.Text & "')),2) as 'RemBudget' " _
        '    & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
        '    & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & ddlBRNum.Text & "'"

       


        myAdapterRem.SelectCommand = myCmdRem
        myAdapterRem.Fill(myDataRem)
    
        If String.IsNullOrEmpty(ddlBRNum.Text) = False Then
            '11 28 2016 commend change query validation for BR amount
            'BR = myDataRem.Rows(0).Item("RemBudget") - (Convert.ToDecimal(mebEPA.Text))
            BR = myDataRem.Rows(0).Item("RemBudget")
        End If

        '------------------------------------------------------------------------------'

        Dim myCmd2 As New MySqlCommand
        Dim myAdapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData2 As New DataTable
        Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim percent As Decimal

        conn2.Open()

        myCmd2.Connection = conn2

        'myCmd2.CommandText = "select if(tr1.fldYen is not null,tr1.fldYen,0) - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
        '                    & "from tblUPO UPO where UPO.fldBudRefNum = '" & ddlBRNum.Text & "') - " _
        '                    & "( " _
        '                    & "SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where tr2.fldBudRefNum = '" & ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' " _
        '                    & ")- " _
        '                    & "(( " _
        '                    & "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) " _
        '                    & " FROM tblOrder PR where (select count(MO.fldTransCode) " _
        '                    & "from tblMOI MO where MO.fldTransCode = PR.fldTransCode " _
        '                    & " and MO.fldStat = 'OPEN') != 0 and PR.fldBudRefNum = '" & ddlBRNum.Text & "' " _
        '                    & ")) " _
        '                    & " as 'mebRemBLPR' " _
        '                    & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
        '                    & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & ddlBRNum.Text & "' "

        myCmd2.CommandText = "select if(tr1.fldYen is not null,tr1.fldYen,0) - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
                            & "from tblUPO UPO where UPO.fldBudRefNum = '" & ddlBRNum.Text & "') - " _
                            & "( " _
                            & "SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where tr2.fldBudRefNum = '" & ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' " _
                            & ")- " _
                            & "(( " _
                            & "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) " _
                            & " FROM tblOrder PR where PR.fldOrderStatus = 'OPEN' " _
                            & " and PR.fldBudRefNum = '" & ddlBRNum.Text & "' " _
                            & ")) " _
                            & " as 'mebRemBLPR' " _
                            & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
                            & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & ddlBRNum.Text & "' "
        myAdapter2.SelectCommand = myCmd2
        myAdapter2.Fill(myData2)

        percent = myData2.Rows(0).Item("mebRemBLPR") * 0.05
        '------------------------------------------------------------------------------'
        If chkNewPR.Checked = False Then
            Dim countRow As Integer = rgvList.Rows.Count
            Dim RowGTotal As Integer

            Dim myCmd3 As New MySqlCommand
            Dim myAdapter3 As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim myData3 As New DataTable
            Dim conn3 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)



            conn3.Open()

            myCmd3.Connection = conn3
            myCmd3.CommandText = "select distinct Count(ORD.fldPRNo) as 'PRCount' " _
                                & "from tblMOI MOI left join tblOrder ORD on MOI.fldTransCode = ORD.fldTransCode " _
                                & "where MOI.fldStat = 'OPEN' and ORD.fldPRNo = '" & txtPRNum.Text & "'"
            myAdapter3.SelectCommand = myCmd3
            myAdapter3.Fill(myData3)
            RowGTotal = Convert.ToInt32(myData3.Rows(0).Item("PRCount").ToString) + countRow
            If RowGTotal >= 11 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Only 10 items allowed you have '" & myData3.Rows(0).Item("PRCount") & "' existing items/data and '" & countRow & "' additional items", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Exit Sub
            End If
        End If
        '------------------------------------------------------------------------------'

        '----- BORROWED BUDGET -----'

        If ddlStat.Text = "CLOSE" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. Cannot Add Order with CLOSE Status!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlBRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Budget Reference Number Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

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
            txtRemarks.Focus()

            '    '--------------------------------------------'
            '    '---- COMMENT THIS FOR NEXT YEAR (2016) -----'
            '    '--------------------------------------------'
            'ElseIf (mebRemBLPR.Value * -1) > percent And txtNB.Text = "NO" Then
            '    mebRemBLPR.BackColor = Color.Red
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("Insufficient Budget", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '    '--------------------------------------------'

        ElseIf rgvList.RowCount = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. Add Item(s) to Continue", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '11 28 2016 commend change query validation for BR amount
            'ElseIf Convert.ToDecimal(mebRemBLPR.Value) <> BR Then


            'ElseIf Convert.ToDecimal(mebTOPRA.Value) <> BR Then
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("The remaining balance reflected is already updated by other user. Click the OK button to see updated balance. ", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '    Try ' FOR REFRESHING WEEEE
            '        OrderInfoMulti()
            '        RemBudMultiOrder()
            '        TOEA()
            '        DeductPR()
            '    Catch ex As Exception

            '    End Try

        ElseIf Not match = 0 Then
            'RadMessageBox.SetThemeName("Windows8")
            'If RadMessageBox.Show("This Budget is from another Department. Are you sure you want to use it for your Order?",
            '                    "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            '    frmConfirmUsers.Show(Me)
            'End If
            RadMessageBox.Show("This Budget is from another Department. you are not allowed to PR on this department", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Are you sure you want to Order this item?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                '----- SAME DEPT | MULTIPLE ORDER -----'
                ' Try
                conn.Open()
                myCmd.Connection = conn
                myCmdPR.Connection = conn

                Dim TransCode, Curr As String

                Dim TC, BRNum, Status, ICode, Desc, Unit, Classification, Dept, Process, User As String
                Dim QTY, Rate As Decimal
                ' Dim UPrice, Total As Decimal
                Dim MO, ColMO As Date

                TransCode = "TC00" + lblTCID.Text + "-" + ddlDept.Text
                Curr = ddlCurrency.Text
                MO = dtpMOrder.Value

                If chkNewPR.Checked Then
                    myCmdPR.CommandText = "CALL PR_Insert('" & dtpMOrder.Value.Year & "','" & TransCode & "','" & ddlDept.Text & "');"
                    myCmdPR.ExecuteNonQuery()
                    myCmd.Parameters.Clear()
                Else
                    myCmdPR.CommandText = "UPDATE `tblOrder` SET `fldPrint`='NO' WHERE fldPRNo ='" & txtPRNum.Text & "'"
                    myCmdPR.ExecuteNonQuery()
                    myCmd.Parameters.Clear()
                End If

                '------------------------------------------------------

                Zaji.addParameter("BudRefNum", ddlBRNum.Text)
                Zaji.addParameter("TransCode", TransCode)
                Zaji.addParameter("PRNo", txtPRNum.Text)
                Zaji.addParameter("MonthOrder", dtpMOrder.Value)
                Zaji.addParameter("OrderDesc", txtDesc.Text)
                Zaji.addParameter("Classification", ddlClass.Text)
                Zaji.addParameter("OrderDepartment", ddlDept.Text)
                Zaji.addParameter("_Process", ddlProcess.Text)
                Zaji.addParameter("QTY", mebQTY.Value)
                Zaji.addParameter("UOM", ddlItemUOM.Text)
                Zaji.addParameter("OrderStatus", ddlStat.Text)
                Zaji.addParameter("Reason", txtReason.Text)
                Zaji.addParameter("OrderRemarks", txtRemarks.Text)
                Zaji.addParameter("Signature", txtSignature.Text)
                Zaji.addParameter("MO", dtpMOrder.Value)
                Zaji.addParameter("DN", dtpDN.Value)
                Zaji.addParameter("EC", ddlCurrency.Text)
                Zaji.addParameter("EOA", mebAmount.Value)
                Zaji.addParameter("EJPY", mebEPA.Value)
                Zaji.addParameter("TOPRA", mebTOPRA.Value)
                Zaji.addParameter("TDOPRA", mebTOPDRA.Value)
                Zaji.addParameter("RBLPR", mebRemBLPR.Value)
                Zaji.addParameter("RDBLPR", mebRemDBLPR.Value)
                Zaji.addParameter("RB", mebRemBud.Value)
                Zaji.addParameter("RDB", RemDeptBud.Value)
                Zaji.addParameter("RN", txtRN.Text)
                Zaji.addParameter("Rate", mebXRate.Value)
                Zaji.addParameter("MoldDie", txtMoldDie.Text)
                Zaji.addParameter("NReason", txtNReason.Text)
                Zaji.addParameter("InsRequirements", ddlInsRequirement.Text)

                Zaji.dbAED("SP_InsertOrder")

                ''----------------------------Add Investment Record--------------------------
                If cbInvestment.Checked = False Then
                    Tomboy.AddInvestmentRecord(ddlBRNum.Text,
                                    TransCode,
                                    txtPRNum.Text,
                                    dtpMOrder.Value,
                                    txtDesc.Text,
                                    ddlClass.Text,
                                    ddlDept.Text,
                                    ddlProcess.Text,
                                    mebQTY.Value,
                                    ddlItemUOM.Text,
                                    ddlStat.Text,
                                    txtReason.Text,
                                    txtRemarks.Text,
                                    txtSignature.Text,
                                    dtpMOrder.Value,
                                    dtpDN.Value,
                                    ddlCurrency.Text,
                                    mebAmount.Value,
                                    mebEPA.Value,
                                    mebTOPRA.Value,
                                    mebTOPDRA.Value,
                                    mebRemBLPR.Value,
                                    mebRemDBLPR.Value,
                                    mebRemBud.Value,
                                    RemDeptBud.Value,
                                    txtRN.Text,
                                    mebXRate.Value,
                                    txtMoldDie.Text,
                                    ddlInvestment.Text)
                End If

                '' ------------------------------------------------------------------

                For x As Integer = 0 To rgvList.Rows.Count - 1
                    TC = TransCode
                    BRNum = ddlBRNum.Text
                    ICode = rgvList.Rows(x).Cells(1).Value
                    Desc = rgvList.Rows(x).Cells(2).Value
                    QTY = rgvList.Rows(x).Cells(3).Value
                    Unit = rgvList.Rows(x).Cells(4).Value
                    'UPrice = rgvList.Rows(x).Cells(4).Value
                    'Total = rgvList.Rows(x).Cells(5).Value
                    'Currency = Curr
                    Status = "OPEN"
                    ColMO = MO
                    Classification = ddlClass.Text
                    Dept = ddlDept.Text
                    Process = ddlProcess.Text
                    User = txtSignature.Text
                    Rate = mebXRate.Value

                    myCmd.CommandText = "INSERT INTO tblMOI" _
                                            & "(fldTransCode, fldBudRefNum, fldICode, fldDesc, fldQTY, " _
                                            & "fldUnit, fldStat, fldSignature, fldMO, " _
                                            & "fldClass, fldDept, fldProcess, fldRate) " _
                                            & "values" _
                                            & "(@fldTransCode, @fldBudRefNum, @fldICode, @fldDesc, @fldQTY," _
                                            & "@fldUnit, @fldStat, @fldSignature, @fldMO," _
                                            & "@fldClass, @fldDept, @fldProcess, @fldRate)"

                    With myCmd.Parameters
                        .AddWithValue("@fldTransCode", TC)
                        .AddWithValue("@fldBudRefNum", BRNum)
                        .AddWithValue("@fldICode", ICode)
                        .AddWithValue("@fldDesc", Desc)
                        .AddWithValue("@fldQTY", QTY)
                        .AddWithValue("@fldUnit", Unit)
                        '.AddWithValue("@fldUPrice", UPrice)
                        '.AddWithValue("@fldTotalCost", Total)
                        '.AddWithValue("@fldCurrency", Currency)
                        .AddWithValue("@fldStat", Status)
                        .AddWithValue("@fldSignature", User)
                        .AddWithValue("@fldMO", ColMO)
                        .AddWithValue("@fldClass", Classification)
                        .AddWithValue("@fldDept", Dept)
                        .AddWithValue("@fldProcess", Process)
                        .AddWithValue("@fldRate", Rate)
                    End With

                    myCmd.ExecuteNonQuery()
                    myCmd.Parameters.Clear()

                Next

                conn.Close()

                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Clear()
                GenTCNo()
                RadMessageBox.Show("This Module will be close automatically. Please reopen theis Module to Create PR again Thank you", "Notification", MessageBoxButtons.OK)
                Me.Close()
                'Catch ex As Exception
                '    RadMessageBox.SetThemeName("Windows8")
                '    RadMessageBox.Show("System Error! Please Contact MIS @ Local 113 or 606", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                'End Try

            End If

        End If

    End Sub

    Private Sub Clear()

        txtTC.Text = ""
        txtCategory.Text = ""
        txtItemCode.Text = ""
        txtIMDesc.Text = ""
        mebItemQTY.Text = 0
        'ddlUOM.Text = ""
        ' mebItemUnitPrice.Text = ""

        ddlBRNum.Text = ""
        txtPRNum.Text = ""
        dtpMOrder.Value = Today
        ' txtSupplier.Text = ""
        txtDesc.Text = ""
        ddlClass.Text = ""
        ddlDept.Text = ""
        ddlProcess.Text = ""
        mebQTY.Text = ""
        mebRemQTY.Text = ""
        ' ddlUOM.Text = ""
        mebJPYAmount.Text = ""
        dtpMDelivery.Value = Today
        ddlStat.Text = "OPEN"
        mebRemBud.Text = ""
        txtRemarks.Text = ""
        rgvList.Text = 0.0

        rgvList.Rows.Clear()

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

    Private Sub ddlDept_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlDept.SelectedIndexChanged
        GetDeptData()
        GetRemDeptBud()

        If chkNewPR.Checked = False Then
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
            Dim myCmd As New MySqlCommand
            Dim ddlvalues As MySqlDataReader
            Try

                conn.Open()

                Dim drCheckYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
                Dim CheckYear As String = drCheckYear.Item("fldLimit")
                'Dim CheckYear As String = "2018"
                myCmd.Connection = conn
                myCmd.CommandText = "select concat(fldYear,'-',fldPRKey) as PRNOAI from tblPRNo where fldDept = '" & ddlDept.Text & "' AND fldStat = 'OPEN' and fldYear = '" & CheckYear & "'"


                ddlvalues = myCmd.ExecuteReader()
                txtPRNum.DataSource = ddlvalues
                txtPRNum.DisplayMember = "PRNOAI"
                txtPRNum.Enabled = True
                txtPRNum.Text = ""
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub GetRemDeptBud()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim drCheckYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
        Dim CheckYear As String = drCheckYear.Item("fldLimit")
        'Dim CheckYear As String = "2018"

        'conn.Open()

        'myCmd.Connection = conn

        'myCmd.CommandText = "select if(tr1.fldYen is not null,sum(tr1.fldYen),0) " _
        '    & "- (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) from tblUPO UPO " _
        '    & "where UPO.fldDept = '" & ddlDept.Text & "' and year(UPO.fldUDate) = '" & CheckYear & "') - " _
        '    & "(Select If(tr2.fldYenSap Is Not null, sum(tr2.fldYenSap), 0) " _
        '    & "FROM tblPOI tr2 where tr2.fldDept = '" & ddlDept.Text & "' and tr2.fldStat != 'CLOSE' " _
        '    & "and year(tr2.fldMO) = '" & CheckYear & "') as 'RemBudget' " _
        '    & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
        '    & "where tr1.fldStat != 'CLOSE' and tr7.fldDept = '" & ddlDept.Text & "' and year(tr7.fldMBudgeted) = '" & CheckYear & "'"
        'myAdapter.SelectCommand = myCmd
        'myAdapter.Fill(myData)
        '--------------------------------------------Linq------------------------------------------------------
        dtLoadBud = Chinita.fetchDBTable("call SP_SelectBudgetByYear('" & CheckYear & "', '" & ddlDept.Text & "')")
        dtLoadUPO = Chinita.fetchDBTable("call SP_SelectUPOByYear('" & CheckYear & "', '" & ddlDept.Text & "')")
        dtLoadPOI = Chinita.fetchDBTable("call SP_SelectPOIByYear('" & CheckYear & "', '" & ddlDept.Text & "')")
        '--------------------------------------------Linq End--------------------------------------------------
        'conn.Close()

        'RemDeptBud.Text = myData.Rows(0).Item("RemBudget")
        Dim BudTotal As Decimal = GetBudgetYear()
        Dim UPOTotal As Decimal = GetUPOYear()
        Dim POITotal As Decimal = GetPOIYear()

        RemDeptBud.Value = Convert.ToString(BudTotal - UPOTotal - POITotal)
    End Sub
    Function GetBudgetYear()
        Dim QueryBud = dtLoadBud.AsEnumerable().Sum(Function(r) CType(r("fldYen"), Decimal))
        Return Convert.ToDecimal(QueryBud)
    End Function
    Function GetUPOYear()
        Dim QueryUPO = dtLoadUPO.AsEnumerable().Sum(Function(r) CType(r("fldJPY"), Decimal))
        Return Convert.ToDecimal(QueryUPO)
    End Function
    Function GetPOIYear()
        'Try
        Dim QueryPOI = dtLoadPOI.AsEnumerable().Sum(Function(r) CType(r("fldYenSap"), Decimal))
        Return Convert.ToDecimal(QueryPOI)
        'Catch ex As Exception
        '    Return 0
        'End Try

    End Function
    Private Sub GetInvestment()
        Try
            dtLoadData2 = Chinita.fetchDBTable("call SP_SelectInvestmentGood()")
            ddlInvestment.DataSource = dtLoadData2
            ddlInvestment.DisplayMember = "fldInvestmentNo"
            ddlInvestment.MultiColumnComboBoxElement.DropDownWidth = 480
            ddlInvestment.MultiColumnComboBoxElement.DropDownHeight = 200
            ddlInvestment.Text = ""
            RemoveHandler ddlInvestment.SelectedIndexChanged, AddressOf ddlInvestment_SelectedIndexChanged_1
            ddlInvestment.SelectedIndex = -1
            AddHandler ddlInvestment.SelectedIndexChanged, AddressOf ddlInvestment_SelectedIndexChanged_1
            txtInvestmentAppBud.Value = 0
            txtInvBudBalance.Value = 0
            ddlInvestment.EditorControl.AllowSearchRow = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetDeptData()

        Dim drCheckYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
        Dim CheckYear As String = drCheckYear.Item("fldLimit").ToString
        'Dim CheckYear As String = "2018"
        Try
            'Edited 1-9-2020 change year to 2019
            'dtLoadData2 = Chinita.fetchDBTable("SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN' AND fldDept = '" & ddlDept.Text & "' and year(fldMBudgeted) = '" & CheckYear & "' order by fldBudRefNum")
            dtLoadData2 = Chinita.fetchDBTable("SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN' AND fldDept = '" & ddlDept.Text & "' and year(fldMBudgeted) = '" & "2019" & "' order by fldBudRefNum")
        Catch ex As Exception

        End Try

        ddlBRNum.DataSource = dtLoadData2

        ddlBRNum.Text = ""
        txtDesc.Text = ""
        ddlClass.Text = ""
        ddlProcess.Text = ""
        mebRemBud.Value = 0.0
        mebRemBLPR.Value = 0.0

        ddlBRNum.DisplayMember = "fldBudRefNum"
        ddlBRNum.ValueMember = "fldBudRefNum"

        RemoveHandler ddlBRNum.SelectedIndexChanged, AddressOf ddlBRNum_SelectedIndexChanged
        ddlBRNum.SelectedIndex = -1
        AddHandler ddlBRNum.SelectedIndexChanged, AddressOf ddlBRNum_SelectedIndexChanged
    End Sub

    Private Sub CurrencyRate()

        Try
            If ddlCurrency.Text = "JPY" Then
                mebEPA.Value = mebAmount.Value
            Else
                mebEPA.Value = mebAmount.Value * mebXRate.Value
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged

        GetRate()

        CurrencyRate()
        DeductPR()
    End Sub

    Private Sub mebJPYAmount_TextChanged(sender As Object, e As EventArgs) Handles mebJPYAmount.TextChanged
        CurrencyRate()
    End Sub

    Private Sub rgvList_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgvList.CellFormatting
        If e.CellElement.ColumnInfo.HeaderText = "NO" Then
            e.CellElement.Text = e.CellElement.RowIndex.ToString + 1
        End If
    End Sub

    Private Sub rgvList_CurrentCellChanged(sender As Object, e As CurrentCellChangedEventArgs) Handles rgvList.CurrentCellChanged
        'ECC()
    End Sub

    Private Sub rgvList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.RowsChanged

        Dim QTY As Integer = 0
        Dim TCost As Decimal = 0.0

        For x As Integer = 0 To rgvList.Rows.Count - 1
            QTY = QTY + rgvList.Rows(x).Cells("fldQTY").Value
            TCost = TCost + rgvList.Rows(x).Cells("fldTotalCost").Value
        Next

        mebQTY.Value = QTY
        mebJPYAmount.Value = TCost

    End Sub

    Private Sub ddlItemCode_Click(sender As Object, e As EventArgs)
        txtCategory.Text = ""
        txtIMDesc.Text = ""
        ddlItemUOM.Text = ""
    End Sub

    Private Sub ddlItemCode_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim conn As New SqlClient.SqlConnection(Sapsap)
        Dim myCmd As New SqlClient.SqlCommand
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "select " _
                                & "( " _
                                & "case T0.ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
                                & "WHEN '101' THEN 'Work In Progress' " _
                                & "WHEN '102' THEN 'Raw Materials' " _
                                & "WHEN '103' THEN 'Spare Parts' " _
                                & "WHEN '104' THEN 'Office Supplies' " _
                                & "WHEN '105' THEN 'Packaging' " _
                                & "WHEN '106' THEN 'Fabrication' " _
                                & "WHEN '107' THEN 'Others' " _
                                & "WHEN '108' THEN 'Supplies Others' " _
                                & "WHEN '109' THEN 'FFC Manufacturing' " _
                                & "WHEN '111' THEN 'BSS Manufacturing' " _
                                & "End " _
                                & ") AS 'Category' " _
                                & ",T0.ItemCode,T0.ItemName,T0.BuyUnitMsr from OITM T0 " _
                                & "where T0.ItemCode = '" & txtItemCode.Text & "' "

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            myAdapter.Fill(myData2)
            conn.Close()

            txtIMDesc.Text = myData.Rows(0).Item("ItemName").ToString
            ddlItemUOM.Text = myData2.Rows(0).Item("BuyUnitMsr").ToString
            txtCategory.Text = myData2.Rows(0).Item("Category").ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadItemCode()

        Dim conn As New SqlClient.SqlConnection(Sapsap)
        Dim myCmd As New SqlClient.SqlCommand
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myAdapter As New SqlClient.SqlDataAdapter

        conn.Open()

        myCmd.Connection = conn
        myCmd.CommandText = "select " _
                            & "( " _
                            & "case T0.ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
                            & "WHEN '101' THEN 'Work In Progress' " _
                            & "WHEN '102' THEN 'Raw Materials' " _
                            & "WHEN '103' THEN 'Spare Parts' " _
                            & "WHEN '104' THEN 'Office Supplies' " _
                            & "WHEN '105' THEN 'Packaging' " _
                            & "WHEN '106' THEN 'Fabrication' " _
                            & "WHEN '107' THEN 'Others' " _
                            & "WHEN '108' THEN 'Supplies Others' " _
                            & "WHEN '109' THEN 'FFC Manufacturing' " _
                            & "WHEN '111' THEN 'BSS Manufacturing' " _
                            & "End " _
                            & ") AS 'Category' " _
                            & ",T0.ItemCode,T0.ItemName,T0.BuyUnitMsr from OITM T0 "

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        myAdapter.Fill(myData2)
        conn.Close()


    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlBRNum.SelectedIndexChanged
        Try
            OrderInfoMulti()
            RemBudMultiOrder()
            TOEA()
            DeductPR()

            If chkNewPR.Checked = False Then
                GetRate()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub rgvItemSelect_DoubleClick(sender As Object, e As EventArgs) Handles rgvItemSelect.DoubleClick
        Try
            txtItemCode.Text = rgvItemSelect.CurrentRow.Cells("ItemCode").Value.ToString
            txtCategory.Text = rgvItemSelect.CurrentRow.Cells("Category").Value.ToString
            txtIMDesc.Text = rgvItemSelect.CurrentRow.Cells("ItemName").Value.ToString
            ddlItemUOM.Text = rgvItemSelect.CurrentRow.Cells("BuyUnitMsr").Value.ToString
        Catch ex As Exception

        End Try

        CheckClear()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemCode.Text = ""
        txtCategory.Text = ""
        txtIMDesc.Text = ""
        mebItemQTY.Text = 0
        ddlItemUOM.Text = ""

        btnClear.Enabled = False
    End Sub

    Private Sub mebItemQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mebItemQTY.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub mebRemBud_TextChanged(sender As Object, e As EventArgs)

        If mebRemBud.Value < 0 Then
            mebRemBud.BackColor = Color.Orange
        Else
            mebRemBud.BackColor = Color.Transparent
        End If

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mebAmount_TextChanged(sender As Object, e As EventArgs) Handles mebAmount.ValueChanged

        CurrencyRate()
        DeductPR()
    End Sub

    Private Sub DeductPR()
        Try
            mebRemBLPR.Value = Convert.ToDecimal(mebRemBud.Value) - Convert.ToDecimal(Convert.ToDecimal(mebEPA.Value) + Convert.ToDecimal(mebTOPRA.Value))

            mebRemDBLPR.Value = Convert.ToDecimal(RemDeptBud.Value) - Convert.ToDecimal(Convert.ToDecimal(mebEPA.Value) + Convert.ToDecimal(mebTOPDRA.Value))
        Catch ex As Exception

        End Try

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
                myCmd.CommandText = "select Currency, Rate from ORTT where RateDate = '" & dtpMOrder.Value & "' and Currency = '" & ddlCurrency.Text & "'"

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
    Function GetTJPY()
        dtLoadTJPY = Chinita.fetchDBTable("call SP_GetTJPY('" & ddlBRNum.Text & "')")

        Dim QueryTJPY = dtLoadTJPY.AsEnumerable().Sum(Function(r) CType(r("fldEJPY"), Decimal))
        Return Convert.ToString(QueryTJPY)
    End Function
    Function GetTDJPY()
        Dim drCheckYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
        Dim CheckYear As String = drCheckYear.Item("fldLimit")
        'Dim CheckYear As String = "2018"

        dtLoadTDJPY = Chinita.fetchDBTable("call SP_GetTDJPY('" & ddlDept.Text & "','" & CheckYear & "')")

        Dim QueryTDJPY = dtLoadTDJPY.AsEnumerable().Sum(Function(r) CType(r("fldEJPY"), Decimal))
        Return Convert.ToString(QueryTDJPY)
    End Function
    Private Sub TOEA()
        '--------------------Created 1-4-2019---------------------------------
        Dim TJPY As Decimal = GetTJPY()
        Dim TDJPY As Decimal = GetTDJPY()

        mebTOPRA.Value = TJPY
        mebTOPDRA.Value = TDJPY
        '----------------------------------------------
        '--------------------------------Comment 1-4-2019 Change linq----------------------------------
        'Dim myCmd As New MySqlCommand
        'Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        'Dim myData As New DataTable
        'Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        'conn.Open()
        'myCmd.Connection = conn

        'Dim drCheckYear As DataRow = Chinita.fetchMySqlRow("SELECT * from tblSettings WHERE fldProID = '4'")
        'Dim CheckYear As String = drCheckYear.Item("fldLimit")

        'myCmd.CommandText = "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY', " _
        '    & "(SELECT if(PRD.fldEJPY is not null,sum(PRD.fldEJPY),0) FROM tblOrder PRD " _
        '    & "where (select count(MO.fldTransCode) from tblMOI MO " _
        '    & "where MO.fldTransCode = PRD.fldTransCode and MO.fldStat = 'OPEN') != 0 " _
        '    & "and fldOrderDepartment = '" & ddlDept.Text & "') as 'TDJPY' FROM tblOrder PR " _
        '    & "where (select count(MO.fldTransCode) from tblMOI MO where MO.fldTransCode = PR.fldTransCode and MO.fldStat = 'OPEN') != 0 " _
        '    & "and PR.fldBudRefNum = '" & ddlBRNum.Text & "'"
        '----------------------------------------------------------------------------------------------------

        '..................................Changed 1-5-2016........................................................
        'myCmd.CommandText = "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY'" & _
        '",(SELECT if(PRD.fldEJPY is not null,sum(PRD.fldEJPY),0) " & _
        '"FROM tblOrder PRD where " & _
        '"PRD.fldOrderStatus = 'OPEN'" & _
        '"and PRD.fldOrderDepartment = '" & ddlDept.Text & "' and YEAR(PRD.fldMO) = '" & CheckYear & "') as 'TDJPY'" & _
        '"FROM tblOrder PR where  PR.fldOrderStatus = 'OPEN'" & _
        '"and PR.fldBudRefNum = '" & ddlBRNum.Text & "'"
        '..........................................................................................

        '--------------------------------Comment 1-4-2019 Change linq----------------------------------
        'myAdapter.SelectCommand = myCmd
        'myAdapter.Fill(myData)

        'mebTOPRA.Text = myData.Rows(0).Item("TJPY")
        'mebTOPDRA.Text = myData.Rows(0).Item("TDJPY")
        '----------------------------------------------------------------------------------------------------
    End Sub

    Private Sub mebRemBLPR_ValueChanged(sender As Object, e As EventArgs)
        If mebRemBLPR.Value < 0 Then
            'mebRemBLPR.BackColor = Color.Orange
            'Fivepercent()
        Else
            mebRemBLPR.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            OrderInfoMulti()
            RemBudMultiOrder()
            TOEA()
            DeductPR()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkNewPR_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkNewPR.ToggleStateChanged
        If chkNewPR.Checked = True Then

            txtPRNum.Text = ""
            ddlCurrency.Text = ""
            ddlCurrency.Enabled = True
            txtPRNum.Enabled = False

        Else

            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
            Dim myCmd As New MySqlCommand
            Dim ddlvalues As MySqlDataReader

            Try
                ddlCurrency.Enabled = False

                conn.Open()
                myCmd.Connection = conn
                myCmd.CommandText = "select concat(fldYear,'-',fldPRKey) as PRNOAI from tblPRNo where fldDept = '" & ddlDept.Text & "'"
                ddlvalues = myCmd.ExecuteReader()
                txtPRNum.DataSource = ddlvalues
                txtPRNum.DisplayMember = "PRNOAI"
                txtPRNum.Enabled = True

                GetRate()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub dtpMOrder_ValueChanged(sender As Object, e As EventArgs) Handles dtpMOrder.ValueChanged
        GetRate()
        CurrencyRate()
    End Sub

    Private Sub txtPRNum_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles txtPRNum.SelectedIndexChanged

        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            myCmd.Connection = conn
            myCmd.CommandText = "select distinct fldEC from tblOrder where fldPRNo = '" & txtPRNum.Text & "'"
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            ddlCurrency.Text = myData.Rows(0).Item("fldEC")

            If chkNewPR.Checked = False Then
                GetRate()
            End If

        Catch ex As Exception

        End Try
        
    End Sub


    Private Sub CBNA_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CBNA.ToggleStateChanged
        If CBNA.Checked = True Then
            txtMoldDie.Enabled = False
            txtMoldDie.Text = "N/A"
        Else
            txtMoldDie.Enabled = True
            txtMoldDie.Text = ""
        End If
    End Sub

    Private Sub btnRefresHItemCode_Click(sender As Object, e As EventArgs) Handles btnRefresHItemCode.Click
        GetItemCodeSap()
    End Sub

    Private Sub cbInvestment_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbInvestment.ToggleStateChanged
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

    Private Sub ddlInvestment_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ddlInvestment.SelectedIndexChanged
        Try
            Dim PRAmount As Decimal = ddlInvestment.EditorControl.CurrentRow.Cells("PR AMOUNT").Value.ToString
            Dim InvAppBud As Decimal = ddlInvestment.EditorControl.CurrentRow.Cells("APPROVED BUDGET").Value.ToString

            txtInvestmentAppBud.Value = ddlInvestment.EditorControl.CurrentRow.Cells("APPROVED BUDGET").Value.ToString
            txtInvBudBalance.Value = Convert.ToString(InvAppBud - PRAmount)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        If Zaji.IsFormOpen(FrmRemBudLessPR) Then
            FrmRemBudLessPR.Focus()
        Else
            FrmRemBudLessPR.Show()
        End If
    End Sub


End Class

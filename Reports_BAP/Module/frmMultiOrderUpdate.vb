Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmMultiOrderUpdate

    Dim dt1 As New DataTable
    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable

    Private Sub FrmMultiOrderUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)

        Clear()

        GenTCNo()

        ClassMultiOrderUpdate()
        DepartmentMultiOrderUpdate()
        ProcessMultiOrderUpdate()
        ECC()

        IMCategoryMultiOrderUpdate()
        ddlCat.Text = ""

        ReadyGrid()

        ReadyGridListItem()

        GetUser()

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

        ' ddlDept.Text = drUser.Item("fldDept").ToString

    End Sub

    Private Sub ECC()

        If rgvList.Rows.Count = 0 Then
            ddlCurency1.Enabled = True
        Else
            ddlCurency1.Enabled = False
        End If

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

    Private Sub Clear()

        ddlBRNum.Text = ""
        txtPONum.Text = ""
        txtPRNum.Text = ""
        dtpMOrder.Value = Today
        txtSupplier.Text = ""
        'txtDesc.Text = ""
        ddlClass.Text = ""
        ddlDept.Text = ""
        ddlProcess.Text = ""
        'mebQTY.Text = ""
        mebRemQTY.Text = ""
        'ddlUOM.Text = ""
        'mebJPYAmount.Text = ""
        'dtpMDelivery.Value = Today
        ddlStat.Text = "OPEN"
        mebRemBud.Text = ""
        txtRemarks.Text = ""

        txtReason.Enabled = False

        ddlBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlStat.Enabled = True

    End Sub

    Public Sub GenTCode()

        Dim TransCode As String
        TransCode = "TC00" + lblTCID.Text + "-" + ddlDept.Text

        RadMessageBox.Show(TransCode)

    End Sub

    Private Sub CloseItem()

        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        If rgvListItem.CurrentRow.Cells("fldStat").Value = "REMOVED" Then
            RadMessageBox.Show("Item Already Removed!", "Notification", MessageBoxButtons.OK)

        ElseIf rgvListItem.CurrentRow.Cells("fldStat").Value = "CLOSE" Then
            RadMessageBox.Show("Item Already in Acquisition!", "Notification", MessageBoxButtons.OK)

        Else

            If rgvListItem.SelectedRows.Count > 0 Then
                RadMessageBox.SetThemeName("Windows8Theme1")

                If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to remove this Order?", _
                                      "Remove Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    Try
                        conn.Open()
                        myCmd.Connection = conn

                        myCmd.CommandText = "UPDATE tblMOI set fldStat = 'REMOVED' where fldMOIID = '" & rgvListItem.CurrentRow.Cells("fldMOIID").Value & "'"

                        myCmd.ExecuteNonQuery()

                        conn.Close()
                    Catch ex As Exception

                    End Try

                    bwLoadData.RunWorkerAsync()

                End If

            Else
                RadMessageBox.Show("Select Item to Remove")
            End If

        End If

        CheckOpenStat()

    End Sub

    Private Sub CheckOpenStat()

        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim y As Integer

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "select count(fldMOIID) as chick2 from tblMOI where fldTransCode = '" & txtTC.Text & "' and fldStat = 'OPEN'"
        myCmd.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        y = myData.Rows(0).Item("chick2")

        If y = 0 Then
            myCmd2.Connection = conn

            myCmd2.CommandText = "UPDATE tblOrder SET fldOrderStatus = 'CLOSE' WHERE fldTransCode = '" & txtTC.Text & "'"
            myCmd2.ExecuteNonQuery()

            ddlStat.Text = "CLOSE"
            btnCopyTo.Enabled = False
        End If

        conn.Close()

    End Sub

    Private Sub ReadyGridListItem()

        'Dim checkBoxColumn As New GridViewCheckBoxColumn()
        'With checkBoxColumn
        '    .Name = "CheckBoxColumn"
        '    .FieldName = ""
        '    .HeaderText = ""
        '    .Width = 30
        '    .IsPinned = True
        '    .PinPosition = PinnedColumnPosition.Left
        'End With
        'rgvListItem.MasterTemplate.Columns.Add(checkBoxColumn)

        Dim fldMOIID As New GridViewTextBoxColumn("ID")
        With fldMOIID
            .FieldName = "fldMOIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldMOIID)

        Dim fldTransCodeColumn As New GridViewTextBoxColumn("TransCode")
        With fldTransCodeColumn
            .FieldName = "fldTransCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldTransCodeColumn)

        Dim fldICColumn As New GridViewTextBoxColumn("ITEM_CODE")
        With fldICColumn
            .FieldName = "fldICode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvListItem.Columns.Add(fldICColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvListItem.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvListItem.Columns.Add(fldQTYColumn)

        Dim fldUNITColumn As New GridViewTextBoxColumn("UNIT")
        With fldUNITColumn
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 60
        End With
        rgvListItem.Columns.Add(fldUNITColumn)

        Dim fldUPColumn As New GridViewTextBoxColumn("UNIT_PRICE")
        With fldUPColumn
            .FieldName = "fldUPrice"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvListItem.Columns.Add(fldUPColumn)
        rgvListItem.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldTotalCost As New GridViewTextBoxColumn("TOTAL_COST")
        With fldTotalCost
            .FieldName = "fldTotalCost"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvListItem.Columns.Add(fldTotalCost)
        rgvListItem.Columns("fldTotalCost").FormatString = "{0:N2}"

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "fldStat"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvListItem.Columns.Add(fldStatColumn)

        Dim fldMDeliveryColumn As New GridViewDateTimeColumn("MONTH OF DELIVERY")
        With fldMDeliveryColumn
            .FieldName = "fldMonthDelivery"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldMDeliveryColumn)
        rgvListItem.Columns("fldMonthDelivery").FormatString = "{0:MMM dd, yyyy}"

        Dim fldSignatureColumn As New GridViewTextBoxColumn("ORDERED BY")
        With fldSignatureColumn
            .FieldName = "fldSignature"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvListItem.Columns.Add(fldSignatureColumn)

        Dim fldDeleteColumn As New GridViewCommandColumn("    ")
        With fldDeleteColumn
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .UseDefaultText = True
            .DefaultText = "REMOVE"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With

        AddHandler rgvListItem.CommandCellClick, AddressOf CloseItem
        rgvListItem.Columns.Add(fldDeleteColumn)

        With rgvListItem
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

        End With

    End Sub

    Private Sub ReadyGrid()

        Dim fldICColumn As New GridViewTextBoxColumn("ITEM_CODE")
        With fldICColumn
            .FieldName = "fldItemCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvList.Columns.Add(fldICColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUNITColumn As New GridViewTextBoxColumn("UNIT")
        With fldUNITColumn
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvList.Columns.Add(fldUNITColumn)

        Dim fldUPColumn As New GridViewDecimalColumn("UNIT_PRICE")
        With fldUPColumn
            .FieldName = "fldUPrice"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvList.Columns.Add(fldUPColumn)
        rgvList.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldTotalCost As New GridViewDecimalColumn("TOTAL_COST")
        With fldTotalCost
            .FieldName = "fldTotalCost"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
        End With
        rgvList.Columns.Add(fldTotalCost)
        rgvList.Columns("fldTotalCost").FormatString = "{0:N2}"

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = True
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        frmOrder.Show()
        frmOrder.bwLoadData.RunWorkerAsync()
        frmOrder.ClearOrder()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If String.IsNullOrEmpty(ddlCat.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Category Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlItemCode.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Code Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlIMDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Description Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlItemUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Unit of Measurement Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf mebItemQTY.Text = 0 Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Quantity", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

            'ElseIf mebItemUnitPrice.Text = 0.0 Then
            '    RadMessageBox.SetThemeName("Windows8Theme1")
            '    RadMessageBox.Show("No Unit Price", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else
            rgvList.Rows.Add(ddlItemCode.Text, ddlIMDesc.Text, mebItemQTY.Text, ddlItemUOM.Text, mebItemUnitPrice.Text, mebItemQTY.Text * mebItemUnitPrice.Text)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If rgvList.SelectedRows.Count > 0 Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            If RadMessageBox.Show("Remove item", "Remove Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                rgvList.Rows.Remove(rgvList.SelectedRows(0))
            Else
                RadMessageBox.Show("Select Item to Remove")
            End If
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        dtLoadData = Chinita.fetchDBTable("select fldMOIID, fldBudRefNum, fldICode, fldDesc, fldQTY, fldUnit, fldUPrice, fldStat, fldTotalCost, fldMonthDelivery, fldSignature from tblMOI where fldTransCode = '" & txtTC.Text & "' ORDER BY fldStat")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvListItem.DataSource = dtLoadData
    End Sub

    Private Sub mebJPYAmount_TextChanged(sender As Object, e As EventArgs) Handles mebJPYAmount.TextChanged
        CurrencyRate()
    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        CurrencyRate()
    End Sub

    Private Sub btnUpdateMulOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateMulOrder.Click
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        If rgvList.RowCount = 0 Then
            RadMessageBox.Show("No Item to Add/Update! Please Add Items", "Order Added", MessageBoxButtons.OK)

        Else

            Try
                conn.Open()
                myCmd.Connection = conn
                myCmd2.Connection = conn

                Dim TransCode, Curr As String

                Dim TC, BRNum, Status, ICode, Desc, Unit, Currency As String
                Dim QTY, ConID, ConID2 As Integer
                Dim UPrice, Total As Decimal
                Dim MOrder, MO As Date

                TransCode = txtTC.Text
                Curr = ddlCurrency.Text
                MOrder = dtpMOrder.Value
                ConID = lblUserID.Text

                For x As Integer = 0 To rgvList.Rows.Count - 1
                    TC = TransCode
                    BRNum = ddlBRNum.Text
                    ICode = rgvList.Rows(x).Cells(0).Value
                    Desc = rgvList.Rows(x).Cells(1).Value
                    QTY = rgvList.Rows(x).Cells(2).Value
                    Unit = rgvList.Rows(x).Cells(3).Value
                    UPrice = rgvList.Rows(x).Cells(4).Value
                    Total = rgvList.Rows(x).Cells(5).Value
                    Currency = Curr
                    Status = "OPEN"
                    MO = MOrder
                    ConID2 = ConID

                    myCmd.CommandText = "INSERT INTO tblMOI(fldTransCode, fldBudRefNum, fldICode, fldDesc, fldQTY, fldUnit, fldUPrice, fldTotalCost, fldCurrency, fldStat, fldUID, fldMO) " _
                                     & "values(@fldTransCode,@fldBudRefNum,@fldICode,@fldDesc,@fldQTY,@fldUnit,@fldUPrice,@fldTotalCost,@fldCurrency,@fldStat,@fldUID,@fldMO)"

                    With myCmd.Parameters
                        .AddWithValue("@fldTransCode", TC)
                        .AddWithValue("@fldBudRefNum", BRNum)
                        .AddWithValue("@fldICode", ICode)
                        .AddWithValue("@fldDesc", Desc)
                        .AddWithValue("@fldQTY", QTY)
                        .AddWithValue("@fldUnit", Unit)
                        .AddWithValue("@fldUPrice", UPrice)
                        .AddWithValue("@fldTotalCost", Total)
                        .AddWithValue("@fldCurrency", Currency)
                        .AddWithValue("@fldStat", Status)
                        .AddWithValue("@fldUID", ConID2)
                        .AddWithValue("@fldMO", MO)
                    End With

                    myCmd.ExecuteNonQuery()
                    myCmd.Parameters.Clear()

                Next

                myCmd2.CommandText = "UPDATE tblORDER SET fldAmountJPY = (SELECT SUM(fldTotalCost) FROM tblMOI WHERE fldTransCode = '" & txtTC.Text & "' AND fldStat = 'OPEN') WHERE fldOrderID"

                conn.Close()
                RadMessageBox.Show("Multiple Order Added!", "Order Added", MessageBoxButtons.OK)
                rgvList.Rows.Clear()

                bwLoadData.RunWorkerAsync()

            Catch ex As Exception

            End Try

            frmOrder.Show()

        End If

        Me.Close()

    End Sub

    Private Sub FilterCopyMultiOrderUpdate()
        '----- check if multiOrder has REMOVE ITEM
        'Dim myCmd As New MySqlCommand
        'Dim myCmd2 As New MySqlCommand
        'Dim myCmd3 As New MySqlCommand
        'Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        'Dim myAdapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        'Dim myData As New DataTable
        'Dim myData2 As New DataTable
        'Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        'Dim y As String

        'myCmd2.Connection = conn

        'myCmd2.CommandText = "select count(fldMOIID) as chick2 from tblMOI where fldTransCode = '" & txtTC.Text & "' and fldStat = 'OPEN'"
        'myCmd2.ExecuteNonQuery()

        'myAdapter2.SelectCommand = myCmd2
        'myAdapter2.Fill(myData2)

        'y = myData2.Rows(0).Item("chick2")

        'If y = 0 Then
        '    myCmd3.Connection = conn

        '    myCmd3.CommandText = "UPDATE tblOrder SET fldOrderStatus = 'CLOSE' WHERE fldTransCode = '" & txtTC.Text & "'"
        '    myCmd3.ExecuteNonQuery()

        '    ddlStat.Text = "CLOSE"
        '    btnCopyTo.Enabled = False
        'End If

        For x As Integer = 0 To rgvListItem.SelectedRows.Count - 1

            If rgvListItem.SelectedRows(x).Cells("fldStat").Value = "REMOVED" Then
                btnCopyTo.Enabled = False
                Exit Sub

            ElseIf rgvListItem.SelectedRows(x).Cells("fldStat").Value = "CLOSE" Then
                btnCopyTo.Enabled = False
                Exit Sub
            Else
                btnCopyTo.Enabled = True
            End If

        Next

    End Sub

    Private Sub rgvListItem_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvListItem.CellClick
        FilterCopyMultiOrderUpdate()
    End Sub

    Private Sub btnCopyTo_Click(sender As Object, e As EventArgs) Handles btnCopyTo.Click

        RadMessageBox.SetThemeName("Windows8Theme1")
        If txtPONum.Text = "" Then
            RadMessageBox.Show("Please Insert Purchase Order Number to Transfer this Items!", "Notification", MessageBoxButtons.OK)

        ElseIf String.IsNullOrEmpty(txtSupplier.Text) Then
            RadMessageBox.Show("Please Insert Supplier to Transfer this Items!", "Notification", MessageBoxButtons.OK)

        ElseIf RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to copy this item to Acquisition?", _
                                              "Close Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            frmDRAA.Show(Me)
        Else

        End If

    End Sub

    Private Sub btnIR_Click(sender As Object, e As EventArgs) Handles btnIR.Click

        reporttype = 7

        dt.Rows.Clear()
        dt.Columns.Clear()

        dt.Columns.Add("ITEM_CODE", GetType(String))
        dt.Columns.Add("DESCRIPTION", GetType(String))
        dt.Columns.Add("QTY", GetType(Integer))
        dt.Columns.Add("UNIT", GetType(String))
        dt.Columns.Add("UNIT_PRICE", GetType(Decimal))
        dt.Columns.Add("TOTAL_COST", GetType(Decimal))

        For x As Integer = 0 To rgvListItem.ChildRows.Count - 1

            If rgvListItem.ChildRows(x).Cells("fldStat").Value.ToString = "OPEN" Then

                Dim IC As String = rgvListItem.ChildRows(x).Cells("fldICode").Value.ToString
                Dim Desc As String = rgvListItem.ChildRows(x).Cells("fldDesc").Value.ToString
                Dim QTY As Integer = Convert.ToInt32(rgvListItem.ChildRows(x).Cells("fldQTY").Value.ToString)
                Dim unit As String = rgvListItem.ChildRows(x).Cells("fldUnit").Value.ToString
                Dim UP As Decimal = Convert.ToDecimal(rgvListItem.ChildRows(x).Cells("fldUPrice").Value.ToString)
                Dim TCost As Decimal = Convert.ToDecimal(rgvListItem.ChildRows(x).Cells("fldTotalCost").Value.ToString)

                dt.Rows.Add(IC, Desc, QTY, unit, UP, TCost)

            Else

            End If

        Next

        frmReport.Show()
        frmReport.ReportViewer1.Refresh()

    End Sub

    Private Sub ddlCat_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlCat.SelectedValueChanged
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim ddlvalues As MySqlDataReader
        Dim ddlvalues2 As MySqlDataReader

        '----------ITEM CODE----------'

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldStat, fldIMItemCode, fldIMCat from tblIM where fldIMCat = '" & ddlCat.Text & "' and fldStat = 'OPEN'"

        ddlvalues = myCmd.ExecuteReader()
        ddlItemCode.DataSource = ddlvalues
        ddlItemCode.DisplayMember = "fldIMItemCode"

        ddlItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlItemCode.AutoCompleteDataSource = AutoCompleteSource.CustomSource

        myCmd.Connection.Close()

        '----------DESCRIPTION----------'

        conn2.Open()
        myCmd2.Connection = conn2
        myCmd2.CommandText = "select fldStat, fldIMCat, fldIMItemDesc from tblIM where fldIMCat = '" & ddlCat.Text & "' and fldStat = 'OPEN'"

        ddlvalues2 = myCmd2.ExecuteReader()
        ddlIMDesc.DataSource = ddlvalues2
        ddlIMDesc.DisplayMember = "fldIMItemDesc"

        ddlIMDesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlIMDesc.AutoCompleteDataSource = AutoCompleteSource.CustomSource

        myCmd2.Connection.Close()

        ddlItemCode.Text = ""
        ddlIMDesc.Text = ""

    End Sub

    Private Sub ddlItemCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlItemCode.SelectedValueChanged
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()

            myCmd.Connection = conn

            myCmd.CommandText = "select fldStat, fldIMItemCode, fldIMItemDesc from tblIM where fldIMItemCode = '" & ddlItemCode.Text & "' and fldStat = 'OPEN'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            conn.Close()

            ddlIMDesc.Text = myData.Rows(0).Item("fldIMItemDesc").ToString

        Catch ex As Exception
            ' RadMessageBox.Show("Please Select Item Code!", "Notification", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ddlIMDesc_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlIMDesc.SelectedValueChanged
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()

            myCmd.Connection = conn

            myCmd.CommandText = "select fldStat, fldIMItemCode, fldIMItemDesc from tblIM where fldIMItemDesc = '" & ddlIMDesc.Text & "' and fldStat = 'OPEN'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            conn.Close()

            ddlItemCode.Text = myData.Rows(0).Item("fldIMItemCode").ToString

        Catch ex As Exception
            ' RadMessageBox.Show("Please Select Item Code!", "Notification", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub ddlCurency1_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurency1.SelectedIndexChanged
        ddlCurrency.Text = ddlCurency1.Text
    End Sub

End Class
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

    Private Sub FrmMultiOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)

        GenTCNo()

        ClassMultiOrder()
        DepartmentMultiOrder()
        ProcessMultiOrder()
        ECC()

        'IMCategoryMultiOrder()
        'ddlIMDesc.Text = ""
        'ddlItemCode.Text = ""
        GetCatSap()

        ddlStat.Text = "OPEN"

        ddlClass.Text = ""
        ddlDept.Text = ""
        ddlProcess.Text = ""
        ddlCat.Text = ""

        ReadyGrid()

        'GetUser()

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

        ' ddlDept.Text = drUser.Item("fldDept").ToString

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

    Private Sub ECC()

        If rgvList.Rows.Count = 0 Then
            ddlCurency1.Enabled = True
        Else
            ddlCurency1.Enabled = False
        End If

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

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
        frmOrderPicker.rbMO.IsChecked = False
        frmOrderPicker.rbSO.IsChecked = False
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

            If rgvList.Rows.Count = 0 Then
                ddlCurrency.Enabled = True
            Else
                ddlCurency1.Enabled = False
            End If

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If rgvList.SelectedRows.Count > 0 Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            If RadMessageBox.Show("Remove item", "Remove Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                rgvList.Rows.Remove(rgvList.SelectedRows(0))
            Else
                RadMessageBox.Show("Select Item to Remove")
            End If
        End If
    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveMulOrder.Click

        btnpicker = 2

        Dim match = String.Compare(ddlDept.Text, lblDept.Text, ignoreCase:=False)

        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        GenTCNo()
        GenTCode()

        '----- BORROWED BUDGET -----'
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

            '----- SAME DEPT | MULTIPLE ORDER -----'
            Try
                conn.Open()
                myCmd.Connection = conn

                Dim TransCode, Curr As String

                Dim TC, BRNum, Status, ICode, Desc, Unit, Currency, Classification, Dept, Process As String
                Dim QTY As Integer
                Dim UPrice, Total As Decimal
                Dim MO, ColMO As Date

                TransCode = "TC00" + lblTCID.Text + "-" + ddlDept.Text
                Curr = ddlCurrency.Text
                MO = dtpMOrder.Value

                '------------------------------------------------------
                Tomboy.AddOrderM(ddlBRNum.Text, _
                                 TransCode, _
                                 txtPONum.Text, _
                                 txtPRNum.Text, _
                                 dtpMOrder.Value, _
                                 txtSupplier.Text, _
                                 txtDesc.Text, _
                                 ddlClass.Text, _
                                 ddlDept.Text, _
                                 ddlProcess.Text, _
                                 ddlCurrency.Text, _
                                 mebYEN.Text, _
                                 mebQTY.Text, _
                                 ddlUOM.Text, _
                                 mebJPYAmount.Text, _
                                 ddlStat.Text, _
                                 txtReason.Text, _
                                 txtRemarks.Text, _
                                 txtSignature.Text, _
                                 dtpMOrder.Value)
                
                '------------------------------------------------------

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
                    ColMO = MO
                    Classification = ddlClass.Text
                    Dept = ddlDept.Text
                    Process = ddlProcess.Text

                    myCmd.CommandText = "INSERT INTO tblMOI(fldTransCode, fldBudRefNum, fldICode, fldDesc, fldQTY, " _
                                        & "fldUnit, fldUPrice, fldTotalCost, fldCurrency, fldStat, fldMO, " _
                                        & "fldSupplier, fldClass, fldDept, fldProcess) " _
                                        & "values(@fldTransCode,@fldBudRefNum,@fldICode,@fldDesc,@fldQTY," _
                                        & "@fldUnit,@fldUPrice,@fldTotalCost,@fldCurrency,@fldStat,@fldMO," _
                                        & "@fldClass,@fldDept,@fldProcess)"

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
                        .AddWithValue("@fldMO", ColMO)
                        .AddWithValue("@fldClass", Classification)
                        .AddWithValue("@fldDept", Dept)
                        .AddWithValue("@fldProcess", Process)
                    End With

                    myCmd.ExecuteNonQuery()
                    myCmd.Parameters.Clear()

                Next

                conn.Close()

                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK)

                Clear()
                GenTCNo()

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Clear()

        txtTC.Text = ""
        ddlCat.Text = ""
        ddlItemCode.Text = ""
        mebItemQTY.Text = 0
        ddlUOM.Text = ""
        mebItemUnitPrice.Text = ""

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

        rgvList.Rows.Clear()

        txtReason.Enabled = False

        ddlBRNum.Enabled = True
        ddlDept.Enabled = True
        ddlStat.Enabled = True

    End Sub

    Private Sub ddlDept_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlDept.SelectedIndexChanged
        GetDeptData()
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
    Public Sub CurrencyRate()
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

    Private Sub rgvList_CurrentCellChanged(sender As Object, e As CurrentCellChangedEventArgs) Handles rgvList.CurrentCellChanged
        ECC()
    End Sub

    Private Sub rgvList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.RowsChanged

        Dim QTY As Integer = 0
        Dim TCost As Decimal = 0.0

        For x As Integer = 0 To rgvList.Rows.Count - 1
            QTY = QTY + rgvList.Rows(x).Cells("fldQTY").Value
            TCost = TCost + rgvList.Rows(x).Cells("fldTotalCost").Value
        Next

        mebQTY.Text = QTY
        mebJPYAmount.Text = TCost

    End Sub

    Private Sub ddlCat_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlCat.SelectedValueChanged

        Dim conn As New SqlClient.SqlConnection(Sapsap)
        Dim conn2 As New SqlClient.SqlConnection(Sapsap)
        Dim myCmd As New SqlClient.SqlCommand
        Dim myCmd2 As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader
        Dim ddlvalues2 As SqlDataReader

        ''----------ITEM CODE----------'

        Try

            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "select T0.ItemCode,T0.ItemName,T0.BuyUnitMsr from OITM T0 where T0.ItmsGrpCod = " _
                & "case '" & ddlCat.Text & "' WHEN 'Finished Goods' THEN '100' " _
                & "WHEN 'Work In Progress' THEN '101' " _
                & "WHEN 'Raw Materials' THEN '102' " _
                & "WHEN 'Spare Parts' THEN '103' " _
                & "WHEN 'Office Supplies' THEN '104' " _
                & "WHEN 'Packaging' THEN '105' " _
                & "WHEN 'Fabrication' THEN '106' " _
                & "WHEN 'Others' THEN '107' " _
                & "WHEN 'Supplies Others' THEN '108' " _
                & "WHEN 'FFC Manufacturing' THEN '109' " _
                & "End "

            ddlvalues = myCmd.ExecuteReader()
            ddlItemCode.DataSource = ddlvalues
            ddlItemCode.DisplayMember = "ItemCode"

            ddlItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ddlItemCode.AutoCompleteDataSource = AutoCompleteSource.CustomSource

            myCmd.Connection.Close()

            ''----------DESCRIPTION----------'

            conn2.Open()
            myCmd2.Connection = conn2
            myCmd2.CommandText = "select T0.ItemCode,T0.ItemName,T0.BuyUnitMsr from OITM T0 where T0.ItmsGrpCod = " _
                & "case '" & ddlCat.Text & "' WHEN 'Finished Goods' THEN '100' " _
                & "WHEN 'Work In Progress' THEN '101' " _
                & "WHEN 'Raw Materials' THEN '102' " _
                & "WHEN 'Spare Parts' THEN '103' " _
                & "WHEN 'Office Supplies' THEN '104' " _
                & "WHEN 'Packaging' THEN '105' " _
                & "WHEN 'Fabrication' THEN '106' " _
                & "WHEN 'Others' THEN '107' " _
                & "WHEN 'Supplies Others' THEN '108' " _
                & "WHEN 'FFC Manufacturing' THEN '109' " _
                & "End "

            ddlvalues2 = myCmd2.ExecuteReader()
            ddlIMDesc.DataSource = ddlvalues2
            ddlIMDesc.DisplayMember = "ItemName"

            ddlIMDesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ddlIMDesc.AutoCompleteDataSource = AutoCompleteSource.CustomSource

            myCmd2.Connection.Close()

            ddlItemCode.Text = ""
            ddlIMDesc.Text = ""
        Catch ex As Exception

        End Try

       

    End Sub

    Private Sub ddlItemCode_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlItemCode.SelectedValueChanged

        Dim conn As New SqlClient.SqlConnection(Sapsap)
        Dim myCmd As New SqlClient.SqlCommand
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myAdapter As New SqlClient.SqlDataAdapter
     
        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "select T0.ItemName, T0.BuyUnitMsr from OITM T0 where T0.ItemCode = '" & ddlItemCode.Text & "'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)
            myAdapter.Fill(myData2)

            conn.Close()

            ddlIMDesc.Text = myData.Rows(0).Item("ItemName").ToString
            ddlItemUOM.Text = myData2.Rows(0).Item("BuyUnitMsr").ToString

        Catch ex As Exception

        End Try

    End Sub


    Private Sub ddlIMDesc_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlIMDesc.SelectedValueChanged

        Dim conn As New SqlClient.SqlConnection(Sapsap)
        Dim myCmd As New SqlClient.SqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "select T0.ItemCode from OITM T0 where T0.ItemName = '" & ddlIMDesc.Text & "'"
  
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            conn.Close()

            ddlItemCode.Text = myData.Rows(0).Item("ItemCode").ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlBRNum.SelectedIndexChanged
        Try
            OrderInfoMulti()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ddlCurency1_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurency1.SelectedIndexChanged

        ddlCurrency.Text = ddlCurency1.Text

    End Sub

End Class

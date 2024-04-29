Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class FrmCPO

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable


    Private Sub FrmCPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)

        ReadyGrid()
        ReadyItemGrid()

        GetSupSap()

        dtpMOrder.Value = Today
        dtpDelDate.Value = Today

        ddlSupSap.Text = ""

        bwLoadData.RunWorkerAsync()

        GetUser()

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        dtLoadData = Chinita.fetchDBTable("select tr2.fldOrderId, tr1.fldMOIID, tr1.fldQTYSOUT, tr1.fldBudRefNum, tr2.fldPRNo , tr1.fldICode, tr1.fldDesc" _
                                          & ", tr1.fldQTYEB, tr1.fldUnit, tr1.fldUPrice, tr1.fldStat, tr1.fldTotalCost, tr2.fldOrderDepartment, " _
                                          & "tr1.fldMonthDelivery, tr1.fldSignature from tblMOI tr1 left join tblOrder tr2 on tr1.fldTransCode = tr2.fldTransCode " _
                                          & "  Where fldStat = 'OPEN' ORDER BY fldStat")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub ReadyGrid()

        Dim fldOrderId As New GridViewTextBoxColumn("fldOrderId")
        With fldOrderId
            .FieldName = "fldOrderId"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldOrderId)

        Dim fldMOIID As New GridViewTextBoxColumn("ID")
        With fldMOIID
            .FieldName = "fldMOIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvList.Columns.Add(fldMOIID)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldPRNoColumn As New GridViewTextBoxColumn("PURCHASED REQ. NO.")
        With fldPRNoColumn
            .FieldName = "fldPRNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldPRNoColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldICodeColumn
            .FieldName = "fldICode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 250
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QTY")
        With fldQTYColumn
            .FieldName = "fldQTYEB"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn("Dept")
        With fldDeptColumn
            .FieldName = "fldOrderDepartment"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvList.Columns.Add(fldDeptColumn)
        Dim fldQTYOUTColumn As New GridViewTextBoxColumn("fldQTYSOUT")
        With fldQTYOUTColumn
            .FieldName = "fldQTYSOUT"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldQTYOUTColumn)


        With rgvList
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

    Private Sub ReadyItemGrid()

        Dim fldPRNoColumn As New GridViewTextBoxColumn("PURCHASED REQ. NO.")
        With fldPRNoColumn
            .FieldName = "fldPRNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            '.IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
            '.ReadOnly = True
            .IsVisible = False
        End With
        txtTotal.Columns.Add(fldPRNoColumn)

        Dim OB_LineColumn As New GridViewTextBoxColumn("OB_LINE")
        With OB_LineColumn
            .FieldName = "OB_Line"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .AllowResize = False
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_LineColumn)

        Dim OB_DocDateColumn As New GridViewTextBoxColumn("OB_DocDate")
        With OB_DocDateColumn
            .FieldName = "OB_DocDate"
            .Width = 120
            '.Format = DateTimePickerFormat.Custom
            ' .CustomFormat = "yyyyMMdd"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_DocDateColumn)
        txtTotal.Columns("OB_DocDate").FormatString = "{0:yyyyMMdd}"

        Dim OB_TaxDateColumn As New GridViewTextBoxColumn("OB_TaxDate")
        With OB_TaxDateColumn
            .FieldName = "OB_TaxDate"
            .Width = 120
            '.Format = DateTimePickerFormat.Custom
            '.CustomFormat = "yyyyMMdd"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_TaxDateColumn)
        txtTotal.Columns("OB_TaxDate").FormatString = "{0:yyyyMMdd}"

        Dim OB_DocDueDateColumn As New GridViewTextBoxColumn("OB_DocDueDate")
        With OB_DocDueDateColumn
            .FieldName = "OB_DocDueDate"
            .Width = 120
            '.Format = DateTimePickerFormat.Custom
            '.CustomFormat = "yyyyMMdd"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_DocDueDateColumn)
        txtTotal.Columns("OB_DocDueDate").FormatString = "{0:yyyyMMdd}"

        Dim OB_VendorColumn As New GridViewTextBoxColumn("OB_Vendor")
        With OB_VendorColumn
            .FieldName = "OB_Vendor"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .AllowResize = False
        End With
        txtTotal.Columns.Add(OB_VendorColumn)

        Dim OB_POAmtColumn As New GridViewDecimalColumn("OB_POAmt")
        With OB_POAmtColumn
            .FieldName = "OB_POAmt"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_POAmtColumn)
        txtTotal.Columns("OB_POAmt").FormatString = "{0:N6}"

        Dim OB_RowNumColumn As New GridViewDecimalColumn("OB_RowNum")
        With OB_RowNumColumn
            .FieldName = "OB_RowNum"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_RowNumColumn)

        Dim OB_ItemCodeColumn As New GridViewTextBoxColumn("OB_ItemCode")
        With OB_ItemCodeColumn
            .FieldName = "OB_ItemCode"
            .Width = 200
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_ItemCodeColumn)

        Dim OB_QtyColumn As New GridViewDecimalColumn("OB_Qty")
        With OB_QtyColumn
            .FieldName = "OB_Qty"
            '.ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
        End With
        txtTotal.Columns.Add(OB_QtyColumn)
        txtTotal.Columns("OB_Qty").FormatString = "{0:N6}"

        Dim OB_UnitPriceColumn As New GridViewDecimalColumn("OB_UnitPrice")
        With OB_UnitPriceColumn
            .FieldName = "OB_UnitPrice"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        txtTotal.Columns.Add(OB_UnitPriceColumn)
        txtTotal.Columns("OB_UnitPrice").FormatString = "{0:N6}"

        Dim OB_RemarksColumn As New GridViewTextBoxColumn("OB_Remarks")
        With OB_RemarksColumn
            .FieldName = "OB_Remarks"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            '   .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_RemarksColumn)

        Dim OB_Detail_IDColumn As New GridViewTextBoxColumn("OB_Detail_ID")
        With OB_Detail_IDColumn
            .FieldName = "OB_Detail_ID"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_Detail_IDColumn)

        Dim OB_DeptColumn As New GridViewTextBoxColumn("OB_Dept")
        With OB_DeptColumn
            .FieldName = "OB_Dept"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_DeptColumn)

        Dim OB_BudgetRefColumn As New GridViewTextBoxColumn("OB_BudgetRef")
        With OB_BudgetRefColumn
            .FieldName = "OB_BudgetRef"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        txtTotal.Columns.Add(OB_BudgetRefColumn)

        Dim fldOrderId As New GridViewTextBoxColumn("fldOrderId")
        With fldOrderId
            .FieldName = "fldOrderId"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        txtTotal.Columns.Add(fldOrderId)

        Dim fldQTYOUTColumn As New GridViewTextBoxColumn("fldQTYSOUT")
        With fldQTYOUTColumn
            .FieldName = "fldQTYSOUT"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        txtTotal.Columns.Add(fldQTYOUTColumn)

        Dim fldMOID As New GridViewTextBoxColumn("fldMOID")
        With fldMOID
            .FieldName = "fldMOIID"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        txtTotal.Columns.Add(fldMOID)



        Dim fldTotal As New GridViewSummaryItem("OB_LINE", "TOTAL", GridAggregateFunction.Var)
        Dim fldTCSum As New GridViewSummaryItem("OB_POAmt", "{0:N6}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldTCSum)


        With txtTotal
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
            '.ShowColumnHeaders = False
            .SummaryRowsBottom.Add(SummaryRowItem)
        End With

    End Sub

    Private Sub rgvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellDoubleClick


        If String.IsNullOrEmpty(ddlSupSap.Text) Then
            RadMessageBox.Show("Please Enter A Supplier", "Notification", MessageBoxButtons.OK)

        ElseIf String.IsNullOrEmpty(txtRemarks.Text) Then
            RadMessageBox.Show("Please Enter A Remarks", "Notification", MessageBoxButtons.OK)

        Else



            'Dim OB_MOIID As Integer = rgvList.CurrentRow.Cells("fldMOIID").Value.ToString

            'rgvID.Rows.Add(OB_MOIID)

            Dim OB_Line As String = ""
            Dim OB_DocDate As String = Convert.ToString(String.Format("{0:yyyyMMdd}", dtpMOrder.Value))
            Dim OB_TaxDate As String = Convert.ToString(String.Format("{0:yyyyMMdd}", dtpMOrder.Value))
            Dim OB_DocDueDate As String = Convert.ToString(String.Format("{0:yyyyMMdd}", dtpDelDate.Value))
            Dim OB_Vendor As String = txtVenCode.Text
            Dim OB_POAmt As Decimal = 0.0

            Dim z As Integer
            For i As Integer = 0 To txtTotal.Rows.Count + 1
                z = i
            Next
            Dim OB_RowNum As Integer = z

            Dim OB_ItemCode As String = rgvList.CurrentRow.Cells("fldICode").Value.ToString
            Dim OB_Qty As Decimal = Convert.ToInt32(rgvList.CurrentRow.Cells("fldQTYEB").Value)
            Dim OB_UnitPrice As Decimal = 0.0
            Dim OB_Remarks As String = txtRemarks.Text
            Dim OB_Detail_ID As String = ""
            Dim OB_Dept As String = rgvList.CurrentRow.Cells("fldOrderDepartment").Value.ToString
            Dim OB_BudgetRef As String = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            Dim OrdID As Integer = Convert.ToInt32(rgvList.CurrentRow.Cells("fldOrderId").Value)

            Dim QTYOUT As Integer = rgvList.CurrentRow.Cells("fldQTYSOUT").Value

            'Dim BRNum As String = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            Dim PRNum As String = rgvList.CurrentRow.Cells("fldPRNo").Value.ToString
            'Dim Desc As String = rgvList.CurrentRow.Cells("fldDesc").Value.ToString

            'Dim OID As Integer = Convert.ToInt32(rgvList.CurrentRow.Cells("fldOrderId").Value)
            Dim fldMOID As String = rgvList.CurrentRow.Cells("fldMOIID").Value.ToString
            txtTotal.Rows.Add(PRNum, OB_Line, OB_DocDate, OB_TaxDate, OB_DocDueDate, OB_Vendor, OB_POAmt, _
                              OB_RowNum, OB_ItemCode, OB_Qty, OB_UnitPrice, OB_Remarks, OB_Detail_ID, OB_Dept, OB_BudgetRef, OrdID, QTYOUT, fldMOID)

        End If

    End Sub

    Private Sub btnCPO_Click(sender As Object, e As EventArgs) Handles btnCPO.Click

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand
        Dim myCmd4 As New MySqlCommand
        Dim myCmdChecking As New MySqlCommand
        Dim myCmdOBDetailID As New MySqlCommand

        Dim myAdapterChecking As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim myAdapterOBDetailID As New MySqlDataAdapter


        Dim chk As String
        Dim Supplier As String = ddlSupSap.Text


        'Dim MO As Date = dtpMOrder.Text
        'Dim DD As Date = dtpDelDate.Text
        Dim Currency As String = ddlCurrency.Text
        Dim Discount As Decimal = RTD.Text
        Dim Amount As Decimal = RTUPrice.Text
        Dim OBAmt As Decimal = RTTotal.Text
        Dim TTPO As Decimal = RTTPO.Text
        Dim Remarks As String = txtRemarks.Text
        Dim QTYOUT As Integer = rgvList.CurrentRow.Cells("fldQTYSOUT").Value


        conn.Open()

        myCmd.Connection = conn
        myCmd2.Connection = conn
        myCmd3.Connection = conn
        myCmd4.Connection = conn
        myCmdChecking.Connection = conn


        txtTotal.ShowColumnHeaders = False

        myCmdChecking.CommandText = "select Concat('POID',if(fldPOID is not null,max(fldPOID)+1,0)) as 'OB_Line' from tblPO"
        myAdapterChecking.SelectCommand = myCmdChecking
        myAdapterChecking.Fill(myData)

        chk = myData.Rows(0).Item("OB_Line").ToString

        For y As Integer = 0 To txtTotal.ChildRows.Count - 1

            txtTotal.ChildRows(y).Cells("OB_LINE").Value = chk
            txtTotal.ChildRows(y).Cells("OB_POAmt").Value = RTTotal.Value

            'txtTotal.Rows.Add(OB_Line)

        Next

        myCmd3.CommandText = "INSERT INTO `tblPO`( `OB_Line`, `fldSupplier`, `fldMOrdered`,`fldDDate`, " _
                        & "`fldStat`, `fldCurrency`, `fldDiscount`, `fldDAmount`, `fldTPO`, `OB_POAmt`, `fldRemarks`) " _
                        & "VALUES(" _
                        & " '" & chk & "','" & Supplier & "','" & dtpMOrder.Value & "','" & dtpDelDate.Value & "', " _
                        & "'OPEN','" & Currency & "','" & Discount & "','" & Amount & "','" & TTPO & "','" & OBAmt & "','" & Remarks & "')"
        myCmd3.ExecuteNonQuery()

        For x As Integer = 0 To txtTotal.ChildRows.Count - 1
            Dim myDataOBDetailID As New DataTable
            Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

            'conn2.Open()
            myCmdOBDetailID.Connection = conn

            Dim OB_Detail_ID As Integer

            myCmdOBDetailID.CommandText = "select if(fldPOIID is not null,max(fldPOIID)+1,0) as 'OB_Detail_ID' from tblPOI"
            myAdapterOBDetailID.SelectCommand = myCmdOBDetailID
            myAdapterOBDetailID.Fill(myDataOBDetailID)

            myCmdOBDetailID.ExecuteNonQuery()
            OB_Detail_ID = myDataOBDetailID.Rows(0).Item("OB_Detail_ID").ToString

            txtTotal.ChildRows(x).Cells("OB_Detail_ID").Value = OB_Detail_ID

            Dim ID As String = txtTotal.ChildRows(x).Cells("OB_Detail_ID").Value.ToString
            Dim UP As Decimal = Convert.ToDecimal(txtTotal.ChildRows(x).Cells("OB_UnitPrice").Value)
            Dim TC As Decimal = Convert.ToDecimal(txtTotal.ChildRows(x).Cells("OB_POAmt").Value)
            Dim QTY As Integer = Convert.ToInt32(txtTotal.ChildRows(x).Cells("OB_Qty").Value)
            Dim OID As Integer = Convert.ToInt32(txtTotal.ChildRows(x).Cells("fldOrderId").Value)
            Dim PRNum As String = rgvList.CurrentRow.Cells("fldPRNo").Value.ToString
            Dim DD As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpDelDate.Text))

            Dim Signature As String = txtSignature.Text
            Dim MO As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpMOrder.Text))
            Dim fldMOID As String = txtTotal.ChildRows(x).Cells("fldMOIID").Value.ToString

            myCmd.CommandText = "INSERT INTO tblPOI(OB_Detail_ID, fldMOIID, OB_Line,fldTransCode, fldBudRefNum,fldPRNo, fldICode, fldDesc, fldQTY, " _
                                & "fldUnit, fldStat,fldUID, fldMO,fldSignature,fldUPrice, fldTotalCost,fldCurrency,fldMonthDelivery) " _
                                & "SELECT '" & OB_Detail_ID & "', fldMOIID, '" & chk & "',fldTransCode,fldBudRefNum,'" & PRNum & "',fldICode,fldDesc," & QTY & ",fldUnit,fldStat, " _
                                & "fldUID,'" & MO & "','" & Signature & "', " & UP & ", " & TC & ", '" & Currency & "', '" & DD & "' FROM tblMOI WHERE fldMOIID = '" & fldMOID & "'; "
            myCmd.ExecuteNonQuery()
            myCmdOBDetailID.Parameters.Clear()
            'conn2.Close()

            'If x = 0 Then

            'myCmd2.CommandText = "INSERT INTO `tblHPO` " _
            '                   & "fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, fldMonthDelivery, " _
            '                   & "fldReason, fldOrderStatus, fldOrderRemarks,fldNB, fldSignature, fldMO) " _
            '                   & "select " _
            '                   & "'" & OID & "','" & chk & "',fldBudRefNum,fldPONo,fldPRNo,fldTransCode,fldMonthOrder,fldOrderSupplier,fldOrderDesc, " _
            '                   & "fldClassification,fldOrderDepartment,fldProcess,fldQTY, fldUOM, fldMonthDelivery, " _
            '                   & "fldReason, fldOrderStatus, fldOrderRemarks,fldNB,fldSignature,fldMO " _
            '                   & "from tblOrder where fldOrderID = '" & OID & "'; "
            'myCmd2.ExecuteNonQuery()

            myCmd4.CommandText = "UPDATE `tblMOI` SET `fldQTYSOUT`='" & QTY & "' + '" & QTYOUT & "' WHERE `fldMOIID` ='" & fldMOID & "'"
            myCmd4.ExecuteNonQuery()

        Next

        conn.Close()

        Try
            Dim exporter As ExportToCSV = New ExportToCSV(txtTotal)
            exporter.FileExtension = "csv"

            Dim Time As String = System.DateTime.Now.ToString("ddMMyyyyHHmmss")
            exporter.SummariesExportOption = SummariesOption.DoNotExport

            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & Time & ".csv"

            exporter.RunExport(fileName)

            Dim text As String() = System.IO.File.ReadAllLines(fileName)

            For i As Integer = 0 To text.Length - 1
                text(i) = text(i).Replace("""", "")
            Next

            System.IO.File.WriteAllLines(fileName, text)

            txtTotal.ShowColumnHeaders = True

            RadMessageBox.Show("Purchased Order Created", "Notification", MessageBoxButtons.OK)

            ClearAll()

        Catch ex As Exception
            RadMessageBox.Show("Error Creating Purchased Order", "Error", MessageBoxButtons.OK)
        End Try



    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub ddlSupSap_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlSupSap.SelectedIndexChanged
        GetCurSap()
    End Sub

    Private Sub rgvListItem_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles txtTotal.CellEndEdit

        Dim x As Decimal = Convert.ToDecimal(txtTotal.CurrentRow.Cells("OB_Qty").Value)
        Dim y As Decimal = Convert.ToDecimal(txtTotal.CurrentRow.Cells("OB_UnitPrice").Value)

        txtTotal.CurrentRow.Cells("OB_POAmt").Value = x * y
        RTTPO.Text = txtTotal.MasterView.SummaryRows(0).Cells("OB_POAmt").Value

    End Sub

  

    Public Sub ND()
        If RTTPO.Value <> 0 Then
            RTTotal.Value = RTTPO.Value - RTUPrice.Text
            RTD.Value = (RTUPrice.Value / RTTPO.Value) * 100
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
        Else

        End If
    End Sub

    Private Sub RTD_Leave(sender As Object, e As EventArgs) Handles RTD.Leave
        RTUPrice.Text = ((RTTPO.Text * RTD.Text) / 100)
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
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub ClearAll()
        ddlSupSap.Text = ""
        txtVenCode.Text = ""
        ddlCurrency.Text = ""
        dtpMOrder.Value = Today
        dtpDelDate.Value = Today
        RTTPO.Text = 0.0
        RTD.Text = 0.0
        RTUPrice.Text = 0.0
        RTTotal.Text = 0.0
        txtRemarks.Text = ""

        txtTotal.Rows.Clear()
    End Sub

End Class

 
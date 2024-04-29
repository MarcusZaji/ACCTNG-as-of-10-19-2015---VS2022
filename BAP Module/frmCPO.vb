Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports System.Text.RegularExpressions

Public Class FrmCPO

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private dtLoadData3 As DataTable
    Private dtLoadData4 As DataTable

    Dim ValidChars As String =
"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-.&()@#!%/$\+? "
    Dim NotValid As String = "`~%^*_-=\|]}[{:;,<>'"""

    Private Sub frmCPO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If rgvCreatePO.Rows.Count > 0 Then
                RadMessageBox.SetThemeName("Windows8")
                If RadMessageBox.Show("There are Item(s) to Order. Are you sure you want to close this transaction?",
                                    "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Me.Close()
                End If
            Else

                If bwLoadData.IsBusy Then
                    bwLoadData.CancelAsync()
                    imBusy = False
                End If

                Me.Close()

            End If
        End If

    End Sub

    Private Sub FrmCPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadySupplierGrid()
        frmsplash.busy()

        ReadyGrid()
        ReadyItemGrid()

        dtpMOrder.Value = Today
        dtpDelDate.Value = Today

        ddlSupSap.Text = ""
        txtCurrency.Text = ""
        txtVenCode.Text = ""

        'Comment due to SAP Problem
        GetSuppGrid()
        '-------------------------
        'Replace For SAP Table
        'GetSuppGridNew()
        '--------------------------
        dtpMOrder.Value = Today
        dtpDelDate.Value = "01/01/0001"

        GetUser()

        btnCPO.Enabled = True

        'disable right click
        Dim _blankContextMenu As New RadContextMenu()
        txtRemarks.RadContextMenu = _blankContextMenu


    End Sub

    Private Sub FrmCPO_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        Me.Cursor = Cursors.WaitCursor
        bwLoadData.RunWorkerAsync()
        pbOlrayt.Visible = True

        GetDeptCode()
    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        dtLoadData = Chinita.fetchDBTable("call SP_CPO_GetItemToPOWithLimit()")

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
    Private Sub GetSuppGridNew()
        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectAllSuppliersSAPRename")
        rgvSupplier.DataSource = DTSBud
    End Sub
    Private Sub GetSuppGrid()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "SELECT T0.[CardName], T0.CardCode,T0.Currency " _
            & "FROM OCRD T0 WHERE T0.[CardType] ='S' " _
            & "ORDER BY T0.[CardName] ASC"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        rgvSupplier.Columns.Clear()


        ReadySupplierGrid()
        rgvSupplier.DataSource = myData

    End Sub

    Private Sub ReadySupplierGrid()

        Dim fldMOIID As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldMOIID
            .FieldName = "CardName"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 500
        End With
        rgvSupplier.Columns.Add(fldMOIID)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("VENDOR CODE")
        With fldBudRefColumn
            .FieldName = "CardCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldBudRefColumn)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "Currency"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldCurrencyColumn)

        With rgvSupplier
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowGroupPanel = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False

        End With
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
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldMOIID)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("SUB REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldSubRefNo"
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

        End With
        rgvList.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 250
            .TextAlignment = ContentAlignment.MiddleCenter

        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QTY")
        With fldQTYColumn
            .FieldName = "fldQTYEB"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
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

            .EnableAlternatingRowColor = True
            .EnableFiltering = True

            .ShowGroupPanel = True


            .AllowRowReorder = True
            .MultiSelect = False
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

            .IsVisible = False
        End With
        rgvCreatePO.Columns.Add(fldPRNoColumn)

        Dim OB_LineColumn As New GridViewTextBoxColumn("OB_LINE")
        With OB_LineColumn
            .FieldName = "OB_Line"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .AllowResize = False
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_LineColumn)

        Dim OB_DocDateColumn As New GridViewTextBoxColumn("OB_DocDate")
        With OB_DocDateColumn
            .FieldName = "OB_DocDate"
            .Width = 120

            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_DocDateColumn)
        rgvCreatePO.Columns("OB_DocDate").FormatString = "{0:yyyyMMdd}"

        Dim OB_TaxDateColumn As New GridViewTextBoxColumn("OB_TaxDate")
        With OB_TaxDateColumn
            .FieldName = "OB_TaxDate"
            .Width = 120

            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_TaxDateColumn)
        rgvCreatePO.Columns("OB_TaxDate").FormatString = "{0:yyyyMMdd}"

        Dim OB_DocDueDateColumn As New GridViewTextBoxColumn("OB_DocDueDate")
        With OB_DocDueDateColumn
            .FieldName = "OB_DocDueDate"
            .Width = 120

            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_DocDueDateColumn)
        rgvCreatePO.Columns("OB_DocDueDate").FormatString = "{0:yyyyMMdd}"

        Dim OB_VendorColumn As New GridViewTextBoxColumn("SUPPLIER")
        With OB_VendorColumn
            .FieldName = "OB_Vendor"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .AllowResize = False
        End With
        rgvCreatePO.Columns.Add(OB_VendorColumn)

        Dim OB_POAmtColumn As New GridViewDecimalColumn("TOTAL PO AMOUNT")
        With OB_POAmtColumn
            .FieldName = "OB_POAmt"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_POAmtColumn)
        rgvCreatePO.Columns("OB_POAmt").FormatString = "{0:N6}"

        Dim OB_RowNumColumn As New GridViewDecimalColumn("OB_RowNum")
        With OB_RowNumColumn
            .FieldName = "OB_RowNum"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_RowNumColumn)

        Dim OB_ItemCodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With OB_ItemCodeColumn
            .FieldName = "OB_ItemCode"
            .Width = 200
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_ItemCodeColumn)

        Dim OB_QtyColumn As New GridViewDecimalColumn("QTY")
        With OB_QtyColumn
            .FieldName = "OB_Qty"

            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvCreatePO.Columns.Add(OB_QtyColumn)
        rgvCreatePO.Columns("OB_Qty").FormatString = "{0:N6}"

        Dim OB_UnitPriceColumn As New GridViewDecimalColumn("UNIT PRICE")
        With OB_UnitPriceColumn
            .FieldName = "OB_UnitPrice"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .DecimalPlaces = 6
        End With
        rgvCreatePO.Columns.Add(OB_UnitPriceColumn)
        rgvCreatePO.Columns("OB_UnitPrice").FormatString = "{0:N6}"

        Dim OB_RemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With OB_RemarksColumn
            .FieldName = "OB_Remarks"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_RemarksColumn)

        Dim OB_Detail_IDColumn As New GridViewTextBoxColumn("OB_Detail_ID")
        With OB_Detail_IDColumn
            .FieldName = "OB_Detail_ID"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_Detail_IDColumn)

        Dim OB_DeptColumn As New GridViewTextBoxColumn("DEPT")
        With OB_DeptColumn
            .FieldName = "OB_Dept"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_DeptColumn)

        Dim OB_BudgetRefColumn As New GridViewTextBoxColumn("BUDGET REF. NO.")
        With OB_BudgetRefColumn
            .FieldName = "OB_BudgetRef"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvCreatePO.Columns.Add(OB_BudgetRefColumn)

        Dim fldOrderId As New GridViewTextBoxColumn("fldOrderId")
        With fldOrderId
            .FieldName = "fldOrderId"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvCreatePO.Columns.Add(fldOrderId)

        Dim fldQTYOUTColumn As New GridViewTextBoxColumn("fldQTYSOUT")
        With fldQTYOUTColumn
            .FieldName = "fldQTYSOUT"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvCreatePO.Columns.Add(fldQTYOUTColumn)

        Dim fldMOID As New GridViewTextBoxColumn("fldMOID")
        With fldMOID
            .FieldName = "fldMOIID"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvCreatePO.Columns.Add(fldMOID)

        Dim fldTotal As New GridViewSummaryItem("OB_LINE", "TOTAL", GridAggregateFunction.Var)
        Dim fldTCSum As New GridViewSummaryItem("OB_POAmt", "{0:N6}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldTCSum)


        With rgvCreatePO
            .EnableAlternatingRowColor = True
            .ShowGroupPanel = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
            .SummaryRowsBottom.Add(SummaryRowItem)
        End With

    End Sub

    Private Sub rgvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellDoubleClick

        For y As Integer = 0 To rgvCreatePO.ChildRows.Count - 1
            If rgvCreatePO.ChildRows(y).Cells("fldMOIID").Value = rgvList.CurrentRow.Cells("fldMOIID").Value Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Item Already in Order Grid", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Exit Sub
            End If

        Next

        If dtpDelDate.Text = "" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Select Delivery date to continue", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Dim OB_Line As String = ""
            Dim OB_DocDate As String = Convert.ToString(String.Format("{0:yyyyMMdd}", dtpMOrder.Value))
            Dim OB_TaxDate As String = Convert.ToString(String.Format("{0:yyyyMMdd}", dtpMOrder.Value))
            Dim OB_DocDueDate As String = Convert.ToString(String.Format("{0:yyyyMMdd}", dtpDelDate.Value))
            Dim OB_Vendor As String = txtVenCode.Text
            Dim OB_POAmt As Decimal = 0.0

            Dim z As Integer
            For i As Integer = 0 To rgvCreatePO.Rows.Count + 1
                z = i
            Next
            Dim OB_RowNum As Integer = z

            Dim OB_ItemCode As String = rgvList.CurrentRow.Cells("fldICode").Value.ToString
            Dim OB_Qty As Decimal = Convert.ToInt32(rgvList.CurrentRow.Cells("fldQTYEB").Value)
            Dim OB_UnitPrice As Decimal = 0.0
            Dim OB_Remarks As String = txtRemarks.Text
            Dim OB_Detail_ID As String = ""
            Dim OB_Dept As String = rgvList.CurrentRow.Cells("fldOrderDepartment").Value.ToString

            Dim OB_BudgetRef As String = rgvList.CurrentRow.Cells("fldSubRefNo").Value.ToString
            Dim OrdID As Integer = Convert.ToInt32(rgvList.CurrentRow.Cells("fldOrderId").Value)

            Dim QTYOUT As Integer = rgvList.CurrentRow.Cells("fldQTYSOUT").Value

            Dim PRNum As String = rgvList.CurrentRow.Cells("fldPRNo").Value.ToString

            Dim fldMOID As String = rgvList.CurrentRow.Cells("fldMOIID").Value.ToString
            rgvCreatePO.Rows.Add(PRNum, OB_Line, OB_DocDate, OB_TaxDate, OB_DocDueDate, OB_Vendor, OB_POAmt,
                              OB_RowNum, OB_ItemCode, OB_Qty, OB_UnitPrice, OB_Remarks, OB_Detail_ID, OB_Dept, OB_BudgetRef, OrdID, QTYOUT, fldMOID)

        End If


    End Sub

    Private Sub btnCPO_Click(sender As Object, e As EventArgs) Handles btnCPO.Click
        'Comment due to SAP Problem
        GetCurSap()

        'Temporary Remove Comment due to SAP Testing of PO
        ' New Code Due to SAP Problem
        'Zaji.addParameter("PONo", Regex.Replace(txtPONo.Text, "\s+", " "))
        'Dim RecordCheck As DataTable = Zaji.dbSelect("SP_CheckifPONoExist")

        'Dim CheckMe = RecordCheck.Rows(0).Item("CheckMe").ToString()

        'If CheckMe >= "1" Then
        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show("This PONo Already Exist", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        '    Exit Sub
        'End If
        '-----------------------------------------------------------------------------------------------------------

        For z As Integer = 0 To rgvCreatePO.ChildRows.Count - 1
            If rgvCreatePO.ChildRows(z).Cells("OB_UnitPrice").Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please Check input. Zero unit price is not acceptable.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Exit Sub
            End If

            If rgvCreatePO.ChildRows(z).Cells("OB_Qty").Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please Check input. Zero quantity is not acceptable.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Exit Sub
            End If

        Next

        If String.IsNullOrEmpty(ddlSupSap.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Enter A Supplier", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)


        ElseIf String.IsNullOrEmpty(txtRemarks.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Enter A Remarks", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            txtRemarks.Focus()

        ElseIf String.IsNullOrEmpty(ddlVenCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please re-enter supplier", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            txtRemarks.Focus()

        ElseIf String.IsNullOrEmpty(txtCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please re-enter supplier", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            txtRemarks.Focus()

            'Temporary Remove Comment due to SAP Testing of PO
            'ElseIf String.IsNullOrEmpty(ddlDepartment.Text) Then
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("Please re-enter Department", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '    txtRemarks.Focus()
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("Please re-enter Prepared by", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '    txtRemarks.Focus()
            'ElseIf String.IsNullOrEmpty(txtCheckedBy.Text) Then
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("Please re-enter Checked by", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '    txtRemarks.Focus()
            'ElseIf String.IsNullOrEmpty(txtPONo.Text) Then
            '    RadMessageBox.SetThemeName("Windows8")
            '    RadMessageBox.Show("Please re-enter PO No", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            '    txtRemarks.Focus()
            '-------------------------------------------------------
        Else

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Are you sure you want to Order this item?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
                Dim myCmd As New MySqlCommand
                Dim myCmd2 As New MySqlCommand
                Dim myCmd3 As New MySqlCommand
                Dim myCmd4 As New MySqlCommand
                Dim myCmd5 As New MySqlCommand
                Dim myCmdChecking As New MySqlCommand
                Dim myCmdOBDetailID As New MySqlCommand
                Dim myCmdCheckMOIID As New MySqlCommand

                Dim myAdapterChecking As New MySqlDataAdapter
                Dim myAdapterIDCheck As New MySqlDataAdapter
                Dim myData As New DataTable
                Dim myDataIDCheck As New DataTable
                Dim myAdapterOBDetailID As New MySqlDataAdapter

                Dim chk As String
                Dim Supplier As String = ddlSupSap.Text
                Dim IDcheck As String

                Dim Currency As String = txtCurrency.Text
                Dim Discount As Decimal = RTD.Text
                Dim Amount As Decimal = RTUPrice.Text
                Dim OBAmt As Decimal = RTTotal.Text
                Dim TTPO As Decimal = RTTPO.Text
                Dim Remarks As String = txtRemarks.Text
                Dim Rate As Decimal = mebXRate.Text

                'Comment due to no vendor code
                ' Dim VenCode As String = txtVenCode.Text
                Dim VenCode As String = ddlVenCode.Text
                '--------------------------------------

                conn.Open()

                myCmd.Connection = conn
                myCmd2.Connection = conn
                myCmd3.Connection = conn
                myCmd4.Connection = conn
                myCmd5.Connection = conn
                myCmdChecking.Connection = conn
                myCmdCheckMOIID.Connection = conn

                For z As Integer = 0 To rgvCreatePO.ChildRows.Count - 1
                    Dim id As Integer = rgvCreatePO.ChildRows(z).Cells("fldMOIID").Value
                    Dim itemcode As String = rgvCreatePO.ChildRows(z).Cells("OB_ItemCode").Value.ToString

                    myCmdCheckMOIID.CommandText = "SELECT fldStat FROM tblMOI where fldMOIID = '" & id & "'"
                    myAdapterIDCheck.SelectCommand = myCmdCheckMOIID
                    myAdapterIDCheck.Fill(myDataIDCheck)


                    IDcheck = myDataIDCheck.Rows(0).Item("fldStat").ToString

                    If IDcheck = "CLOSE" Then
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("Item Code: '" & itemcode & "' is already CLOSE. Please Remove this item to Continue.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                        bwLoadData.RunWorkerAsync()
                        Exit Sub
                    End If

                Next

                rgvCreatePO.ShowColumnHeaders = False

                myCmdChecking.CommandText = "select Concat('POID',if(fldPOID is not null,max(fldPOID)+1,0)) as 'OB_Line' from tblPO"
                myAdapterChecking.SelectCommand = myCmdChecking
                myAdapterChecking.Fill(myData)

                chk = myData.Rows(0).Item("OB_Line").ToString

                For y As Integer = 0 To rgvCreatePO.ChildRows.Count - 1

                    rgvCreatePO.ChildRows(y).Cells("OB_LINE").Value = chk
                    rgvCreatePO.ChildRows(y).Cells("OB_POAmt").Value = RTTotal.Value
                    rgvCreatePO.ChildRows(y).Cells("OB_Vendor").Value = VenCode
                    rgvCreatePO.ChildRows(y).Cells("OB_Remarks").Value = Remarks

                Next

                myCmd3.CommandText = "INSERT INTO `tblPO`( `OB_Line`, `fldSupplier`, `fldVCode`, `fldMOrdered`,`fldDDate`, " _
                                & "`fldStat`, `fldCurrency`, `fldDiscount`, `fldDAmount`, `fldTPO`, `OB_POAmt`, `fldRemarks`, `fldSignature`, `fldRate`) " _
                                & "VALUES(" _
                                & " '" & chk & "','" & Replace(Supplier, "'", "''") & "','" & VenCode & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpMOrder.Value)) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpDelDate.Value)) & "', " _
                                & "'OPEN','" & Currency & "','" & Discount & "','" & Amount & "','" & TTPO & "','" & OBAmt & "','" & Remarks & "','" & txtSignature.Text & "','" & Rate & "')"
                myCmd3.ExecuteNonQuery()



                For x As Integer = 0 To rgvCreatePO.ChildRows.Count - 1
                    Dim myDataOBDetailID As New DataTable
                    Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

                    myCmdOBDetailID.Connection = conn

                    Dim OB_Detail_ID As Integer

                    myCmdOBDetailID.CommandText = "select if(fldPOIID is not null,max(fldPOIID)+1,0) as 'OB_Detail_ID' from tblPOI"
                    myAdapterOBDetailID.SelectCommand = myCmdOBDetailID
                    myAdapterOBDetailID.Fill(myDataOBDetailID)

                    myCmdOBDetailID.ExecuteNonQuery()
                    OB_Detail_ID = myDataOBDetailID.Rows(0).Item("OB_Detail_ID").ToString

                    rgvCreatePO.ChildRows(x).Cells("OB_Detail_ID").Value = OB_Detail_ID

                    Dim ID As String = rgvCreatePO.ChildRows(x).Cells("OB_Detail_ID").Value.ToString
                    Dim UP As Decimal = Convert.ToDecimal(rgvCreatePO.ChildRows(x).Cells("OB_UnitPrice").Value)
                    Dim TC As Decimal = Convert.ToDecimal(rgvCreatePO.ChildRows(x).Cells("OB_POAmt").Value)
                    Dim QTY As Integer = Convert.ToInt32(rgvCreatePO.ChildRows(x).Cells("OB_Qty").Value)
                    Dim OID As Integer = Convert.ToInt32(rgvCreatePO.ChildRows(x).Cells("fldOrderId").Value)
                    Dim PRNum As String = rgvCreatePO.ChildRows(x).Cells("fldPRNo").Value.ToString
                    Dim DD As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpDelDate.Value))

                    Dim Signature As String = txtSignature.Text
                    Dim MO As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", dtpMOrder.Value))
                    Dim fldMOID As String = rgvCreatePO.ChildRows(x).Cells("fldMOIID").Value.ToString

                    Dim QTYOUT As Integer = rgvCreatePO.ChildRows(x).Cells("fldQTYSOUT").Value


                    myCmd.CommandText = "INSERT INTO tblPOI(fldQTYSOut ,OB_Detail_ID, fldMOIID, OB_Line,fldTransCode, fldBudRefNum,fldPRNo, fldICode, fldDesc, fldQTY, " _
                                        & "fldUnit, fldStat,fldUID, fldMO,fldSignature,fldUPrice, fldTotalCost, fldCurrency, fldMonthDelivery, fldDept, fldClass, fldRate, fldSubRefNo) " _
                                        & "SELECT 0, '" & OB_Detail_ID & "', T1.fldMOIID, '" & chk & "',T1.fldTransCode,T1.fldBudRefNum,'" & PRNum & "',T1.fldICode,T1.fldDesc," & QTY & ",T1.fldUnit,T1.fldStat, " _
                                        & "T1.fldUID,'" & MO & "','" & Signature & "', " & UP & ", " & TC & ", '" & Currency & "', '" & DD & "',(select TBud.fldDept from tblBudget TBud where TBud.fldBudRefNum = T1.fldSubRefNo), T1.fldClass, '" & Rate & "', T1.fldSubRefNo " _
                                        & "FROM tblMOI T1 WHERE T1.fldMOIID = '" & fldMOID & "'; "
                    myCmd.ExecuteNonQuery()
                    myCmdOBDetailID.Parameters.Clear()

                    myCmd4.CommandText = "UPDATE `tblMOI` SET `fldQTYSOUT`='" & QTY & "' + '" & QTYOUT & "' " _
                        & ", fldQTYEB = fldQTY - (fldQTYSOUT - fldQTYSIN), fldStat = if(fldQTY <= (fldQTYSOUT - fldQTYSIN),'CLOSE','OPEN'), fldRS = 'PO CREATED' WHERE `fldMOIID` ='" & fldMOID & "';"
                    myCmd4.ExecuteNonQuery()

                    myCmd5.CommandText = "UPDATE tblPRNo set fldStat = 'PO CREATED' where fldPRKey = right('" & PRNum & "',6);"
                    myCmd5.ExecuteNonQuery()
                Next
                'Temporary Remove Comment due to SAP Testing of PO
                ''Insert PONo in BAP Comment fix SAP
                Zaji.addParameter("_OB_Line", chk)
                Zaji.addParameter("PreparedBy", txtPreparedBy.Text)
                Zaji.addParameter("CheckedBy", txtCheckedBy.Text)
                Zaji.addParameter("Department", ddlDepartment.Text)
                Zaji.addParameter("PONo", txtPONo.Text)
                Zaji.dbAED("SP_InsertPONo")
                '----------------------------------------------------
                conn.Close()

                'Temporary Remove Comment due to SAP Testing of PO
                'Comment due to SAP Problem
                Try
                    '-------------------'
                    '-- EXPORT TO SAP --'
                    '-------------------'

                    Dim exporter As ExportToCSV = New ExportToCSV(rgvCreatePO)
                    exporter.FileExtension = "csv"

                    Dim Time As String = System.DateTime.Now.ToString("ddMMyyyyHHmmss")
                    exporter.SummariesExportOption = SummariesOption.DoNotExport

                    Dim fileName As String = "\\192.168.191.48\Backup$" & "\" & Time & ".csv"

                    exporter.RunExport(fileName)

                    Dim text As String() = System.IO.File.ReadAllLines(fileName)

                    For i As Integer = 0 To text.Length - 1
                        text(i) = text(i).Replace("""", "")
                    Next

                    System.IO.File.WriteAllLines(fileName, text)

                    '---------'
                    '-- END --'
                    '---------'

                Catch ex As Exception

                End Try
                '----------------------------------------------------------------------
                '----------------------------------------------------
                'New Code replace SAP--------------------------

                Try
                    '-------------------'
                    '-- EXPORT TO SAP --'
                    '-------------------'

                    Dim exporter As ExportToCSV = New ExportToCSV(rgvCreatePO)
                    exporter.FileExtension = "csv"

                    Dim Time As String = System.DateTime.Now.ToString("ddMMyyyyHHmmss")
                    exporter.SummariesExportOption = SummariesOption.DoNotExport

                    Dim fileName As String = Application.StartupPath + "\SAP-INTIGRATION" & "\" & Time & ".csv"

                    exporter.RunExport(fileName)

                    Dim text As String() = System.IO.File.ReadAllLines(fileName)

                    For i As Integer = 0 To text.Length - 1
                        text(i) = text(i).Replace("""", "")
                    Next

                    System.IO.File.WriteAllLines(fileName, text)

                    '---------'
                    '-- END --'
                    '---------'

                Catch ex As Exception

                End Try
                '------------------------------------------------

                rgvCreatePO.ShowColumnHeaders = True

                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Purchased Order Created", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                ClearAll()

            End If

        End If

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        If rgvCreatePO.Rows.Count > 0 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("There are Item(s) to Order. Are you sure you want to close this transaction?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Me.Close()
            End If
        Else
            If bwLoadData.IsBusy Then
                bwLoadData.CancelAsync()
                imBusy = False
            End If

            Me.Close()

        End If
    End Sub

    Private Sub ddlSupSap_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlSupSap.SelectedIndexChanged


    End Sub

    Private Sub rgvListItem_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles rgvCreatePO.CellEndEdit

        Dim x As Decimal = Convert.ToDecimal(rgvCreatePO.CurrentRow.Cells("OB_Qty").Value)
        Dim y As Decimal = Convert.ToDecimal(rgvCreatePO.CurrentRow.Cells("OB_UnitPrice").Value)

        rgvCreatePO.CurrentRow.Cells("OB_POAmt").Value = x * y
        RTTPO.Text = rgvCreatePO.MasterView.SummaryRows(0).Cells("OB_POAmt").Value

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

    Private Sub RTD_Leave(sender As Object, e As EventArgs) Handles RTD.Leave
        RTUPrice.Text = ((RTTPO.Text * RTD.Text) / 100)
    End Sub

    Private Sub RTD_TextChanged(sender As Object, e As EventArgs) Handles RTD.TextChanged
        If RTD.Value > 100 Then
            RTD.Value = 100
            RTUPrice.Text = RTTPO.Text
            RTTotal.Value = RTTPO.Value - RTUPrice.Text
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClearAll()
        ddlSupSap.Text = ""
        txtVenCode.Text = ""
        txtCurrency.Text = ""
        dtpMOrder.Value = Today

        RTTPO.Text = 0.0
        RTD.Text = 0.0
        RTUPrice.Text = 0.0
        RTTotal.Text = 0.0
        txtRemarks.Text = ""

        rgvCreatePO.Rows.Clear()
    End Sub

    Private Sub txtTotal_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgvCreatePO.CellFormatting

        If (e.CellElement.ColumnInfo.HeaderText = "QTY") Or (e.CellElement.ColumnInfo.HeaderText = "UNIT PRICE") Then
            e.CellElement.DrawFill = True
            e.CellElement.BackColor = System.Drawing.Color.LightSkyBlue

        ElseIf (e.CellElement.ColumnInfo.HeaderText = "ITEM CODE") Then
            e.CellElement.DrawFill = True
            e.CellElement.BackColor = System.Drawing.Color.DarkGray

        Else
            e.CellElement.DrawFill = True
            e.CellElement.BackColor = System.Drawing.Color.Transparent
        End If

    End Sub

    Private Sub RTUPrice_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles RTUPrice.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            If RTTPO.Value <> 0 Then
                RTUPrice.Text = ((RTTPO.Text * RTD.Text) / 100)
            End If
        Else

        End If
    End Sub

    Private Sub RTUPrice_TextChanged1(sender As Object, e As EventArgs) Handles RTUPrice.TextChanged
        ND()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpMOrder_ValueChanged(sender As Object, e As EventArgs) Handles dtpMOrder.ValueChanged
        'Comment due to SAP problem
        GetRateSap()
        '------------------------
        'New Rate BAP
        'GetRateBAP()
        '--------------------------
    End Sub

    Private Sub ddlVenCode_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlVenCode.SelectedIndexChanged
    End Sub


    Private Sub txtRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks.KeyPress

        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 _
                OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtRemarks_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemarks.KeyDown
        If (e.Control = True) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Cut/Copy and Paste are disabled", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub txtRemarks_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRemarks.MouseClick
        If (e.Button = MouseButtons.Right) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Cut/Copy and Paste are disabled", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        End If
    End Sub

    Private Sub rgvSupplier_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvSupplier.CellClick


    End Sub

    Private Sub rgvSupplier_SelectionChanged(sender As Object, e As EventArgs) Handles rgvSupplier.SelectionChanged

    End Sub

    Private Sub rgvSupplier_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvSupplier.CellDoubleClick
        Try
            Zaji.addParameter("SuppName", rgvSupplier.CurrentRow.Cells("CardName").Value.ToString)
            Dim dtSuppName As DataTable = Zaji.dbSelect("SP_CheckInactiveSupplier")

            Dim CheckSuppname = (From i In dtSuppName.AsEnumerable()
                                 Select Convert.ToString(i("Checkme"))).FirstOrDefault()

            If CheckSuppname = 1 Then
                RadMessageBox.SetThemeName("Windows8")
                If RadMessageBox.Show("WARNING. This supplier is marked to be inactive!, Are you sure you want to continue to use this supplier?",
                                          "INACTIVE SUPPLIER", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    GetSuppInfo()
                End If
            Else
                GetSuppInfo()
            End If
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please Contact MIS Mark @ Local 606", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub
    Private Sub GetSuppInfo()
        ddlSupSap.Text = rgvSupplier.CurrentRow.Cells("CardName").Value.ToString
        ddlVenCode.Text = rgvSupplier.CurrentRow.Cells("CardCode").Value.ToString
        txtCurrency.Text = rgvSupplier.CurrentRow.Cells("Currency").Value.ToString
        'Comment due to SAP problem
        GetRateSap()
        '------------------------
        'New Rate BAP
        'GetRateBAP()
        '--------------------------
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dtLoadData4 = Chinita.fetchDBTable("call SP_CPO_GetItemToPOByPRNo('" & txtSearchPR.Text & "')")
        rgvList.DataSource = dtLoadData4
    End Sub

    Private Sub txtExistingPR_Click(sender As Object, e As EventArgs) Handles txtExistingPR.Click
        rgvList.DataSource = dtLoadData
    End Sub
    Public Sub GetRateBAP()
        If txtCurrency.Text = "JPY" Or String.IsNullOrEmpty(txtCurrency.Text) Then
            mebXRate.Value = 0.000000
        Else
            Try

                Zaji.addParameter("Currency", txtCurrency.Text)
                Zaji.addParameter("_Date", dtpMOrder.Value.Date)
                Dim DTCheck As DataTable = Zaji.dbSelect("SP_CheckRate")

                mebXRate.Value = DTCheck.Rows(0).Item("fldRate").ToString()


            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Selected Date has No Convertion Rate," & Environment.NewLine &
                                      "Please Contact MIS Mark @ Local 606", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try

        End If

    End Sub
    Public Sub GetDeptCode()
        Dim dtDeptCode As DataTable = Zaji.dbSelect("SP_SelectAllDeptCode")
        ddlDepartment.DataSource = dtDeptCode
        ddlDepartment.DisplayMember = "fldNote"

    End Sub

End Class


Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Text

Public Class frmConfirmUsers

    Dim success As Boolean

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim x As Integer
        Dim pw As String

        Dim deptvalue As String = frmOrder.ddlDept.Text
        Dim deptvalue2 As String = frmMultiOrder.ddlDept.Text

        pw = Chinita.getMD5Hash(txtPW.Text)

        If btnpicker = 1 Then
            myCmd.Connection = conn

            myCmd.CommandText = "select IF('" & deptvalue & "' = (select fldDept from tblUser where " _
                & "fldUsername = '" & txtUN.Text & "' and fldPassword = '" & pw & "'),1,0) as 'check'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            x = myData.Rows(0).Item("check")

        ElseIf btnpicker = 2 Then
            myCmd.Connection = conn

            myCmd.CommandText = "select IF('" & deptvalue2 & "' = (select fldDept from tblUser where " _
                & "fldUsername = '" & txtUN.Text & "' and fldPassword = '" & pw & "'),1,0) as 'check'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            x = myData.Rows(0).Item("check")
        End If

        If x = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Wrong Username or Password!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            '------------------------------------------------------------------------------'
            Dim myCmdRem As New MySqlCommand
            Dim myAdapterRem As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim myDataRem As New DataTable
            Dim connRem As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
            Dim BR As Decimal
            connRem.Open()

            myCmdRem.Connection = connRem
            myCmdRem.CommandText = "select ROUND(if(tr1.fldYen is not null,tr1.fldYen,0) " _
                & "- (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
                & "from tblUPO UPO where UPO.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' ) " _
                & "- (SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0) " _
                & "FROM tblPOI tr2 where tr2.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' ) - " _
                & "((" _
                & "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY' FROM tblOrder PR " _
                & "where (select count(MO.fldTransCode) from tblMOI MO " _
                & "where MO.fldTransCode = PR.fldTransCode and MO.fldStat = 'OPEN') != 0 " _
                & "and PR.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "')),2) as 'RemBudget' " _
                & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
                & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "'"

            'myCmdRem.CommandText = "select ROUND(if(tr1.fldYen is not null,tr1.fldYen,0) " _
            '     & "- (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
            '     & "from tblUPO UPO where UPO.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "') " _
            '     & "- (SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0) " _
            '     & "FROM tblPOI tr2 where tr2.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' ) - " _
            '     & "((" _
            '     & "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) as 'TJPY' FROM tblOrder PR " _
            '     & "where PR.fldOrderStatus = 'OPEN'" _
            '     & "and PR.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "')),2) as 'RemBudget' " _
            '     & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
            '     & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "'"

            myAdapterRem.SelectCommand = myCmdRem
            myAdapterRem.Fill(myDataRem)

            BR = myDataRem.Rows(0).Item("RemBudget") - (Convert.ToDecimal(frmMultiOrder.mebEPA.Text))
            '------------------------------------------------------------------------------'


            If frmMultiOrder.mebRemBLPR.Value <> BR Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("The remaining balance reflected is already updated by other user. Click the Refresh button to see updated balance. ", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Me.Dispose()
                Exit Sub

            End If

            If btnpicker = 1 Then
                Tomboy.AddOrderB(frmOrder.ddlBRNum.Text, _
                                frmOrder.txtPRNum.Text, _
                                frmOrder.dtpMOrder.Value, _
                                frmOrder.txtSupplier.Text, _
                                frmOrder.txtDesc.Text, _
                                frmOrder.ddlClass.Text, _
                                frmOrder.ddlDept.Text, _
                                frmOrder.ddlProcess.Text, _
                                frmOrder.mebQTY.Text, _
                                frmOrder.ddlUOM.Text, _
                                frmOrder.ddlCurrency.Text, _
                                frmOrder.mebJPYAmount.Text, _
                                frmOrder.dtpMDelivery.Value, _
                                frmOrder.ddlStat.Text, _
                                frmOrder.txtReason.Text, _
                                frmOrder.Remarks.Text, _
                                frmOrder.txtSignature.Text, _
                                frmOrder.lblUserID.Text, _
                                frmOrder.dtpMOrder.Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK)
                frmOrder.bwLoadData.RunWorkerAsync()

                Me.Dispose()

            ElseIf btnpicker = 2 Then

                Try
                    conn.Open()
                    myCmd.Connection = conn

                    Dim TransCode, Curr, Classification, Dept, Process As String

                    Dim TC, BRNum, Status, ICode, Desc, Unit, User As String
                    Dim ConID As Integer
                    'Dim UPrice, Total As Decimal
                    Dim Rate, QTY As Decimal
                    Dim ColMO As Date

                    TransCode = "TC00" + frmMultiOrder.lblTCID.Text + "-" + frmMultiOrder.ddlDept.Text
                    Curr = frmMultiOrder.ddlCurrency.Text

                    For c As Integer = 0 To frmMultiOrder.rgvList.Rows.Count - 1
                        TC = TransCode
                        BRNum = frmMultiOrder.ddlBRNum.Text
                        ICode = frmMultiOrder.rgvList.Rows(c).Cells(1).Value
                        Desc = frmMultiOrder.rgvList.Rows(c).Cells(2).Value
                        QTY = frmMultiOrder.rgvList.Rows(c).Cells(3).Value
                        Unit = frmMultiOrder.rgvList.Rows(c).Cells(4).Value
                        Status = "OPEN"
                        User = frmMultiOrder.txtSignature.Text
                        ConID = frmMultiOrder.lblUserID.Text
                        ColMO = frmMultiOrder.dtpMOrder.Value
                        Classification = frmMultiOrder.ddlClass.Text
                        Dept = frmMultiOrder.ddlDept.Text
                        Process = frmMultiOrder.ddlProcess.Text
                        Rate = frmMultiOrder.mebXRate.Value

                        myCmd.CommandText = "INSERT INTO tblMOI" _
                            & "(fldTransCode, fldBudRefNum, fldICode, fldDesc, fldQTY, " _
                            & "fldUnit, fldStat, fldSignature, " _
                            & "fldUID, fldMO, fldClass, fldDept, fldProcess, fldRate) " _
                            & "values " _
                            & "(@fldTransCode,@fldBudRefNum,@fldICode,@fldDesc,@fldQTY," _
                            & "@fldUnit,@fldStat,@fldSignature," _
                            & "@fldUID,@fldMO,@fldClass,@fldDept,@fldProcess,@fldRate)"

                        With myCmd.Parameters
                            .AddWithValue("@fldTransCode", TC)
                            .AddWithValue("@fldBudRefNum", BRNum)
                            .AddWithValue("@fldICode", ICode)
                            .AddWithValue("@fldDesc", Desc)
                            .AddWithValue("@fldQTY", QTY)
                            .AddWithValue("@fldUnit", Unit)
                            .AddWithValue("@fldStat", Status)
                            .AddWithValue("@fldSignature", User)
                            .AddWithValue("@fldUID", ConID)
                            .AddWithValue("@fldMO", ColMO)
                            .AddWithValue("@fldClass", Classification)
                            .AddWithValue("@fldDept", Dept)
                            .AddWithValue("@fldProcess", Process)
                            .AddWithValue("@fldRate", Rate)
                        End With

                        myCmd.ExecuteNonQuery()
                        myCmd.Parameters.Clear()

                    Next

                    If frmMultiOrder.chkNewPR.Checked Then
                        Dim myCmdPR As New MySqlCommand
                        myCmdPR.Connection = conn
                        myCmdPR.CommandText = "CALL PR_Insert('" & frmMultiOrder.dtpMOrder.Value.Year & "','" & TransCode & "','" & frmMultiOrder.ddlDept.Text & "');"
                        myCmdPR.ExecuteNonQuery()
                        myCmd.Parameters.Clear()
                    End If
                    conn.Close()
                    '------------------------------------------------------
                    Tomboy.AddOrderMB(frmMultiOrder.ddlBRNum.Text,
                                     TransCode,
                                     frmMultiOrder.txtPRNum.Text,
                                     frmMultiOrder.dtpMOrder.Value,
                                     frmMultiOrder.txtDesc.Text,
                                     frmMultiOrder.ddlClass.Text,
                                     frmMultiOrder.ddlDept.Text,
                                     frmMultiOrder.ddlProcess.Text,
                                     frmMultiOrder.mebQTY.Text,
                                     frmMultiOrder.ddlItemUOM.Text,
                                     frmMultiOrder.ddlStat.Text,
                                     frmMultiOrder.txtReason.Text,
                                     frmMultiOrder.txtRemarks.Text,
                                     frmMultiOrder.txtSignature.Text,
                                     frmMultiOrder.lblUserID.Text,
                                     frmMultiOrder.dtpMOrder.Value,
                                     frmMultiOrder.dtpDN.Value,
                                     frmMultiOrder.ddlCurrency.Text,
                                     frmMultiOrder.mebAmount.Value,
                                     frmMultiOrder.mebEPA.Value,
                                     frmMultiOrder.mebTOPRA.Value,
                                     frmMultiOrder.mebTOPDRA.Value,
                                     frmMultiOrder.mebRemBLPR.Value,
                                     frmMultiOrder.mebRemDBLPR.Value,
                                     frmMultiOrder.mebRemBud.Value,
                                     frmMultiOrder.RemDeptBud.Value,
                                     frmMultiOrder.txtRN.Text,
                                     frmMultiOrder.mebXRate.Value)
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                    Me.Dispose()

                    Clear()

                Catch ex As Exception
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Error", "Error", MessageBoxButtons.OK)
                End Try

            End If

        End If

    End Sub

    Private Sub Clear()

        With frmMultiOrder

            .txtTC.Text = ""
            .txtCategory.Text = ""
            .txtItemCode.Text = ""
            .mebItemQTY.Text = 0
           
            .ddlBRNum.Text = ""
            .txtPRNum.Text = ""
            .dtpMOrder.Value = Today
            .txtDesc.Text = ""
            .ddlClass.Text = ""
            .ddlDept.Text = ""
            .ddlProcess.Text = ""
            .mebQTY.Text = ""
            .mebRemQTY.Text = ""
            .mebJPYAmount.Text = ""
            .dtpMDelivery.Value = Today
            .ddlStat.Text = "OPEN"
            .mebRemBud.Text = ""
            .txtRemarks.Text = ""

            .rgvList.Rows.Clear()

            .txtReason.Enabled = False

            .ddlBRNum.Enabled = True
            .ddlDept.Enabled = True
            .ddlStat.Enabled = True

        End With

    End Sub

    Private Sub frmConfirmUsers_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConfirmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUN.Focus()
    End Sub

End Class

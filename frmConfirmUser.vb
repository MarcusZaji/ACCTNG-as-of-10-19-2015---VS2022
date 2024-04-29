Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Text

Public Class frmConfirmUser

    Dim success As Boolean

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim x As String
        Dim pw As String

        pw = Chinita.getMD5Hash(txtPW.Text)

        If btnpicker = 1 Then
            myCmd.Connection = conn

            myCmd.CommandText = "select IF('" & frmOrder.ddlDept.Text & "' = (select fldDept from tblUser where " _
                & "fldUsername = '" & txtUN.Text & "' and fldPassword = '" & pw & "'),1,0) as 'check'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            x = myData.Rows(0).Item("check").ToString

        ElseIf btnpicker = 2 Then
            myCmd.Connection = conn

            myCmd.CommandText = "select IF('" & frmMultiOrder.ddlDept.Text & "' = (select fldDept from tblUser where " _
                & "fldUsername = '" & txtUN.Text & "' and fldPassword = '" & pw & "'),1,0) as 'check'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            x = myData.Rows(0).Item("check").ToString
        End If


        If pw = 0 Then
            RadMessageBox.Show("Wrong Username or Password!", "Notification", MessageBoxButtons.OK)

        Else

            If btnpicker = 1 Then
                Tomboy.AddOrderB(frmOrder.ddlBRNum.Text, _
                                frmOrder.txtPONum.Text, _
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
                                frmOrder.mebYEN.Text, _
                                frmOrder.dtpMDelivery.Value, _
                                frmOrder.ddlStat.Text, _
                                frmOrder.txtReason.Text, _
                                frmOrder.txtRemarks.Text, _
                                frmOrder.txtSignature.Text, _
                                frmOrder.lblUserID.Text)
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK)
                'Clear()
                frmOrder.bwLoadData.RunWorkerAsync()

                Me.Dispose()

            ElseIf btnpicker = 2 Then

                Try
                    conn.Open()
                    myCmd.Connection = conn

                    Dim TransCode, Curr As String

                    Dim TC, BRNum, Status, ICode, Desc, Unit, Currency As String
                    Dim QTY As Integer
                    Dim UPrice, Total As Decimal

                    TransCode = "TC00" + frmMultiOrder.lblTCID.Text + "-" + frmMultiOrder.ddlDept.Text
                    Curr = frmMultiOrder.ddlCurrency.Text

                    For c As Integer = 0 To frmMultiOrder.rgvList.Rows.Count - 1
                        TC = TransCode
                        BRNum = frmMultiOrder.ddlBRNum.Text
                        ICode = frmMultiOrder.rgvList.Rows(x).Cells(0).Value
                        Desc = frmMultiOrder.rgvList.Rows(x).Cells(1).Value
                        QTY = frmMultiOrder.rgvList.Rows(x).Cells(2).Value
                        Unit = frmMultiOrder.rgvList.Rows(x).Cells(3).Value
                        UPrice = frmMultiOrder.rgvList.Rows(x).Cells(4).Value
                        Total = frmMultiOrder.rgvList.Rows(x).Cells(5).Value
                        Currency = Curr
                        Status = "OPEN"

                        myCmd.CommandText = "INSERT INTO tblMOI(fldTransCode, fldBudRefNum, fldICode, fldDesc, fldQTY, fldUnit, fldUPrice, fldTotalCost, fldCurrency, fldStat) " _
                                         & "values(@fldTransCode,@fldBudRefNum,@fldICode,@fldDesc,@fldQTY,@fldUnit,@fldUPrice,@fldTotalCost,@fldCurrency,@fldStat)"

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
                        End With

                        myCmd.ExecuteNonQuery()
                        myCmd.Parameters.Clear()

                    Next

                    conn.Close()
                    '------------------------------------------------------
                    Tomboy.AddOrderMB(frmMultiOrder.ddlBRNum.Text, _
                                     TransCode, _
                                     frmMultiOrder.txtPONum.Text, _
                                     frmMultiOrder.txtPRNum.Text, _
                                     frmMultiOrder.dtpMOrder.Value, _
                                     frmMultiOrder.txtSupplier.Text, _
                                     frmMultiOrder.txtDesc.Text, _
                                     frmMultiOrder.ddlClass.Text, _
                                     frmMultiOrder.ddlDept.Text, _
                                     frmMultiOrder.ddlProcess.Text, _
                                     frmMultiOrder.ddlCurrency.Text, _
                                     frmMultiOrder.mebYEN.Text, _
                                     frmMultiOrder.mebQTY.Text, _
                                     frmMultiOrder.ddlUOM.Text, _
                                     frmMultiOrder.mebJPYAmount.Text, _
                                     frmMultiOrder.ddlStat.Text, _
                                     frmMultiOrder.txtReason.Text, _
                                     frmMultiOrder.txtRemarks.Text, _
                                     frmMultiOrder.txtSignature.Text, _
                                     frmMultiOrder.lblUserID.Text)
                    RadMessageBox.SetThemeName("Windows8Theme1")
                    RadMessageBox.Show("Order Added!", "Notification", MessageBoxButtons.OK)

                    Me.Dispose()

                    Clear()

                Catch ex As Exception

                End Try

            End If


        End If

    End Sub

    Private Sub Clear()
        With frmMultiOrder

            .txtTC.Text = ""
            .ddlCat.Text = ""
            .ddlItemCode.Text = ""
            .mebItemQTY.Text = 0
            .ddlUOM.Text = ""
            .mebItemUnitPrice.Text = ""

            .ddlBRNum.Text = ""
            .txtPONum.Text = ""
            .txtPRNum.Text = ""
            .dtpMOrder.Value = Today
            .txtSupplier.Text = ""
            .txtDesc.Text = ""
            .ddlClass.Text = ""
            .ddlDept.Text = ""
            .ddlProcess.Text = ""
            .mebQTY.Text = ""
            .mebRemQTY.Text = ""
            .ddlUOM.Text = ""
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

    Private Sub frmConfirmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Imports MySql.Data.MySqlClient
Imports Telerik.WinControls



Module Chix

    Public Delay As Integer = 40
    Public DelaySplash As Integer = 100


    'Previous Version 154
    'Previous Version 182
    'Previous Version 183
    'Previous Version 184
    'Previous Version 185
    'Previous Version 186
    'Previous Version 187
    'Previous Version 188
    'Previous Version 189
    'Previous Version 190
    'Previous Version 191
    'Previous Version 192
    'Previous Version 193
    'Previous Version 194
    'Previous Version 150 from test
    'Previous Version 195
    'Previous Version 196
    'Previous Version 197
    'Previous Version 198
    'Previous Version 199
    'Previous Version 200
    'Previous Version 201
    'Previous Version SAP V10 Version
    'Previous Version 203
    'Previous Version 204 
    'Previous Version 205 
    'Previous Version 206 BCS Report change 
    Public Version As Integer = 207

    'User Setting------------------------------------------

    ' Public ConnString As String = "server=" & My.Settings.BAPServerAddress & ";" & "uid=" & My.Settings.setUsername & ";" & "pwd=" & My.Settings.setPassword & ";" & "Convert Zero Datetime=True;" & "database=" & My.Settings.BAPDBName & ";"
    'Public ConnString As String = "server=" & "192.168.191.20" & ";" & ";" & "uid=" & My.Settings.setUsername & ";" & "pwd=" & My.Settings.setPassword & ";" & "Convert Zero Datetime=True;" & "database=" & "dbBAPTest" & ";"
    Public ConnString As String = "server=" & "192.168.191.12" & ";" & "uid=" & My.Settings.setUsername & ";" & "pwd=" & My.Settings.setPassword & ";" & "Convert Zero Datetime=True;" & "database=" & "dbBAP" & ";"
    Public ConnStringBCS As String = "server=" & "192.168.191.252" & ";" & "uid=" & My.Settings.setUsername & ";" & "pwd=" & My.Settings.setPassword & ";" & "Convert Zero Datetime=True;" & "database=" & "dbBCS" & ";"
    Public ConnReportServer As String = "server=" & "192.168.191.12" & ";" & "uid=feap;" & "pwd=45|iF$;" & "Convert Zero Datetime=True;" & "database=" & "dbReportServer" & ";"
    Public Check As String = My.Settings.BAPServerAddress

    'End User Setting --------------------------------------

    'Public ConnString As String = "server=" & My.Settin.;gs.setServerAddre`ss & ";" & "uid=" & My.Settings.setUsername & ";" & "pwd=" & My.Settings.setPassword & ";" & "Convert Zero Datetime=True;" & "database=" & My.Settings.setServerDBName & ";"

    Public OperationLabel As String = Nothing
    Public ProgressLabel As String = Nothing

    Public imBusy As Boolean = False
    Public GTG As Boolean = False

    Public dt As New DataTable
    Public dtCSV As New DataTable

    Public btnpicker As Integer
    Public rbUploadpicker As Integer
    Public reporttype As Integer
    Public rbpicker As Integer
    Public MatrixPicker As Integer

    Public SelectedDetails As Integer = Nothing
    Public SelectedUser As Integer = Nothing
    Public frmDetailsMode As Integer = 0


    Public Sub getTOMBOY()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        myCmd.Connection = conn
        myCmd.CommandText = "select fldDesc,(IF(fldQTY IS NOT NULL, fldQTY,0)) " _
            & "as QTY,fldUOM,fldSOU from tblRevision where fldBudRefNum = '" & frmBudget.txtBRNum.Text & "' AND fldstat != 'CLOSE'"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        frmBudget.mebQTY.Text = myData.Rows(0).Item("QTY")

        frmBudget.txtDesc.Text = myData.Rows(0).Item("fldDesc")
        frmBudget.ddlUOM.Text = myData.Rows(0).Item("fldUOM")
        frmBudget.dtpSOU.Value = myData.Rows(0).Item("fldSOU")

    End Sub

    Public Sub OrderInfo()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()

        myCmd.Connection = conn

        myCmd.CommandText = "select trmain.fldBudRefNum,trmain.fldDept,trmain.fldDesc,trmain.fldClass,trmain.fldProcess," _
            & "(SELECT IF(tr4.fldQTY is not null,tr4.fldQTY,0) from tblRevision tr4 " _
            & "where tr4.fldStat != 'CLOSE' and tr4.fldBudRefNum = trmain.fldBudRefNum) as QTY," _
            & "(SELECT  tr4.fldUOM from tblRevision tr4 where tr4.fldStat != 'CLOSE' " _
            & "and tr4.fldBudRefNum = trmain.fldBudRefNum) as UOM from tblRevision tr1 left join tblBudget " _
            & "trmain on tr1.fldBudRefNum = trmain.fldBudRefNum where trmain.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "'" _
            & " and tr1.fldRevNum = (SELECT MAX(`fldRevNum`) FROM tblRevision WHERE fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "')"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        conn.Close()

        frmOrder.txtDesc.Text = Format(myData.Rows(0).Item("fldDesc").ToString)
        frmOrder.ddlClass.Text = Format(myData.Rows(0).Item("fldClass").ToString)
        frmOrder.ddlProcess.Text = Format(myData.Rows(0).Item("fldProcess").ToString)
        'frmOrder.mebQTY.Text = Format(myData.Rows(0).Item("QTY").ToString)
        frmOrder.ddlUOM.Text = Format(myData.Rows(0).Item("UOM").ToString)


    End Sub

    Public Sub OrderInfoMulti()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()

        myCmd.Connection = conn

        myCmd.CommandText = "select trmain.fldNB,trmain.fldBudRefNum,trmain.fldDept,trmain.fldDesc,trmain.fldClass,trmain.fldProcess," _
                            & "(select if(TRQTYF.fldQTY is not null,TRQTYF.fldQTY,0) - " _
                            & "(Select If(TPO.fldQTY Is Not null, sum(TPO.fldQTY), 0) " _
                            & "from tblPOI TPO WHERE TPO.fldBudRefNum = trmain.fldBudRefNum) " _
                            & "from tblRevision TRQTYF where TRQTYF.fldBudRefNum = " _
                            & "trmain.fldBudRefNum AND TRQTYF.fldStat != 'CLOSE')AS RQTY, " _
                            & "(SELECT  tr4.fldUOM from tblRevision tr4 where tr4.fldStat != 'CLOSE' " _
                            & "and tr4.fldBudRefNum = trmain.fldBudRefNum) as UOM from tblRevision tr1 left join tblBudget " _
                            & "trmain on tr1.fldBudRefNum = trmain.fldBudRefNum where trmain.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "'" _
                            & " and tr1.fldStat != 'CLOSE'"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        conn.Close()
        frmMultiOrder.txtNB.Text = Format(myData.Rows(0).Item("fldNB").ToString)
        frmMultiOrder.txtDesc.Text = Format(myData.Rows(0).Item("fldDesc").ToString)
        If frmMultiOrder.txtNB.Text = "NO" Then
            frmMultiOrder.ddlClass.Text = Format(myData.Rows(0).Item("fldClass").ToString)
        Else
            frmMultiOrder.ddlClass.Text = ""
        End If

        'frmMultiOrder.ddlProcess.Text = Format(myData.Rows(0).Item("fldProcess").ToString)
        frmMultiOrder.mebRemQTY.Value = Convert.ToDecimal(myData.Rows(0).Item("RQTY").ToString)
        'frmMultiOrder.ddlUOM.Text = Format(myData.Rows(0).Item("UOM").ToString)


    End Sub

    Public Sub RemQTYBudget()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim x As String

        Try
            conn.Open()

            myCmd.Connection = conn

            myCmd.CommandText = "select ( " _
                & " select if(tr1.fldQTY is not null,tr1.fldQTY,0) - " _
                & " (( " _
                & " select " _
                & " if(tr2.fldTransCode is not null,(select IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0) " _
                & " from tblMOI tr4 where tr4.fldBudRefNum = '" & frmBudget.txtBRNum.Text & "' and tr4.fldStat = 'OPEN'),if(tr2.fldQTY is not null,sum(tr2.fldQTY),0)) " _
                & " from tblOrder tr2 where tr2.fldBudRefNum = '" & frmBudget.txtBRNum.Text & "' and tr2.fldOrderStatus = 'OPEN' " _
                & " ) + " _
                & " ( " _
                & " select " _
                & " if(tr5.fldTransCode is not null,(select IF(tr6.fldQTY IS NOT NULL,sum(tr6.fldQTY),0) " _
                & " from tblMAI tr6 where tr6.fldBudRefNum = '" & frmBudget.txtBRNum.Text & "' AND tr6.fldStat = 'OPEN'),if(tr5.fldQTY is not null,sum(tr5.fldQTY),0)) " _
                & " from tblActualAcquisition tr5 where tr5.fldBudRefNum = '" & frmBudget.txtBRNum.Text & "' " _
                & " )) as OrdAA " _
                & " from tblRevision tr1 where tr1.fldRevNum =  " _
                & " (SELECT MAX(`fldRevNum`) " _
                & " FROM tblRevision " _
                & " WHERE fldBudRefNum = '" & frmBudget.txtBRNum.Text & "') " _
                & " and  tr1.fldStat = 'OPEN' " _
                & " and tr1.fldBudRefNum = '" & frmBudget.txtBRNum.Text & "') as RemQTY "

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            x = myData.Rows(0).Item("RemQTY")

            If String.IsNullOrEmpty(x) Then
                frmBudget.mebRemQTY.Text = 0.0
            Else
                frmBudget.mebRemQTY.Text = myData.Rows(0).Item("RemQTY")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub RemQTY()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim x As String

        Try
            conn.Open()

            myCmd.Connection = conn

            myCmd.CommandText = "select ( " _
                    & " select if(tr1.fldQTY is not null,tr1.fldQTY,0) - " _
                    & " (( " _
                    & " select " _
                    & " if(tr2.fldTransCode is not null,(select IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0) " _
                    & " from tblMOI tr4 where tr4.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "' and tr4.fldStat = 'OPEN'),if(tr2.fldQTY is not null,sum(tr2.fldQTY),0)) " _
                    & " from tblOrder tr2 where tr2.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "' and tr2.fldOrderStatus = 'OPEN' " _
                    & " ) + " _
                    & " ( " _
                    & " select " _
                    & " if(tr5.fldTransCode is not null,(select IF(tr6.fldQTY IS NOT NULL,sum(tr6.fldQTY),0) " _
                    & " from tblMAI tr6 where tr6.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "' AND tr6.fldStat = 'OPEN'),if(tr5.fldQTY is not null,sum(tr5.fldQTY),0)) " _
                    & " from tblActualAcquisition tr5 where tr5.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "' " _
                    & " )) as OrdAA " _
                    & " from tblRevision tr1 where tr1.fldRevNum =  " _
                    & " (SELECT MAX(`fldRevNum`) " _
                    & " FROM tblRevision " _
                    & " WHERE fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "') " _
                    & " and  tr1.fldStat = 'OPEN' " _
                    & " and tr1.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "') as RemQTY "

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            x = myData.Rows(0).Item("RemQTY")

            If String.IsNullOrEmpty(x) Then
                frmOrder.mebRemQTY.Text = 0.0
            Else
                frmOrder.mebRemQTY.Text = myData.Rows(0).Item("RemQTY")
            End If

        Catch ex As Exception

        End Try
        

    End Sub

    Public Sub RemBudOrder()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim x As String

        conn.Open()

        myCmd.Connection = conn

        myCmd.CommandText = "select if(tr1.fldYen is not null,tr1.fldYen,0) - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) from tblUPO UPO where UPO.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "') - " _
            & "(" _
            & "SELECT if(tr2.fldYen is not null,sum(tr2.fldYen),0)FROM tblPOI tr2 where tr2.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' " _
            & ") as 'RemBudget' " _
            & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
            & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & frmOrder.ddlBRNum.Text & "' "

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        conn.Close()

        x = myData.Rows(0).Item("RemBudget")

        If String.IsNullOrEmpty(x) Then
            frmOrder.mebRemBud.Text = 0.0
        Else
            '  frmOrder.mebRemBud.Text = myData.Rows(0).Item("RemBudget")
        End If

    End Sub
    'Public Sub POUPO()
    '    Dim myCmd As New MySqlCommand
    '    Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    '    Dim myData As New DataTable
    '    Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
    '    Dim x As String

    '    conn.Open()

    '    myCmd.Connection = conn

    '    myCmd.CommandText = "SP_SelectPOPlusUPO('" & frmMultiOrder.ddlBRNum.Text & "')"

    '    myAdapter.SelectCommand = myCmd
    '    myAdapter.Fill(myData)

    '    conn.Close()

    '    x = myData.Rows(0).Item("UPOPO")

    '    If String.IsNullOrEmpty(x) Then
    '        frmMultiOrder.txtUPOPO.Text = 0.0
    '    Else
    '        frmMultiOrder.txtUPOPO.Text = x
    '    End If

    'End Sub

    Public Sub RemBudMultiOrder()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim myCmd2 As New MySqlCommand
        Dim myAdapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData2 As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim x, y As String

        conn.Open()

        myCmd.Connection = conn

        myCmd.CommandText = "select if(tr1.fldYen is not null,tr1.fldYen,0) - ((select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
            & "from tblUPO UPO where UPO.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "') + " _
            & "(" _
            & "SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where tr2.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' " _
            & ")) as 'RemBudget' " _
            & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
            & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' "

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        conn.Close()

        x = myData.Rows(0).Item("RemBudget")

        If String.IsNullOrEmpty(x) Then
            frmMultiOrder.mebRemBud.Value = 0.0
        Else
            frmMultiOrder.mebRemBud.Value = myData.Rows(0).Item("RemBudget")
        End If

    End Sub

    Public Sub RemBudAA()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()

        myCmd.Connection = conn

        myCmd.CommandText = "select if(tr1.fldYen is not null,tr1.fldYen,0) - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) from tblUPO UPO where UPO.fldBudRefNum = '" & frmAA.ddlBRNum.Text & "') - " _
                            & "(" _
                            & "SELECT if(tr2.fldYen is not null,sum(tr2.fldYen),0)FROM tblPOI tr2 where tr2.fldBudRefNum = '" & frmAA.ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' " _
                            & ") as 'RemBudget' " _
                            & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
                            & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & frmAA.ddlBRNum.Text & "' "
        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        conn.Close()

        Dim x As Integer = myData.Rows(0).Item("RemBudget")

        If String.IsNullOrEmpty(x) Then
            frmAA.mebRemBud.Text = 0.0
        Else
            frmAA.mebRemBud.Text = myData.Rows(0).Item("RemBudget")
        End If

    End Sub

    Public Sub AutoComplete()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()

        myCmd.Connection = conn

        myCmd.CommandText = "SELECT `fldBudRefNum` FROM `tblBudget` WHERE `fldStat` = 'OPEN'"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        conn.Close()

    End Sub

    Public Sub GetMultiOrder()

        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "select (Select fldTransCode from tblOrder where fldOrderID = '" & frmOrder.lblOrderID.Text & "') as MultiOrder"

        myCmd.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("MultiOrder").ToString

        If String.IsNullOrEmpty(x) Then
            ' frmOrder.btnMultiOrder.Enabled = False
            frmOrder.mebJPYAmount.ReadOnly = False
        Else
            'frmOrder.btnMultiOrder.Enabled = True
            frmOrder.mebJPYAmount.ReadOnly = True
        End If

    End Sub

    Public Sub GetTransCode()

        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "select (Select fldTransCode from tblOrder where fldOrderID = '" & frmOrder.lblOrderID.Text & "') as TransCode"

        myCmd.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("TransCode").ToString

    End Sub

    Public Sub GetOI_DI()

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "Select count(fldBudRefNum)as RefNumOI, " _
                            & "(SELECT  COUNT(fldBudRefNum) FROM tblUPO WHERE fldBudRefNum = '" & frmBudget.rgvList.CurrentRow.Cells("fldBudRefNum").Value & "') AS UPO " _
                            & "from tblPOI where fldBudRefNum = '" & frmBudget.rgvList.CurrentRow.Cells("fldBudRefNum").Value & "' and fldStat != 'CLOSE'"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("RefNumOI") Or myData.Rows(0).Item("UPO")

        If x = 0 Then
            frmBudget.btnOI.Enabled = False
        Else
            frmBudget.btnOI.Enabled = True
        End If

    End Sub

    Public Sub GetDI_AI()

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "SELECT " _
                    & "count(T4.DocNum) as RefNumAI " _
                    & "FROM POR1 T1 " _
                    & "LEFT OUTER JOIN OPOR T2 " _
                    & "ON T1.DocEntry = T2.DocEntry " _
                    & "LEFT OUTER JOIN PDN1 T3 " _
                    & "ON T2.DocEntry = T3.BaseEntry " _
                    & "AND T1.LineNum = T3.BaseLine " _
                    & "AND T1.ItemCode = T3.ItemCode " _
                    & "LEFT OUTER JOIN OPDN T4 " _
                    & "	ON T3.DocEntry = T4.DocEntry " _
                    & "LEFT OUTER JOIN RPD1 T5 " _
                    & "ON T4.DocEntry = T5.BaseEntry " _
                    & "AND T3.LineNum = T5.BaseLine " _
                    & "AND T3.ItemCode = T5.ItemCode " _
                    & "LEFT OUTER JOIN ORPD T6 " _
                    & "ON T5.DocEntry = T6.DocEntry " _
                    & "LEFT OUTER JOIN PCH1 T7 " _
                    & "ON T4.DocEntry = T7.BaseEntry " _
                    & "AND T3.LineNum = T7.BaseLine " _
                    & "AND T3.ItemCode = T7.ItemCode " _
                    & "LEFT OUTER JOIN OPCH T8 " _
                    & "ON T7.DocEntry = T8.DocEntry " _
                    & "LEFT OUTER JOIN RPC1 T9 " _
                    & "ON T8.DocEntry = T9.BaseEntry " _
                    & "AND T7.LineNum = T9.BaseLine " _
                    & "AND T7.ItemCode = T9.ItemCode " _
                    & "LEFT OUTER JOIN ORPC T10 " _
                    & "ON T9.DocEntry = T10.DocEntry " _
                    & "WHERE T2.U_HeaderID Is Not null " _
                    & "and T6.DocNum is null " _
                    & "and T10.DocNum is null " _
                     & "and T1.U_BudgetRef = '" & frmBudget.rgvList.CurrentRow.Cells("fldBudRefNum").Value & "'"
        myCmd.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("RefNumAI")

        If x = 0 Then
            frmBudget.btnDI.Enabled = False
        Else
            frmBudget.btnDI.Enabled = True
        End If

    End Sub

    'Public Sub Fivepercent()

    '    Dim myCmd As New MySqlCommand
    '    Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    '    Dim myData As New DataTable
    '    Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

    '    Dim x As Decimal

    '    conn.Open()

    '    myCmd.Connection = conn

    '    myCmd.CommandText = "select if(tr1.fldYen is not null,tr1.fldYen,0) - (select if(UPO.fldJPY is not null,sum(UPO.fldJPY),0) " _
    '                        & "from tblUPO UPO where UPO.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "') - " _
    '                        & "( " _
    '                        & "SELECT if(tr2.fldYenSap is not null,sum(tr2.fldYenSap),0)FROM tblPOI tr2 where tr2.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' and tr2.fldStat != 'CLOSE' " _
    '                        & ")- " _
    '                        & "(( " _
    '                        & "SELECT if(PR.fldEJPY is not null,sum(PR.fldEJPY),0) " _
    '                        & " FROM tblOrder PR where (select count(MO.fldTransCode) " _
    '                        & "from tblMOI MO where MO.fldTransCode = PR.fldTransCode " _
    '                        & " and MO.fldStat = 'OPEN') != 0 and PR.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' " _
    '                        & ")) " _
    '                        & " as 'mebRemBLPR' " _
    '                        & "from tblRevision tr1 left join tblBudget tr7 on tr1.fldBudRefNum = tr7.fldBudRefNum " _
    '                        & "where tr1.fldStat != 'CLOSE' and tr1.fldBudRefNum = '" & frmMultiOrder.ddlBRNum.Text & "' "
    '    myAdapter.SelectCommand = myCmd
    '    myAdapter.Fill(myData)

    '    x = myData.Rows(0).Item("mebRemBLPR") * 0.05

    '    If (frmMultiOrder.mebRemBLPR.Value * -1) > x And frmMultiOrder.txtNB.Text = "NO" Then
    '        frmMultiOrder.mebRemBLPR.BackColor = Color.Red
    '        RadMessageBox.SetThemeName("Windows8")
    '        RadMessageBox.Show("Insufficient Budget", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

    '    Else
    '        frmMultiOrder.mebRemBLPR.BackColor = Color.Orange
    '    End If

    'End Sub

End Module
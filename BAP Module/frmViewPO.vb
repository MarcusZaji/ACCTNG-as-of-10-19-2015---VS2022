Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient


Public Class FrmViewPO

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private dtLoadOPOR As DataTable
    Private dtLoadPO As DataTable
    Private dtLoadGRPO As DataTable

    Private Sub FrmViewPO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadDataPO.IsBusy Then
                bwLoadDataPO.CancelAsync()
                imBusy = False
            End If

            Me.Close()
        End If
    End Sub

    Private Sub FrmViewPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmsplash.busy()
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        ReadyPOGrid()
        ReadyPOIGrid()
        ReadyItemGrid()
        Getuser()

        dtpMOrder.Value = Today
        dtpDelDate.Value = Today
        ddlFMonth.Text = Today.Month
        ddlFYear.Text = Today.Year

    End Sub

    Private Sub FrmViewPO_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        bwLoadDataPO.RunWorkerAsync()
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Visible = True
        DepartmentListPO()
        ddlDept.Text = lblDept.Text
    End Sub

    Private Sub bwLoadDataPO_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataPO.DoWork
        Dim FMONTH As Integer = ddlFMonth.Text
        Dim FYEAR As Integer = ddlFYear.Text
        Dim DEPT As String = lblDept.Text
        Dim DeptNew As String = ddlDept.Text

        imBusy = True

        If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Or lblUserlvl.Text = "PROFESSIONAL" Or lblUserlvl.Text = "MANAGER" Then

            dtLoadPO = Chinita.fetchDBTable("call SP_GetPOByDeptDate('" & FMONTH & "','" & FYEAR & "','" & DeptNew & "')")
            'Comment due to SAP problem
            dtLoadOPOR = Chinita.fetchDbTableSAPSupp("select DocNum,U_HeaderID from OPOR where U_HeaderID is not null")
            'dtLoadOPOR = Chinita.fetchDbTableSAPSupp("SELECT DISTINCT  T0.DocNum,T0.U_HeaderID,T1.U_Detail_ID  from OPOR T0 INNER JOIN POR1 T1 ON T0.DocEntry = T1.DocEntry where U_Detaild_ID ")

            FetchMePO()
            'Replace Linq
            'FetchMeNoPOno()
        Else
            dtLoadPO = Chinita.fetchDBTable("call SP_GetPOByDeptDate('" & FMONTH & "','" & FYEAR & "','" & DEPT & "')")
            'Comment due to SAP problem
            dtLoadOPOR = Chinita.fetchDbTableSAPSupp("select DocNum,U_HeaderID from OPOR where U_HeaderID is not null")
            FetchMePO()
            'Replace Linq
            'FetchMeNoPOno()
        End If

        For counter As Integer = 0 To dtLoadData.Rows.Count - 1
            Dim x As Double = counter / dtLoadData.Rows.Count * 100
            bwLoadDataPO.ReportProgress(x)
            Threading.Thread.Sleep(Delay)
        Next

    End Sub
    Public Sub FetchMeNoPOno()
        Dim FMONTH As Integer = ddlFMonth.Text
        Dim FYEAR As Integer = ddlFYear.Text
        Dim DEPT As String = lblDept.Text
        '-----------------Super Linq---------------------------
        '----------------Query------------------------------------
        Dim query = (From PO In dtLoadPO.AsEnumerable()
                     Select New With {
           Key .fldPOID = PO("fldPOID"),
           Key .fldIndex = PO("fldIndex"),
           Key .fldSupplier = PO("fldSupplier"),
           Key .fldVCode = PO("fldVCode"),
           Key .fldCurrency = PO("fldCurrency"),
           Key .fldStat = PO("fldStat"),
           Key .fldForcePO = PO("fldForcePO"),
           Key .fldMOrdered = PO("fldMOrdered"),
           Key .fldDDate = PO("fldDDate"),
           Key .fldTPO = PO("fldTPO"),
           Key .fldDiscount = PO("fldDiscount"),
           Key .fldDAmount = PO("fldDAmount"),
           Key .OB_POAmt = PO("OB_POAmt"),
           Key .fldSignature = PO("fldSignature"),
           Key .fldRemarks = PO("fldRemarks"),
           Key .OB_Line = PO("OB_Line")
            }).ToList
        dtLoadData = Chinita.convertToDatatable(query)
    End Sub
    Public Sub FetchMePO()
        Dim FMONTH As Integer = ddlFMonth.Text
        Dim FYEAR As Integer = ddlFYear.Text
        Dim DEPT As String = lblDept.Text
        '-----------------Super Linq---------------------------
        '----------------Query------------------------------------
        Dim query = (From PO In dtLoadPO.AsEnumerable()
                     Let MyPO = GetPONo(PO("OB_Line"))
                     Select New With {
           Key .fldPOID = PO("fldPOID"),
           Key .fldIndex = PO("fldIndex"),
           Key .fldSupplier = PO("fldSupplier"),
           Key .fldVCode = PO("fldVCode"),
           Key .fldCurrency = PO("fldCurrency"),
           Key .fldStat = PO("fldStat"),
           Key .fldForcePO = PO("fldForcePO"),
           Key .fldMOrdered = PO("fldMOrdered"),
           Key .fldDDate = PO("fldDDate"),
           Key .fldTPO = PO("fldTPO"),
           Key .fldDiscount = PO("fldDiscount"),
           Key .fldDAmount = PO("fldDAmount"),
           Key .OB_POAmt = PO("OB_POAmt"),
           Key .fldSignature = PO("fldSignature"),
           Key .fldRemarks = PO("fldRemarks"),
           Key .OB_Line = PO("OB_Line"),
           Key .PO = MyPO
            }).ToList
        dtLoadData = Chinita.convertToDatatable(query)
    End Sub
    Public Sub FetchMePoJoin()
        Dim FMONTH As Integer = ddlFMonth.Text
        Dim FYEAR As Integer = ddlFYear.Text
        Dim DEPT As String = lblDept.Text
        '-----------------Super Linq------------------------------
        dtLoadOPOR = Chinita.fetchDbTableSAPSupp("select DocNum,U_HeaderID from OPOR where U_HeaderID is not null")
        '----------------Query------------------------------------
        Dim query = (From PO In dtLoadPO.AsEnumerable()
                     Join OPOR In dtLoadOPOR.AsEnumerable() On PO("OB_Line") Equals OPOR("U_HeaderID")
                     Select New With {
           Key .fldPOID = PO("fldPOID"),
           Key .fldIndex = PO("fldIndex"),
           Key .fldSupplier = PO("fldSupplier"),
           Key .fldVCode = PO("fldVCode"),
           Key .fldCurrency = PO("fldCurrency"),
           Key .fldStat = PO("fldStat"),
           Key .fldForcePO = PO("fldForcePO"),
           Key .fldMOrdered = PO("fldMOrdered"),
           Key .fldDDate = PO("fldDDate"),
           Key .fldTPO = PO("fldTPO"),
           Key .fldDiscount = PO("fldDiscount"),
           Key .fldDAmount = PO("fldDAmount"),
           Key .OB_POAmt = PO("OB_POAmt"),
           Key .fldSignature = PO("fldSignature"),
           Key .fldRemarks = PO("fldRemarks"),
           Key .OB_Line = PO("OB_Line"),
           Key .PO = OPOR("DocNum")
            }).ToList
        dtLoadData = Chinita.convertToDatatable(query)
        '------------------End linq-----------------------------
    End Sub
    Function GetPONo(ByVal OB_Line As String)
        Dim POVal = ""
        'dtLoadOPOR = Chinita.fetchDbTableSAPSupp("select DocNum,U_HeaderID from OPOR where U_HeaderID is not null")
        Try
            Dim QueryOPOR = (From OPOR In dtLoadOPOR.AsEnumerable()
                             Where OPOR.Field(Of String)("U_HeaderID") = OB_Line
                             Select New With
                                   {
                                    .DocNum = OPOR("DocNum")
                                   }
                        ).Take(1).ToList
            Dim dtOPOR As DataTable = Chinita.convertToDatatable(QueryOPOR)
            POVal = dtOPOR.Rows(0).Item("DocNum").ToString
        Catch ex As Exception
            POVal = ""
        End Try

        Return POVal
    End Function

    Private Sub bwLoadDataPO_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadDataPO.ProgressChanged
        pbOlrayt.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadDataPO_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadDataPO.RunWorkerCompleted
        Try
            rgvPOList.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOlrayt.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Getuser()
        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

        lblName.Text = drUser.Item("fldName").ToString

        If lblUserlvl.Text = "USER" Then
            btnCancelPO.Visible = False
            btnClosePO.Visible = False
        Else
            btnCancelPO.Visible = True
            btnClosePO.Visible = True
        End If

    End Sub

    Private Sub bwLoadDataPOI_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataPOI.DoWork
        Try
            Dim OB_Line As String = rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString

            dtLoadData2 = Chinita.fetchDBTable("call PO_GetPOItemsv2('" & OB_Line & "')")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bwLoadDataPOI_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadDataPOI.RunWorkerCompleted
        rgvPOIList.DataSource = dtLoadData2
    End Sub

    Private Sub ReadyPOGrid()

        Dim fldPOIDColumn As New GridViewTextBoxColumn("ID")
        With fldPOIDColumn
            .FieldName = "fldPOID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
            .IsVisible = True
        End With
        rgvPOList.Columns.Add(fldPOIDColumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn("Index")
        With fldIndexColumn
            .FieldName = "fldIndex"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
            .IsPinned = Left
        End With
        rgvPOList.Columns.Add(fldIndexColumn)

        Dim fldPONumberColumn As New GridViewTextBoxColumn("PO NUMBER")
        With fldPONumberColumn
            .FieldName = "PO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
        End With
        rgvPOList.Columns.Add(fldPONumberColumn)


        'Dim fldGRPONumberColumn As New GridViewTextBoxColumn("GRPO NUMBER")
        'With fldGRPONumberColumn
        '    .FieldName = "GRPO"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 80
        '    .IsPinned = Right
        '    .IsVisible = False
        'End With
        'rgvPOList.Columns.Add(fldGRPONumberColumn)

        Dim OB_LineColumn As New GridViewTextBoxColumn("OB LINE")
        With OB_LineColumn
            .FieldName = "OB_Line"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
            .IsVisible = True
        End With
        rgvPOList.Columns.Add(OB_LineColumn)

        Dim fldVCodeColumn As New GridViewTextBoxColumn("VENDOR CODE")
        With fldVCodeColumn
            .FieldName = "fldVCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvPOList.Columns.Add(fldVCodeColumn)

        Dim fldSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
        With fldSupplierColumn
            .FieldName = "fldSupplier"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 250
        End With
        rgvPOList.Columns.Add(fldSupplierColumn)

        Dim fldMOrderedColumn As New GridViewTextBoxColumn("ORDER DATE")
        With fldMOrderedColumn
            .FieldName = "fldMOrdered"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOList.Columns.Add(fldMOrderedColumn)
        rgvPOList.Columns("fldMOrdered").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDDateColumn As New GridViewTextBoxColumn("DELIVERY DATE")
        With fldDDateColumn
            .FieldName = "fldDDate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOList.Columns.Add(fldDDateColumn)
        rgvPOList.Columns("fldDDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOList.Columns.Add(fldCurrencyColumn)

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "fldStat"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = False
        End With
        rgvPOList.Columns.Add(fldStatColumn)

        Dim fldTPOColumn As New GridViewDecimalColumn("TOTAL PO AMOUNT")
        With fldTPOColumn
            .FieldName = "fldTPO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldTPOColumn)
        rgvPOList.Columns("fldTPO").FormatString = "{0:N2}"

        Dim OB_POAmtColumn As New GridViewDecimalColumn("PO AMOUNT WITH DISCOUNT")
        With OB_POAmtColumn
            .FieldName = "OB_POAmt"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(OB_POAmtColumn)
        rgvPOList.Columns("OB_POAmt").FormatString = "{0:N2}"

        Dim fldDiscountColumn As New GridViewDecimalColumn("%")
        With fldDiscountColumn
            .FieldName = "fldDiscount"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldDiscountColumn)
        rgvPOList.Columns("fldDiscount").FormatString = "{0:N2}"

        Dim fldDAmountColumn As New GridViewDecimalColumn("DISCOUNT")
        With fldDAmountColumn
            .FieldName = "fldDAmount"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            '.IsVisible = False
        End With
        rgvPOList.Columns.Add(fldDAmountColumn)
        rgvPOList.Columns("fldDAmount").FormatString = "{0:N2}"

        'Dim fldYenSapColumn As New GridViewDecimalColumn("SAP YEN AMOUNT")
        'With fldYenSapColumn
        '    .FieldName = "SAPJPY"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 150
        '    '.IsVisible = False
        'End With
        'rgvPOList.Columns.Add(fldYenSapColumn)
        'rgvPOList.Columns("SAPJPY").FormatString = "{0:N2}"

        'Dim fldYenBapColumn As New GridViewDecimalColumn("BAP YEN AMOUNT")
        'With fldYenBapColumn
        '    .FieldName = "BAPJPY"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 150
        '    '.IsVisible = False
        'End With
        'rgvPOList.Columns.Add(fldYenBapColumn)
        'rgvPOList.Columns("BAPJPY").FormatString = "{0:N2}"

        'Dim fldforestColumn As New GridViewDecimalColumn("FOREX")
        'With fldforestColumn
        '    .FieldName = "forest"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 150
        '    '.IsVisible = False
        'End With
        'rgvPOList.Columns.Add(fldforestColumn)
        'rgvPOList.Columns("forest").FormatString = "{0:N2}"

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldRemarks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 250
        End With
        rgvPOList.Columns.Add(fldRemarksColumn)

        Dim fldForcePOColumn As New GridViewTextBoxColumn("FPO")
        With fldForcePOColumn
            .FieldName = "fldForcePO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
        End With
        rgvPOList.Columns.Add(fldForcePOColumn)

        Dim fldSignatureColumn As New GridViewTextBoxColumn("SIGNATURE")
        With fldSignatureColumn
            .FieldName = "fldSignature"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 180
        End With
        rgvPOList.Columns.Add(fldSignatureColumn)

        'Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        'With fldDeptColumn
        '    .FieldName = "fldDept"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 100
        '    .IsPinned = Left
        '    '.IsVisible = False
        'End With
        'rgvPOList.Columns.Add(fldDeptColumn)

        AddHandler Me.rgvPOList.RowFormatting, AddressOf rgvPOList_RowFormatting

        Dim PrintMe As New GridViewCommandColumn("Print PO")
        With PrintMe
            .FieldName = "Print PO"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "Print PO"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvPOList.Columns.Add(PrintMe)

        Dim CSV As New GridViewCommandColumn("Download CSV")
        With CSV
            .FieldName = "CSV"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "CSV"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvPOList.Columns.Add(CSV)

        AddHandler rgvPOList.CommandCellClick, AddressOf Command

        With rgvPOList
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

    Private Sub Command()
        If rgvPOList.CurrentColumn.HeaderText = "Print PO" Then
            reporttype = 25
            globalVariables.OBLine = rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString
            globalVariables.POID = rgvPOList.CurrentRow.Cells("fldPOID").Value.ToString
            Try
                FrmReportServer.Show(Me)
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try
        ElseIf rgvPOList.CurrentColumn.HeaderText = "Download CSV" Then

            Zaji.addParameter("_OB_Line", rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString)
            Dim DTCPO As DataTable = Zaji.dbSelect("SP_CPO_CreateCSVbyOBLine")
            rgvCreatePO.DataSource = DTCPO


        End If
    End Sub

    Private Sub ReadyPOIGrid()

        Dim fldPOIDColumn As New GridViewTextBoxColumn("ID")
        With fldPOIDColumn
            .FieldName = "fldPOIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
        End With
        rgvPOIList.Columns.Add(fldPOIDColumn)

        Dim fldPONumberColumn As New GridViewTextBoxColumn("PO NUMBER")
        With fldPONumberColumn
            .FieldName = "PO"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldPONumberColumn)

        Dim fldMOIID As New GridViewTextBoxColumn("MOIID")
        With fldMOIID
            .FieldName = "fldMOIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldMOIID)

        Dim OB_LineColumn As New GridViewTextBoxColumn("OB LINE")
        With OB_LineColumn
            .FieldName = "OB_Line"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(OB_LineColumn)

        Dim fldBudRefNumColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefNumColumn
            .FieldName = "fldBudRefNum"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            .IsPinned = Right
        End With
        rgvPOIList.Columns.Add(fldBudRefNumColumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn("Index")
        With fldIndexColumn
            .FieldName = "fldIndex"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
            .IsPinned = Left
        End With
        rgvPOIList.Columns.Add(fldIndexColumn)

        Dim fldPRNoColumn As New GridViewTextBoxColumn("PR NUMBER")
        With fldPRNoColumn
            .FieldName = "fldPRNo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOIList.Columns.Add(fldPRNoColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldICodeColumn
            .FieldName = "fldICode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvPOIList.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("ITEM DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 250
        End With
        rgvPOIList.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QTY")
        With fldQTYColumn
            .FieldName = "RQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
        End With
        rgvPOIList.Columns.Add(fldQTYColumn)
        rgvPOIList.Columns("RQTY").FormatString = "{0:N2}"

        Dim fldUnitColumn As New GridViewTextBoxColumn("UNIT")
        With fldUnitColumn
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
        End With
        rgvPOIList.Columns.Add(fldUnitColumn)

        Dim fldUPriceColumn As New GridViewDecimalColumn("UNIT PRICE")
        With fldUPriceColumn
            .FieldName = "fldUPrice"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvPOIList.Columns.Add(fldUPriceColumn)
        rgvPOIList.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldRateColumn As New GridViewDecimalColumn("RATE")
        With fldRateColumn
            .FieldName = "fldRate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvPOIList.Columns.Add(fldRateColumn)
        rgvPOIList.Columns("fldRate").FormatString = "{0:N6}"

        Dim fldYenSapColumn As New GridViewDecimalColumn("SAP JPY")
        With fldYenSapColumn
            .FieldName = "fldYenSap"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvPOIList.Columns.Add(fldYenSapColumn)
        rgvPOIList.Columns("fldYenSap").FormatString = "{0:N6}"

        Dim fldGRPOQTY As New GridViewDecimalColumn("GRPO QTY")
        With fldGRPOQTY
            .FieldName = "GRPOQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldGRPOQTY)
        rgvPOIList.Columns("GRPOQTY").FormatString = "{0:N2}"

        Dim fldStatusColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "STAT"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = False
        End With
        rgvPOIList.Columns.Add(fldStatusColumn)

        With rgvPOIList
            .EnableAlternatingRowColor = True
            .ShowGroupPanel = True
            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

        'Comment SAP Fix
        'Dim fldUpdate As New GridViewCommandColumn("UPDATE")
        'With fldUpdate
        '    .FieldName = "UPDATE"
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 70
        '    .IsVisible = True
        '    .DefaultText = "UPDATE"
        '    .UseDefaultText = True
        '    .PinPosition = PinnedColumnPosition.Right
        'End With
        'rgvPOIList.Columns.Add(fldUpdate)
        '-----------------------------------------------------
        rgvPOIList.EnableFiltering = True
        AddHandler rgvPOIList.CommandCellClick, AddressOf UpdateMe
    End Sub
    Private Sub UpdateMe()
        If rgvPOIList.CurrentColumn.HeaderText = "UPDATE" Then
            Try
                FrmUpdatePOI.txtID.Text = rgvPOIList.CurrentRow.Cells("fldPOIID").Value.ToString
                FrmUpdatePOI.ddlItemUOM.Text = rgvPOIList.CurrentRow.Cells("fldUnit").Value.ToString
                FrmUpdatePOI.txtIMDesc.Text = rgvPOIList.CurrentRow.Cells("fldDesc").Value.ToString

                If Zaji.IsFormOpen(FrmUpdatePOI) Then
                    FrmUpdatePOI.Focus()
                Else
                    FrmUpdatePOI.Show()
                End If
            Catch ex As Exception
                MessageBox.Show("Error Update Please call local 606")
            End Try

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If bwLoadDataPO.IsBusy Then
            bwLoadDataPO.CancelAsync()
            imBusy = False
        End If

        Me.Close()
    End Sub

    Private Sub rgvPOList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvPOList.CellClick
        Try
            txtSupName.Text = rgvPOList.CurrentRow.Cells("fldSupplier").Value.ToString
            txtVenCode.Text = rgvPOList.CurrentRow.Cells("fldVCode").Value.ToString
            txtCurrency.Text = rgvPOList.CurrentRow.Cells("fldCurrency").Value.ToString
            dtpMOrder.Value = rgvPOList.CurrentRow.Cells("fldMOrdered").Value
            dtpDelDate.Value = rgvPOList.CurrentRow.Cells("fldDDate").Value
            RTTPO.Text = rgvPOList.CurrentRow.Cells("fldTPO").Value.ToString
            RTUPrice.Text = rgvPOList.CurrentRow.Cells("fldDAmount").Value.ToString
            RTD.Text = rgvPOList.CurrentRow.Cells("fldDiscount").Value.ToString
            RTTotal.Text = rgvPOList.CurrentRow.Cells("OB_POAmt").Value.ToString
            txtRemarks.Text = rgvPOList.CurrentRow.Cells("fldRemarks").Value.ToString

            bwLoadDataPOI.RunWorkerAsync()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtSupName.Text = ""
        txtVenCode.Text = ""
        txtCurrency.Text = ""

        RTTPO.Text = 0.0
        RTUPrice.Text = 0.0
        RTD.Text = 0.0
        RTTotal.Text = 0.0
        txtRemarks.Text = ""

        rgvPOList.FilterDescriptors.Clear()

        bwLoadDataPO.RunWorkerAsync()

    End Sub

    Private Sub rgvPOList_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles rgvPOList.RowFormatting
        If e.RowElement.RowInfo.Cells("fldForcePO").Value.ToString = "YES" Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.LightPink

        ElseIf e.RowElement.RowInfo.Cells("fldSignature").Value.ToString = "PC-MAAN ARELA" Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.MediumOrchid
        End If
    End Sub

    Private Sub rgvPOList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvPOList.SelectionChanged
        Try
            txtSupName.Text = rgvPOList.CurrentRow.Cells("fldSupplier").Value.ToString
            txtVenCode.Text = rgvPOList.CurrentRow.Cells("fldVCode").Value.ToString
            txtCurrency.Text = rgvPOList.CurrentRow.Cells("fldCurrency").Value.ToString
            dtpMOrder.Value = rgvPOList.CurrentRow.Cells("fldMOrdered").Value
            dtpDelDate.Value = rgvPOList.CurrentRow.Cells("fldDDate").Value
            RTTPO.Text = rgvPOList.CurrentRow.Cells("fldTPO").Value.ToString
            RTUPrice.Text = rgvPOList.CurrentRow.Cells("fldDAmount").Value.ToString
            RTD.Text = rgvPOList.CurrentRow.Cells("fldDiscount").Value.ToString
            RTTotal.Text = rgvPOList.CurrentRow.Cells("OB_POAmt").Value.ToString
            txtRemarks.Text = rgvPOList.CurrentRow.Cells("fldRemarks").Value.ToString

            bwLoadDataPOI.RunWorkerAsync()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelPO_Click(sender As Object, e As EventArgs) Handles btnCancelPO.Click

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim connSap As New SqlClient.SqlConnection(Sapsap)

        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand

        Dim myCmdSap As New SqlClient.SqlCommand
        Dim myAdapterSap As New SqlClient.SqlDataAdapter
        Dim myDataSap As New DataTable

        Dim myAdapter As New MySqlDataAdapter
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myAdapter3 As New MySqlDataAdapter

        Dim OB_LineUp As String = rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString
        Dim IndexPO As Integer = rgvPOList.CurrentRow.Cells("fldIndex").Value.ToString

        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to Cancel this item(s)?",
                            "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If String.IsNullOrEmpty(txtRem4CloseCancelPO.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please insert a remarks for Close/Cancel PO.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                conn.Open()
                connSap.Open()

                myCmd.Connection = conn
                myCmd2.Connection = conn
                myCmd3.Connection = conn
                myCmdSap.Connection = connSap

                myCmdSap.Connection = connSap
                myCmdSap.CommandText = "SELECT count(T4.DocNum) AS CheckGRPO FROM POR1 T1 " _
                    & "LEFT OUTER JOIN OPOR T2 ON T1.DocEntry = T2.DocEntry " _
                    & "LEFT OUTER JOIN PDN1 T3 ON T2.DocEntry = T3.BaseEntry AND T1.LineNum = T3.BaseLine AND T1.ItemCode = T3.ItemCode " _
                    & "LEFT OUTER JOIN OPDN T4 ON T3.DocEntry = T4.DocEntry " _
                    & "LEFT OUTER JOIN RPD1 T5 " _
                    & "ON T4.DocEntry = T5.BaseEntry " _
                    & "AND T3.LineNum = T5.BaseLine " _
                    & "AND T3.ItemCode = T5.ItemCode " _
                    & "LEFT OUTER JOIN ORPD T6 " _
                    & "ON T5.DocEntry = T6.DocEntry " _
                    & "where T2.U_HeaderID = '" & rgvPOList.CurrentRow.Cells("OB_Line").Value & "' and T6.DocNum is null"
                myCmdSap.ExecuteNonQuery()

                myAdapterSap.SelectCommand = myCmdSap
                myAdapterSap.Fill(myDataSap)
                Dim CGRPO = myDataSap.Rows(0).Item("CheckGRPO")
                'If CGRPO > 0 Then
                '    RadMessageBox.SetThemeName("Windows8")
                '    RadMessageBox.Show("This PO has already have an transaction. Please Check SAP.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                'Else

                For x As Integer = 0 To rgvPOIList.ChildRows.Count - 1

                    Dim POIID As Integer = rgvPOIList.ChildRows(x).Cells("fldPOIID").Value
                    Dim Index As Integer = rgvPOIList.ChildRows(x).Cells("fldIndex").Value

                    Dim SOUT As Decimal = rgvPOIList.ChildRows(x).Cells("RQTY").Value

                    Dim MOIID As Integer = rgvPOIList.ChildRows(x).Cells("fldMOIID").Value

                    myCmd.CommandText = "UPDATE tblPOI SET fldStat = 'CLOSE', fldCancel = 'YES'  WHERE fldPOIID = '" & POIID & "' and fldIndex = '" & Index & "';"
                    myCmd.ExecuteNonQuery()

                    myCmd2.CommandText = "UPDATE `tblMOI` SET `fldQTYSIN`='" & SOUT & "'" _
                        & ", fldQTYEB = fldQTY - (fldQTYSOUT - fldQTYSIN) , fldStat = if(fldQTY <= (fldQTYSOUT - fldQTYSIN),'CLOSE','OPEN') WHERE `fldMOIID` ='" & MOIID & "';"
                    myCmd2.ExecuteNonQuery()

                Next

                myCmd3.CommandText = "UPDATE tblPO SET fldStat = 'CLOSE', fldCancel ='YES', " _
                         & "fldRemarksCC = '" & txtRem4CloseCancelPO.Text & "', fldCancelSignature = '" & txtSignature.Text & "' " _
                         & "WHERE OB_Line = '" & OB_LineUp & "' and fldIndex = '" & IndexPO & "';"
                myCmd3.ExecuteNonQuery()

                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Purchase Order Successfully Close", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                'End If

            End If

        End If

        conn.Close()

    End Sub

    Private Sub btnClosePO_Click(sender As Object, e As EventArgs) Handles btnClosePO.Click

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim connSap As New SqlClient.SqlConnection(Sapsap)

        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand

        Dim myCmdSap As New SqlClient.SqlCommand
        Dim myAdapterSap As New SqlClient.SqlDataAdapter
        Dim myDataSap As New DataTable

        Dim myAdapter As New MySqlDataAdapter
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myAdapter3 As New MySqlDataAdapter

        Dim OB_LineUp As String = rgvPOList.CurrentRow.Cells("OB_Line").Value.ToString
        Dim IndexPO As Integer = rgvPOList.CurrentRow.Cells("fldIndex").Value.ToString

        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to close this item(s)?",
                            "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If String.IsNullOrEmpty(txtRem4CloseCancelPO.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please insert a remarks for Close/Cancel PO.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else

                conn.Open()
                connSap.Open()

                myCmd.Connection = conn
                myCmd2.Connection = conn
                myCmd3.Connection = conn
                myCmdSap.Connection = connSap

                myCmdSap.Connection = connSap
                myCmdSap.CommandText = "SELECT count(T4.DocNum) AS CheckGRPO FROM POR1 T1 " _
                    & "LEFT OUTER JOIN OPOR T2 ON T1.DocEntry = T2.DocEntry " _
                    & "LEFT OUTER JOIN PDN1 T3 ON T2.DocEntry = T3.BaseEntry AND T1.LineNum = T3.BaseLine AND T1.ItemCode = T3.ItemCode " _
                    & "LEFT OUTER JOIN OPDN T4 ON T3.DocEntry = T4.DocEntry " _
                    & "where T2.U_HeaderID = '" & rgvPOList.CurrentRow.Cells("OB_Line").Value & "'"
                myCmdSap.ExecuteNonQuery()

                myAdapterSap.SelectCommand = myCmdSap
                myAdapterSap.Fill(myDataSap)
                Dim CGRPO = myDataSap.Rows(0).Item("CheckGRPO")
                If CGRPO > 0 Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("This PO has already have an transaction. Please Check SAP.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Else

                    For x As Integer = 0 To rgvPOIList.ChildRows.Count - 1

                        Dim POIID As Integer = rgvPOIList.ChildRows(x).Cells("fldPOIID").Value
                        Dim Index As Integer = rgvPOIList.ChildRows(x).Cells("fldIndex").Value

                        Dim SOUT As Decimal = rgvPOIList.ChildRows(x).Cells("RQTY").Value

                        Dim MOIID As Integer = rgvPOIList.ChildRows(x).Cells("fldMOIID").Value

                        myCmd.CommandText = "UPDATE tblPOI SET fldStat = 'CLOSE', fldDrop = 'YES'  WHERE fldPOIID = '" & POIID & "' and fldIndex = '" & Index & "';"
                        myCmd.ExecuteNonQuery()

                        myCmd2.CommandText = "UPDATE `tblMOI` SET `fldQTYSIN`='" & SOUT & "'" _
                       & ", fldQTYEB = fldQTY - (fldQTYSOUT - fldQTYSIN) , fldStat = if(fldQTY <= (fldQTYSOUT - fldQTYSIN),'CLOSE','OPEN') WHERE `fldMOIID` ='" & MOIID & "';"
                        myCmd2.ExecuteNonQuery()

                    Next

                    myCmd3.CommandText = "UPDATE tblPO SET fldStat = 'CLOSE', fldDrop ='YES', " _
                        & "fldRemarksCC = '" & txtRem4CloseCancelPO.Text & "', fldCloseSignature = '" & txtSignature.Text & "' " _
                        & "WHERE OB_Line = '" & OB_LineUp & "' and fldIndex = '" & IndexPO & "';"
                    myCmd3.ExecuteNonQuery()

                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Purchase Order Successfully Close", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                End If

            End If

        End If


        conn.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            bwLoadDataPO.RunWorkerAsync()
            Me.Cursor = Cursors.WaitCursor
            pbOlrayt.Visible = True
            imBusy = True
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        End Try
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ''Try
        ''-------------------'
        ''-- EXPORT TO 192.168.191.20 SAP-INTEGRATION --'
        ''-------------------'
        'rgvCreatePO.ShowColumnHeaders = False

        'Dim exporter As ExportToCSV = New ExportToCSV(rgvCreatePO)
        '    exporter.FileExtension = "csv"

        '    Dim Time As String = System.DateTime.Now.ToString("ddMMyyyyHHmmss")
        '    exporter.SummariesExportOption = SummariesOption.DoNotExport

        '    Dim fileName As String = "\\192.168.191.20\public\SAP-INTIGRATION" & "\" & Time & ".csv"

        '    exporter.RunExport(fileName)

        '    Dim text As String() = System.IO.File.ReadAllLines(fileName)

        '    For i As Integer = 0 To text.Length - 1
        '        text(i) = text(i).Replace("""", "")
        '    Next

        '    System.IO.File.WriteAllLines(fileName, text)

        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show("CSV file was created to MIS Folder. Please informed MIS to access the folder", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        'rgvCreatePO.ShowColumnHeaders = True



        ''---------'
        ''-- END --'
        ''---------'

        ''Catch ex As Exception

        ''End Try

        rgvCreatePO.ShowColumnHeaders = False
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

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("CSV file was created to MIS Folder. Please informed MIS to access the folder", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)


        Catch ex As Exception

        End Try
        rgvCreatePO.ShowColumnHeaders = True
    End Sub
End Class

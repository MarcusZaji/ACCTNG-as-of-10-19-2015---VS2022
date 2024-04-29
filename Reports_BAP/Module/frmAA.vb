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

    Private Sub frmAA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)
        txtSignature.ReadOnly = True

        DepartmentAA()
        ClassificationAA()

        Clear()

        ddlWBud.Text = "WITHOUT"

        ReadyGrid()
        ReadyItemGrid()

        GetUser()

    End Sub

    Private Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        ddlDept.Text = drUser.Item("fldDept").ToString

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
        'ddlWBud.Enabled = True
        'ddlBRNum.Enabled = True
        txtPONum.Enabled = True
        txtPRNum.Enabled = True
        dtpMAcquired.Enabled = True
        txtDesc.Enabled = True
        ddlClass.Enabled = True
        ddlDept.Enabled = True
        mebJPYAmount.Enabled = True
        txtRemarks.Enabled = True

        btnAddAA.Enabled = True

    End Sub

    Private Sub Clear()

        ddlWBud.Text = "WITHOUT"
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

        btnAddAA.Enabled = True
    End Sub

    Private Sub GetData()
        Try
            ddlWBud.Text = rgvList.CurrentRow.Cells("fldWBudget").Value.ToString
            ddlBRNum.Text = rgvList.CurrentRow.Cells("fldBudRefNum").Value.ToString
            txtPONum.Text = rgvList.CurrentRow.Cells("fldPONo").Value.ToString
            txtPRNum.Text = rgvList.CurrentRow.Cells("fldPRNo").Value.ToString
            dtpMAcquired.Value = rgvList.CurrentRow.Cells("fldMonthAcquired").Value.ToString
            txtSupplier.Text = rgvList.CurrentRow.Cells("fldOrderSupplier").Value.ToString
            txtDesc.Text = rgvList.CurrentRow.Cells("fldOrderDesc").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("fldClassification").Value.ToString
            mebQTY.Text = rgvList.CurrentRow.Cells("fldQTY").Value.ToString
            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldOrderDepartment").Value.ToString
            mebJPYAmount.Text = rgvList.CurrentRow.Cells("fldAmountJPY").Value.ToString
            txtRemarks.Text = rgvList.CurrentRow.Cells("fldOrderRemarks").Value.ToString
            mebRemBud.Text = rgvList.CurrentRow.Cells("RemBal").Value.ToString
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

            btnAddAA.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReadyGrid()

        Dim fldTransCode As New GridViewDecimalColumn("TransCode")
        With fldTransCode
            .FieldName = "fldTransCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldTransCode)

        Dim fldAAIDColumn As New GridViewDecimalColumn("ID")
        With fldAAIDColumn
            .FieldName = "fldAACode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldAAIDColumn)

        Dim fldWBud As New GridViewDecimalColumn("WBUD")
        With fldWBud
            .FieldName = "fldWBudget"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldWBud)

        Dim fldBYColumn As New GridViewComboBoxColumn("YEAR")
        With fldBYColumn
            .FieldName = "Byear"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"2014", _
                                          "2015", _
                                          "2016", _
                                          "2017", _
                                          "2018", _
                                          "2019", _
                                          "2020", _
                                          "2021", _
                                          "2022", _
                                          "2023", _
                                          "2024", _
                                          "2025"}
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldBYColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldPONumColumn As New GridViewTextBoxColumn("PURCHASED ORDER NO")
        With fldPONumColumn
            .FieldName = "fldPONo"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPONumColumn)

        Dim fldPRNumColumn As New GridViewTextBoxColumn("PURCHASED REQUEST NO")
        With fldPRNumColumn
            .FieldName = "fldPRNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPRNumColumn)

        Dim fldMAcquiredColumn As New GridViewDateTimeColumn("MONTH ACQUIRED")
        With fldMAcquiredColumn
            .FieldName = "fldMonthAcquired"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMAcquiredColumn)
        rgvList.Columns("fldMonthAcquired").FormatString = "{0:MMM dd, yyyy}"

        Dim fldSupplierColumn As New GridViewTextBoxColumn("SUPPLIER")
        With fldSupplierColumn
            .FieldName = "fldOrderSupplier"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSupplierColumn)

        Dim fldOrderDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldOrderDescColumn
            .FieldName = "fldOrderDesc"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldOrderDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClassification"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldOrderDepartment"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldAmountJPYColumn As New GridViewTextBoxColumn("ORIGINAL AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "fldAmountJPY"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountJPYColumn)
        rgvList.Columns("fldAmountJPY").FormatString = "{0:N2}"

        Dim fldYENColumn As New GridViewTextBoxColumn("JPY AMOUNT")
        With fldYENColumn
            .FieldName = "YEN"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldYENColumn)
        rgvList.Columns("YEN").FormatString = "{0:N2}"

        Dim fldAmountPHPColumn As New GridViewTextBoxColumn("PHP AMOUNT")
        With fldAmountPHPColumn
            .FieldName = "PHP"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountPHPColumn)
        rgvList.Columns("PHP").FormatString = "{0:N2}"

        Dim fldAmountUSDColumn As New GridViewTextBoxColumn("USD AMOUNT")
        With fldAmountUSDColumn
            .FieldName = "USD"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountUSDColumn)
        rgvList.Columns("USD").FormatString = "{0:N2}"

        Dim fldRemBalColumn As New GridViewTextBoxColumn("REMAINING BUDGET")
        With fldRemBalColumn
            .FieldName = "RemBal"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRemBalColumn)
        rgvList.Columns("RemBal").FormatString = "{0:N2}"

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldOrderRemarks"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRemarksColumn)

        Dim fldOrderByColumn As New GridViewTextBoxColumn("REVISED BY")
        With fldOrderByColumn
            .FieldName = "fldSignature"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvList.Columns.Add(fldOrderByColumn)

        '-----GRID PROPERTIES-----'

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub ReadyItemGrid()

        Dim fldMAAIDColumn As New GridViewDecimalColumn("ID")
        With fldMAAIDColumn
            .FieldName = "fldMAIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldMAAIDColumn)

        Dim fldTransCode As New GridViewDecimalColumn("TransCode")
        With fldTransCode
            .FieldName = "fldTransCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldTransCode)

        Dim fldBudRefNum As New GridViewTextBoxColumn("BUDGET REF. NO.")
        With fldBudRefNum
            .FieldName = "fldBudRefNum"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 140
        End With
        rgvListItem.Columns.Add(fldBudRefNum)

        Dim fldICode As New GridViewTextBoxColumn("ITEM CODE")
        With fldICode
            .FieldName = "fldICode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvListItem.Columns.Add(fldICode)

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDesc
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 180
        End With
        rgvListItem.Columns.Add(fldDesc)

        Dim fldQTY As New GridViewDecimalColumn("QUANTITY")
        With fldQTY
            .FieldName = "fldQTY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
        End With
        rgvListItem.Columns.Add(fldQTY)

        Dim fldUnit As New GridViewDecimalColumn("UNIT")
        With fldUnit
            .FieldName = "fldUnit"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 60
        End With
        rgvListItem.Columns.Add(fldUnit)

        Dim fldCurrencyColumn As New GridViewDecimalColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 60
        End With
        rgvListItem.Columns.Add(fldCurrencyColumn)

        Dim fldUPrice As New GridViewDecimalColumn("UNIT PRICE")
        With fldUPrice
            .FieldName = "fldUPrice"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvListItem.Columns.Add(fldUPrice)
        rgvListItem.Columns("fldUPrice").FormatString = "{0:N2}"

        Dim fldTotalCost As New GridViewDecimalColumn("TOTAL COST")
        With fldTotalCost
            .FieldName = "fldTotalCost"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 140
        End With
        rgvListItem.Columns.Add(fldTotalCost)
        rgvListItem.Columns("fldTotalCost").FormatString = "{0:N2}"

        Dim fldAmountYENColumn As New GridViewTextBoxColumn("YEN AMOUNT")
        With fldAmountYENColumn
            .FieldName = "YEN"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldAmountYENColumn)
        rgvListItem.Columns("YEN").FormatString = "{0:N2}"

        Dim fldAmountPHPColumn As New GridViewTextBoxColumn("PHP AMOUNT")
        With fldAmountPHPColumn
            .FieldName = "PHP"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldAmountPHPColumn)
        rgvListItem.Columns("PHP").FormatString = "{0:N2}"

        Dim fldAmountUSDColumn As New GridViewTextBoxColumn("USD AMOUNT")
        With fldAmountUSDColumn
            .FieldName = "USD"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldAmountUSDColumn)
        rgvListItem.Columns("USD").FormatString = "{0:N2}"

        Dim fldSignature As New GridViewTextBoxColumn("SIGNATURE")
        With fldSignature
            .FieldName = "fldSignature"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 140
        End With
        rgvListItem.Columns.Add(fldSignature)

        With rgvListItem
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            ' .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub rgvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellDoubleClick
        GetData()
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        dtLoadData = Chinita.fetchDBTable("SELECT tr1.fldCurrency,tr1.fldAACode,tr1.fldTransCode, tr1.fldBudRefNum, tr1.fldWBudget, fldTransCode, fldPONo, fldPRNo, " _
                                          & "fldMonthAcquired,year(fldMonthAcquired) as Byear, fldOrderSupplier, " _
                                          & "(if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) as 'Amount' , " _
                                          & "(CASE " _
                                          & "WHEN tr1.fldCurrency = 'USD' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) " _
                                          & "WHEN tr1.fldCurrency = 'PHP' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                          & "WHEN tr1.fldCurrency = 'YEN' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                          & "END) as USD, " _
                                          & "(CASE " _
                                          & "WHEN tr1.fldCurrency = 'PHP' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) " _
                                          & "WHEN tr1.fldCurrency = 'USD' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                          & "WHEN tr1.fldCurrency = 'YEN' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                          & "END) as PHP, " _
                                          & "(CASE " _
                                          & "WHEN tr1.fldCurrency = 'YEN' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) " _
                                          & "WHEN tr1.fldCurrency = 'USD' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                          & "WHEN tr1.fldCurrency = 'PHP' then (if(tr1.fldTransCode is not null,(select if(tr2.fldTotalCost is not null,sum(tr2.fldTotalCost),0) from tblMAI tr2 where tr2.fldTransCode = tr1.fldTransCode and tr2.fldStat = 'OPEN'),tr1.fldYen)) / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                          & "END) as YEN, " _
                                          & "fldOrderDesc, fldClassification, fldOrderDepartment, fldAmountJPY, fldYen, " _
                                          & "fldUOM, fldOrderRemarks, fldSignature, " _
                                          & "(select trqty.fldQTY - " _
                                          & "(((Select (If(tr5.fldQTY Is Not null, sum(tr5.fldQTY), 0)) from tblOrder tr5 " _
                                          & "where tr5.fldOrderStatus = 'OPEN' and tr5.fldBudRefNum = tr1.fldBudRefNum " _
                                          & "and tr5.fldTransCode is null) + " _
                                          & "(select distinct if(tr6.fldQTY is not null,sum(tr6.fldQTY),0) " _
                                          & "from tblMOI tr6 left join tblOrder tr8 on tr6.fldTransCode = tr8.fldTransCode " _
                                          & "where tr8.fldBudRefNum = tr1.fldBudRefNum and tr6.fldStat = 'OPEN' and tr8.fldTransCode is not null" _
                                          & ")) + " _
                                          & "((select (IF(tr4.fldQTY IS NOT NULL,sum(tr4.fldQTY),0)) " _
                                          & "from tblActualAcquisition tr4 left join tblBudget trmain on trmain.fldBudRefNum = tr4.fldBudRefNum " _
                                          & "where trmain.fldBudRefNum = tr1.fldBudRefNum " _
                                          & "and tr4.fldTransCode is null and left(tr4.fldBudRefNum,9) != 'NO BUDGET') + " _
                                          & "(select " _
                                          & "IF(tr9.fldQTY IS NOT NULL,sum(tr9.fldQTY),0) " _
                                          & "from tblMAI tr9 left join tblOrder trqty0 on tr9.fldTransCode = trqty0.fldTransCode " _
                                          & "where trqty0.fldBudRefNum = tr1.fldBudRefNum AND tr9.fldStat = 'OPEN' AND trqty0.fldTransCode is not null))) " _
                                          & "from tblRevision trqty where trqty.fldBudRefNum = tr1.fldBudRefNum and trqty.fldRevNum = (SELECT MAX(`fldRevNum`) " _
                                          & "FROM tblRevision WHERE fldBudRefNum = tr1.fldBudRefNum)) as 'fldQTY'," _
                                          & "((select if(trRev.fldYen is not null,trRev.fldYen,0) - " _
                                          & "(((Select If(tr4.fldYen Is Not null, sum(tr4.fldYen), 0) " _
                                          & "from tblMOI tr4 where tr4.fldBudRefNum = tr1.fldBudRefNum  and tr4.fldStat = 'OPEN') + " _
                                          & "(select (IF(tr2.fldYen IS NOT NULL,sum(tr2.fldYen),0)) " _
                                          & "from tblOrder tr2 where tr2.fldBudRefNum = tr1.fldBudRefNum and tr2.fldOrderStatus = 'OPEN' And tr2.fldTransCode IS NULL" _
                                          & ")) + " _
                                          & "((select " _
                                          & "IF(tr6.fldYen IS NOT NULL,sum(tr6.fldYen),0) " _
                                          & "from tblMAI tr6 where tr6.fldBudRefNum = tr1.fldBudRefNum AND tr6.fldStat = 'OPEN') + (" _
                                          & "Select If(tr5.fldYen Is Not null, sum(tr5.fldYen), 0) " _
                                          & "from tblActualAcquisition tr5 where tr5.fldBudRefNum = tr1.fldBudRefNum and tr5.fldTransCode IS NULL))) " _
                                          & "from tblRevision trRev left join tblBudget tr7 on trRev.fldBudRefNum = tr7.fldBudRefNum " _
                                          & "where trRev.fldRevNum = (SELECT MAX(`fldRevNum`) " _
                                          & "FROM tblRevision " _
                                          & "WHERE fldBudRefNum = tr1.fldBudRefNum) and  trRev.fldStat = 'OPEN' and trRev.fldBudRefNum = tr1.fldBudRefNum)) as RemBal " _
                                          & "FROM tblActualAcquisition tr1")


    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub frmAA_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
        EnabledAll()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlBRNum.SelectedIndexChanged

        Try
            RemBudAA()
        Catch ex As Exception

        End Try

        ddlBRNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddlBRNum.AutoCompleteDataSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub ddlWBud_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlWBud.SelectedIndexChanged

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

    Private Sub btnAddAA_Click(sender As Object, e As EventArgs) Handles btnAddAA.Click

        If String.IsNullOrEmpty(txtPONum.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Purchased Order Number", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtPRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Purchased Request Number ", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtSupplier.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Supplier", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Department Selected ", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlClass.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Classification Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlDept.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Department Selected ", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf mebJPYAmount.Value = 0.0 Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else

            If Tomboy.AddNewAAWO(ddlWBud.Text, txtPONum.Text, txtPRNum.Text, _
                               dtpMAcquired.Value, txtSupplier.Text, txtDesc.Text, ddlClass.Text, _
                               ddlDept.Text, mebQTY.Text, ddlUOM.Text, mebJPYAmount.Text, txtRemarks.Text, txtSignature.Text) Then
                RadMessageBox.SetThemeName("Windows8Theme1")
                RadMessageBox.Show("Acquisition Added!", "Notification", MessageBoxButtons.OK)
                Clear()
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    '----- KEYPRESS OF DROP DOWN LIST -----'

    Private Sub ddlBRNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlBRNum.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlWBud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlWBud.KeyPress
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

            'Dim mb As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMBudgeted").Value))
            'Dim fb As String = Convert.ToString(String.Format("{0:M/d/yyyy}", rgvList.ChildRows(x).Cells("fldMForecasted").Value))

            dt.Rows.Add(yr, brno, oa, pha, usa, cls, dpt, pr, po, desc, qty, uom, sup, ma, rmk, sig)
        Next

        frmReport.Show()
        frmReport.ReportViewer1.Refresh()

    End Sub

    Private Sub bwLoadItem_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadItem.DoWork
        dtLoadData2 = Chinita.fetchDBTable("SELECT tr1.fldMAIID,tr1.fldTransCode,tr1.fldBudRefNum,tr1.fldICode,tr1.fldDesc,tr1.fldCurrency,year(tr1.fldMonthDelivery) as Byear " _
                                           & ",(CASE  " _
                                           & "WHEN tr1.fldCurrency = 'USD' then tr1.fldTotalCost " _
                                           & "WHEN tr1.fldCurrency = 'PHP' then tr1.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                           & "WHEN tr1.fldCurrency = 'YEN' then tr1.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                           & "END) as USD, " _
                                           & "(CASE " _
                                           & "WHEN tr1.fldCurrency = 'PHP' then tr1.fldTotalCost " _
                                           & "WHEN tr1.fldCurrency = 'USD' then tr1.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'PHP-USD') " _
                                           & "WHEN tr1.fldCurrency = 'YEN' then tr1.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                           & "END) as PHP, " _
                                           & "(CASE " _
                                           & "WHEN tr1.fldCurrency = 'YEN' then tr1.fldTotalCost " _
                                           & "WHEN tr1.fldCurrency = 'USD' then tr1.fldTotalCost * (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'USD-YEN') " _
                                           & "WHEN tr1.fldCurrency = 'PHP' then tr1.fldTotalCost / (select fldAmount from tblConversion where Year(fldDate) = Byear and fldcurrency = 'YEN-PHP') " _
                                           & "END) as YEN, " _
                                           & "tr1.fldQTY, tr1.fldUnit, tr1.fldUPrice, tr1.fldTotalCost, tr1.fldStat, tr1.fldSignature " _
                                           & "from tblMAI tr1 where tr1.fldTransCode = '" & rgvList.CurrentRow.Cells("fldTransCode").Value & "'")

    End Sub

    Private Sub bwLoadItem_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadItem.RunWorkerCompleted
        rgvListItem.DataSource = dtLoadData2
    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        Clear()

        bwLoadItem.RunWorkerAsync()
    End Sub

End Class

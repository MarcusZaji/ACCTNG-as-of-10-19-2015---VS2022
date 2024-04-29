Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data

Module Pink

    Public Sapsap As String = "Data Source=feap-sap;Initial Catalog=Furukawa_Live2022;User ID=sldadmin;Password=SQL@dm1n; Connection Timeout=500;"
    Public dtItemCode As DataTable
    Public dtRate As DataTable
    Public Sub ClassificationBudget()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass"

        ddlvalues = myCmd.ExecuteReader()
        frmBudget.ddlClass.DataSource = ddlvalues
        frmBudget.ddlClass.DisplayMember = "fldClassDesc"

        myCmd.Connection.Close()

    End Sub
    Public Sub ClassificationCreatePR()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass"

        ddlvalues = myCmd.ExecuteReader()
        frmCreatePR.ddlClass.DataSource = ddlvalues
        frmCreatePR.ddlClass.DisplayMember = "fldClassDesc"

        myCmd.Connection.Close()

    End Sub

    Public Sub ClassificationOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass"
        ddlvalues = myCmd.ExecuteReader()

        frmOrder.ddlClass.DataSource = ddlvalues
        frmOrder.ddlClass.DisplayMember = "fldClassDesc"
        myCmd.Connection.Close()

    End Sub

    Public Sub ClassificationAA()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass"

        ddlvalues = myCmd.ExecuteReader()
        frmAA.ddlClass.DataSource = ddlvalues
        frmAA.ddlClass.DisplayMember = "fldClassDesc"
        myCmd.Connection.Close()

    End Sub

    Public Sub DepartmentAA()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        frmAA.ddlDept.DataSource = ddlvalues
        frmAA.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub DepartmentBudget()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()

        If frmMain.lblAccesslvl.Text = "SUPERADMIN" Then
            myCmd.Connection = conn
            myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode != 'ALL'"

            ddlvalues = myCmd.ExecuteReader()
            frmBudget.ddlDept.DataSource = ddlvalues
            frmBudget.ddlDept.DisplayMember = "fldDeptCode"
            'frmBudget.ddlDept.Text = ""

            myCmd.Connection.Close()

        Else
            myCmd.Connection = conn
            myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode = '" & frmMain.lblDept.Text & "'  AND fldDeptCode != 'ALL'"

            ddlvalues = myCmd.ExecuteReader()
            frmBudget.ddlDept.DataSource = ddlvalues
            frmBudget.ddlDept.DisplayMember = "fldDeptCode"
            'frmBudget.ddlDept.Text = ""

            myCmd.Connection.Close()
        End If


    End Sub

    Public Sub DepartmentOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment WHERE fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        frmOrder.ddlDept.DataSource = ddlvalues
        frmOrder.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub ProcessBudget()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldProcessCode from tblProcess"

        ddlvalues = myCmd.ExecuteReader()
        frmBudget.ddlProcess.DataSource = ddlvalues
        frmBudget.ddlProcess.DisplayMember = "fldProcessCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub ProcessOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldProcessCode from tblProcess"

        ddlvalues = myCmd.ExecuteReader()
        frmOrder.ddlProcess.DataSource = ddlvalues
        frmOrder.ddlProcess.DisplayMember = "fldProcessCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub DepartmentUser()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment WHERE fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        frmUser.ddlDept.DataSource = ddlvalues
        frmUser.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()
    End Sub


    Public Sub DepartmentUserInv()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment WHERE fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        FrmInvestment.ddlDept.DataSource = ddlvalues
        FrmInvestment.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()
    End Sub

    Public Sub ClassMultiOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass WHERE fldClassDesc != 'OTHERS' ORDER BY fldClassDesc Asc"

        ddlvalues = myCmd.ExecuteReader()
        frmMultiOrder.ddlClass.DataSource = ddlvalues
        frmMultiOrder.ddlClass.DisplayMember = "fldClassDesc"

        myCmd.Connection.Close()

    End Sub

    Public Sub DepartmentMultiOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment WHERE fldDeptCode != 'ALL' ORDER BY fldDeptCode Asc "

        ddlvalues = myCmd.ExecuteReader()
        frmMultiOrder.ddlDept.DataSource = ddlvalues
        frmMultiOrder.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub ProcessMultiOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldProcessCode from tblProcess ORDER BY fldProcessCode Asc "

        ddlvalues = myCmd.ExecuteReader()
        frmMultiOrder.ddlProcess.DataSource = ddlvalues
        frmMultiOrder.ddlProcess.DisplayMember = "fldProcessCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub IMCategoryMultiOrder()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "select fldCatDesc from tblItemCategory"

        ddlvalues = myCmd.ExecuteReader()
        'frmMultiOrder.ddlCat.DataSource = ddlvalues
        'frmMultiOrder.ddlCat.DisplayMember = "fldCatDesc"

        myCmd.Connection.Close()

    End Sub

    Public Sub DepartmentReport()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment WHERE fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        frmGenUpd8dBud.ddlDept.DataSource = ddlvalues
        frmGenUpd8dBud.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()
    End Sub

    Public Sub ClassReport()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass"

        ddlvalues = myCmd.ExecuteReader()
        frmGenUpd8dBud.ddlClass.DataSource = ddlvalues
        frmGenUpd8dBud.ddlClass.DisplayMember = "fldClassDesc"

        myCmd.Connection.Close()

    End Sub

    Public Sub ClassRepUpdated()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassDesc from tblClass ORDER BY fldClassDesc"

        ddlvalues = myCmd.ExecuteReader()
        frmGenReport.ddlClass.DataSource = ddlvalues
        frmGenReport.ddlClass.DisplayMember = "fldClassDesc"

        myCmd.Connection.Close()

    End Sub

    Public Sub DeptRepUpdated()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment ORDER BY fldDeptCode Asc"

        ddlvalues = myCmd.ExecuteReader()
        frmGenReport.ddlDept.DataSource = ddlvalues
        frmGenReport.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub DeptGenRepBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn

        If frmMain.lblAccesslvl.Text = "SUPERADMIN" Or frmMain.lblAccesslvl.Text = "ADMINISTRATOR" Then
            myCmd.CommandText = "select fldDeptCode from tblDepartment"

            ddlvalues = myCmd.ExecuteReader()
            frmGenReportBC.ddlDept.DataSource = ddlvalues
            frmGenReportBC.ddlDept.DisplayMember = "fldDeptCode"
            frmGenReportBC.ddlDept.ValueMember = "fldDeptCode"
        Else
            myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode = '" & frmMain.lblDept.Text & "'"

            ddlvalues = myCmd.ExecuteReader()
            frmGenReportBC.ddlDept.DataSource = ddlvalues
            frmGenReportBC.ddlDept.DisplayMember = "fldDeptCode"
            frmGenReportBC.ddlDept.ValueMember = "fldDeptCode"
        End If

        myCmd.Connection.Close()

    End Sub

    Public Sub ClassGenRepBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "select fldClassCode, fldClassDesc from tblClass ORDER BY fldClassDesc"

        ddlvalues = myCmd.ExecuteReader()
        frmGenReportBC.ddlClass.DataSource = ddlvalues
        frmGenReportBC.ddlClass.DisplayMember = "fldClassDesc"
        frmGenReportBC.ddlClass.ValueMember = "fldClassCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub DeptRepMonth()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment WHERE fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        frmGenReport.ddlDept.DataSource = ddlvalues
        frmGenReport.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()
    End Sub

    Public Sub RepPO()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select 'ALL' AS fldPoNo from tblOrder union select DocNum AS fldPoNo from OPOR where DocNum != '110004780'"

        ddlvalues = myCmd.ExecuteReader()
        frmGenReport.ddlPO.DataSource = ddlvalues
        frmGenReport.ddlPO.DisplayMember = "fldPONo"

        myCmd.Connection.Close()

    End Sub

    Public Sub GetCurSap_POC()
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myData3 As New DataTable
        Dim myData4 As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.Currency, T0.CardCode, T0.LicTradNum, " _
                                & "CASE when T0.CntctPrsn IS null then '' else T0.CntctPrsn end as 'CntctPrsn' " _
                                & "FROM OCRD T0 WHERE T0.[CardType] ='S' AND T0.[CardCode] ='" & frmPOChange.ddlVenCode.Text & "' " _
                                & " ORDER BY  T0.[Balance] DESC "

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)
            myAdapter.Fill(myData2)
            myAdapter.Fill(myData3)
            myAdapter.Fill(myData4)

            frmPOChange.txtCurrency.Text = myData.Rows(0).Item("Currency")
            frmPOChange.txtVenCode.Text = myData2.Rows(0).Item("CardCode")
            frmPOChange.txtTINNo.Text = myData3.Rows(0).Item("LicTradNum").ToString
            frmPOChange.txtCntctPrsn.Text = myData4.Rows(0).Item("CntctPrsn").ToString

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetSupSap_POC()

        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.[CardName], T0.Currency " _
                                 & "FROM OCRD T0 WHERE T0.[CardType] ='S'" _
                                 & " ORDER BY T0.[CardName] ASC "

            ddlvalues = myCmd.ExecuteReader
            frmPOChange.ddlSupSap.DataSource = ddlvalues
            frmPOChange.ddlSupSap.DisplayMember = "CardName"

            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetSupSap()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.[CardName], T0.Currency " _
                                 & "FROM OCRD T0 WHERE T0.[CardType] ='S'" _
                                 & " ORDER BY T0.[CardName] ASC "

            ddlvalues = myCmd.ExecuteReader
            FrmCPO.ddlSupSap.DataSource = ddlvalues
            FrmCPO.ddlSupSap.DisplayMember = "CardName"

            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GeSapCardCode()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.[CardName], T0.CardCode " _
                                 & "FROM OCRD T0 WHERE T0.[CardType] ='S' and T0.CardName = '" & Replace(FrmCPO.ddlSupSap.Text, "'", "''") & "'" _
                                 & " ORDER BY T0.[CardName] ASC "

            ddlvalues = myCmd.ExecuteReader
            FrmCPO.ddlVenCode.DataSource = ddlvalues
            FrmCPO.ddlVenCode.DisplayMember = "CardCode"
            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetCurSap()
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.Currency, T0.CardCode " _
                                & "FROM OCRD T0 WHERE T0.[CardType] ='S' AND T0.[CardCode] ='" & FrmCPO.ddlVenCode.Text & "' " _
                                & " ORDER BY  T0.[Balance] DESC "

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)
            myAdapter.Fill(myData2)


            FrmCPO.txtCurrency.Text = myData.Rows(0).Item("Currency")
            FrmCPO.txtVenCode.Text = myData2.Rows(0).Item("CardCode")

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetRateSap()
        Try
            If FrmCPO.txtCurrency.Text = "JPY" Or String.IsNullOrEmpty(FrmCPO.txtCurrency.Text) Then
                FrmCPO.mebXRate.Text = 0.0

            Else
                Try
                    Dim conn As New SqlClient.SqlConnection(Sapsap)
                    Dim myCmd As New SqlClient.SqlCommand
                    Dim myData As New DataTable
                    Dim myData2 As New DataTable
                    Dim myAdapter As New SqlClient.SqlDataAdapter

                    myCmd.Connection = conn
                    myCmd.CommandText = "select Currency, Rate from ORTT where RateDate = '" & FrmCPO.dtpMOrder.Value & "' " _
                        & "and Currency = '" & FrmCPO.txtCurrency.Text & "'"

                    myAdapter.SelectCommand = myCmd
                    myAdapter.Fill(myData)

                    FrmCPO.mebXRate.Text = myData.Rows(0).Item("Rate")
                Catch ex As Exception
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("NO CONVERTION RATE! Form will close automatically," & Environment.NewLine & _
                                       "Please Contact Edgar Comia @ Local 102", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                    FrmCPO.Close()
                End Try

            End If

        Catch ex As Exception

        End Try
            
    End Sub

    Public Sub GetRateSapFPO()
        Try
            If FrmFPO.txtCurrency.Text = "JPY" Or String.IsNullOrEmpty(FrmFPO.txtCurrency.Text) Then
                FrmFPO.mebXRate.Text = 0.0

            Else
                Try
                    Dim conn As New SqlClient.SqlConnection(Sapsap)
                    Dim myCmd As New SqlClient.SqlCommand
                    Dim myData As New DataTable
                    Dim myData2 As New DataTable
                    Dim myAdapter As New SqlClient.SqlDataAdapter

                    myCmd.Connection = conn
                    myCmd.CommandText = "select Currency, Rate from ORTT where RateDate = '" & FrmFPO.dtpMOrder.Value & "' " _
                        & "and Currency = '" & FrmFPO.txtCurrency.Text & "'"

                    myAdapter.SelectCommand = myCmd
                    myAdapter.Fill(myData)

                    FrmFPO.mebXRate.Text = myData.Rows(0).Item("Rate")
                Catch ex As Exception
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("NO CONVERTION RATE! Form will close automatically," & Environment.NewLine & _
                                       "Please Contact Edgar Comia @ Local 102", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                    FrmFPO.Close()
                End Try

            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetSupSapFPO()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.[CardName], T0.Currency " _
                                 & "FROM OCRD T0 WHERE T0.[CardType] ='S'" _
                                 & " ORDER BY T0.[CardName] ASC "

            ddlvalues = myCmd.ExecuteReader
            FrmFPO.ddlSupSap.DataSource = ddlvalues
            FrmFPO.ddlSupSap.DisplayMember = "CardName"

            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetCurSapFPO()
        Dim myData As New DataTable
        Dim myData2 As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.Currency, T0.CardCode " _
                                & "FROM OCRD T0 WHERE T0.[CardType] ='S' AND T0.[CardCode] ='" & FrmFPO.ddlVenCode.Text & "' " _
                                & " ORDER BY  T0.[Balance] DESC "

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)
            myAdapter.Fill(myData2)


            FrmFPO.txtCurrency.Text = myData.Rows(0).Item("Currency")
            FrmFPO.txtVenCode.Text = myData2.Rows(0).Item("CardCode")
        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetSapCardCodeFPO()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.[CardName], T0.CardCode " _
                                  & "FROM OCRD T0 WHERE T0.[CardType] ='S' and T0.CardName = '" & Replace(FrmFPO.ddlSupSap.Text, "'", "''") & "'" _
                                  & " ORDER BY T0.[CardName] ASC "

            ddlvalues = myCmd.ExecuteReader
            FrmFPO.ddlVenCode.DataSource = ddlvalues
            FrmFPO.ddlVenCode.DisplayMember = "CardCode"
            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetSapCardCodePOChange()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT T0.[CardName], T0.CardCode " _
                                  & "FROM OCRD T0 WHERE T0.[CardType] ='S' and T0.CardName = '" & Replace(frmPOChange.ddlSupSap.Text, "'", "''") & "'" _
                                  & " ORDER BY T0.[CardName] ASC "

            ddlvalues = myCmd.ExecuteReader
            frmPOChange.ddlVenCode.DataSource = ddlvalues
            frmPOChange.ddlVenCode.DisplayMember = "CardCode"
            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetItemCodeSap()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "SELECT " _
                & "(case ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
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
                & "End) AS 'Category', " _
                & "ItemCode, ItemName, BuyUnitMsr FROM OITM " _
                & "where " _
                & "(validTo IS NULL OR frozenFrom IS NULL) " _
                & "and ItmsGrpCod not in ('100','101','102')"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            frmMultiOrder.rgvItemSelect.DataSource = myData

        Catch ex As Exception

        End Try

    End Sub
    Public Sub GetItemCodeSapForPR()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "SELECT " _
                & "(case ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
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
                & "End) AS 'Category', " _
                & "ItemCode, ItemName, BuyUnitMsr FROM OITM " _
                & "where " _
                & "(validTo IS NULL OR frozenFrom IS NULL) " _
                & "and ItmsGrpCod not in ('100','101','102')"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            frmCreatePR.ddlSelectItem.DataSource = myData
            frmCreatePR.ddlSelectItem.ValueMember = "ItemCode"
            frmCreatePR.ddlSelectItem.DisplayMember = "ItemCode"
            frmCreatePR.ddlSelectItem.MultiColumnComboBoxElement.DropDownWidth = 450
        Catch ex As Exception

        End Try

    End Sub
    Public Sub GetItemCodeSapFordt()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "SELECT " _
                & "(case ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
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
                & "End) AS 'Category', " _
                & "ItemCode, ItemName, BuyUnitMsr FROM OITM " _
                & "where " _
                & "(validTo IS NULL OR frozenFrom IS NULL) " _
                & "and ItmsGrpCod not in ('100','101','102')"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            dtItemCode = myData
        Catch ex As Exception

        End Try

    End Sub
    Public Sub GetRateAll()

        Dim conn As New SqlClient.SqlConnection(Sapsap)
                Dim myCmd As New SqlClient.SqlCommand
                Dim myData As New DataTable
                Dim myData2 As New DataTable
                Dim myAdapter As New SqlClient.SqlDataAdapter

                myCmd.Connection = conn
        myCmd.CommandText = "select Currency, Rate  from ORTT where CONVERT(DATE,RateDate) = CONVERT(DATE,GETDATE());"

        myAdapter.SelectCommand = myCmd
                myAdapter.Fill(myData)

        dtRate = myData

    End Sub

    Public Sub GetItemCodeSapForPRItemName()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "SELECT " _
                & "(case ItmsGrpCod WHEN '100' THEN 'Finished Goods' " _
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
                & "End) AS 'Category', " _
                & "ItemCode, ItemName, BuyUnitMsr FROM OITM " _
                & "where " _
                & "(validTo IS NULL OR frozenFrom IS NULL) " _
                & "and ItmsGrpCod not in ('100','101','102')"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            frmCreatePR.ddlItemCodeDesc.DataSource = myData
            frmCreatePR.ddlItemCodeDesc.ValueMember = "ItemName"
            frmCreatePR.ddlItemCodeDesc.DisplayMember = "ItemName"
            frmCreatePR.ddlItemCodeDesc.MultiColumnComboBoxElement.DropDownWidth = 450
        Catch ex As Exception

        End Try

    End Sub
    Public Sub GetSupplier()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()

            'myCmd.Connection = conn
            'myCmd.CommandText = "SELECT " _
            '    & " T0.CardCode, T0.CardName, T0.Phone1,T0.CardType, " _
            '    & "T1.StreetNo + ' '+ T1.City as Street, T1.Block, T1.ZipCode,T1.AdresType,T2.Name  as ContactPerson " _
            '    & "FROM OCRD T0 INNER JOIN CRD1 T1 ON T0.CardCode = T1.CardCode " _
            '    & "inner join OCPR T2 on T0.CardCode = T2.CardCode " _
            '    & "where T0.CardType = 'S' AND T0.validFor = 'Y'"

            myCmd.Connection = conn
            myCmd.CommandText = "SELECT " _
                & " T0.CardCode, T0.CardName, T0.Phone1,T0.CardType, " _
                & "T1.StreetNo + ' '+ T1.City as Street, T1.Block, T1.ZipCode,T1.AdresType,T2.Name  as ContactPerson " _
                & "FROM OCRD T0 INNER JOIN CRD1 T1 ON T0.CardCode = T1.CardCode " _
                & "inner join OCPR T2 on T0.CardCode = T2.CardCode " _
                & "where T0.CardType = 'S'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            FrmRFQPur.ddlContactPerson.DataSource = myData
            FrmRFQPur.ddlContactPerson.ValueMember = "CardName"
            FrmRFQPur.ddlContactPerson.DisplayMember = "CardName"
            FrmRFQPur.ddlContactPerson.MultiColumnComboBoxElement.DropDownWidth = 450

        Catch ex As Exception

        End Try
    End Sub

    Public Sub GetActualByDate()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter
        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()

            myCmd.Connection = conn
            myCmd.CommandText = "SP_SelectActualByDate()"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            FrmRFQPur.ddlContactPerson.DataSource = myData
            FrmRFQPur.ddlContactPerson.ValueMember = "CardName"
            FrmRFQPur.ddlContactPerson.DisplayMember = "CardName"
            FrmRFQPur.ddlContactPerson.MultiColumnComboBoxElement.DropDownWidth = 450

        Catch ex As Exception

        End Try
    End Sub

    Public Sub keyFilter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub



End Module
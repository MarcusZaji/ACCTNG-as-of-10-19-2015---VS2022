Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data

Module Jamela

    Public BC_ConnString As String = "Server = 192.168.191.252; Database = dbBCS; Uid = feap; Pwd = 45|iF$; Convert Zero Datetime=True"

    Public BC_Conversion As Integer
    Public EditPicker As Integer

    Public Sub DepartmentBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()

        If frmMain.lblAccesslvl.Text = "SUPERADMIN" Then
            myCmd.Connection = conn
            myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode != 'ALL'"

            ddlvalues = myCmd.ExecuteReader()
            frmBudgetCreation.ddlDept.DataSource = ddlvalues
            frmBudgetCreation.ddlDept.DisplayMember = "fldDeptCode"

            myCmd.Connection.Close()

        Else
            myCmd.Connection = conn
            myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode = '" & frmMain.lblDept.Text & "'  AND fldDeptCode != 'ALL'"

            ddlvalues = myCmd.ExecuteReader()
            frmBudgetCreation.ddlDept.DataSource = ddlvalues
            frmBudgetCreation.ddlDept.DisplayMember = "fldDeptCode"

            myCmd.Connection.Close()
        End If

    End Sub

    Public Sub DepartmentListPO()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()

        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment where fldDeptCode != 'ALL'"

        ddlvalues = myCmd.ExecuteReader()
        FrmViewPO.ddlDept.DataSource = ddlvalues
        FrmViewPO.ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub ClassificationBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassCode, fldClassDesc from tblClass WHERE fldClassDesc != 'ALL' ORDER BY fldClassDesc"

        ddlvalues = myCmd.ExecuteReader()
        frmBudgetCreation.ddlClass.DataSource = ddlvalues
        frmBudgetCreation.ddlClass.DisplayMember = "fldClassDesc"
        frmBudgetCreation.ddlClass.ValueMember = "fldClassCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub SubClassBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldSCCode, fldSCDesc from tblClassPPE WHERE fldSCCode NOT IN('ALL','') ORDER BY fldSCDesc"

        ddlvalues = myCmd.ExecuteReader()
        frmBudgetCreation.ddlSubClass.DataSource = ddlvalues
        frmBudgetCreation.ddlSubClass.DisplayMember = "fldSCDesc"
        frmBudgetCreation.ddlSubClass.ValueMember = "fldSCCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub ProcessBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldProcessCode from tblProcess"

        ddlvalues = myCmd.ExecuteReader()
        frmBudgetCreation.ddlProcess.DataSource = ddlvalues
        frmBudgetCreation.ddlProcess.DisplayMember = "fldProcessCode"

        myCmd.Connection.Close()

    End Sub

    Public Sub ddlDataUOMBC()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim ddlvalues As SqlDataReader

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd.CommandText = "select distinct T0.BuyUnitMsr from OITM T0 where T0.BuyUnitMsr is not null ORDER BY BuyUnitMsr"

            ddlvalues = myCmd.ExecuteReader
            frmBudgetCreation.ddlUOM.DataSource = ddlvalues
            frmBudgetCreation.ddlUOM.DisplayMember = "BuyUnitMsr"

            myCmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub ddlYearBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select distinct YEAR(fldDate) as fldyear from tblConversion order by fldDate DESC"

        ddlvalues = myCmd.ExecuteReader()
        frmBudgetCreation.ddlYear.DataSource = ddlvalues
        frmBudgetCreation.ddlYear.DisplayMember = "fldyear"

        myCmd.Connection.Close()

    End Sub

    Public Sub ddlYearFBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select distinct YEAR(fldDate) as fldyear from tblConversion order by fldDate DESC"

        ddlvalues = myCmd.ExecuteReader()
        frmFinalBudgetCreated.ddlYear.DataSource = ddlvalues
        frmFinalBudgetCreated.ddlYear.DisplayMember = "fldyear"

        myCmd.Connection.Close()

    End Sub

    Public Sub ddlYearBCGenReport()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select distinct YEAR(fldDate) as fldyear from tblConversion union select '2020' as fldyear ORDER BY fldyear DESC"

        ddlvalues = myCmd.ExecuteReader()
        frmGenReportBC.ddlYear.DataSource = ddlvalues
        frmGenReportBC.ddlYear.DisplayMember = "fldyear"

        myCmd.Connection.Close()

    End Sub

    Public Sub ClassificationMatrixBC()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldClassCode, fldClassDesc from tblClass WHERE fldClassDesc != 'ALL' ORDER BY fldClassDesc"

        ddlvalues = myCmd.ExecuteReader()
        frmMatrixExpenseTrans.ddlClass.DataSource = ddlvalues
        frmMatrixExpenseTrans.ddlClass.DisplayMember = "fldClassDesc"
        frmMatrixExpenseTrans.ddlClass.ValueMember = "fldClassCode"

        myCmd.Connection.Close()

    End Sub

End Module

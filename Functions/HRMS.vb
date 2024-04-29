Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Text
Imports System.ComponentModel
Module HRMS

    'User Setting------------------------------------------

    Public HRMSConnect As String = My.Settings.dbHRMS

    Public Sub getEmployeeRec()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(HRMSConnect)

        myCmd.Connection = conn
        myCmd.CommandText = "call SP_GetEmpByID('" & Left$(MyGlobal.EmpNo, 7) & "')"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)
        Try
            globalVariables.EmpName = myData.Rows(0).Item("myname")
            globalVariables.Section = myData.Rows(0).Item("fldEmpSection")
            globalVariables.Dept = myData.Rows(0).Item("fldEmpDepartment")
            globalVariables.EmpGroup = myData.Rows(0).Item("fldEmpGroup")

        Catch ex As Exception

        End Try

    End Sub

    'End User Setting --------------------------------------
End Module

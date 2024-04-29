Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Text
Imports System.ComponentModel

Public Class Chinita

    Shared Function isOpenForm(ByVal frm As Form) As Boolean

        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

    Shared Function fetchDbTableSAPSupp(ByVal mySQLcommand As String) As DataTable
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.CommandText = mySQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
        conn = Nothing

        Return myData
    End Function

    Shared Function fetchDbTableSAP(ByVal mySQLcommand As String) As DataTable
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.CommandText = mySQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
        conn = Nothing

        Return myData
    End Function

    Shared Function fetchDbTableSAPvsBAP(ByVal mySQLcommand As String) As DataTable
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        Try
            conn.Open()
            myCmd.CommandText = mySQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
        conn = Nothing

        Return myData
    End Function

    Shared Function fetchDBTable(ByVal mySQLCommand As String) As DataTable
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.CommandText = mySQLCommand
            myCmd.Connection = conn
            myCmd.CommandTimeout = 500
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            conn.Close()
        Catch ex As SqlClient.SqlException
            RadMessageBox.Show(ex.Message)
        End Try

        conn = Nothing

        Return myData
    End Function

    Shared Function fetchMySqlRow(ByVal SQLcommand As String) As DataRow
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()
        myCmd.CommandText = SQLcommand
        myCmd.Connection = conn

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        If myData.Rows.Count > 0 Then
            fetchMySqlRow = myData.Rows(0)
        Else
            fetchMySqlRow = Nothing
        End If

        conn.Close()
        conn = Nothing

    End Function

    Shared Function checkIfRecordExist(ByVal SQLcommand As String) As Boolean
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()
        myCmd.CommandText = SQLcommand
        myCmd.Connection = conn

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        If myData.Rows.Count > 0 Then
            checkIfRecordExist = True
        Else
            checkIfRecordExist = False
        End If

        conn.Close()
        conn = Nothing

        Return checkIfRecordExist

    End Function

    '---- BUDGET CREATION ----' 

    Shared Function fetchDBTable_BC(ByVal mySQLCommand As String) As DataTable
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Try
            conn.Open()
            myCmd.CommandText = mySQLCommand
            myCmd.Connection = conn
            myCmd.CommandTimeout = 500
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            conn.Close()
        Catch ex As SqlClient.SqlException
            RadMessageBox.Show(ex.Message)
        End Try

        conn = Nothing

        Return myData

    End Function

    Shared Function fetchMySqlRow_BC(ByVal SQLcommand As String) As DataRow
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.CommandText = SQLcommand
        myCmd.Connection = conn

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        If myData.Rows.Count > 0 Then
            fetchMySqlRow_BC = myData.Rows(0)
        Else
            fetchMySqlRow_BC = Nothing
        End If

        conn.Close()
        conn = Nothing

    End Function

    '------------------------------------------'

    Shared Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""
        Dim b As Byte

        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    '---------------------------Function for upload BCS -------------------------------------------------

    Shared Function fetchMySqlRowDataTable(ByVal SQLcommand As String) As DataTable
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.CommandText = SQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)


        Catch ex As System.Data.SqlClient.SqlException
            RadMessageBox.Show(ex.Message & "(Function Error)", "BAP", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        conn.Close()
        conn = Nothing

        Return myData
    End Function
    '----------------------------------------------------------------------------------------------------

End Class

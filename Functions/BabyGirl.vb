Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Text

'-------------------------------------------------'
'------- ADD & DELETE MODULE FOR FRMADDETC -------'
'-------------------------------------------------'

Public Class BabyGirl

    Shared Function AddClass(ByVal CCode As String, _
                            ByVal CDesc As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblClass (fldClassCode,fldClassDesc) " _
                & "VALUES (@fldClassCode,@fldClassDesc)"

            With myCmd.Parameters
                .AddWithValue("@fldClassCode", CCode)
                .AddWithValue("@fldClassDesc", CDesc)
            End With
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function DeleteClass(ByVal ID As Integer) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "DELETE FROM tblClass WHERE fldCCode=@fldCCode"
            myCmd.Parameters.AddWithValue("@fldCCode", ID)
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function


    Shared Function AddDept(ByVal DeptCode As String, _
                            ByVal DeptDesc As String, _
                            ByVal DeptAC As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblDepartment (fldDeptCode, fldDeptDesc, fldActivityCode) " _
                & "VALUES (@fldDeptCode, @fldDeptDesc, @fldActivityCode)"

            With myCmd.Parameters
                .AddWithValue("@fldDeptCode", DeptCode)
                .AddWithValue("@fldDeptDesc", DeptDesc)
                .AddWithValue("@fldActivityCode", DeptAC)
            End With
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function DeleteDept(ByVal ID As Integer) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "DELETE FROM tblDepartment WHERE fldDeptID=@fldDeptID"
            myCmd.Parameters.AddWithValue("@fldDeptID", ID)
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function AddProcess(ByVal ProcessCode As String, _
                            ByVal ProcessDesc As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblProcess (fldProcessCode,fldProcessDesc) " _
                & "VALUES (@fldProcessCode,@fldProcessDesc)"

            With myCmd.Parameters
                .AddWithValue("@fldProcessCode", ProcessCode)
                .AddWithValue("@fldProcessDesc", ProcessDesc)
            End With
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function DeleteProcess(ByVal ID As Integer) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "DELETE FROM tblProcess WHERE fldPCode=@fldPCode"
            myCmd.Parameters.AddWithValue("@fldPCode", ID)
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function AddSubClass(ByVal SCCode As String, _
                                ByVal SCDesc As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblClassPPE(fldSCCode, fldSCDesc) " _
                & "VALUES (@fldSCCode, @fldSCDesc)"

            With myCmd.Parameters
                .AddWithValue("@fldSCCode", SCCode)
                .AddWithValue("@fldSCDesc", SCDesc)
            End With
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function DeleteSubClass(ByVal ID As Integer) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "DELETE FROM tblClassPPE WHERE fldSCID=@fldSCID"
            myCmd.Parameters.AddWithValue("@fldSCID", ID)
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

End Class

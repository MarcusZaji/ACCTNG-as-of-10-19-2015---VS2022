Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmReportInvestment
    Private dtLoadData As DataTable
    Private Sub FrmReportInvestment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbInvestment_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbInvestment.ToggleStateChanged
        'reporttype = 23
        reporttype = 1025
        If rbInvestment.IsChecked = True Then
            ddlDept.Enabled = False
            ddlInvestment.Enabled = False
            cbAll.Enabled = False
        Else
            ddlDept.Enabled = True
            ddlInvestment.Enabled = True
            cbAll.Enabled = True
        End If
    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Try
            globalVariables.Department = ddlDept.Text
            globalVariables.InvstmentNo = ddlInvestment.Text
            FrmReportInv.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub
    Private Sub GeTBudgetRef()
        Try
            dtLoadData = Chinita.fetchDBTable("select fldinvestmentNo from tblInvestment;")
            ddlInvestment.DataSource = dtLoadData
            ddlInvestment.DisplayMember = "fldinvestmentNo"
            ddlInvestment.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    Public Sub DepartmentUserInv()
        Dim conn As New MySqlConnection(ConnString)
        Dim myCmd As New MySqlCommand
        Dim ddlvalues As MySqlDataReader

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "select fldDeptCode from tblDepartment "

        ddlvalues = myCmd.ExecuteReader()
        ddlDept.DataSource = ddlvalues
        ddlDept.DisplayMember = "fldDeptCode"

        myCmd.Connection.Close()
    End Sub
    Private Sub FrmReportInvestment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GeTBudgetRef()
        DepartmentUserInv()
    End Sub


    Private Sub cbAll_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbAll.ToggleStateChanged
        If cbAll.Checked = True Then
            ddlInvestment.Text = "ALL"
            ddlInvestment.Enabled = False
        Else
            ddlInvestment.Text = ""
            ddlInvestment.Enabled = True
        End If
    End Sub

    Private Sub RadRadioButton2_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadRadioButton2.ToggleStateChanged
        reporttype = 1027
    End Sub

    Private Sub rptInvPO_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rptPerPO.ToggleStateChanged
         reporttype = 1028
    End Sub

    Private Sub rptPerInv_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rptPerInv.ToggleStateChanged
        reporttype = 1026
    End Sub

    Private Sub rptPerPODetail_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rptPerPODetail.ToggleStateChanged
        reporttype = 1029
    End Sub
End Class

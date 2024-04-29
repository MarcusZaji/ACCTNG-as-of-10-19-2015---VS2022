Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmConversionBC

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Dim drDate As DataRow

    Private Sub GetConRate()
        mebPHP_USD.Text = ""
        mebUSD_JPY.Text = ""
        mebJPY_PHP.Text = ""
        dtpDate.Value = ""

    End Sub

    Private Sub frmConversionBC_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConversionBC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        dtpDate.Value = Today

        GetConversionRate()

        GetSetting()

    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click

        If BC_Conversion = 1 Then
            drDate = Chinita.fetchMySqlRow_BC("select (select distinct(year(fldDate)) " _
                                & "from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "') as date")

            If drDate.Item("date").ToString <> "" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Convertion for this year is already set!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                Tomboy.SetConversionRateBC(mebPHP_USD.Text, mebUSD_JPY.Text, mebJPY_PHP.Text, dtpDate.Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Convertion Set", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        Else
            Tomboy.UpdateConversionRateBC(mebPHP_USD.Text, mebUSD_JPY.Text, mebJPY_PHP.Text, dtpDate.Value)
            Tomboy.AddConversionRateLogs(mebPHP_USD.Value, mebUSD_JPY.Value, mebJPY_PHP.Value, dtpDate.Value, Today)
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Convertion Updated", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        mebPHP_USD.Text = ""
        mebUSD_JPY.Text = ""
        mebJPY_PHP.Text = ""

        GetConversionRate()
    End Sub

    Private Sub GetConversionRate()
        Dim drPHP_USD As DataRow = Chinita.fetchMySqlRow_BC("select (select fldAmount from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "' AND fldCurrency = 'PHP-USD')as Amount")
        Dim drUSD_YEN As DataRow = Chinita.fetchMySqlRow_BC("select (select fldAmount from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "' AND fldCurrency = 'USD-JPY')as Amount")
        Dim drJPY_PHP As DataRow = Chinita.fetchMySqlRow_BC("select (select fldAmount from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "' AND fldCurrency = 'JPY-PHP')as Amount")

        If drPHP_USD.Item("Amount").ToString <> "" Then
            BC_Conversion = 0

            mebPHP_USD.Text = drPHP_USD.Item("Amount").ToString
            mebUSD_JPY.Text = drUSD_YEN.Item("Amount").ToString
            mebJPY_PHP.Text = drJPY_PHP.Item("Amount").ToString

        Else
            BC_Conversion = 1

            mebPHP_USD.Text = 0.0
            mebUSD_JPY.Text = 0.0
            mebJPY_PHP.Text = 0.0

        End If

    End Sub

    Private Sub GetSetting()
        Dim LockModule As DataRow = Chinita.fetchMySqlRow_BC("select fldCode from tblSetting where fldSettingID = 1")

        If LockModule.Item("fldCode").ToString = "YES" Then
            btnLockModule.ToggleState = Enumerations.ToggleState.On
            btnLockModule.Text = "LOCKED"
        Else
            btnLockModule.Text = "UNLOCKED"
        End If

    End Sub

    Private Sub btnLockModule_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles btnLockModule.ToggleStateChanged

        If btnLockModule.ToggleState = Enumerations.ToggleState.On Then
            Tomboy.SetModule("YES")
            btnLockModule.Text = "LOCKED"
           
        Else
            Tomboy.SetModule("NO")
            btnLockModule.Text = "UNLOCKED"
           
        End If
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Try
            frmRateLogsBC.Show(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class

Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmConversion

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Dim drDate As DataRow

    Private Sub GetConRate()
        mebPHP_USD.Text = ""
        mebUSD_JPY.Text = ""
        mebJPY_PHP.Text = ""
        dtpDate.Value = ""

    End Sub

    Private Sub frmConversion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        dtpDate.Value = Today

        Dim drPHP_USD As DataRow = Chinita.fetchMySqlRow("select (select fldamount from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "' AND fldcurrency = 'PHP-USD')as Amount")
        Dim drUSD_YEN As DataRow = Chinita.fetchMySqlRow("select (select fldamount from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "' AND fldcurrency = 'USD-JPY')as Amount")
        Dim drJPY_PHP As DataRow = Chinita.fetchMySqlRow("select (select fldamount from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "' AND fldcurrency = 'JPY-PHP')as Amount")

        If drPHP_USD.Item("Amount").ToString <> "" Then
            mebPHP_USD.Text = drPHP_USD.Item("Amount").ToString
            mebUSD_JPY.Text = drUSD_YEN.Item("Amount").ToString
            mebJPY_PHP.Text = drJPY_PHP.Item("Amount").ToString

        Else
            mebPHP_USD.Text = 0.0
            mebUSD_JPY.Text = 0.0
            mebJPY_PHP.Text = 0.0

        End If

    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click

        drDate = Chinita.fetchMySqlRow("select (select distinct(year(fldDate)) " _
                                & "from tblConversion where year(fldDate) = '" & dtpDate.Value.Year & "') as date")

        If drDate.Item("date").ToString <> "" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Convertion for this year is already set!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
           
        Else
            Tomboy.SetConversionRate(mebPHP_USD.Text, mebUSD_JPY.Text, mebJPY_PHP.Text, dtpDate.Value)
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Convertion Set", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        mebPHP_USD.Text = ""
        mebUSD_JPY.Text = ""
        mebJPY_PHP.Text = ""
    End Sub

End Class

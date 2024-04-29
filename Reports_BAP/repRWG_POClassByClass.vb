Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repRWG_POClassByClass

    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)


        myCmd.Connection = conn


        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "call SP_RWGCPO_CLASS('" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", frmGenReport.dtpFrom.Value)) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", frmGenReport.dtpTo.Value)) & "','" & frmGenReport.ddlDept.Text & "','" & frmGenReport.ddlBT.Text & "','" & frmGenReport.ddlClass.Text & "')"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        Me.DataSource = myData

        budgetCaptionTextBox.Value = frmGenReport.ddlBT.Text + "BUDGET"

    End Sub
End Class
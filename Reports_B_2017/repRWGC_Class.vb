Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repRWGC_Class2017
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
        myCmd.CommandTimeout = 0
        myCmd.CommandText = "call SP_RWGC_Class('" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", frmGenReport.dtpFrom.Value)) & "','" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", frmGenReport.dtpTo.Value)) & "','" & frmGenReport.ddlDept.Text & "','" & frmGenReport.ddlBT.Text & "','" & frmGenReport.ddlClass.Text & "')"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        Me.DataSource = myData

        budgetCaptionTextBox.Value = frmGenReport.ddlBT.Text + "BUDGET"



        'Me.ReportParameters("D1").Value = frmGenReport.dtpFrom.Value
        'Me.ReportParameters("D2").Value = frmGenReport.dtpTo.Value
        'Me.ReportParameters("DEPT").Value = frmGenReport.ddlDept.Text
        'Me.ReportParameters("Choice").Value = frmGenReport.ddlBT.Text
        'Me.ReportParameters("CLASS").Value = frmGenReport.ddlClass.Text
    End Sub
End Class
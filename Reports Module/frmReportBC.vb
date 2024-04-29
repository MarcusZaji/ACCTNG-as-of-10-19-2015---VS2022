Public Class frmReportBC

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmReportBC_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmReportBC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '-----moveable form :)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        If reporttype = 101 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBperAmount, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 102 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBperQTY, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 103 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBperAmountperClass, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 104 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBperQTYperClass, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 105 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repUserBudCreated, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 106 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repConsolidatedBudget, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 107 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBperAmountperPPEClass, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 108 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBperQTYperPPEClass, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 109 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repFBCombine, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()

        ElseIf reporttype = 110 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.repCreatedMajorBud, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmGenReportBC

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmGenReportBC_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmGenReportBC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) 'moveable form :)

        DeptGenRepBC()
        ClassGenRepBC()
        ddlYearBCGenReport()

        ddlDept.Enabled = True
        ddlDept.Text = ""
        ddlClass.Text = ""
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub rbRepCombine_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepCombine.ToggleStateChanged
        reporttype = 109

        ddlClass.Enabled = False
        ddlClass.Text = ""
    End Sub

    Private Sub rbRepAmount_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepAmount.ToggleStateChanged
        reporttype = 101

        ddlClass.Enabled = False
        ddlClass.Text = ""
    End Sub

    Private Sub rbRepQTY_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepQTY.ToggleStateChanged
        reporttype = 102

        ddlClass.Enabled = False
        ddlClass.Text = ""
    End Sub

    Private Sub rbRepAmountClass_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepAmountClass.ToggleStateChanged
        ddlClass.Enabled = True
    End Sub

    Private Sub rbRepQTYClass_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepQTYClass.ToggleStateChanged
        ddlClass.Enabled = True
    End Sub

    Private Sub rbRepBC_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepBC.ToggleStateChanged
        reporttype = 105
        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlClass.Text = ""
    End Sub

    Private Sub rbRepConBC_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepConBC.ToggleStateChanged
        reporttype = 106

        ddlClass.Enabled = False
        ddlClass.Text = ""
    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Try
            If (rbRepCombine.IsChecked = True) Then
                reporttype = 109
            End If

            If (rbRepAmount.IsChecked = True) Then
                reporttype = 101
            End If

            If (rbRepQTY.IsChecked = True) Then
                reporttype = 102
            End If

            If (rbRepBC.IsChecked = True) Then
                reporttype = 105
            End If

            If (cbMajorBud.IsChecked = True) Then
                reporttype = 110
            End If

            If rbRepAmountClass.IsChecked = True Then
                If ddlClass.SelectedValue = "PPE" Then
                    reporttype = 107
                Else
                    reporttype = 103
                End If
            End If

            If rbRepQTYClass.IsChecked = True Then
                If ddlClass.SelectedValue = "PPE" Then
                    reporttype = 108
                Else
                    reporttype = 104
                End If

            End If

            frmReportBC.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub cbMajorBud_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbMajorBud.ToggleStateChanged
        reporttype = 110

        ddlClass.Enabled = False
        ddlDept.Enabled = False
        ddlClass.Text = ""
        ddlDept.Text = ""
    End Sub
End Class

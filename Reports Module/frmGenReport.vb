Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmGenReport

    Dim moveCtrl As MoveControl = Nothing

    Private Sub frmGenReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmGenReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) 'moveable form :)

        ClassRepUpdated()
        DeptRepUpdated()
        RepPO()

        ddlClass.Text = ""

        ddlDept.Enabled = True
        ddlDept.Text = ""

        dtpFrom.Value = Today
        dtpTo.Value = Today

    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        'If rbPR.IsChecked = True Then
        '    Try
        '        reporttype = 3

        '        globalVariables.Department = ddlDept.Text
        '        globalVariables.d1 = dtpFrom.Value 
        '        globalVariables.d2 = dtpTo.Value
        '        FrmReportServer.Show()
        '    Catch ex As Exception
        '        RadMessageBox.SetThemeName("Windows8")
        '        RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        '    End Try
        'End If
        globalVariables.Department = ddlDept.Text
        globalVariables.d1 = dtpFrom.Value
        globalVariables.d2 = dtpTo.Value
        globalVariables._Class = ddlClass.Text
        globalVariables._PO = ddlPO.Text
        globalVariables.Choice = ddlBT.Text
        globalVariables.YearReport = txtYear.Text


        'If rbRepMonth.IsChecked = True Then
        '    If ddlDept.Text = "ALL" Then
        '        reporttype = 12
        '    Else
        '        reporttype = 4
        '    End If

        'End If
        'If rbRWGC_ClassByClass.IsChecked = True Then
        '    reporttype = 202
        '    Try
        '        FrmPleaseWait.Show(Me)
        '    Catch ex As Exception
        '        RadMessageBox.SetThemeName("Windows8")
        '        RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        '    End Try
        '    Exit Sub
        'End If

        'If rbPR.IsChecked = True Then
        '    'If ddlDept.Text = "ALL" Then
        '    '    reporttype = 19
        '    'Else
        '    '    reporttype = 16
        '    'End If
        '    Try
        '        reporttype = 2

        '        globalVariables.Department = ddlDept.Text
        '        globalVariables.d1 = dtpFrom.Value
        '        globalVariables.d2 = dtpTo.Value
        '        FrmReportServer.Show()
        '    Catch ex As Exception
        '        RadMessageBox.SetThemeName("Windows8")
        '        RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        '    End Try

        'End If

        'If rbPR_Item_Open.IsChecked = True Then
        '    If ddlDept.Text = "ALL" Then
        '        reporttype = 21
        '    Else
        '        reporttype = 20
        '    End If
        'End If

        Try
            FrmReportServer.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try


    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub rbRepDept_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepDept.ToggleStateChanged
        reporttype = 5

        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub rbRepBud_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepBud.ToggleStateChanged
        reporttype = 6
        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
        globalVariables.Choose = "SUB BUDGET"
    End Sub

    Private Sub rbRepMonth_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepMonth.ToggleStateChanged
        reporttype = 8
        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub rbAA_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbAA.ToggleStateChanged
        reporttype = 9

        ddlDept.Enabled = True
        ddlClass.Enabled = True
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub rbPO_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbPO.ToggleStateChanged
        reporttype = 10

        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = True
        ddlBT.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub rbSO_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbSO.ToggleStateChanged
        reporttype = 9
        txtYear.Enabled = False

    End Sub

    Private Sub rbRWG_ToggleStateChanged_1(sender As Object, args As StateChangedEventArgs) Handles rbRWG.ToggleStateChanged
        reporttype = 11

        If rbRWG.IsChecked = True Then
            ddlDept.Enabled = False
            ddlClass.Enabled = False
            ddlPO.Enabled = False
            txtYear.Enabled = False
            ddlBT.Enabled = True
        End If
    End Sub

    Private Sub rbRWGC_ToggleStateChanged_1(sender As Object, args As StateChangedEventArgs) Handles rbRWGC.ToggleStateChanged
        reporttype = 13

        If rbRWGC.IsChecked = True Then
            ddlDept.Enabled = False
            ddlPO.Enabled = False
            ddlClass.Enabled = True
            ddlBT.Enabled = True
            txtYear.Enabled = False
        End If
    End Sub

    Private Sub rbRWG_PO_ToggleStateChanged_1(sender As Object, args As StateChangedEventArgs) Handles rbRWG_PO.ToggleStateChanged
        reporttype = 14

        If rbRWG_PO.IsChecked = True Then
            ddlDept.Enabled = False
            ddlPO.Enabled = False
            ddlClass.Enabled = False
            txtYear.Enabled = False
            ddlBT.Enabled = True
        End If
    End Sub

    Private Sub rbRWG_POClass_ToggleStateChanged_1(sender As Object, args As StateChangedEventArgs) Handles rbRWG_POClass.ToggleStateChanged
        reporttype = 15

        If rbRWG_POClass.IsChecked = True Then
            ddlDept.Enabled = False
            ddlPO.Enabled = False
            ddlClass.Enabled = True
            ddlBT.Enabled = True
            txtYear.Enabled = False
        End If

    End Sub

    Private Sub rbPR_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbPR.ToggleStateChanged
        reporttype = 16
        If rbPR.IsChecked = True Then
            ddlDept.Enabled = True
            ddlPO.Enabled = False
            ddlClass.Enabled = False
            ddlBT.Enabled = False
            txtYear.Enabled = False
        End If

    End Sub

    Private Sub rbUPO_Summary_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbUPO_Summary.ToggleStateChanged
        reporttype = 18

        If rbUPO_Summary.IsChecked = True Then
            ddlDept.Enabled = True
            ddlPO.Enabled = False
            ddlClass.Enabled = False
            ddlBT.Enabled = False
            txtYear.Enabled = False
        End If

    End Sub

    Private Sub rbFPO_Summary_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbFPO_Summary.ToggleStateChanged
        reporttype = 19

        If rbFPO_Summary.IsChecked = True Then
            ddlDept.Enabled = True
            ddlClass.Enabled = False
            ddlPO.Enabled = False
            ddlBT.Enabled = False
            txtYear.Enabled = False
        End If

    End Sub

    Private Sub rbPR_Item_Open_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbPR_Item_Open.ToggleStateChanged
        reporttype = 17
        If rbPR.IsChecked = True Then
            ddlDept.Enabled = True
            ddlPO.Enabled = False
            ddlClass.Enabled = False
            ddlBT.Enabled = False
            txtYear.Enabled = False
        End If
    End Sub

    Private Sub rbRWG_POClassByClass_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRWG_POClassByClass.ToggleStateChanged
        reporttype = 20
        If rbRWG_POClassByClass.IsChecked = True Then
            ddlDept.Enabled = True
            ddlClass.Enabled = True
            ddlPO.Enabled = False
            ddlBT.Enabled = True
            txtYear.Enabled = False
        End If
    End Sub

    Private Sub rbRWGC_ClassByClass_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRWGC_ClassByClass.ToggleStateChanged
        reporttype = 21
        If rbRWGC_ClassByClass.IsChecked = True Then
            ddlDept.Enabled = True
            ddlClass.Enabled = True
            ddlPO.Enabled = False
            ddlBT.Enabled = True
            txtYear.Enabled = False
        End If
    End Sub

    Private Sub rbPRParent_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbPRParent.ToggleStateChanged
        reporttype = 22
        If rbPRParent.IsChecked = True Then
            ddlDept.Enabled = True
            ddlClass.Enabled = False
            ddlPO.Enabled = False
            ddlBT.Enabled = False
            txtYear.Enabled = False
        End If
    End Sub

    Private Sub rbInvestment_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbInvestment.ToggleStateChanged
        reporttype = 23
        If rbInvestment.IsChecked = True Then
            ddlDept.Enabled = False
            ddlClass.Enabled = False
            ddlPO.Enabled = False
            ddlBT.Enabled = False
            dtpFrom.Enabled = False
            dtpTo.Enabled = False
            txtYear.Enabled = False
        End If
    End Sub

    Private Sub rbSubBud_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbSubBud.ToggleStateChanged
        reporttype = 7
        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
        globalVariables.Choose = "SUB"
    End Sub

    Private Sub rbRepBudMajor_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbRepBudMajor.ToggleStateChanged
        reporttype = 6
        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
        globalVariables.Choose = "MAJOR"
    End Sub

    Private Sub rbSubBudMajor_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbSubBudMajor.ToggleStateChanged
        reporttype = 7
        ddlDept.Enabled = True
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        txtYear.Enabled = False
        globalVariables.Choose = "Original"
    End Sub

    Private Sub rbPOReport_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbPOReport.ToggleStateChanged
        reporttype = 26
        ddlDept.Enabled = False
        ddlClass.Enabled = False
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        dtpFrom.Enabled = True
        dtpTo.Enabled = True
        txtYear.Enabled = False
        globalVariables.Choose = "Purchasing Report"
    End Sub

    Private Sub rbSubBudgetReport_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbSubBudgetReport.ToggleStateChanged
        reporttype = 27
        ddlDept.Enabled = False
        ddlClass.Enabled = True
        ddlPO.Enabled = False
        ddlBT.Enabled = False
        dtpFrom.Enabled = False
        dtpTo.Enabled = False
        txtYear.Enabled = True
        globalVariables.Choose = "Sub Budget Report"
    End Sub
End Class

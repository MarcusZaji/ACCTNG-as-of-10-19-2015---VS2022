Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class frmUploadPicker


    Private Sub Pilina()

        If rbUploadpicker = 1 Then
            ' Me.Close()
            FrmUpItem.Show(Me)

        ElseIf rbUploadpicker = 2 Then
            FrmUpBud.Show(Me)
            'Me.Close()

        ElseIf rbUploadpicker = 3 Then
            FrmUpPO.Show(Me)

        ElseIf rbUploadpicker = 4 Then
            frmUpBC.Show(Me)
        End If

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub rbUpItem_Click(sender As Object, e As EventArgs) Handles rbUpItem.Click
        rbUploadpicker = 1
        Pilina()
    End Sub

    Private Sub rbUpBudget_Click(sender As Object, e As EventArgs) Handles rbUpBudget.Click
        rbUploadpicker = 2
        Pilina()
    End Sub

    Private Sub rbUpPO_Click(sender As Object, e As EventArgs) Handles rbUpPO.Click
        rbUploadpicker = 3
        Pilina()
    End Sub

    Private Sub rbUpBC_Click(sender As Object, e As EventArgs) Handles rbUpBC.Click
        rbUploadpicker = 4
        Pilina()
    End Sub

    Private Sub frmUploadPicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmUploadPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Version As Integer = 1

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT fldProName, fldLimit FROM tblSettings WHERE fldProID = 3")
        Dim BAP_Version As Integer = drUser.Item("fldLimit")

        If Version <> BAP_Version Then
            rbUpPO.Visible = False
        End If

    End Sub

    Private Sub rbUpPO_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbUpPO.ToggleStateChanged

    End Sub
End Class

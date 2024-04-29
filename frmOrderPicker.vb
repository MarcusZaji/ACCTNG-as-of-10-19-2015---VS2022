Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class frmOrderPicker

    Private Sub rbSO_Click(sender As Object, e As EventArgs) Handles rbSO.Click
        rbpicker = 1
        Pilina()
    End Sub

    Private Sub rbMO_Click(sender As Object, e As EventArgs) Handles rbMO.Click
        rbpicker = 2
        Pilina()
    End Sub

    Private Sub Pilina()

        If rbpicker = 1 Then
            Try
                frmOrder.Show(Me)
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form already open.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try

        ElseIf rbpicker = 2 Then
            Try
                frmMultiOrder.Show(Me)
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form already open.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try

        End If

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub frmOrderPicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub rbSO_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbSO.ToggleStateChanged

    End Sub
End Class

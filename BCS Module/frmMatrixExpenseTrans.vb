Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmMatrixExpenseTrans

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private Data_ID As Integer

    Private Sub frmMatrixExpenseTrans_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmMatrixExpenseTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClassificationMatrixBC()

        If MatrixPicker = 1 Then
            Clear(Me)

        ElseIf MatrixPicker = 2 Then
            GetData()
        End If

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Public Sub GetData()
        
        Try
            Data_ID = frmMatrixExpense.rgvList.CurrentRow.Cells("fldID").Value
            ddlClass.Text = frmMatrixExpense.rgvList.CurrentRow.Cells("fldItem").Value.ToString
            txtDefinition.Text = frmMatrixExpense.rgvList.CurrentRow.Cells("fldDefinition").Value.ToString
            txtThreshold.Text = frmMatrixExpense.rgvList.CurrentRow.Cells("fldThreshold").Value.ToString
            txtSample.Text = frmMatrixExpense.rgvList.CurrentRow.Cells("fldSample").Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Clear(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            Clear(ctrl)

            If TypeOf ctrl Is Telerik.WinControls.UI.RadTextBoxControl Then
                CType(ctrl, Telerik.WinControls.UI.RadTextBoxControl).Text = ""
            End If

            If TypeOf ctrl Is Telerik.WinControls.UI.RadDropDownList Then
                CType(ctrl, Telerik.WinControls.UI.RadDropDownList).Text = ""
            End If

        Next ctrl
    End Sub

    Private Sub btnNewMatrix_Click(sender As Object, e As EventArgs) Handles btnNewMatrix.Click
        If btnNewMatrix.Text = "Save" Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Are you sure you want to add this matrix for expense?",
                         "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If Tomboy.AddNewMatrixExpense(ddlClass.Text,
                                              txtDefinition.Text,
                                              txtThreshold.Text,
                                              txtSample.Text) Then

                    frmMatrixExpense.bwLoadData.RunWorkerAsync()
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Matrx Expense Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                    Clear(Me)
                End If
            End If
        Else
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("Are you sure you want to add this matrix for expense?",
                         "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If Tomboy.UpdateNewMatrixExpense(Data_ID,
                                                 ddlClass.Text,
                                                 txtDefinition.Text,
                                                 txtThreshold.Text,
                                                 txtSample.Text) Then

                    frmMatrixExpense.bwLoadData.RunWorkerAsync()
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Matrx Expense Updated!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                    Clear(Me)
                End If

            End If
        End If
    End Sub
End Class

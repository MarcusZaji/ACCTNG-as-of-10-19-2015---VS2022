Imports System.Text.RegularExpressions
Imports Telerik.WinControls

Public Class FrmSignatory
    Private Sub FrmSignatory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fetchSignatory()
        ddlCategory.Text = globalVariables.LoginRFQSection
        ddlCategory.Enabled = True
    End Sub

    Private Sub fetchSignatory()
        Zaji.addParameter("Category", globalVariables.LoginRFQSection)

        Dim dtRFQSig As DataTable = Zaji.dbSelect("SP_SelectRFQSignatorybyCategory")
        If dtRFQSig.Rows.Count > 0 Then
            txtPreparedBy.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldPreparedby"))
            txtPDesignation.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldPDesignation"))
            txtCheckBy.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldCheckedby"))
            txtCDesignation.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldCDesignation"))
            txtCheckBy.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldCheckedby"))
            txtCDesignation.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldCDesignation"))
            txtApprovedby.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldApprovedby"))
            txtADesignation.Text = Convert.ToString(dtRFQSig.Rows(0).Item("fldADesignation"))


        End If

    End Sub

    Private Sub ddlCategory_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlCategory.SelectedIndexChanged
        fetchSignatory()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If RadMessageBox.Show("Are you sure want to update this data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            If txtPreparedBy.Text Is Nothing Then
                RadMessageBox.Show("No Prepared by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            If txtCheckBy.Text Is Nothing Then
                RadMessageBox.Show("No Checked by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            Zaji.addParameter("Preparedby", Regex.Replace(Trim(txtPreparedBy.Text), "\s+", " "))
            Zaji.addParameter("PDesignation", Regex.Replace(Trim(txtPDesignation.Text), "\s+", " "))
            Zaji.addParameter("Checkedby", Regex.Replace(Trim(txtCheckBy.Text), "\s+", " "))
            Zaji.addParameter("CDesignation", Regex.Replace(Trim(txtCDesignation.Text), "\s+", " "))
            Zaji.addParameter("Approvedby", Regex.Replace(Trim(txtApprovedby.Text), "\s+", " "))
            Zaji.addParameter("ADesignation", Regex.Replace(Trim(txtADesignation.Text), "\s+", " "))
            Zaji.addParameter("Category", Regex.Replace(Trim(ddlCategory.Text), "\s+", " "))
            Zaji.dbAED("SP_UpdateSignatorybyCategory")

            RadMessageBox.Show("Record successfully updated", "information", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub
End Class

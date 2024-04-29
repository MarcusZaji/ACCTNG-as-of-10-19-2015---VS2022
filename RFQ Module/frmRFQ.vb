Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Text.RegularExpressions
Imports Telerik.WinControls.UI.Docking

Public Class FrmRFQ
    Dim RFQNoCheck As Int16
    Dim dtCALogs As DataTable
    Private Sub FrmRFQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtID.Text = "" Then
            btnSave.Visible = True
        Else
            btnUpdate.Visible = True
        End If


        Dim EmployeeNo As String = MyGlobal.EmpNo.Substring(0, 7)
        ReadyGrid()
        '------------------Get Deptlist---------------------------
        Zaji.addParameter("Dept", globalVariables.Dept)
        Dim dtDeptList As DataTable = Zaji.dbSelect("SP_SelectSectionByDept")
        ddlSection.DataSource = dtDeptList
        ddlSection.DisplayMember = "fldSection"
        '--------------------Get CHecked and Approved-----------------------
        Zaji.addParameter("Dept", globalVariables.Dept)
        dtCALogs = Zaji.dbSelect("SP_SelectCALogsDept")
        ddlCheckedBy.DataSource = dtCALogs
        ddlCheckedBy.DisplayMember = "fldChecked"

        ddlApprovedBy.DataSource = dtCALogs
        ddlApprovedBy.DisplayMember = "fldApproved"
        '--------------------------------------------------------

        txtEmpNo.Text = EmployeeNo
        txtEmpName.Text = globalVariables.EmpName
        ddlSection.Text = globalVariables.Section
        txtDept.Text = globalVariables.Dept

        dtpDate.Value = Now()
        dtpDateNeeded.Value = Now()


        Dim service As DragDropService = Me.RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting
    End Sub
    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub
    Public Sub ClassificationBudget()
        Dim dtlvalues As DataTable = Zaji.dbSelect("SP_SelectClassNotAll")
        ddlClass.DataSource = dtlvalues
        ddlClass.DisplayMember = "fldClassDesc"
    End Sub
    Private Sub FrmRFQ_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' ClassificationBudget()
        If txtID.Text <> "" Then
            RFQItems()
        End If
    End Sub
    Public Sub RFQItems()
        '-------------------------Get Data for update--------------------------------
        txtRFQNo.Text = globalVariables.RFQNo
        ddlCheckedBy.Text = globalVariables.CheckedBy
        ddlApprovedBy.Text = globalVariables.ApprovedBy
        dtpDate.Value = globalVariables.DateRequest
        txtCPosition.Text = globalVariables.CPosition
        txtAPosition.Text = globalVariables.APosition
        '----------------------------------------------------------------------------

        Zaji.addParameter("RFQNo", txtID.Text)
        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectRFQChildByID")
        rgvList.DataSource = dtRFQRec
    End Sub

    Private Sub ReadyGrid()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")

        With fldStatColumn
            .FieldName = "STATUS"
            fldStatColumn.Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            fldStatColumn.ReadOnly = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            rgvList.Columns.Add(fldStatColumn)
        End With

        Dim fldTypeExpense As New GridViewTextBoxColumn("Type of Expense")
        With fldTypeExpense
            .FieldName = "fldTypeExpense"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldTypeExpense)

        Dim fldDesc As New GridViewTextBoxColumn("Descripion")
        With fldDesc
            .FieldName = "fldDesc"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDesc)

        Dim fldQTY As New GridViewDecimalColumn("QTY")
        With fldQTY
            .FieldName = "fldQTY"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQTY)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldDateNeeded As New GridViewDateTimeColumn("Date Needed")
        With fldDateNeeded
            .FieldName = "fldDateNeeded"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDateNeeded)
        rgvList.Columns("fldDateNeeded").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarks As New GridViewTextBoxColumn("Remarks")
        With fldRemarks
            .FieldName = "fldRemarks"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRemarks)

        Dim fldChemical As New GridViewTextBoxColumn("Chemical")
        With fldChemical
            .FieldName = "fldChemical"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldChemical)

        Dim fldPPE As New GridViewTextBoxColumn("PPE")
        With fldPPE
            .FieldName = "fldPPE"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldPPE)

    End Sub

    Private Sub btnOI_Click(sender As Object, e As EventArgs) Handles btnOI.Click
        If String.IsNullOrEmpty(ddlClass.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Type of Expense selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please input Item Description", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf (mebQTY.Value = 0) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Zero Quantity is not allowed", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Unit of Measurement Selected", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Dim Chemical As String

            If rbNo.IsChecked = True Then
                Chemical = "NO"
            Else
                Chemical = "YES"
            End If

            Dim PPE As String

            If rbPPENo.IsChecked = True Then
                PPE = "NO"
            Else
                PPE = "YES"
            End If

            Dim count As Integer = rgvList.Rows.Count

            If count >= 15 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("15 Items only per Purchased Requisition", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                rgvList.Rows.Add("", ddlClass.Text, txtDesc.Text, mebQTY.Value, ddlUOM.Text, dtpDateNeeded.Value, txtRemarks.Text, Chemical, PPE)

            End If

        End If
    End Sub

    Private Sub txtEmpNo_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNo.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtEmpName.Text Is Nothing Then
            RadMessageBox.Show("Please Contact MIS for this problem", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If ddlApprovedBy.Text = "" Then
            RadMessageBox.Show("Please input approved by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If ddlCheckedBy.Text = "" Then
            RadMessageBox.Show("Please input checked by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If txtID.Text = "" Then
            RFQNoCheck = 0
        Else
            RFQNoCheck = Convert.ToInt16(txtID.Text)
        End If
        If RadMessageBox.Show("Are you sure want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

            Zaji.addParameter("RFQNo", RFQNoCheck)
            Zaji.addParameter("DateRequest", dtpDate.Value)
            Zaji.addParameter("EmpNo", Regex.Replace(Trim(txtEmpNo.Text), "\s+", " "))
            Zaji.addParameter("EmpName", Regex.Replace(Trim(txtEmpName.Text), "\s+", " "))
            Zaji.addParameter("Dept", txtDept.Text)
            Zaji.addParameter("Section", ddlSection.Text)
            Zaji.addParameter("CheckedBy", ddlCheckedBy.Text)
            Zaji.addParameter("ApprovedBy", ddlApprovedBy.Text)
            Zaji.addParameter("CPosition", txtCPosition.Text)
            Zaji.addParameter("APosition", txtAPosition.Text)

            If Zaji.dbAED("SP_InsertRFQ") Then

                Zaji.addParameter("Dept", txtDept.Text)
                Zaji.addParameter("Section", ddlSection.Text)
                Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectLastCreatedRFQbyDept")

                If dtRFQRec.Rows.Count > 0 Then
                    txtRFQNo.Text = Convert.ToString(dtRFQRec.Rows(0).Item("RFQNo"))
                    txtID.Text = Convert.ToString(dtRFQRec.Rows(0).Item("fldRFQNo"))
                End If

                '----------------------Insert Section list
                Zaji.addParameter("Section", ddlSection.Text)
                Zaji.addParameter("Dept", txtDept.Text)
                Dim dtInsert As DataTable = Zaji.dbSelect("SP_InsertSectionList")

                '--------------------insert Checked and Approved logs
                Zaji.addParameter("Checked", ddlCheckedBy.Text)
                Zaji.addParameter("Approved", ddlApprovedBy.Text)
                Zaji.addParameter("Dept", txtDept.Text)
                Dim dtInsertCALogs As DataTable = Zaji.dbSelect("SP_InsertCALogs")

                bwSave.RunWorkerAsync()

            End If
        End If

    End Sub
    Private lineNo As Integer
    Private lineStat As String
    Private Sub bwSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSave.DoWork
        Dim delay As Integer = 20
        Zaji.addParameter("RFQNo", txtID.Text)
        Zaji.dbAED("SP_DeletRFQChildByRFQNo")
        Dim count = 0
        For x As Integer = 0 To rgvList.Rows.Count - 1
            count = count + 1
            Zaji.addParameter("RFQNo", txtID.Text)
            Zaji.addParameter("TypeExpense", rgvList.Rows(x).Cells("fldTypeExpense").Value)
            Zaji.addParameter("_Desc", rgvList.Rows(x).Cells("fldDesc").Value)
            Zaji.addParameter("QTY", rgvList.Rows(x).Cells("fldQTY").Value)
            Zaji.addParameter("UOM", rgvList.Rows(x).Cells("fldUOM").Value)
            Zaji.addParameter("DateNeeded", rgvList.Rows(x).Cells("fldDateNeeded").Value)
            Zaji.addParameter("Remarks", rgvList.Rows(x).Cells("fldRemarks").Value)
            Zaji.addParameter("Chemical", rgvList.Rows(x).Cells("fldChemical").Value)
            Zaji.addParameter("_No", count)
            Zaji.addParameter("PPE", rgvList.Rows(x).Cells("fldPPE").Value)

            If Zaji.dbAED("SP_InsertRFQChildv3") Then
                lineStat = "OK"
            Else
                lineStat = "NG"
            End If

            Dim percent As Double = x / rgvList.Rows.Count * 100

            lineNo = x
            RadProgressBar1.Text = "Saving..."
            bwSave.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwSave_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwSave.ProgressChanged
        rgvList.CurrentRow = rgvList.Rows(lineNo)
        rgvList.CurrentRow.Cells(0).Value = lineStat
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSave_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwSave.RunWorkerCompleted
        RadProgressBar1.Value1 = 100
        RadProgressBar1.Text = "Done"
        FrmRFQList.GetRFQList()
        RadMessageBox.Show("Successfully Saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            reporttype = 0
            'Zaji.addReportParameter("RFQNo", txtID.Text)
            globalVariables.RID = txtID.Text
            FrmReportServer.Show()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub rgvList_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles rgvList.CellFormatting

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEmpName.Text Is Nothing Then
            RadMessageBox.Show("Please Contact MIS for this problem", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If ddlApprovedBy.Text = "" Then
            RadMessageBox.Show("Please input approved by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If ddlCheckedBy.Text = "" Then
            RadMessageBox.Show("Please input checked by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If txtID.Text = "" Then
            RFQNoCheck = 0
        Else
            RFQNoCheck = Convert.ToInt16(txtID.Text)
        End If
        If RadMessageBox.Show("Are you sure want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

            Zaji.addParameter("RFQNo", RFQNoCheck)
            Zaji.addParameter("DateRequest", dtpDate.Value)
            Zaji.addParameter("EmpNo", Regex.Replace(Trim(txtEmpNo.Text), "\s+", " "))
            Zaji.addParameter("EmpName", Regex.Replace(Trim(txtEmpName.Text), "\s+", " "))
            Zaji.addParameter("Dept", txtDept.Text)
            Zaji.addParameter("Section", ddlSection.Text)
            Zaji.addParameter("CheckedBy", ddlCheckedBy.Text)
            Zaji.addParameter("ApprovedBy", ddlApprovedBy.Text)
            Zaji.addParameter("CPosition", txtCPosition.Text)
            Zaji.addParameter("APosition", txtAPosition.Text)

            If Zaji.dbAED("SP_InsertRFQ") Then

                '----------------------Insert Section list
                Zaji.addParameter("Section", ddlSection.Text)
                Zaji.addParameter("Dept", txtDept.Text)
                Dim dtInsert As DataTable = Zaji.dbSelect("SP_InsertSectionList")

                '--------------------insert Checked and Approved logs
                Zaji.addParameter("Checked", ddlCheckedBy.Text)
                Zaji.addParameter("Approved", ddlApprovedBy.Text)
                Zaji.addParameter("Dept", txtDept.Text)
                Dim dtInsertCALogs As DataTable = Zaji.dbSelect("SP_InsertCALogs")

                bwSave.RunWorkerAsync()

            End If
        End If
    End Sub
End Class

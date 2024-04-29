Imports Telerik.WinControls
Imports MySql.Data.MySqlClient

Public Class frmMain

    Private FormToLoad As String = Nothing
    Private name As String

    Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

    Private Sub mnDCSet_Click(sender As Object, e As EventArgs)
        'set password of admin to set....
        frmSetDataConn.Show(Me)

    End Sub

    Private Sub getUser()
        'Dim name As String
        Dim UN As String
        Dim PRNotif As String

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & lblId.Text & "'")
        lblDept.Text = drUser.Item("fldDept").ToString
        globalVariables.LoginDept = drUser.Item("fldDept").ToString
        globalVariables.LoginSignature = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString
        globalVariables.LoginUID = drUser.Item("fldUID")
        globalVariables.LoginUserLvl = drUser.Item("fldUserlvl").ToString
        globalVariables.LoginRFQ = drUser.Item("fldRFQ").ToString
        globalVariables.LoginRFQSection = drUser.Item("fldRFQSection").ToString

        ' MessageBox.Show(globalVariables.LoginRFQSection)

        lblAccesslvl.Text = drUser.Item("fldUserlvl").ToString
        name = drUser.Item("fldName").ToString
        UN = drUser.Item("fldUsername").ToString
        lblTheme.Text = drUser.Item("fldThemeColor").ToString
        PRNotif = drUser.Item("fldPRNotifi").ToString

        If PRNotif = "YES" Then
            lblPurchasing.Visible = True
            lblPRNotifi.Visible = True
            lblPRInfo.Visible = True
            imgPRInfo.Visible = True
        End If

        If lblAccesslvl.Text = "SUPERADMIN" Then

            picSupp.Visible = True
            lblSupp.Visible = True
            lblSuppDesc.Visible = True

            picItemNonRM.Visible = True
            lblItemNonRM.Visible = True
            ItemNonRMDesc.Visible = True

            PicRate.Visible = True
            lblRate.Visible = True
            lblRateDesc.Visible = True

            lblSettings.Visible = True

            picUser.Visible = True
            lblManUser.Visible = True
            lblManUser1.Visible = True

            picCurrency.Visible = True
            lblCurrency.Visible = True
            lblCurrency1.Visible = True

            picDC.Visible = True
            lblDataConn.Visible = True
            lblDataConn1.Visible = True

            picAddField.Visible = True
            lblAddField.Visible = True
            lblAddField1.Visible = True

            picBS.Visible = True
            lblBS1.Visible = True
            lblBS2.Visible = True

            picUploadItem.Visible = True
            lblUploadItem.Visible = True
            lblUploadItem1.Visible = True

            lblCreatePO.Visible = True
            picCreatePO.Visible = True

            lblPOChange.Visible = True
            picPOChange.Visible = True

            imgUploadBud.Visible = True
            lblUploadBud.Visible = True

            lblFPO.Visible = True
            picFPO.Visible = True
            picBC.Visible = True
            lblBudOld.Visible = True
            'lblBC.Visible = True

            lblAcctngSync.Visible = True

            'imgInvestment.Visible = True
            'lblInvestment.Visible = True

            lblInactive.Visible = True
            picInactive.Visible = True


            ImgSubBudget.Visible = True
            lblSubBudget.Visible = True
            lblUploadUpdateSub.Visible = True
            imgUploadSubBudget.Visible = True

            lblActivity.Visible = True
            PicActivity.Visible = True
            lblModel.Visible = True
            PicModel.Visible = True


        ElseIf lblAccesslvl.Text = "ADMINISTRATOR" Then

            picSupp.Visible = True
            lblSupp.Visible = True
            lblSuppDesc.Visible = True

            picItemNonRM.Visible = True
            lblItemNonRM.Visible = True
            ItemNonRMDesc.Visible = True

            PicRate.Visible = True
            lblRate.Visible = True
            lblRateDesc.Visible = True

            lblSettings.Visible = True

            picUser.Visible = True
            lblManUser.Visible = True
            lblManUser1.Visible = True

            picCurrency.Visible = True
            lblCurrency.Visible = True
            lblCurrency1.Visible = True

            picDC.Visible = True
            lblDataConn.Visible = True
            lblDataConn1.Visible = True

            picAddField.Visible = True
            lblAddField.Visible = True
            lblAddField1.Visible = True

            'picIM.Visible = False
            'lblIM.Visible = False
            'lblIM1.Visible = False

            picUploadItem.Visible = True
            lblUploadItem.Visible = True
            lblUploadItem1.Visible = True

            lblCreatePO.Visible = True
            picCreatePO.Visible = True

            lblPOChange.Visible = True
            picPOChange.Visible = True

            lblFPO.Visible = True
            picFPO.Visible = True

            imgUploadBud.Visible = True
            lblUploadBud.Visible = True
            picBC.Visible = True
            lblBudOld.Visible = True

            lblInactive.Visible = True
            picInactive.Visible = True

            ImgSubBudget.Visible = True
            lblSubBudget.Visible = True
            lblUploadUpdateSub.Visible = True
            imgUploadSubBudget.Visible = True

            lblActivity.Visible = True
            PicActivity.Visible = True
            lblModel.Visible = True
            PicModel.Visible = True

        ElseIf lblAccesslvl.Text = "PROFESSIONAL" Then

            picSupp.Visible = True
            lblSupp.Visible = True
            lblSuppDesc.Visible = True

            picItemNonRM.Visible = True
            lblItemNonRM.Visible = True
            ItemNonRMDesc.Visible = True

            lblCreatePO.Visible = True
            picCreatePO.Visible = True

            lblPOChange.Visible = True
            picPOChange.Visible = True

            lblInactive.Visible = True
            picInactive.Visible = True

        ElseIf lblAccesslvl.Text = "MANAGER" Then


        ElseIf lblAccesslvl.Text = "USER" Then

        End If

        leCurrentDate.Text = Today.ToString("MMM dd, yyyy")

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me Then
                My.Application.OpenForms.Item(i).Refresh()
            End If
        Next i

        'frmLogin.Show()
        'frmLogin.txtUN.Text = ""
        'frmLogin.txtPW.Text = ""
        'frmLogin.txtUN.Focus()

        'Me.Close()
        ' Environment.Exit(1)
    End Sub

    Private Sub ChangePassword()
        If Chinita.isOpenForm(FrmChangePW) Then
            FrmChangePW.Focus()
        Else
            frmsplash.busy()
            FrmChangePW.lblID.Text = Me.lblId.Text
            FrmChangePW.Show(Me)
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Closing BAP...", "Force Close BAP", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i

        End If

        If e.KeyCode = Keys.Home Then
            Try
                ChangePassword()
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form Already Open.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try

        End If

        If e.KeyCode = Keys.Escape Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString
        ' lblV.Text = My.Settings.setServerAddress + " - " + "BAP Live SAP Connected datatbase/ 2020"
        lblV.Text = My.Settings.setServerAddress + " - " + "BAP Live SAP Connected datatbase/" + Today.Year.ToString()

        'Ge HRMS Security
        getEmployeeRec()


        Dim ctl As Control
        Dim ctlMDI As MdiClient

        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)

                ctl.BackColor = Me.BackColor
            Catch exc As InvalidCastException

            End Try
        Next

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = New Point(0, 2)

        getUser()

        GetTheme(Me)
        Me.Text = "BAP (Budget Actual Program) 3.0"

    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
    End Sub

    Private Sub bwChildFormLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwChildFormLoader.DoWork
        For x As Integer = 0 To 3
            Threading.Thread.Sleep(Delay)
        Next
    End Sub

    Private Sub bwChildFormLoader_RunWo3kerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwChildFormLoader.RunWorkerCompleted

        Select Case FormToLoad

            Case "frmBudget"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is frmBudget Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New frmBudget
                frm.MdiParent = Me
                frm.Show()

                '-----------------
                '-----------------

            Case "frmPO"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is FrmViewPO Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New FrmViewPO
                frm.MdiParent = Me
                frm.Show()

                '-----------------

            Case "frmOrder"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is frmOrder Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New frmOrder
                frm.MdiParent = Me
                frm.Show()

                '-----------------
            Case "frmAA"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is frmAA Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New frmAA
                frm.MdiParent = Me
                frm.Show()

                '-----------------
            Case "frmUser"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is frmUser Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New frmUser
                frm.MdiParent = Me
                frm.Show()

                '-----------------
            Case "frmReport"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is frmReport Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New frmReport
                frm.MdiParent = Me
                frm.Show()

                '-----------------
            Case "frmConversion"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is frmConversion Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New frmConversion
                frm.MdiParent = Me
                frm.Show()

                '-----------------
            Case "frmCPO"
                For Each Child In Me.MdiChildren
                    If TypeOf Child Is FrmCPO Then
                        Child.WindowState = FormWindowState.Normal
                        Child.Focus()
                        Exit Sub
                    End If
                Next

                frmsplash.busy()

                Dim frm As New FrmCPO
                frm.MdiParent = Me
                frm.Show()
        End Select

    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.Dispose()
        GTG = True
        frmLogin.Show()
        frmLogin.txtUN.Text = ""
        frmLogin.txtPW.Text = ""
        frmLogin.txtUN.Focus()

        Me.Close()

    End Sub

    '----- Budget -----'
    Private Sub picBudget_Click(sender As Object, e As EventArgs) Handles picBudget.Click
        Try
            FrmMajorBudget.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub lblBudMan_Click(sender As Object, e As EventArgs) Handles lblBudMan.Click
        Budget()
    End Sub

    Private Sub lblBudMan1_Click(sender As Object, e As EventArgs)
        Budget()
    End Sub

    '----- PO -----'

    Private Sub lblPOChange_Click(sender As Object, e As EventArgs) Handles lblPOChange.Click
        POChange()
    End Sub

    Private Sub picPOChange_Click(sender As Object, e As EventArgs) Handles picPOChange.Click
        POChange()
    End Sub

    Private Sub lblPO_Click(sender As Object, e As EventArgs) Handles lblPO.Click
        ViewPO()
    End Sub

    Private Sub lblFPO_Click(sender As Object, e As EventArgs) Handles lblFPO.Click
        ForcePO()
    End Sub

    Private Sub picFPO_Click(sender As Object, e As EventArgs) Handles picFPO.Click
        ForcePO()
    End Sub

    Private Sub lblViewPO_Click(sender As Object, e As EventArgs) Handles lblViewPO.Click
        ViewPO()
    End Sub

    Private Sub picViewPO_Click(sender As Object, e As EventArgs) Handles picViewPO.Click
        ViewPO()
    End Sub

    Private Sub lblCreatePO_Click(sender As Object, e As EventArgs) Handles lblCreatePO.Click
        CreatePO()
        'MessageBox.Show("Create PO is not yet available")
    End Sub

    Private Sub picCreatePO_Click(sender As Object, e As EventArgs) Handles picCreatePO.Click
        CreatePO()
        'MessageBox.Show("Create PO is not yet available")
    End Sub

    '----- DATA CONN -----'

    Private Sub picDC_Click(sender As Object, e As EventArgs) Handles picDC.Click
        SetDataConn()
    End Sub

    Private Sub lblDataConn_Click(sender As Object, e As EventArgs) Handles lblDataConn.Click
        SetDataConn()
    End Sub

    Private Sub lblDataConn1_Click(sender As Object, e As EventArgs) Handles lblDataConn1.Click
        Try
            frmSetDataConn.Show(Me)
        Catch ex As Exception

        End Try
    End Sub

    '----- ORDER -----'


    Private Sub PicOrder_Click(sender As Object, e As EventArgs) Handles PicOrder.Click
        OrderPicker()
    End Sub

    Private Sub lblOrder_Click(sender As Object, e As EventArgs) Handles lblOrder.Click
        OrderPicker()
    End Sub

    Private Sub lblMO_Click(sender As Object, e As EventArgs) Handles lblMO.Click
        Try
            frmCreatePR.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub picMO_Click(sender As Object, e As EventArgs) Handles picMO.Click
        MultiOrder()
    End Sub

    Private Sub lblSO_Click(sender As Object, e As EventArgs) Handles lblSO.Click
        SingleOrder()
    End Sub

    Private Sub picSO_Click(sender As Object, e As EventArgs) Handles picSO.Click
        SingleOrder()
    End Sub

    '----- AA -----'
    Private Sub PicAA_Click(sender As Object, e As EventArgs) Handles PicAA.Click
        Acquisition()
    End Sub

    Private Sub lblAA_Click(sender As Object, e As EventArgs) Handles lblAA.Click
        Acquisition()
    End Sub

    '----- REPORT -----'

    Private Sub PicReport_Click(sender As Object, e As EventArgs) Handles PicReport.Click
        Report()
    End Sub

    Private Sub lblReport_Click(sender As Object, e As EventArgs) Handles lblReport.Click
        Report()
    End Sub

    '----- THEME SELECT -----' 

    Private Sub lblSetTheme_Click(sender As Object, e As EventArgs) Handles lblSetTheme.Click
        ThemeSelect()
    End Sub

    Private Sub picSetTheme_Click(sender As Object, e As EventArgs) Handles picSetTheme.Click
        ThemeSelect()
    End Sub

    Private Sub lblSetTheme1_Click(sender As Object, e As EventArgs) Handles lblSetTheme1.Click
        ThemeSelect()
    End Sub

    '----- EXIT -----'
    Public Sub CloseMe()
        If RadMessageBox.Show("Are you sure you want to close the program?",
                            "Close BAP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Environment.Exit(1)
        End If
    End Sub
    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        CloseMe()

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        CloseMe()
    End Sub

    Private Sub lblExit1_Click(sender As Object, e As EventArgs) Handles lblExit1.Click
        CloseMe()
    End Sub

    '----- LOGOUT -----'

    Private Sub lblLogout_Click_1(sender As Object, e As EventArgs)
        CloseMe()
    End Sub

    '----- CONVERSION -----'

    Private Sub picCurrency_Click(sender As Object, e As EventArgs) Handles picCurrency.Click
        Conversion()
    End Sub

    Private Sub lblCurrency_Click(sender As Object, e As EventArgs) Handles lblCurrency.Click
        Conversion()
    End Sub

    Private Sub lblCurrency1_Click(sender As Object, e As EventArgs) Handles lblCurrency1.Click
        Conversion()
    End Sub

    '----- USER -----'

    Private Sub picUser_Click(sender As Object, e As EventArgs) Handles picUser.Click
        ManageUserForm()
    End Sub

    Private Sub lblManUser_Click(sender As Object, e As EventArgs) Handles lblManUser.Click
        ManageUserForm()
    End Sub

    Private Sub lblManUser1_Click(sender As Object, e As EventArgs) Handles lblManUser1.Click
        ManageUserForm()
    End Sub

    '----- BUDGET SETTING -----'

    Private Sub picBS_Click(sender As Object, e As EventArgs) Handles picBS.Click
        BudgetSetting()
    End Sub

    Private Sub lblBS1_Click(sender As Object, e As EventArgs) Handles lblBS1.Click
        BudgetSetting()
    End Sub

    Private Sub lblBS2_Click(sender As Object, e As EventArgs) Handles lblBS2.Click
        BudgetSetting()
    End Sub

    Private Sub picAddField_Click(sender As Object, e As EventArgs) Handles picAddField.Click
        Try
            frmAddEtc.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub lblAddField_Click(sender As Object, e As EventArgs) Handles lblAddField.Click
        Try
            frmAddEtc.Show(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblAddField1_Click(sender As Object, e As EventArgs) Handles lblAddField1.Click
        Try
            frmAddEtc.Show(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub picUploadItem_Click(sender As Object, e As EventArgs) Handles picUploadItem.Click
        UploadItem()
    End Sub

    Private Sub lblUploadItem_Click(sender As Object, e As EventArgs) Handles lblUploadItem.Click
        UploadItem()
    End Sub

    Private Sub lblUploadItem1_Click(sender As Object, e As EventArgs) Handles lblUploadItem1.Click
        UploadItem()
    End Sub

    '----- DL from SAP -----'

    Private Sub picDLSap_Click(sender As Object, e As EventArgs) Handles picDLSap.Click
        DLSap()
    End Sub

    Private Sub lblDLSap_Click(sender As Object, e As EventArgs) Handles lblDLSap.Click
        DLSap()
    End Sub

    Private Sub lblDLSap2_Click(sender As Object, e As EventArgs) Handles lblDLSap2.Click
        DLSap()
    End Sub

    Private Sub picBC_Click_1(sender As Object, e As EventArgs) Handles picBC.Click
        CreateBudget()
    End Sub

    Private Sub lblBC_Click(sender As Object, e As EventArgs) Handles lblBC.Click
        Try
            FrmMajorBudget.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub picFB_Click_1(sender As Object, e As EventArgs) Handles picFB.Click
        FinalBudgetCreated()
    End Sub

    Private Sub lblFB_Click(sender As Object, e As EventArgs) Handles lblFB.Click
        FinalBudgetCreated()
    End Sub


    '-------------------------'
    '----------SUBS-----------'
    '-------------------------'

    Private Sub ManageUserForm()
        Try
            If lblAccesslvl.Text = "SUPERADMIN" Then
                frmUser.Show(Me)
            Else
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Your access level is not authorize for this transaction. Please contact MIS @ local 113 or 606 for inquiry. Thank you!", _
                                   "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub MangePRNotification()
        Try
            System.Diagnostics.Process.Start(Application.StartupPath + "\PR_Notification\PRNotification.exe")
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please contact MIS", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub DLSap()
        Try
            If lblAccesslvl.Text = "USER" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Your Access Level is not authorize to open this Module.", "Access Denied", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else

                Try
                    Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

                    conn.Open()

                    Dim Limit As Integer
                    Dim username As String
                    Dim myCmdLimit As New MySqlCommand
                    Dim myAdapter_Limit As New MySqlDataAdapter
                    Dim myData_Limit As New DataTable

                    myCmdLimit.Connection = conn
                    myCmdLimit.CommandText = "SELECT fldLimit, fldName FROM tblSettings WHERE fldProID = 1"
                    myAdapter_Limit.SelectCommand = myCmdLimit
                    myAdapter_Limit.Fill(myData_Limit)
                    Limit = myData_Limit.Rows(0).Item("fldLimit")
                    username = myData_Limit.Rows(0).Item("fldName")

                    If Limit = 1 Then
                        frmDLSAP.Show(Me)

                        Dim mycmdLimitUpdate As New MySqlCommand
                        mycmdLimitUpdate.Connection = conn
                        mycmdLimitUpdate.CommandText = "UPDATE tblSettings SET fldLimit = 0, fldName = '" & name & "' WHERE fldProID = 1"
                        mycmdLimitUpdate.ExecuteNonQuery()

                    Else
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("Sync-in Progress! " & Environment.NewLine & _
                                           "Current user: '" & username & "' " & Environment.NewLine & _
                                           "Please wait. Thank you.")
                    End If
                Catch ex As Exception
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                End Try
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CloseAll()

        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("Are you sure you want to close the program?",
                            "Close BAP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i

            Application.Exit()

        End If

    End Sub

    Private Sub GetTheme(ByVal root As Control)

        If lblTheme.Text = "" Then

        Else
            Me.BackColor = ColorTranslator.FromHtml(lblTheme.Text)
        End If

        If ColorTranslator.FromHtml(lblTheme.Text) = Color.White Then
            For Each ctrl As Control In root.Controls
                GetTheme(ctrl)
                If TypeOf ctrl Is Telerik.WinControls.UI.RadLabel Then
                    CType(ctrl, Telerik.WinControls.UI.RadLabel).ForeColor = Color.Black
                End If

            Next ctrl

        Else
            For Each ctrl As Control In root.Controls
                GetTheme(ctrl)
                If TypeOf ctrl Is Telerik.WinControls.UI.RadLabel Then
                    CType(ctrl, Telerik.WinControls.UI.RadLabel).ForeColor = Color.White
                End If

            Next ctrl

        End If
    End Sub

    Private Sub Budget()
        Try
            frmBudget.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub OrderPicker()
        Try
            frmOrderPicker.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Acquisition()
        Try
            frmAA.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub Report()
        Try
            frmGenReport.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub
    Private Sub ReportInvestment()
        Try
            FrmReportInvestment.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub UploadItem()
        Try
            frmUploadPicker.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub SetDataConn()
        Try
            frmSetDataConn.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub Conversion()
        Try
            frmConversion.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub ThemeSelect()
        Try
            FrmThemeSelector.Show(Me)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CreateBudget()
        Try
            frmBudgetCreation.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub FinalBudgetCreated()
        Try
            frmFinalBudgetCreated.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub MultiOrder()
        Try
            frmMultiOrder.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try

    End Sub

    Private Sub SingleOrder()
        Try
            frmOrder.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub ViewPO()
        Try
            FrmViewPO.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub CreatePO()
        Try
            FrmCPO.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub POChange()
        Try
            frmPOChange.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub ForcePO()
        If Zaji.IsFormOpen(FrmFPO) Then
            FrmFPO.Focus()
        Else
            FrmFPO.Show()
        End If
    End Sub

    Private Sub BudgetSetting()
        Try
            frmBudgetSetting.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub lblAcctngSync_Click(sender As Object, e As EventArgs) Handles lblAcctngSync.Click
        Try
            frmAcctngSync.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub imgUploadBud_Click(sender As Object, e As EventArgs) Handles imgUploadBud.Click
        Try
            FrmUploadBCSBudget.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub lblUploadBud_Click(sender As Object, e As EventArgs) Handles lblUploadBud.Click
        Try
            FrmUploadBCSBudget.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub imgPRInfo_Click(sender As Object, e As EventArgs) Handles imgPRInfo.Click
        MangePRNotification()
    End Sub

    Private Sub lblPRNotifi_Click(sender As Object, e As EventArgs) Handles lblPRNotifi.Click
        MangePRNotification()
    End Sub

    Private Sub imgInvestment_Click(sender As Object, e As EventArgs) Handles imgInvestment.Click
        Try
            FrmInvestment.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub lblInvestment_Click(sender As Object, e As EventArgs) Handles lblInvestment.Click, RadLabel1.Click
        Try
            FrmInvestment.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub lblInvReport_Click(sender As Object, e As EventArgs) Handles lblInvReport.Click
        ReportInvestment()
    End Sub

    Private Sub imgInvReport_Click(sender As Object, e As EventArgs) Handles imgInvReport.Click
        ReportInvestment()
    End Sub

    Private Sub imgRFQ_Click(sender As Object, e As EventArgs) Handles imgRFQ.Click
        RFQ()
    End Sub
    Private Sub RFQ()
        Try
            FrmRFQList.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub lblRFQ_Click(sender As Object, e As EventArgs) Handles lblRFQ.Click
        Try
            FrmRFQList.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub PicPO_Click(sender As Object, e As EventArgs) Handles PicPO.Click
        ViewPO()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnCreatePR.Click
        Try
            frmCreatePR.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub btnBudgetNew_Click(sender As Object, e As EventArgs) Handles btnBudgetNew.Click
        Try
            FrmMajorBudget.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub picBudSummary_Click(sender As Object, e As EventArgs) Handles picBudSummary.Click
        If Zaji.IsFormOpen(FrmRemBudLessPR) Then
            FrmRemBudLessPR.Focus()
        Else
            FrmRemBudLessPR.Show()
        End If
    End Sub

    Private Sub lblBudOld_Click(sender As Object, e As EventArgs) Handles lblBudOld.Click
        CreateBudget()
    End Sub

    Private Sub pbOldPR_Click(sender As Object, e As EventArgs) Handles pbOldPR.Click
        MultiOrder()
    End Sub

    Private Sub picInactive_Click(sender As Object, e As EventArgs) Handles picInactive.Click
        If Zaji.IsFormOpen(FrmInactiveSupp) Then
            FrmInactiveSupp.Focus()
        Else
            FrmInactiveSupp.Show()
        End If
    End Sub

    Private Sub lblInactive_Click(sender As Object, e As EventArgs) Handles lblInactive.Click
        If Zaji.IsFormOpen(FrmInactiveSupp) Then
            FrmInactiveSupp.Focus()
        Else
            FrmInactiveSupp.Show()
        End If
    End Sub

    Private Sub PicRate_Click(sender As Object, e As EventArgs) Handles PicRate.Click
        If Zaji.IsFormOpen(FrmRate) Then
            FrmRate.Focus()
        Else
            FrmRate.Show()
        End If
    End Sub

    Private Sub lblRate_Click(sender As Object, e As EventArgs) Handles lblRate.Click
        If Zaji.IsFormOpen(FrmRate) Then
            FrmRate.Focus()
        Else
            FrmRate.Show()
        End If
    End Sub

    Private Sub picItemNonRM_Click(sender As Object, e As EventArgs) Handles picItemNonRM.Click
        If Zaji.IsFormOpen(FrmItemNonRM) Then
            FrmItemNonRM.Focus()
        Else
            FrmItemNonRM.Show()
        End If
    End Sub

    Private Sub lblItemNonRM_Click(sender As Object, e As EventArgs) Handles lblItemNonRM.Click
        If Zaji.IsFormOpen(FrmItemNonRM) Then
            FrmItemNonRM.Focus()
        Else
            FrmItemNonRM.Show()
        End If
    End Sub

    Private Sub picSupp_Click(sender As Object, e As EventArgs) Handles picSupp.Click
        If Zaji.IsFormOpen(FrmSupplier) Then
            FrmSupplier.Focus()
        Else
            FrmSupplier.Show()
        End If
    End Sub

    Private Sub ImgSubBudget_Click(sender As Object, e As EventArgs) Handles ImgSubBudget.Click
        If Zaji.IsFormOpen(FrmExportSubBud) Then
            FrmExportSubBud.Focus()
        Else
            FrmExportSubBud.Show()
        End If
    End Sub

    Private Sub lblSubBudget_Click(sender As Object, e As EventArgs) Handles lblSubBudget.Click
        If Zaji.IsFormOpen(FrmExportSubBud) Then
            FrmExportSubBud.Focus()
        Else
            FrmExportSubBud.Show()
        End If
    End Sub

    Private Sub lblUploadUpdateSub_Click(sender As Object, e As EventArgs) Handles lblUploadUpdateSub.Click
        If Zaji.IsFormOpen(FrmUploadSubBud) Then
            FrmUploadSubBud.Focus()
        Else
            FrmUploadSubBud.Show()
        End If
    End Sub

    Private Sub imgUploadSubBudget_Click(sender As Object, e As EventArgs) Handles imgUploadSubBudget.Click
        If Zaji.IsFormOpen(FrmUploadSubBud) Then
            FrmUploadSubBud.Focus()
        Else
            FrmUploadSubBud.Show()
        End If
    End Sub

    Private Sub PicActivity_Click(sender As Object, e As EventArgs) Handles PicActivity.Click
        If Zaji.IsFormOpen(Activity) Then
            Activity.Focus()
        Else
            Activity.Show()
        End If
    End Sub

    Private Sub lblActivity_Click(sender As Object, e As EventArgs) Handles lblActivity.Click
        If Zaji.IsFormOpen(Activity) Then
            Activity.Focus()
        Else
            Activity.Show()
        End If
    End Sub

    Private Sub PicModel_Click(sender As Object, e As EventArgs) Handles PicModel.Click
        If Zaji.IsFormOpen(FrmModel) Then
            FrmModel.Focus()
        Else
            FrmModel.Show()
        End If
    End Sub

    Private Sub lblModel_Click(sender As Object, e As EventArgs) Handles lblModel.Click
        If Zaji.IsFormOpen(FrmModel) Then
            FrmModel.Focus()
        Else
            FrmModel.Show()
        End If
    End Sub

    Private Sub imgRFQSup_Click(sender As Object, e As EventArgs) Handles imgRFQSup.Click
        'If Zaji.IsFormOpen(FrmViewRFQSuppliers) Then
        '    FrmViewRFQSuppliers.Focus()
        'Else
        '    FrmViewRFQSuppliers.Show()
        'End If

        Try
            FrmViewRFQPur.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub imgSignatory_Click(sender As Object, e As EventArgs) Handles imgSignatory.Click
        If Zaji.IsFormOpen(FrmSignatory) Then
            FrmSignatory.Focus()
        Else
            FrmSignatory.Show()
        End If
    End Sub

    Private Sub txtRFQSup_Click(sender As Object, e As EventArgs) Handles txtRFQSup.Click
        Try
            FrmViewRFQPur.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub
End Class

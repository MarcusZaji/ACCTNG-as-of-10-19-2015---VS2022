
private void FrmCPO_Load(object sender, EventArgs e)
{
    // moveCtrl = New MoveControl(Me) '-----moveable form :)
    ACCTNG.My.MyProject.MyForms.frmsplash.busy();

    // ReadySupplierGrid()
    ReadyGrid();
    ReadyItemGrid();

    // GetSupSap()

    dtpMOrder.Value = DateAndTime.Today;
    dtpDelDate.Value = DateAndTime.Today;

    ddlSupSap.Text = "";
    txtCurrency.Text = "";
    txtVenCode.Text = "";

    GetSuppGrid();

    dtpMOrder.Value = DateAndTime.Today;
    dtpDelDate.Value = "01/01/0001";

    GetUser();

    btnCPO.Enabled = true;

    // disable right click
    RadContextMenu _blankContextMenu = new RadContextMenu();
    txtRemarks.RadContextMenu = _blankContextMenu;

    // ddlSupSap.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    // ddlSupSap.AutoCompleteDataSource = AutoCompleteSource.CustomSource
    // Me.txtRemarks.ContextMenu = New ContextMenu()

    var tblPalletInfoGrp = (from palletInfo in tblPalletInfo
                            group palletInfo by new
                            {
                                palletInfo.fldID
                            } into Group
                            let Keys = Group.Key
                            select new
                            {
                                Keys.fldID,
                                Group.First.fldCustomerID,
                                fldPalletNumber = string.Join(", ", Group.Select(x => x.fldPalletNumber)),
                                fldPalletCount = Group.Count()
                            }
).ToList();
}

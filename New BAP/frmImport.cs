using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections;
using System;
using Telerik.WinControls;
using System.Text.RegularExpressions;

namespace ACCTNG
{
    public partial class FrmImport
    {
        private DataTable dtSubBudget;
        private void FrmImport_Load(object sender, EventArgs e)
        {
            dtSubBudget = Zaji.dbSelect("SP_SelectAllBudget");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = rbeGetData.Value.ToString();

                System.Data.OleDb.OleDbConnection cn = default(System.Data.OleDb.OleDbConnection);
                System.Data.OleDb.OleDbDataAdapter cmd = default(System.Data.OleDb.OleDbDataAdapter);
                DataTable dt = new DataTable();

                cn = new System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=Excel 12.0;");

                cmd = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", cn);
                cn.Open();
                cmd.Fill(dt);
                cn.Close();

                globalVariables.dtImport = dt;
                if ((globalVariables.ImportSelect ?? "") == "SUB BUDGET")
                    ImportSubBudget();
                else
                {
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.SetThemeName("TelerikvisualStudio2012Light");
                RadMessageBox.Show("Please rename Excel sheet to Sheet1", "INFO", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }
        public void ImportSubBudget()
        {
            ACCTNG.My.MyProject.MyForms.FrmAddSubBudget.rgvList.DataSource = null;

            DataTable table = globalVariables.dtImport;

            IEnumerable Query = (from T0 in table.AsEnumerable()
                                 let _CheckifExist = CheckifExist(T0[1])
                                 select new
                                 {
                                     fldMajorRefNo = Regex.Replace(Strings.Trim(T0[0]), @"\s+", " ").ToString(),
                                     fldDept = Regex.Replace(Strings.Trim(T0[2]), @"\s+", " "),
                                     fldClass = Regex.Replace(Strings.Trim(T0[3]), @"\s+", " "),
                                     fldBudRefNum = Regex.Replace(Strings.Trim(T0[1]), @"\s+", " "),
                                     fldStat = Regex.Replace(Strings.Trim(T0[4]), @"\s+", " "),
                                     fldCurrency = Regex.Replace(Strings.Trim(T0[5]), @"\s+", " "),
                                     fldAmount = Interaction.IIf(!string.IsNullOrEmpty(T0[6]), T0[6], 0),
                                     fldYen = Interaction.IIf(!string.IsNullOrEmpty(T0[7]), T0[7], 0),
                                     fldProcess = Regex.Replace(Strings.Trim(T0[8]), @"\s+", " "),
                                     fldQTY = Interaction.IIf(!string.IsNullOrEmpty(T0[9]), T0[9], 0),
                                     fldUOM = Regex.Replace(Strings.Trim(T0[10]), @"\s+", " "),
                                     fldSOU = Convert.ToDateTime(T0[11]),
                                     fldDesc = Regex.Replace(Strings.Trim(T0[12]), @"\s+", " "),
                                     fldMBudgeted = Convert.ToDateTime(T0[13]),
                                     CheckifExist = _CheckifExist == null ? "doesn't exist" : "existing"
                                 }).ToList();
            ACCTNG.My.MyProject.MyForms.FrmAddSubBudget.rgvList.DataSource = Query;
        }
        public void CheckifExist(string SubBudget)
        {
            var Query = (from i in dtSubBudget.AsEnumerable()
                         where (Convert.ToString(i["fldBudRefNum"]) ?? "") == (SubBudget ?? "")
                         select Convert.ToString(i["fldBudRefNum"])).FirstOrDefault();

            return Convert.ToString(Query);
        }
    }
}

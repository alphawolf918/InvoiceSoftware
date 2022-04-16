using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmClientAdd : Form {
        private readonly frmCompanyAdd frmCompanyAdd = new frmCompanyAdd();

        public frmClientAdd() => InitializeComponent();

        private void frmClientAdd_Load(object sender, EventArgs e) {
            this.txtClientName.Text = "";
            this.txtClientAddress.Text = "";
            this.cbCompany.SelectedIndex = -1;
            this.cbCompany.Items.Clear();
            this.PopulateCompanyBox();
        }

        private void PopulateCompanyBox() {
            string strSQL = "SELECT [ID], [CompanyName] FROM [Company] ORDER BY [CompanyName] ASC;";
            using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                    while (sqlReader.Read()) {
                        cbCompany.Items.Add(Utils.SqlFormat(sqlReader["CompanyName"]));
                    }
                    sqlReader.Close();
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            string clientName = Utils.Nz(this.txtClientName.Text, "$CLIENT_NAME");
            string clientAddr = Utils.Nz(this.txtClientAddress.Text, "--");
            string clientComp = Utils.Nz(this.cbCompany.Text, "--");

            if (Utils.CheckIfEmptyOrNull(clientName, "Name")) {
                return;
            }

            string strCompSQL = "SELECT [ID] FROM [Company] WHERE [CompanyName] = @NAME;";
            strCompSQL = strCompSQL.Replace("@NAME", "'" + clientComp.Replace("'", "\'") + "'");

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [Clients] " +
                                "([NAME], [ADDRESS], [COMPANYID]) " +
                                "VALUES " +
                                "(@NAME, @ADDRESS, @COMP_ID);";

                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    long companyID = Utils.CLng(DBData.GetData(strCompSQL, "ID", conn));
                    sqlCmd.AddDynamicParam("@NAME", SqlDbType.NChar, clientName);
                    sqlCmd.AddDynamicParam("@ADDRESS", SqlDbType.Text, clientAddr);
                    sqlCmd.AddDynamicParam("@COMP_ID", SqlDbType.BigInt, companyID);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Client added successfully!");
                    }
                    frmMain.instance.RefreshListClient();
                    conn = null;
                    this.Visible = false;
                    this.txtClientName.Text = "";
                    this.txtClientAddress.Text = "";
                    this.cbCompany.SelectedIndex = -1;
                    this.Close();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void btnClientAddCompany_Click(object sender, EventArgs e) {
            frmCompanyAdd.ShowDialog();
            cbCompany.Items.Clear();
            this.PopulateCompanyBox();
        }
    }
}
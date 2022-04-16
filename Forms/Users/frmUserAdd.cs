using InvoiceSoftware.Forms.Businesses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmUserAdd : Form {
        private readonly frmRoleAdd frmAddRole = new frmRoleAdd();
        private readonly frmBusinessAdd frmAddBusiness = new frmBusinessAdd();

        public frmUserAdd() => InitializeComponent();

        private void frmUserAdd_Load(object sender, EventArgs e) {
            this.ClearEverything();
        }

        private void ClearEverything() {
            this.txtUserEmail.Text = "";
            this.txtPassword1.Text = "";
            this.txtPassword2.Text = "";
            this.cbRoles.SelectedIndex = -1;
            this.cbRoles.Items.Clear();
            this.chkLocked.Checked = false;
            this.PopulateRoleBox();
            this.PopulateBusinessBox();
        }

        private void PopulateRoleBox() {
            this.cbRoles.Items.Clear();
            this.cbRoles.PopulateData("SELECT [Role_Name] FROM [Roles] ORDER BY [Role_Name] ASC;", "Role_aName");
        }

        private void PopulateBusinessBox() {
            this.cbBusiness.Items.Clear();
            this.cbBusiness.PopulateData("SELECT [BusinessName] FROM [BusinessInfo] ORDER BY [BusinessName] ASC;", "BusinessName");
        }

        private void btnUserAddRole_Click(object sender, EventArgs e) {
            frmAddRole.ShowDialog();
            this.PopulateRoleBox();
        }

        private void btnAddUser_Click(object sender, EventArgs e) {
            string usrEmail = Utils.Nz(this.txtUserEmail.Text, "$USER_EMAIL");
            string usrPass1 = Security.HashSecureEncryption(this.txtPassword1.Text);
            string usrPass2 = Security.HashSecureEncryption(this.txtPassword2.Text);
            string usrRole = Utils.Nz(this.cbRoles.Text, "--");
            string usrBus = Utils.Nz(this.cbBusiness.Text, "--");
            bool usrLocked = (this.chkLocked.Checked) ? true : false;

            if (Utils.CheckIfEmptyOrNull(usrEmail, "Email")) {
                return;
            }

            if (Utils.CheckIfEmptyOrNull(usrPass1, "Password")) {
                return;
            }

            if (Utils.CheckIfEmptyOrNull(usrPass2, "Verify Password")) {
                return;
            }

            if (usrPass1 != usrPass2) {
                DialogBox.Error("Passwords do not match.");
                return;
            }

            string strRoleSQL = "SELECT [ID] FROM [Roles] WHERE [Role_Name] = @NAME;";
            strRoleSQL = strRoleSQL.Replace("@NAME", "'" + usrRole.Replace("'", "\'") + "'");

            string strBusinessSQL = "SELECT [ID] FROM [BusinessInfo] WHERE [BusisnessName] = @NAME;";
            strBusinessSQL = strBusinessSQL.Replace("@NAME", "'" + usrBus.Replace("'", "\'") + "'");

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [Users] " +
                                "([RoleID], [Email], [Password], [IS_LOCKED]) " +
                                "VALUES " +
                                "(@ROLE_ID, @EMAIL, @PASS, @LOCKED, @BUSINESS_ID);";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    long roleID = Utils.CLng(DBData.GetData(strRoleSQL, "ID", conn));
                    long businessID = Utils.CLng(DBData.GetData(strBusinessSQL, "ID", conn));
                    sqlCmd.AddDynamicParam("@ROLE_ID", SqlDbType.BigInt, ((roleID == 0) ? 3 : roleID));
                    sqlCmd.AddDynamicParam("@EMAIL", SqlDbType.NVarChar, usrEmail);
                    sqlCmd.AddDynamicParam("@PASS", SqlDbType.NVarChar, usrPass1);
                    sqlCmd.AddDynamicParam("@LOCKED", SqlDbType.Bit, usrLocked);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("User added sucessfully!");
                    }
                    frmUsersManage.instance.RefreshUserLists();
                    conn = null;
                    this.ClearEverything();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void frmUserAdd_FormClosing(object sender, FormClosingEventArgs e) {
            this.ClearEverything();
            this.Visible = false;
            e.Cancel = true;
        }

        private void btnAddBusiness_Click(object sender, EventArgs e) {
            frmAddBusiness.ShowDialog();
            this.PopulateBusinessBox();
        }
    }
}
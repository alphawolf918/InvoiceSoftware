using InvoiceSoftware.Forms.Businesses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmUserEdit : Form {
        private static long userID = -1;

        private readonly frmRoleAdd frmAddRole = new frmRoleAdd();
        private readonly frmBusinessAdd frmAddBusiness = new frmBusinessAdd();

        private string usrEmail;
        private string usrRole;
        private string usrBus;
        private bool usrLocked;
        private long usrRoleID;
        private long usrBusID;

        public frmUserEdit() => InitializeComponent();

        private void frmUserEdit_Load(object sender, EventArgs e) {
            if (userID > 0) {
                this.PopulateRoleBox();
                this.PopulateBusinessBox();
                string strSQL = "SELECT * FROM [VIEW_Users] WHERE [UserID] = @ID;";
                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, userID);
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.usrEmail = Utils.SqlFormat(sqlReader["Email"]);
                                this.usrRole = Utils.SqlFormat(sqlReader["RoleName"]);
                                this.usrBus = Utils.SqlFormat(sqlReader["Business"]);
                                this.usrRoleID = Utils.CLng(Utils.Nz(sqlReader["RoleID"].ToString(), "0"));
                                this.usrBusID = Utils.CLng(Utils.Nz(sqlReader["BusinessID"].ToString(), "0"));
                                this.usrLocked = (sqlReader["Locked"].ToString() == "Yes");
                            }
                            sqlReader.Close();
                            conn = null;
                            this.txtUserEmail.Text = this.usrEmail;
                            this.cbRoles.Text = this.usrRole;
                            this.cbBusiness.Text = this.usrBus;
                            this.chkLocked.Checked = this.usrLocked;
                        }
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty user ID.");
            }
        }

        private void PopulateRoleBox() {
            this.cbRoles.Items.Clear();
            this.cbRoles.PopulateData("SELECT [Role_Name] FROM [Roles] ORDER BY [Role_Name] ASC;", "Role_Name");
        }

        private void PopulateBusinessBox() {
            this.cbBusiness.Items.Clear();
            this.cbBusiness.PopulateData("SELECT [BusinessName] FROM [BusinessInfo] ORDER BY [BusinessName] ASC;", "BusinessName");
        }

        private void btnAddUser_Click(object sender, EventArgs e) {
            if (userID > 0) {
                string usEmail = Utils.SqlFormat(Utils.Nz(this.txtUserEmail.Text, "$USER_EMAIL"));
                string usRole = Utils.Nz(this.cbRoles.Text, "0");
                string usBus = Utils.Nz(this.cbBusiness.Text, "0");
                bool usLocked = (this.chkLocked.Checked);

                if (Utils.CheckIfEmptyOrNull(usEmail, "Email")) {
                    return;
                }

                string strRoleSQL = "SELECT [ID] FROM [Roles] WHERE [Role_Name] = @NAME;";
                strRoleSQL = strRoleSQL.Replace("@NAME", "'" + usRole.Replace("'", "\'") + "'");

                string strBusSQL = "SELECT [ID] FROM [BusinessInfo] WHERE [BusinessName] = @NAME;";
                strBusSQL = strBusSQL.Replace("@NAME", "'" + usBus.Replace("'", "\'") + "'");

                string strPassSQL = "";
                bool changePassword = false;

                if (this.txtPassword1.Text != "" ||
                    this.txtPassword2.Text != "") {
                    string pass1 = Security.HashSecureEncryption(this.txtPassword1.Text);
                    string pass2 = Security.HashSecureEncryption(this.txtPassword2.Text);

                    if (pass1 != pass2) {
                        DialogBox.Error("Password boxes do not match. To leave the Password the same, leave both boxes blank.");
                        return;
                    }

                    strPassSQL = "[Password] = @PASS, ";
                    changePassword = true;
                }

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [Users] SET    " +
                                     "[EMAIL] = @EMAIL,     ";

                    if (changePassword) {
                        strSQL += strPassSQL;
                    }

                    string strSQL2 = strSQL + "[RoleID] = @ROLE_ID,  " +
                                     "[BusinessID] = @BUSINESS_ID, " +
                                     "[IS_LOCKED] = @LOCKED " +
                                     "WHERE [ID] = @ID;";
                    long usRoleID = Utils.CLng(DBData.GetData(strRoleSQL, "ID", conn));
                    long usBusID = Utils.CLng(DBData.GetData(strBusSQL, "ID", conn));
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL2, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, userID);
                        sqlCmd.AddDynamicParam("@ROLE_ID", SqlDbType.BigInt, usRoleID);
                        sqlCmd.AddDynamicParam("@BUSINESS_ID", SqlDbType.BigInt, usBusID);
                        sqlCmd.AddDynamicParam("@EMAIL", SqlDbType.NVarChar, usEmail);
                        sqlCmd.AddDynamicParam("@LOCKED", SqlDbType.Bit, usLocked);
                        if (changePassword) {
                            string securePass = Security.HashSecureEncryption(this.txtPassword1.Text);
                            sqlCmd.AddDynamicParam("@PASS", SqlDbType.NVarChar, securePass);
                        }
                        sqlCmd.ExecuteNonQuery();
                        frmUsersManage.instance.RefreshUserLists();
                        if (AAS.showDialogsAfterSave) {
                            DialogBox.ChangesSaved();
                        }
                        conn = null;
                        this.Close();
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty user ID.");
            }
        }

        public static void SetUserID(long IDin) {
            userID = IDin;
        }

        private void ClearEverything() {
            this.txtUserEmail.Text = "";
            this.txtPassword1.Text = "";
            this.txtPassword2.Text = "";
            this.cbRoles.SelectedIndex = -1;
            this.cbBusiness.SelectedIndex = -1;
            this.cbRoles.Items.Clear();
            this.cbBusiness.Items.Clear();
            this.chkLocked.Checked = false;
        }

        private void frmUserEdit_FormClosing(object sender, FormClosingEventArgs e) {
            this.ClearEverything();
            e.Cancel = true;
            this.Visible = false;
        }

        private void btnUserAddRole_Click(object sender, EventArgs e) {
            frmAddRole.ShowDialog();
            this.PopulateRoleBox();
        }

        private void btnAddBusiness_Click(object sender, EventArgs e) {
            frmAddBusiness.ShowDialog();
            this.PopulateBusinessBox();
        }
    }
}
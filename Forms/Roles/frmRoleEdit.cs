using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmRoleEdit : Form {
        private static long roleID = -1;

        private readonly frmRoleAdd frmAddRole = new frmRoleAdd();

        string roleName;
        string roleText;

        public frmRoleEdit() => InitializeComponent();

        private void frmRoleEdit_Load(object sender, EventArgs e) {
            if (roleID > 0) {
                string strSQL = "SELECT * FROM [Roles] WHERE [ID] = @ID;";
                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.Parameters.Add("@ID", SqlDbType.BigInt);
                        sqlCmd.Parameters["@ID"].Value = roleID;
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.roleName = Utils.SqlFormat(sqlReader["Role_Name"]);
                                this.roleText = Utils.SqlFormat(sqlReader["Role_Text"]);
                            }
                            sqlReader.Close();
                            conn = null;
                            this.txtRoleName.Text = this.roleName;
                            this.txtRoleText.Text = this.roleText;
                        }
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty role ID.");
            }
        }

        private void btnEditRole_Click(object sender, EventArgs e) {
            if (roleID > 0) {
                string rlName = Utils.SqlFormat(Utils.Nz(this.txtRoleName.Text, "$ROLE_NAME"));
                string rlText = Utils.SqlFormat(this.txtRoleText.Text);

                if (Utils.CheckIfEmptyOrNull(rlName, "Name")) {
                    return;
                }

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [Roles] SET " +
                                    "[Role_Name] = @RNAME, " +
                                    "[Role_Text] = @RTEXT " +
                                    "WHERE [ID] = @ID;";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, roleID);
                        sqlCmd.AddDynamicParam("@NAME", SqlDbType.NVarChar, rlName);
                        sqlCmd.AddDynamicParam("@RTEXT", SqlDbType.Text, rlText);
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
                DialogBox.Error("Empty role ID.");
            }
        }

        public static void SetRoleID(long IDin) {
            roleID = IDin;
        }

        private void frmRoleEdit_FormClosing(object sender, FormClosingEventArgs e) {
            this.txtRoleName.Text = "";
            this.txtRoleText.Text = "";
            roleID = -1;
        }
    }
}
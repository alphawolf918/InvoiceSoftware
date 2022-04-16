using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using InvoiceSoftware;

namespace InvoiceSoftware.Forms {
    public partial class frmRoleAdd : Form {
        public frmRoleAdd() => InitializeComponent();

        private void frmRoleAdd_Load(object sender, EventArgs e) {
            this.txtRoleName.Text = "";
            this.txtRoleText.Text = "";
        }

        private void btnAddRole_Click(object sender, EventArgs e) {
            string roleName = Utils.SqlFormat(this.txtRoleName.Text);
            string roleText = Utils.SqlFormat(this.txtRoleText.Text);

            if (Utils.CheckIfEmptyOrNull(roleName, "Name")) {
                return;
            }

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [Roles] " +
                                "([Role_Name], [Role_Text]) " +
                                "VALUES " +
                                "(@RNAME, @RTEXT);";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    sqlCmd.AddDynamicParam("@NAME", SqlDbType.NVarChar, roleName);
                    sqlCmd.AddDynamicParam("@RTEXT", SqlDbType.Text, roleText);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Role added successfully!");
                    }
                    frmUsersManage.instance.RefreshUserLists();
                    conn = null;
                    this.txtRoleName.Text = "";
                    this.txtRoleText.Text = "";
                    this.Close();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }
    }
}
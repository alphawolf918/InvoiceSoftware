using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmUsersManage : Form {
        public static frmUsersManage instance;

        private readonly frmUserAdd frmAddUser = new frmUserAdd();
        private readonly frmRoleAdd frmAddRole = new frmRoleAdd();
        private readonly frmUserEdit frmEditUser = new frmUserEdit();
        private readonly frmRoleEdit frmEditRole = new frmRoleEdit();

        public frmUsersManage() => InitializeComponent();

        private void frmUsersManage_Load(object sender, EventArgs e) {
            instance = this;
            this.RefreshUserLists();
        }

        private void PopulateListUsers() {
            string strSQL = "SELECT * FROM [VIEW_Users] ORDER BY [Email] ASC;";
            try {
                SqlConnection conn = AAS.SQL_CONN;
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, conn)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "VIEW_Users");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            foreach (DataRow row in dataTbl.Rows) {
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["UserID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Email"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["RoleName"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Locked"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Forbidden"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Business"]));
                                this.lsUsers.Items.Add(viewItem);
                                if ((i % 2) == 0) {
                                    viewItem.BackColor = Color.Gainsboro;
                                }
                                i++;
                            }
                        }
                    }
                }
                Utils.SizeLastColumn(lv: this.lsUsers);
                this.btnUserEdit.Enabled = false;
                this.btnUserDelete.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void PopulateListRoles() {
            string strSQL = "SELECT * FROM [Roles] ORDER BY [Role_Name] ASC;";
            try {
                SqlConnection conn = AAS.SQL_CONN;
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, conn)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "Roles");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            foreach (DataRow row in dataTbl.Rows) {
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["ID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Role_Name"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Role_Text"]));
                                this.lsRoles.Items.Add(viewItem);
                                if ((i % 2) == 0) {
                                    viewItem.BackColor = Color.Gainsboro;
                                }
                                i++;
                            }
                        }
                    }
                }
                Utils.SizeLastColumn(lv: this.lsRoles);
                this.btnRoleEdit.Enabled = false;
                this.btnRoleDelete.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e) {
            this.RefreshUserLists();
        }

        private void btnRefreshRoles_Click(object sender, EventArgs e) {
            this.RefreshUserLists();
        }

        public void RefreshUserLists() {
            Utils.RemoveAllFromListView(this.lsUsers);
            Utils.RemoveAllFromListView(this.lsRoles);
            this.PopulateListUsers();
            this.PopulateListRoles();
        }

        private void btnExportToExcelUsers_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Users list to Excel?")) {
                Utils.ExportToExcel(this.lsUsers);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnExportToExcelRoles_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Roles list to Excel?")) {
                Utils.ExportToExcel(this.lsRoles);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e) => this.UserAdd(sender, e);

        private void btnRoleAdd_Click(object sender, EventArgs e) => this.RoleAdd(sender, e);

        private void btnUserEdit_Click(object sender, EventArgs e) => this.UserEdit(sender, e);

        private void btnRoleEdit_Click(object sender, EventArgs e) => this.RoleEdit(sender, e);

        private void btnUserDelete_Click(object sender, EventArgs e) => this.UserDelete(sender, e);

        private void btnRoleDelete_Click(object sender, EventArgs e) => this.RoleDelete(sender, e);

        private void UserAdd(object sender, EventArgs e) => frmAddUser.ShowDialog();

        private void RoleAdd(object sender, EventArgs e) => frmAddRole.ShowDialog();

        private void UserEdit(object sender, EventArgs e) {
            if (this.lsUsers.SelectedItems.Count > 0) {
                string strUserID = Utils.Nz(this.lsUsers.SelectedItems[0].Text, "-1");
                long userID = Utils.CLng(strUserID);
                bool enable = (userID > 0);

                if (enable) {
                    frmUserEdit.SetUserID(userID);
                    frmEditUser.ShowDialog();
                }
            }
        }

        private void RoleEdit(object sender, EventArgs e) {
            if (this.lsRoles.SelectedItems.Count > 0) {
                string strRoleID = Utils.Nz(this.lsRoles.SelectedItems[0].Text, "-1");
                long roleID = Utils.CLng(strRoleID);
                bool enable = (roleID > 0);

                if (enable) {
                    frmRoleEdit.SetRoleID(roleID);
                    frmEditRole.ShowDialog();
                }
            }
        }

        private void UserDelete(object sender, EventArgs e) {
            if (!DialogBox.Confirm("Are you sure you wish to delete this User from the list?")) {
                return;
            }

            string strUserID = Utils.Nz(this.lsUsers.SelectedItems[0].Text, "-1");
            long userID = Utils.CLng(strUserID);
            bool enable = (userID > 0);
            if (enable) {
                string strSQL = "DELETE FROM [USERS] WHERE [ID] = @ID;";
                try {
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, userID);
                        sqlCmd.ExecuteNonQuery();
                    }
                    DialogBox.Show("User deleted.");
                    this.RefreshUserLists();
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            }
        }

        private void RoleDelete(object sender, EventArgs e) {
            if (!DialogBox.Confirm("Are you sure you wish to delete this Role from the list?")) {
                return;
            }

            string strRoleID = Utils.Nz(this.lsRoles.SelectedItems[0].Text, "-1");
            long roleID = Utils.CLng(strRoleID);
            bool enable = (roleID > 0);
            if (enable) {
                string strSQL = "DELETE FROM [ROLES] WHERE [ID] = @ID;";
                try {
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, roleID);
                        sqlCmd.ExecuteNonQuery();
                    }
                    DialogBox.Show("Role deleted.");
                    this.RefreshUserLists();
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            }
        }

        private void lsUsers_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsUsers);
            btnUserEdit.Enabled = enable;
            btnUserDelete.Enabled = enable;
        }

        private void lsRoles_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsRoles);
            btnRoleEdit.Enabled = enable;
            btnRoleDelete.Enabled = enable;
        }

        private void lsUsers_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsUsers, sender, e);

        private void lsRoles_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsRoles, sender, e);

        private void lsUsers_DoubleClick(object sender, EventArgs e) => this.UserEdit(sender, e);

        private void lsRoles_DoubleClick(object sender, EventArgs e) => this.RoleEdit(sender, e);
    }
}
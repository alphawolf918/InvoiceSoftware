using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmChangePassword : Form {
        public frmChangePassword() => InitializeComponent();

        int failedAttempts = 0;
        int maxFailedAttempts = 3;

        private void btnChangePassword_Click(object sender, EventArgs e) {
            bool verify = true;
            string currentPass1 = Security.HashSecureEncryption(this.txtCurrentPass1.Text);
            string currentPass2 = Security.HashSecureEncryption(this.txtCurrentPass2.Text);

            if (currentPass1 != currentPass2) {
                DialogBox.Error("Current Password boxes do not match.");
                verify = false;
                return;
            }

            string strPassword = "";

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "SELECT [PASSWORD] FROM [USERS] WHERE [ID] = @ID;";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    sqlCmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    sqlCmd.Parameters["@ID"].Value = AAS.GetID();
                    strPassword = sqlCmd.ExecuteScalar().ToString();
                    conn = null;
                }
            } catch (SqlException ex) {
                verify = false;
                DialogBox.ErrorUnexpected(ex);
            }

            if (currentPass1 != strPassword) {
                this.failedAttempts++;
                DialogBox.Error("Password supplied for Current Password boxes does not match account password.\n\nFailed Attempts: " + this.failedAttempts + "/" + this.maxFailedAttempts);
                verify = false;
                if (this.failedAttempts >= this.maxFailedAttempts) {
                    AAS.LockAccount(AAS.GetID());
                    DialogBox.Error("Max failed attempts exceeded. This account is now locked. Please contact your adminstrator for assistance.");
                    Environment.Exit(1);
                }
            }

            string newPass1 = Security.HashSecureEncryption(this.txtNewPass1.Text);
            string newPass2 = Security.HashSecureEncryption(this.txtNewPass2.Text);

            if (newPass1 != newPass2) {
                DialogBox.Error("New Password boxes do not match.");
                verify = false;
                return;
            }

            if (verify) {
                string strSQL = "UPDATE [USERS] SET " +
                                "[PASSWORD] = @NEW_PASS " +
                                "WHERE [ID] = @ID;";
                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, AAS.GetID());
                        sqlCmd.AddDynamicParam("@NEW_PASS", SqlDbType.NVarChar, newPass1);
                        sqlCmd.ExecuteNonQuery();
                        DialogBox.Show("Password changed successfully! Please keep this in mind for the next time that you log in.");
                        conn = null;
                        this.Close();
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            }
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e) {
            this.txtCurrentPass1.Text = "";
            this.txtCurrentPass2.Text = "";
            this.txtNewPass1.Text = "";
            this.txtNewPass2.Text = "";
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
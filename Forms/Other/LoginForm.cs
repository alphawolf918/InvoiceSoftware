using IniParser;
using IniParser.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmLogin : Form {
        private const string conErrorStr = "Could not establish database connection: \n\n";
        private SqlConnection sqlConn;
        private bool secureLogin = false;
        private readonly string confSection = "CONNECTIONS";
        private string sqlDataSrc;
        private string sqlDb;
        private string sqlTrustConn;

        private int failedAttempts = 0;

        public frmLogin() => InitializeComponent();

        private void frmLogin_Load(object sender, EventArgs e) {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filePath: Directory.GetCurrentDirectory() + @"\config.ini");
            sqlDataSrc = data[confSection]["Server"];
            sqlDb = data[confSection]["Database"];
            sqlTrustConn = data[confSection]["TrustedConnection"];

Connect:
            string sqlConnStr = @"Server=" + sqlDataSrc + ";Database=" + sqlDb + ";Trusted_Connection=" + sqlTrustConn + ";";
            try {
                sqlConn = new SqlConnection {
                    ConnectionString = sqlConnStr
                };
                sqlConn.Open();
            } catch (SqlException ex) {
                DialogResult msgRes = DialogBox.AbortRetryIgnore(conErrorStr + ex.Message, "Log In Error");
                if (msgRes == DialogResult.Retry) {
                    goto Connect;
                } else if (msgRes == DialogResult.Ignore) {
                    goto End;
                } else {
                    DialogBox.Show("Application will now close.");
                    Environment.Exit(1);
                }
            }
End:
            ;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string strEmail = Utils.SqlFormat(this.txtEmail.Text);
            string strPass = Security.HashSecureEncryption(Utils.SqlFormat(this.txtPass.Text));
            string strSQL = "SELECT [PASSWORD] FROM [USERS] WHERE [EMAIL] = @EMAIL;";

            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, sqlConn)) {
                    sqlCmd.AddDynamicParam("@EMAIL", SqlDbType.NVarChar, strEmail);
                    object sqlScalar = sqlCmd.ExecuteScalar();
                    string dbPass;
                    if (sqlScalar != null) {
                        dbPass = sqlScalar.ToString();
                    } else {
                        dbPass = "";
                    }

                    if (this.CheckAccountForLock(strEmail)) {
                        DialogBox.Error("This account is locked. Please contact your administrator to unlock it.", "Locked Account");
                        this.secureLogin = false;
                        this.CloseForm();
                        return;
                    }

                    if (this.failedAttempts < 2) {
                        if (strPass != dbPass) {
                            DialogBox.Error("Incorrect email/password combination.", "Log In Error");
                            this.secureLogin = false;
                            this.failedAttempts++;
                        } else {
                            this.secureLogin = true;
                            AAS.SecureLogin = true;
                            this.CloseForm();
                            AAS.OpenSQLConnection();
                            AAS.SetID(strEmail);
                            if (Roles.GetRole() == ((long) RoleList.Forbidden)) {
                                DialogBox.Error("This account has been blocked from using this software.\n\n" +
                                                    "Please contact your administrator for assistance.", "Forbidden Account");
                                this.CloseConnection();
                                this.secureLogin = false;
                                return;
                            }
                            frmMain.instance.Focus();
                            frmMain.instance.tabMain.Visible = true;
                            frmMain.instance.PopulateListViews();
                            if (Roles.isAdmin()) {
                                frmMain.instance.adminSettingsToolStripMenuItem.Visible = true;
                                frmMain.instance.settingsToolStripMenuItem.Enabled = true;
                                frmMain.instance.settingsToolStripMenuItem.Visible = true;
                            }
                        }
                    } else {
                        this.secureLogin = false;
                        this.LockAccount(strEmail);
                    }
                }
            } catch (Exception ex) when (Utils.ExceptionFilter(ex)) {
                Utils.CommandError(ex);
            }
        }

        private void LockAccount(string strEmail) {
            if (this.CheckAccountForLock(strEmail)) {
                DialogBox.Error("This account is locked. Please contact your administrator to unlock it.", "Locked Account");
                return;
            }
            try {
                string strSQL = "UPDATE [USERS] SET [IS_LOCKED] = 1 WHERE [EMAIL] = @EMAIL;";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, sqlConn)) {
                    sqlCmd.AddDynamicParam("@EMAIL", SqlDbType.NVarChar, strEmail);
                    sqlCmd.ExecuteNonQuery();
                    DialogBox.Error("Too many failed log in attempts.\n\n" +
                                        "This account has been locked. Please contact your administrator to unlock it.");
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private bool CheckAccountForLock(string strEmail) {
            string strSQL = "SELECT [IS_LOCKED] FROM [USERS] WHERE [EMAIL] = @EMAIL;";
            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, sqlConn)) {
                    sqlCmd.AddDynamicParam("@EMAIL", SqlDbType.NVarChar, strEmail);
                    bool isLocked = Utils.CBool(sqlCmd.ExecuteScalar());
                    return isLocked;
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
            return false;
        }

        private void CloseConnection() {
            try {
                sqlConn.Close();
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            this.CloseConnection();
            if (!this.isSecureLogin()) {
                frmMain.instance.CloseProgram();
            }
            this.Visible = false;
            e.Cancel = true;
        }

        public void CloseForm() {
            this.CloseConnection();
            Dispose(true);
        }

        public bool isSecureLogin() => this.secureLogin;
    }
}
using IniParser;
using IniParser.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public class AAS {

        public const string PROGRAM_TITLE = "SIM Voice";

        #region Connection Settings
        public static string SQL_DATA_SRC = "";
        public static string SQL_DATA_DB = "";
        public static string SQL_CONN_STR = "";
        public static string SQL_TRUST_CONN = "";
        private const string SQL_CONN_ERR = "Could not establish database connection:\n\n";
        #endregion

        public static SqlConnection SQL_CONN;

        private static readonly string confSection = "CONNECTIONS";
        private static long USER_ID;

        #region All Application Settings
        public static int maxLoginAttempts { get; set; }
        public static bool showDialogsAfterSave { get; set; }
        #endregion

        public static bool SecureLogin { get; set; }

        public static void OpenSQLConnection() {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filePath: Directory.GetCurrentDirectory() + @"\config.ini");
            SQL_DATA_SRC = data[confSection]["Server"];
            SQL_DATA_DB = data[confSection]["Database"];
            SQL_TRUST_CONN = data[confSection]["TrustedConnection"];
            SQL_CONN_STR = @"Server=" + SQL_DATA_SRC + ";Database=" + SQL_DATA_DB + ";Trusted_Connection=" + SQL_TRUST_CONN + ";";

Connect:
            try {
                SQL_CONN = new SqlConnection {
                    ConnectionString = SQL_CONN_STR
                };
                SQL_CONN.Open();
            } catch (SqlException ex) {
                DialogResult msgRes = DialogBox.AbortRetryIgnore(SQL_CONN_ERR + ex.Message, "Connection Initialization Error");
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
            AAS.maxLoginAttempts = Utils.CInt(data["APPLICATION"]["MaxLoginAttempts"]);
            AAS.showDialogsAfterSave = Utils.CBool(data["APPLICATION"]["ShowDialogAfterSave"]);
        }

        public static string GetConfigFile() {
            return Directory.GetCurrentDirectory() + @"\config.ini";
        }

        public static void SetID(string strEmail) {
            string strSQL = "SELECT [ID] FROM [USERS] WHERE [EMAIL] = @EMAIL;";
            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, SQL_CONN)) {
                    sqlCmd.AddDynamicParam("@EMAIL", SqlDbType.NVarChar, Utils.SqlFormat(strEmail));
                    AAS.USER_ID = Utils.CLng(sqlCmd.ExecuteScalar().ToString());
                }
            } catch (SqlException ex) {
                DialogBox.Error("There was an error running this command:\n\n" + ex.Message);
            }
        }

        public static long GetID() {
            return AAS.USER_ID;
        }

        public static void EndSQLConnection() {
            try {
                if (!(SQL_CONN is null)) {
                    SQL_CONN.Close();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            } catch (NullReferenceException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public static void LockAccount(long userID) {
            if (AAS.CheckAccountForLock(userID)) {
                DialogBox.Error("This account is locked. Please contact your administrator to unlock it.", "Locked Account");
                return;
            }
            try {
                string strSQL = "UPDATE [USERS] SET [IS_LOCKED] = 1 WHERE [ID] = @ID;";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                    sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, userID);
                    sqlCmd.ExecuteNonQuery();
                    DialogBox.Error("Too many failed log in attempts.\n\n" +
                                         "This account has been locked. Please contact your administrator to unlock it.");
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public static bool CheckAccountForLock(long userID) {
            string strSQL = "SELECT [IS_LOCKED] FROM [USERS] WHERE [ID] = @ID;";
            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                    sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, userID);
                    bool isLocked = Utils.CBool(sqlCmd.ExecuteScalar());
                    return isLocked;
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
            return false;
        }
    }
}
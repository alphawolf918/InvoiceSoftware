using System;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceSoftware {
    public enum RoleList {
        Unknown = 0,
        Admin = 1,
        Developer = 2,
        User = 3,
        Forbidden = 4
    };

    public class Roles {
        public static long GetRole() {
            string strSQL = "SELECT [ROLEID] FROM [USERS] WHERE [ID] = @ID;";
            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                    sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, AAS.GetID());
                    return Utils.CLng(sqlCmd.ExecuteScalar());
                }
            } catch (SqlException ex) {
                DialogBox.Error("There was an error running this command:\n\n" + ex.Message);
            }
            return 0;
        }

        public static bool isAdmin() {
            return Roles.GetRole() == ((long) RoleList.Admin);
        }

        public static bool isForbidden() {
            return Roles.GetRole() == ((long) RoleList.Forbidden);
        }
    }
}
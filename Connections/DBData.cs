using System;
using System.Data;
using System.Data.SqlClient;

namespace InvoiceSoftware {
    public class DBData {
        public static object GetData(string strSQL, string fieldName, SqlConnection conn) {
            string result = null;
            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                        while (sqlReader.Read()) {
                            result = sqlReader[fieldName].ToString();
                        }
                        sqlReader.Close();
                    }
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
                result = null;
            }
            return result;
        }
    }
}
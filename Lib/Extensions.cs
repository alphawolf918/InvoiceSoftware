using InvoiceSoftware;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public static partial class Extensions {
    public static double[] ExtractDoubles(this string @this) => Regex.Matches(@this, @"[-]?\d+(\.\d+)?")
                                                                     .Cast<Match>()
                                                                     .Select(x => Convert.ToDouble(x.Value))
                                                                     .ToArray();

    public static Match Match(this String input, String @pattern) => Regex.Match(input, pattern);

    public static Match Match(this String input, String @pattern, RegexOptions options) => Regex.Match(input, pattern, options);

    public static bool RegExp_Like(this String input, String @pattern) => (input.Match(pattern).Success);

    public static bool RegExp_Like(this String input, String @pattern, RegexOptions options) => (input.Match(pattern, options).Success);

    public static string RegExp_Replace(this String input, String @pattern, String replaceVal) {
        string r = input;
        if (input.RegExp_Like(pattern)) {
            r = Regex.Replace(input, pattern, replaceVal);
        }
        return r;
    }

    public static void AddDynamicParam(this SqlCommand sqlCmd, String paramName, SqlDbType dbType, Object value) {
        sqlCmd.Parameters.Add(paramName, dbType);
        sqlCmd.Parameters[paramName].Value = value;
    }

    public static void PopulateData(this ComboBox cbBox, String strSQL, String fieldName) {
        SqlConnection conn = AAS.SQL_CONN;
        using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
            using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                while (sqlReader.Read()) {
                    cbBox.Items.Add(Utils.SqlFormat(sqlReader[fieldName]));
                }
                sqlReader.Close();
            }
            conn = null;
        }
    }
}
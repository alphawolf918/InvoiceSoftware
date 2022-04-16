using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmClientEdit : Form {
        private static long clientID = -1;
        private readonly frmCompanyAdd frmAddCompany = new frmCompanyAdd();

        private string clientName;
        private string clientAddr;
        private string clientComp;
        private long clientCompID;

        public frmClientEdit() => InitializeComponent();

        private void frmClientEdit_Load(object sender, EventArgs e) {
            if (clientID > 0) {
                this.cbCompany.Items.Clear();
                this.PopulateCompanyBox();
                string strSQL = "SELECT *                  " +
                                "FROM [VIEW_ClientInfo]    " +
                                "WHERE [ClientID] = @ID    " +
                                "ORDER BY [ClientName] ASC;";
                try {
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, clientID);
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.clientName = Utils.SqlFormat(sqlReader["ClientName"]);
                                this.clientAddr = Utils.SqlFormat(sqlReader["ClientAddress"]);
                                this.clientCompID = Utils.CLng(Utils.Nz(sqlReader["CompanyID"].ToString(), "0"));
                            }
                            sqlReader.Close();
                            string strSQL2 = "SELECT [CompanyName] FROM [VIEW_ClientInfo] WHERE [CompanyID] = @ID;";
                            strSQL2 = strSQL2.Replace("@ID", clientCompID.ToString());
                            clientComp = Utils.Nz(DBData.GetData(strSQL2, "CompanyName", AAS.SQL_CONN).ToString(), "");
                            this.txtClientName.Text = this.clientName;
                            this.txtClientAddress.Text = this.clientAddr;
                            this.cbCompany.Text = Utils.SqlFormat(this.clientComp);
                        }
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty client ID.");
            }
        }

        private void btnClientAddCompany_Click(object sender, EventArgs e) {
            frmAddCompany.ShowDialog();
            cbCompany.Items.Clear();
            this.PopulateCompanyBox();
        }

        public static void SetClientID(long IDin) {
            clientID = IDin;
        }

        private void btnEditClient_Click(object sender, EventArgs e) {
            if (clientID > 0) {
                string clName = Utils.SqlFormat(Utils.Nz(this.txtClientName.Text, "$CLIENT_NAME"));
                string clAddr = Utils.SqlFormat(Utils.Nz(this.txtClientAddress.Text, "--"));
                string clComp = Utils.Nz(this.cbCompany.Text, "0");

                if (Utils.CheckIfEmptyOrNull(clName, "Name")) {
                    return;
                }

                string strCompSQL = "SELECT [ID] FROM [Company] WHERE [CompanyName] = @NAME;";
                strCompSQL = strCompSQL.Replace("@NAME", "'" + clComp.Replace("'", "\'") + "'");

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [Clients] SET   " +
                                    "[Name] = @NAME,        " +
                                    "[Address] = @ADDRESS,  " +
                                    "[CompanyID] = @COMP_ID " +
                                    "WHERE [ID] = @ID;";
                    long clCompID = Utils.CLng(DBData.GetData(strCompSQL, "ID", conn));
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, clientID);
                        sqlCmd.AddDynamicParam("@COMP_ID", SqlDbType.BigInt, clCompID);
                        sqlCmd.AddDynamicParam("@NAME", SqlDbType.NChar, clName);
                        sqlCmd.AddDynamicParam("@ADDRESS", SqlDbType.Text, clAddr);
                        sqlCmd.ExecuteNonQuery();
                        frmMain.instance.RefreshListViews();
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
                DialogBox.Error("Empty client ID.");
            }
        }

        private void PopulateCompanyBox() {
            this.cbCompany.PopulateData("SELECT [CompanyName] FROM [Company] ORDER BY [CompanyName] ASC;", "CompanyName");
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmCompanyEdit : Form {
        private static long companyID = -1;

        private string companyName;
        private string companyAddress;
        private string companyPhone;
        private string companyWeb;

        public frmCompanyEdit() => InitializeComponent();

        private void frmCompanyEdit_Load(object sender, EventArgs e) {
            if (companyID > -1) {
                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "SELECT * FROM [VIEW_CompanyInfo]  WHERE [CompanyID] = @ID;";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, companyID);
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.companyName = Utils.SqlFormat(sqlReader["Name"]);
                                this.companyAddress = Utils.SqlFormat(sqlReader["Address"]);
                                this.companyPhone = Utils.SqlFormat(sqlReader["Phone Number"]);
                                this.companyWeb = Utils.SqlFormat(sqlReader["Web Site"]);
                            }
                            sqlReader.Close();
                            this.txtCompanyName.Text = companyName;
                            this.txtAddress.Text = companyAddress;
                            this.txtPhone.Text = companyPhone;
                            this.txtWeb.Text = companyWeb;
                            conn = null;
                        }
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty companyID.");
            }
        }

        private void btnEditCompany_Click(object sender, EventArgs e) {
            if (companyID > -1) {
                string companyName = Utils.Nz(this.txtCompanyName.Text, "$COMPANY_NAME");
                string companyAddr = Utils.Nz(this.txtAddress.Text, "--");
                string companyPhone = Utils.Nz(this.txtPhone.Text, "--");
                string companyWeb = Utils.Nz(this.txtWeb.Text, "--");

                if (Utils.CheckIfEmptyOrNull(companyName, "Name")) {
                    return;
                }

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [COMPANY] SET " +
                                    "[CompanyName] = @NAME, " +
                                    "[CompanyAddress] = @ADDRESS," +
                                    "[CompanyPhoneNr] = @PHONE, " +
                                    "[CompanyWebsite] = @WEB " +
                                    "WHERE [ID] = @ID;";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, companyID);
                        sqlCmd.AddDynamicParam("@NAME", SqlDbType.NChar, Utils.SqlFormat(companyName));
                        sqlCmd.AddDynamicParam("@ADDRESS", SqlDbType.Text, Utils.SqlFormat(companyAddr));
                        sqlCmd.AddDynamicParam("@PHONE", SqlDbType.NChar, Utils.SqlFormat(companyPhone));
                        sqlCmd.AddDynamicParam("@WEB", SqlDbType.NChar, Utils.SqlFormat(companyWeb));
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
                DialogBox.Error("Empty companyID.");
            }
        }

        public static void SetCompanyID(long IDin) {
            companyID = IDin;
        }
    }
}
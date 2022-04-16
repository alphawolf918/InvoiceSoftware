using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms.Businesses {
    public partial class frmBusinessEdit : Form {
        private static long businessID = -1;

        private string businessName;
        private string businessAddr;
        private string businessPhone;
        private string businessWeb;

        public frmBusinessEdit() => InitializeComponent();

        private void frmBusinessEdit_Load(object sender, EventArgs e) {
            if (businessID > 0) {
                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "SELECT * FROM [BusinessInfo] WHERE [ID] = @ID;";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, businessID);
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.businessName = Utils.SqlFormat(sqlReader["BusinessName"]);
                                this.businessAddr = Utils.SqlFormat(sqlReader["BusinessAddress"]);
                                this.businessPhone = Utils.SqlFormat(sqlReader["BusinessPhone"]);
                                this.businessWeb = Utils.SqlFormat(sqlReader["BusinessWebsite"]);
                            }
                            sqlReader.Close();
                            this.txtBusinessName.Text = businessName;
                            this.txtAddress.Text = businessAddr;
                            this.txtPhone.Text = businessPhone;
                            this.txtWeb.Text = businessWeb;
                            conn = null;
                        }
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty Business ID.");
                this.Close();
            }
        }

        private void btnEditBusiness_Click(object sender, EventArgs e) {
            if (businessID > 0) {
                string bsName = Utils.SqlFormat(Utils.Nz(this.txtBusinessName.Text, "$BUSINESS_NAME"));
                string bsAddr = Utils.SqlFormat(Utils.Nz(this.txtAddress.Text, "--"));
                string bsPhone = Utils.SqlFormat(Utils.Nz(this.txtPhone.Text, "--"));
                string bsWeb = Utils.SqlFormat(Utils.Nz(this.txtWeb.Text, "--"));

                if (Utils.CheckIfEmptyOrNull(bsName, "Business Name")) {
                    return;
                }

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [BusinessInfo] SET     " +
                                    "[BusinessName] = @NAME,       " +
                                    "[BusinessAddress] = @ADDRESS, " +
                                    "[BusinessPhone] = @PHONE,     " +
                                    "[BusinessWebsite] = @WEB      " +
                                    "WHERE [ID] = @ID;";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, businessID);
                        sqlCmd.AddDynamicParam("@NAME", SqlDbType.NVarChar, bsName);
                        sqlCmd.AddDynamicParam("@ADDRESS", SqlDbType.Text, bsAddr);
                        sqlCmd.AddDynamicParam("@PHONE", SqlDbType.NVarChar, bsPhone);
                        sqlCmd.AddDynamicParam("@WEB", SqlDbType.NVarChar, bsWeb);
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
                DialogBox.Error("Empty Business ID.");
                this.Close();
            }
        }

        public static void SetBusinessID(long IDin) {
            businessID = IDin;
        }
    }
}
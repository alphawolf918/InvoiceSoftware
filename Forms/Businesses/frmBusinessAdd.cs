using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms.Businesses {
    public partial class frmBusinessAdd : Form {
        public frmBusinessAdd() => InitializeComponent();

        private void btnAddBusiness_Click(object sender, EventArgs e) {
            string busName = Utils.SqlFormat(Utils.Nz(this.txtBusinessName.Text, "$BUSINESS_NAME"));
            string busAddr = Utils.SqlFormat(Utils.Nz(this.txtAddress.Text, "--"));
            string busPhone = Utils.SqlFormat(Utils.Nz(this.txtPhone.Text, "--"));
            string busWeb = Utils.SqlFormat(Utils.Nz(this.txtWeb.Text, "--"));

            if (Utils.CheckIfEmptyOrNull(busName, "Name")) {
                return;
            }

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [BusinessInfo] " +
                                "([BusinessName], [BusinessAddress], [BusinessPhone], [BusinessWebsite]) " +
                                "VALUES " +
                                "(@NAME, @ADDRESS, @PHONE, @WEB);";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    sqlCmd.AddDynamicParam("@NAME", SqlDbType.NVarChar, busName);
                    sqlCmd.AddDynamicParam("@ADDRESS", SqlDbType.Text, busAddr);
                    sqlCmd.AddDynamicParam("@PHONE", SqlDbType.NVarChar, busPhone);
                    sqlCmd.AddDynamicParam("@WEB", SqlDbType.NVarChar, busWeb);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Business added successfully!");
                    }
                    frmMain.instance.RefreshListViews();
                    conn = null;
                    this.Visible = false;
                    this.txtBusinessName.Text = "";
                    this.txtAddress.Text = "";
                    this.txtPhone.Text = "";
                    this.txtWeb.Text = "";
                    this.Close();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }
    }
}
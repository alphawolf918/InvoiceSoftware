using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmCompanyAdd : Form {
        public frmCompanyAdd() => InitializeComponent();

        private void btnAddCompany_Click(object sender, EventArgs e) {
            string cmpName = Utils.SqlFormat(Utils.Nz(this.txtCompanyName.Text, "$COMPANY_NAME"));
            string cmpAddr = Utils.SqlFormat(Utils.Nz(this.txtAddress.Text, "--"));
            string cmpPhone = Utils.SqlFormat(Utils.Nz(this.txtPhone.Text, "--"));
            string cmpWeb = Utils.SqlFormat(Utils.Nz(this.txtWeb.Text, "--"));

            if (Utils.CheckIfEmptyOrNull(cmpName, "Name")) {
                return;
            }

            SqlConnection conn = AAS.SQL_CONN;
            string strSQL = "INSERT INTO [Company] " +
                            "([COMPANYNAME], [COMPANYADDRESS], [COMPANYPHONENR], [COMPANYWEBSITE]) " +
                            "VALUES " +
                            "(@NAME, @ADDRESS, @PHONE, @WEB);";

            try {
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    sqlCmd.AddDynamicParam("@NAME", SqlDbType.NChar, cmpName);
                    sqlCmd.AddDynamicParam("@ADDRESS", SqlDbType.Text, cmpAddr);
                    sqlCmd.AddDynamicParam("@PHONE", SqlDbType.NChar, cmpPhone);
                    sqlCmd.AddDynamicParam("@WEB", SqlDbType.NChar, cmpWeb);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Company added successfully!");
                    }
                    frmMain.instance.RefreshListViews();
                    conn = null;
                    this.Visible = false;
                    this.txtCompanyName.Text = "";
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
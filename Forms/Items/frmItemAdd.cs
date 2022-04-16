using InvoiceSoftware.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmItemAdd : Form {
        private frmCompanyAdd frmCompanyAdd = new frmCompanyAdd();
        private frmItemGroupAdd frmAddItemGroup = new frmItemGroupAdd();

        public frmItemAdd() => InitializeComponent();

        private void frmItemAdd_Load(object sender, EventArgs e) {
            this.txtItemName.Text = "";
            this.txtDescription.Text = "";
            this.txtPrice.Text = "";
            this.txtDiscount.Text = "";
            this.txtItemColor.Text = "1694498815";
            this.txtItemColor.ForeColor = Color.FromArgb(1694498815);
            this.cbCompany.SelectedIndex = -1;
            this.cbItemGroup.SelectedIndex = -1;
            this.cbCompany.Items.Clear();
            this.cbItemGroup.Items.Clear();
            this.PopulateCompanyBox();
            this.PopulateItemGroupBox();
        }

        private void PopulateCompanyBox() {
            string strSQL = "SELECT [ID], [CompanyName] FROM [Company] ORDER BY [CompanyName] ASC;";
            using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                    while (sqlReader.Read()) {
                        this.cbCompany.Items.Add(Utils.SqlFormat(sqlReader["CompanyName"]));
                    }
                    sqlReader.Close();
                }
            }
        }

        private void PopulateItemGroupBox() {
            string strSQL = "SELECT [ID], [GroupName] FROM [ItemGroups] ORDER BY [GroupName] ASC;";
            using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                    while (sqlReader.Read()) {
                        this.cbItemGroup.Items.Add(Utils.SqlFormat(sqlReader["GroupName"]));
                    }
                    sqlReader.Close();
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            string itemName = Utils.SqlFormat(Utils.Nz(this.txtItemName.Text, "$ITEM_NAME"));
            string itemText = Utils.SqlFormat(Utils.Nz(this.txtDescription.Text, "N/A"));
            double itemPrice = Utils.CDbl(Utils.Nz(this.txtPrice.Text, "0.00"));
            double itemDiscount = Utils.CDbl(Utils.Nz(this.txtDiscount.Text, "0.00"));
            long itemColor = Utils.CLng(Utils.Nz(this.txtItemColor.Text, "16777215"));
            string itemComp = Utils.SqlFormat(Utils.Nz(this.cbCompany.Text, "--"));
            string itemGrp = Utils.SqlFormat(Utils.Nz(this.cbItemGroup.Text, "--"));

            if (Utils.CheckIfEmptyOrNull(itemName, "Name")) {
                return;
            }

            string strCompSQL = "SELECT [ID] FROM [Company] WHERE [CompanyName] = @NAME;";
            strCompSQL = strCompSQL.Replace("@NAME", "'" + itemComp.Replace("'", "\'") + "'");

            string itemGrpSQL = "SELECT [ID] FROM [ItemGroups] WHERE [GroupName] = @NAME;";
            itemGrpSQL = itemGrpSQL.Replace("@NAME", "'" + itemGrp.Replace("'", "\'") + "'");

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [Items] " +
                                "([CompanyID], [ItemName], [ItemText], [ItemPrice], [ItemDiscount], [ItemColor], [ItemGroupID]) " +
                                "VALUES " +
                                "(@COMPANY_ID, @NAME, @DESCRIPTION, @PRICE, @DISCOUNT, @COLOR, @GROUP_ID);";

                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    long companyID = Utils.CLng(DBData.GetData(strCompSQL, "ID", conn));
                    long groupID = Utils.CLng(DBData.GetData(itemGrpSQL, "ID", conn));
                    sqlCmd.AddDynamicParam("@COMPANY_ID", SqlDbType.BigInt, companyID);
                    sqlCmd.AddDynamicParam("@GROUP_ID", SqlDbType.BigInt, groupID);
                    sqlCmd.AddDynamicParam("@NAME", SqlDbType.NVarChar, itemName);
                    sqlCmd.AddDynamicParam("@DESCRIPTION", SqlDbType.Text, itemText);
                    sqlCmd.AddDynamicParam("@PRICE", SqlDbType.Money, itemPrice);
                    sqlCmd.AddDynamicParam("@DISCOUNT", SqlDbType.Money, itemDiscount);
                    sqlCmd.AddDynamicParam("@COLOR", SqlDbType.BigInt, itemColor);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Item added successfully!");
                    }
                    frmMain.instance.RefreshListViews();
                    conn = null;
                    this.Visible = false;
                    this.txtItemName.Text = "";
                    this.txtDescription.Text = "";
                    this.txtPrice.Text = "";
                    this.txtDiscount.Text = "";
                    this.txtItemColor.Text = "16777215";
                    this.cbCompany.SelectedIndex = -1;
                    this.cbItemGroup.SelectedIndex = -1;
                    this.Close();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void btnItemAddCompany_Click(object sender, EventArgs e) {
            frmCompanyAdd.ShowDialog();
            cbCompany.Items.Clear();
            this.PopulateCompanyBox();
        }

        private void btnAddItemGroup_Click(object sender, EventArgs e) {
            frmAddItemGroup.ShowDialog();
            cbItemGroup.Items.Clear();
            this.PopulateItemGroupBox();
        }

        private void btnChooseColor_Click(object sender, EventArgs e) {
            this.itemColorDialog.ShowDialog();
            Color clr = itemColorDialog.Color;
            if (clr == null) {
                clr = Color.White;
            }
            this.txtItemColor.Text = clr.ToArgb().ToString();
            this.txtItemColor.BackColor = clr;
            this.txtItemColor.ForeColor = clr;
        }
    }
}
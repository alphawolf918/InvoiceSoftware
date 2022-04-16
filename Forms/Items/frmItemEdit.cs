using InvoiceSoftware.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmItemEdit : Form {
        private static long itemID = -1;

        private readonly frmCompanyAdd frmAddCompany = new frmCompanyAdd();
        private readonly frmItemGroupAdd frmAddItemGroup = new frmItemGroupAdd();

        private string itemName;
        private string itemText;
        private string itemCompany;
        private string itemGroup;
        private double itemPrice;
        private double itemDiscount;
        private long itemColor;
        private long companyID;
        private long groupID;

        public frmItemEdit() => InitializeComponent();

        private void frmItemEdit_Load(object sender, EventArgs e) {
            if (itemID > 0) {
                this.cbCompany.Items.Clear();
                this.cbItemGroup.Items.Clear();
                this.PopulateCompanyBox();
                this.PopulateItemGroupBox();
                string strSQL = "SELECT * FROM [VIEW_Items] WHERE [ItemID] = @ID;";
                try {
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, itemID);
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.itemName = Utils.SqlFormat(sqlReader["Name"]);
                                this.itemText = Utils.SqlFormat(sqlReader["Description"]);
                                this.itemCompany = Utils.SqlFormat(sqlReader["Company"]);
                                this.itemPrice = Utils.CDbl(sqlReader["Price"]);
                                this.itemDiscount = Utils.CDbl(sqlReader["Discount"]);
                                this.itemColor = Utils.CLng(sqlReader["Color"]);
                                this.companyID = Utils.CLng(Utils.Nz(sqlReader["CompanyID"].ToString(), "0"));
                                this.groupID = Utils.CLng(Utils.Nz(sqlReader["GroupID"].ToString(), "0"));
                                this.itemGroup = Utils.SqlFormat(sqlReader["ItemGroup"]);
                            }
                            sqlReader.Close();

                            Color clr = Color.FromArgb(Utils.CInt(this.itemColor));
                            if (clr == null) {
                                clr = Color.White;
                            }

                            this.txtItemName.Text = this.itemName;
                            this.txtDescription.Text = this.itemText;
                            this.cbCompany.Text = Utils.SqlFormat(this.itemCompany);
                            this.cbItemGroup.Text = this.itemGroup;
                            this.txtPrice.Text = this.itemPrice.ToString();
                            this.txtDiscount.Text = this.itemDiscount.ToString();
                            this.txtItemColor.Text = this.itemColor.ToString();
                            this.txtItemColor.ForeColor = clr;
                            this.txtItemColor.BackColor = clr;
                        }
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty item ID.");
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e) {
            if (itemID > 0) {
                string itName = Utils.SqlFormat(Utils.Nz(this.txtItemName.Text, "$ITEM_NAME"));
                string itTxt = Utils.SqlFormat(Utils.Nz(this.txtDescription.Text, "N/A"));
                string itComp = Utils.SqlFormat(Utils.Nz(this.cbCompany.Text, "--"));
                string itGroup = Utils.SqlFormat(Utils.Nz(this.cbItemGroup.Text, "--"));
                double itPrice = Utils.CDbl(Utils.Nz(this.txtPrice.Text, "0"));
                double itDiscount = Utils.CDbl(Utils.Nz(this.txtDiscount.Text, "0"));
                long itColor = Utils.CLng(this.txtItemColor.Text);

                if (Utils.CheckIfEmptyOrNull(itName, "Name")) {
                    return;
                }

                string strCompSQL = "SELECT [ID] FROM [Company] WHERE [CompanyName] = @NAME;";
                strCompSQL = strCompSQL.Replace("@NAME", "'" + itComp.Replace("'", "\'") + "'");

                string itemGrpSQL = "SELECT [ID] FROM [ItemGroups] WHERE [GroupName] = @NAME;";
                itemGrpSQL = itemGrpSQL.Replace("@NAME", "'" + itGroup.Replace("'", "\'") + "'");

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [Items] SET          " +
                                    "[ItemName] = @NAME,         " +
                                    "[ItemText] = @DESCRIPTION,  " +
                                    "[ItemPrice] = @PRICE,       " +
                                    "[ItemDiscount] = @DISCOUNT, " +
                                    "[ItemColor] = @COLOR,       " +
                                    "[CompanyID] = @COMPANY_ID,  " +
                                    "[ItemGroupID] = @GROUP_ID   " +
                                    "WHERE [ID] = @ID;";
                    long itCompID = Utils.CLng(DBData.GetData(strCompSQL, "ID", conn));
                    long itGrpID = Utils.CLng(DBData.GetData(itemGrpSQL, "ID", conn));
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        double price = Utils.CDbl(Utils.Nz(itPrice.ToString(), "0"));
                        double discount = Utils.CDbl(Utils.Nz(itDiscount.ToString(), "0"));
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, itemID);
                        sqlCmd.AddDynamicParam("@COMPANY_ID", SqlDbType.BigInt, itCompID);
                        sqlCmd.AddDynamicParam("@GROUP_ID", SqlDbType.BigInt, itGrpID);
                        sqlCmd.AddDynamicParam("@COLOR", SqlDbType.BigInt, itColor);
                        sqlCmd.AddDynamicParam("@NAME", SqlDbType.NVarChar, itName);
                        sqlCmd.AddDynamicParam("@DESCRIPTION", SqlDbType.Text, itTxt);
                        sqlCmd.AddDynamicParam("@PRICE", SqlDbType.Money, price);
                        sqlCmd.AddDynamicParam("@DISCOUNT", SqlDbType.Money, discount);
                        sqlCmd.ExecuteNonQuery();
                        frmMain.instance.RefreshListViews();
                        if (AAS.showDialogsAfterSave) {
                            DialogBox.ChangesSaved();
                        }
                        conn = null;
                        this.Visible = false;
                        this.Close();
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty Item ID.");
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e) {
            this.itemColorDialog.ShowDialog();
            Color clr = itemColorDialog.Color;
            this.txtItemColor.Text = clr.ToArgb().ToString();
            this.txtItemColor.BackColor = clr;
            this.txtItemColor.ForeColor = clr;
        }

        private void btnItemAddCompany_Click(object sender, EventArgs e) {
            frmAddCompany.ShowDialog();
            cbCompany.Items.Clear();
            this.PopulateCompanyBox();
        }

        private void btnAddItemGroup_Click(object sender, EventArgs e) {
            frmAddItemGroup.ShowDialog();
            cbItemGroup.Items.Clear();
            this.PopulateItemGroupBox();
        }

        public static void SetItemID(long IDin) {
            itemID = IDin;
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
    }
}
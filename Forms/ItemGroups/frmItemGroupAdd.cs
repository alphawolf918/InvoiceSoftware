using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmItemGroupAdd : Form {
        public frmItemGroupAdd() => InitializeComponent();

        private void frmItemGroupAdd_Load(object sender, EventArgs e) {
            this.txtItemGroupName.Text = "";
            this.txtItemGroupText.Text = "";
            this.txtItemGroupColor.Text = "1694498815";
            this.txtItemGroupColor.ForeColor = Color.FromArgb(1694498815);
        }

        private void btnAddItemGroup_Click(object sender, EventArgs e) {
            string itemGrpName = Utils.Nz(Utils.SqlFormat(this.txtItemGroupName.Text), "$ITEM_GRP_NAME");
            string itemGrpText = Utils.SqlFormat(Utils.SqlFormat(this.txtItemGroupText.Text));
            long itemGrpColor = Utils.CLng(Utils.Nz(this.txtItemGroupColor.Text, "16777215"));

            if (Utils.CheckIfEmptyOrNull(itemGrpName, "Group Name")) {
                return;
            }

            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [ItemGroups] " +
                                "([GroupName], [GroupText], [GroupColor]) " +
                                "VALUES " +
                                "(@NAME, @TXT, @COLOR);";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    sqlCmd.AddDynamicParam("@NAME", SqlDbType.NChar, itemGrpName);
                    sqlCmd.AddDynamicParam("@TXT", SqlDbType.Text, itemGrpText);
                    sqlCmd.AddDynamicParam("@COLOR", SqlDbType.BigInt, itemGrpColor);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Item Group added successfully! Associate it with Items on the Products & Items page.");
                    }
                    frmMain.instance.RefreshListViews();
                    conn = null;
                    this.Visible = false;
                    this.txtItemGroupName.Text = "";
                    this.txtItemGroupText.Text = "";
                    this.txtItemGroupColor.Text = "1694498815";
                    this.txtItemGroupColor.ForeColor = Color.FromArgb(1694498815);
                    this.Close();
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e) {
            this.itemGroupColorDialog.ShowDialog();
            Color clr = itemGroupColorDialog.Color;
            if (clr == null) {
                clr = Color.White;
            }
            this.txtItemGroupColor.Text = clr.ToArgb().ToString();
            this.txtItemGroupColor.BackColor = clr;
            this.txtItemGroupColor.ForeColor = clr;
        }
    }
}
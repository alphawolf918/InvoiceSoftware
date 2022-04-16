using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public partial class frmItemGroupEdit : Form {

        private static long itemGrpID = -1;
        private string grpName;
        private string grpTxt;
        private long grpColor;

        public frmItemGroupEdit() => InitializeComponent();

        private void frmItemGroupEdit_Load(object sender, EventArgs e) {
            if (itemGrpID > 0) {
                this.txtItemGroupName.Text = "";
                this.txtItemGroupText.Text = "";
                this.txtItemGroupColor.Text = "1694498815";
                this.txtItemGroupColor.ForeColor = Color.FromArgb(1694498815);

                string strSQL = "SELECT * FROM [ItemGroups] WHERE [ID] = @ID;";
                SqlConnection conn = AAS.SQL_CONN;
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    sqlCmd.Parameters.Add("@ID", SqlDbType.BigInt);
                    sqlCmd.Parameters["@ID"].Value = itemGrpID;

                    using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                        while (sqlReader.Read()) {
                            this.grpName = Utils.SqlFormat(sqlReader["GroupName"]);
                            this.grpTxt = Utils.SqlFormat(sqlReader["GroupText"]);
                            this.grpColor = Utils.CLng(sqlReader["GroupColor"]);
                        }
                        sqlReader.Close();

                        Color clr = Color.FromArgb(Utils.CInt(this.grpColor));
                        if (clr == null) {
                            clr = Color.White;
                        }

                        this.txtItemGroupName.Text = this.grpName;
                        this.txtItemGroupText.Text = this.grpTxt;
                        this.txtItemGroupColor.Text = this.grpColor.ToString();
                        this.txtItemGroupColor.ForeColor = clr;
                        this.txtItemGroupColor.BackColor = clr;
                    }
                }
            } else {
                DialogBox.Error("Empty Item Group ID.");
            }
        }

        public static void SetID(long IDin) {
            itemGrpID = IDin;
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

        private void btnEditItemGroup_Click(object sender, EventArgs e) {
            if (itemGrpID > 0) {
                string itemGrpName = Utils.Nz(Utils.SqlFormat(this.txtItemGroupName.Text), "$ITEM_GRP_NAME");
                string itemGrpText = Utils.SqlFormat(Utils.SqlFormat(this.txtItemGroupText.Text));
                long itemGrpColor = Utils.CLng(Utils.Nz(this.txtItemGroupColor.Text, "16777215"));

                if (Utils.CheckIfEmptyOrNull(itemGrpName, "Group Name")) {
                    return;
                }

                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    string strSQL = "UPDATE [ItemGroups] SET " +
                                    "[GroupName] = @NAME,    " +
                                    "[GroupText] = @TXT,     " +
                                    "[GroupColor] = @COLOR   " +
                                    "WHERE [ID] = @ID;";
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, itemGrpID);
                        sqlCmd.AddDynamicParam("@NAME", SqlDbType.NChar, itemGrpName);
                        sqlCmd.AddDynamicParam("@TXT", SqlDbType.Text, itemGrpText);
                        sqlCmd.AddDynamicParam("@COLOR", SqlDbType.BigInt, itemGrpColor);
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
                DialogBox.Error("Empty Item Group ID.");
            }
        }
    }
}
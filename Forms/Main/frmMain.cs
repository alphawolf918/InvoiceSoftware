using InvoiceSoftware.Forms;
using InvoiceSoftware.Forms.Businesses;
using InvoiceSoftware.Forms.Settings;
using InvoiceSoftware.Lib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace InvoiceSoftware {
    public partial class frmMain : Form {
        public static frmMain instance;

        private readonly frmLogin loginForm = new frmLogin();
        private readonly frmCompanyAdd frmCompAdd = new frmCompanyAdd();
        private readonly frmClientAdd frmClientAdd = new frmClientAdd();
        private readonly frmItemGroupAdd frmAddItemGroup = new frmItemGroupAdd();
        private readonly frmItemAdd frmItemAdd = new frmItemAdd();
        private readonly frmInvoiceAdd frmInvoiceAdd = new frmInvoiceAdd();
        private readonly frmBusinessAdd frmAddBusiness = new frmBusinessAdd();
        private readonly frmCompanyEdit frmCompEdit = new frmCompanyEdit();
        private readonly frmClientEdit frmEditClient = new frmClientEdit();
        private readonly frmItemEdit frmItemEdit = new frmItemEdit();
        private readonly frmItemGroupEdit frmEditItemGroup = new frmItemGroupEdit();
        private readonly frmInvoiceEdit frmEditInvoice = new frmInvoiceEdit();
        private readonly frmBusinessEdit frmEditBusiness = new frmBusinessEdit();
        private readonly frmChangePassword frmPassChange = new frmChangePassword();
        private readonly frmUsersManage frmManageUsers = new frmUsersManage();
        private readonly frmFinanceCalculator frmFinanceCalc = new frmFinanceCalculator();
        private readonly frmAboutBox frmAbout = new frmAboutBox();
        private readonly frmSettings frmSettings = new frmSettings();

        public frmMain() => InitializeComponent();

        private void frmMain_Load(object sender, EventArgs e) {
            instance = this;
            Utils.UpdateStatusBar("Verifying credentials...");
            loginForm.ShowDialog();
            if (!AAS.SecureLogin) {
                DialogBox.Error("Insecure log in detected. Program will now exit.");
                this.CloseProgram();
            }
            AAS.maxLoginAttempts = Properties.Settings.Default.MaxLoginAttempts;
            Utils.UpdateStatusBar("Ready");
        }

        public void PopulateListViews() {
            Utils.UpdateStatusBar("Populating lists...");
            this.PopulateListCompany();
            this.PopulateListClient();
            this.PopulateListItem();
            this.PopulateListItemGroups();
            this.PopulateListInvoices();
            this.PopulateListBusiness();
            Utils.UpdateStatusBar("Ready");
        }

        public void ResizeListViews() {
            Utils.UpdateStatusBar("Resizing lists...");
            Utils.SizeLastColumn(lv: this.lsCompanies);
            Utils.SizeLastColumn(lv: this.lsClients);
            Utils.SizeLastColumn(lv: this.lsItems);
            Utils.SizeLastColumn(lv: this.lsItemGroups);
            Utils.SizeLastColumn(lv: this.lsInvoices);
            Utils.SizeLastColumn(lv: this.lsBusinesses);
            Utils.UpdateStatusBar("Ready");
        }

        public void RefreshListViews() {
            Utils.UpdateStatusBar("Refreshing lists...");
            this.RefreshListCompany();
            this.RefreshListClient();
            this.RefreshListItem();
            this.RefreshListItemGroups();
            this.RefreshListInvoices();
            this.RefreshListBusinesses();
            Utils.UpdateStatusBar("Ready");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.CloseProgram();

        public void CloseProgram() {
            try {
                AAS.EndSQLConnection();
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
            Dispose(true);
            Application.Exit();
        }

        private void btnCompanyAdd_Click(object sender, EventArgs e) => this.CompanyAdd(sender, e);

        private void btnCompanyEdit_Click(object sender, EventArgs e) => this.CompanyEdit(sender, e);

        private void btnCompanyDelete_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Are you sure you want to delete this company from the list?")) {
                this.CompanyDelete(sender, e);
            }
        }

        private void CompanyAdd(object sender, EventArgs e) => frmCompAdd.ShowDialog();

        private void ClientAdd(object sender, EventArgs e) => frmClientAdd.ShowDialog();

        private void ItemAdd(object sender, EventArgs e) => frmItemAdd.ShowDialog();

        private void ItemGroupAdd(object sender, EventArgs e) => frmAddItemGroup.ShowDialog();

        private void InvoiceAdd(object sender, EventArgs e) => frmInvoiceAdd.ShowDialog();

        private void BusinessAdd(object sender, EventArgs e) => frmAddBusiness.ShowDialog();

        private void CompanyEdit(object sender, EventArgs e) {
            if (this.lsCompanies.SelectedItems.Count > 0) {
                string strCompID = Utils.Nz(this.lsCompanies.SelectedItems[0].Text, "-1");
                long companyID = Utils.CLng(strCompID);
                bool enable = (companyID > 0);

                if (enable) {
                    frmCompanyEdit.SetCompanyID(companyID);
                    frmCompEdit.ShowDialog();
                }
            }
        }

        private void ClientEdit(object sender, EventArgs e) {
            if (this.lsClients.SelectedItems.Count > 0) {
                string strClientID = Utils.Nz(this.lsClients.SelectedItems[0].Text, "-1");
                long clientID = Utils.CLng(strClientID);
                bool enable = (clientID > 0);

                if (enable) {
                    frmClientEdit.SetClientID(clientID);
                    frmEditClient.ShowDialog();
                }
            }
        }

        private void ItemEdit(object sender, EventArgs e) {
            if (this.lsItems.SelectedItems.Count > 0) {
                string strItemID = Utils.Nz(this.lsItems.SelectedItems[0].Text, "-1");
                long itemID = Utils.CLng(strItemID);
                bool enable = (itemID > 0);

                if (enable) {
                    frmItemEdit.SetItemID(itemID);
                    frmItemEdit.ShowDialog();
                }
            }
        }

        private void ItemGroupEdit(object sender, EventArgs e) {
            if (this.lsItemGroups.SelectedItems.Count > 0) {
                string strItemGrpID = Utils.Nz(this.lsItemGroups.SelectedItems[0].Text, "-1");
                long itemGrpID = Utils.CLng(strItemGrpID);
                bool enable = (itemGrpID > 0);

                if (enable) {
                    frmItemGroupEdit.SetID(itemGrpID);
                    frmEditItemGroup.ShowDialog();
                }
            }
        }

        private void InvoiceEdit(object sender, EventArgs e) {
            if (this.lsInvoices.SelectedItems.Count > 0) {
                string strInvoiceID = Utils.Nz(this.lsInvoices.SelectedItems[0].Text, "-1");
                long invoiceID = Utils.CLng(strInvoiceID);
                bool enable = (invoiceID > 0);

                if (enable) {
                    frmInvoiceEdit.SetInvoiceID(invoiceID);
                    frmEditInvoice.ShowDialog();
                }
            }
        }

        private void BusinessEdit(object sender, EventArgs e) {
            if (this.lsBusinesses.SelectedItems.Count > 0) {
                string strBusinessID = Utils.Nz(this.lsBusinesses.SelectedItems[0].Text, "-1");
                long businessID = Utils.CLng(strBusinessID);
                bool enable = (businessID > 0);

                if (enable) {
                    frmBusinessEdit.SetBusinessID(businessID);
                    frmEditBusiness.ShowDialog();
                }
            }
        }

        private void CompanyDelete(object sender, EventArgs e) {
            if (this.lsCompanies.SelectedItems.Count > 0) {
                string strCompID = Utils.Nz(this.lsCompanies.SelectedItems[0].Text, "-1");
                long companyID = Utils.CLng(strCompID);
                bool enable = (companyID > 0);
                if (enable) {
                    string strSQL = "DELETE FROM [COMPANY] WHERE [ID] = @ID;";
                    try {
                        using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                            sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, companyID);
                            sqlCmd.ExecuteNonQuery();
                        }
                        DialogBox.Show("Company deleted.");
                        this.RefreshListViews();
                    } catch (SqlException ex) {
                        DialogBox.ErrorUnexpected(ex);
                    }
                }
            }
        }

        private void ClientDelete(object sender, EventArgs e) {
            if (!DialogBox.Confirm("Are you sure you wish to delete this Client from the list?")) {
                return;
            }

            string strClientID = Utils.Nz(this.lsClients.SelectedItems[0].Text, "-1");
            long clientID = Utils.CLng(strClientID);
            bool enable = (clientID > 0);
            if (enable) {
                string strSQL = "DELETE FROM [CLIENTS] WHERE [ID] = @ID;";
                try {
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, clientID);
                        sqlCmd.ExecuteNonQuery();
                    }
                    DialogBox.Show("Client deleted.");
                    this.RefreshListViews();
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            }
        }

        private void ItemDelete(object sender, EventArgs e) {
            if (this.lsItems.SelectedItems.Count > 0) {
                string strItemID = Utils.Nz(this.lsItems.SelectedItems[0].Text, "-1");
                long itemID = Utils.CLng(strItemID);
                bool enable = (itemID > 0);
                if (enable) {
                    string strSQL = "DELETE FROM [Items] WHERE [ID] = @ID;";
                    try {
                        using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                            sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, itemID);
                            sqlCmd.ExecuteNonQuery();
                        }
                        DialogBox.Show("Item deleted.");
                        this.RefreshListViews();
                    } catch (SqlException ex) {
                        DialogBox.ErrorUnexpected(ex);
                    }
                }
            }
        }

        private void ItemGroupDelete(object sender, EventArgs e) {
            if (this.lsItemGroups.SelectedItems.Count > 0) {
                string strItemGroupID = Utils.Nz(this.lsItemGroups.SelectedItems[0].Text, "-1");
                long itemGroupID = Utils.CLng(strItemGroupID);
                bool enable = (itemGroupID > 0);
                if (enable) {
                    string strSQL = "DELETE FROM [ItemGroups] WHERE [ID] = @ID;";
                    try {
                        using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                            sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, itemGroupID);
                            sqlCmd.ExecuteNonQuery();
                        }
                        DialogBox.Show("Item Group deleted.");
                        this.RefreshListViews();
                    } catch (SqlException ex) {
                        DialogBox.ErrorUnexpected(ex);
                    }
                }
            }
        }

        private void InvoiceDelete(object sender, EventArgs e) {
            if (this.lsInvoices.SelectedItems.Count > 0) {
                string strInvoiceID = Utils.Nz(this.lsInvoices.SelectedItems[0].Text, "-1");
                long invoiceID = Utils.CLng(strInvoiceID);
                bool enable = (invoiceID > 0);
                if (enable) {
                    string strSQL = "DELETE FROM [Invoices] WHERE [ID] = @ID;";
                    try {
                        using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                            sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, invoiceID);
                            sqlCmd.ExecuteNonQuery();
                        }
                        DialogBox.Show("Invoice permanently deleted.");
                        this.RefreshListViews();
                    } catch (SqlException ex) {
                        DialogBox.ErrorUnexpected(ex);
                    }
                }
            }
        }

        private void BusinessDelete(object sender, EventArgs e) {
            if (this.lsBusinesses.SelectedItems.Count > 0) {
                string strBusID = Utils.Nz(this.lsBusinesses.SelectedItems[0].Text, "-1");
                long businessID = Utils.CLng(strBusID);
                bool enable = (businessID > 0);
                if (enable) {
                    string strSQL = "DELETE FROM [BusinessInfo] WHERE [ID] = @ID;";
                    try {
                        using (SqlCommand sqlCmd = new SqlCommand(strSQL, AAS.SQL_CONN)) {
                            sqlCmd.Parameters.Add("@ID", SqlDbType.BigInt);
                            sqlCmd.Parameters["@ID"].Value = businessID;
                            sqlCmd.ExecuteNonQuery();
                        }
                        DialogBox.Show("Business deleted.");
                        this.RefreshListViews();
                    } catch (SqlException ex) {
                        DialogBox.ErrorUnexpected(ex);
                    }
                }
            }
        }

        #region Populate ListViews
        public void PopulateListCompany() {
            string strSQL = "SELECT * FROM [VIEW_CompanyInfo] ORDER BY [Name] ASC;";
            try {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, AAS.SQL_CONN)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "VIEW_CompanyInfo");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            foreach (DataRow row in dataTbl.Rows) {
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["CompanyID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Name"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Address"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Phone Number"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Web Site"]));
                                this.lsCompanies.Items.Add(viewItem);
                                if ((i % 2) == 0) {
                                    viewItem.BackColor = Color.Gainsboro;
                                }
                                i++;
                            }
                        }
                    }
                }
                this.ResizeListViews();
                this.btnCompanyEdit.Enabled = false;
                this.btnCompanyDelete.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public void PopulateListClient() {
            string strSQL = "SELECT * FROM [VIEW_ClientInfo] ORDER BY [ClientName] ASC;";
            try {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, AAS.SQL_CONN)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "VIEW_ClientInfo");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            foreach (DataRow row in dataTbl.Rows) {
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["ClientID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["ClientName"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["ClientAddress"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["CompanyName"]));
                                this.lsClients.Items.Add(viewItem);
                                if ((i % 2) == 0) {
                                    viewItem.BackColor = Color.Gainsboro;
                                }
                                i++;
                            }
                        }
                    }
                }
                this.ResizeListViews();
                this.btnClientEdit.Enabled = false;
                this.btnClientDelete.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public void PopulateListItem() {
            string strSQL = "SELECT * FROM [VIEW_Items] ORDER BY [Name] ASC;";
            try {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, AAS.SQL_CONN)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "VIEW_Items");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            double price;
                            double discount;
                            int color = 1694498815;
                            bool hasColor = false;
                            foreach (DataRow row in dataTbl.Rows) {
                                price = Math.Round(Utils.CDbl(row["Price"]), 2);
                                discount = Math.Round(Utils.CDbl(row["discount"]), 2);
                                color = Utils.CInt(Utils.Nz(row["Color"].ToString(), "-1"));
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["ItemID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Name"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Description"]));
                                viewItem.SubItems.Add(Utils.Nz(Utils.SqlFormat(row["ItemGroup"]), "--"));
                                viewItem.SubItems.Add("$" + Utils.SqlFormat(price));
                                viewItem.SubItems.Add("$" + Utils.SqlFormat(discount));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Company"]));
                                this.lsItems.Items.Add(viewItem);
                                if (color != 1694498815) {
                                    hasColor = true;
                                    viewItem.BackColor = Color.FromArgb(color);
                                }

                                if (!hasColor) {
                                    if ((i % 2) == 0) {
                                        viewItem.BackColor = Color.Gainsboro;
                                    }
                                }
                                hasColor = false;
                                i++;
                            }
                        }
                    }
                }
                this.ResizeListViews();
                this.btnItemEdit.Enabled = false;
                this.btnItemDelete.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public void PopulateListItemGroups() {
            string strSQL = "SELECT * FROM [ItemGroups] ORDER BY [GroupName] ASC;";
            try {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, AAS.SQL_CONN)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "ItemGroups");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            int color = 1694498815;
                            bool hasColor = false;
                            foreach (DataRow row in dataTbl.Rows) {
                                color = Utils.CInt(Utils.Nz(row["GroupColor"].ToString(), "1694498815"));
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["ID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["GroupName"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["GroupText"]));
                                this.lsItemGroups.Items.Add(viewItem);

                                if (color != 1694498815) {
                                    hasColor = true;
                                    viewItem.BackColor = Color.FromArgb(color);
                                }

                                if (!hasColor) {
                                    if ((i % 2) == 0) {
                                        viewItem.BackColor = Color.Gainsboro;
                                    }
                                }
                                hasColor = false;
                                i++;
                            }
                        }
                    }
                }
                this.ResizeListViews();
                this.btnEditItemGroup.Enabled = false;
                this.btnDeleteItemGroup.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public void PopulateListInvoices() {
            string strSQL = "SELECT * FROM [VIEW_InvoiceData] ORDER BY [InvoiceNr] ASC;";
            try {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, AAS.SQL_CONN)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "VIEW_InvoiceData");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            foreach (DataRow row in dataTbl.Rows) {
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["InvoiceID"])
                                };
                                viewItem.SubItems.Add(row["InvoiceNr"].ToString());
                                viewItem.SubItems.Add(row["AmountDue"].ToString());
                                viewItem.SubItems.Add(row["TaxPct"].ToString());
                                viewItem.SubItems.Add(row["DiscountPct"].ToString());
                                viewItem.SubItems.Add(row["Subtotal"].ToString());
                                viewItem.SubItems.Add(row["IssueDt"].ToString());
                                viewItem.SubItems.Add(row["DueDt"].ToString());
                                viewItem.SubItems.Add(row["Paid"].ToString());
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Client"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Company"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["Business"]));
                                this.lsInvoices.Items.Add(viewItem);
                                if ((i % 2) == 0) {
                                    viewItem.BackColor = Color.Gainsboro;
                                }
                                i++;
                            }
                        }
                    }
                }
                this.ResizeListViews();
                this.btnEditInvoice.Enabled = false;
                this.btnDeleteInvoice.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }

        public void PopulateListBusiness() {
            string strSQL = "SELECT * FROM [BusinessInfo] ORDER BY [BusinessName] ASC;";
            try {
                using (SqlDataAdapter sqlData = new SqlDataAdapter(strSQL, AAS.SQL_CONN)) {
                    using (DataSet dataSet = new DataSet()) {
                        sqlData.Fill(dataSet, "BusinessInfo");
                        using (DataTable dataTbl = dataSet.Tables[0]) {
                            int i = 0;
                            foreach (DataRow row in dataTbl.Rows) {
                                ListViewItem viewItem = new ListViewItem {
                                    Text = Utils.CStr(row["ID"])
                                };
                                viewItem.SubItems.Add(Utils.SqlFormat(row["BusinessName"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["BusinessAddress"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["BusinessPhone"]));
                                viewItem.SubItems.Add(Utils.SqlFormat(row["BusinessWebsite"]));
                                this.lsBusinesses.Items.Add(viewItem);
                                if ((i % 2) == 0) {
                                    viewItem.BackColor = Color.Gainsboro;
                                }
                                i++;
                            }
                        }
                    }
                }
                this.ResizeListViews();
                this.btnCompanyEdit.Enabled = false;
                this.btnCompanyDelete.Enabled = false;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
        }
        #endregion

        #region Clear ListViews
        private void RemoveAllCompany() => Utils.RemoveAllFromListView(this.lsCompanies);

        private void RemoveAllClient() => Utils.RemoveAllFromListView(this.lsClients);

        private void RemoveAllItems() => Utils.RemoveAllFromListView(this.lsItems);

        private void RemoveAllItemGroups() => Utils.RemoveAllFromListView(lv: this.lsItemGroups);

        private void RemoveAllInvoices() => Utils.RemoveAllFromListView(lv: this.lsInvoices);

        private void RemoveAllBusinesses() => Utils.RemoveAllFromListView(lv: this.lsBusinesses);
        #endregion

        #region Refresh ListViews
        public Action RefreshListCompany() {
            this.RemoveAllCompany();
            this.PopulateListCompany();
            return null;
        }

        public Action RefreshListClient() {
            this.RemoveAllClient();
            this.PopulateListClient();
            return null;
        }

        public Action RefreshListItem() {
            this.RemoveAllItems();
            this.PopulateListItem();
            return null;
        }

        public Action RefreshListItemGroups() {
            this.RemoveAllItemGroups();
            this.PopulateListItemGroups();
            return null;
        }

        public Action RefreshListInvoices() {
            this.RemoveAllInvoices();
            this.PopulateListInvoices();
            return null;
        }

        public Action RefreshListBusinesses() {
            this.RemoveAllBusinesses();
            this.PopulateListBusiness();
            return null;
        }
        #endregion

        private void lsCompanies_DoubleClick(object sender, EventArgs e) => this.CompanyEdit(sender, e);

        private void btnRefreshCompany_Click(object sender, EventArgs e) => this.RefreshListCompany();

        private void lsCompanies_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsCompanies);
            this.btnCompanyEdit.Enabled = enable;
            this.btnCompanyDelete.Enabled = enable;
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e) {
            Utils.SystemResize = true;
            this.ResizeListViews();
            this.RefreshListViews();
            Utils.SystemResize = false;
        }

        private void frmMain_MinimumSizeChanged(object sender, EventArgs e) {
            Utils.SystemResize = true;
            this.ResizeListViews();
            this.RefreshListViews();
            Utils.SystemResize = false;
        }

        private void frmMain_Resize(object sender, EventArgs e) {
            Utils.SystemResize = true;
            this.ResizeListViews();
            this.RefreshListViews();
            Utils.SystemResize = false;
        }

        private void btnClientDelete_Click(object sender, EventArgs e) => this.ClientDelete(sender, e);

        private void btnClientEdit_Click(object sender, EventArgs e) => this.ClientEdit(sender, e);

        private void btnClientAdd_Click(object sender, EventArgs e) => this.ClientAdd(sender, e);

        private void lsClients_DoubleClick(object sender, EventArgs e) => this.ClientEdit(sender, e);

        private void lsClients_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsClients);
            this.btnClientEdit.Enabled = enable;
            this.btnClientDelete.Enabled = enable;
        }

        private void btnRefresh_Click(object sender, EventArgs e) => this.RefreshListClient();

        private void customerToolStripMenuItem_Click(object sender, EventArgs e) => this.ClientAdd(sender, e);

        private void companyToolStripMenuItem_Click(object sender, EventArgs e) => this.CompanyAdd(sender, e);

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) => this.frmSettings.ShowDialog();

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgClients;

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgCompanies;

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgInvoices;

        private void productsToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgProducts;

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgReports;

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!Roles.isAdmin()) {
                DialogBox.Error("Insufficient permissions; adminsitrators only.");
                return;
            }
            frmManageUsers.Show();
        }

        private void btnRefreshItems_Click(object sender, EventArgs e) => this.RefreshListItem();

        private void lsItems_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsItems);
            this.btnItemEdit.Enabled = enable;
            this.btnItemDelete.Enabled = enable;
        }

        private void lsItemGroups_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsItemGroups);
            this.btnEditItemGroup.Enabled = enable;
            this.btnDeleteItemGroup.Enabled = enable;
        }

        private void btnItemEdit_Click(object sender, EventArgs e) => this.ItemEdit(sender, e);

        private void btnItemsAdd_Click(object sender, EventArgs e) => this.ItemAdd(sender, e);

        private void btnItemDelete_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Are you sure you want to delete this Item?")) {
                this.ItemDelete(sender, e);
            }
        }

        private void lsItems_DoubleClick(object sender, EventArgs e) => this.ItemEdit(sender, e);

        public void OpenChangePasswordForm() => frmPassChange.ShowDialog();

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) => this.OpenChangePasswordForm();

        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e) => this.ItemGroupAdd(sender, e);

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e) => this.frmInvoiceAdd.ShowDialog();

        private void productToolStripMenuItem_Click(object sender, EventArgs e) => this.ItemAdd(sender, e);

        private void reportToolStripMenuItem_Click(object sender, EventArgs e) {
            //TODO
        }

        private void btnViewItemGroups_Click(object sender, EventArgs e) => this.ViewItemGroups(sender, e);

        private void ViewItemGroups(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgItemGroups;

        private void btnRefreshItemGroups_Click(object sender, EventArgs e) => this.RefreshListItemGroups();

        private void itemGroupsToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgItemGroups;

        private void lsItemGroups_DoubleClick(object sender, EventArgs e) => this.ItemGroupEdit(sender, e);

        private void btnEditItemGroup_Click(object sender, EventArgs e) => this.ItemGroupEdit(sender, e);

        private void btnDeleteItemGroup_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Are you sure you want to delete this Item Group?")) {
                this.ItemGroupDelete(sender, e);
            }
        }

        private void btnAddNewItemGroup_Click(object sender, EventArgs e) => this.ItemGroupAdd(sender, e);

        private void btnExportToExcelClients_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Clients list to Excel?")) {
                Utils.ExportToExcel(this.lsClients);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnExportToExcelCompanies_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Companies list to Excel?")) {
                Utils.ExportToExcel(this.lsCompanies);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnExportToExcelItems_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Items list to Excel?")) {
                Utils.ExportToExcel(this.lsItems);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnExportToExcelItemGroups_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Item Groups list to Excel?")) {
                Utils.ExportToExcel(this.lsItemGroups);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnExportToExcelInvoices_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Invoices list to Excel?")) {
                Utils.ExportToExcel(this.lsInvoices);
                DialogBox.Show("Export complete!");
            }
        }

        private void btnExportToExcelBusinesses_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Export Businesses list to Excel?")) {
                Utils.ExportToExcel(this.lsBusinesses);
                DialogBox.Show("Export complete!");
            }
        }

        private void lsClients_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsClients, sender, e);

        private void lsCompanies_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsCompanies, sender, e);

        private void lsItems_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsItems, sender, e);

        private void lsItemGroups_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsItemGroups, sender, e);

        private void lsBusinesses_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsBusinesses, sender, e);

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e) => this.ResizeListViews();

        private void btnAddInvoice_Click(object sender, EventArgs e) => this.InvoiceAdd(sender, e);

        private void btnEditInvoice_Click(object sender, EventArgs e) => this.InvoiceEdit(sender, e);

        private void btnDeleteInvoice_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Are you sure you want to delete this Invoice? This is permanent and cannot be undone.")) {
                this.InvoiceDelete(sender, e);
            }
        }

        private void lsInvoices_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsInvoices);
            this.btnEditInvoice.Enabled = enable;
            this.btnDeleteInvoice.Enabled = enable;
            this.btnGenerateInvoice.Enabled = enable;
        }

        private void lsInvoices_DoubleClick(object sender, EventArgs e) => this.InvoiceEdit(sender, e);

        private void lsInvoices_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) => Utils.PreventColumnResize(this.lsInvoices, sender, e);

        private void btnRefreshInvoices_Click(object sender, EventArgs e) => this.RefreshListInvoices();

        private void btnGenerateInvoice_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Generate selected Invoice as Word document?")) {
                this.GenerateInvoice(sender, e);
            }
        }

        public void GenerateInvoice(object sender, EventArgs e) {
            if (Utils.isSomethingSelected(this.lsInvoices)) {
                string strInvoiceID = Utils.Nz(this.lsInvoices.SelectedItems[0].Text, "-1");
                long invoiceID = Utils.CLng(strInvoiceID);
                string invoiceNr = "INV_000";
                string currentDt = DateTime.Now.ToShortDateString();
                string invoiceDt = "";
                string supplyDt = "";
                string dueDt = "";
                string compName = "";
                string compAddr = "";
                string compPhone = "";
                string compWeb = "";
                string busName = "";
                string busAddr = "";
                string busPhone = "";
                string busWeb = "";
                string summary = "";
                string payTerms = "";
                double amountDue = 0.00;
                double tax = 0.00;
                double taxPct = 0.00;
                double discount = 0.00;
                double discountPct = 0.00;
                double total = 0.00;

                try {
                    string strSQL = "SELECT * FROM [VIEW_InvoiceData] WHERE [InvoiceID] = @ID;";
                    SqlConnection conn = AAS.SQL_CONN;
                    using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                        sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, invoiceID);
                        using (SqlDataReader sqlReader = sqlCmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                invoiceNr = sqlReader["InvoiceNr"].ToString();
                                invoiceDt = sqlReader["IssueDt"].ToString();
                                supplyDt = sqlReader["SupplyDt"].ToString();
                                dueDt = sqlReader["DueDt"].ToString();
                                compName = Utils.SqlFormat(sqlReader["Company"]);
                                compAddr = Utils.SqlFormat(sqlReader["Company_Address"]);
                                compPhone = Utils.SqlFormat(sqlReader["Company_Phone"]);
                                compWeb = Utils.SqlFormat(sqlReader["Company_Website"]);
                                busName = Utils.SqlFormat(sqlReader["Business"]);
                                busAddr = Utils.SqlFormat(sqlReader["Business_Address"]);
                                busPhone = Utils.SqlFormat(sqlReader["Business_Phone"]);
                                busWeb = Utils.SqlFormat(sqlReader["Business_Website"]);
                                summary = Utils.SqlFormat(sqlReader["Summary"]);
                                payTerms = Utils.SqlFormat(sqlReader["PayTerms"]);
                                taxPct = Utils.MoneyVal(sqlReader["TaxPct"]);
                                discountPct = Utils.MoneyVal(sqlReader["DiscountPct"]);
                                amountDue = Utils.MoneyVal(sqlReader["AmountDue"], false);
                            }
                            sqlReader.Close();
                            tax = Finances.CalcTax(amountDue, discountPct, taxPct);
                            discount = Finances.CalcSavings(amountDue, discountPct, taxPct);
                            total = Finances.CalcTotal(amountDue, discountPct, taxPct);
                        }
                    }
                    conn = null;
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }

                Cursor.Current = Cursors.WaitCursor;
                try {
                    string filePath = Directory.GetCurrentDirectory() + @"\INVOICE_SIMPLE.docx";
                    Word.Application word = new Word.Application();
                    Word.Document doc = word.Documents.Add(filePath);
                    word.Visible = false;

                    #region Update Word variables
                    doc.Variables["$INVOICE_NR"].Value = invoiceNr;
                    doc.Variables["$COMPANY_NAME"].Value = compName;
                    doc.Variables["$COMPANY_ADDR"].Value = compAddr;
                    doc.Variables["$COMPANY_PHONE"].Value = compPhone;
                    doc.Variables["$COMPANY_WEB"].Value = compWeb;
                    doc.Variables["$BUSINESS_NAME"].Value = busName;
                    doc.Variables["$BUSINESS_ADDR"].Value = busAddr;
                    doc.Variables["$BUSINESS_PHONE"].Value = busPhone;
                    doc.Variables["$BUSINESS_WEB"].Value = busWeb;
                    doc.Variables["$INVOICE_DT"].Value = invoiceDt;
                    doc.Variables["$SUPPLY_DT"].Value = supplyDt;
                    doc.Variables["$DUE_DT"].Value = dueDt;
                    doc.Variables["$CURRENT_DT"].Value = currentDt;
                    doc.Variables["$SUMMARY"].Value = summary;
                    doc.Variables["$PAY_TERMS"].Value = payTerms;
                    doc.Variables["$AMOUNT_DUE"].Value = "$" + amountDue.ToString();
                    doc.Variables["$DISCOUNT"].Value = "$" + discount.ToString();
                    doc.Variables["$TAX"].Value = "$" + tax.ToString();
                    doc.Variables["$TOTAL"].Value = "$" + total.ToString();
                    doc.Fields.Update();
                    #endregion

                    string userName = Environment.UserName;
                    string dir = @"C:\Users\" + userName + @"\Documents\My Invoices";
                    if (!Directory.Exists(dir)) {
                        Directory.CreateDirectory(dir);
                    }
                    string fileName = dir + @"\" + invoiceNr + ".docx";
                    doc.SaveAs2(fileName);
                    doc.Close();
                    //word.Quit();
                    doc = word.Documents.Open(fileName);
                    word.Visible = true;
                    word.ShowMe();
                } catch (FileNotFoundException ex) {
                    DialogBox.ErrorUnexpected(ex, "File could not be found.");
                } catch (IOException ex) {
                    DialogBox.ErrorUnexpected(ex, "Input/Output Error.");
                } catch (UnauthorizedAccessException ex) {
                    DialogBox.ErrorUnexpected(ex, "Permission denied.");
                } catch (NotSupportedException ex) {
                    DialogBox.ErrorUnexpected(ex, "Operation not supported.");
                } finally {
                    Cursor.Current = Cursors.Default;
                }
            } else {
                DialogBox.Error("No Invoice was selected.");
            }
        }

        private void btnOpenFinanceCalc_Click(object sender, EventArgs e) => this.OpenFinancialCalculator(sender, e);

        public void OpenFinancialCalculator(object sender, EventArgs e) => this.frmFinanceCalc.Show();

        private void businessToolStripMenuItem_Click(object sender, EventArgs e) => this.BusinessAdd(sender, e);

        private void businessesToolStripMenuItem_Click(object sender, EventArgs e) => this.tabMain.SelectedTab = this.pgBusinesses;

        private void btnAddBusiness_Click(object sender, EventArgs e) => this.BusinessAdd(sender, e);

        private void btnEditBusiness_Click(object sender, EventArgs e) => this.BusinessEdit(sender, e);

        private void btnDeleteBusiness_Click(object sender, EventArgs e) {
            if (DialogBox.Confirm("Are you sure you want to delete this Business from the list?")) {
                this.BusinessDelete(sender, e);
            }
        }

        private void btnRefreshBusinesses_Click(object sender, EventArgs e) {
            this.RefreshListBusinesses();
        }

        private void lsBusinesses_SelectedIndexChanged(object sender, EventArgs e) {
            bool enable = Utils.isSomethingSelected(this.lsBusinesses);
            this.btnEditBusiness.Enabled = enable;
            this.btnDeleteBusiness.Enabled = enable;
        }

        private void lsBusinesses_DoubleClick(object sender, EventArgs e) {
            this.BusinessEdit(sender, e);
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAbout.ShowDialog();
        }

        private void openGuideToolStripMenuItem_Click(object sender, EventArgs e) {
            //TODO
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            this.CloseProgram();
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
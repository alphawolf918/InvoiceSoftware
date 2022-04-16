using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceSoftware {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pgInvoices = new System.Windows.Forms.TabPage();
            this.btnOpenFinanceCalc = new System.Windows.Forms.Button();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.btnExportToExcelInvoices = new System.Windows.Forms.Button();
            this.btnRefreshInvoices = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lsInvoices = new System.Windows.Forms.ListView();
            this.colInvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInvoiceNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmountDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalesTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiscnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIssueDt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDueDt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBusiness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInvoiceList = new System.Windows.Forms.Label();
            this.pgBusinesses = new System.Windows.Forms.TabPage();
            this.btnEditBusiness = new System.Windows.Forms.Button();
            this.btnDeleteBusiness = new System.Windows.Forms.Button();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.btnExportToExcelBusinesses = new System.Windows.Forms.Button();
            this.btnRefreshBusinesses = new System.Windows.Forms.Button();
            this.lsBusinesses = new System.Windows.Forms.ListView();
            this.colBusinessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBusinessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBusinessAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBusinessPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBusinessWeb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBusinesses = new System.Windows.Forms.Label();
            this.pgClients = new System.Windows.Forms.TabPage();
            this.btnExportToExcelClients = new System.Windows.Forms.Button();
            this.btnRefreshClient = new System.Windows.Forms.Button();
            this.btnClientEdit = new System.Windows.Forms.Button();
            this.btnClientDelete = new System.Windows.Forms.Button();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.lsClients = new System.Windows.Forms.ListView();
            this.colClientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblClients = new System.Windows.Forms.Label();
            this.pgCompanies = new System.Windows.Forms.TabPage();
            this.btnExportToExcelCompanies = new System.Windows.Forms.Button();
            this.btnRefreshCompany = new System.Windows.Forms.Button();
            this.lsCompanies = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWebSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCompanies = new System.Windows.Forms.Label();
            this.btnCompanyEdit = new System.Windows.Forms.Button();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.pgProducts = new System.Windows.Forms.TabPage();
            this.btnExportToExcelItems = new System.Windows.Forms.Button();
            this.btnViewItemGroups = new System.Windows.Forms.Button();
            this.btnItemEdit = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemsAdd = new System.Windows.Forms.Button();
            this.lsItems = new System.Windows.Forms.ListView();
            this.colItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshItems = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.pgItemGroups = new System.Windows.Forms.TabPage();
            this.btnExportToExcelItemGroups = new System.Windows.Forms.Button();
            this.lblItemGroups = new System.Windows.Forms.Label();
            this.btnEditItemGroup = new System.Windows.Forms.Button();
            this.btnDeleteItemGroup = new System.Windows.Forms.Button();
            this.btnAddNewItemGroup = new System.Windows.Forms.Button();
            this.lsItemGroups = new System.Windows.Forms.ListView();
            this.colItemGroupID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemGroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemGroupText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshItemGroups = new System.Windows.Forms.Button();
            this.pgReports = new System.Windows.Forms.TabPage();
            this.menuStripMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pgInvoices.SuspendLayout();
            this.pgBusinesses.SuspendLayout();
            this.pgClients.SuspendLayout();
            this.pgCompanies.SuspendLayout();
            this.pgProducts.SuspendLayout();
            this.pgItemGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.adminSettingsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1488, 26);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuMain
            // 
            this.menuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuMain.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(46, 22);
            this.menuMain.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businessToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.productToolStripMenuItem,
            this.itemGroupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // businessToolStripMenuItem
            // 
            this.businessToolStripMenuItem.Name = "businessToolStripMenuItem";
            this.businessToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.businessToolStripMenuItem.Text = "Business";
            this.businessToolStripMenuItem.Click += new System.EventHandler(this.businessToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.customerToolStripMenuItem.Text = "Client";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.productToolStripMenuItem.Text = "Item";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // itemGroupToolStripMenuItem
            // 
            this.itemGroupToolStripMenuItem.Name = "itemGroupToolStripMenuItem";
            this.itemGroupToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.itemGroupToolStripMenuItem.Text = "Item Group";
            this.itemGroupToolStripMenuItem.Click += new System.EventHandler(this.itemGroupToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.settingsToolStripMenuItem.Text = "Application Settings";
            this.settingsToolStripMenuItem.Visible = false;
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businessesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.itemGroupsToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // businessesToolStripMenuItem
            // 
            this.businessesToolStripMenuItem.Name = "businessesToolStripMenuItem";
            this.businessesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.businessesToolStripMenuItem.Text = "Businesses";
            this.businessesToolStripMenuItem.Click += new System.EventHandler(this.businessesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.companiesToolStripMenuItem.Text = "Companies";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            this.invoicesToolStripMenuItem.Click += new System.EventHandler(this.invoicesToolStripMenuItem_Click);
            // 
            // itemGroupsToolStripMenuItem
            // 
            this.itemGroupsToolStripMenuItem.Name = "itemGroupsToolStripMenuItem";
            this.itemGroupsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.itemGroupsToolStripMenuItem.Text = "Item Groups";
            this.itemGroupsToolStripMenuItem.Click += new System.EventHandler(this.itemGroupsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.productsToolStripMenuItem.Text = "Items";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailsToolStripMenuItem,
            this.openGuideToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // openGuideToolStripMenuItem
            // 
            this.openGuideToolStripMenuItem.Name = "openGuideToolStripMenuItem";
            this.openGuideToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.openGuideToolStripMenuItem.Text = "Open Guide";
            this.openGuideToolStripMenuItem.Click += new System.EventHandler(this.openGuideToolStripMenuItem_Click);
            // 
            // adminSettingsToolStripMenuItem
            // 
            this.adminSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem});
            this.adminSettingsToolStripMenuItem.Name = "adminSettingsToolStripMenuItem";
            this.adminSettingsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.adminSettingsToolStripMenuItem.Text = "Admin Settings";
            this.adminSettingsToolStripMenuItem.Visible = false;
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1488, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(54, 18);
            this.lblStatusBar.Text = "Ready";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pgInvoices);
            this.tabMain.Controls.Add(this.pgBusinesses);
            this.tabMain.Controls.Add(this.pgClients);
            this.tabMain.Controls.Add(this.pgCompanies);
            this.tabMain.Controls.Add(this.pgProducts);
            this.tabMain.Controls.Add(this.pgItemGroups);
            this.tabMain.Controls.Add(this.pgReports);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.HotTrack = true;
            this.tabMain.Location = new System.Drawing.Point(0, 26);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1488, 624);
            this.tabMain.TabIndex = 2;
            this.tabMain.TabStop = false;
            this.tabMain.Visible = false;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // pgInvoices
            // 
            this.pgInvoices.BackColor = System.Drawing.Color.Gainsboro;
            this.pgInvoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgInvoices.Controls.Add(this.btnOpenFinanceCalc);
            this.pgInvoices.Controls.Add(this.btnGenerateInvoice);
            this.pgInvoices.Controls.Add(this.btnExportToExcelInvoices);
            this.pgInvoices.Controls.Add(this.btnRefreshInvoices);
            this.pgInvoices.Controls.Add(this.btnEditInvoice);
            this.pgInvoices.Controls.Add(this.btnDeleteInvoice);
            this.pgInvoices.Controls.Add(this.btnAddInvoice);
            this.pgInvoices.Controls.Add(this.lsInvoices);
            this.pgInvoices.Controls.Add(this.lblInvoiceList);
            this.pgInvoices.Location = new System.Drawing.Point(4, 27);
            this.pgInvoices.Name = "pgInvoices";
            this.pgInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.pgInvoices.Size = new System.Drawing.Size(1480, 593);
            this.pgInvoices.TabIndex = 0;
            this.pgInvoices.Text = "Invoices & Billing ";
            // 
            // btnOpenFinanceCalc
            // 
            this.btnOpenFinanceCalc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenFinanceCalc.Location = new System.Drawing.Point(135, 6);
            this.btnOpenFinanceCalc.Name = "btnOpenFinanceCalc";
            this.btnOpenFinanceCalc.Size = new System.Drawing.Size(166, 32);
            this.btnOpenFinanceCalc.TabIndex = 21;
            this.btnOpenFinanceCalc.Text = "Financial Calculator";
            this.btnOpenFinanceCalc.UseVisualStyleBackColor = true;
            this.btnOpenFinanceCalc.Click += new System.EventHandler(this.btnOpenFinanceCalc_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerateInvoice.Enabled = false;
            this.btnGenerateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(8, 530);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(222, 39);
            this.btnGenerateInvoice.TabIndex = 20;
            this.btnGenerateInvoice.Text = "Generate Selected Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnExportToExcelInvoices
            // 
            this.btnExportToExcelInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelInvoices.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelInvoices.Location = new System.Drawing.Point(1309, 6);
            this.btnExportToExcelInvoices.Name = "btnExportToExcelInvoices";
            this.btnExportToExcelInvoices.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelInvoices.TabIndex = 19;
            this.btnExportToExcelInvoices.Text = "Export to Excel";
            this.btnExportToExcelInvoices.UseVisualStyleBackColor = true;
            this.btnExportToExcelInvoices.Click += new System.EventHandler(this.btnExportToExcelInvoices_Click);
            // 
            // btnRefreshInvoices
            // 
            this.btnRefreshInvoices.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshInvoices.Location = new System.Drawing.Point(8, 6);
            this.btnRefreshInvoices.Name = "btnRefreshInvoices";
            this.btnRefreshInvoices.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshInvoices.TabIndex = 18;
            this.btnRefreshInvoices.Text = "Refresh";
            this.btnRefreshInvoices.UseVisualStyleBackColor = true;
            this.btnRefreshInvoices.Click += new System.EventHandler(this.btnRefreshInvoices_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInvoice.Enabled = false;
            this.btnEditInvoice.Location = new System.Drawing.Point(1172, 532);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(135, 39);
            this.btnEditInvoice.TabIndex = 17;
            this.btnEditInvoice.Text = "Edit Invoice";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteInvoice.Enabled = false;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(1313, 532);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(158, 39);
            this.btnDeleteInvoice.TabIndex = 16;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddInvoice.Location = new System.Drawing.Point(1003, 532);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(163, 39);
            this.btnAddInvoice.TabIndex = 15;
            this.btnAddInvoice.Text = "Create New Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // lsInvoices
            // 
            this.lsInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsInvoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInvoiceID,
            this.colInvoiceNr,
            this.colAmountDue,
            this.colSalesTax,
            this.colDiscnt,
            this.colTotal,
            this.colIssueDt,
            this.colDueDt,
            this.colPaid,
            this.colClient,
            this.colComp,
            this.colBusiness});
            this.lsInvoices.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsInvoices.ForeColor = System.Drawing.Color.Black;
            this.lsInvoices.FullRowSelect = true;
            this.lsInvoices.GridLines = true;
            this.lsInvoices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsInvoices.HideSelection = false;
            this.lsInvoices.Location = new System.Drawing.Point(8, 44);
            this.lsInvoices.MultiSelect = false;
            this.lsInvoices.Name = "lsInvoices";
            this.lsInvoices.ShowItemToolTips = true;
            this.lsInvoices.Size = new System.Drawing.Size(1463, 482);
            this.lsInvoices.TabIndex = 14;
            this.lsInvoices.UseCompatibleStateImageBehavior = false;
            this.lsInvoices.View = System.Windows.Forms.View.Details;
            this.lsInvoices.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsInvoices_ColumnWidthChanging);
            this.lsInvoices.SelectedIndexChanged += new System.EventHandler(this.lsInvoices_SelectedIndexChanged);
            this.lsInvoices.DoubleClick += new System.EventHandler(this.lsInvoices_DoubleClick);
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.Text = "InvoiceID";
            this.colInvoiceID.Width = 0;
            // 
            // colInvoiceNr
            // 
            this.colInvoiceNr.Text = "Invoicing Number";
            this.colInvoiceNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colInvoiceNr.Width = 170;
            // 
            // colAmountDue
            // 
            this.colAmountDue.Text = "Amount Due";
            this.colAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmountDue.Width = 120;
            // 
            // colSalesTax
            // 
            this.colSalesTax.Text = "Sales Tax";
            this.colSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSalesTax.Width = 100;
            // 
            // colDiscnt
            // 
            this.colDiscnt.Text = "Discount";
            this.colDiscnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDiscnt.Width = 110;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTotal.Width = 90;
            // 
            // colIssueDt
            // 
            this.colIssueDt.Text = "Issue Date";
            this.colIssueDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colIssueDt.Width = 120;
            // 
            // colDueDt
            // 
            this.colDueDt.Text = "Due Date";
            this.colDueDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDueDt.Width = 120;
            // 
            // colPaid
            // 
            this.colPaid.Text = "Paid";
            this.colPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPaid.Width = 70;
            // 
            // colClient
            // 
            this.colClient.Text = "Client";
            this.colClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClient.Width = 180;
            // 
            // colComp
            // 
            this.colComp.Text = "To Company";
            this.colComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colComp.Width = 180;
            // 
            // colBusiness
            // 
            this.colBusiness.Text = "From Business";
            this.colBusiness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBusiness.Width = 180;
            // 
            // lblInvoiceList
            // 
            this.lblInvoiceList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvoiceList.AutoSize = true;
            this.lblInvoiceList.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvoiceList.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceList.Location = new System.Drawing.Point(631, 3);
            this.lblInvoiceList.Name = "lblInvoiceList";
            this.lblInvoiceList.Size = new System.Drawing.Size(198, 20);
            this.lblInvoiceList.TabIndex = 1;
            this.lblInvoiceList.Text = "Invoices and Billing";
            this.lblInvoiceList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgBusinesses
            // 
            this.pgBusinesses.BackColor = System.Drawing.Color.Gainsboro;
            this.pgBusinesses.Controls.Add(this.btnEditBusiness);
            this.pgBusinesses.Controls.Add(this.btnDeleteBusiness);
            this.pgBusinesses.Controls.Add(this.btnAddBusiness);
            this.pgBusinesses.Controls.Add(this.btnExportToExcelBusinesses);
            this.pgBusinesses.Controls.Add(this.btnRefreshBusinesses);
            this.pgBusinesses.Controls.Add(this.lsBusinesses);
            this.pgBusinesses.Controls.Add(this.lblBusinesses);
            this.pgBusinesses.Location = new System.Drawing.Point(4, 27);
            this.pgBusinesses.Name = "pgBusinesses";
            this.pgBusinesses.Padding = new System.Windows.Forms.Padding(3);
            this.pgBusinesses.Size = new System.Drawing.Size(1480, 591);
            this.pgBusinesses.TabIndex = 7;
            this.pgBusinesses.Text = "Business Information";
            // 
            // btnEditBusiness
            // 
            this.btnEditBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBusiness.Enabled = false;
            this.btnEditBusiness.Location = new System.Drawing.Point(1167, 527);
            this.btnEditBusiness.Name = "btnEditBusiness";
            this.btnEditBusiness.Size = new System.Drawing.Size(135, 39);
            this.btnEditBusiness.TabIndex = 21;
            this.btnEditBusiness.Text = "Edit Business";
            this.btnEditBusiness.UseVisualStyleBackColor = true;
            this.btnEditBusiness.Click += new System.EventHandler(this.btnEditBusiness_Click);
            // 
            // btnDeleteBusiness
            // 
            this.btnDeleteBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBusiness.Enabled = false;
            this.btnDeleteBusiness.Location = new System.Drawing.Point(1308, 529);
            this.btnDeleteBusiness.Name = "btnDeleteBusiness";
            this.btnDeleteBusiness.Size = new System.Drawing.Size(163, 39);
            this.btnDeleteBusiness.TabIndex = 20;
            this.btnDeleteBusiness.Text = "Delete Business";
            this.btnDeleteBusiness.UseVisualStyleBackColor = true;
            this.btnDeleteBusiness.Click += new System.EventHandler(this.btnDeleteBusiness_Click);
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBusiness.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddBusiness.Location = new System.Drawing.Point(995, 529);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(166, 39);
            this.btnAddBusiness.TabIndex = 19;
            this.btnAddBusiness.Text = "Add New Business";
            this.btnAddBusiness.UseVisualStyleBackColor = true;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // btnExportToExcelBusinesses
            // 
            this.btnExportToExcelBusinesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelBusinesses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelBusinesses.Location = new System.Drawing.Point(1309, 6);
            this.btnExportToExcelBusinesses.Name = "btnExportToExcelBusinesses";
            this.btnExportToExcelBusinesses.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelBusinesses.TabIndex = 18;
            this.btnExportToExcelBusinesses.Text = "Export to Excel";
            this.btnExportToExcelBusinesses.UseVisualStyleBackColor = true;
            this.btnExportToExcelBusinesses.Click += new System.EventHandler(this.btnExportToExcelBusinesses_Click);
            // 
            // btnRefreshBusinesses
            // 
            this.btnRefreshBusinesses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshBusinesses.Location = new System.Drawing.Point(8, 6);
            this.btnRefreshBusinesses.Name = "btnRefreshBusinesses";
            this.btnRefreshBusinesses.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshBusinesses.TabIndex = 17;
            this.btnRefreshBusinesses.Text = "Refresh";
            this.btnRefreshBusinesses.UseVisualStyleBackColor = true;
            this.btnRefreshBusinesses.Click += new System.EventHandler(this.btnRefreshBusinesses_Click);
            // 
            // lsBusinesses
            // 
            this.lsBusinesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsBusinesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsBusinesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBusinessID,
            this.colBusinessName,
            this.colBusinessAddress,
            this.colBusinessPhone,
            this.colBusinessWeb});
            this.lsBusinesses.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBusinesses.ForeColor = System.Drawing.Color.Black;
            this.lsBusinesses.FullRowSelect = true;
            this.lsBusinesses.GridLines = true;
            this.lsBusinesses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsBusinesses.HideSelection = false;
            this.lsBusinesses.Location = new System.Drawing.Point(8, 44);
            this.lsBusinesses.MultiSelect = false;
            this.lsBusinesses.Name = "lsBusinesses";
            this.lsBusinesses.ShowItemToolTips = true;
            this.lsBusinesses.Size = new System.Drawing.Size(1463, 479);
            this.lsBusinesses.TabIndex = 10;
            this.lsBusinesses.UseCompatibleStateImageBehavior = false;
            this.lsBusinesses.View = System.Windows.Forms.View.Details;
            this.lsBusinesses.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsBusinesses_ColumnWidthChanging);
            this.lsBusinesses.SelectedIndexChanged += new System.EventHandler(this.lsBusinesses_SelectedIndexChanged);
            this.lsBusinesses.DoubleClick += new System.EventHandler(this.lsBusinesses_DoubleClick);
            // 
            // colBusinessID
            // 
            this.colBusinessID.Text = "ID";
            this.colBusinessID.Width = 0;
            // 
            // colBusinessName
            // 
            this.colBusinessName.Text = "Name";
            this.colBusinessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBusinessName.Width = 200;
            // 
            // colBusinessAddress
            // 
            this.colBusinessAddress.Text = "Address";
            this.colBusinessAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBusinessAddress.Width = 360;
            // 
            // colBusinessPhone
            // 
            this.colBusinessPhone.Text = "Phone Number";
            this.colBusinessPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBusinessPhone.Width = 141;
            // 
            // colBusinessWeb
            // 
            this.colBusinessWeb.Text = "Web Site";
            this.colBusinessWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBusinessWeb.Width = 280;
            // 
            // lblBusinesses
            // 
            this.lblBusinesses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusinesses.AutoSize = true;
            this.lblBusinesses.BackColor = System.Drawing.Color.Gainsboro;
            this.lblBusinesses.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinesses.Location = new System.Drawing.Point(624, 3);
            this.lblBusinesses.Name = "lblBusinesses";
            this.lblBusinesses.Size = new System.Drawing.Size(180, 20);
            this.lblBusinesses.TabIndex = 9;
            this.lblBusinesses.Text = "List of Businesses";
            this.lblBusinesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgClients
            // 
            this.pgClients.BackColor = System.Drawing.Color.Gainsboro;
            this.pgClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgClients.Controls.Add(this.btnExportToExcelClients);
            this.pgClients.Controls.Add(this.btnRefreshClient);
            this.pgClients.Controls.Add(this.btnClientEdit);
            this.pgClients.Controls.Add(this.btnClientDelete);
            this.pgClients.Controls.Add(this.btnClientAdd);
            this.pgClients.Controls.Add(this.lsClients);
            this.pgClients.Controls.Add(this.lblClients);
            this.pgClients.Location = new System.Drawing.Point(4, 27);
            this.pgClients.Name = "pgClients";
            this.pgClients.Padding = new System.Windows.Forms.Padding(3);
            this.pgClients.Size = new System.Drawing.Size(1480, 591);
            this.pgClients.TabIndex = 1;
            this.pgClients.Text = "Clients & Customers ";
            // 
            // btnExportToExcelClients
            // 
            this.btnExportToExcelClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelClients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelClients.Location = new System.Drawing.Point(1309, 6);
            this.btnExportToExcelClients.Name = "btnExportToExcelClients";
            this.btnExportToExcelClients.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelClients.TabIndex = 15;
            this.btnExportToExcelClients.Text = "Export to Excel";
            this.btnExportToExcelClients.UseVisualStyleBackColor = true;
            this.btnExportToExcelClients.Click += new System.EventHandler(this.btnExportToExcelClients_Click);
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshClient.Location = new System.Drawing.Point(9, 4);
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshClient.TabIndex = 14;
            this.btnRefreshClient.Text = "Refresh";
            this.btnRefreshClient.UseVisualStyleBackColor = true;
            this.btnRefreshClient.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClientEdit
            // 
            this.btnClientEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientEdit.Enabled = false;
            this.btnClientEdit.Location = new System.Drawing.Point(1167, 524);
            this.btnClientEdit.Name = "btnClientEdit";
            this.btnClientEdit.Size = new System.Drawing.Size(135, 39);
            this.btnClientEdit.TabIndex = 13;
            this.btnClientEdit.Text = "Edit Client";
            this.btnClientEdit.UseVisualStyleBackColor = true;
            this.btnClientEdit.Click += new System.EventHandler(this.btnClientEdit_Click);
            // 
            // btnClientDelete
            // 
            this.btnClientDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientDelete.Enabled = false;
            this.btnClientDelete.Location = new System.Drawing.Point(1308, 524);
            this.btnClientDelete.Name = "btnClientDelete";
            this.btnClientDelete.Size = new System.Drawing.Size(163, 39);
            this.btnClientDelete.TabIndex = 12;
            this.btnClientDelete.Text = "Delete Client ";
            this.btnClientDelete.UseVisualStyleBackColor = true;
            this.btnClientDelete.Click += new System.EventHandler(this.btnClientDelete_Click);
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClientAdd.Location = new System.Drawing.Point(995, 524);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(166, 39);
            this.btnClientAdd.TabIndex = 11;
            this.btnClientAdd.Text = "Add New Client";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // lsClients
            // 
            this.lsClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientID,
            this.colClientName,
            this.colAddr,
            this.colCompanyName});
            this.lsClients.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsClients.ForeColor = System.Drawing.Color.Black;
            this.lsClients.FullRowSelect = true;
            this.lsClients.GridLines = true;
            this.lsClients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsClients.HideSelection = false;
            this.lsClients.Location = new System.Drawing.Point(9, 42);
            this.lsClients.MultiSelect = false;
            this.lsClients.Name = "lsClients";
            this.lsClients.ShowItemToolTips = true;
            this.lsClients.Size = new System.Drawing.Size(1463, 476);
            this.lsClients.TabIndex = 10;
            this.lsClients.UseCompatibleStateImageBehavior = false;
            this.lsClients.View = System.Windows.Forms.View.Details;
            this.lsClients.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsClients_ColumnWidthChanging);
            this.lsClients.SelectedIndexChanged += new System.EventHandler(this.lsClients_SelectedIndexChanged);
            this.lsClients.DoubleClick += new System.EventHandler(this.lsClients_DoubleClick);
            // 
            // colClientID
            // 
            this.colClientID.Text = "ClientID";
            this.colClientID.Width = 0;
            // 
            // colClientName
            // 
            this.colClientName.Text = "Name";
            this.colClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClientName.Width = 240;
            // 
            // colAddr
            // 
            this.colAddr.Text = "Address";
            this.colAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAddr.Width = 340;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Text = "Company";
            this.colCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCompanyName.Width = 320;
            // 
            // lblClients
            // 
            this.lblClients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClients.AutoSize = true;
            this.lblClients.BackColor = System.Drawing.Color.Gainsboro;
            this.lblClients.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(638, 16);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(222, 20);
            this.lblClients.TabIndex = 2;
            this.lblClients.Text = "Clients and Customers";
            this.lblClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgCompanies
            // 
            this.pgCompanies.BackColor = System.Drawing.Color.Gainsboro;
            this.pgCompanies.Controls.Add(this.btnExportToExcelCompanies);
            this.pgCompanies.Controls.Add(this.btnRefreshCompany);
            this.pgCompanies.Controls.Add(this.lsCompanies);
            this.pgCompanies.Controls.Add(this.lblCompanies);
            this.pgCompanies.Controls.Add(this.btnCompanyEdit);
            this.pgCompanies.Controls.Add(this.btnCompanyDelete);
            this.pgCompanies.Controls.Add(this.btnCompanyAdd);
            this.pgCompanies.Location = new System.Drawing.Point(4, 27);
            this.pgCompanies.Name = "pgCompanies";
            this.pgCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.pgCompanies.Size = new System.Drawing.Size(1480, 591);
            this.pgCompanies.TabIndex = 5;
            this.pgCompanies.Text = "Companies ";
            // 
            // btnExportToExcelCompanies
            // 
            this.btnExportToExcelCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelCompanies.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelCompanies.Location = new System.Drawing.Point(1309, 6);
            this.btnExportToExcelCompanies.Name = "btnExportToExcelCompanies";
            this.btnExportToExcelCompanies.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelCompanies.TabIndex = 16;
            this.btnExportToExcelCompanies.Text = "Export to Excel";
            this.btnExportToExcelCompanies.UseVisualStyleBackColor = true;
            this.btnExportToExcelCompanies.Click += new System.EventHandler(this.btnExportToExcelCompanies_Click);
            // 
            // btnRefreshCompany
            // 
            this.btnRefreshCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshCompany.Location = new System.Drawing.Point(9, 6);
            this.btnRefreshCompany.Name = "btnRefreshCompany";
            this.btnRefreshCompany.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshCompany.TabIndex = 10;
            this.btnRefreshCompany.Text = "Refresh";
            this.btnRefreshCompany.UseVisualStyleBackColor = true;
            this.btnRefreshCompany.Click += new System.EventHandler(this.btnRefreshCompany_Click);
            // 
            // lsCompanies
            // 
            this.lsCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsCompanies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colAddress,
            this.colPhoneNr,
            this.colWebSite});
            this.lsCompanies.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsCompanies.ForeColor = System.Drawing.Color.Black;
            this.lsCompanies.FullRowSelect = true;
            this.lsCompanies.GridLines = true;
            this.lsCompanies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsCompanies.HideSelection = false;
            this.lsCompanies.Location = new System.Drawing.Point(9, 44);
            this.lsCompanies.MultiSelect = false;
            this.lsCompanies.Name = "lsCompanies";
            this.lsCompanies.ShowItemToolTips = true;
            this.lsCompanies.Size = new System.Drawing.Size(1463, 475);
            this.lsCompanies.TabIndex = 9;
            this.lsCompanies.UseCompatibleStateImageBehavior = false;
            this.lsCompanies.View = System.Windows.Forms.View.Details;
            this.lsCompanies.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsCompanies_ColumnWidthChanging);
            this.lsCompanies.SelectedIndexChanged += new System.EventHandler(this.lsCompanies_SelectedIndexChanged);
            this.lsCompanies.DoubleClick += new System.EventHandler(this.lsCompanies_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 0;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colName.Width = 200;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAddress.Width = 360;
            // 
            // colPhoneNr
            // 
            this.colPhoneNr.Text = "Phone Number";
            this.colPhoneNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPhoneNr.Width = 141;
            // 
            // colWebSite
            // 
            this.colWebSite.Text = "Web Site";
            this.colWebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colWebSite.Width = 280;
            // 
            // lblCompanies
            // 
            this.lblCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompanies.AutoSize = true;
            this.lblCompanies.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCompanies.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanies.Location = new System.Drawing.Point(680, 15);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(113, 20);
            this.lblCompanies.TabIndex = 8;
            this.lblCompanies.Text = "Companies";
            this.lblCompanies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompanyEdit
            // 
            this.btnCompanyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompanyEdit.Enabled = false;
            this.btnCompanyEdit.Location = new System.Drawing.Point(1168, 525);
            this.btnCompanyEdit.Name = "btnCompanyEdit";
            this.btnCompanyEdit.Size = new System.Drawing.Size(135, 39);
            this.btnCompanyEdit.TabIndex = 7;
            this.btnCompanyEdit.Text = "Edit Company ";
            this.btnCompanyEdit.UseVisualStyleBackColor = true;
            this.btnCompanyEdit.Click += new System.EventHandler(this.btnCompanyEdit_Click);
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompanyDelete.Enabled = false;
            this.btnCompanyDelete.Location = new System.Drawing.Point(1309, 525);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(163, 39);
            this.btnCompanyDelete.TabIndex = 6;
            this.btnCompanyDelete.Text = "Delete Company ";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompanyAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCompanyAdd.Location = new System.Drawing.Point(996, 525);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(166, 39);
            this.btnCompanyAdd.TabIndex = 5;
            this.btnCompanyAdd.Text = "Add New Company ";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // pgProducts
            // 
            this.pgProducts.BackColor = System.Drawing.Color.Gainsboro;
            this.pgProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgProducts.Controls.Add(this.btnExportToExcelItems);
            this.pgProducts.Controls.Add(this.btnViewItemGroups);
            this.pgProducts.Controls.Add(this.btnItemEdit);
            this.pgProducts.Controls.Add(this.btnItemDelete);
            this.pgProducts.Controls.Add(this.btnItemsAdd);
            this.pgProducts.Controls.Add(this.lsItems);
            this.pgProducts.Controls.Add(this.btnRefreshItems);
            this.pgProducts.Controls.Add(this.lblItems);
            this.pgProducts.Location = new System.Drawing.Point(4, 27);
            this.pgProducts.Name = "pgProducts";
            this.pgProducts.Padding = new System.Windows.Forms.Padding(3);
            this.pgProducts.Size = new System.Drawing.Size(1480, 591);
            this.pgProducts.TabIndex = 2;
            this.pgProducts.Text = "Products & Items ";
            // 
            // btnExportToExcelItems
            // 
            this.btnExportToExcelItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelItems.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelItems.Location = new System.Drawing.Point(1309, 6);
            this.btnExportToExcelItems.Name = "btnExportToExcelItems";
            this.btnExportToExcelItems.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelItems.TabIndex = 19;
            this.btnExportToExcelItems.Text = "Export to Excel";
            this.btnExportToExcelItems.UseVisualStyleBackColor = true;
            this.btnExportToExcelItems.Click += new System.EventHandler(this.btnExportToExcelItems_Click);
            // 
            // btnViewItemGroups
            // 
            this.btnViewItemGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewItemGroups.Location = new System.Drawing.Point(134, 6);
            this.btnViewItemGroups.Name = "btnViewItemGroups";
            this.btnViewItemGroups.Size = new System.Drawing.Size(172, 32);
            this.btnViewItemGroups.TabIndex = 18;
            this.btnViewItemGroups.Text = "View Item Groups";
            this.btnViewItemGroups.UseVisualStyleBackColor = true;
            this.btnViewItemGroups.Click += new System.EventHandler(this.btnViewItemGroups_Click);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemEdit.Enabled = false;
            this.btnItemEdit.Location = new System.Drawing.Point(1167, 524);
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.Size = new System.Drawing.Size(135, 39);
            this.btnItemEdit.TabIndex = 17;
            this.btnItemEdit.Text = "Edit Item";
            this.btnItemEdit.UseVisualStyleBackColor = true;
            this.btnItemEdit.Click += new System.EventHandler(this.btnItemEdit_Click);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDelete.Enabled = false;
            this.btnItemDelete.Location = new System.Drawing.Point(1308, 524);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(163, 39);
            this.btnItemDelete.TabIndex = 16;
            this.btnItemDelete.Text = "Delete Item";
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemsAdd
            // 
            this.btnItemsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemsAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnItemsAdd.Location = new System.Drawing.Point(995, 524);
            this.btnItemsAdd.Name = "btnItemsAdd";
            this.btnItemsAdd.Size = new System.Drawing.Size(166, 39);
            this.btnItemsAdd.TabIndex = 15;
            this.btnItemsAdd.Text = "Add New Item";
            this.btnItemsAdd.UseVisualStyleBackColor = true;
            this.btnItemsAdd.Click += new System.EventHandler(this.btnItemsAdd_Click);
            // 
            // lsItems
            // 
            this.lsItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemID,
            this.colItemName,
            this.colDescription,
            this.colItemGroup,
            this.colPrice,
            this.colDiscount,
            this.colCompany});
            this.lsItems.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsItems.ForeColor = System.Drawing.Color.Black;
            this.lsItems.FullRowSelect = true;
            this.lsItems.GridLines = true;
            this.lsItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsItems.HideSelection = false;
            this.lsItems.Location = new System.Drawing.Point(8, 39);
            this.lsItems.MultiSelect = false;
            this.lsItems.Name = "lsItems";
            this.lsItems.ShowItemToolTips = true;
            this.lsItems.Size = new System.Drawing.Size(1463, 479);
            this.lsItems.TabIndex = 14;
            this.lsItems.UseCompatibleStateImageBehavior = false;
            this.lsItems.View = System.Windows.Forms.View.Details;
            this.lsItems.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsItems_ColumnWidthChanging);
            this.lsItems.SelectedIndexChanged += new System.EventHandler(this.lsItems_SelectedIndexChanged);
            this.lsItems.DoubleClick += new System.EventHandler(this.lsItems_DoubleClick);
            // 
            // colItemID
            // 
            this.colItemID.Text = "ItemID";
            this.colItemID.Width = 0;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Name";
            this.colItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colItemName.Width = 210;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDescription.Width = 300;
            // 
            // colItemGroup
            // 
            this.colItemGroup.Text = "Item Group";
            this.colItemGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colItemGroup.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrice.Width = 95;
            // 
            // colDiscount
            // 
            this.colDiscount.Text = "Discount";
            this.colDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDiscount.Width = 95;
            // 
            // colCompany
            // 
            this.colCompany.Text = "Company";
            this.colCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCompany.Width = 280;
            // 
            // btnRefreshItems
            // 
            this.btnRefreshItems.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshItems.Location = new System.Drawing.Point(7, 6);
            this.btnRefreshItems.Name = "btnRefreshItems";
            this.btnRefreshItems.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshItems.TabIndex = 11;
            this.btnRefreshItems.Text = "Refresh";
            this.btnRefreshItems.UseVisualStyleBackColor = true;
            this.btnRefreshItems.Click += new System.EventHandler(this.btnRefreshItems_Click);
            // 
            // lblItems
            // 
            this.lblItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItems.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(637, 6);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(196, 20);
            this.lblItems.TabIndex = 9;
            this.lblItems.Text = "Products and Items";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgItemGroups
            // 
            this.pgItemGroups.BackColor = System.Drawing.Color.Gainsboro;
            this.pgItemGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgItemGroups.Controls.Add(this.btnExportToExcelItemGroups);
            this.pgItemGroups.Controls.Add(this.lblItemGroups);
            this.pgItemGroups.Controls.Add(this.btnEditItemGroup);
            this.pgItemGroups.Controls.Add(this.btnDeleteItemGroup);
            this.pgItemGroups.Controls.Add(this.btnAddNewItemGroup);
            this.pgItemGroups.Controls.Add(this.lsItemGroups);
            this.pgItemGroups.Controls.Add(this.btnRefreshItemGroups);
            this.pgItemGroups.Location = new System.Drawing.Point(4, 27);
            this.pgItemGroups.Name = "pgItemGroups";
            this.pgItemGroups.Padding = new System.Windows.Forms.Padding(3);
            this.pgItemGroups.Size = new System.Drawing.Size(1480, 591);
            this.pgItemGroups.TabIndex = 6;
            this.pgItemGroups.Text = "Item Groups";
            // 
            // btnExportToExcelItemGroups
            // 
            this.btnExportToExcelItemGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelItemGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelItemGroups.Location = new System.Drawing.Point(1310, 6);
            this.btnExportToExcelItemGroups.Name = "btnExportToExcelItemGroups";
            this.btnExportToExcelItemGroups.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelItemGroups.TabIndex = 24;
            this.btnExportToExcelItemGroups.Text = "Export to Excel";
            this.btnExportToExcelItemGroups.UseVisualStyleBackColor = true;
            this.btnExportToExcelItemGroups.Click += new System.EventHandler(this.btnExportToExcelItemGroups_Click);
            // 
            // lblItemGroups
            // 
            this.lblItemGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItemGroups.AutoSize = true;
            this.lblItemGroups.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItemGroups.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroups.Location = new System.Drawing.Point(696, 11);
            this.lblItemGroups.Name = "lblItemGroups";
            this.lblItemGroups.Size = new System.Drawing.Size(129, 20);
            this.lblItemGroups.TabIndex = 23;
            this.lblItemGroups.Text = "Item Groups";
            this.lblItemGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditItemGroup
            // 
            this.btnEditItemGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItemGroup.Enabled = false;
            this.btnEditItemGroup.Location = new System.Drawing.Point(1134, 524);
            this.btnEditItemGroup.Name = "btnEditItemGroup";
            this.btnEditItemGroup.Size = new System.Drawing.Size(169, 39);
            this.btnEditItemGroup.TabIndex = 22;
            this.btnEditItemGroup.Text = "Edit Item Group";
            this.btnEditItemGroup.UseVisualStyleBackColor = true;
            this.btnEditItemGroup.Click += new System.EventHandler(this.btnEditItemGroup_Click);
            // 
            // btnDeleteItemGroup
            // 
            this.btnDeleteItemGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItemGroup.Enabled = false;
            this.btnDeleteItemGroup.Location = new System.Drawing.Point(1309, 524);
            this.btnDeleteItemGroup.Name = "btnDeleteItemGroup";
            this.btnDeleteItemGroup.Size = new System.Drawing.Size(163, 39);
            this.btnDeleteItemGroup.TabIndex = 21;
            this.btnDeleteItemGroup.Text = "Delete Item Group";
            this.btnDeleteItemGroup.UseVisualStyleBackColor = true;
            this.btnDeleteItemGroup.Click += new System.EventHandler(this.btnDeleteItemGroup_Click);
            // 
            // btnAddNewItemGroup
            // 
            this.btnAddNewItemGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewItemGroup.Location = new System.Drawing.Point(940, 524);
            this.btnAddNewItemGroup.Name = "btnAddNewItemGroup";
            this.btnAddNewItemGroup.Size = new System.Drawing.Size(188, 39);
            this.btnAddNewItemGroup.TabIndex = 20;
            this.btnAddNewItemGroup.Text = "Add New Item Group";
            this.btnAddNewItemGroup.UseVisualStyleBackColor = true;
            this.btnAddNewItemGroup.Click += new System.EventHandler(this.btnAddNewItemGroup_Click);
            // 
            // lsItemGroups
            // 
            this.lsItemGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsItemGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsItemGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemGroupID,
            this.colItemGroupName,
            this.colItemGroupText});
            this.lsItemGroups.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsItemGroups.ForeColor = System.Drawing.Color.Black;
            this.lsItemGroups.FullRowSelect = true;
            this.lsItemGroups.GridLines = true;
            this.lsItemGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsItemGroups.HideSelection = false;
            this.lsItemGroups.Location = new System.Drawing.Point(9, 44);
            this.lsItemGroups.MultiSelect = false;
            this.lsItemGroups.Name = "lsItemGroups";
            this.lsItemGroups.ShowItemToolTips = true;
            this.lsItemGroups.Size = new System.Drawing.Size(1463, 474);
            this.lsItemGroups.TabIndex = 19;
            this.lsItemGroups.UseCompatibleStateImageBehavior = false;
            this.lsItemGroups.View = System.Windows.Forms.View.Details;
            this.lsItemGroups.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsItemGroups_ColumnWidthChanging);
            this.lsItemGroups.SelectedIndexChanged += new System.EventHandler(this.lsItemGroups_SelectedIndexChanged);
            this.lsItemGroups.DoubleClick += new System.EventHandler(this.lsItemGroups_DoubleClick);
            // 
            // colItemGroupID
            // 
            this.colItemGroupID.Text = "ID";
            this.colItemGroupID.Width = 0;
            // 
            // colItemGroupName
            // 
            this.colItemGroupName.Text = "Name";
            this.colItemGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colItemGroupName.Width = 220;
            // 
            // colItemGroupText
            // 
            this.colItemGroupText.Text = "Description";
            this.colItemGroupText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colItemGroupText.Width = 475;
            // 
            // btnRefreshItemGroups
            // 
            this.btnRefreshItemGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshItemGroups.Location = new System.Drawing.Point(8, 6);
            this.btnRefreshItemGroups.Name = "btnRefreshItemGroups";
            this.btnRefreshItemGroups.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshItemGroups.TabIndex = 18;
            this.btnRefreshItemGroups.Text = "Refresh";
            this.btnRefreshItemGroups.UseVisualStyleBackColor = true;
            this.btnRefreshItemGroups.Click += new System.EventHandler(this.btnRefreshItemGroups_Click);
            // 
            // pgReports
            // 
            this.pgReports.BackColor = System.Drawing.Color.Gainsboro;
            this.pgReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgReports.Location = new System.Drawing.Point(4, 27);
            this.pgReports.Name = "pgReports";
            this.pgReports.Padding = new System.Windows.Forms.Padding(3);
            this.pgReports.Size = new System.Drawing.Size(1480, 591);
            this.pgReports.TabIndex = 3;
            this.pgReports.Text = "Reports & Metrics ";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1488, 650);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(940, 500);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM Voice";
            this.MaximumSizeChanged += new System.EventHandler(this.frmMain_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.frmMain_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.pgInvoices.ResumeLayout(false);
            this.pgInvoices.PerformLayout();
            this.pgBusinesses.ResumeLayout(false);
            this.pgBusinesses.PerformLayout();
            this.pgClients.ResumeLayout(false);
            this.pgClients.PerformLayout();
            this.pgCompanies.ResumeLayout(false);
            this.pgCompanies.PerformLayout();
            this.pgProducts.ResumeLayout(false);
            this.pgProducts.PerformLayout();
            this.pgItemGroups.ResumeLayout(false);
            this.pgItemGroups.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MenuStrip menuStripMain;
        public ToolStripMenuItem menuMain;
        public ToolStripMenuItem newToolStripMenuItem;
        public ToolStripMenuItem customerToolStripMenuItem;
        public ToolStripMenuItem productToolStripMenuItem;
        public ToolStripMenuItem invoiceToolStripMenuItem;
        public ToolStripMenuItem settingsToolStripMenuItem;
        public ToolStripMenuItem exitToolStripMenuItem;
        public StatusStrip statusStrip1;
        public ToolStripMenuItem reportToolStripMenuItem;
        public ToolStripMenuItem viewToolStripMenuItem;
        public ToolStripMenuItem clientsToolStripMenuItem;
        public ToolStripMenuItem productsToolStripMenuItem;
        public ToolStripMenuItem invoicesToolStripMenuItem;
        public ToolStripMenuItem reportsToolStripMenuItem;
        public ToolStripStatusLabel lblStatusBar;
        private TabPage pgInvoices;
        private TabPage pgClients;
        public TabControl tabMain;
        private TabPage pgProducts;
        private TabPage pgReports;
        public Label lblInvoiceList;
        private TabPage pgCompanies;
        private ToolStripMenuItem companyToolStripMenuItem;
        private ToolStripMenuItem companiesToolStripMenuItem;
        public Button btnCompanyEdit;
        public Button btnCompanyDelete;
        public Button btnCompanyAdd;
        public Label lblCompanies;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        public ToolStripMenuItem adminSettingsToolStripMenuItem;
        public ColumnHeader colID;
        public ColumnHeader colName;
        public ColumnHeader colAddress;
        public ColumnHeader colPhoneNr;
        public ColumnHeader colWebSite;
        public ListView lsCompanies;
        private Button btnRefreshCompany;
        public Label lblClients;
        public Button btnClientEdit;
        public Button btnClientDelete;
        public Button btnClientAdd;
        public ListView lsClients;
        private ColumnHeader colClientID;
        private ColumnHeader colClientName;
        private ColumnHeader colAddr;
        private ColumnHeader colCompanyName;
        private Button btnRefreshClient;
        private ToolStripMenuItem itemGroupToolStripMenuItem;
        public Button btnItemEdit;
        public Button btnItemDelete;
        public Button btnItemsAdd;
        public ListView lsItems;
        private Button btnRefreshItems;
        public Label lblItems;
        public ColumnHeader colItemID;
        public ColumnHeader colItemName;
        public ColumnHeader colDescription;
        public ColumnHeader colPrice;
        public ColumnHeader colDiscount;
        public ColumnHeader colCompany;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem itemGroupsToolStripMenuItem;
        private Button btnViewItemGroups;
        private TabPage pgItemGroups;
        public Label lblItemGroups;
        public Button btnEditItemGroup;
        public Button btnDeleteItemGroup;
        public Button btnAddNewItemGroup;
        public ListView lsItemGroups;
        public ColumnHeader colItemGroupID;
        public ColumnHeader colItemGroupName;
        public ColumnHeader colItemGroupText;
        private Button btnRefreshItemGroups;
        public ColumnHeader colItemGroup;
        private Button btnExportToExcelClients;
        private Button btnExportToExcelCompanies;
        private Button btnExportToExcelItems;
        private Button btnExportToExcelItemGroups;
        private Button btnRefreshInvoices;
        public Button btnEditInvoice;
        public Button btnDeleteInvoice;
        public Button btnAddInvoice;
        public ListView lsInvoices;
        public ColumnHeader colInvoiceID;
        public ColumnHeader colInvoiceNr;
        public ColumnHeader colAmountDue;
        public ColumnHeader colSalesTax;
        public ColumnHeader colDiscnt;
        public ColumnHeader colIssueDt;
        public ColumnHeader colDueDt;
        public ColumnHeader colPaid;
        public ColumnHeader colClient;
        public ColumnHeader colComp;
        public ColumnHeader colTotal;
        private Button btnExportToExcelInvoices;
        public Button btnGenerateInvoice;
        private Button btnOpenFinanceCalc;
        private ToolStripMenuItem businessToolStripMenuItem;
        private ToolStripMenuItem businessesToolStripMenuItem;
        private TabPage pgBusinesses;
        public Label lblBusinesses;
        private Button btnExportToExcelBusinesses;
        private Button btnRefreshBusinesses;
        public ListView lsBusinesses;
        public ColumnHeader colBusinessID;
        public ColumnHeader colBusinessName;
        public ColumnHeader colBusinessAddress;
        public ColumnHeader colBusinessPhone;
        public ColumnHeader colBusinessWeb;
        public Button btnEditBusiness;
        public Button btnDeleteBusiness;
        public Button btnAddBusiness;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripMenuItem openGuideToolStripMenuItem;
        public ColumnHeader colBusiness;
    }
}
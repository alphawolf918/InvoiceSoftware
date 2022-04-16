
namespace InvoiceSoftware.Forms {
    partial class frmInvoiceAdd {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceAdd));
            this.lblItemAdd = new System.Windows.Forms.Label();
            this.txtInvoiceDt = new System.Windows.Forms.TextBox();
            this.lblInvoiceDt = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnInvoiceAddCompany = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.grpCompanyClients = new System.Windows.Forms.GroupBox();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.dpIssueDt = new System.Windows.Forms.DateTimePicker();
            this.txtPaidDt = new System.Windows.Forms.TextBox();
            this.lblPaidDt = new System.Windows.Forms.Label();
            this.txtSupplyDt = new System.Windows.Forms.TextBox();
            this.lblInvoiceSupplyDt = new System.Windows.Forms.Label();
            this.txtDueDt = new System.Windows.Forms.TextBox();
            this.lblDueDt = new System.Windows.Forms.Label();
            this.dpDueDt = new System.Windows.Forms.DateTimePicker();
            this.dpSupplyDt = new System.Windows.Forms.DateTimePicker();
            this.dpPaidDt = new System.Windows.Forms.DateTimePicker();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.grpFinances = new System.Windows.Forms.GroupBox();
            this.btnOpenFinanceCalc = new System.Windows.Forms.Button();
            this.txtPayTerms = new System.Windows.Forms.TextBox();
            this.lblPayTerms = new System.Windows.Forms.Label();
            this.txtTaxPct = new System.Windows.Forms.TextBox();
            this.lblTaxPct = new System.Windows.Forms.Label();
            this.txtDiscountPct = new System.Windows.Forms.TextBox();
            this.lblDiscountPct = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.btnSaveGenerate = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.LBLnOTES = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.grpCompanyClients.SuspendLayout();
            this.grpDates.SuspendLayout();
            this.grpFinances.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemAdd
            // 
            this.lblItemAdd.AutoSize = true;
            this.lblItemAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAdd.Location = new System.Drawing.Point(369, 9);
            this.lblItemAdd.Name = "lblItemAdd";
            this.lblItemAdd.Size = new System.Drawing.Size(267, 25);
            this.lblItemAdd.TabIndex = 28;
            this.lblItemAdd.Text = "CREATE NEW INVOICE";
            this.lblItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInvoiceDt
            // 
            this.txtInvoiceDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDt.Location = new System.Drawing.Point(220, 32);
            this.txtInvoiceDt.Name = "txtInvoiceDt";
            this.txtInvoiceDt.Size = new System.Drawing.Size(177, 26);
            this.txtInvoiceDt.TabIndex = 34;
            this.txtInvoiceDt.WordWrap = false;
            // 
            // lblInvoiceDt
            // 
            this.lblInvoiceDt.AutoSize = true;
            this.lblInvoiceDt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDt.Location = new System.Drawing.Point(7, 32);
            this.lblInvoiceDt.Name = "lblInvoiceDt";
            this.lblInvoiceDt.Size = new System.Drawing.Size(213, 20);
            this.lblInvoiceDt.TabIndex = 35;
            this.lblInvoiceDt.Text = "* Invoice Issue Date:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(6, 36);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(122, 20);
            this.lblCompany.TabIndex = 32;
            this.lblCompany.Text = "* Company:";
            // 
            // cbCompany
            // 
            this.cbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(134, 36);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(220, 26);
            this.cbCompany.TabIndex = 31;
            // 
            // btnInvoiceAddCompany
            // 
            this.btnInvoiceAddCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceAddCompany.Location = new System.Drawing.Point(134, 68);
            this.btnInvoiceAddCompany.Name = "btnInvoiceAddCompany";
            this.btnInvoiceAddCompany.Size = new System.Drawing.Size(156, 32);
            this.btnInvoiceAddCompany.TabIndex = 33;
            this.btnInvoiceAddCompany.Text = "Add Company";
            this.btnInvoiceAddCompany.UseVisualStyleBackColor = true;
            this.btnInvoiceAddCompany.Click += new System.EventHandler(this.btnInvoiceAddCompany_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(23, 112);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(71, 20);
            this.lblClient.TabIndex = 35;
            this.lblClient.Text = "Client:";
            // 
            // cbClients
            // 
            this.cbClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClients.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(134, 112);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(220, 26);
            this.cbClients.TabIndex = 34;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(134, 144);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(156, 32);
            this.btnAddClient.TabIndex = 36;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // grpCompanyClients
            // 
            this.grpCompanyClients.Controls.Add(this.btnAddClient);
            this.grpCompanyClients.Controls.Add(this.cbClients);
            this.grpCompanyClients.Controls.Add(this.lblClient);
            this.grpCompanyClients.Controls.Add(this.btnInvoiceAddCompany);
            this.grpCompanyClients.Controls.Add(this.cbCompany);
            this.grpCompanyClients.Controls.Add(this.lblCompany);
            this.grpCompanyClients.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompanyClients.Location = new System.Drawing.Point(516, 64);
            this.grpCompanyClients.Name = "grpCompanyClients";
            this.grpCompanyClients.Size = new System.Drawing.Size(393, 183);
            this.grpCompanyClients.TabIndex = 36;
            this.grpCompanyClients.TabStop = false;
            this.grpCompanyClients.Text = "Invoice To";
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.txtInvoiceDt);
            this.grpDates.Controls.Add(this.dpIssueDt);
            this.grpDates.Controls.Add(this.txtPaidDt);
            this.grpDates.Controls.Add(this.lblPaidDt);
            this.grpDates.Controls.Add(this.txtSupplyDt);
            this.grpDates.Controls.Add(this.lblInvoiceSupplyDt);
            this.grpDates.Controls.Add(this.txtDueDt);
            this.grpDates.Controls.Add(this.lblDueDt);
            this.grpDates.Controls.Add(this.lblInvoiceDt);
            this.grpDates.Controls.Add(this.dpDueDt);
            this.grpDates.Controls.Add(this.dpSupplyDt);
            this.grpDates.Controls.Add(this.dpPaidDt);
            this.grpDates.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDates.Location = new System.Drawing.Point(12, 64);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(477, 183);
            this.grpDates.TabIndex = 37;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "Invoice Dates";
            // 
            // dpIssueDt
            // 
            this.dpIssueDt.CustomFormat = "MM/dd/yyyy";
            this.dpIssueDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpIssueDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpIssueDt.Location = new System.Drawing.Point(220, 32);
            this.dpIssueDt.Name = "dpIssueDt";
            this.dpIssueDt.Size = new System.Drawing.Size(217, 26);
            this.dpIssueDt.TabIndex = 42;
            this.dpIssueDt.Value = new System.DateTime(2021, 9, 27, 0, 0, 0, 0);
            this.dpIssueDt.ValueChanged += new System.EventHandler(this.dpIssueDt_ValueChanged);
            // 
            // txtPaidDt
            // 
            this.txtPaidDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidDt.Location = new System.Drawing.Point(220, 142);
            this.txtPaidDt.Name = "txtPaidDt";
            this.txtPaidDt.Size = new System.Drawing.Size(177, 26);
            this.txtPaidDt.TabIndex = 40;
            this.txtPaidDt.WordWrap = false;
            // 
            // lblPaidDt
            // 
            this.lblPaidDt.AutoSize = true;
            this.lblPaidDt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidDt.Location = new System.Drawing.Point(7, 143);
            this.lblPaidDt.Name = "lblPaidDt";
            this.lblPaidDt.Size = new System.Drawing.Size(184, 20);
            this.lblPaidDt.TabIndex = 41;
            this.lblPaidDt.Text = "Invoice Paid Date:";
            // 
            // txtSupplyDt
            // 
            this.txtSupplyDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplyDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplyDt.Location = new System.Drawing.Point(220, 106);
            this.txtSupplyDt.Name = "txtSupplyDt";
            this.txtSupplyDt.Size = new System.Drawing.Size(177, 26);
            this.txtSupplyDt.TabIndex = 38;
            this.txtSupplyDt.WordWrap = false;
            // 
            // lblInvoiceSupplyDt
            // 
            this.lblInvoiceSupplyDt.AutoSize = true;
            this.lblInvoiceSupplyDt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceSupplyDt.Location = new System.Drawing.Point(7, 107);
            this.lblInvoiceSupplyDt.Name = "lblInvoiceSupplyDt";
            this.lblInvoiceSupplyDt.Size = new System.Drawing.Size(208, 20);
            this.lblInvoiceSupplyDt.TabIndex = 39;
            this.lblInvoiceSupplyDt.Text = "Invoice Supply Date:";
            // 
            // txtDueDt
            // 
            this.txtDueDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDueDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDt.Location = new System.Drawing.Point(220, 69);
            this.txtDueDt.Name = "txtDueDt";
            this.txtDueDt.Size = new System.Drawing.Size(177, 26);
            this.txtDueDt.TabIndex = 36;
            this.txtDueDt.WordWrap = false;
            // 
            // lblDueDt
            // 
            this.lblDueDt.AutoSize = true;
            this.lblDueDt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDt.Location = new System.Drawing.Point(7, 70);
            this.lblDueDt.Name = "lblDueDt";
            this.lblDueDt.Size = new System.Drawing.Size(180, 20);
            this.lblDueDt.TabIndex = 37;
            this.lblDueDt.Text = "Invoice Due Date:";
            // 
            // dpDueDt
            // 
            this.dpDueDt.CustomFormat = "MM/dd/yyyy";
            this.dpDueDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDueDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDueDt.Location = new System.Drawing.Point(220, 69);
            this.dpDueDt.Name = "dpDueDt";
            this.dpDueDt.Size = new System.Drawing.Size(217, 26);
            this.dpDueDt.TabIndex = 43;
            this.dpDueDt.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            this.dpDueDt.ValueChanged += new System.EventHandler(this.dpDueDt_ValueChanged);
            // 
            // dpSupplyDt
            // 
            this.dpSupplyDt.CustomFormat = "MM/dd/yyyy";
            this.dpSupplyDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSupplyDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSupplyDt.Location = new System.Drawing.Point(220, 106);
            this.dpSupplyDt.Name = "dpSupplyDt";
            this.dpSupplyDt.Size = new System.Drawing.Size(217, 26);
            this.dpSupplyDt.TabIndex = 44;
            this.dpSupplyDt.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            this.dpSupplyDt.ValueChanged += new System.EventHandler(this.dpSupplyDt_ValueChanged);
            // 
            // dpPaidDt
            // 
            this.dpPaidDt.CustomFormat = "MM/dd/yyyy";
            this.dpPaidDt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPaidDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpPaidDt.Location = new System.Drawing.Point(220, 142);
            this.dpPaidDt.Name = "dpPaidDt";
            this.dpPaidDt.Size = new System.Drawing.Size(217, 26);
            this.dpPaidDt.TabIndex = 45;
            this.dpPaidDt.Value = new System.DateTime(2021, 10, 6, 0, 0, 0, 0);
            this.dpPaidDt.ValueChanged += new System.EventHandler(this.dpPaidDt_ValueChanged);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddInvoice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInvoice.Image")));
            this.btnAddInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInvoice.Location = new System.Drawing.Point(611, 676);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(111, 39);
            this.btnAddInvoice.TabIndex = 38;
            this.btnAddInvoice.Text = "Save";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // grpFinances
            // 
            this.grpFinances.Controls.Add(this.btnOpenFinanceCalc);
            this.grpFinances.Controls.Add(this.txtPayTerms);
            this.grpFinances.Controls.Add(this.lblPayTerms);
            this.grpFinances.Controls.Add(this.txtTaxPct);
            this.grpFinances.Controls.Add(this.lblTaxPct);
            this.grpFinances.Controls.Add(this.txtDiscountPct);
            this.grpFinances.Controls.Add(this.lblDiscountPct);
            this.grpFinances.Controls.Add(this.txtAmountDue);
            this.grpFinances.Controls.Add(this.lblAmountDue);
            this.grpFinances.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFinances.Location = new System.Drawing.Point(12, 279);
            this.grpFinances.Name = "grpFinances";
            this.grpFinances.Size = new System.Drawing.Size(897, 185);
            this.grpFinances.TabIndex = 39;
            this.grpFinances.TabStop = false;
            this.grpFinances.Text = "Payment Information";
            // 
            // btnOpenFinanceCalc
            // 
            this.btnOpenFinanceCalc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenFinanceCalc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFinanceCalc.Location = new System.Drawing.Point(164, 137);
            this.btnOpenFinanceCalc.Name = "btnOpenFinanceCalc";
            this.btnOpenFinanceCalc.Size = new System.Drawing.Size(166, 32);
            this.btnOpenFinanceCalc.TabIndex = 44;
            this.btnOpenFinanceCalc.Text = "Financial Calculator";
            this.btnOpenFinanceCalc.UseVisualStyleBackColor = true;
            this.btnOpenFinanceCalc.Click += new System.EventHandler(this.btnOpenFinanceCalc_Click);
            // 
            // txtPayTerms
            // 
            this.txtPayTerms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayTerms.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayTerms.Location = new System.Drawing.Point(504, 34);
            this.txtPayTerms.Multiline = true;
            this.txtPayTerms.Name = "txtPayTerms";
            this.txtPayTerms.Size = new System.Drawing.Size(377, 135);
            this.txtPayTerms.TabIndex = 42;
            this.txtPayTerms.WordWrap = false;
            // 
            // lblPayTerms
            // 
            this.lblPayTerms.AutoSize = true;
            this.lblPayTerms.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayTerms.Location = new System.Drawing.Point(500, 11);
            this.lblPayTerms.Name = "lblPayTerms";
            this.lblPayTerms.Size = new System.Drawing.Size(182, 20);
            this.lblPayTerms.TabIndex = 43;
            this.lblPayTerms.Text = "* Payment Terms:";
            // 
            // txtTaxPct
            // 
            this.txtTaxPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxPct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxPct.Location = new System.Drawing.Point(164, 105);
            this.txtTaxPct.Name = "txtTaxPct";
            this.txtTaxPct.Size = new System.Drawing.Size(166, 26);
            this.txtTaxPct.TabIndex = 40;
            this.txtTaxPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxPct.WordWrap = false;
            // 
            // lblTaxPct
            // 
            this.lblTaxPct.AutoSize = true;
            this.lblTaxPct.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPct.Location = new System.Drawing.Point(6, 105);
            this.lblTaxPct.Name = "lblTaxPct";
            this.lblTaxPct.Size = new System.Drawing.Size(96, 20);
            this.lblTaxPct.TabIndex = 41;
            this.lblTaxPct.Text = "* Tax %:";
            // 
            // txtDiscountPct
            // 
            this.txtDiscountPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPct.Location = new System.Drawing.Point(164, 71);
            this.txtDiscountPct.Name = "txtDiscountPct";
            this.txtDiscountPct.Size = new System.Drawing.Size(166, 26);
            this.txtDiscountPct.TabIndex = 38;
            this.txtDiscountPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPct.WordWrap = false;
            // 
            // lblDiscountPct
            // 
            this.lblDiscountPct.AutoSize = true;
            this.lblDiscountPct.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPct.Location = new System.Drawing.Point(6, 71);
            this.lblDiscountPct.Name = "lblDiscountPct";
            this.lblDiscountPct.Size = new System.Drawing.Size(146, 20);
            this.lblDiscountPct.TabIndex = 39;
            this.lblDiscountPct.Text = "* Discount %:";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountDue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(164, 37);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(166, 26);
            this.txtAmountDue.TabIndex = 36;
            this.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountDue.WordWrap = false;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(6, 37);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(152, 20);
            this.lblAmountDue.TabIndex = 37;
            this.lblAmountDue.Text = "* Amount Due:";
            // 
            // btnSaveGenerate
            // 
            this.btnSaveGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveGenerate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGenerate.Image")));
            this.btnSaveGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveGenerate.Location = new System.Drawing.Point(728, 676);
            this.btnSaveGenerate.Name = "btnSaveGenerate";
            this.btnSaveGenerate.Size = new System.Drawing.Size(165, 39);
            this.btnSaveGenerate.TabIndex = 40;
            this.btnSaveGenerate.Text = "Save and Generate";
            this.btnSaveGenerate.UseVisualStyleBackColor = true;
            this.btnSaveGenerate.Click += new System.EventHandler(this.btnSaveGenerate_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtNotes);
            this.grpSummary.Controls.Add(this.LBLnOTES);
            this.grpSummary.Controls.Add(this.txtSummary);
            this.grpSummary.Controls.Add(this.lblSummary);
            this.grpSummary.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(12, 470);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(897, 200);
            this.grpSummary.TabIndex = 41;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary and Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(504, 49);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(377, 144);
            this.txtNotes.TabIndex = 40;
            this.txtNotes.WordWrap = false;
            // 
            // LBLnOTES
            // 
            this.LBLnOTES.AutoSize = true;
            this.LBLnOTES.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnOTES.Location = new System.Drawing.Point(500, 26);
            this.LBLnOTES.Name = "LBLnOTES";
            this.LBLnOTES.Size = new System.Drawing.Size(216, 20);
            this.LBLnOTES.TabIndex = 41;
            this.LBLnOTES.Text = "Notes (internal only):";
            // 
            // txtSummary
            // 
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary.Location = new System.Drawing.Point(10, 49);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(427, 144);
            this.txtSummary.TabIndex = 38;
            this.txtSummary.WordWrap = false;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(6, 26);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(330, 20);
            this.lblSummary.TabIndex = 39;
            this.lblSummary.Text = "* Summary (appears on Invoice):";
            // 
            // frmInvoiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(905, 728);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnSaveGenerate);
            this.Controls.Add(this.grpFinances);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpCompanyClients);
            this.Controls.Add(this.lblItemAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoiceAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Invoice";
            this.Load += new System.EventHandler(this.frmInvoiceAdd_Load);
            this.grpCompanyClients.ResumeLayout(false);
            this.grpCompanyClients.PerformLayout();
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            this.grpFinances.ResumeLayout(false);
            this.grpFinances.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemAdd;
        public System.Windows.Forms.TextBox txtInvoiceDt;
        private System.Windows.Forms.Label lblInvoiceDt;
        private System.Windows.Forms.Label lblCompany;
        public System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btnInvoiceAddCompany;
        private System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox grpCompanyClients;
        private System.Windows.Forms.GroupBox grpDates;
        public System.Windows.Forms.TextBox txtDueDt;
        private System.Windows.Forms.Label lblDueDt;
        private System.Windows.Forms.Button btnAddInvoice;
        public System.Windows.Forms.TextBox txtSupplyDt;
        private System.Windows.Forms.Label lblInvoiceSupplyDt;
        public System.Windows.Forms.TextBox txtPaidDt;
        private System.Windows.Forms.Label lblPaidDt;
        private System.Windows.Forms.GroupBox grpFinances;
        public System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblAmountDue;
        public System.Windows.Forms.TextBox txtDiscountPct;
        private System.Windows.Forms.Label lblDiscountPct;
        public System.Windows.Forms.TextBox txtTaxPct;
        private System.Windows.Forms.Label lblTaxPct;
        public System.Windows.Forms.DateTimePicker dpIssueDt;
        public System.Windows.Forms.DateTimePicker dpDueDt;
        public System.Windows.Forms.DateTimePicker dpPaidDt;
        public System.Windows.Forms.DateTimePicker dpSupplyDt;
        private System.Windows.Forms.Button btnSaveGenerate;
        private System.Windows.Forms.GroupBox grpSummary;
        public System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblSummary;
        public System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label LBLnOTES;
        public System.Windows.Forms.TextBox txtPayTerms;
        private System.Windows.Forms.Label lblPayTerms;
        private System.Windows.Forms.Button btnOpenFinanceCalc;
    }
}
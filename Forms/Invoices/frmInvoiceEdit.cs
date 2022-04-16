using System;
using System.Data;
using System.Data.SqlClient;
using static System.DateTime;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmInvoiceEdit : Form {

        private static long invoiceID = -1;

        private readonly frmCompanyAdd frmAddCompany = new frmCompanyAdd();
        private readonly frmClientAdd frmAddClient = new frmClientAdd();
        private readonly frmItemAdd frmAddItem = new frmItemAdd();
        private readonly frmFinanceCalculator frmFinance = new frmFinanceCalculator();

        private double dblTax;
        private double dblDiscount;
        private double dblAmountDue;
        private DateTime dtInvoice;
        private DateTime dtDue;
        private DateTime dtSupply;
        private DateTime dtPaid;
        private long companyID;
        private long clientID;
        private string strCompany;
        private string strClient;
        private string strSummary;
        private string strNotes;
        private string strPayTerms;

        public frmInvoiceEdit() => InitializeComponent();

        private void frmInvoiceEdit_Load(object sender, EventArgs e) {
            this.ClearEverything();
            this.cbCompany.PopulateData("SELECT [CompanyName] FROM [Company] ORDER BY [CompanyName] ASC;", "CompanyName");
            this.cbClients.PopulateData("SELECT [Name] FROM [Clients] ORDER BY [Name] ASC;", "Name");
            if (invoiceID > 0) {
                string strSQL = "SELECT * FROM [VIEW_InvoiceData] WHERE [InvoiceID] = @ID;";
                try {
                    SqlConnection conn = AAS.SQL_CONN;
                    using (SqlCommand sqlcmd = new SqlCommand(strSQL, conn)) {
                        sqlcmd.AddDynamicParam("@ID", SqlDbType.BigInt, invoiceID);
                        using (SqlDataReader sqlReader = sqlcmd.ExecuteReader()) {
                            while (sqlReader.Read()) {
                                this.dblTax = Utils.MoneyVal(sqlReader["TaxPct"]) * 100.00;
                                this.dblDiscount = Utils.MoneyVal(sqlReader["DiscountPct"]) * 100.00;
                                this.dblAmountDue = Utils.MoneyVal(sqlReader["AmountDue"], false);
                                this.dtInvoice = DateTime.Parse(sqlReader["IssueDt"].ToString());
                                this.dtDue = DateTime.Parse(sqlReader["DueDt"].ToString());
                                this.dtSupply = DateTime.Parse(sqlReader["SupplyDt"].ToString());
                                string pdDt = sqlReader["PaidDt"].ToString();
                                this.dtPaid = (pdDt != "N/A") ? DateTime.Parse(pdDt) : DateTime.Parse("01-JAN-53");
                                this.companyID = Utils.CLng(sqlReader["CompanyID"].ToString());
                                this.clientID = Utils.CLng(sqlReader["ClientID"].ToString());
                                this.strCompany = Utils.SqlFormat(sqlReader["Company"]);
                                this.strClient = Utils.SqlFormat(sqlReader["Client"]);
                                this.strSummary = Utils.SqlFormat(sqlReader["Summary"]);
                                this.strNotes = Utils.SqlFormat(sqlReader["Notes"]);
                                this.strPayTerms = Utils.SqlFormat(sqlReader["PayTerms"]);
                            }
                            sqlReader.Close();
                            this.txtTaxPct.Text = dblTax.ToString() + '%';
                            this.txtDiscountPct.Text = dblDiscount.ToString() + '%';
                            this.txtAmountDue.Text = '$' + dblAmountDue.ToString();
                            this.txtInvoiceDt.Text = this.dtInvoice.ToString();
                            this.txtDueDt.Text = this.dtDue.ToString();
                            this.txtSupplyDt.Text = this.dtSupply.ToString();
                            if (this.dtPaid != DateTime.Parse("01/01/1953")) {
                                this.txtPaidDt.Text = this.dtPaid.ToString();
                            }
                            this.dpIssueDt.Text = this.txtInvoiceDt.Text;
                            this.dpDueDt.Text = this.txtDueDt.Text;
                            this.dpSupplyDt.Text = this.txtSupplyDt.Text;
                            this.dpPaidDt.Text = this.txtPaidDt.Text;
                            this.cbCompany.Text = this.strCompany;
                            this.cbClients.Text = this.strClient;
                            this.txtSummary.Text = this.strSummary;
                            this.txtNotes.Text = this.strNotes;
                            this.txtPayTerms.Text = this.strPayTerms;
                        }
                        conn = null;
                    }
                } catch (SqlException ex) {
                    DialogBox.ErrorUnexpected(ex);
                }
            } else {
                DialogBox.Error("Empty Invoice ID.");
            }
        }

        private void InvoiceEdit(object sender, EventArgs e) {
            if (Utils.CheckIfEmptyOrNull(this.txtTaxPct.Text, "Tax")
             || Utils.CheckIfEmptyOrNull(this.txtDiscountPct.Text, "Discount")
             || Utils.CheckIfEmptyOrNull(this.txtAmountDue.Text, "Amount Due")
             || Utils.CheckIfEmptyOrNull(this.cbCompany.Text, "Company")
             || Utils.CheckIfEmptyOrNull(this.txtSummary.Text, "Summary")
             || Utils.CheckIfEmptyOrNull(this.txtPayTerms.Text, "Payment Terms")
            ) {
                return;
            }

            #region Prices
            double tax = Utils.MoneyVal(this.txtTaxPct.Text);
            double discount = Utils.MoneyVal(this.txtDiscountPct.Text);
            double amountDue = Utils.MoneyVal(this.txtAmountDue.Text, false);
            #endregion

            #region Dates
            string strInvoiceDt = Utils.Nz(this.txtInvoiceDt.Text, Now.ToShortDateString());
            string strDueDt = Utils.Nz(this.txtDueDt.Text, Now.AddDays(30).ToShortDateString());
            string strSupplyDt = Utils.Nz(this.txtSupplyDt.Text, strInvoiceDt);
            string strPaidDt = Utils.Nz(this.txtPaidDt.Text, "1/1/1753");

            DateTime invoiceDt = DateTime.Parse(strInvoiceDt);
            DateTime dueDt = DateTime.Parse(strDueDt);
            DateTime supplyDt = DateTime.Parse(strSupplyDt);
            DateTime paidDt = DateTime.Parse(strPaidDt);
            #endregion

            #region Companies and Clients
            string invComp = Utils.SqlFormat(Utils.Nz(this.cbCompany.Text, "--"));
            string invClient = Utils.SqlFormat(Utils.Nz(this.cbClients.Text, "--"));

            string strCompSQL = "SELECT [ID] FROM [Company] WHERE [CompanyName] = @NAME;";
            strCompSQL = strCompSQL.Replace("@NAME", "'" + invComp.Replace("'", "\'") + "'");

            string strClientSQL = "SELECT [ID] FROM [Clients] WHERE [Name] = @NAME;";
            strClientSQL = strClientSQL.Replace("@NAME", "'" + invClient.Replace("'", "\'") + "'");

            string strBusSQL = "SELECT [BusinessID] FROM [VIEW_Users] WHERE [UserID] = @USR_ID;";
            strBusSQL = strBusSQL.Replace("@USR_ID", AAS.GetID().ToString());

            string strBusSQL2 = "SELECT [BusinessID] FROM [Invoices] WHERE [ID] = @ID;";
            strBusSQL2 = strBusSQL2.Replace("@ID", invoiceID.ToString());
            #endregion

            #region Extra Information
            string summary = Utils.SqlFormat(this.txtSummary.Text);
            string notes = Utils.SqlFormat(this.txtNotes.Text);
            string payTerms = Utils.SqlFormat(this.txtPayTerms.Text);
            #endregion

            #region SQL Data Entry
            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "UPDATE [Invoices] SET           " +
                                "[CompanyID] = @COMPANY_ID,      " +
                                "[ClientID] = @CLIENT_ID,        " +
                                "[BusinessID] = @BUSINESS_ID,    " +
                                "[Payment_Terms] = @PAY_TERMS,   " +
                                "[Summary] = @SUMMARY,           " +
                                "[Invoice_Dt] = @INVOICE_DT,     " +
                                "[Supply_Dt] = @SUPPLY_DT,       " +
                                "[Paid_Dt] = @PAID_DT,           " +
                                "[Due_Dt] = @DUE_DT,             " +
                                "[Amount_Payable] = @AMOUNT_DUE, " +
                                "[Sales_Tax] = @TAX,             " +
                                "[Discount] = @DISCOUNT,         " +
                                "[Notes] = @NOTES                " +
                                "WHERE [ID] = @ID;";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    long invCompID = Utils.CLng(DBData.GetData(strCompSQL, "ID", conn));
                    long invClientID = Utils.CLng(DBData.GetData(strClientSQL, "ID", conn));
                    long? businessID = Utils.CLng(DBData.GetData(strBusSQL, "BusinessID", conn));
                    long invBusID = Utils.CLng(DBData.GetData(strBusSQL2, "BusinessID", conn));

                    if (businessID == 0 || businessID == null) {
                        DialogBox.Error("You do not have a Business associated with your account.");
                        goto FinishUp;
                    }

                    if (businessID != invBusID) {
                        if (!DialogBox.Confirm("WARNING: A different business ID is detected on this account than the one saved to this Invoice. Saving this Invoice will alter that ID to be of the one set to your account.\n\nContinue?")) {
                            DialogBox.Show("Understood. The change will not be made, and this form will now close.");
                            goto FinishUp;
                        }
                    }

                    sqlCmd.AddDynamicParam("@ID", SqlDbType.BigInt, invoiceID);
                    sqlCmd.AddDynamicParam("@COMPANY_ID", SqlDbType.BigInt, invCompID);
                    sqlCmd.AddDynamicParam("@CLIENT_ID", SqlDbType.BigInt, invClientID);
                    sqlCmd.AddDynamicParam("@BUSINESS_ID", SqlDbType.BigInt, businessID);
                    sqlCmd.AddDynamicParam("@PAY_TERMS", SqlDbType.Text, payTerms);
                    sqlCmd.AddDynamicParam("@SUMMARY", SqlDbType.Text, summary);
                    sqlCmd.AddDynamicParam("@INVOICE_DT", SqlDbType.Date, invoiceDt);
                    sqlCmd.AddDynamicParam("@SUPPLY_DT", SqlDbType.Date, supplyDt);
                    sqlCmd.AddDynamicParam("@PAID_DT", SqlDbType.Date, paidDt);
                    sqlCmd.AddDynamicParam("@DUE_DT", SqlDbType.Date, dueDt);
                    sqlCmd.AddDynamicParam("@AMOUNT_DUE", SqlDbType.Money, amountDue);
                    sqlCmd.AddDynamicParam("@TAX", SqlDbType.SmallMoney, tax);
                    sqlCmd.AddDynamicParam("@DISCOUNT", SqlDbType.Money, discount);
                    sqlCmd.AddDynamicParam("@NOTES", SqlDbType.Text, notes);
                    sqlCmd.ExecuteNonQuery();
                }
                conn = null;
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
            #endregion

FinishUp:
            this.ClearEverything();
            frmMain.instance.RefreshListViews();
            if (AAS.showDialogsAfterSave) {
                DialogBox.ChangesSaved();
            }
            this.Close();
            this.Visible = false;
        }

        private void btnOpenFinanceCalc_Click(object sender, EventArgs e) => frmFinance.Show();

        private void ClearEverything() {
            this.cbCompany.SelectedIndex = -1;
            this.cbClients.SelectedIndex = -1;
            this.cbCompany.Items.Clear();
            this.cbClients.Items.Clear();
            this.dpIssueDt.Text = Now.ToShortDateString();
            this.txtInvoiceDt.Text = this.dpIssueDt.Text;
            this.txtDueDt.Text = "";
            this.txtSupplyDt.Text = "";
            this.txtPaidDt.Text = "";
            this.txtAmountDue.Text = "";
            this.txtDiscountPct.Text = "";
            this.txtTaxPct.Text = "";
            this.txtSummary.Text = "";
            this.txtNotes.Text = "";
            this.txtPayTerms.Text = "";
        }

        public static void SetInvoiceID(long IDin) => invoiceID = IDin;

        private void dpIssueDt_ValueChanged(object sender, EventArgs e) => this.txtInvoiceDt.Text = this.dpIssueDt.Text;

        private void dpDueDt_ValueChanged(object sender, EventArgs e) => this.txtDueDt.Text = this.dpDueDt.Text;

        private void dpSupplyDt_ValueChanged(object sender, EventArgs e) => this.txtSupplyDt.Text = this.dpSupplyDt.Text;

        private void dpPaidDt_ValueChanged(object sender, EventArgs e) => this.txtPaidDt.Text = this.dpPaidDt.Text;

        private void btnInvoiceAddCompany_Click(object sender, EventArgs e) => frmAddCompany.ShowDialog();

        private void btnAddClient_Click(object sender, EventArgs e) => frmAddClient.ShowDialog();

        private void btnSaveGenerate_Click(object sender, EventArgs e) {
            this.InvoiceEdit(sender, e);
            frmMain.instance.GenerateInvoice(sender, e);
        }

        private void btnEditInvoice_Click(object sender, EventArgs e) => this.InvoiceEdit(sender, e);
    }
}
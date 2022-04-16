using System;
using System.Data;
using System.Data.SqlClient;
using static System.DateTime;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmInvoiceAdd : Form {

        private readonly frmCompanyAdd frmAddCompany = new frmCompanyAdd();
        private readonly frmClientAdd frmAddClient = new frmClientAdd();
        private readonly frmItemAdd frmAddItem = new frmItemAdd();
        private readonly frmFinanceCalculator frmFinance = new frmFinanceCalculator();

        public frmInvoiceAdd() => InitializeComponent();

        private void frmInvoiceAdd_Load(object sender, EventArgs e) {
            this.ClearEverything();
            this.PopulateCompanyBox();
            this.PopulateClientBox();
        }

        private void InvoiceAdd(object sender, EventArgs e) {
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
            #endregion

            #region Extra Information
            string summary = Utils.SqlFormat(this.txtSummary.Text);
            string notes = Utils.SqlFormat(this.txtNotes.Text);
            string payTerms = Utils.SqlFormat(this.txtPayTerms.Text);
            #endregion

            #region SQL Data Entry
            try {
                SqlConnection conn = AAS.SQL_CONN;
                string strSQL = "INSERT INTO [Invoices] " +
                                "([CompanyID], [ClientID], [BusinessID], [Payment_Terms], [Summary], [Invoice_Dt], [Supply_Dt], [Paid_Dt], [Due_Dt], [Amount_Payable], [Sales_Tax], [Discount], [Notes]) " +
                                "VALUES " +
                                "(@COMPANY_ID, @CLIENT_ID, @BUSINESS_ID, @PAY_TERMS, @SUMMARY, @INVOICE_DT, @SUPPLY_DT, @PAID_DT, @DUE_DT, @AMOUNT, @TAX, @DISCOUNT, @NOTES);";
                using (SqlCommand sqlCmd = new SqlCommand(strSQL, conn)) {
                    long companyID = Utils.CLng(DBData.GetData(strCompSQL, "ID", conn));
                    long clientID = Utils.CLng(DBData.GetData(strClientSQL, "ID", conn));
                    long? businessID = Utils.CLng(DBData.GetData(strBusSQL, "BusinessID", conn));
                    if (businessID == 0 || businessID == null) {
                        DialogBox.Error("You do not have a Business associated with your account.");
                        goto FinishUp;
                    }
                    sqlCmd.AddDynamicParam("@COMPANY_ID", SqlDbType.BigInt, companyID);
                    sqlCmd.AddDynamicParam("@CLIENT_ID", SqlDbType.BigInt, clientID);
                    sqlCmd.AddDynamicParam("@BUSINESS_ID", SqlDbType.BigInt, businessID);
                    sqlCmd.AddDynamicParam("@PAY_TERMS", SqlDbType.Text, payTerms);
                    sqlCmd.AddDynamicParam("@SUMMARY", SqlDbType.Text, summary);
                    sqlCmd.AddDynamicParam("@INVOICE_DT", SqlDbType.Date, invoiceDt);
                    sqlCmd.AddDynamicParam("@SUPPLY_DT", SqlDbType.Date, supplyDt);
                    sqlCmd.AddDynamicParam("@PAID_DT", SqlDbType.Date, paidDt);
                    sqlCmd.AddDynamicParam("@DUE_DT", SqlDbType.Date, dueDt);
                    sqlCmd.AddDynamicParam("@AMOUNT", SqlDbType.Money, amountDue);
                    sqlCmd.AddDynamicParam("@TAX", SqlDbType.SmallMoney, tax);
                    sqlCmd.AddDynamicParam("@DISCOUNT", SqlDbType.Money, discount);
                    sqlCmd.AddDynamicParam("@NOTES", SqlDbType.Text, notes);
                    sqlCmd.ExecuteNonQuery();
                    if (AAS.showDialogsAfterSave) {
                        DialogBox.Show("Invoice added successfully!");
                    }
FinishUp:
                    conn = null;
                    frmMain.instance.RefreshListViews();
                    this.ClearEverything();
                    this.Close();
                    this.Visible = false;
                }
            } catch (SqlException ex) {
                DialogBox.ErrorUnexpected(ex);
            }
            #endregion
        }

        private void btnAddInvoice_Click(object sender, EventArgs e) {
            this.InvoiceAdd(sender, e);
        }

        private void ClearEverything() {
            this.cbCompany.SelectedIndex = -1;
            this.cbClients.SelectedIndex = -1;
            this.cbCompany.Items.Clear();
            this.cbClients.Items.Clear();
            this.dpIssueDt.Text = Now.ToShortDateString();
            this.dpDueDt.Text = Now.ToShortDateString();
            this.dpSupplyDt.Text = Now.ToShortDateString();
            this.dpPaidDt.Text = Now.ToShortDateString();
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

        private void PopulateCompanyBox() {
            this.cbCompany.PopulateData("SELECT [CompanyName] FROM [Company] ORDER BY [CompanyName] ASC;", "CompanyName");
        }

        private void PopulateClientBox() {
            this.cbClients.PopulateData("SELECT [Name] FROM [Clients] ORDER BY [Name] ASC;", "Name");
        }

        private void btnInvoiceAddCompany_Click(object sender, EventArgs e) {
            frmAddCompany.ShowDialog();
            this.cbCompany.Items.Clear();
            this.PopulateCompanyBox();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            frmAddClient.ShowDialog();
            this.cbClients.Items.Clear();
            this.PopulateClientBox();
        }

        private void dpIssueDt_ValueChanged(object sender, EventArgs e) => this.txtInvoiceDt.Text = dpIssueDt.Text;

        private void dpDueDt_ValueChanged(object sender, EventArgs e) => this.txtDueDt.Text = dpDueDt.Text;

        private void dpSupplyDt_ValueChanged(object sender, EventArgs e) => this.txtSupplyDt.Text = dpSupplyDt.Text;

        private void dpPaidDt_ValueChanged(object sender, EventArgs e) => this.txtPaidDt.Text = dpPaidDt.Text;

        private void btnSaveGenerate_Click(object sender, EventArgs e) {
            this.InvoiceAdd(sender, e);
            frmMain.instance.GenerateInvoice(sender, e);
        }

        private void btnOpenFinanceCalc_Click(object sender, EventArgs e) {
            this.frmFinance.Show();
        }
    }
}
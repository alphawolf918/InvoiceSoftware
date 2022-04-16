using InvoiceSoftware.Lib;
using System;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms {
    public partial class frmFinanceCalculator : Form {
        public frmFinanceCalculator() => InitializeComponent();

        private void btnCalc_Click(object sender, EventArgs e) {
            double txtTax = Utils.MoneyVal(this.txtTaxPct.Text);
            double txtDiscount = Utils.MoneyVal(this.txtDiscountPct.Text);
            double txtAmountDue = Utils.MoneyVal(this.txtAmountDue.Text, false);

            double calcTax = Finances.CalcTax(txtAmountDue, txtDiscount, txtTax);
            double calcSavings = Finances.CalcSavings(txtAmountDue, txtDiscount, txtTax);
            double calcTotal = Finances.CalcTotal(txtAmountDue, txtDiscount, txtTax);

            this.lblTotalPrice.Text = "$" + calcTotal.ToString();
            this.lblDiscount.Text = "$" + calcSavings.ToString();
            this.lblTax.Text = "$" + calcTax.ToString();
        }
    }
}
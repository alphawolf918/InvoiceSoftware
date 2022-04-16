
namespace InvoiceSoftware.Forms {
    partial class frmFinanceCalculator {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanceCalculator));
            this.lblFinanceTitle = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtTaxPct = new System.Windows.Forms.TextBox();
            this.lblTaxPct = new System.Windows.Forms.Label();
            this.txtDiscountPct = new System.Windows.Forms.TextBox();
            this.lblDiscountPct = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblInvoiceList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinanceTitle
            // 
            this.lblFinanceTitle.AutoSize = true;
            this.lblFinanceTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceTitle.Location = new System.Drawing.Point(53, 9);
            this.lblFinanceTitle.Name = "lblFinanceTitle";
            this.lblFinanceTitle.Size = new System.Drawing.Size(223, 25);
            this.lblFinanceTitle.TabIndex = 29;
            this.lblFinanceTitle.Text = "CALCULATE TOTAL";
            this.lblFinanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(140, 339);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(63, 20);
            this.lblTotalPrice.TabIndex = 53;
            this.lblTotalPrice.Text = "$0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(12, 339);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(118, 20);
            this.lblSubTotal.TabIndex = 52;
            this.lblSubTotal.Text = "Total Price:";
            // 
            // txtTaxPct
            // 
            this.txtTaxPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxPct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxPct.Location = new System.Drawing.Point(161, 179);
            this.txtTaxPct.Name = "txtTaxPct";
            this.txtTaxPct.Size = new System.Drawing.Size(134, 26);
            this.txtTaxPct.TabIndex = 50;
            this.txtTaxPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxPct.WordWrap = false;
            // 
            // lblTaxPct
            // 
            this.lblTaxPct.AutoSize = true;
            this.lblTaxPct.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPct.Location = new System.Drawing.Point(12, 179);
            this.lblTaxPct.Name = "lblTaxPct";
            this.lblTaxPct.Size = new System.Drawing.Size(78, 20);
            this.lblTaxPct.TabIndex = 51;
            this.lblTaxPct.Text = "Tax %:";
            // 
            // txtDiscountPct
            // 
            this.txtDiscountPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPct.Location = new System.Drawing.Point(161, 145);
            this.txtDiscountPct.Name = "txtDiscountPct";
            this.txtDiscountPct.Size = new System.Drawing.Size(134, 26);
            this.txtDiscountPct.TabIndex = 48;
            this.txtDiscountPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPct.WordWrap = false;
            // 
            // lblDiscountPct
            // 
            this.lblDiscountPct.AutoSize = true;
            this.lblDiscountPct.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPct.Location = new System.Drawing.Point(12, 145);
            this.lblDiscountPct.Name = "lblDiscountPct";
            this.lblDiscountPct.Size = new System.Drawing.Size(128, 20);
            this.lblDiscountPct.TabIndex = 49;
            this.lblDiscountPct.Text = "Discount %:";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountDue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(161, 111);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(134, 26);
            this.txtAmountDue.TabIndex = 46;
            this.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountDue.WordWrap = false;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(12, 111);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(134, 20);
            this.lblAmountDue.TabIndex = 47;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(140, 272);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 20);
            this.lblDiscount.TabIndex = 55;
            this.lblDiscount.Text = "$0.00";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.Location = new System.Drawing.Point(12, 272);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(90, 20);
            this.lblSavings.TabIndex = 54;
            this.lblSavings.Text = "Savings:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(140, 306);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(63, 20);
            this.lblTax.TabIndex = 57;
            this.lblTax.Text = "$0.00";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxes.Location = new System.Drawing.Point(12, 306);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(50, 20);
            this.lblTaxes.TabIndex = 56;
            this.lblTaxes.Text = "Tax:";
            // 
            // btnCalc
            // 
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Image = ((System.Drawing.Image)(resources.GetObject("btnCalc.Image")));
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.Location = new System.Drawing.Point(174, 211);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 39);
            this.btnCalc.TabIndex = 58;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblInvoiceList
            // 
            this.lblInvoiceList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvoiceList.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvoiceList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceList.Location = new System.Drawing.Point(12, 44);
            this.lblInvoiceList.Name = "lblInvoiceList";
            this.lblInvoiceList.Size = new System.Drawing.Size(283, 56);
            this.lblInvoiceList.TabIndex = 59;
            this.lblInvoiceList.Text = "Please type in discount and taxes as whole percentages (e.g. 25% should be typed " +
    "as 25, not .25).";
            this.lblInvoiceList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFinanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(304, 376);
            this.Controls.Add(this.lblInvoiceList);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtTaxPct);
            this.Controls.Add(this.lblTaxPct);
            this.Controls.Add(this.txtDiscountPct);
            this.Controls.Add(this.lblDiscountPct);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.lblFinanceTitle);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinanceCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinanceTitle;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSubTotal;
        public System.Windows.Forms.TextBox txtTaxPct;
        private System.Windows.Forms.Label lblTaxPct;
        public System.Windows.Forms.TextBox txtDiscountPct;
        private System.Windows.Forms.Label lblDiscountPct;
        public System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Button btnCalc;
        public System.Windows.Forms.Label lblInvoiceList;
    }
}
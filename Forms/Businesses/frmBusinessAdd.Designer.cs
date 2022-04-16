
namespace InvoiceSoftware.Forms.Businesses {
    partial class frmBusinessAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusinessAdd));
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblBusinessWeb = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblBusinessPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblCompanyAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Location = new System.Drawing.Point(512, 173);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(103, 31);
            this.btnAddBusiness.TabIndex = 19;
            this.btnAddBusiness.Text = "Save";
            this.btnAddBusiness.UseVisualStyleBackColor = true;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(223, 141);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(392, 26);
            this.txtWeb.TabIndex = 18;
            this.txtWeb.WordWrap = false;
            // 
            // lblBusinessWeb
            // 
            this.lblBusinessWeb.AutoSize = true;
            this.lblBusinessWeb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessWeb.Location = new System.Drawing.Point(5, 143);
            this.lblBusinessWeb.Name = "lblBusinessWeb";
            this.lblBusinessWeb.Size = new System.Drawing.Size(191, 20);
            this.lblBusinessWeb.TabIndex = 17;
            this.lblBusinessWeb.Text = "Business Web Site:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(223, 109);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(392, 26);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.WordWrap = false;
            // 
            // lblBusinessPhone
            // 
            this.lblBusinessPhone.AutoSize = true;
            this.lblBusinessPhone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessPhone.Location = new System.Drawing.Point(5, 111);
            this.lblBusinessPhone.Name = "lblBusinessPhone";
            this.lblBusinessPhone.Size = new System.Drawing.Size(165, 20);
            this.lblBusinessPhone.TabIndex = 15;
            this.lblBusinessPhone.Text = "Business Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(223, 77);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 26);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(5, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(182, 20);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Business Address:";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(223, 46);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(392, 26);
            this.txtBusinessName.TabIndex = 12;
            this.txtBusinessName.WordWrap = false;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.Location = new System.Drawing.Point(5, 47);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(160, 20);
            this.lblBusinessName.TabIndex = 11;
            this.lblBusinessName.Text = "Business Name:";
            // 
            // lblCompanyAdd
            // 
            this.lblCompanyAdd.AutoSize = true;
            this.lblCompanyAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAdd.Location = new System.Drawing.Point(218, 7);
            this.lblCompanyAdd.Name = "lblCompanyAdd";
            this.lblCompanyAdd.Size = new System.Drawing.Size(245, 25);
            this.lblCompanyAdd.TabIndex = 10;
            this.lblCompanyAdd.Text = "ADD NEW BUSINESS";
            this.lblCompanyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBusinessAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(624, 211);
            this.Controls.Add(this.btnAddBusiness);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblBusinessWeb);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblBusinessPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblCompanyAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusinessAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Business";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBusiness;
        public System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblBusinessWeb;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBusinessPhone;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblCompanyAdd;
    }
}
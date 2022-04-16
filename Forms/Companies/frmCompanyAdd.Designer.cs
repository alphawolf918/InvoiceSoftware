
namespace InvoiceSoftware {
    partial class frmCompanyAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyAdd));
            this.lblCompanyAdd = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblCompanyWeb = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompanyAdd
            // 
            this.lblCompanyAdd.AutoSize = true;
            this.lblCompanyAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAdd.Location = new System.Drawing.Point(225, 9);
            this.lblCompanyAdd.Name = "lblCompanyAdd";
            this.lblCompanyAdd.Size = new System.Drawing.Size(243, 25);
            this.lblCompanyAdd.TabIndex = 0;
            this.lblCompanyAdd.Text = "ADD NEW COMPANY";
            this.lblCompanyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(12, 49);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(164, 20);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(230, 48);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(392, 26);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.WordWrap = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(230, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 26);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(186, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Company Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(230, 111);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(392, 26);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.WordWrap = false;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPhone.Location = new System.Drawing.Point(12, 113);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(169, 20);
            this.lblCompanyPhone.TabIndex = 5;
            this.lblCompanyPhone.Text = "Company Phone:";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(230, 143);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(392, 26);
            this.txtWeb.TabIndex = 8;
            this.txtWeb.WordWrap = false;
            // 
            // lblCompanyWeb
            // 
            this.lblCompanyWeb.AutoSize = true;
            this.lblCompanyWeb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyWeb.Location = new System.Drawing.Point(12, 145);
            this.lblCompanyWeb.Name = "lblCompanyWeb";
            this.lblCompanyWeb.Size = new System.Drawing.Size(195, 20);
            this.lblCompanyWeb.TabIndex = 7;
            this.lblCompanyWeb.Text = "Company Web Site:";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(519, 175);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(103, 31);
            this.btnAddCompany.TabIndex = 9;
            this.btnAddCompany.Text = "Save";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // frmCompanyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(641, 215);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblCompanyWeb);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyAdd;
        private System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.TextBox txtCompanyName;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCompanyPhone;
        public System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblCompanyWeb;
        private System.Windows.Forms.Button btnAddCompany;
    }
}

namespace InvoiceSoftware {
    partial class frmCompanyEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyEdit));
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblCompanyWeb = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Location = new System.Drawing.Point(583, 197);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(116, 35);
            this.btnEditCompany.TabIndex = 19;
            this.btnEditCompany.Text = "Save";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(258, 161);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(440, 26);
            this.txtWeb.TabIndex = 18;
            this.txtWeb.WordWrap = false;
            // 
            // lblCompanyWeb
            // 
            this.lblCompanyWeb.AutoSize = true;
            this.lblCompanyWeb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyWeb.Location = new System.Drawing.Point(12, 163);
            this.lblCompanyWeb.Name = "lblCompanyWeb";
            this.lblCompanyWeb.Size = new System.Drawing.Size(195, 20);
            this.lblCompanyWeb.TabIndex = 17;
            this.lblCompanyWeb.Text = "Company Web Site:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(258, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(440, 26);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.WordWrap = false;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPhone.Location = new System.Drawing.Point(12, 127);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(169, 20);
            this.lblCompanyPhone.TabIndex = 15;
            this.lblCompanyPhone.Text = "Company Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(258, 89);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(440, 26);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(186, 20);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Company Address:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(258, 54);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(440, 26);
            this.txtCompanyName.TabIndex = 12;
            this.txtCompanyName.WordWrap = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(12, 55);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(164, 20);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblCompanyEdit
            // 
            this.lblCompanyEdit.AutoSize = true;
            this.lblCompanyEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyEdit.Location = new System.Drawing.Point(252, 10);
            this.lblCompanyEdit.Name = "lblCompanyEdit";
            this.lblCompanyEdit.Size = new System.Drawing.Size(188, 25);
            this.lblCompanyEdit.TabIndex = 10;
            this.lblCompanyEdit.Text = "EDIT COMPANY";
            this.lblCompanyEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCompanyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(719, 243);
            this.Controls.Add(this.btnEditCompany);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblCompanyWeb);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyEdit);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Company";
            this.Load += new System.EventHandler(this.frmCompanyEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCompany;
        public System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblCompanyWeb;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCompanyPhone;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyEdit;
    }
}
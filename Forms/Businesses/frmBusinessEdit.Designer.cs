
namespace InvoiceSoftware.Forms.Businesses {
    partial class frmBusinessEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusinessEdit));
            this.btnEditBusiness = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblBusinessWeb = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblBusinessPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblCompanyEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditBusiness
            // 
            this.btnEditBusiness.Location = new System.Drawing.Point(515, 177);
            this.btnEditBusiness.Name = "btnEditBusiness";
            this.btnEditBusiness.Size = new System.Drawing.Size(103, 31);
            this.btnEditBusiness.TabIndex = 29;
            this.btnEditBusiness.Text = "Save";
            this.btnEditBusiness.UseVisualStyleBackColor = true;
            this.btnEditBusiness.Click += new System.EventHandler(this.btnEditBusiness_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(226, 145);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(392, 26);
            this.txtWeb.TabIndex = 28;
            this.txtWeb.WordWrap = false;
            // 
            // lblBusinessWeb
            // 
            this.lblBusinessWeb.AutoSize = true;
            this.lblBusinessWeb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessWeb.Location = new System.Drawing.Point(8, 147);
            this.lblBusinessWeb.Name = "lblBusinessWeb";
            this.lblBusinessWeb.Size = new System.Drawing.Size(191, 20);
            this.lblBusinessWeb.TabIndex = 27;
            this.lblBusinessWeb.Text = "Business Web Site:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(226, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(392, 26);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.WordWrap = false;
            // 
            // lblBusinessPhone
            // 
            this.lblBusinessPhone.AutoSize = true;
            this.lblBusinessPhone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessPhone.Location = new System.Drawing.Point(8, 115);
            this.lblBusinessPhone.Name = "lblBusinessPhone";
            this.lblBusinessPhone.Size = new System.Drawing.Size(165, 20);
            this.lblBusinessPhone.TabIndex = 25;
            this.lblBusinessPhone.Text = "Business Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(226, 81);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 26);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 83);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(182, 20);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Business Address:";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(226, 50);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(392, 26);
            this.txtBusinessName.TabIndex = 22;
            this.txtBusinessName.WordWrap = false;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.Location = new System.Drawing.Point(8, 51);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(160, 20);
            this.lblBusinessName.TabIndex = 21;
            this.lblBusinessName.Text = "Business Name:";
            // 
            // lblCompanyEdit
            // 
            this.lblCompanyEdit.AutoSize = true;
            this.lblCompanyEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyEdit.Location = new System.Drawing.Point(221, 9);
            this.lblCompanyEdit.Name = "lblCompanyEdit";
            this.lblCompanyEdit.Size = new System.Drawing.Size(190, 25);
            this.lblCompanyEdit.TabIndex = 20;
            this.lblCompanyEdit.Text = "EDIT BUSINESS";
            this.lblCompanyEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBusinessEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(629, 217);
            this.Controls.Add(this.btnEditBusiness);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblBusinessWeb);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblBusinessPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblCompanyEdit);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusinessEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Business";
            this.Load += new System.EventHandler(this.frmBusinessEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditBusiness;
        public System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblBusinessWeb;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBusinessPhone;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblCompanyEdit;
    }
}
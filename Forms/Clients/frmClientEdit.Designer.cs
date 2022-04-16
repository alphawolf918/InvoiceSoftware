
namespace InvoiceSoftware {
    partial class frmClientEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientEdit));
            this.btnClientAddCompany = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCompanyAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClientAddCompany
            // 
            this.btnClientAddCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAddCompany.Location = new System.Drawing.Point(278, 172);
            this.btnClientAddCompany.Name = "btnClientAddCompany";
            this.btnClientAddCompany.Size = new System.Drawing.Size(123, 32);
            this.btnClientAddCompany.TabIndex = 31;
            this.btnClientAddCompany.Text = "Add";
            this.btnClientAddCompany.UseVisualStyleBackColor = true;
            this.btnClientAddCompany.Click += new System.EventHandler(this.btnClientAddCompany_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(3, 136);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(165, 20);
            this.lblCompany.TabIndex = 30;
            this.lblCompany.Text = "Client Company:";
            // 
            // cbCompany
            // 
            this.cbCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(278, 136);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(220, 26);
            this.cbCompany.TabIndex = 25;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(506, 187);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(130, 39);
            this.btnEditClient.TabIndex = 26;
            this.btnEditClient.Text = "Save";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(278, 96);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(358, 26);
            this.txtClientAddress.TabIndex = 24;
            this.txtClientAddress.WordWrap = false;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(2, 98);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(153, 20);
            this.lblClientAddress.TabIndex = 29;
            this.lblClientAddress.Text = "Client Address:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(278, 56);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(358, 26);
            this.txtClientName.TabIndex = 23;
            this.txtClientName.WordWrap = false;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(2, 57);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(131, 20);
            this.lblClientName.TabIndex = 28;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblCompanyAdd
            // 
            this.lblCompanyAdd.AutoSize = true;
            this.lblCompanyAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAdd.Location = new System.Drawing.Point(272, 8);
            this.lblCompanyAdd.Name = "lblCompanyAdd";
            this.lblCompanyAdd.Size = new System.Drawing.Size(158, 25);
            this.lblCompanyAdd.TabIndex = 27;
            this.lblCompanyAdd.Text = "EDIT CLIENT";
            this.lblCompanyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(646, 238);
            this.Controls.Add(this.btnClientAddCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblCompanyAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Client";
            this.Load += new System.EventHandler(this.frmClientEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientAddCompany;
        private System.Windows.Forms.Label lblCompany;
        public System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btnEditClient;
        public System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label lblClientAddress;
        public System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCompanyAdd;
    }
}
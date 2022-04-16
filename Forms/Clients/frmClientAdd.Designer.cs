
namespace InvoiceSoftware {
    partial class frmClientAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientAdd));
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCompanyAdd = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnClientAddCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(501, 201);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(116, 35);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Save";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(256, 92);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(361, 26);
            this.txtClientAddress.TabIndex = 2;
            this.txtClientAddress.WordWrap = false;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(11, 94);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(153, 20);
            this.lblClientAddress.TabIndex = 13;
            this.lblClientAddress.Text = "Client Address:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(256, 57);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(361, 26);
            this.txtClientName.TabIndex = 1;
            this.txtClientName.WordWrap = false;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(11, 58);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(131, 20);
            this.lblClientName.TabIndex = 11;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblCompanyAdd
            // 
            this.lblCompanyAdd.AutoSize = true;
            this.lblCompanyAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAdd.Location = new System.Drawing.Point(251, 14);
            this.lblCompanyAdd.Name = "lblCompanyAdd";
            this.lblCompanyAdd.Size = new System.Drawing.Size(213, 25);
            this.lblCompanyAdd.TabIndex = 10;
            this.lblCompanyAdd.Text = "ADD NEW CLIENT";
            this.lblCompanyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCompany
            // 
            this.cbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(256, 128);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(196, 26);
            this.cbCompany.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(12, 128);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(165, 20);
            this.lblCompany.TabIndex = 21;
            this.lblCompany.Text = "Client Company:";
            // 
            // btnClientAddCompany
            // 
            this.btnClientAddCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAddCompany.Location = new System.Drawing.Point(256, 160);
            this.btnClientAddCompany.Name = "btnClientAddCompany";
            this.btnClientAddCompany.Size = new System.Drawing.Size(109, 28);
            this.btnClientAddCompany.TabIndex = 22;
            this.btnClientAddCompany.Text = "Add";
            this.btnClientAddCompany.UseVisualStyleBackColor = true;
            this.btnClientAddCompany.Click += new System.EventHandler(this.btnClientAddCompany_Click);
            // 
            // frmClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(630, 248);
            this.Controls.Add(this.btnClientAddCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.btnAddClient);
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
            this.Name = "frmClientAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Client";
            this.Load += new System.EventHandler(this.frmClientAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        public System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label lblClientAddress;
        public System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCompanyAdd;
        private System.Windows.Forms.Label lblCompany;
        public System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btnClientAddCompany;
    }
}
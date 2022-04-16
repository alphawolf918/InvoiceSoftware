
namespace InvoiceSoftware.Forms {
    partial class frmUserEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserEdit));
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblLocked = new System.Windows.Forms.Label();
            this.btnUserAddRole = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserEdit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.cbBusiness = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(206, 372);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(18, 17);
            this.chkLocked.TabIndex = 31;
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(411, 367);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(130, 39);
            this.btnAddUser.TabIndex = 32;
            this.btnAddUser.Text = "Save";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblLocked
            // 
            this.lblLocked.AutoSize = true;
            this.lblLocked.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocked.Location = new System.Drawing.Point(11, 367);
            this.lblLocked.Name = "lblLocked";
            this.lblLocked.Size = new System.Drawing.Size(166, 20);
            this.lblLocked.TabIndex = 38;
            this.lblLocked.Text = "Locked Account:";
            // 
            // btnUserAddRole
            // 
            this.btnUserAddRole.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAddRole.Location = new System.Drawing.Point(206, 250);
            this.btnUserAddRole.Name = "btnUserAddRole";
            this.btnUserAddRole.Size = new System.Drawing.Size(123, 32);
            this.btnUserAddRole.TabIndex = 30;
            this.btnUserAddRole.Text = "Add";
            this.btnUserAddRole.UseVisualStyleBackColor = true;
            this.btnUserAddRole.Click += new System.EventHandler(this.btnUserAddRole_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(11, 225);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(58, 20);
            this.lblRole.TabIndex = 37;
            this.lblRole.Text = "Role:";
            // 
            // cbRoles
            // 
            this.cbRoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(206, 218);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(220, 26);
            this.cbRoles.TabIndex = 29;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(206, 141);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(335, 26);
            this.txtPassword2.TabIndex = 28;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.WordWrap = false;
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.Location = new System.Drawing.Point(6, 142);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(170, 20);
            this.lblPass2.TabIndex = 36;
            this.lblPass2.Text = "Verify Password:";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(206, 105);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(335, 26);
            this.txtPassword1.TabIndex = 27;
            this.txtPassword1.UseSystemPasswordChar = true;
            this.txtPassword1.WordWrap = false;
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.Location = new System.Drawing.Point(6, 106);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(108, 20);
            this.lblPassword1.TabIndex = 35;
            this.lblPassword1.Text = "Password:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(206, 53);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(335, 26);
            this.txtUserEmail.TabIndex = 26;
            this.txtUserEmail.WordWrap = false;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.Location = new System.Drawing.Point(6, 54);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(69, 20);
            this.lblUserEmail.TabIndex = 34;
            this.lblUserEmail.Text = "Email:";
            // 
            // lblUserEdit
            // 
            this.lblUserEdit.AutoSize = true;
            this.lblUserEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEdit.Location = new System.Drawing.Point(201, 9);
            this.lblUserEdit.Name = "lblUserEdit";
            this.lblUserEdit.Size = new System.Drawing.Size(135, 25);
            this.lblUserEdit.TabIndex = 33;
            this.lblUserEdit.Text = "EDIT USER";
            this.lblUserEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(203, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 39;
            this.label1.Text = "To leave the Password the same, leave both boxes blank.";
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBusiness.Location = new System.Drawing.Point(206, 320);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(109, 28);
            this.btnAddBusiness.TabIndex = 41;
            this.btnAddBusiness.Text = "Add";
            this.btnAddBusiness.UseVisualStyleBackColor = true;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusiness.Location = new System.Drawing.Point(11, 294);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(100, 20);
            this.lblBusiness.TabIndex = 42;
            this.lblBusiness.Text = "Business:";
            // 
            // cbBusiness
            // 
            this.cbBusiness.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBusiness.FormattingEnabled = true;
            this.cbBusiness.Location = new System.Drawing.Point(206, 288);
            this.cbBusiness.Name = "cbBusiness";
            this.cbBusiness.Size = new System.Drawing.Size(196, 26);
            this.cbBusiness.TabIndex = 40;
            // 
            // frmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(549, 415);
            this.Controls.Add(this.btnAddBusiness);
            this.Controls.Add(this.lblBusiness);
            this.Controls.Add(this.cbBusiness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLocked);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblLocked);
            this.Controls.Add(this.btnUserAddRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUserEdit);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmUserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblLocked;
        private System.Windows.Forms.Button btnUserAddRole;
        private System.Windows.Forms.Label lblRole;
        public System.Windows.Forms.ComboBox cbRoles;
        public System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblPass2;
        public System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblPassword1;
        public System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Label lblBusiness;
        public System.Windows.Forms.ComboBox cbBusiness;
    }
}
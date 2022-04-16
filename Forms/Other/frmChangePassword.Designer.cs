
namespace InvoiceSoftware.Forms {
    partial class frmChangePassword {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.txtCurrentPass1 = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPass2 = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword2 = new System.Windows.Forms.Label();
            this.txtNewPass1 = new System.Windows.Forms.TextBox();
            this.lblNewPassword1 = new System.Windows.Forms.Label();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(217, 4);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(245, 25);
            this.lblChangePassword.TabIndex = 28;
            this.lblChangePassword.Text = "CHANGE PASSWORD";
            this.lblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentPass1
            // 
            this.txtCurrentPass1.Location = new System.Drawing.Point(286, 48);
            this.txtCurrentPass1.Name = "txtCurrentPass1";
            this.txtCurrentPass1.Size = new System.Drawing.Size(358, 26);
            this.txtCurrentPass1.TabIndex = 1;
            this.txtCurrentPass1.UseSystemPasswordChar = true;
            this.txtCurrentPass1.WordWrap = false;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(10, 49);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(185, 20);
            this.lblCurrentPassword.TabIndex = 30;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // txtCurrentPass2
            // 
            this.txtCurrentPass2.Location = new System.Drawing.Point(286, 80);
            this.txtCurrentPass2.Name = "txtCurrentPass2";
            this.txtCurrentPass2.Size = new System.Drawing.Size(358, 26);
            this.txtCurrentPass2.TabIndex = 2;
            this.txtCurrentPass2.UseSystemPasswordChar = true;
            this.txtCurrentPass2.WordWrap = false;
            // 
            // lblCurrentPassword2
            // 
            this.lblCurrentPassword2.AutoSize = true;
            this.lblCurrentPassword2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword2.Location = new System.Drawing.Point(10, 81);
            this.lblCurrentPassword2.Name = "lblCurrentPassword2";
            this.lblCurrentPassword2.Size = new System.Drawing.Size(257, 20);
            this.lblCurrentPassword2.TabIndex = 32;
            this.lblCurrentPassword2.Text = "Retype Current Password:";
            // 
            // txtNewPass1
            // 
            this.txtNewPass1.Location = new System.Drawing.Point(286, 143);
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.Size = new System.Drawing.Size(358, 26);
            this.txtNewPass1.TabIndex = 3;
            this.txtNewPass1.UseSystemPasswordChar = true;
            this.txtNewPass1.WordWrap = false;
            // 
            // lblNewPassword1
            // 
            this.lblNewPassword1.AutoSize = true;
            this.lblNewPassword1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword1.Location = new System.Drawing.Point(14, 144);
            this.lblNewPassword1.Name = "lblNewPassword1";
            this.lblNewPassword1.Size = new System.Drawing.Size(156, 20);
            this.lblNewPassword1.TabIndex = 34;
            this.lblNewPassword1.Text = "New Password:";
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(286, 175);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(358, 26);
            this.txtNewPass2.TabIndex = 4;
            this.txtNewPass2.UseSystemPasswordChar = true;
            this.txtNewPass2.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Retype New Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangePassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(519, 221);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(125, 44);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Save";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 271);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtNewPass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPass1);
            this.Controls.Add(this.lblNewPassword1);
            this.Controls.Add(this.txtCurrentPass2);
            this.Controls.Add(this.lblCurrentPassword2);
            this.Controls.Add(this.txtCurrentPass1);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblChangePassword);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChangePassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangePassword;
        public System.Windows.Forms.TextBox txtCurrentPass1;
        private System.Windows.Forms.Label lblCurrentPassword;
        public System.Windows.Forms.TextBox txtCurrentPass2;
        private System.Windows.Forms.Label lblCurrentPassword2;
        public System.Windows.Forms.TextBox txtNewPass1;
        private System.Windows.Forms.Label lblNewPassword1;
        public System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
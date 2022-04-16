
namespace InvoiceSoftware.Forms.Settings {
    partial class frmSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblMaxLoginAttempts = new System.Windows.Forms.Label();
            this.txtMaxLoginAttempts = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblShowDialog = new System.Windows.Forms.Label();
            this.chkShowDialog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(117, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(126, 25);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "SETTINGS";
            // 
            // lblMaxLoginAttempts
            // 
            this.lblMaxLoginAttempts.AutoSize = true;
            this.lblMaxLoginAttempts.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMaxLoginAttempts.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLoginAttempts.Location = new System.Drawing.Point(12, 69);
            this.lblMaxLoginAttempts.Name = "lblMaxLoginAttempts";
            this.lblMaxLoginAttempts.Size = new System.Drawing.Size(207, 20);
            this.lblMaxLoginAttempts.TabIndex = 2;
            this.lblMaxLoginAttempts.Text = "Max Login Attempts:";
            this.lblMaxLoginAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxLoginAttempts
            // 
            this.txtMaxLoginAttempts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxLoginAttempts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxLoginAttempts.Location = new System.Drawing.Point(277, 69);
            this.txtMaxLoginAttempts.MaxLength = 1;
            this.txtMaxLoginAttempts.Name = "txtMaxLoginAttempts";
            this.txtMaxLoginAttempts.Size = new System.Drawing.Size(50, 26);
            this.txtMaxLoginAttempts.TabIndex = 35;
            this.txtMaxLoginAttempts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxLoginAttempts.WordWrap = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveSettings.Location = new System.Drawing.Point(114, 287);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(129, 39);
            this.btnSaveSettings.TabIndex = 36;
            this.btnSaveSettings.Text = "Save Changes";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblShowDialog
            // 
            this.lblShowDialog.AutoSize = true;
            this.lblShowDialog.BackColor = System.Drawing.Color.Gainsboro;
            this.lblShowDialog.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDialog.Location = new System.Drawing.Point(13, 112);
            this.lblShowDialog.Name = "lblShowDialog";
            this.lblShowDialog.Size = new System.Drawing.Size(240, 20);
            this.lblShowDialog.TabIndex = 37;
            this.lblShowDialog.Text = "Show Dialog After Save:";
            this.lblShowDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkShowDialog
            // 
            this.chkShowDialog.AutoSize = true;
            this.chkShowDialog.Location = new System.Drawing.Point(291, 115);
            this.chkShowDialog.Name = "chkShowDialog";
            this.chkShowDialog.Size = new System.Drawing.Size(18, 17);
            this.chkShowDialog.TabIndex = 38;
            this.chkShowDialog.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSaveSettings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(339, 338);
            this.Controls.Add(this.chkShowDialog);
            this.Controls.Add(this.lblShowDialog);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtMaxLoginAttempts);
            this.Controls.Add(this.lblMaxLoginAttempts);
            this.Controls.Add(this.lblSettings);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM Voice - Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        public System.Windows.Forms.Label lblMaxLoginAttempts;
        public System.Windows.Forms.TextBox txtMaxLoginAttempts;
        public System.Windows.Forms.Button btnSaveSettings;
        public System.Windows.Forms.Label lblShowDialog;
        private System.Windows.Forms.CheckBox chkShowDialog;
    }
}
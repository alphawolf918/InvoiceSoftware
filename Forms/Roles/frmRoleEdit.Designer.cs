
namespace InvoiceSoftware.Forms {
    partial class frmRoleEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleEdit));
            this.btnEditRole = new System.Windows.Forms.Button();
            this.txtRoleText = new System.Windows.Forms.TextBox();
            this.lblRoleText = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblRoleEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditRole
            // 
            this.btnEditRole.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRole.Location = new System.Drawing.Point(398, 228);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(116, 35);
            this.btnEditRole.TabIndex = 24;
            this.btnEditRole.Text = "Save";
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // txtRoleText
            // 
            this.txtRoleText.Location = new System.Drawing.Point(190, 78);
            this.txtRoleText.Multiline = true;
            this.txtRoleText.Name = "txtRoleText";
            this.txtRoleText.Size = new System.Drawing.Size(324, 144);
            this.txtRoleText.TabIndex = 22;
            // 
            // lblRoleText
            // 
            this.lblRoleText.AutoSize = true;
            this.lblRoleText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleText.Location = new System.Drawing.Point(1, 79);
            this.lblRoleText.Name = "lblRoleText";
            this.lblRoleText.Size = new System.Drawing.Size(173, 20);
            this.lblRoleText.TabIndex = 23;
            this.lblRoleText.Text = "Role Description:";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(190, 46);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(324, 26);
            this.txtRoleName.TabIndex = 20;
            this.txtRoleName.WordWrap = false;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(1, 47);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(118, 20);
            this.lblRoleName.TabIndex = 21;
            this.lblRoleName.Text = "Role Name:";
            // 
            // lblRoleEdit
            // 
            this.lblRoleEdit.AutoSize = true;
            this.lblRoleEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleEdit.Location = new System.Drawing.Point(185, 6);
            this.lblRoleEdit.Name = "lblRoleEdit";
            this.lblRoleEdit.Size = new System.Drawing.Size(135, 25);
            this.lblRoleEdit.TabIndex = 19;
            this.lblRoleEdit.Text = "EDIT ROLE";
            this.lblRoleEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRoleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(525, 269);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.txtRoleText);
            this.Controls.Add(this.lblRoleText);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblRoleEdit);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoleEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Role";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoleEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmRoleEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditRole;
        public System.Windows.Forms.TextBox txtRoleText;
        private System.Windows.Forms.Label lblRoleText;
        public System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblRoleEdit;
    }
}
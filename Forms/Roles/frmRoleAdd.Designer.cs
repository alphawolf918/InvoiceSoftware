
namespace InvoiceSoftware.Forms {
    partial class frmRoleAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleAdd));
            this.lblRoleAdd = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleText = new System.Windows.Forms.TextBox();
            this.lblRoleText = new System.Windows.Forms.Label();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoleAdd
            // 
            this.lblRoleAdd.AutoSize = true;
            this.lblRoleAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleAdd.Location = new System.Drawing.Point(191, 9);
            this.lblRoleAdd.Name = "lblRoleAdd";
            this.lblRoleAdd.Size = new System.Drawing.Size(190, 25);
            this.lblRoleAdd.TabIndex = 12;
            this.lblRoleAdd.Text = "ADD NEW ROLE";
            this.lblRoleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(196, 49);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(324, 26);
            this.txtRoleName.TabIndex = 14;
            this.txtRoleName.WordWrap = false;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(7, 50);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(118, 20);
            this.lblRoleName.TabIndex = 15;
            this.lblRoleName.Text = "Role Name:";
            // 
            // txtRoleText
            // 
            this.txtRoleText.Location = new System.Drawing.Point(196, 81);
            this.txtRoleText.Multiline = true;
            this.txtRoleText.Name = "txtRoleText";
            this.txtRoleText.Size = new System.Drawing.Size(324, 144);
            this.txtRoleText.TabIndex = 16;
            // 
            // lblRoleText
            // 
            this.lblRoleText.AutoSize = true;
            this.lblRoleText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleText.Location = new System.Drawing.Point(7, 82);
            this.lblRoleText.Name = "lblRoleText";
            this.lblRoleText.Size = new System.Drawing.Size(173, 20);
            this.lblRoleText.TabIndex = 17;
            this.lblRoleText.Text = "Role Description:";
            // 
            // btnAddRole
            // 
            this.btnAddRole.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.Location = new System.Drawing.Point(404, 231);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(116, 35);
            this.btnAddRole.TabIndex = 18;
            this.btnAddRole.Text = "Save";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // frmRoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(527, 271);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.txtRoleText);
            this.Controls.Add(this.lblRoleText);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblRoleAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Role";
            this.Load += new System.EventHandler(this.frmRoleAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoleAdd;
        public System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        public System.Windows.Forms.TextBox txtRoleText;
        private System.Windows.Forms.Label lblRoleText;
        private System.Windows.Forms.Button btnAddRole;
    }
}
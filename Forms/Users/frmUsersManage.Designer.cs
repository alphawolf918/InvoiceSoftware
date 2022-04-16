
namespace InvoiceSoftware.Forms {
    partial class frmUsersManage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManage));
            this.lblUsers = new System.Windows.Forms.Label();
            this.tabUserRoles = new System.Windows.Forms.TabControl();
            this.pgUsers = new System.Windows.Forms.TabPage();
            this.btnExportToExcelUsers = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.lsUsers = new System.Windows.Forms.ListView();
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForbidden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBusiness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pgRoles = new System.Windows.Forms.TabPage();
            this.btnRoleEdit = new System.Windows.Forms.Button();
            this.btnRoleDelete = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.btnExportToExcelRoles = new System.Windows.Forms.Button();
            this.btnRefreshRoles = new System.Windows.Forms.Button();
            this.lsRoles = new System.Windows.Forms.ListView();
            this.colRoleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleTxt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabUserRoles.SuspendLayout();
            this.pgUsers.SuspendLayout();
            this.pgRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsers.AutoSize = true;
            this.lblUsers.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(323, 9);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(180, 20);
            this.lblUsers.TabIndex = 16;
            this.lblUsers.Text = "User Management";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabUserRoles
            // 
            this.tabUserRoles.Controls.Add(this.pgUsers);
            this.tabUserRoles.Controls.Add(this.pgRoles);
            this.tabUserRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUserRoles.Location = new System.Drawing.Point(0, 0);
            this.tabUserRoles.Name = "tabUserRoles";
            this.tabUserRoles.SelectedIndex = 0;
            this.tabUserRoles.Size = new System.Drawing.Size(922, 541);
            this.tabUserRoles.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabUserRoles.TabIndex = 17;
            // 
            // pgUsers
            // 
            this.pgUsers.BackColor = System.Drawing.Color.Gainsboro;
            this.pgUsers.Controls.Add(this.btnExportToExcelUsers);
            this.pgUsers.Controls.Add(this.btnUserEdit);
            this.pgUsers.Controls.Add(this.btnUserDelete);
            this.pgUsers.Controls.Add(this.btnUserAdd);
            this.pgUsers.Controls.Add(this.btnRefreshUsers);
            this.pgUsers.Controls.Add(this.lsUsers);
            this.pgUsers.Location = new System.Drawing.Point(4, 27);
            this.pgUsers.Name = "pgUsers";
            this.pgUsers.Padding = new System.Windows.Forms.Padding(3);
            this.pgUsers.Size = new System.Drawing.Size(914, 510);
            this.pgUsers.TabIndex = 0;
            this.pgUsers.Text = "Users ";
            // 
            // btnExportToExcelUsers
            // 
            this.btnExportToExcelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelUsers.Location = new System.Drawing.Point(741, 6);
            this.btnExportToExcelUsers.Name = "btnExportToExcelUsers";
            this.btnExportToExcelUsers.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelUsers.TabIndex = 21;
            this.btnExportToExcelUsers.Text = "Export to Excel";
            this.btnExportToExcelUsers.UseVisualStyleBackColor = true;
            this.btnExportToExcelUsers.Click += new System.EventHandler(this.btnExportToExcelUsers_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserEdit.Enabled = false;
            this.btnUserEdit.Location = new System.Drawing.Point(599, 463);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(135, 39);
            this.btnUserEdit.TabIndex = 20;
            this.btnUserEdit.Text = "Edit User";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserDelete.Enabled = false;
            this.btnUserDelete.Location = new System.Drawing.Point(740, 463);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(163, 39);
            this.btnUserDelete.TabIndex = 19;
            this.btnUserDelete.Text = "Delete User";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUserAdd.Location = new System.Drawing.Point(427, 463);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(166, 39);
            this.btnUserAdd.TabIndex = 18;
            this.btnUserAdd.Text = "Add New User";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshUsers.Location = new System.Drawing.Point(8, 6);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshUsers.TabIndex = 17;
            this.btnRefreshUsers.Text = "Refresh";
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // lsUsers
            // 
            this.lsUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserID,
            this.colEmail,
            this.colRole,
            this.colLocked,
            this.colForbidden,
            this.colBusiness});
            this.lsUsers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsUsers.ForeColor = System.Drawing.Color.Black;
            this.lsUsers.FullRowSelect = true;
            this.lsUsers.GridLines = true;
            this.lsUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsUsers.HideSelection = false;
            this.lsUsers.Location = new System.Drawing.Point(8, 44);
            this.lsUsers.MultiSelect = false;
            this.lsUsers.Name = "lsUsers";
            this.lsUsers.ShowItemToolTips = true;
            this.lsUsers.Size = new System.Drawing.Size(895, 413);
            this.lsUsers.TabIndex = 16;
            this.lsUsers.UseCompatibleStateImageBehavior = false;
            this.lsUsers.View = System.Windows.Forms.View.Details;
            this.lsUsers.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsUsers_ColumnWidthChanging);
            this.lsUsers.SelectedIndexChanged += new System.EventHandler(this.lsUsers_SelectedIndexChanged);
            this.lsUsers.DoubleClick += new System.EventHandler(this.lsUsers_DoubleClick);
            // 
            // colUserID
            // 
            this.colUserID.Text = "UserID";
            this.colUserID.Width = 0;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEmail.Width = 300;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRole.Width = 120;
            // 
            // colLocked
            // 
            this.colLocked.Text = "Locked";
            this.colLocked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLocked.Width = 80;
            // 
            // colForbidden
            // 
            this.colForbidden.Text = "Forbidden";
            this.colForbidden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colForbidden.Width = 100;
            // 
            // colBusiness
            // 
            this.colBusiness.Text = "Business";
            this.colBusiness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBusiness.Width = 270;
            // 
            // pgRoles
            // 
            this.pgRoles.BackColor = System.Drawing.Color.Gainsboro;
            this.pgRoles.Controls.Add(this.btnRoleEdit);
            this.pgRoles.Controls.Add(this.btnRoleDelete);
            this.pgRoles.Controls.Add(this.btnRoleAdd);
            this.pgRoles.Controls.Add(this.btnExportToExcelRoles);
            this.pgRoles.Controls.Add(this.btnRefreshRoles);
            this.pgRoles.Controls.Add(this.lsRoles);
            this.pgRoles.Location = new System.Drawing.Point(4, 27);
            this.pgRoles.Name = "pgRoles";
            this.pgRoles.Padding = new System.Windows.Forms.Padding(3);
            this.pgRoles.Size = new System.Drawing.Size(914, 510);
            this.pgRoles.TabIndex = 1;
            this.pgRoles.Text = "Roles ";
            // 
            // btnRoleEdit
            // 
            this.btnRoleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoleEdit.Enabled = false;
            this.btnRoleEdit.Location = new System.Drawing.Point(599, 455);
            this.btnRoleEdit.Name = "btnRoleEdit";
            this.btnRoleEdit.Size = new System.Drawing.Size(135, 39);
            this.btnRoleEdit.TabIndex = 25;
            this.btnRoleEdit.Text = "Edit Role";
            this.btnRoleEdit.UseVisualStyleBackColor = true;
            this.btnRoleEdit.Click += new System.EventHandler(this.btnRoleEdit_Click);
            // 
            // btnRoleDelete
            // 
            this.btnRoleDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoleDelete.Enabled = false;
            this.btnRoleDelete.Location = new System.Drawing.Point(740, 455);
            this.btnRoleDelete.Name = "btnRoleDelete";
            this.btnRoleDelete.Size = new System.Drawing.Size(163, 39);
            this.btnRoleDelete.TabIndex = 24;
            this.btnRoleDelete.Text = "Delete Role";
            this.btnRoleDelete.UseVisualStyleBackColor = true;
            this.btnRoleDelete.Click += new System.EventHandler(this.btnRoleDelete_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoleAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRoleAdd.Location = new System.Drawing.Point(427, 455);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(166, 39);
            this.btnRoleAdd.TabIndex = 23;
            this.btnRoleAdd.Text = "Add New Role";
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // btnExportToExcelRoles
            // 
            this.btnExportToExcelRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcelRoles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportToExcelRoles.Location = new System.Drawing.Point(741, 6);
            this.btnExportToExcelRoles.Name = "btnExportToExcelRoles";
            this.btnExportToExcelRoles.Size = new System.Drawing.Size(162, 32);
            this.btnExportToExcelRoles.TabIndex = 22;
            this.btnExportToExcelRoles.Text = "Export to Excel";
            this.btnExportToExcelRoles.UseVisualStyleBackColor = true;
            this.btnExportToExcelRoles.Click += new System.EventHandler(this.btnExportToExcelRoles_Click);
            // 
            // btnRefreshRoles
            // 
            this.btnRefreshRoles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshRoles.Location = new System.Drawing.Point(12, 6);
            this.btnRefreshRoles.Name = "btnRefreshRoles";
            this.btnRefreshRoles.Size = new System.Drawing.Size(121, 32);
            this.btnRefreshRoles.TabIndex = 18;
            this.btnRefreshRoles.Text = "Refresh";
            this.btnRefreshRoles.UseVisualStyleBackColor = true;
            this.btnRefreshRoles.Click += new System.EventHandler(this.btnRefreshRoles_Click);
            // 
            // lsRoles
            // 
            this.lsRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoleID,
            this.colRoleName,
            this.colRoleTxt});
            this.lsRoles.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsRoles.ForeColor = System.Drawing.Color.Black;
            this.lsRoles.FullRowSelect = true;
            this.lsRoles.GridLines = true;
            this.lsRoles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsRoles.HideSelection = false;
            this.lsRoles.Location = new System.Drawing.Point(12, 44);
            this.lsRoles.MultiSelect = false;
            this.lsRoles.Name = "lsRoles";
            this.lsRoles.ShowItemToolTips = true;
            this.lsRoles.Size = new System.Drawing.Size(891, 405);
            this.lsRoles.TabIndex = 17;
            this.lsRoles.UseCompatibleStateImageBehavior = false;
            this.lsRoles.View = System.Windows.Forms.View.Details;
            this.lsRoles.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsRoles_ColumnWidthChanging);
            this.lsRoles.SelectedIndexChanged += new System.EventHandler(this.lsRoles_SelectedIndexChanged);
            this.lsRoles.DoubleClick += new System.EventHandler(this.lsRoles_DoubleClick);
            // 
            // colRoleID
            // 
            this.colRoleID.Text = "RoleID";
            this.colRoleID.Width = 0;
            // 
            // colRoleName
            // 
            this.colRoleName.Text = "Name";
            this.colRoleName.Width = 300;
            // 
            // colRoleTxt
            // 
            this.colRoleTxt.Text = "Description";
            this.colRoleTxt.Width = 360;
            // 
            // frmUsersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(922, 541);
            this.Controls.Add(this.tabUserRoles);
            this.Controls.Add(this.lblUsers);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 500);
            this.Name = "frmUsersManage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUsersManage_Load);
            this.tabUserRoles.ResumeLayout(false);
            this.pgUsers.ResumeLayout(false);
            this.pgRoles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblUsers;
        public System.Windows.Forms.ListView lsUsers;
        public System.Windows.Forms.ColumnHeader colUserID;
        public System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colLocked;
        private System.Windows.Forms.ColumnHeader colForbidden;
        public System.Windows.Forms.TabControl tabUserRoles;
        public System.Windows.Forms.TabPage pgUsers;
        public System.Windows.Forms.TabPage pgRoles;
        private System.Windows.Forms.Button btnRefreshUsers;
        public System.Windows.Forms.Button btnUserEdit;
        public System.Windows.Forms.Button btnUserDelete;
        public System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnExportToExcelUsers;
        public System.Windows.Forms.Button btnRoleEdit;
        public System.Windows.Forms.Button btnRoleDelete;
        public System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.Button btnExportToExcelRoles;
        private System.Windows.Forms.Button btnRefreshRoles;
        public System.Windows.Forms.ListView lsRoles;
        public System.Windows.Forms.ColumnHeader colRoleID;
        public System.Windows.Forms.ColumnHeader colRoleName;
        private System.Windows.Forms.ColumnHeader colRoleTxt;
        public System.Windows.Forms.ColumnHeader colBusiness;
    }
}

namespace InvoiceSoftware {
    partial class frmItemGroupEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemGroupEdit));
            this.btnEditItemGroup = new System.Windows.Forms.Button();
            this.lblItemGroupColor = new System.Windows.Forms.Label();
            this.txtItemGroupColor = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.txtItemGroupText = new System.Windows.Forms.TextBox();
            this.lblItemGroupText = new System.Windows.Forms.Label();
            this.txtItemGroupName = new System.Windows.Forms.TextBox();
            this.lblItemGroupName = new System.Windows.Forms.Label();
            this.lblItemGroupEdit = new System.Windows.Forms.Label();
            this.itemGroupColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnEditItemGroup
            // 
            this.btnEditItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditItemGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItemGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItemGroup.Image")));
            this.btnEditItemGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditItemGroup.Location = new System.Drawing.Point(638, 286);
            this.btnEditItemGroup.Name = "btnEditItemGroup";
            this.btnEditItemGroup.Size = new System.Drawing.Size(141, 50);
            this.btnEditItemGroup.TabIndex = 67;
            this.btnEditItemGroup.Text = "Save";
            this.btnEditItemGroup.UseVisualStyleBackColor = true;
            this.btnEditItemGroup.Click += new System.EventHandler(this.btnEditItemGroup_Click);
            // 
            // lblItemGroupColor
            // 
            this.lblItemGroupColor.AutoSize = true;
            this.lblItemGroupColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupColor.Location = new System.Drawing.Point(14, 212);
            this.lblItemGroupColor.Name = "lblItemGroupColor";
            this.lblItemGroupColor.Size = new System.Drawing.Size(182, 20);
            this.lblItemGroupColor.TabIndex = 66;
            this.lblItemGroupColor.Text = "Item Group Color:";
            // 
            // txtItemGroupColor
            // 
            this.txtItemGroupColor.BackColor = System.Drawing.Color.White;
            this.txtItemGroupColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemGroupColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemGroupColor.Location = new System.Drawing.Point(308, 210);
            this.txtItemGroupColor.Name = "txtItemGroupColor";
            this.txtItemGroupColor.Size = new System.Drawing.Size(155, 50);
            this.txtItemGroupColor.TabIndex = 65;
            this.txtItemGroupColor.Text = "                ";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseColor.Location = new System.Drawing.Point(308, 264);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(155, 40);
            this.btnChooseColor.TabIndex = 64;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // txtItemGroupText
            // 
            this.txtItemGroupText.Location = new System.Drawing.Point(308, 100);
            this.txtItemGroupText.Multiline = true;
            this.txtItemGroupText.Name = "txtItemGroupText";
            this.txtItemGroupText.Size = new System.Drawing.Size(470, 103);
            this.txtItemGroupText.TabIndex = 62;
            // 
            // lblItemGroupText
            // 
            this.lblItemGroupText.AutoSize = true;
            this.lblItemGroupText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupText.Location = new System.Drawing.Point(14, 107);
            this.lblItemGroupText.Name = "lblItemGroupText";
            this.lblItemGroupText.Size = new System.Drawing.Size(241, 20);
            this.lblItemGroupText.TabIndex = 63;
            this.lblItemGroupText.Text = "Item Group Description:";
            // 
            // txtItemGroupName
            // 
            this.txtItemGroupName.Location = new System.Drawing.Point(308, 61);
            this.txtItemGroupName.Name = "txtItemGroupName";
            this.txtItemGroupName.Size = new System.Drawing.Size(470, 26);
            this.txtItemGroupName.TabIndex = 60;
            this.txtItemGroupName.WordWrap = false;
            // 
            // lblItemGroupName
            // 
            this.lblItemGroupName.AutoSize = true;
            this.lblItemGroupName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupName.Location = new System.Drawing.Point(11, 68);
            this.lblItemGroupName.Name = "lblItemGroupName";
            this.lblItemGroupName.Size = new System.Drawing.Size(186, 20);
            this.lblItemGroupName.TabIndex = 61;
            this.lblItemGroupName.Text = "Item Group Name:";
            // 
            // lblItemGroupEdit
            // 
            this.lblItemGroupEdit.AutoSize = true;
            this.lblItemGroupEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupEdit.Location = new System.Drawing.Point(303, 9);
            this.lblItemGroupEdit.Name = "lblItemGroupEdit";
            this.lblItemGroupEdit.Size = new System.Drawing.Size(220, 25);
            this.lblItemGroupEdit.TabIndex = 59;
            this.lblItemGroupEdit.Text = "EDIT ITEM GROUP";
            this.lblItemGroupEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemGroupColorDialog
            // 
            this.itemGroupColorDialog.AnyColor = true;
            this.itemGroupColorDialog.Color = System.Drawing.Color.White;
            this.itemGroupColorDialog.FullOpen = true;
            // 
            // frmItemGroupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 348);
            this.Controls.Add(this.btnEditItemGroup);
            this.Controls.Add(this.lblItemGroupColor);
            this.Controls.Add(this.txtItemGroupColor);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.txtItemGroupText);
            this.Controls.Add(this.lblItemGroupText);
            this.Controls.Add(this.txtItemGroupName);
            this.Controls.Add(this.lblItemGroupName);
            this.Controls.Add(this.lblItemGroupEdit);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemGroupEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item Group";
            this.Load += new System.EventHandler(this.frmItemGroupEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditItemGroup;
        private System.Windows.Forms.Label lblItemGroupColor;
        public System.Windows.Forms.Label txtItemGroupColor;
        private System.Windows.Forms.Button btnChooseColor;
        public System.Windows.Forms.TextBox txtItemGroupText;
        private System.Windows.Forms.Label lblItemGroupText;
        public System.Windows.Forms.TextBox txtItemGroupName;
        private System.Windows.Forms.Label lblItemGroupName;
        private System.Windows.Forms.Label lblItemGroupEdit;
        public System.Windows.Forms.ColorDialog itemGroupColorDialog;
    }
}
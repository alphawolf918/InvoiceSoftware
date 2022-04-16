
namespace InvoiceSoftware.Forms {
    partial class frmItemGroupAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemGroupAdd));
            this.lblItemGroupAdd = new System.Windows.Forms.Label();
            this.txtItemGroupName = new System.Windows.Forms.TextBox();
            this.lblItemGroupName = new System.Windows.Forms.Label();
            this.txtItemGroupText = new System.Windows.Forms.TextBox();
            this.lblItemGroupText = new System.Windows.Forms.Label();
            this.txtItemGroupColor = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.lblItemGroupColor = new System.Windows.Forms.Label();
            this.btnAddItemGroup = new System.Windows.Forms.Button();
            this.itemGroupColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblItemGroupAdd
            // 
            this.lblItemGroupAdd.AutoSize = true;
            this.lblItemGroupAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupAdd.Location = new System.Drawing.Point(202, 9);
            this.lblItemGroupAdd.Name = "lblItemGroupAdd";
            this.lblItemGroupAdd.Size = new System.Drawing.Size(275, 25);
            this.lblItemGroupAdd.TabIndex = 11;
            this.lblItemGroupAdd.Text = "ADD NEW ITEM GROUP";
            this.lblItemGroupAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemGroupName
            // 
            this.txtItemGroupName.Location = new System.Drawing.Point(270, 49);
            this.txtItemGroupName.Name = "txtItemGroupName";
            this.txtItemGroupName.Size = new System.Drawing.Size(418, 26);
            this.txtItemGroupName.TabIndex = 12;
            this.txtItemGroupName.WordWrap = false;
            // 
            // lblItemGroupName
            // 
            this.lblItemGroupName.AutoSize = true;
            this.lblItemGroupName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupName.Location = new System.Drawing.Point(6, 55);
            this.lblItemGroupName.Name = "lblItemGroupName";
            this.lblItemGroupName.Size = new System.Drawing.Size(186, 20);
            this.lblItemGroupName.TabIndex = 13;
            this.lblItemGroupName.Text = "Item Group Name:";
            // 
            // txtItemGroupText
            // 
            this.txtItemGroupText.Location = new System.Drawing.Point(270, 84);
            this.txtItemGroupText.Multiline = true;
            this.txtItemGroupText.Name = "txtItemGroupText";
            this.txtItemGroupText.Size = new System.Drawing.Size(418, 92);
            this.txtItemGroupText.TabIndex = 14;
            // 
            // lblItemGroupText
            // 
            this.lblItemGroupText.AutoSize = true;
            this.lblItemGroupText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupText.Location = new System.Drawing.Point(8, 90);
            this.lblItemGroupText.Name = "lblItemGroupText";
            this.lblItemGroupText.Size = new System.Drawing.Size(241, 20);
            this.lblItemGroupText.TabIndex = 15;
            this.lblItemGroupText.Text = "Item Group Description:";
            // 
            // txtItemGroupColor
            // 
            this.txtItemGroupColor.BackColor = System.Drawing.Color.White;
            this.txtItemGroupColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemGroupColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemGroupColor.Location = new System.Drawing.Point(270, 182);
            this.txtItemGroupColor.Name = "txtItemGroupColor";
            this.txtItemGroupColor.Size = new System.Drawing.Size(138, 45);
            this.txtItemGroupColor.TabIndex = 56;
            this.txtItemGroupColor.Text = "                ";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseColor.Location = new System.Drawing.Point(270, 230);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(138, 36);
            this.btnChooseColor.TabIndex = 55;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // lblItemGroupColor
            // 
            this.lblItemGroupColor.AutoSize = true;
            this.lblItemGroupColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroupColor.Location = new System.Drawing.Point(12, 182);
            this.lblItemGroupColor.Name = "lblItemGroupColor";
            this.lblItemGroupColor.Size = new System.Drawing.Size(182, 20);
            this.lblItemGroupColor.TabIndex = 57;
            this.lblItemGroupColor.Text = "Item Group Color:";
            // 
            // btnAddItemGroup
            // 
            this.btnAddItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddItemGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItemGroup.Image")));
            this.btnAddItemGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItemGroup.Location = new System.Drawing.Point(563, 249);
            this.btnAddItemGroup.Name = "btnAddItemGroup";
            this.btnAddItemGroup.Size = new System.Drawing.Size(125, 44);
            this.btnAddItemGroup.TabIndex = 58;
            this.btnAddItemGroup.Text = "Save";
            this.btnAddItemGroup.UseVisualStyleBackColor = true;
            this.btnAddItemGroup.Click += new System.EventHandler(this.btnAddItemGroup_Click);
            // 
            // itemGroupColorDialog
            // 
            this.itemGroupColorDialog.AnyColor = true;
            this.itemGroupColorDialog.Color = System.Drawing.Color.White;
            this.itemGroupColorDialog.FullOpen = true;
            // 
            // frmItemGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 305);
            this.Controls.Add(this.btnAddItemGroup);
            this.Controls.Add(this.lblItemGroupColor);
            this.Controls.Add(this.txtItemGroupColor);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.txtItemGroupText);
            this.Controls.Add(this.lblItemGroupText);
            this.Controls.Add(this.txtItemGroupName);
            this.Controls.Add(this.lblItemGroupName);
            this.Controls.Add(this.lblItemGroupAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemGroupAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item Group";
            this.Load += new System.EventHandler(this.frmItemGroupAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemGroupAdd;
        public System.Windows.Forms.TextBox txtItemGroupName;
        private System.Windows.Forms.Label lblItemGroupName;
        public System.Windows.Forms.TextBox txtItemGroupText;
        private System.Windows.Forms.Label lblItemGroupText;
        public System.Windows.Forms.Label txtItemGroupColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label lblItemGroupColor;
        private System.Windows.Forms.Button btnAddItemGroup;
        public System.Windows.Forms.ColorDialog itemGroupColorDialog;
    }
}
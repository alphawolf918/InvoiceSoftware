
namespace InvoiceSoftware {
    partial class frmItemAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemAdd));
            this.btnItemAddCompany = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemAdd = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.itemColorDialog = new System.Windows.Forms.ColorDialog();
            this.lblItemColor = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.txtItemColor = new System.Windows.Forms.Label();
            this.btnAddItemGroup = new System.Windows.Forms.Button();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.cbItemGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnItemAddCompany
            // 
            this.btnItemAddCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemAddCompany.Location = new System.Drawing.Point(280, 303);
            this.btnItemAddCompany.Name = "btnItemAddCompany";
            this.btnItemAddCompany.Size = new System.Drawing.Size(156, 32);
            this.btnItemAddCompany.TabIndex = 6;
            this.btnItemAddCompany.Text = "Add Company";
            this.btnItemAddCompany.UseVisualStyleBackColor = true;
            this.btnItemAddCompany.Click += new System.EventHandler(this.btnItemAddCompany_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(4, 272);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(156, 20);
            this.lblCompany.TabIndex = 30;
            this.lblCompany.Text = "Item Company:";
            // 
            // cbCompany
            // 
            this.cbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(280, 271);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(220, 26);
            this.cbCompany.TabIndex = 5;
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(579, 479);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(111, 39);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Save";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AllowDrop = true;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(280, 94);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(406, 101);
            this.txtDescription.TabIndex = 2;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(4, 97);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(177, 20);
            this.lblClientAddress.TabIndex = 29;
            this.lblClientAddress.Text = "Item Description:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(280, 55);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(406, 26);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.WordWrap = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(4, 56);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(122, 20);
            this.lblItemName.TabIndex = 28;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblItemAdd
            // 
            this.lblItemAdd.AutoSize = true;
            this.lblItemAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAdd.Location = new System.Drawing.Point(275, 9);
            this.lblItemAdd.Name = "lblItemAdd";
            this.lblItemAdd.Size = new System.Drawing.Size(188, 25);
            this.lblItemAdd.TabIndex = 27;
            this.lblItemAdd.Text = "ADD NEW ITEM";
            this.lblItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(280, 201);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 26);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.WordWrap = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(4, 202);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(115, 20);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Item Price:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(280, 233);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(111, 26);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.WordWrap = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(4, 234);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(152, 20);
            this.lblDiscount.TabIndex = 35;
            this.lblDiscount.Text = "Item Discount:";
            // 
            // itemColorDialog
            // 
            this.itemColorDialog.AnyColor = true;
            this.itemColorDialog.Color = System.Drawing.Color.Transparent;
            this.itemColorDialog.FullOpen = true;
            // 
            // lblItemColor
            // 
            this.lblItemColor.AutoSize = true;
            this.lblItemColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemColor.Location = new System.Drawing.Point(4, 430);
            this.lblItemColor.Name = "lblItemColor";
            this.lblItemColor.Size = new System.Drawing.Size(118, 20);
            this.lblItemColor.TabIndex = 37;
            this.lblItemColor.Text = "Item Color:";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseColor.Location = new System.Drawing.Point(280, 477);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(123, 32);
            this.btnChooseColor.TabIndex = 7;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // txtItemColor
            // 
            this.txtItemColor.BackColor = System.Drawing.Color.White;
            this.txtItemColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemColor.Location = new System.Drawing.Point(280, 429);
            this.txtItemColor.Name = "txtItemColor";
            this.txtItemColor.Size = new System.Drawing.Size(123, 45);
            this.txtItemColor.TabIndex = 38;
            this.txtItemColor.Text = "                ";
            // 
            // btnAddItemGroup
            // 
            this.btnAddItemGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemGroup.Location = new System.Drawing.Point(280, 380);
            this.btnAddItemGroup.Name = "btnAddItemGroup";
            this.btnAddItemGroup.Size = new System.Drawing.Size(156, 32);
            this.btnAddItemGroup.TabIndex = 40;
            this.btnAddItemGroup.Text = "Add Item Group";
            this.btnAddItemGroup.UseVisualStyleBackColor = true;
            this.btnAddItemGroup.Click += new System.EventHandler(this.btnAddItemGroup_Click);
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(4, 349);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(126, 20);
            this.lblItemGroup.TabIndex = 41;
            this.lblItemGroup.Text = "Item Group:";
            // 
            // cbItemGroup
            // 
            this.cbItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItemGroup.FormattingEnabled = true;
            this.cbItemGroup.Location = new System.Drawing.Point(280, 348);
            this.cbItemGroup.Name = "cbItemGroup";
            this.cbItemGroup.Size = new System.Drawing.Size(220, 26);
            this.cbItemGroup.TabIndex = 39;
            // 
            // frmItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 539);
            this.Controls.Add(this.btnAddItemGroup);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.cbItemGroup);
            this.Controls.Add(this.txtItemColor);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.lblItemColor);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnItemAddCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.frmItemAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemAddCompany;
        private System.Windows.Forms.Label lblCompany;
        public System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblClientAddress;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemAdd;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.ColorDialog itemColorDialog;
        private System.Windows.Forms.Label lblItemColor;
        private System.Windows.Forms.Button btnChooseColor;
        public System.Windows.Forms.Label txtItemColor;
        private System.Windows.Forms.Button btnAddItemGroup;
        private System.Windows.Forms.Label lblItemGroup;
        public System.Windows.Forms.ComboBox cbItemGroup;
    }
}
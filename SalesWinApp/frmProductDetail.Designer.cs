namespace SalesWinApp
{
    partial class frmProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbProductID = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            txtProductID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtCategoryID = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(45, 328);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(172, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(39, 45);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(79, 20);
            lbProductID.TabIndex = 2;
            lbProductID.Text = "Product ID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(39, 89);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(100, 20);
            lbProductName.TabIndex = 3;
            lbProductName.Text = "ProductName";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(39, 133);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(88, 20);
            lbCategoryID.TabIndex = 4;
            lbCategoryID.Text = "Category ID";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(39, 175);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(56, 20);
            lbWeight.TabIndex = 5;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(39, 223);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(68, 20);
            lbUnitPrice.TabIndex = 6;
            lbUnitPrice.Text = "UnitPrice";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(39, 270);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            lbUnitsInStock.TabIndex = 7;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(141, 38);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(125, 27);
            txtProductID.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(141, 82);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(125, 27);
            txtProductName.TabIndex = 9;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(141, 126);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(125, 27);
            txtCategoryID.TabIndex = 10;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(141, 168);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(125, 27);
            txtWeight.TabIndex = 11;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(141, 216);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(125, 27);
            txtUnitPrice.TabIndex = 12;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(141, 263);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(125, 27);
            txtUnitsInStock.TabIndex = 13;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(316, 392);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductName);
            Controls.Add(lbProductID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProductDetail";
            Text = "frmProductDetail";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
    }
}
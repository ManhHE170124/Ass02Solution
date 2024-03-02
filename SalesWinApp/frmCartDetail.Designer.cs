namespace SalesWinApp
{
    partial class frmCartDetail
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
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            txtCategoryID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.TextBox();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnAddToCart = new System.Windows.Forms.Button();
            lbQuantity = new System.Windows.Forms.Label();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(142, 234);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(125, 27);
            txtUnitPrice.TabIndex = 22;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(142, 186);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(125, 27);
            txtWeight.TabIndex = 21;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(142, 144);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(125, 27);
            txtCategoryID.TabIndex = 20;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(142, 100);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(125, 27);
            txtProductName.TabIndex = 19;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(142, 56);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(125, 27);
            txtProductID.TabIndex = 18;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(40, 241);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(68, 20);
            lbUnitPrice.TabIndex = 17;
            lbUnitPrice.Text = "UnitPrice";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(40, 193);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(56, 20);
            lbWeight.TabIndex = 16;
            lbWeight.Text = "Weight";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(40, 151);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(88, 20);
            lbCategoryID.TabIndex = 15;
            lbCategoryID.Text = "Category ID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(40, 107);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(100, 20);
            lbProductName.TabIndex = 14;
            lbProductName.Text = "ProductName";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(40, 63);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(79, 20);
            lbProductID.TabIndex = 13;
            lbProductID.Text = "Product ID";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(173, 317);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAddToCart.Location = new System.Drawing.Point(46, 317);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(121, 29);
            btnAddToCart.TabIndex = 24;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(40, 280);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(65, 20);
            lbQuantity.TabIndex = 25;
            lbQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new System.Drawing.Point(142, 273);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(125, 27);
            nudQuantity.TabIndex = 26;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // frmCartDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(342, 405);
            Controls.Add(nudQuantity);
            Controls.Add(lbQuantity);
            Controls.Add(btnAddToCart);
            Controls.Add(btnCancel);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductName);
            Controls.Add(lbProductID);
            Name = "frmCartDetail";
            Text = "frmCartDetail";
            Load += frmCartDetail_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}
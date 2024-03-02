namespace SalesWinApp
{
    partial class frmOrderDetail
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
            label1 = new System.Windows.Forms.Label();
            lbOrderID = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbDiscount = new System.Windows.Forms.Label();
            lbQuantity = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtDiscount = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(82, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Order Detail";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(29, 73);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(66, 20);
            lbOrderID.TabIndex = 1;
            lbOrderID.Text = "Order ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(29, 127);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(79, 20);
            lbProductID.TabIndex = 2;
            lbProductID.Text = "Product ID";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(29, 179);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new System.Drawing.Point(28, 279);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new System.Drawing.Size(67, 20);
            lbDiscount.TabIndex = 4;
            lbDiscount.Text = "Discount";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(30, 226);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(65, 20);
            lbQuantity.TabIndex = 5;
            lbQuantity.Text = "Quantity";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(114, 66);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(125, 27);
            txtOrderID.TabIndex = 6;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(114, 120);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(125, 27);
            txtProductID.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(114, 172);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(125, 27);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(114, 272);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(125, 27);
            txtDiscount.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(114, 219);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(125, 27);
            txtQuantity.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(72, 342);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(306, 413);
            Controls.Add(btnClose);
            Controls.Add(txtQuantity);
            Controls.Add(txtDiscount);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtOrderID);
            Controls.Add(lbQuantity);
            Controls.Add(lbDiscount);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductID);
            Controls.Add(lbOrderID);
            Controls.Add(label1);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnClose;
    }
}
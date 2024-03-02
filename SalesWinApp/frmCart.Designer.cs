namespace SalesWinApp
{
    partial class frmCart
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
            lbProductManagement = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            txtCategoryID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.TextBox();
            dgvProductList = new System.Windows.Forms.DataGridView();
            btnDESC = new System.Windows.Forms.Button();
            grpbFilter = new System.Windows.Forms.GroupBox();
            btnFilter = new System.Windows.Forms.Button();
            lbTo = new System.Windows.Forms.Label();
            rbUnitPrice = new System.Windows.Forms.RadioButton();
            lbFrom = new System.Windows.Forms.Label();
            txtTo = new System.Windows.Forms.TextBox();
            txtFrom = new System.Windows.Forms.TextBox();
            rbUnitsInStock = new System.Windows.Forms.RadioButton();
            grpbSearch = new System.Windows.Forms.GroupBox();
            txtSearch = new System.Windows.Forms.TextBox();
            cbSearch = new System.Windows.Forms.ComboBox();
            btnLoad = new System.Windows.Forms.Button();
            btnViewCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            grpbFilter.SuspendLayout();
            grpbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lbProductManagement
            // 
            lbProductManagement.AutoSize = true;
            lbProductManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductManagement.Location = new System.Drawing.Point(226, 9);
            lbProductManagement.Name = "lbProductManagement";
            lbProductManagement.Size = new System.Drawing.Size(217, 28);
            lbProductManagement.TabIndex = 25;
            lbProductManagement.Text = "Product Management";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(350, 150);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            lbUnitsInStock.TabIndex = 24;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(350, 100);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            lbUnitPrice.TabIndex = 23;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(350, 47);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(56, 20);
            lbWeight.TabIndex = 22;
            lbWeight.Text = "Weight";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(89, 150);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(84, 20);
            lbCategoryID.TabIndex = 21;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(89, 100);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(100, 20);
            lbProductName.TabIndex = 20;
            lbProductName.Text = "ProductName";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(89, 47);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(75, 20);
            lbProductID.TabIndex = 19;
            lbProductID.Text = "ProductID";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(464, 143);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(125, 27);
            txtUnitsInStock.TabIndex = 18;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(464, 93);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(125, 27);
            txtUnitPrice.TabIndex = 17;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(464, 47);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(125, 27);
            txtWeight.TabIndex = 16;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(194, 143);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(125, 27);
            txtCategoryID.TabIndex = 15;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(194, 93);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(125, 27);
            txtProductName.TabIndex = 14;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(194, 47);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(125, 27);
            txtProductID.TabIndex = 13;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new System.Drawing.Point(54, 337);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new System.Drawing.Size(567, 163);
            dgvProductList.TabIndex = 29;
            dgvProductList.DoubleClick += dgvProductList_DoubleClick;
            // 
            // btnDESC
            // 
            btnDESC.Location = new System.Drawing.Point(109, 302);
            btnDESC.Name = "btnDESC";
            btnDESC.Size = new System.Drawing.Size(94, 29);
            btnDESC.TabIndex = 28;
            btnDESC.Text = "DESC";
            btnDESC.UseVisualStyleBackColor = true;
            btnDESC.Click += btnDESC_Click;
            // 
            // grpbFilter
            // 
            grpbFilter.Controls.Add(btnFilter);
            grpbFilter.Controls.Add(lbTo);
            grpbFilter.Controls.Add(rbUnitPrice);
            grpbFilter.Controls.Add(lbFrom);
            grpbFilter.Controls.Add(txtTo);
            grpbFilter.Controls.Add(txtFrom);
            grpbFilter.Controls.Add(rbUnitsInStock);
            grpbFilter.Location = new System.Drawing.Point(307, 214);
            grpbFilter.Name = "grpbFilter";
            grpbFilter.Size = new System.Drawing.Size(320, 111);
            grpbFilter.TabIndex = 27;
            grpbFilter.TabStop = false;
            grpbFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(237, 69);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(77, 29);
            btnFilter.TabIndex = 21;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new System.Drawing.Point(160, 30);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(25, 20);
            lbTo.TabIndex = 23;
            lbTo.Text = "To";
            // 
            // rbUnitPrice
            // 
            rbUnitPrice.AutoSize = true;
            rbUnitPrice.Location = new System.Drawing.Point(14, 71);
            rbUnitPrice.Name = "rbUnitPrice";
            rbUnitPrice.Size = new System.Drawing.Size(93, 24);
            rbUnitPrice.TabIndex = 0;
            rbUnitPrice.TabStop = true;
            rbUnitPrice.Text = "Unit Price";
            rbUnitPrice.UseVisualStyleBackColor = true;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new System.Drawing.Point(9, 30);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(43, 20);
            lbFrom.TabIndex = 22;
            lbFrom.Text = "From";
            // 
            // txtTo
            // 
            txtTo.Location = new System.Drawing.Point(192, 27);
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(91, 27);
            txtTo.TabIndex = 3;
            // 
            // txtFrom
            // 
            txtFrom.Location = new System.Drawing.Point(58, 26);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(96, 27);
            txtFrom.TabIndex = 2;
            // 
            // rbUnitsInStock
            // 
            rbUnitsInStock.AutoSize = true;
            rbUnitsInStock.Location = new System.Drawing.Point(113, 71);
            rbUnitsInStock.Name = "rbUnitsInStock";
            rbUnitsInStock.Size = new System.Drawing.Size(119, 24);
            rbUnitsInStock.TabIndex = 20;
            rbUnitsInStock.TabStop = true;
            rbUnitsInStock.Text = "Units in Stock";
            rbUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // grpbSearch
            // 
            grpbSearch.Controls.Add(txtSearch);
            grpbSearch.Controls.Add(cbSearch);
            grpbSearch.Location = new System.Drawing.Point(40, 214);
            grpbSearch.Name = "grpbSearch";
            grpbSearch.Size = new System.Drawing.Size(261, 68);
            grpbSearch.TabIndex = 26;
            grpbSearch.TabStop = false;
            grpbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(113, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(142, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "ProductID", "ProductName", "CategoryID", "Weight" });
            cbSearch.Location = new System.Drawing.Point(6, 26);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new System.Drawing.Size(101, 28);
            cbSearch.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(207, 179);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 30;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new System.Drawing.Point(398, 179);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new System.Drawing.Size(94, 29);
            btnViewCart.TabIndex = 31;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(661, 512);
            Controls.Add(btnViewCart);
            Controls.Add(btnLoad);
            Controls.Add(dgvProductList);
            Controls.Add(btnDESC);
            Controls.Add(grpbFilter);
            Controls.Add(grpbSearch);
            Controls.Add(lbProductManagement);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductName);
            Controls.Add(lbProductID);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Name = "frmCart";
            Text = "frmCart";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            grpbFilter.ResumeLayout(false);
            grpbFilter.PerformLayout();
            grpbSearch.ResumeLayout(false);
            grpbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProductManagement;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.RadioButton rbUnitPrice;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.RadioButton rbUnitsInStock;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnViewCart;
    }
}
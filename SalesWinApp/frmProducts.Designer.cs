namespace SalesWinApp
{
    partial class frmProducts
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
            txtProductID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtCategoryID = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            lbProductID = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbProductManagement = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            grpbSearch = new System.Windows.Forms.GroupBox();
            txtSearch = new System.Windows.Forms.TextBox();
            cbSearch = new System.Windows.Forms.ComboBox();
            grpbFilter = new System.Windows.Forms.GroupBox();
            btnFilter = new System.Windows.Forms.Button();
            lbTo = new System.Windows.Forms.Label();
            rbUnitPrice = new System.Windows.Forms.RadioButton();
            lbFrom = new System.Windows.Forms.Label();
            txtTo = new System.Windows.Forms.TextBox();
            txtFrom = new System.Windows.Forms.TextBox();
            rbUnitsInStock = new System.Windows.Forms.RadioButton();
            btnDESC = new System.Windows.Forms.Button();
            dgvProductList = new System.Windows.Forms.DataGridView();
            grpbSearch.SuspendLayout();
            grpbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(158, 42);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(125, 27);
            txtProductID.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(158, 88);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(125, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(158, 138);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(125, 27);
            txtCategoryID.TabIndex = 2;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(428, 42);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(125, 27);
            txtWeight.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(428, 88);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(125, 27);
            txtUnitPrice.TabIndex = 4;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(428, 138);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(125, 27);
            txtUnitsInStock.TabIndex = 5;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(53, 42);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(75, 20);
            lbProductID.TabIndex = 6;
            lbProductID.Text = "ProductID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(53, 95);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(100, 20);
            lbProductName.TabIndex = 7;
            lbProductName.Text = "ProductName";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(53, 145);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(84, 20);
            lbCategoryID.TabIndex = 8;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(314, 42);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(56, 20);
            lbWeight.TabIndex = 9;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(314, 95);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            lbUnitPrice.TabIndex = 10;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(314, 145);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            lbUnitsInStock.TabIndex = 11;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbProductManagement
            // 
            lbProductManagement.AutoSize = true;
            lbProductManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductManagement.Location = new System.Drawing.Point(190, 4);
            lbProductManagement.Name = "lbProductManagement";
            lbProductManagement.Size = new System.Drawing.Size(217, 28);
            lbProductManagement.TabIndex = 12;
            lbProductManagement.Text = "Product Management";
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(81, 187);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(237, 187);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 14;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(393, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpbSearch
            // 
            grpbSearch.Controls.Add(txtSearch);
            grpbSearch.Controls.Add(cbSearch);
            grpbSearch.Location = new System.Drawing.Point(12, 222);
            grpbSearch.Name = "grpbSearch";
            grpbSearch.Size = new System.Drawing.Size(261, 68);
            grpbSearch.TabIndex = 16;
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
            // grpbFilter
            // 
            grpbFilter.Controls.Add(btnFilter);
            grpbFilter.Controls.Add(lbTo);
            grpbFilter.Controls.Add(rbUnitPrice);
            grpbFilter.Controls.Add(lbFrom);
            grpbFilter.Controls.Add(txtTo);
            grpbFilter.Controls.Add(txtFrom);
            grpbFilter.Controls.Add(rbUnitsInStock);
            grpbFilter.Location = new System.Drawing.Point(279, 222);
            grpbFilter.Name = "grpbFilter";
            grpbFilter.Size = new System.Drawing.Size(320, 111);
            grpbFilter.TabIndex = 17;
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
            // btnDESC
            // 
            btnDESC.Location = new System.Drawing.Point(81, 310);
            btnDESC.Name = "btnDESC";
            btnDESC.Size = new System.Drawing.Size(94, 29);
            btnDESC.TabIndex = 18;
            btnDESC.Text = "DESC";
            btnDESC.UseVisualStyleBackColor = true;
            btnDESC.Click += btnDESC_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new System.Drawing.Point(26, 345);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new System.Drawing.Size(567, 163);
            dgvProductList.TabIndex = 19;
            dgvProductList.CellDoubleClick += dgvProductList_CellDoubleClick;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(611, 523);
            Controls.Add(dgvProductList);
            Controls.Add(btnDESC);
            Controls.Add(grpbFilter);
            Controls.Add(grpbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
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
            Name = "frmProducts";
            Text = "frmProducts";
            grpbSearch.ResumeLayout(false);
            grpbSearch.PerformLayout();
            grpbFilter.ResumeLayout(false);
            grpbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbProductManagement;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.RadioButton rbUnitPrice;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.RadioButton rbUnitsInStock;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
    }
}
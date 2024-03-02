namespace SalesWinApp
{
    partial class frmOrders
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
            txtOrderID = new System.Windows.Forms.TextBox();
            txtOrderDate = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbOrderID = new System.Windows.Forms.Label();
            lbOrderDate = new System.Windows.Forms.Label();
            lbMemberID = new System.Windows.Forms.Label();
            dgvOrderList = new System.Windows.Forms.DataGridView();
            grpbSearch = new System.Windows.Forms.GroupBox();
            btnSearch = new System.Windows.Forms.Button();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            lbEndDate = new System.Windows.Forms.Label();
            lbStartDate = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            lbFreight = new System.Windows.Forms.Label();
            txtFreight = new System.Windows.Forms.TextBox();
            lbOrder = new System.Windows.Forms.Label();
            lbRequiredDate = new System.Windows.Forms.Label();
            lbShippedDate = new System.Windows.Forms.Label();
            txtShippedDate = new System.Windows.Forms.TextBox();
            txtRequiredDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            grpbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(149, 33);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(125, 27);
            txtOrderID.TabIndex = 0;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new System.Drawing.Point(149, 72);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(125, 27);
            txtOrderDate.TabIndex = 1;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(149, 105);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(125, 27);
            txtMemberID.TabIndex = 3;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(45, 40);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(66, 20);
            lbOrderID.TabIndex = 4;
            lbOrderID.Text = "Order ID";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(45, 75);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(83, 20);
            lbOrderDate.TabIndex = 5;
            lbOrderDate.Text = "Order Date";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(45, 108);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 7;
            lbMemberID.Text = "Member ID";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new System.Drawing.Point(82, 250);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new System.Drawing.Size(520, 188);
            dgvOrderList.TabIndex = 8;
            dgvOrderList.CellContentDoubleClick += dgvOrderList_CellContentDoubleClick;
            // 
            // grpbSearch
            // 
            grpbSearch.Controls.Add(btnSearch);
            grpbSearch.Controls.Add(dtpEndDate);
            grpbSearch.Controls.Add(dtpStartDate);
            grpbSearch.Controls.Add(lbEndDate);
            grpbSearch.Controls.Add(lbStartDate);
            grpbSearch.Location = new System.Drawing.Point(280, 51);
            grpbSearch.Name = "grpbSearch";
            grpbSearch.Size = new System.Drawing.Size(379, 177);
            grpbSearch.TabIndex = 9;
            grpbSearch.TabStop = false;
            grpbSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(150, 129);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(87, 79);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(250, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(87, 36);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(250, 27);
            dtpStartDate.TabIndex = 2;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new System.Drawing.Point(16, 86);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new System.Drawing.Size(70, 20);
            lbEndDate.TabIndex = 1;
            lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new System.Drawing.Point(16, 40);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new System.Drawing.Size(76, 20);
            lbStartDate.TabIndex = 0;
            lbStartDate.Text = "Start Date";
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(608, 250);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new System.Drawing.Point(45, 141);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new System.Drawing.Size(55, 20);
            lbFreight.TabIndex = 11;
            lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new System.Drawing.Point(149, 134);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new System.Drawing.Size(125, 27);
            txtFreight.TabIndex = 12;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbOrder.Location = new System.Drawing.Point(296, 9);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new System.Drawing.Size(66, 28);
            lbOrder.TabIndex = 13;
            lbOrder.Text = "Order";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new System.Drawing.Point(42, 174);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            lbRequiredDate.TabIndex = 14;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new System.Drawing.Point(42, 208);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new System.Drawing.Size(100, 20);
            lbShippedDate.TabIndex = 15;
            lbShippedDate.Text = "Shipped Date";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new System.Drawing.Point(149, 200);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new System.Drawing.Size(125, 27);
            txtShippedDate.TabIndex = 16;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new System.Drawing.Point(149, 167);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new System.Drawing.Size(125, 27);
            txtRequiredDate.TabIndex = 17;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(707, 450);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtShippedDate);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrder);
            Controls.Add(txtFreight);
            Controls.Add(lbFreight);
            Controls.Add(btnLoad);
            Controls.Add(grpbSearch);
            Controls.Add(dgvOrderList);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderDate);
            Controls.Add(lbOrderID);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderDate);
            Controls.Add(txtOrderID);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            grpbSearch.ResumeLayout(false);
            grpbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
    }
}
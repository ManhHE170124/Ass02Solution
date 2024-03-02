namespace SalesWinApp
{
    partial class frmMember
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
            lbMemberID = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbCompanyName = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbMemberManagement = new System.Windows.Forms.Label();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtCompanyName = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            cbSearch = new System.Windows.Forms.ComboBox();
            txtSearch = new System.Windows.Forms.TextBox();
            cbFilter = new System.Windows.Forms.ComboBox();
            cbLocation = new System.Windows.Forms.ComboBox();
            btnDESC = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            grpbSearch = new System.Windows.Forms.GroupBox();
            grpbFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            grpbSearch.SuspendLayout();
            grpbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(52, 48);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "MemberID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(52, 102);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(52, 157);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(325, 48);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(112, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "CompanyName";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(325, 102);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(325, 157);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbMemberManagement
            // 
            lbMemberManagement.AutoSize = true;
            lbMemberManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbMemberManagement.Location = new System.Drawing.Point(203, 9);
            lbMemberManagement.Name = "lbMemberManagement";
            lbMemberManagement.Size = new System.Drawing.Size(222, 28);
            lbMemberManagement.TabIndex = 6;
            lbMemberManagement.Text = "Member Management";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(138, 41);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(125, 27);
            txtMemberID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(138, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(138, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(125, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(443, 41);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(125, 27);
            txtCompanyName.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(443, 95);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(125, 27);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(443, 150);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(125, 27);
            txtCountry.TabIndex = 12;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "MemberId", "Email", "CompanyName" });
            cbSearch.Location = new System.Drawing.Point(6, 22);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new System.Drawing.Size(104, 28);
            cbSearch.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(116, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(110, 27);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "City", "Country" });
            cbFilter.Location = new System.Drawing.Point(6, 22);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(104, 28);
            cbFilter.TabIndex = 15;
            // 
            // cbLocation
            // 
            cbLocation.FormattingEnabled = true;
            cbLocation.Items.AddRange(new object[] { "HaNoi", "Vinh", "HoaBinh", "Hue", "HoChiMinh", "VietNam" });
            cbLocation.Location = new System.Drawing.Point(116, 21);
            cbLocation.Name = "cbLocation";
            cbLocation.Size = new System.Drawing.Size(109, 28);
            cbLocation.TabIndex = 16;
            cbLocation.SelectedIndexChanged += cbLocation_SelectedIndexChanged;
            // 
            // btnDESC
            // 
            btnDESC.Location = new System.Drawing.Point(532, 251);
            btnDESC.Name = "btnDESC";
            btnDESC.Size = new System.Drawing.Size(94, 29);
            btnDESC.TabIndex = 17;
            btnDESC.Text = "DESC";
            btnDESC.UseVisualStyleBackColor = true;
            btnDESC.Click += btnDESC_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(52, 297);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new System.Drawing.Size(516, 154);
            dgvMemberList.TabIndex = 18;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(102, 194);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(278, 194);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(443, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpbSearch
            // 
            grpbSearch.Controls.Add(cbSearch);
            grpbSearch.Controls.Add(txtSearch);
            grpbSearch.Location = new System.Drawing.Point(52, 229);
            grpbSearch.Name = "grpbSearch";
            grpbSearch.Size = new System.Drawing.Size(231, 56);
            grpbSearch.TabIndex = 22;
            grpbSearch.TabStop = false;
            grpbSearch.Text = "Search";
            // 
            // grpbFilter
            // 
            grpbFilter.Controls.Add(cbFilter);
            grpbFilter.Controls.Add(cbLocation);
            grpbFilter.Location = new System.Drawing.Point(295, 229);
            grpbFilter.Name = "grpbFilter";
            grpbFilter.Size = new System.Drawing.Size(231, 56);
            grpbFilter.TabIndex = 23;
            grpbFilter.TabStop = false;
            grpbFilter.Text = "Filter";
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(637, 476);
            Controls.Add(grpbFilter);
            Controls.Add(grpbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDESC);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberManagement);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Name = "frmMember";
            Text = "frmMember";
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            grpbSearch.ResumeLayout(false);
            grpbSearch.PerformLayout();
            grpbFilter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbMemberManagement;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbFilter;
    }
}
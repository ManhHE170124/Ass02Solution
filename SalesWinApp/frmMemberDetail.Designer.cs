namespace SalesWinApp
{
    partial class frmMemberDetail
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
            txtMemberID = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtCompanyName = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnViewProduct = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(113, 45);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "MemberID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(113, 85);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(113, 129);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(113, 174);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(112, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "CompanyName";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(113, 218);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(113, 261);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(227, 38);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(177, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(227, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(177, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(227, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(177, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(227, 167);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(177, 27);
            txtCompanyName.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(227, 211);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(177, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(227, 254);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(177, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(113, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(284, 321);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnViewProduct
            // 
            btnViewProduct.Location = new System.Drawing.Point(183, 374);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.Size = new System.Drawing.Size(128, 29);
            btnViewProduct.TabIndex = 14;
            btnViewProduct.Text = "View Product";
            btnViewProduct.UseVisualStyleBackColor = true;
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 450);
            Controls.Add(btnViewProduct);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
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
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewProduct;
    }
}
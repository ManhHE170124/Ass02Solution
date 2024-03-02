namespace SalesWinApp
{
    partial class frmChooseManagement
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
            btnMemberManagement = new System.Windows.Forms.Button();
            btnOrderManagement = new System.Windows.Forms.Button();
            btnProductManagement = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnMemberManagement
            // 
            btnMemberManagement.Location = new System.Drawing.Point(12, 92);
            btnMemberManagement.Name = "btnMemberManagement";
            btnMemberManagement.Size = new System.Drawing.Size(143, 64);
            btnMemberManagement.TabIndex = 0;
            btnMemberManagement.Text = "Member Management";
            btnMemberManagement.UseVisualStyleBackColor = true;
            btnMemberManagement.Click += btnMemberManagement_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.Location = new System.Drawing.Point(184, 92);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new System.Drawing.Size(133, 64);
            btnOrderManagement.TabIndex = 1;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = true;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new System.Drawing.Point(345, 92);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new System.Drawing.Size(135, 64);
            btnProductManagement.TabIndex = 2;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // frmChooseManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 310);
            Controls.Add(btnProductManagement);
            Controls.Add(btnOrderManagement);
            Controls.Add(btnMemberManagement);
            Name = "frmChooseManagement";
            Text = "frmChooseManagement";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnMemberManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnProductManagement;
    }
}
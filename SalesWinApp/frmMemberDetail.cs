using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        public MemberObject Admin {  get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject Member { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if (Admin != null && Admin.Email.Equals("admin@fstore.com"))
            {
                btnViewProduct.Visible = false;
            }

            txtMemberID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = Member.MemberId.ToString();
                txtEmail.Text = Member.Email;
                txtPassword.Text = Member.Password;
                txtCompanyName.Text = Member.CompanyName;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Insert a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
                frmCart frmCart = new frmCart()
                {
                    Member = Member
                };
                frmCart.ShowDialog();
        }
    }
}

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
    public partial class frmMember : Form
    {
        public MemberObject Admin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMember()
        {
            InitializeComponent();
        }
        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                Member = GetMemberObject(),
                MemberRepository = memberRepository,
                Admin = Admin,
                
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }
        private void LoadMemberList()
        {
            var members = memberRepository.GetAllMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            if (btnDESC.Text.Equals("DESC"))
            {
                List<MemberObject> list = memberRepository.GetMemberByDescending();
                btnDESC.Text = "ASC";
                dgvMemberList.DataSource = list;
            }
            else if (btnDESC.Text.Equals("ASC"))
            {
                List<MemberObject> list = memberRepository.GetMemberByAscending();
                btnDESC.Text = "DESC";
                dgvMemberList.DataSource = list;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = cbSearch.Text;
            string key = txtSearch.Text;
            List<MemberObject> list = memberRepository.GetMemberBySearch(search, key);
            dgvMemberList.DataSource = list;
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cbFilter.Text;
            string location = cbLocation.Text;
            List<MemberObject> list = memberRepository.GetMemberByFilter(filter, location);
            dgvMemberList.DataSource = list;
        }
    }
}

using BusinessObject;
using DataAccess;
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
    public partial class frmLogin : Form
    {
        public MemberObject member { get; set; }
        public IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MemberRepository memberRepository = new MemberRepository();
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            if(email != null && password != null)
            {
                if (email.Equals("admin@fstore.com") && password.Equals("admin@@"))
                {
                    frmChooseManagement frmChooseManagement = new frmChooseManagement();
                    frmChooseManagement.ShowDialog();
                }
                else if (memberRepository.GetMemberByEmailAndPassword(email, password) != null)
                {
                    frmMemberDetail frmMemberDetail = new frmMemberDetail()
                    {
                        Member = memberRepository.GetMemberByEmailAndPassword(email, password),
                        Text = "Info Member",
                        InsertOrUpdate = true,
                        MemberRepository = memberRepository
                    };
                    frmMemberDetail.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter wrong email or password");
                }
            }           
        }
    }
}

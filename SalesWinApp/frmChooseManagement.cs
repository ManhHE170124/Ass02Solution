using BusinessObject;
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
    public partial class frmChooseManagement : Form
    {
        public MemberObject member;
        public frmChooseManagement()
        {
            InitializeComponent();
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Admin = new MemberObject()
                {
                    Email = "admin@fstore.com",
                    Password = "admin@@"
                }
            };
            frmMember.ShowDialog();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders()
            {
                member = new MemberObject()
                {
                    Email = "admin@fstore.com",
                    Password = "admin@@"
                }
            };
            frmOrders.ShowDialog();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }
    }
}

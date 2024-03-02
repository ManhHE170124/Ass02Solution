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
    public partial class frmOrderDetail : Form
    {
        public OrderDetailObject OrderDetail { get; set; }
        public IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderID.Text = OrderDetail.OrderId.ToString();
            txtProductID.Text = OrderDetail.ProductId.ToString();
            txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
            txtQuantity.Text = OrderDetail.Quantity.ToString();
            txtDiscount.Text = OrderDetail.Discount.ToString();
        }
    }
}

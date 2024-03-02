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
    public partial class frmCartDetail : Form
    {
        public MemberObject member { get; set; }
        public OrdersRepository OrdersRepository = new OrdersRepository();
        public OrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject Product { get; set; }
        public frmCartDetail()
        {
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(nudQuantity.Value <=0 ) {
                MessageBox.Show("Quantity must be greater than 0");
                return;
            }
            
            OrdersObject ordersObject = new OrdersObject()
            {
                OrderDate = DateTime.Now,
                MemberId = member.MemberId,
                Freight = decimal.Parse(txtUnitPrice.Text),
                RequiredDate = DateTime.Now.AddDays(2),
                ShippedDate = DateTime.Now.AddDays(7)
            };

            OrdersRepository.InsertOrder(ordersObject);
            MessageBox.Show("Add successfull");
            int orderId = 0;
            //code to get the orderId last inserted
            List<OrdersObject> orders = (List<OrdersObject>)OrdersRepository.GetAllOrders();
            if (orders.Count > 0)
            {
                orderId = orders[orders.Count - 1].OrderId;
            }
            else
            {
                orderId = 0;
            }

            if (orderId == 0)
            {
                MessageBox.Show("Failed to add order");
                return;
            }

            OrderDetailObject OrderDetail = new OrderDetailObject()
            {
                OrderId = orderId,
                ProductId = int.Parse(txtProductID.Text),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = (int)nudQuantity.Value,
                Discount = 0
            };
            
            OrderDetailRepository.InsertOrderDetail(OrderDetail);
            
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmCartDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = Product.ProductId.ToString();
                txtProductName.Text = Product.ProductName.ToString();
                txtCategoryID.Text = Product.CategoryId.ToString();
                txtWeight.Text = Product.Weight.ToString();
                txtUnitPrice.Text = Product.UnitPrice.ToString();
            }
        }
    }
}

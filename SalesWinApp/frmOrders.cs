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
    public partial class frmOrders : Form
    {
        public MemberObject member { get; set; }
        public OrderDetailObject orderDetail { get; set; }
        public IOrdersRepository ordersRepository = new OrdersRepository();
        public IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            if (!member.Email.Equals("admin@fstore.com") && !member.Password.Equals("admin@@"))
            {
                var orders = ordersRepository.GetAllOrdersByMemberId(member.MemberId);
                try
                {
                    source = new BindingSource();
                    source.DataSource = orders;

                    txtOrderID.DataBindings.Clear();
                    txtOrderDate.DataBindings.Clear();
                    txtMemberID.DataBindings.Clear();
                    txtFreight.DataBindings.Clear();
                    txtRequiredDate.DataBindings.Clear();
                    txtShippedDate.DataBindings.Clear();

                    txtOrderID.DataBindings.Add("Text", source, "OrderID");
                    txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                    txtMemberID.DataBindings.Add("Text", source, "OrderID");
                    txtFreight.DataBindings.Add("Text", source, "Freight");
                    txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                    txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load order list");
                }
            }
            else
            {
                var orders = ordersRepository.GetAllOrders();
                try
                {
                    source = new BindingSource();
                    source.DataSource = orders;

                    txtOrderID.DataBindings.Clear();
                    txtOrderDate.DataBindings.Clear();
                    txtMemberID.DataBindings.Clear();
                    txtFreight.DataBindings.Clear();
                    txtRequiredDate.DataBindings.Clear();
                    txtShippedDate.DataBindings.Clear();

                    txtOrderID.DataBindings.Add("Text", source, "OrderID");
                    txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                    txtMemberID.DataBindings.Add("Text", source, "OrderID");
                    txtFreight.DataBindings.Add("Text", source, "Freight");
                    txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                    txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                    dgvOrderList.DataSource = null;
                    dgvOrderList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load order list");
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("StartDate should be < EndDate");
            }
            else
            {
                if (!member.Email.Equals("admin@fstore.com") && !member.Password.Equals("admin@@"))
                {
                    List<OrdersObject> list = ordersRepository.GetOrderBySearchAndId(member.MemberId, startDate, endDate);
                    dgvOrderList.DataSource = list;
                }
                else
                {
                    List<OrdersObject> list = ordersRepository.GetOrderBySearch(startDate, endDate);
                    dgvOrderList.DataSource = list;
                }
            }
        }

        private void dgvOrderList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail()
            {
                Text = "Order Detail",
                OrderDetail = orderDetailRepository.GetOrderDetailObject(int.Parse(txtOrderID.Text)),
                OrderDetailRepository = orderDetailRepository
                

            };
            frmOrderDetail.ShowDialog();
            LoadOrderList();
            source.Position = source.Count - 1;
        }

        private OrdersObject GetOrderObject()
        {
            OrdersObject order = null;
            try
            {
                order = new OrdersObject()
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtOrderDate.Text).AddDays(2),
                    ShippedDate = DateTime.Parse(txtOrderDate.Text).AddDays(7),
                    Freight = decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            dgvOrderList.CellDoubleClick += dgvOrderList_CellContentDoubleClick;
        }
    }
}

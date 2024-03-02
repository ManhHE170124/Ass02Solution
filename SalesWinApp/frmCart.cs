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

    public partial class frmCart : Form
    {
        public MemberObject Member { get; set; }
        public OrderDetailObject OrderDetail { get; set; }
        public IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmCart()
        {
            InitializeComponent();
        }
        private ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return product;
        }
        private void LoadProductList()
        {
            var products = productRepository.GetAllProduct();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = cbSearch.Text;
            string key = txtSearch.Text;
            List<ProductObject> list = productRepository.GetProductBySearch(search, key);
            dgvProductList.DataSource = list;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MemberRepository memberRepository = new MemberRepository();
            if (rbUnitPrice.Checked == true)
            {
                decimal from = decimal.Parse(txtFrom.Text);
                decimal to = decimal.Parse(txtTo.Text);
                if (from != null && to != null)
                {
                    List<ProductObject> list = productRepository.GetProductByUnitPrice(from, to);
                    dgvProductList.DataSource = list;
                }
                else
                {
                    dgvProductList.DataSource = memberRepository.GetAllMembers();
                }
            }
            else if (rbUnitsInStock.Checked == true)
            {
                int from = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                if (from != null && to != null)
                {
                    List<ProductObject> list = productRepository.GetProductByUnitsInStock(from, to);
                    dgvProductList.DataSource = list;
                }
                else
                {
                    dgvProductList.DataSource = memberRepository.GetAllMembers();
                }
            }
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            if (btnDESC.Text.Equals("DESC"))
            {
                List<ProductObject> list = productRepository.GetProductByAscending();
                btnDESC.Text = "ASC";
                dgvProductList.DataSource = list;
            }
            else if (btnDESC.Text.Equals("ASC"))
            {
                List<ProductObject> list = productRepository.GetProductByDescending();
                btnDESC.Text = "DESC";
                dgvProductList.DataSource = list;
            }
        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {

            frmCartDetail frmCartDetail = new frmCartDetail()
            {
                member = Member,
                Text = "Add To Cart",
                InsertOrUpdate = true,
                Product = GetProductObject(),
                ProductRepository = productRepository
            };
            if (frmCartDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            
            frmOrders frmOrders = new frmOrders()
            {
                member = Member,
                orderDetail = OrderDetail
            };
            frmOrders.ShowDialog();
        }
    }
}

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
    public partial class frmProductDetail : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject Product { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = Product.ProductId.ToString();
                txtProductName.Text = Product.ProductName.ToString();
                txtCategoryID.Text = Product.CategoryId.ToString();
                txtWeight.Text = Product.Weight.ToString();
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductObject
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(product);
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Insert a new product" : "Update a product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();     
    }
}

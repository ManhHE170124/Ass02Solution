using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int ProductId) => ProductDAO.Instance.Remove(ProductId);

        public IEnumerable<ProductObject> GetAllProduct() => ProductDAO.Instance.GetProductList();

        public List<ProductObject> GetProductByAscending() => ProductDAO.Instance.GetProductByAscending();

        public List<ProductObject> GetProductByDescending() => ProductDAO.Instance.GetProductByDescending();

        public List<ProductObject> GetProductBySearch(string search, string key) => ProductDAO.Instance.GetProductBySearch(search, key);

        public List<ProductObject> GetProductByUnitPrice(decimal from, decimal to) => ProductDAO.Instance.GetProductByUnitPrice(from, to);

        public List<ProductObject> GetProductByUnitsInStock(int from, int to) => ProductDAO.Instance.GetProductByUnitsInStock(from, to);

        public ProductObject GetProductObject(int ProductId) => ProductDAO.Instance.GetProductByID(ProductId);

        public void InsertProduct(ProductObject product) => ProductDAO.Instance.AddNew(product);

        public void UpdateProduct(ProductObject product) => ProductDAO.Instance.Update(product);
    }
}

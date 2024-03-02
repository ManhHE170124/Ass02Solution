using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetAllProduct();
        ProductObject GetProductObject(int ProductId);
        void InsertProduct(ProductObject product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(ProductObject product);
        List<ProductObject> GetProductBySearch(string search, string key);
        List<ProductObject> GetProductByUnitPrice(decimal from, decimal to);
        List<ProductObject> GetProductByUnitsInStock(int from, int to);
        List<ProductObject> GetProductByDescending();
        List<ProductObject> GetProductByAscending();
    }
}

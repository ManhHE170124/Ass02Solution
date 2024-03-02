using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        CategoryId = dataReader.GetInt32(dataReader.GetOrdinal("CategoryId")),
                        ProductName = dataReader.GetString(dataReader.GetOrdinal("ProductName")),
                        Weight = dataReader.GetString(dataReader.GetOrdinal("Weight")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        UnitsInStock = dataReader.GetInt32(dataReader.GetOrdinal("UnitsInStock"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }
        public ProductObject GetProductByID(int ProductId)
        {
            ProductObject product = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock from Product where ProductId = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, ProductId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    product = new ProductObject
                    {
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        CategoryId = dataReader.GetInt32(dataReader.GetOrdinal("CategoryId")),
                        ProductName = dataReader.GetString(dataReader.GetOrdinal("ProductName")),
                        Weight = dataReader.GetString(dataReader.GetOrdinal("Weight")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        UnitsInStock = dataReader.GetInt32(dataReader.GetOrdinal("UnitsInStock"))
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return product;
        }
        public void AddNew(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductByID(product.ProductId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Product values(@ProductId, @CategoryId, @ProductName, @Weight, @UnitPrice, @UnitsInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 15, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(ProductObject product)
        {
            try
            {
                ProductObject c = GetProductByID(product.ProductId);
                if (c != null)
                {
                    string SQLUpdate = "Update Product set CategoryId = @CategoryId, ProductName = @ProductName, " +
                        "Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock where ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 15, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int ProductId)
        {
            try
            {
                ProductObject product = GetProductByID(ProductId);
                if (product != null)
                {
                    string SQLDelete = "Delete Product where ProductId = @ProductId";
                    var param = dataProvider.CreateParameter("@ProductId", 4, ProductId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The product does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<ProductObject> GetProductBySearch(string search, string key)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Product WHERE " + search + " LIKE @keyword";
            var products = new List<ProductObject>();
            try
            {
                var param = dataProvider.CreateParameter("@keyword", 20, "%" + key + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        ProductName = dataReader.GetString(dataReader.GetOrdinal("ProductName")),
                        CategoryId = dataReader.GetInt32(dataReader.GetOrdinal("CategoryId")),
                        Weight = dataReader.GetString(dataReader.GetOrdinal("Weight")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        UnitsInStock = dataReader.GetInt32(dataReader.GetOrdinal("UnitsInStock"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }

        public List<ProductObject> GetProductByUnitPrice(decimal from, decimal to)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Product WHERE UnitPrice between @from and @to";
            var products = new List<ProductObject>();
            try
            {
                var param1 = dataProvider.CreateParameter("@from", 20, from, DbType.Decimal);
                var param2 = dataProvider.CreateParameter("@to", 20, to, DbType.Decimal);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param1, param2);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        ProductName = dataReader.GetString(dataReader.GetOrdinal("ProductName")),
                        CategoryId = dataReader.GetInt32(dataReader.GetOrdinal("CategoryId")),
                        Weight = dataReader.GetString(dataReader.GetOrdinal("Weight")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        UnitsInStock = dataReader.GetInt32(dataReader.GetOrdinal("UnitsInStock"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }

        public List<ProductObject> GetProductByUnitsInStock(int from, int to)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Product WHERE UnitsInStock between @from and @to";
            var products = new List<ProductObject>();
            try
            {
                var param1 = dataProvider.CreateParameter("@from", 20, from, DbType.Decimal);
                var param2 = dataProvider.CreateParameter("@to", 20, to, DbType.Decimal);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param1, param2);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        ProductName = dataReader.GetString(dataReader.GetOrdinal("ProductName")),
                        CategoryId = dataReader.GetInt32(dataReader.GetOrdinal("CategoryId")),
                        Weight = dataReader.GetString(dataReader.GetOrdinal("Weight")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        UnitsInStock = dataReader.GetInt32(dataReader.GetOrdinal("UnitsInStock"))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }

        public List<ProductObject> GetProductByAscending()
        {
            List<ProductObject> list = GetProductList().OrderByDescending(x => x.ProductId).ToList();
            return list;
        }

        public List<ProductObject> GetProductByDescending()
        {
            List<ProductObject> list = GetProductList().OrderBy(x => x.ProductId).ToList();
            return list;
        }
    }
}


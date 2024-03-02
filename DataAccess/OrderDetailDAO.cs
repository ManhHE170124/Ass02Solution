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
    public class OrderDetailDAO : BaseDAL
    { 
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetailObject> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, ProductId, UnitPrice, Quantity, Discount from OrderDetail";
            var orderdetails = new List<OrderDetailObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderdetails.Add(new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        Quantity = dataReader.GetInt32(dataReader.GetOrdinal("Quantity")),
                        Discount = dataReader.GetDecimal(dataReader.GetOrdinal("Discount")),
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
            return orderdetails;
        }
        public OrderDetailObject GetOrderDetailByID(int OrderId)
        {
            OrderDetailObject orderdetail = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, ProductId, UnitPrice, Quantity, Discount from OrderDetail where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, OrderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    orderdetail = new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        ProductId = dataReader.GetInt32(dataReader.GetOrdinal("ProductId")),
                        UnitPrice = dataReader.GetDecimal(dataReader.GetOrdinal("UnitPrice")),
                        Quantity = dataReader.GetInt32(dataReader.GetOrdinal("Quantity")),
                        Discount = dataReader.GetDecimal(dataReader.GetOrdinal("Discount")),
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
            return orderdetail;
        }
        public void AddNew(OrderDetailObject orderdetail)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByID(orderdetail.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "Insert OrderDetail values(@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderdetail.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, orderdetail.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 15, orderdetail.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderdetail.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 15, orderdetail.Discount, DbType.Double));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order detail is already exist");
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
        public void Update(OrderDetailObject orderdetail)
        {
            try
            {
                OrderDetailObject c = GetOrderDetailByID(orderdetail.OrderId);
                if (c != null)
                {
                    string SQLUpdate = "Update OrderDetail set ProductId = @ProductId, UnitPrice = @UnitPrice, " +
                        "Quantity = @Quantity, Discount = @Discount where OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, orderdetail.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, orderdetail.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 15, orderdetail.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderdetail.Quantity, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 15, orderdetail.Discount, DbType.Double));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order detail does not already exist");
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
        public void Remove(int OrderId)
        {
            try
            {
                OrderDetailObject orderdetail = GetOrderDetailByID(OrderId);
                if (orderdetail != null)
                {
                    string SQLDelete = "Delete OrderDetail where OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, OrderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The order detail does not already exist");
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
    }
}


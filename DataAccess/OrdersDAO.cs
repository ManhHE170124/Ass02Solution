using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrdersDAO : BaseDAL
    {
        private static OrdersDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrdersDAO() { }
        public static OrdersDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrdersDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrdersObject> GetOrdersList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight from Orders";
            var orders = new List<OrdersObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrdersObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                        RequiredDate = dataReader.GetDateTime(dataReader.GetOrdinal("RequiredDate")),
                        ShippedDate = dataReader.GetDateTime(dataReader.GetOrdinal("ShippedDate")),
                        Freight = dataReader.GetDecimal(dataReader.GetOrdinal("Freight"))
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
            return orders;
        }
        public OrdersObject GetOrderByID(int OrderId)
        {
            OrdersObject order = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight from Orders where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, OrderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrdersObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                        RequiredDate = dataReader.GetDateTime(dataReader.GetOrdinal("RequiredDate")),
                        ShippedDate = dataReader.GetDateTime(dataReader.GetOrdinal("ShippedDate")),
                        Freight = dataReader.GetDecimal(dataReader.GetOrdinal("Freight"))
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
            return order;
        }
        public void AddNew(OrdersObject order)
        {
            try
            {
                OrdersObject pro = GetOrderByID(order.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Orders values(@MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 40, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 40, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 40, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 15, order.Freight, DbType.Decimal));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrdersObject order)
        {
            try
            {
                OrdersObject c = GetOrderByID(order.OrderId);
                if (c != null)
                {
                    string SQLUpdate = "Update Orders set MemberId = @MemberId, OrderDate = @OrderDate, " +
                        "RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, Freight = @Freight where OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 40, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 40, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 40, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 15, order.Freight, DbType.Decimal));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist");
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
                OrdersObject order = GetOrderByID(OrderId);
                if (order != null)
                {
                    string SQLDelete = "Delete Orders where OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, OrderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The order does not already exist");
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

        public List<OrdersObject> GetOrderBySearch(DateTime startDate, DateTime endDate)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Orders WHERE OrderDate between @startDate and @endDate";
            var orders = new List<OrdersObject>();
            try
            {
                var param1 = dataProvider.CreateParameter("@startDate", 20, startDate, DbType.DateTime);
                var param2 = dataProvider.CreateParameter("@endDate", 20, endDate, DbType.DateTime);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param1, param2);
                while (dataReader.Read())
                {
                    orders.Add(new OrdersObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                        RequiredDate = dataReader.GetDateTime(dataReader.GetOrdinal("RequiredDate")),
                        ShippedDate = dataReader.GetDateTime(dataReader.GetOrdinal("ShippedDate")),
                        Freight = dataReader.GetDecimal(dataReader.GetOrdinal("Freight"))
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
            return orders;
        }

        public IEnumerable<OrdersObject> GetOrdersListByMemberId(int memberId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight from Orders where MemberId = @memberId";
            var orders = new List<OrdersObject>();
            try
            {
                var param = dataProvider.CreateParameter("@memberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orders.Add(new OrdersObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                        RequiredDate = dataReader.GetDateTime(dataReader.GetOrdinal("RequiredDate")),
                        ShippedDate = dataReader.GetDateTime(dataReader.GetOrdinal("ShippedDate")),
                        Freight = dataReader.GetDecimal(dataReader.GetOrdinal("Freight"))
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
            return orders;
        }

        public List<OrdersObject> GetOrderBySearchAndId(int memberId, DateTime startDate, DateTime endDate)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Orders WHERE MemberId = @memberId and OrderDate between @startDate and @endDate";
            var orders = new List<OrdersObject>();
            try
            {
                var param1 = dataProvider.CreateParameter("@startDate", 20, startDate, DbType.DateTime);
                var param2 = dataProvider.CreateParameter("@endDate", 20, endDate, DbType.DateTime);
                var param3 = dataProvider.CreateParameter("@memberId", 20, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param1, param2, param3);
                while (dataReader.Read())
                {
                    orders.Add(new OrdersObject
                    {
                        OrderId = dataReader.GetInt32(dataReader.GetOrdinal("OrderId")),
                        MemberId = dataReader.GetInt32(dataReader.GetOrdinal("MemberId")),
                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                        RequiredDate = dataReader.GetDateTime(dataReader.GetOrdinal("RequiredDate")),
                        ShippedDate = dataReader.GetDateTime(dataReader.GetOrdinal("ShippedDate")),
                        Freight = dataReader.GetDecimal(dataReader.GetOrdinal("Freight"))
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
            return orders;
        }
    }
}

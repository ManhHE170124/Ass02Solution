using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        public void DeleteOrder(int OrderId) => OrdersDAO.Instance.Remove(OrderId);

        public IEnumerable<OrdersObject> GetAllOrders() =>  OrdersDAO.Instance.GetOrdersList();

        public IEnumerable<OrdersObject> GetAllOrdersByMemberId(int memberId) => OrdersDAO.Instance.GetOrdersListByMemberId(memberId);

        public List<OrdersObject> GetOrderBySearch(DateTime startDate, DateTime endDate) => OrdersDAO.Instance.GetOrderBySearch(startDate, endDate);

        public List<OrdersObject> GetOrderBySearchAndId(int memberId, DateTime startDate, DateTime endDate) => OrdersDAO.Instance.GetOrderBySearchAndId(memberId, startDate, endDate);  

        public OrdersObject GetOrdersObject(int OrderId) => OrdersDAO.Instance.GetOrderByID(OrderId);

        public void InsertOrder(OrdersObject order) => OrdersDAO.Instance.AddNew(order);

        public void UpdateOrder(OrdersObject order) => OrdersDAO.Instance.Update(order);
    }
}

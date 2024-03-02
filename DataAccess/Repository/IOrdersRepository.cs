using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrdersRepository
    {
        IEnumerable<OrdersObject> GetAllOrders();
        OrdersObject GetOrdersObject(int OrderId);
        void InsertOrder(OrdersObject order);
        void DeleteOrder(int OrderId);
        void UpdateOrder(OrdersObject order);
        List<OrdersObject> GetOrderBySearch(DateTime startDate, DateTime endDate);
        IEnumerable<OrdersObject> GetAllOrdersByMemberId(int memberId);
        List<OrdersObject> GetOrderBySearchAndId(int memberId, DateTime startDate, DateTime endDate);
    }
}

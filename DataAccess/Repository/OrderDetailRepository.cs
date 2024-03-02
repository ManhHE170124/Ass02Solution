using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(int OrderId) => OrderDetailDAO.Instance.Remove(OrderId);

        public IEnumerable<OrderDetailObject> GetAllOrderDetail() => OrderDetailDAO.Instance.GetOrderDetailList();

        public OrderDetailObject GetOrderDetailObject(int OrderId) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderId);  

        public void InsertOrderDetail(OrderDetailObject orderdetail) => OrderDetailDAO.Instance.AddNew(orderdetail);

        public void UpdateOrderDetail(OrderDetailObject orderdetail) => OrderDetailDAO.Instance.Update(orderdetail);
    }
}

using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetAllOrderDetail();
        OrderDetailObject GetOrderDetailObject(int OrderId);
        void InsertOrderDetail(OrderDetailObject orderdetail);
        void DeleteOrderDetail(int OrderId);
        void UpdateOrderDetail(OrderDetailObject orderdetail);
    }
}

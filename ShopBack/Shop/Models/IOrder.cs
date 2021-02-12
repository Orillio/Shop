using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public interface IOrder
    {
        IQueryable<OrderModel> OrderModels { get; }
        void AddOrder(OrderModel order);
        void DeleteOrder(int orderId);
    }
}

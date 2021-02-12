using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OrderManager : IOrder
    {
        ProductContext context;
        public OrderManager(ProductContext context)
        {
            this.context = context;
        }

        public IQueryable<OrderModel> OrderModels => context.Orders.Include(x => x.Products);

        public void AddOrder(OrderModel order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
        public void DeleteOrder(int orderId)
        {
            var model = context.Orders.Include(x => x.Products).FirstOrDefault(x => x.Id == orderId);
            if (model == null) return;
            context.Orders.Remove(model);
            context.SaveChanges();
        }
    }
}

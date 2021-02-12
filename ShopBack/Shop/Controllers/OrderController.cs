using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System.Collections.Generic;
using System.Linq;
namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        Cart cart;
        IOrder orderManager;
        public OrderController(IOrder orderManager, Cart cart)
        {
            this.cart = cart;
            this.orderManager = orderManager;
        }
        public IActionResult NewOrder()
        {
            ViewData["cart"] = cart.ItemList;
            return View(new OrderModel());
        }
        [HttpPost]
        public IActionResult NewOrder(OrderModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["cart"] = cart.ItemList;
                return View(new OrderModel());
            }
            model.Products = new List<ProductStringified>(cart.ItemList.Select(x =>
                new ProductStringified { ProductName = x.Product.Name, ProductQuantity = x.Quantity }));
            orderManager.AddOrder(model);
            cart.Clear();
            return Redirect("/Order/Thanks");
        }
        public IActionResult Thanks()
        {
            return View();
        }
    }
}

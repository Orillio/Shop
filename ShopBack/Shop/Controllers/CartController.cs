using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        IProductRepository Repository { get; set; }
        Cart Cart { get; set; }
        public CartController(IProductRepository rep, Cart cartService)
        {
            Cart = cartService;
            Repository = rep;
        }
        public IActionResult AddToCart(int productId)
        {
            var product = Repository.Products.FirstOrDefault(x => productId == x.Id);
            if (product != null)
            {
                Cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", "Product", RouteData.Values);
        }
    }
}

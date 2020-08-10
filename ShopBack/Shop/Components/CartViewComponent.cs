using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Components
{
    public class CartViewComponent : ViewComponent
    {
        IProductRepository repository { get; set; }
        Cart cart { get; set; }
        public CartViewComponent(IProductRepository repository, Cart cart)
        {
            this.cart = cart;
            this.repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            ViewData["Cart"] = cart.ItemList;
            return View();
        }
    }
}

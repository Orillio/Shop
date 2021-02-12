using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult CartList()
        {
            return View(Cart);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using Shop.Models;
using Shop.Models.ViewModels;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository { get; set; }
        Cart cart { get; set; }
        private int pageSize = 6;
        public ProductController(IProductRepository repository, Cart cart)
        {
            this.cart = cart;
            this.repository = repository;
            ViewData["Cart"] = cart.ItemList;

        }
        public IActionResult Index(string category, int page = 1)
        {
            return View(new ProductsViewModel
            {
                Products = repository.Products
                            .Where(x => category == null || x.Category == category)
                            .Skip((page - 1) * pageSize)
                            .Take(pageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = 6,
                    TotalItems = repository.Products.Where(x => category == null || x.Category == category).Count()
                },
                CurrentCategory = category,
            });
        }
        [HttpGet]
        public IActionResult ProductPage(int productId)
        {
            return View(repository.Products.FirstOrDefault(x => x.Id == productId));
        }
        [HttpPost]
        public IActionResult AddItem(int productId, int productQuantity)
        {
            cart.AddItem(repository.Products.FirstOrDefault(x => x.Id == productId), productQuantity);
            return Accepted();
        }
        [HttpPost]
        public IActionResult SetItemQuantity(int productId, int productQuantity)
        {
            cart.SetItemQuantity(repository.Products.FirstOrDefault(x => x.Id == productId), productQuantity);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult DeleteItem(int productId)
        {
            cart.RemoveItem(productId);
            return Accepted();
        }
    }
}

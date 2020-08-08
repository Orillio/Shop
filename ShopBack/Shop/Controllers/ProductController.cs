using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Models;
using Shop.Models.ViewModels;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository Repository { get; set; }
        private int pageSize = 6;
        public ProductController(IProductRepository repository)
        {
            Repository = repository;
        }
        public IActionResult Index(string category, int page = 1)
        {
            return View(new ProductsViewModel
            {
                Products = Repository.Products
                            .Where(x => category == null || x.Category == category)
                            .Skip((page - 1) * pageSize)
                            .Take(pageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = 6,
                    TotalItems = Repository.Products.Where(x => category == null || x.Category == category).Count()
                },
                CurrentCategory = category
            });
        }
        public IActionResult ProductPage(int productId)
        {
            return View(Repository.Products.FirstOrDefault(x => x.Id == productId));
        }
    }
}

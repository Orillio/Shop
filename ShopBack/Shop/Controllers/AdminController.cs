using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Models.ViewModels;

namespace Shop.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IProductRepository repository;
        IWebHostEnvironment appEnvironment;
        IOrder orderManager;
        public AdminController(IProductRepository rep, IWebHostEnvironment appEnvironment, IOrder orderManager)
        {
            this.appEnvironment = appEnvironment;
            repository = rep;
            this.orderManager = orderManager;
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult ProductList(string scope)
        {
            return View(new AdminProductsViewModel
            { 
                FilteredProducts = repository.Products.Where(x => scope == null || x.Category.ToLower() == scope.ToLower()).ToList(),
                AllProducts = repository.Products.ToList(),
                CurrentScope = scope
            });
        }
        public IActionResult ProductView(int productId)
        {
            var p = repository.Products.FirstOrDefault(x => x.Id == productId);

            return View(new ProductModel
            {
                Id = p.Id,
                Name = p.Name,
                Category = p.Category,
                Discount = p.Discount,
                Price = p.Price,
                LongDescription = p.LongDescription,
                ShortDescription = p.ShortDescription,
                FileUrl = p.ImageUrl
            });
        }
        public IActionResult ProductEdit(int productId)
        {
            var p = repository.Products.FirstOrDefault(x => x.Id == productId);

            return View(new ProductModel
            {
                Id = p.Id, 
                Name = p.Name,
                Category = p.Category,
                Discount = p.Discount,
                Price = p.Price,
                LongDescription = p.LongDescription,
                ShortDescription = p.ShortDescription,
                FileUrl = p.ImageUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> ProductEdit(ProductModel model)
        {
            ModelState.Remove("File");
            if(!ModelState.IsValid) return View(model);
            await repository.EditProduct(model);
            TempData["Message"] = $"The product №{model.Id} has been updated.";
            return RedirectToAction("ProductList");

        }
        public IActionResult ProductDelete(int productId, string scope)
        {
            repository.DeleteProduct(productId);
            TempData["Message"] = $"The product №{productId} has been deleted.";
            return RedirectToAction("ProductList", new { scope });
        }
        public IActionResult NewProduct()
        {
            return View(new ProductModel());
        }
        [HttpPost]
        public async Task<IActionResult> NewProduct(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            await repository.AddProduct(model);
            TempData["Message"] = $"The new product has been created.";
            return RedirectToAction("ProductList");
        }
        public IActionResult OrderList()
        {
            return View(orderManager.OrderModels.ToList());
        }
        public IActionResult OrderView(int orderId)
        {
            return View(orderManager.OrderModels.FirstOrDefault(x => x.Id == orderId));
        }
        public IActionResult OrderDelete(int orderId)
        {
            orderManager.DeleteOrder(orderId);
            TempData["Message"] = $"Order #{orderId} has been deleted.";
            return RedirectToAction("OrderList");
        }
    }
}

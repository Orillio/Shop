using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class EFProductRepository : IProductRepository
    {
        ProductContext context;
        IWebHostEnvironment appEnvironment;
        public EFProductRepository(ProductContext product, IWebHostEnvironment appEnvironment)
        {
            this.appEnvironment = appEnvironment;
            context = product;
        }
        public IQueryable<Product> Products => context.Products;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Returns path to image</returns>
        private async Task<string> SaveProductImage(ProductModel model)
        {
            string path = $"img/{model.Category}/{model.File.FileName}";

            using (var fileStream = new FileStream(appEnvironment.WebRootPath + "\\" + path, FileMode.Create, FileAccess.ReadWrite))
            {
                await model.File.CopyToAsync(fileStream);
            }
            return path;
        }
        private void DeleteImage(string url)
        {
            File.Delete(appEnvironment.WebRootPath + "\\" + url);
        }
        public async Task AddProduct(ProductModel model)
        {
            var path = await SaveProductImage(model);
            var product = new Product()
            {
                ImageUrl = path,
                Category = model.Category,
                Discount = model.Discount ?? 0,
                LongDescription = model.LongDescription,
                Name = model.Name,
                Price = model.Price,
                ShortDescription = model.ShortDescription
            };
            context.Products.Add(product);
            context.SaveChanges();

        }

        public void DeleteProduct(int productId)
        {
            var p = context.Products.Find(productId);
            DeleteImage(p.ImageUrl);
            context.Products.Remove(p);
            context.SaveChanges();
        }

        public async Task EditProduct(ProductModel model)
        {
            var prod = context.Products.Find(model.Id);
            string url = null;
            if (model.File != null)
            {
                DeleteImage(model.FileUrl);
                url = await SaveProductImage(model);
            }
            prod.Name = model.Name;
            prod.Price = model.Price;
            prod.Category = model.Category;
            prod.Discount = model.Discount ?? 0;
            prod.ImageUrl = url ?? model.FileUrl;
            prod.LongDescription = model.LongDescription;
            prod.ShortDescription = model.ShortDescription;
            context.SaveChanges();
        }
    }
}

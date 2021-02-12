using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        Task AddProduct(ProductModel product);
        Task EditProduct(ProductModel product);
        void DeleteProduct(int productId);
    }
}

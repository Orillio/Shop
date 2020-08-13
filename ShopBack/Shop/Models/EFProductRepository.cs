using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class EFProductRepository : IProductRepository
    {
        ProductContext context;
        public EFProductRepository(ProductContext product)
        {
            context = product;
        }
        public IQueryable<Product> Products => context.Products;
    }
}

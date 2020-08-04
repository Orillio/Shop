using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Shop.Models;

namespace Shop.DataContext
{
    public class ProductContext : DbContext
    {
        public DbSet<Sofa> Sofas { get; set; }
        public ProductContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProductDb;Integrated Security=True");
        }
    }
}

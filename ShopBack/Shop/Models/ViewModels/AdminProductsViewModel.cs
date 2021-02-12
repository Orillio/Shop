using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.ViewModels
{
    public class AdminProductsViewModel
    {
        public List<Product> AllProducts { get; set; }
        public List<Product> FilteredProducts { get; set; }
        public string CurrentScope { get; set; }
    }
}

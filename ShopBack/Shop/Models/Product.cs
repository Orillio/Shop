using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Price { get; set; }
        public uint DiscountPrice => IsDiscount ? Price - (uint)(Price / 100.0 * Discount) : Price;
        public bool IsDiscount => Discount == default ? false : true;
        public int Discount { get; set; }
        public int MyProperty { get; set; }
        public string ImageUrl { get; set; }
    }
}

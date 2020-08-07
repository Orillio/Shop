using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Price { get; set; }
        public uint DiscountPrice
        {
            get
            {
                if (IsDiscount)
                {
                    var a = (Price - (uint)(Price / 100.0 * Discount)) / 100.0;
                    return (uint)Math.Round(a) * 100;
                }
                return Price;
            }
        }
        public bool IsDiscount => Discount != default;
        public int Discount { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public uint Price { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string LongDescription { get; set; }
        public bool IsDiscount => Discount != default;
        public int? Discount { get; set; }
        [Required]
        public IFormFile File { get; set; }
        public string FileUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите ФИО")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите Email")]
        [RegularExpression(@"^.+@.+\..+", ErrorMessage = "Введите корректный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Введите номер телефона")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Введите адрес доставки")]
        public string Address { get; set; }
        public string OrderComment { get; set; }

        public List<ProductStringified> Products { get; set; }
    }
}

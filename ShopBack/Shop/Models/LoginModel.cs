using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Введите логин")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [UIHint("password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

    }
}

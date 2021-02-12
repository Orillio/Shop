using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signinManager;
        public AccountController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            userManager = um;
            signinManager = sim;

        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl) => View(new LoginModel() { ReturnUrl = returnUrl });

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(model.Name);
                if(user != null)
                {
                    await signinManager.SignOutAsync();
                    if((await signinManager.PasswordSignInAsync(user, model.Password, false, false)).Succeeded)
                    {
                        return Redirect(model?.ReturnUrl ?? "/Admin/Index");
                    }
                }
            }
            if(model?.Name != null && model?.Password != null) ModelState.AddModelError("", "Неправильное имя или пароль");
            return View(model);
        }
        public async Task<IActionResult> LogOut()
        {
            await signinManager.SignOutAsync();
            return Redirect("/Product/Index");
        }
    }
}

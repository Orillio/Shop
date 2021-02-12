using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public static class IdentityData
    {
        private const string adminLogin = "admin";
        private const string adminPassword = "qwerty123";
        
        public static async void EnsureCreated(IApplicationBuilder app)
        {
            var userManager = app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByNameAsync(adminLogin);
            if(user == null)
            {
                user = new IdentityUser(adminLogin);
                await userManager.CreateAsync(user, adminPassword);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Models;

namespace Shop
{
    public class Startup
    {
        IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(services => services.EnableEndpointRouting = false)
                .AddSessionStateTempDataProvider()
                .AddSessionStateTempDataProvider();
            services.AddDbContext<IdentityContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:StoreIdentity:ConnectionString"]);
            });
            services.AddDbContext<ProductContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:StoreProducts:ConnectionString"]);
            });
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
            }).AddDefaultTokenProviders()
              .AddEntityFrameworkStores<IdentityContext>();

            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<IOrder, OrderManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(services => Cart.CartCreate(services));
            services.AddMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(1);
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseDeveloperExceptionPage();
            app.UseSession();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(null,
                    template: "admin",
                    defaults: new { controller = "Admin", action = "Home" });
                routes.MapRoute(null,
                    template: "{category:alpha}",
                    defaults: new { controller = "Product", action = "Index", page = 1 });
                routes.MapRoute(null,
                    template: "{category}/page{page}",
                    defaults: new { controller = "Product", action = "Index" });
                routes.MapRoute(null,
                    template: "page{page}",
                    defaults: new { controller = "Product", action = "Index" });
                routes.MapRoute(null,
                    template: "admin/products/{scope:alpha}",
                    defaults: new { controller = "Admin", action = "ProductList" });
                routes.MapRoute(null,
                    template: "admin/products",
                    defaults: new { controller = "Admin", action = "ProductList" });
                routes.MapRoute(null,
                    template: "admin/products/{productId:int}/edit",
                    defaults: new { controller = "Admin", action = "ProductEdit" });
                routes.MapRoute(null,
                    template: "admin/products/{productId:int}",
                    defaults: new { controller = "Admin", action = "ProductView" });
                routes.MapRoute(null,
                    template: "admin/products/{scope:alpha}/{productId}/delete",
                    defaults: new { controller = "Admin", action = "ProductDelete" });
                routes.MapRoute(null,
                    template: "admin/products/{productId}/delete",
                    defaults: new { controller = "Admin", action = "ProductDelete" });
                routes.MapRoute(null,
                    template: "product/{productId:int}",
                    defaults: new { controller = "Product", action = "ProductPage" });
                routes.MapRoute(null, "{controller=Product}/{action=Index}");
            });
            ProductData.EnsureCreated(app);
            IdentityData.EnsureCreated(app);
        }
    }
}

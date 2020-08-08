using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
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
            services.AddMvc(services => services.EnableEndpointRouting = false);
            services.AddDbContext<ProductContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:StoreProducts:ConnectionString"]);
            });
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(services => Cart.CartCreate(services));
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseDeveloperExceptionPage();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(null,
                    template: "{category:alpha}",
                    defaults: new { controller = "Product", action = "Index", page = 1 });
                routes.MapRoute(null,
                    template: "{category}/Page{page}",
                    defaults: new { controller = "Product", action = "Index" });
                routes.MapRoute(null,
                    template: "Page{page}",
                    defaults: new { controller = "Product", action = "Index"});
                routes.MapRoute(null, "{controller=Product}/{action=ProductPage}/{productId:int}");
                routes.MapRoute(null, "{controller=Product}/{action=Index}");
            });
            ProductData.EnsureCreated(app);
        }
    }
}

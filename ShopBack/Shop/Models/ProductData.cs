using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public static class ProductData
    {
        public static void EnsureCreated(IApplicationBuilder app)
        {
            ProductContext context = app.ApplicationServices.GetRequiredService<ProductContext>();

            context.Database.Migrate();
            //context.Products.Load();
            //context.Products.Local.Clear();
            //context.SaveChanges();
            if (!context.Products.AnyAsync().Result)
            {
                #region Sofas

                
                context.Products.AddRange(
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван Armstrong Union Jack от Andrew Martin.jpg",
                        Name = "Диван \"Armstrong Union Jack\" от Andrew Martin",
                        Price = 179000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 10,
                        ImageUrl = "img/sofaImg/Диван Rebel от Andrew Martin.jpg",
                        Name = "Диван \"Rebel\" от Andrew Martin",
                        Price = 210000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 13,
                        ImageUrl = "img/sofaImg/Диван Panama Sand от Eichholtz.jpg",
                        Name = "Диван \"Panama Sand\" от Eichholtz",
                        Price = 230000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван Bouton от Eichholtz.jpg",
                        Name = "Диван \"Bouton\" от Eichholtz",
                        Price = 159000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван FLY 2.jpg",
                        Name = "Диван \"FLY 2\"",
                        Price = 149000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 7,
                        ImageUrl = "img/sofaImg/Диван Marlborough от Eichholtz.jpg",
                        Name = "Диван \"Marlborough \" от Eichholtz",
                        Price = 150000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 4,
                        ImageUrl = "img/sofaImg/Диван Paolo от Eichholtz.jpg",
                        Name = "Диван \"Paolo\" от Eichholtz",
                        Price = 124000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван Astley.jpg",
                        Name = "Диван \"Astley\"",
                        Price = 59000
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 9,
                        ImageUrl = "img/sofaImg/Диван Astley.jpg",
                        Name = "Диван \"Copenhagen\"",
                        Price = 44900
                    }
                    );
                #endregion

                #region ArmChairs

                context.Products.AddRange(
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло FLY 1.jpg",
                        Name = "Кресло \"FLY 1\"",
                        Price = 84900
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Bouton от Eichholtz.jpg",
                        Name = "Кресло \"Bouton\" от Eichholtz",
                        Price = 77900
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Franco от Eichholtz.jpg",
                        Name = "Кресло \"Franco\" от Eichholtz",
                        Price = 72900
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = 4,
                        ImageUrl = "img/armchairImg/Кресло Cliveden от Eichholtz.jpg",
                        Name = "Кресло \"Cliveden\" от Eichholtz",
                        Price = 70000
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Hallandale от Eichholtz.jpg",
                        Name = "Кресло \"Hallandale\" от Eichholtz",
                        Price = 60900
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Paolo от Eichholtz.jpg",
                        Name = "Кресло \"Paolo\" от Eichholtz",
                        Price = 49000
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Dawson от Eichholtz.jpg",
                        Name = "Кресло \"Dawson\" от Eichholtz",
                        Price = 39000
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = 8,
                        ImageUrl = "img/armchairImg/Кресло Sloped.jpg",
                        Name = "Кресло \"Sloped\"",
                        Price = 38000
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Lisette.jpg",
                        Name = "Кресло \"Lisette\"",
                        Price = 32900
                    }
                    );
                #endregion

                #region Chairs

                context.Products.AddRange(
                    new Product
                    {
                        Category = "Chairs",
                        Discount = 12,
                        ImageUrl = "img/chairImg/Стул Pit.jpg",
                        Name = "Стул \"Pit\"",
                        Price = 53000
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = 5,
                        ImageUrl = "img/chairImg/Стул Nut.jpg",
                        Name = "Стул \"Nut\"",
                        Price = 55000
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Fan.jpg",
                        Name = "Стул \"Fan\"",
                        Price = 27900
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул NORR.jpg",
                        Name = "Стул \"NORR\"",
                        Price = 24900
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Langue.jpg",
                        Name = "Стул \"Langue\"",
                        Price = 10900
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Riviera.jpg",
                        Name = "Стул \"Riviera\"",
                        Price = 10900
                    }
                    );

                #endregion

                #region Tables

                context.Products.AddRange(

                    new Product
                    {
                        Category = "Tables",
                        Discount = 10,
                        ImageUrl = "img/tableImg/Стол Maison.jpg",
                        Name = "Стол \"Maison\"",
                        Price = 99900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 0,
                        ImageUrl = "img/tableImg/Стол Industrial.jpg",
                        Name = "Стол \"Industrial\"",
                        Price = 33900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = default,
                        ImageUrl = "img/tableImg/Стол Maison New Orlean.jpg",
                        Name = "Стол \"Maison New Orlean\"",
                        Price = 78900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = default,
                        ImageUrl = "img/tableImg/Стол Maison Redington.jpg",
                        Name = "Стол \"Maison Redington\"",
                        Price = 96900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 5,
                        ImageUrl = "img/tableImg/Стол Maison Riviera.jpg",
                        Name = "Стол \"Maison Riviera\"",
                        Price = 87900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Muuto.jpg",
                        Name = "Стол \"Muuto\"",
                        Price = 78900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Skagerak.jpg",
                        Name = "Стол \"Skagerak\"",
                        Price = 28900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Slab.jpg",
                        Name = "Стол \"Slab\"",
                        Price = 90900
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол XVL.jpg",
                        Name = "Стол \"XVL\"",
                        Price = 191900
                    }
                    );

                #endregion
            }
            context.SaveChanges();
        }
    }
}

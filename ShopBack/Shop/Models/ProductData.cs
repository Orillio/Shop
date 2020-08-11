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
            //context.Products.Include(e => e.Tags).Load();
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
                        Price = 179000,
                        ShortDescription = "Диван \"Armstrong Union Jack\" в винтажном стиле. Обивка из состаренной шоколадно-коричневой кожи с глубоким цветом.",
                        LongDescription = @"Прямые линии и формы этого дивана в сочетании с плиссированными деталями придют ему современный вид.
                                            Слияние современного и классического вида в производстве этого дивана, делает его идеальным, как для современного, так и классического интерьера.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        { 
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Глубина", TagName = "98" },
                            new ProductTag {CategoryName = "Ширина", TagName = "222" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "натуральная кожа" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "бронза" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 10,
                        ImageUrl = "img/sofaImg/Диван Rebel от Andrew Martin.jpg",
                        Name = "Диван \"Rebel\" от Andrew Martin",
                        Price = 210000,
                        ShortDescription = "Очень редко бывает такое, что одна деталь интерьера может рассказать о хозяина дома ВСЕ. Дизайнерский диван 'Rebel' от 'Andrew Martin' привносит в ваш дом непередаваемую атмосферу путешествий и приключений.",
                        LongDescription = @"Потрясающий элемент интерьера от Эндрю Мартина. Этот старинный диван в стиле 'Честерфилд' обит текстурной состаренной кожей, чтобы придать ему старинный и красивый внешний вид.
                                            Бронзовые заклепки вокруг подлокотников,
                                            четыре ряда пуговиц на спинке и красивый плиссированный элемент на подлокотниках,
                                            диван 'Rebel' от 'Andrew Martin' поставляется в комплекте с традиционными деревянными ножками на колесиках.
                                            Именно это слияние современного и традиционного подхода в производстве этого дивана делает его идеальным,
                                            как для современного,
                                            так и классического интерьера.
                                            Самобытная и уникальная конструкция дивана,
                                            вдохновлена духом истории и путешествий.Превратите ваш домашний интерьер в произведение искусства.",
                        Tags = new List<ProductTag>(new ProductTag[] 
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "80" },
                            new ProductTag {CategoryName = "Глубина", TagName = "100" },
                            new ProductTag {CategoryName = "Ширина", TagName = "220" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "натуральная кожа" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "бронза" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 13,
                        ImageUrl = "img/sofaImg/Диван Panama Sand от Eichholtz.jpg",
                        Name = "Диван \"Panama Sand\" от Eichholtz",
                        Price = 230000,
                        ShortDescription = "Великолепный диван в непринужденном стиле от дизайнерского бренда Eichholtz.",
                        LongDescription = @"Диван c прямыми линиями дизайна и тканевой обивкой в цвете песка с пляжей Панамы.
                                            Внизу диван обрамлен нержавеющей стальной оправой.Деревянные ножки пропитаны касторовым маслом для защиты поверхности.
                                            Элегантный диван станет идеальным дополнением к вашей гостиной.
                                            Диван также доступен в двух вариантах обивки.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "80" },
                            new ProductTag {CategoryName = "Глубина", TagName = "101" },
                            new ProductTag {CategoryName = "Ширина", TagName = "290" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "льняная ткань полиэстер" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван Bouton от Eichholtz.jpg",
                        Name = "Диван \"Bouton\" от Eichholtz",
                        Price = 159000,
                        ShortDescription = "Классический мягкий диван в бежевом цвете с бархатной обивкой.",
                        LongDescription = @"Элегантность в самом центре вашего домашнего интерьера.
                                            Черпая вдохновение из античной французской мебели,
                                            этот диван стал современным прочтением мебельной классики.
                                            Полностью мягкий и уютный бежевый диван с бархатной отделкой и зауженными ножками.В комлекте с удобными мягкими подушками.",
                        Tags = new List<ProductTag>(new ProductTag[] 
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "75" },
                            new ProductTag {CategoryName = "Глубина", TagName = "84" },
                            new ProductTag {CategoryName = "Ширина", TagName = "225" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "бархат" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван FLY 2.jpg",
                        Name = "Диван \"FLY 2\"",
                        Price = 149000,
                        ShortDescription = @"2-местный диван для гостиной, который располагает к комфортному отдыху.
                                            Идеален для комфортного отдыха: сидеть, лежать, прилечь и расслабиться.",
                        LongDescription = @"В отличие от многих диванов и мягких кресел в скандинавском стиле, 'FLY 2' не навязывает какой-либо конкретной позы для комфортного отдыха.
                                            Само сиденье оптимизировано для комфорта,
                                            с незакрепленными подушками для спины,
                                            которые можно разложить в соответствии с собственными потребностями.
                                            Однако диван 'FLY 2' не придерживается традиций в других отношениях,
                                            каркас дивана имеет реечные спинки,
                                            изготавливается из дуба,
                                            обработанного белым пигментированным маслом.
                                            Это тип материала – истинная благодать,
                                            и только хорошеет со временем.
                                            Каждое секция обита льняной и хлопковой тканью цвета песка с темно - серыми акцентами.
                                            Стиль дивана 'FLY 2' вдохновлен путешествиями за границу,
                                            их атмосферой и настроением.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "70" },
                            new ProductTag {CategoryName = "Глубина", TagName = "80" },
                            new ProductTag {CategoryName = "Ширина", TagName = "162" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "дубовый шпон" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 7,
                        ImageUrl = "img/sofaImg/Диван Marlborough от Eichholtz.jpg",
                        Name = "Диван \"Marlborough \" от Eichholtz",
                        Price = 150000,
                        ShortDescription = "Классический диван с натуральной льняной обивкой.",
                        LongDescription = @"Расслабьтесь на стильном диване 'Marlborough' от Eichholtz. Современный, но одновременно традиционный диван в тиле декаданс с современной эстетикой.
                                            В комплекте плиссированный чехол и удобные мягкие подушки.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "89" },
                            new ProductTag {CategoryName = "Глубина", TagName = "108" },
                            new ProductTag {CategoryName = "Ширина", TagName = "222" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "льняная ткань" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 4,
                        ImageUrl = "img/sofaImg/Диван Paolo от Eichholtz.jpg",
                        Name = "Диван \"Paolo\" от Eichholtz",
                        Price = 124000,
                        ShortDescription = "Черный диван с льняной обивкой от Eichholtz.",
                        LongDescription = @"Если добавить к классике немного гламура, то получиться этот стильный и элегантный диван для интерьера вашего дома.
                                            Каждый кусочек украшен яркой блестящей хромированной отделкой заклепками спереди и по бокам,
                                            и закончил с глубоким пуговицы и темной древесины с низкой посадкой ноги.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "72" },
                            new ProductTag {CategoryName = "Глубина", TagName = "85" },
                            new ProductTag {CategoryName = "Ширина", TagName = "230" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "льняная ткань" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = default,
                        ImageUrl = "img/sofaImg/Диван Astley.jpg",
                        Name = "Диван \"Astley\"",
                        Price = 59000,
                        ShortDescription = "Двухместный диван на колесах с серой льняной обивкой.",
                        LongDescription = @"Этот роскошный двухместный диван является прекрасным дополнением для классических и современных интерьеров.
                                            Обеспечивает идеальное место для семейного отдыха",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "80" },
                            new ProductTag {CategoryName = "Глубина", TagName = "89" },
                            new ProductTag {CategoryName = "Ширина", TagName = "170" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "Sofas",
                        Discount = 9,
                        ImageUrl = "img/sofaImg/Диван Astley.jpg",
                        Name = "Диван \"Copenhagen\"",
                        Price = 44900,
                        ShortDescription = "Мягкий, элегантный диван в стиле минимализм с деревянными ножками.",
                        LongDescription = @"Диван 'Copenhagen' – это современный компактный 2-спальный диван.
                                            Легко транспортируется.Выражение стиля скандинаский минимализм с современными характеристиками.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "80" },
                            new ProductTag {CategoryName = "Глубина", TagName = "89" },
                            new ProductTag {CategoryName = "Ширина", TagName = "170" },
                            new ProductTag {CategoryName = "Материал обивки", TagName = "ткань на основе натуральной шерсти" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "мореный бук" },
                        })
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
                        Price = 84900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Bouton от Eichholtz.jpg",
                        Name = "Кресло \"Bouton\" от Eichholtz",
                        Price = 77900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Franco от Eichholtz.jpg",
                        Name = "Кресло \"Franco\" от Eichholtz",
                        Price = 72900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = 4,
                        ImageUrl = "img/armchairImg/Кресло Cliveden от Eichholtz.jpg",
                        Name = "Кресло \"Cliveden\" от Eichholtz",
                        Price = 70000,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Hallandale от Eichholtz.jpg",
                        Name = "Кресло \"Hallandale\" от Eichholtz",
                        Price = 60900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Paolo от Eichholtz.jpg",
                        Name = "Кресло \"Paolo\" от Eichholtz",
                        Price = 49000,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Dawson от Eichholtz.jpg",
                        Name = "Кресло \"Dawson\" от Eichholtz",
                        Price = 39000,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = 8,
                        ImageUrl = "img/armchairImg/Кресло Sloped.jpg",
                        Name = "Кресло \"Sloped\"",
                        Price = 38000,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Lisette.jpg",
                        Name = "Кресло \"Lisette\"",
                        Price = 32900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
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
                        Price = 53000,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = 5,
                        ImageUrl = "img/chairImg/Стул Nut.jpg",
                        Name = "Стул \"Nut\"",
                        Price = 55000,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Fan.jpg",
                        Name = "Стул \"Fan\"",
                        Price = 27900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул NORR.jpg",
                        Name = "Стул \"NORR\"",
                        Price = 24900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Langue.jpg",
                        Name = "Стул \"Langue\"",
                        Price = 10900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Riviera.jpg",
                        Name = "Стул \"Riviera\"",
                        Price = 10900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
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
                        Price = 99900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 0,
                        ImageUrl = "img/tableImg/Стол Industrial.jpg",
                        Name = "Стол \"Industrial\"",
                        Price = 33900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = default,
                        ImageUrl = "img/tableImg/Стол Maison New Orlean.jpg",
                        Name = "Стол \"Maison New Orlean\"",
                        Price = 78900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = default,
                        ImageUrl = "img/tableImg/Стол Maison Redington.jpg",
                        Name = "Стол \"Maison Redington\"",
                        Price = 96900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 5,
                        ImageUrl = "img/tableImg/Стол Maison Riviera.jpg",
                        Name = "Стол \"Maison Riviera\"",
                        Price = 87900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Muuto.jpg",
                        Name = "Стол \"Muuto\"",
                        Price = 78900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Skagerak.jpg",
                        Name = "Стол \"Skagerak\"",
                        Price = 28900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Slab.jpg",
                        Name = "Стол \"Slab\"",
                        Price = 90900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол XVL.jpg",
                        Name = "Стол \"XVL\"",
                        Price = 191900,
                        ShortDescription = "",
                        LongDescription = "",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {

                        })
                    }
                    );

                #endregion
            }
            context.SaveChanges();
        }
    }
}

﻿using Microsoft.AspNetCore.Builder;
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
            context.Products.Include(e => e.Tags).Load();
            context.Products.Local.Clear();
            context.SaveChanges();
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
                            new ProductTag {CategoryName = "Материал", TagName = "натуральная кожа" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "натуральная кожа" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань полиэстер" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "бархат" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
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
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
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
                        ShortDescription = "'FLY 1' – это кресло, которое несет идею отдыха на полную катушку. Оно позволяет сидеть, лежать, отдохнуть и расслабиться.",
                        LongDescription = @"Комфортное кресло, с незакрепленными подушками для спины, которые можно использовать в соответствии с собственными потребностями.
                                            Однако конструкция 'FLY 1' не придерживается традиций в других отношениях, каркас кресла имеет реечные спинки и изготавливается из дуба, обработанного с белым пигментированным маслом.
                                            Это тип материала, только хорошеет со временем.
                                            Каждое кресло обито льняной и хлопчатобумажной тканью цвета песка или темно - серого.
                                            Стиль кресла вдохновенен путешествиями за границу,
                                            их атмосферой и настроением.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "70" },
                            new ProductTag {CategoryName = "Глубина", TagName = "80" },
                            new ProductTag {CategoryName = "Ширина", TagName = "87" },
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "дубовый шпон" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Bouton от Eichholtz.jpg",
                        Name = "Кресло \"Bouton\" от Eichholtz",
                        Price = 77900,
                        ShortDescription = "Классическое мягкое кресло с обивкой из бежевого бархата.",
                        LongDescription = @"Кресло 'Bouton' от Eichholtz будет самым сердцем вашего дизайна интерьера.
                                            Вдохновляясь очарованием антикварной французской мебели,
                                            стиль кресла был обновлен для современного интерьера с кубическим сиденьем и контрастной изогнутой винтажной рамой.
                                            Полностью мягкое кресло с прохладной отделкой из бежевого бархата и удобная квадратная подушка в комплекте.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "76" },
                            new ProductTag {CategoryName = "Глубина", TagName = "77" },
                            new ProductTag {CategoryName = "Ширина", TagName = "97" },
                            new ProductTag {CategoryName = "Материал", TagName = "серый бархат" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Franco от Eichholtz.jpg",
                        Name = "Кресло \"Franco\" от Eichholtz",
                        Price = 72900,
                        ShortDescription = "Современное мягкое дизайнерское кресло с эффектными металлическими подлокотниками.",
                        LongDescription = @"Кресло 'Franco' от Eichholtz в стиле непринужденной роскоши, которое подходит для всех типов интерьера.
                                            Большие L - образные полированные подлокотники из нержавеющей стали прекрасно компенсируются сложным цветом ткани обивки.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "85" },
                            new ProductTag {CategoryName = "Глубина", TagName = "85" },
                            new ProductTag {CategoryName = "Ширина", TagName = "84" },
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "нержавеющая сталь" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = 4,
                        ImageUrl = "img/armchairImg/Кресло Cliveden от Eichholtz.jpg",
                        Name = "Кресло \"Cliveden\" от Eichholtz",
                        Price = 70000,
                        ShortDescription = "Кресло 'Cliveden' добавит последние штрихи к вашему стилю.",
                        LongDescription = @"Гармоничный баланс пропорций и стиля, элегантная эстетика – это роскошное кресло является отличным средством как для классических, так и современных схем дизайна интерьера.
                                            С кривыми подлокотниками и натуральной тканевой обивкой, в комплекте с поворотным основанием, кресло будет идеальным дополнением к вашей жилой площади.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "85" },
                            new ProductTag {CategoryName = "Глубина", TagName = "85" },
                            new ProductTag {CategoryName = "Ширина", TagName = "84" },
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "дубовый шпон" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Hallandale от Eichholtz.jpg",
                        Name = "Кресло \"Hallandale\" от Eichholtz",
                        Price = 60900,
                        ShortDescription = "Современное кресло в форме куба с выбором расцветки.",
                        LongDescription = @"Добавьте последний штрих в ваш интерьер с креслом 'Hallandale' от Eichholtz.
                                            Дизайнерская ривлекательность этого роскошного кресла из коллекции Eichholtz представлена выбором однотонного льна,
                                            сочетающего оттенки бежевого и песочного цвета,
                                            для легкого летного штриха в интерьере вашей гостинной.
                                            Сделано на совесть.Прочная,
                                            износостойкая рама из сосны и березы.Мягкая подушка для сиденья и спинки,
                                            придают непревзойденный комфорт в этом дизайнерском кресле.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "86" },
                            new ProductTag {CategoryName = "Глубина", TagName = "86" },
                            new ProductTag {CategoryName = "Ширина", TagName = "86" },
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "береза" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Paolo от Eichholtz.jpg",
                        Name = "Кресло \"Paolo\" от Eichholtz",
                        Price = 49000,
                        ShortDescription = "Классическое обитое льном кресло от Eichholtz.",
                        LongDescription = @"Это традиционное кресло отлично смотрится при размещении напротив дивана или используется как отдельный элемент интерьера.
                                            Стильная мебель, которая одинаково хорошо смотриться как в современном, так и классическом интерьере.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "73" },
                            new ProductTag {CategoryName = "Глубина", TagName = "86" },
                            new ProductTag {CategoryName = "Ширина", TagName = "86" },
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Dawson от Eichholtz.jpg",
                        Name = "Кресло \"Dawson\" от Eichholtz",
                        Price = 39000,
                        ShortDescription = "Классическое мягкое кресло с перекрещенными металлическим основанием.",
                        LongDescription = @"Кресло 'Dawson' от Eichholtz создано в стиле современная роскошь, который подходит для всех типов интерьера и прекрасно выглядит рядом с диванами или как кресло для чтения.
                                            Современное отполированное основание из нержавеющей стали,
                                            дополняет естественную ткань обивки.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "74" },
                            new ProductTag {CategoryName = "Глубина", TagName = "86" },
                            new ProductTag {CategoryName = "Ширина", TagName = "68" },
                            new ProductTag {CategoryName = "Материал", TagName = "льняная ткань" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = 8,
                        ImageUrl = "img/armchairImg/Кресло Sloped.jpg",
                        Name = "Кресло \"Sloped\"",
                        Price = 38000,
                        ShortDescription = "Кресло из эвкалиптового дерева с дубовыми ножками и мягкой обивкой.",
                        LongDescription = @"Роскошное кресло с льняной отделкой. Естественная эстетика будет чудесно дополнять существующий домашний декор.
                                            Пуховый наполнитель, обеспечивает ощущение мягкости и комфорта. А дубовые ножки придают креслу дорогой вид",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "74" },
                            new ProductTag {CategoryName = "Глубина", TagName = "86" },
                            new ProductTag {CategoryName = "Ширина", TagName = "68" },
                            new ProductTag {CategoryName = "Материал", TagName = "хлопок" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "береза" },
                        })
                    },
                    new Product
                    {
                        Category = "ArmChairs",
                        Discount = default,
                        ImageUrl = "img/armchairImg/Кресло Lisette.jpg",
                        Name = "Кресло \"Lisette\"",
                        Price = 32900,
                        ShortDescription = "Кресло с обивкой из натурального льна и дубовыми ножками.",
                        LongDescription = @"Роскошный уют в ваш доме с креслом 'Lisette'.
                                            Вдохновленное классикой,
                                            это уютное роскошное кресло было создано для современной жизни.Нейтральные и спокойные оттенки обивки.
                                            Мягкая кресло с удобным валиком для ног,
                                            изогнутые подлокотники и изогнутая спинка и все это на дубовых ножках.
                                            Кресло украшено кнопками по периметру.Внутренняя часть кресла создает мягкий кокон,
                                            чтобы расслабиться и отдохнуть.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "84" },
                            new ProductTag {CategoryName = "Глубина", TagName = "85" },
                            new ProductTag {CategoryName = "Ширина", TagName = "79" },
                            new ProductTag {CategoryName = "Материал", TagName = "хлопок" },
                            new ProductTag {CategoryName = "Материал фурнитуры", TagName = "береза" },
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
                        ShortDescription = "Современный минималистский мягкий стул с деревянными ножками.",
                        LongDescription = @"Сказочный современный минималистский дизайн, и новый шедевр нашей конструкторской группы
                                            Идеальное соединение дизайна и мастерства, в четании с экологичностью.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "49" },
                            new ProductTag {CategoryName = "Глубина", TagName = "52" },
                            new ProductTag {CategoryName = "Ширина", TagName = "76" },
                            new ProductTag {CategoryName = "Материал", TagName = "натуральная кожа" },
                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = 5,
                        ImageUrl = "img/chairImg/Стул Nut.jpg",
                        Name = "Стул \"Nut\"",
                        Price = 55000,
                        ShortDescription = "Стул из натурального дуба с мягким сиденьем",
                        LongDescription = @"Изящный стул 'Nut' из натурального светлого дуба отлично впишется в любой интерьер.
                                            Данный стул станет идеальным дополнением к стильным интересным дизайнерским решениям.Мягкий дубовый шпон для корпуса корпус с удобно изогнутой спинкой и массивные дубовые ножки.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "49" },
                            new ProductTag {CategoryName = "Глубина", TagName = "52" },
                            new ProductTag {CategoryName = "Ширина", TagName = "76" },
                            new ProductTag {CategoryName = "Материал", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Fan.jpg",
                        Name = "Стул \"Fan\"",
                        Price = 27900,
                        ShortDescription = "Великолепный деревянный стул круглой формы.",
                        LongDescription = @"Оригинальный круглый стул 'Fan' станет отличным дополнением к интерьеру веранды или летней кухни.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Глубина", TagName = "53" },
                            new ProductTag {CategoryName = "Ширина", TagName = "53" },
                            new ProductTag {CategoryName = "Материал", TagName = "натуральное дерево" },
                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул NORR.jpg",
                        Name = "Стул \"NORR\"",
                        Price = 24900,
                        ShortDescription = "Стул 'NORR' из твердого дуба и кожаной обивкой сидений.",
                        LongDescription = @"Современный вариант классического деревянного стула с улучшенной эргономикой
                                            Высокое качество изготовления, с использованием традиционных столярных техник. Этот дизайнерский стул идеально подходит для вашего современного домашнего интерьера.
                                            С идеально подогнанным дизайном, каждое кресло изготовлено из натурального дуба. Сиденье обтянуто телячьей кожей.
                                            Доступен в палитре натуральных и окрашенных цветовых оттенков, удобная конструкция с кожаной обивкой сиденья.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Глубина", TagName = "50" },
                            new ProductTag {CategoryName = "Ширина", TagName = "47" },
                            new ProductTag {CategoryName = "Материал", TagName = "массив дуба" },
                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Langue.jpg",
                        Name = "Стул \"Langue\"",
                        Price = 10900,
                        ShortDescription = "Минималистичный стул из натурального бука с пластиковым сиденьем.",
                        LongDescription = @"Простая эстетика дизайна вместе с классическими материалами. Стул будет идеальным дополнением для классических и современных интерьеров.
                                            Гармонично сочетающий в себе комфорт и стиль, функциональный дизайнерский обеденный стул с пластмассовым сидением.
                                            Представленные на выбор цветовые оттенки легко дополнят существующую стиль обеденной зоны. Сочетание дерева и гладкого пластика создает необычайный дизайн, который обязательно будет предметом зависти ваших взыскательных гостей.
                                            Создан с точностью и пристальным вниманием к деталям",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Глубина", TagName = "51" },
                            new ProductTag {CategoryName = "Ширина", TagName = "50" },
                            new ProductTag {CategoryName = "Материал", TagName = "пластик" },
                        })
                    },
                    new Product
                    {
                        Category = "Chairs",
                        Discount = default,
                        ImageUrl = "img/chairImg/Стул Riviera.jpg",
                        Name = "Стул \"Riviera\"",
                        Price = 10900,
                        ShortDescription = "Стул с плетением на спинке.",
                        LongDescription = @"В дизайне этого стула воплощена элегантность парижских бистро.
                                            Классический старинный элемент – спинка с крестообразным плетением, материал каркаса – натуральный дуб медового цвета. Данный стул беспечивает оптимальный комфорт и отлично подойдет для вашей столовой или кухни.
                                            Тканевое сиденье завершает эстетику и приглашаете гостей дольше оставаться за столом",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "88" },
                            new ProductTag {CategoryName = "Глубина", TagName = "52" },
                            new ProductTag {CategoryName = "Ширина", TagName = "49" },
                            new ProductTag {CategoryName = "Материал", TagName = "дуб" },
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
                        ShortDescription = "Сильные резкие линии этого стола придают ему очень агрессивный вид.",
                        LongDescription = @"Используйте стол 'Maison' как стильный роскошный письменный стол или туалетный столик.
                                            Каждый стол имеет металлические бронзовые ручки для выдвижных ящиков и поразительно контрастное металлическое основание.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Глубина", TagName = "61" },
                            new ProductTag {CategoryName = "Ширина", TagName = "120" },
                            new ProductTag {CategoryName = "Материал", TagName = "дуб" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 0,
                        ImageUrl = "img/tableImg/Стол Industrial.jpg",
                        Name = "Стол \"Industrial\"",
                        Price = 33900,
                        ShortDescription = "Брутальный стол в стиле 'Индастриал' с металлическим основанием и клеенной столешницей из нескольких видов древесины.",
                        LongDescription = @"'Вещи не должны быть обычными', таким правилом мы руководствовались при создании стола 'Industrial'.
                                            Этот стол будет прекрасным дополнением офиса или кабинета в вашем доме.Стол с характером,
                                            но изысканный,
                                            этот предмет будет визуально увеличить комнату и дополнять остальные аксессуары в интерьере.
                                            Сочетайте рабочий стол 'Industrial' с другими предметами из 'Industrial' - коллекции нашего магазина для получения по - настоящему роскошного интерьера дома,
                                            которым Вы сможете гордиться.
                                            Каждое изделие из этой коллекции производится из переработанной мореной древесины,
                                            что делает их все уникальными предметами из 'Индастриал' - коллекции нашего магазина.
                                            Оригинальное сочетание цветов и текстур делают этот предмет ярким дополнением современного интерьера,
                                            в то время как стальной акцент поддерживает мужественность в интерьере.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Глубина", TagName = "70" },
                            new ProductTag {CategoryName = "Ширина", TagName = "120" },
                            new ProductTag {CategoryName = "Материал", TagName = "дуб" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = default,
                        ImageUrl = "img/tableImg/Стол Maison New Orlean.jpg",
                        Name = "Стол \"Maison New Orlean\"",
                        Price = 78900,
                        ShortDescription = "Классический письменный стол из дерева австралийской акации с антикварной краской.",
                        LongDescription = @"Создайте идеальный фон, вдохновляющий на исследования, с рабочим столом 'Maison Riviera'.
                                            Красивый силуэт ручного изготовления делает этот стол уникальным и роскошным с шикарной старинной белой краской.
                                            Сделано на совесть, для изготовления используется массив австралийской акации.
                                            Ящики открываются наружу. каждая дверь шкафчика с эстетичными жалюзи в стиле колонизаторов.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Ширина", TagName = "120" },
                            new ProductTag {CategoryName = "Длина", TagName = "150" },
                            new ProductTag {CategoryName = "Материал", TagName = "акация" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = default,
                        ImageUrl = "img/tableImg/Стол Maison Redington.jpg",
                        Name = "Стол \"Maison Redington\"",
                        Price = 96900,
                        ShortDescription = "Классический письменный стол из массива вяза с античным белым окрашенным каркасом.",
                        LongDescription = @"Классический письменный стол 'Maison Redington' изготовлен из массива вяза с античным окрашенным каркасом.
                                            Вдохновленные красотой натурального дерева,
                                            этот импозантный письменный стол оформлен в загородном стиле.Столешница выполнена из древесины вяза.Каркас окрашен белой винтажной краской и искуственно состарен.
                                            Два выдвижных ящика обеспечивают достаточно места для хранения.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Ширина", TagName = "75" },
                            new ProductTag {CategoryName = "Длина", TagName = "160" },
                            new ProductTag {CategoryName = "Материал", TagName = "ламинированная фанера" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 5,
                        ImageUrl = "img/tableImg/Стол Maison Riviera.jpg",
                        Name = "Стол \"Maison Riviera\"",
                        Price = 87900,
                        ShortDescription = "Классический письменный стол из дерева австралийской акации с антикварной краской.",
                        LongDescription = @"Создайте идеальный фон, вдохновляющий на исследования, с рабочим столом 'Maison Riviera'.
                                            Красивый силуэт ручного изготовления делает этот стол уникальным и роскошным с шикарной старинной белой краской.
                                            Сделано на совесть, изготовления используется массив австралийской акации, с акцентами манговой древесины на двух красивых ящиках для хранения.
                                            Ящики открываются наружу, каждая дверь шкафчика с эстетичными жалюзи в стиле колонизаторов.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "78" },
                            new ProductTag {CategoryName = "Ширина", TagName = "80" },
                            new ProductTag {CategoryName = "Длина", TagName = "150" },
                            new ProductTag {CategoryName = "Материал", TagName = "акация" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Muuto.jpg",
                        Name = "Стол \"Muuto\"",
                        Price = 78900,
                        ShortDescription = "Прямоугольный стол с квадратными алюминиевыми ножками.",
                        LongDescription = @"Скандинавская простота в стиле – это стол 'Muuto'.
                                            Разработанный  профессиональным архитектором,
                                            исключительно для нашего магазина стол 'Muuto' обладает тонким исполнением с ярким архитектурным обликом.
                                            В основании – два литых алюминиевых белых квадрата,
                                            каждый квадрат 70х70 см.
                                            Стол создан с тщательным вниманием к деталям,
                                            прямоугольная столешница выполнена из фанеры с ламинированной поверхностью.
                                            В этом столе реализована непринужденная простота скандинавского стиля,
                                            'Muuto' вдохновлен эстетикой и минимализмом в дизайне и тщательно продуманной отделкой.
                                            Стиль этого стола – естественное дополнение для вашей обеденной зоны,
                                            открытой планировки или офисного помещения,
                                            отлично сочетается с креслами и стульями в современном стиле.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "73" },
                            new ProductTag {CategoryName = "Ширина", TagName = "90" },
                            new ProductTag {CategoryName = "Длина", TagName = "225" },
                            new ProductTag {CategoryName = "Материал", TagName = "алюминий" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Skagerak.jpg",
                        Name = "Стол \"Skagerak\"",
                        Price = 28900,
                        ShortDescription = "Угловой дубовый стол-консоль 'Skagerak'.",
                        LongDescription = @"Улучшить и обогатить интерьер вашего дома с помощью стола 'Skagerak' от датского бренда.
                                            'Skagerak' – это современный,
                                            крутой,
                                            скандинавский предмет интерьера.
                                            Специально разработан для стены вашей прихожей или гостиной,
                                            прекрасный дубовый каркас,
                                            который доступен в нескольких цветах,
                                            является простым по форме и прекрасно дополняется двумя яркими угловыми ножками.
                                            Стол усиливает концепцию упрощенного скандинавского дизайна и создает отсылку к природе.Это идеальное сочетание делает стол - консоль 'Skagerak' идеально подходящим для вневременного стиля в любом интерьере или экстерьере.
                                            Изготовлен из высококачественного сырья,
                                            это прекрасная коллекция будет вводить практичный и экологически чистый городской стиль.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "75" },
                            new ProductTag {CategoryName = "Ширина", TagName = "32" },
                            new ProductTag {CategoryName = "Длина", TagName = "90" },
                            new ProductTag {CategoryName = "Материал", TagName = "дуб" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол Slab.jpg",
                        Name = "Стол \"Slab\"",
                        Price = 90900,
                        ShortDescription = "Дубовый стол с косыми ножками и отверстием для кабеля от Тома Диксона.",
                        LongDescription = @"Стол изготовлен из массива дуба, это делает его иконой британского дизайна. Современный письменный стол с отличием.
                                            В элегантной и утонченной пропорции, эта роскошная рабочая станция отражает викторианский стиль в его чистом виде.
                                            Стол ручной работы, гладкая особенная конструкця из древесины дуба с мягко закругленными краями и сочетанием прямых и косых угловых оснований.
                                            Отверстие для кабеля с глубоко обработанной канавкой идеально подходит для хранения ручек и настольных аксессуаров.
                                            Предназначен для дополнения современных гостиных.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "75" },
                            new ProductTag {CategoryName = "Ширина", TagName = "60" },
                            new ProductTag {CategoryName = "Длина", TagName = "120" },
                            new ProductTag {CategoryName = "Материал", TagName = "дуб" },
                        })
                    },
                    new Product
                    {
                        Category = "Tables",
                        Discount = 12,
                        ImageUrl = "img/tableImg/Стол XVL.jpg",
                        Name = "Стол \"XVL\"",
                        Price = 191900,
                        ShortDescription = "Стол 'XVL' – это элемент, который отлично смотрится в любой комнате.",
                        LongDescription = @"Мультифункциональный дизайн, он может быть как обеденным столом или современным письменным столом с вневременным дизайном.
                                            Стол изготовлен из высококачественных материалов с высоким качеством отделки. Каждый стол опирается на элегантное основание, придавая ему современный штрих и визуальной легкости.
                                            Изготовлен из шпона дуба с эбонитовыми вставками.",
                        Tags = new List<ProductTag>(new ProductTag[]
                        {
                            new ProductTag {CategoryName = "Высота", TagName = "75" },
                            new ProductTag {CategoryName = "Ширина", TagName = "110" },
                            new ProductTag {CategoryName = "Длина", TagName = "225" },
                            new ProductTag {CategoryName = "Материал", TagName = "дуб" },
                        })
                    }
                    );

                #endregion
            }
            context.SaveChanges();
        }
    }
}

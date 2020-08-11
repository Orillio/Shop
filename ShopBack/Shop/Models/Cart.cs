using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Cart
    {
        public static Cart CartCreate(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            Cart cart = session.GetCart<Cart>() ?? new Cart();
            cart.session = session;
            return cart;
        }
        private ISession session { get; set; }
        public List<CartItem> ItemList { get; set; } = new List<CartItem>();
        public void AddItem(Product product, int quantity)
        {
            var prod = ItemList.FirstOrDefault(x => x.Product.Id == product.Id);
            if (prod == null)
            {
                ItemList.Add(new CartItem { Product = product, Quantity = quantity});
            }
            else
            {
                prod.Quantity += quantity;
            }
            session.SetCart(this);
        }
        public void RemoveItem(int productId)
        {
            ItemList.Remove(ItemList.FirstOrDefault(x => x.Product.Id == productId));
            session.SetCart(this);
        }
        public void SetItemQuantity(Product product, int quantity)
        {
            var cartItem = ItemList.FirstOrDefault(x => x.Product.Id == product.Id);
            if (cartItem == null) return;

            cartItem.Quantity = quantity;
            session.SetCart(this);
        }
        public decimal CalculateTotal() =>
            ItemList.Sum(x => x.Product.IsDiscount ? x.Product.DiscountPrice : x.Product.Price * x.Quantity);
        public void Clear()
        {
            ItemList.Clear();
            session.Remove("Cart");
        }
    }
}

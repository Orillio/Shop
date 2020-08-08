using Microsoft.AspNetCore.Http;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace Shop.Infrastructure
{
    public static class SessionExtensions
    {
        public static T GetCart<T>(this ISession session)
        {
            var cart = session.GetString("Cart");
            if (cart == null) return default;
            return JsonConvert.DeserializeObject<T>(cart);
        }
        public static void SetCart(this ISession session, Cart cart)
        {
            session.SetString("Cart", JsonConvert.SerializeObject(cart));
        }
    }
}

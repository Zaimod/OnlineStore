using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectApp.Models
{
    public class ShopCart
    {
        [Key]
        public int id { get; set; }
        public string ShopCartId { get; set; }

        private readonly Context context;

        public ShopCart(Context context)
        {
            this.context = context;
        }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<Context>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Goods goods)
        {
            context.shopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Goods = goods,
                price = goods.price
            });
            context.SaveChanges();
        }
        public List<ShopCartItem> GetShopItems()
        {
            return context.shopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Goods).ToList();
        }
    }
}

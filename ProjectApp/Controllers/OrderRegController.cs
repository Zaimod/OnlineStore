using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.Repository.UnitOfWork;

namespace ProjectApp.Controllers
{
    public class OrderRegController : Controller
    {
        private readonly IOrderRegister orders;
        private readonly ShopCart shopCart;
        private readonly UnitOfWork_MyCabinet myCabinet = null;
        
        
        public OrderRegController(IOrderRegister orders, ShopCart shopCart, Context context)
        {
            this.orders = orders;
            this.shopCart = shopCart;
            myCabinet = new UnitOfWork_MyCabinet(context);
        }
        //[HttpPost]
        public IActionResult Index(OrderDetailRegister order)
        {
            shopCart.listShopItems = shopCart.GetShopItems();
            var items = shopCart.listShopItems;
            OrderDetailRegister order1 = null;
            if (ModelState.IsValid)
            {
                User user = myCabinet.Cabinet.GetUser(User.Identity.Name);
                
                foreach (var item in items)
                {
                    order1 = new OrderDetailRegister()
                    {
                        address = "test",
                        price = item.Goods.price,
                        GoodsID = item.Goods.id,
                        UserID = user.id,
                        orderTime = DateTime.Now
                    };
                    orders.createOrder(order1);
                }
                

               
            }

            return View(order);
        }

     
    }
}
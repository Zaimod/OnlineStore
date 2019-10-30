using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;

namespace ProjectApp.Controllers
{
    public class OrderNoRegisterController : Controller
    {
        private readonly IOrders orders;
        private readonly ShopCart shopCart;

        public OrderNoRegisterController(IOrders orders, ShopCart shopCart)
        {
            this.orders = orders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(OrderNoRegister order)
        {
            shopCart.listShopItems = shopCart.GetShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "Корзина порожня!");    
            }

            if (ModelState.IsValid)
            {
                orders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ здійснений";
            return View();
        }
    }
}
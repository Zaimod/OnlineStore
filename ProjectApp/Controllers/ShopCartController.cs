using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.ViewsModels;

namespace ProjectApp.Controllers
{
    [Authorize]
    public class ShopCartController : Controller
    {
        private readonly IGoods goodsRepository;
        private readonly ShopCart shopCart;
        ShopCartViewModel obj;
        public ShopCartController(IGoods goodsRepository, ShopCart shopCart)
        {
            this.shopCart = shopCart;
            this.goodsRepository = goodsRepository;
        }
        public IActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                var items = shopCart.GetShopItems();
                shopCart.listShopItems = items;

                double Price = 0;
                foreach (var item in shopCart.listShopItems)
                {
                    Price += item.price;
                }
                obj = new ShopCartViewModel 
                { 
                    shopCart = shopCart,
                    Price = Price
                };

                return View(obj);
            }
            return null;
        }
        public IActionResult test()
        {
            return View();
        }

        public IActionResult addToCart(int id)
        {
            var item = goodsRepository.GetGoods.FirstOrDefault(i => i.id == id);

            if (item != null)
                shopCart.AddToCart(item);
            return RedirectToAction("Index", "Goods/List/{category}");
        }

    }
}
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

                var obj = new ShopCartViewModel { shopCart = shopCart };

                return View(obj);
            }
            return null;
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = goodsRepository.GetGoods.FirstOrDefault(i => i.id == id);

            if (item != null)
                shopCart.AddToCart(item);
            return RedirectToAction("Index");
        }
    }
}
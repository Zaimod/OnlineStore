using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;
using ProjectApp.Interfaces;
using ProjectApp.ViewsModels;

namespace ProjectApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGoods goodsRepository;
        //private readonly ShopCart shopCart;

        public HomeController(IGoods goodsRepository)
        {
            //this.shopCart = shopCart;
            this.goodsRepository = goodsRepository;
        }

        public IActionResult Index()
        {
            var homegoods = new HomeViewModel { favGoods = goodsRepository.GetFavGoods };
            
            return View(homegoods);
        }
       /* public HomeController(IGoods goods, ICategory category)
        {
            this.goods = goods;
            this.category = category;
        }


        public IActionResult Index()
        {
            ViewBag.Title = "Товари";
            GoodsListViewModel obj = new GoodsListViewModel();
            obj.AllGoods = goods.GetGoods;
            obj.currCategory = "відюхи";
            return View("~/Views/Home/Index.cshtml", obj);
        }*/
    }
    
}

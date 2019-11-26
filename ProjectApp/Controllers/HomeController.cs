using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;
using ProjectApp.Interfaces;
using ProjectApp.ViewsModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
        [Route("Home/Top")]
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            ViewBag.Message = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            ViewBag.Title = "Головна";
            var homegoods = new HomeViewModel { favGoods = goodsRepository.GetFavGoods };

            return View(homegoods);
        }
        /* 
        [Authorize(Roles = "admin")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }*/
    }
    
}

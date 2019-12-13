using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.Repository.UnitOfWork;
using ProjectApp.ViewsModels;
namespace ProjectApp.Controllers
{
    public class MyCabinetController : Controller
    {
        UnitOfWork_MyCabinet MyCabinet;
        ShopCart shopCart;
        Context context;
        MyCabinetViewModel objMyCabinet = null;
        public MyCabinetController(Context context, IGoods goodsRepository, ShopCart shopCart)
        {
            this.context = context;           
            this.shopCart = shopCart;
            MyCabinet = new UnitOfWork_MyCabinet(context);
            //this.goodsRepository = goodsRepository;
        }
        public IActionResult Index(string del = "0")
        {
            double sumPriceOrder = 0;
            var items = shopCart.GetShopItems();
            shopCart.listShopItems = items;
            double Price = 0;
            foreach (var item in shopCart.listShopItems)
            {
                Price += item.price;
            }

            List<OrderDetailRegister> ordersQuantity = context.orderDetailRegisters.Where(i => i.User.email == User.Identity.Name).ToList();
            foreach (var item in ordersQuantity)
            {
                sumPriceOrder += item.price;
            }
            User user = MyCabinet.Cabinet.GetUser(User.Identity.Name);
            IQueryable<Goods> goods = context.Goods;
            objMyCabinet = new MyCabinetViewModel() {
                user = user,
                ShopCarts = shopCart,
                Price = Price,
                quantityOrders = ordersQuantity.Count(),
                SumPriceOders = sumPriceOrder,
                OrderDetailRegisters = ordersQuantity.AsQueryable(),
                Goods = goods
            };
            if (del == "1")
            {
                shopCart.listShopItems.Clear();
                objMyCabinet.ShopCarts.listShopItems.Clear();
                objMyCabinet.Price = 0;
            }
            return View(objMyCabinet);
        }


        [HttpPost]
        public async Task<IActionResult> ChangeAccount(MyCabinetViewModel model)
        {
            if (model != null)
            {
                User user = context.Users.Where(i => i.email == User.Identity.Name).FirstOrDefault();
                user = new User
                {
                    first_name = model.first_name,
                    last_name = model.last_name,
                    email = model.email,
                    phone = model.phone
                };
                await context.SaveChangesAsync();
            }
            
            return View(model);
        }


        public IActionResult WishList(string del = "0")
        {
            double sumPriceOrder = 0;
            var items = shopCart.GetShopItems();
            shopCart.listShopItems = items;
            double Price = 0;
            foreach (var item in shopCart.listShopItems)
            {
                Price += item.price;
            }

            List<OrderDetailRegister> ordersQuantity = context.orderDetailRegisters.Where(i => i.User.email == User.Identity.Name).ToList();
            foreach (var item in ordersQuantity)
            {
                sumPriceOrder += item.price;
            }
            User user = MyCabinet.Cabinet.GetUser(User.Identity.Name);
            IQueryable<Goods> goods = context.Goods;
            objMyCabinet = new MyCabinetViewModel()
            {
                user = user,
                ShopCarts = shopCart,
                Price = Price,
                quantityOrders = ordersQuantity.Count(),
                SumPriceOders = sumPriceOrder,
                OrderDetailRegisters = ordersQuantity.AsQueryable(),
                Goods = goods
            };
            if (del == "1")
            {
                shopCart.listShopItems.Clear();
                objMyCabinet.ShopCarts.listShopItems.Clear();
                objMyCabinet.Price = 0;
            }
            return View(objMyCabinet);
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var shopCartItem = await context.shopCartItems.FindAsync(id);
 
            if (shopCartItem != null)
            {
                context.shopCartItems.Remove(shopCartItem);
                await context.SaveChangesAsync();
                 
            }

            return RedirectToPage("Index");
        }


    }
}
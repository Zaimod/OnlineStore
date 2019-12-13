using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.Repository.UnitOfWork;
using ProjectApp.ViewsModels;

namespace ProjectApp.Controllers
{
    public class AccountSetController : Controller
    {
        UnitOfWork_MyCabinet MyCabinet;
        ShopCart shopCart;
        Context context;
        MyCabinetViewModel objMyCabinet = null;
        public AccountSetController(Context context, IGoods goodsRepository, ShopCart shopCart)
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
            ViewBag.Suka = user.id;
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

        public IActionResult AddressSet(string del = "0")
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
            AddressUser addressUsers = context.addressUsers.Where(i => i.user_id == user.id).ToList().FirstOrDefault();
           
            IQueryable<Goods> goods = context.Goods;
            objMyCabinet = new MyCabinetViewModel()
            {
                user = user,
                ShopCarts = shopCart,
                Price = Price,
                quantityOrders = ordersQuantity.Count(),
                SumPriceOders = sumPriceOrder,
                OrderDetailRegisters = ordersQuantity.AsQueryable(),
                Goods = goods,
                AddressUser = addressUsers
                
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
                user.first_name = model.first_name;
                user.last_name = model.last_name;
                user.phone = model.phone;
                if(model.password != null)
                    user.password = model.password;
                
                await context.SaveChangesAsync();
                return RedirectToAction("Index", "AccountSet");
            }

            return RedirectToAction("Index", "Goods/List");
        }

        [HttpPost]
        public async Task<IActionResult> Address(MyCabinetViewModel model)
        {
            User user = context.Users.Where(i => i.email == User.Identity.Name).FirstOrDefault();
            AddressUser addressUser = context.addressUsers.Where(i => i.user_id == user.id).FirstOrDefault();
            if (model != null)
            {
                
                addressUser.City = model.city;
                addressUser.ZiP = model.zip;
                addressUser.Address1 = model.address1;
                addressUser.Adrress2 = model.address2;


                await context.SaveChangesAsync();
                return RedirectToAction("AddressSet", "AccountSet");
            }

            return RedirectToAction("Index", "Goods/List");
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
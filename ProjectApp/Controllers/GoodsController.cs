using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.Repository.UnitOfWork;
using ProjectApp.ViewsModels;
 

namespace ProjectApp.Controllers
{
    public class GoodsController : Controller
    {
      
        UnitOfWork unitOfWork;
        
        public GoodsController(Context context)
        {
            unitOfWork = new UnitOfWork(context);
        }

        [Route("Goods/List")]
        [Route("Goods/List/{category}")]
        public IActionResult Index(string category, string sort)
        {

            IQueryable<Goods> goods = unitOfWork.Goods.GetGoods1;

            if (string.IsNullOrEmpty(category))
            {
                goods = unitOfWork.Goods.GetGoods1;
            }
            else
            {
                if (string.Equals("Відеокарти", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = unitOfWork.Goods.GetGoods1.Where(i => i.Category.id == 2);

                }
                if (string.Equals("Процесори", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = unitOfWork.Goods.GetGoods1.Where(i => i.Category.id == 3);
                }

                if(sort != null)
                    Sort(goods, sort);
            }


            var goodsObj = new GoodsListViewModel
            {
                AllGoods = goods,
                categories = category
            };

            if (category == "Процесори")
                ViewBag.Title = "Процесори";
            else if (category == "Відеокарти")
                ViewBag.Title = "Відеокарти";
            else
                ViewBag.Title = "Головна";

            //ViewData["PriceSort"] = sort;

            return View(goodsObj);
        }
        private IQueryable<Goods> Sort(IQueryable<Goods> goods, string sort)
        {

            if (sort == "priceUp")
                goods = goods.OrderBy(i => i.price);
            else if (sort == "priceDown")
                goods = goods.OrderByDescending(i => i.price);
            else
                goods = goods.OrderBy(i => i.id);

            return goods;
        }
    }
}
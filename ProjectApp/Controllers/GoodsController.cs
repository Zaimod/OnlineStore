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
using PagedList.Mvc;
using PagedList;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public async Task<IActionResult> Index(string category, string sort,  string name, int? categories1, double price_min = 1, double price_max = 100000, int page = 1)
        {
            int pageSize = 3;

            IQueryable<Goods> goods = unitOfWork.Goods.GetGoods1.Include(i => i.Category);

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

            if (categories1 != null && categories1 != 0)
            {
                goods = goods.Where(p => p.id_category == categories1);
            }
            if (!String.IsNullOrEmpty(name))
            {
                goods = goods.Where(p => p.name.Contains(name));
            }

            goods = goods.Where(i => i.price >= price_min && i.price <= price_max);

            List<Category> categories = unitOfWork.Category.GetCategories.ToList();
            categories.Insert(0, new Category { Name = "Все", id = 0});

            //IEnumerable<Goods> goods1 = unitOfWork.Goods.GetGoods.ToList().Where(i => i.price >= price_min && i.price <= price_max);
            
            var count = await goods.CountAsync();
            var items = await goods.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            var goodsObj = new GoodsListViewModel
            {
                AllGoods = items.AsQueryable(),
                categories = category,
                PageViewModel = pageViewModel,
                Name = name,
                categories1 = new SelectList(categories, "id", "Name"),
                cat = categories1,
                price_min = price_min,
                price_max = price_max
                
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
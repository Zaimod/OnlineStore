﻿using System;
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
    public class GoodsController : Controller
    {
        private readonly IGoods goods;
        private readonly ICategory category;
        
        public GoodsController(IGoods goods, ICategory category)
        {
            this.goods = goods;
            this.category = category;
        }

        [Route("Goods/List")]
        [Route("Goods/List/{category}")]
        public IActionResult Index(string category, string sort)
        {
            string _category = category;
            IEnumerable<Goods> goods = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                if (sort == "priceUP")
                    goods = this.goods.GetGoods.OrderBy(i => i.price);
                else if (sort == "priceDown")
                    goods = this.goods.GetGoods.OrderByDescending(i => i.price);
                else
                    goods = this.goods.GetGoods.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Відеокарти", category, StringComparison.OrdinalIgnoreCase))
                {
                    if (sort == "priceUP")
                        goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Відеокарти")).OrderBy(i => i.price);
                    else if (sort == "priceDown")
                        goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Відеокарти")).OrderByDescending(i => i.price);
                    else
                        goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Відеокарти")).OrderBy(i => i.id);
                }
                if (string.Equals("Процесори", category, StringComparison.OrdinalIgnoreCase))
                {
                    if (sort == "priceUP")
                        goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Процесори")).OrderBy(i => i.price);
                    else if (sort == "priceDown")
                        goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Процесори")).OrderByDescending(i => i.price);
                    else
                        goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Процесори")).OrderBy(i => i.id);
                }
                
                currCategory = category;
            }


            var goodsObj = new GoodsListViewModel
            {
                AllGoods = goods,
                categories = currCategory
            };

            if (currCategory == "Процесори")
                ViewBag.Title = "Процесори";
            else if (currCategory == "Відеокарти")
                ViewBag.Title = "Відеокарти";
            else
                ViewBag.Title = "Головна";

            ViewData["PriceSort"] = sort;

            return View(goodsObj);
        }
    }
}
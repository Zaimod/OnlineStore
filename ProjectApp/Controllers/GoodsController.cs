using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Index(string category)
        {
            string _category = category;
            IEnumerable<Goods> goods = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
                goods = this.goods.GetGoods.OrderBy(i => i.id);
            else
            {
                if (string.Equals("Процесори", category, StringComparison.OrdinalIgnoreCase))
                    goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Процесори")).OrderBy(i => i.id);
                else if (string.Equals("Відеокарти", category, StringComparison.OrdinalIgnoreCase))
                    goods = this.goods.GetGoods.Where(i => i.Category.Name.Equals("Відеокарти")).OrderBy(i => i.id);

                currCategory = category;             
            }

            var goodsObj = new GoodsListViewModel
            {
                AllGoods = goods,
                categories = currCategory
            };

            return View(goodsObj);
        }
    }
}
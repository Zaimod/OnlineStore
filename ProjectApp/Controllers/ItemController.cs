using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.ViewsModels;

namespace ProjectApp.Controllers
{
    public class ItemController : Controller
    {
        //private readonly IGoods goods;
        string category = null;
        private IGoods goods;
        private IDescription description;
         //private Context goods1;
        public ItemController(IGoods goods, IDescription description)
        {
            this.goods = goods;
            this.description = description;
        }
        [Route("Item")]
        [Route("Item/{name}")]
        public IActionResult Index(string name)
        {
            IEnumerable<Goods> goodsObj = null;
            goodsObj = goods.GetGoods.Where(i => i.name == name);

            Goods obj = goodsObj.FirstOrDefault();

            var ItemObj = new ItemView
            {
                item = obj,
                Items = goodsObj
            };

            if (obj.Category.Name == "Процесори")
                category = "Процесор";
            else if (obj.Category.Name == "Відеокарти")
                category = "Відеокарта";
            ViewBag.Category1 = category;
            ViewBag.Title1 = obj.Category.Name + "|" + obj.name.Replace(" ", string.Empty);

            if (obj.isAvailable == true)
                ViewBag.isAvailable = "В наявності";
            else
                ViewBag.isAvailable = "Немає в наявності";
            
            ViewBag.Desc = description.description(obj.id).desc.ToString();
            ViewBag.Maker = description.fullDescription_Video(1).Maker.ToString();
            return View(ItemObj);
        }
        
    }
}
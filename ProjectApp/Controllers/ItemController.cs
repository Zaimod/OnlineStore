using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using ProjectApp.Repository.UnitOfWork;
using ProjectApp.ViewsModels;

namespace ProjectApp.Controllers
{
    public class ItemController : Controller
    {
        UnitOfWork_Item UnitOfWork;
        public ItemController(Context context)
        {
            UnitOfWork = new UnitOfWork_Item(context);
        }
        [Route("Item")]
        [Route("Item/{name}")]
        public IActionResult Index(string name)
        {
            IEnumerable<Goods> goodsObj = null;
            FullDescription_Video description_Videos = null;
            Description description = null;

            goodsObj = UnitOfWork.Goods.GetGoods.Where(i => i.name == name);
            description_Videos = UnitOfWork.Description.fullDescription_Video(goodsObj.FirstOrDefault().id);
            description = UnitOfWork.Description.description(goodsObj.FirstOrDefault().id);

            var ItemObj = new ItemView
            {
                item = goodsObj.FirstOrDefault(),
                video_desk = description_Videos,
                description = description
            };
            
            if (goodsObj.FirstOrDefault().Category.id == 2)
                ViewBag.Category1 = goodsObj.FirstOrDefault().Category.Name;
            else if (goodsObj.FirstOrDefault().Category.id == 3)
                ViewBag.Category1 = goodsObj.FirstOrDefault().Category.Name;

            ViewBag.Title1 = goodsObj.FirstOrDefault().Category.Name + "|" + goodsObj.FirstOrDefault().name.Replace(" ", string.Empty);            
            return View(ItemObj);
        }
        
    }
}
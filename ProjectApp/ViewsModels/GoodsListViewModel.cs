using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.ViewsModels
{
    public class GoodsListViewModel
    {
        public IQueryable<Goods> AllGoods { get; set; }

        public string categories { get; set; }

        public PageViewModel PageViewModel { get; set; }

        public double price_min { get; set; }
        public double price_max { get; set; }

        public SelectList categories1 { get; set; }
        public int? cat { get; set; }

        public string Name { get; set; }
    }
}

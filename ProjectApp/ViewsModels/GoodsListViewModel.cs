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
    }
}

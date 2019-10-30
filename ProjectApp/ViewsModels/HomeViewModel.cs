using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.ViewsModels
{
    public class HomeViewModel
    {
        public IEnumerable<Goods> favGoods { get; set; }
    }
}

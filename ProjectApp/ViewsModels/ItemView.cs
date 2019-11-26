using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;

namespace ProjectApp.ViewsModels
{
    public class ItemView
    {
        public Goods item { get; set; }
        public IEnumerable<Goods> Items { get; set; }

        public string desccccc { get; set; }
        public Description description { get; set; }
    }
}

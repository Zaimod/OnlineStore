using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class Description
    {
        public int id { get; set; }

        public int id_goods { get; set; }
        public Goods Goods { get; set; }

        public string desc { get; set; }
    }
}

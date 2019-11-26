using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.DAL.Entities
{
    public class ShopCartItem
    {
        [Key]
        public int id { get; set; }
        public Goods Goods { get; set; }
        public double price { get; set; }

        public string ShopCartId { get; set; }
    }
}

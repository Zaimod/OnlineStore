using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class OrderDetail
    {
        [Key]
        public int id { get; set; }
        public int OrderID { get; set; }
        public int GoodsID { get; set; }
        public double price { get; set; }
        public virtual Goods goods { get; set; }
        public virtual OrderNoRegister Order { get; set; }
    }
}

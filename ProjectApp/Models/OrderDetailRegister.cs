using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class OrderDetailRegister
    {
        [Key]
        public int id { get; set; }
        public int UserID { get; set; }
        public int GoodsID { get; set; }
        public double price { get; set; }
        public DateTime orderTime { get; set; }
        public string address { get; set; }

        public virtual User User { get; set; }
        public virtual Goods Goods { get; set; }
    }
}

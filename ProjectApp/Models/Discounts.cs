using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class Discounts
    {
        [Key]
        public int id { get; set; }
        public int id_goods { get; set; }
        

        public DateTime expires_disck { get; set; }
        public double value { get; set; }

        public Goods Goods { get; set; }
    }
}

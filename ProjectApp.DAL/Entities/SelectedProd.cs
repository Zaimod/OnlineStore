using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.DAL.Entities
{
    public class SelectedProd
    {
        [Key]
        public int id { get; set; }

        public int id_user { get; set; }
        public User User { get; set; }

        public int id_goods { get; set; }
        public Goods Goods { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class GoodsPhotos
    {
        [Key]
        public int id { get; set; }

        public string img { get; set; }

        public int id_goods { get; set; }

        public List<Goods> Goods { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class AllDescript
    {
        [Key]
        public int id { get; set; }     

        public int id_goods { get; set; }
        public Goods Goods { get; set; }
        [Required]
        public int id_longDesc { get; set; }
        public longDesc longDesc { get; set; }
        [Required]
        public int id_shortDesc { get; set; }
        public shortDesc shortDesc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        public int id_photo { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }
        public List<Goods> Goods { get; set;  }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class CategoryPhoto
    {
        [Key]
        public int id { get; set; }
        public string img { get; set; }

        public List<Category> Categories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class Goods
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }   
        [Required]
        public double price { get; set; }
        [Required]
        public bool isFavourite { get; set; }
        [Required]
        public bool isAvailable { get; set; }

        public List<Comments> UsersComment { get; set; }
        public List<SelectedProd> selectedProds { get; set; }

        public int id_allDesc { get; set; }
        public AllDescript AllDescript { get; set; }

        public int id_category { get; set;  }
        public Category Category { get; set; }

        public int id_discount { get; set; }
        public Discounts Discounts { get; set; }

        public int id_img { get; set; }
        public GoodsPhotos GoodsPhotos { get; set; }

        public string img { get; set; }
    }
}

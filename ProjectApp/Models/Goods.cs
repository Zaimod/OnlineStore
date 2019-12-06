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

        public List<AllDescript> AllDescript { get; set; }
        public Description Descriptions { get; set; }
        public FullDescription_Video FullDescription_video { get; set; }
        public int id_category { get; set;  }
        public Category Category { get; set; }

        public List<Discounts> Discounts { get; set; }

        public int id_img { get; set; }
        public List<GoodsPhotos> GoodsPhotos { get; set; }
        public OrderDetailRegister OrderDetailRegister { get; set; }
        public string img { get; set; }
    }
}

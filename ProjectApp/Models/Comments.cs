using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class Comments
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string comment { get; set; }
        [Required]
        public DateTime datetime { get; set; }

        public int id_user { get; set; }
        public User User { get; set; }
        public int id_goods { get; set; }
        public Goods Goods { get; set; }
    }
}

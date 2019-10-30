using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class longDesc
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string description { get; set; }

        public List<AllDescript> allDescripts { get; set; }
    }
}

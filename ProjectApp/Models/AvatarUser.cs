using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class AvatarUser
    {
        [Key]
        public int id { get; set; }
        public string image { get; set; }

        public int user_id { get; set; }
        public User User { get; set; }
    }
}

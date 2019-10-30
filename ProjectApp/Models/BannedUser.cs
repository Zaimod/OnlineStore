using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class BannedUser
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int user_id { get; set; }
        public User User { get; set; }
        [Required]
        public string reason_ban { get; set; }
        [Required]
        public DateTime expires_ban { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace ProjectApp.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }      
        public int? RoleId { get; set; }

        public DateTime RegisterTime { get; set; }
        public Role role { get; set; }

        public AvatarUser avatar { get; set; }

        public BannedUser bannedUser { get; set; }

        public List<Comments> Comments { get; set; }
        public List<SelectedProd> selectedProds { get; set; }
        
        public List<OrderDetailRegister> orderDetailsRegisters { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.ViewsModels
{
    public class RegisterModel
    {   [Required]
        [Display(Name = "Ім'я")]
        public string first_name { get; set; }

        [Required]
        [Display(Name = "Прізвище")]
        public string last_name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефон")]
        public string phone { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Паролі не співпадають")]
        [Display(Name ="Підтвердіть пароль")]
        public string ConfirmPassword { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.ViewsModels
{
    public class RegisterModel
    {
        /*[Required(ErrorMessage = "Вкажіть прізвище")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Вкажіть ім'я")]
        public string Last_name { get; set; }

        [Required(ErrorMessage = "Вкажіть телефон")]
        public string Phone { get; set; }
        */
        [Required(ErrorMessage = "Вкажіть Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Вкажіть пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Пароль не вірний")]
        public string ConfirmPassword { get; set; }
    }
}

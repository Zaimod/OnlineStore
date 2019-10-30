using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.ViewsModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не вказане ім'я")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Не вказане прізвище")]
        public string last_name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Не вказаний телефон")]
        public string phone { get; set; }

        /*[DataType(DataType.Date)]
        [Required(ErrorMessage = "Не вказана дата народження")]
        public DateTime dateOfBithday { get; set; }
        */
        [Required(ErrorMessage = "Не вказаний Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Не вказаний пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Пароль не вірний")]
        public string ConfirmPassword { get; set; }


    }
}

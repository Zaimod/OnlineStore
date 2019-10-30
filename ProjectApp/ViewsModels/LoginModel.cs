using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.ViewsModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Вкажіть Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Вкажіть пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}

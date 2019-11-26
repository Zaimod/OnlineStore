using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.DAL.Entities
{
    public class OrderNoRegister
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введіть ім'я")]
        [StringLength(25)]
        [MinLength(1)]
        [Required(ErrorMessage = "Порожнє поле")]
        public string first_name { get; set; }

        [Display(Name = "Введіть Прізвище")]
        [StringLength(25)]
        [MinLength(1)]
        [Required(ErrorMessage = "Порожнє поле")]
        public string last_name { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(50)]
        [MinLength(1)]
        [Required(ErrorMessage = "Порожнє поле")]
        public string address { get; set; }

        [Display(Name = "Введіть номер телефону")]
        [StringLength(20)]
        [MinLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Не менше 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Введіть email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [MinLength(15)]
        [Required(ErrorMessage = "Не менше 15 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}

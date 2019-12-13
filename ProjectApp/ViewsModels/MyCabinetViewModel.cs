using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProjectApp.Models;
namespace ProjectApp.ViewsModels
{
    public class MyCabinetViewModel
    {
        public User user { get; set; }
         
        public ShopCart ShopCarts { get; set; }
        public double Price { get; set; }

        public int quantityOrders { get; set; }

        public double SumPriceOders { get; set; }

        public IQueryable<OrderDetailRegister> OrderDetailRegisters { get; set; }

        public IQueryable<Goods> Goods { get; set; }

        public AddressUser AddressUser { get; set; }






        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Паролі не співпадають")]
        public string ConfirmPassword { get; set; }


        public string city { get; set; }

        public int zip { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }
    }
}

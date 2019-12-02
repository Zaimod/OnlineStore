using System;
using System.Collections.Generic;
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
    }
}

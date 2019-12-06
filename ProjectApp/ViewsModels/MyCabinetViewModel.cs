﻿using System;
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

        public int quantityOrders { get; set; }

        public double SumPriceOders { get; set; }

        public IQueryable<OrderDetailRegister> OrderDetailRegisters { get; set; }

        public IQueryable<Goods> Goods { get; set; }







        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }
    }
}

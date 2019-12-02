using ProjectApp.Interfaces;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository
{
    public class OrderRegisterRepository : IOrderRegister
    {
        private readonly Context context;

        public OrderRegisterRepository(Context context)
        {
            this.context = context;
        }
        public void createOrder(OrderDetailRegister orderDetailRegister)
        {
            context.orderDetailRegisters.Add(orderDetailRegister);
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;
namespace ProjectApp.Interfaces
{
    public interface IOrderRegister
    {
        void createOrder(OrderDetailRegister orderDetailRegister);
    }
}

using ProjectApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.DAL.Interfaces
{
    public interface IOrders
    {
        void createOrder(OrderNoRegister orderNoRegister);

    }
}

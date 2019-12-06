using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class StatusOrder
    {
        public int id { get; set; }

        public int id_orderDetail { get; set; }

        public OrderDetailRegister OrderDetailRegister { get; set; }

        public string Status { get; set; }
        
    }
}

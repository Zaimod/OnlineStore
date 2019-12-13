using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class AddressUser
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public User User { get; set; }

        public string City { get; set; }

        public int ZiP { get; set; }

        public string Address1 { get; set; }

        public string Adrress2 { get; set; }
    }
}

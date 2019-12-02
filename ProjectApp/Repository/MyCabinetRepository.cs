using ProjectApp.Interfaces;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository
{
    public class MyCabinetRepository : IMyCabinet
    {
        private readonly Context context;
        public MyCabinetRepository(Context context)
        {
            this.context = context;
        }

        public User GetUser(string email) => context.Users.FirstOrDefault(i => i.email == email);
    }
}

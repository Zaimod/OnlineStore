using ProjectApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository
{
    public class DescriptionRepository : IDescription
    {
        private readonly Context context;

        public DescriptionRepository(Context context)
        {
            this.context = context;
        }
        public Description description(int idGoods) => context.Descriptions.FirstOrDefault(i => i.id_goods == idGoods);
        public FullDescription_Video fullDescription_Video(int idGoods) => context.FullDescription_Video.FirstOrDefault(i => i.id_goods == idGoods);
    }
}

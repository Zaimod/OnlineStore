using Microsoft.EntityFrameworkCore;
using ProjectApp.Interfaces;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository
{
    public class GoodsRepository : IGoods
    {
        private readonly Context context;
        public GoodsRepository(Context context)
        {
            this.context = context;
        }

        public IEnumerable<Goods> GetGoods => context.Goods.Include(i => i.Category);

        public IEnumerable<Goods> GetFavGoods => context.Goods.Where(p => p.isFavourite).Include(i => i.Category);

        //public IEnumerable<Goods> GetGoods => context.Goods.Include((System.Linq.Expressions.Expression<Func<Goods, Category>>)(i => i.Category));
        //public IEnumerable<Goods> GetFavGoods => context.Goods.Where(p => p.isFavourite).Include((System.Linq.Expressions.Expression<Func<Goods, Category>>)(i => (Category)i.Category));

        public Goods GetObjectGoods(int item) => context.Goods.FirstOrDefault(p => p.id == item);
    }
}

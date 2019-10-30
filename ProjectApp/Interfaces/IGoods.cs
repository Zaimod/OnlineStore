using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Interfaces
{
    public interface IGoods
    {
        IEnumerable<Goods> GetGoods { get; }
        IEnumerable<Goods> GetFavGoods { get; }
        Goods GetObjectGoods(int item);
    }
}

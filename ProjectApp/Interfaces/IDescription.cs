using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;
namespace ProjectApp.Interfaces
{
    public interface IDescription
    {
        Description description(int idGoods);
        FullDescription_Video fullDescription_Video(int idGoods);
    }
}

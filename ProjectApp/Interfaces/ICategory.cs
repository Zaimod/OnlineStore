using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}

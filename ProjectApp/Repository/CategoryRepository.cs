using ProjectApp.Interfaces;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly Context context;
        public CategoryRepository(Context context)
        {
            this.context = context;
        }
        public IEnumerable<Category> GetCategories => context.Categories;
    }
}

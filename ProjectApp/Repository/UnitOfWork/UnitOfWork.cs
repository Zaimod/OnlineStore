using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;
using ProjectApp.Repository;

namespace ProjectApp.Repository.UnitOfWork
{
    class UnitOfWork : IDisposable
    {
        private readonly Context context;
        private GoodsRepository GoodsRepository;
        private CategoryRepository CategoryRepository;

        
        public UnitOfWork(Context context)
        {
            this.context = context;
        }
        public GoodsRepository Goods
        {
            get
            {
                if (GoodsRepository == null)
                    GoodsRepository = new GoodsRepository(context);
                return GoodsRepository;
            }
        }
        public CategoryRepository Category
        {
            get
            {
                if (CategoryRepository == null)
                    CategoryRepository = new CategoryRepository(context);
                return CategoryRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

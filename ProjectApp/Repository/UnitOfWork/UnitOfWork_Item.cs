using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository.UnitOfWork
{
    public class UnitOfWork_Item : IDisposable
    {
        GoodsRepository GoodsRepository;
        DescriptionRepository DescriptionRepository;
        private readonly Context context;
        public UnitOfWork_Item(Context context)
        {
            this.context = context;
        }

        public DescriptionRepository Description
        {
            get
            {
                if (DescriptionRepository == null)
                    DescriptionRepository = new DescriptionRepository(context);
                return DescriptionRepository;
            }
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

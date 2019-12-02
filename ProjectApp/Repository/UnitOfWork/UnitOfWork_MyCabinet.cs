using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApp.Models;
namespace ProjectApp.Repository.UnitOfWork
{
    public class UnitOfWork_MyCabinet : IDisposable
    {
        private readonly Context context;
        MyCabinetRepository MyCabinetRep;
        ShopCart ShopCart;
        public UnitOfWork_MyCabinet(Context context)
        {
            this.context = context;
        }
        public MyCabinetRepository Cabinet
        {
            get
            {
                if (MyCabinetRep == null)
                    MyCabinetRep = new MyCabinetRepository(context);
                return MyCabinetRep;
            }
        }
        public ShopCart shopcart
        {
            get
            {
                if (ShopCart == null)
                    ShopCart = new ShopCart(context);
                return ShopCart;
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

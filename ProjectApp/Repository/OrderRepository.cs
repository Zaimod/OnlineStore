using ProjectApp.Interfaces;
using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Repository
{
    public class OrderRepository : IOrders
    {
        private readonly Context context;
        private readonly ShopCart shopCart;

        public OrderRepository(Context context, ShopCart shopCart)
        {
            this.context = context;
            this.shopCart = shopCart;
        }

        public void createOrder(OrderNoRegister orderNoRegister)
        {
            orderNoRegister.orderTime = DateTime.Now;
            context.orderNoRegisters.Add(orderNoRegister);

            var items = shopCart.listShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    GoodsID = item.Goods.id,
                    OrderID = orderNoRegister.id,
                    price = item.Goods.price
                };
                context.orderDetails.Add(orderDetail);
            }
            context.SaveChanges();
        }
    }
}

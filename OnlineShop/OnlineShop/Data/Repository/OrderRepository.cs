using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly Cart cart;

        public OrderRepository(AppDBContent appDBContent, Cart cart)
        {
            this.appDBContent = appDBContent;
            this.cart = cart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Orders.Add(order);

            var items = cart.listItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    productID = el.product.id,
                    orderID = order.id,
                    price = el.product.price
                };

                appDBContent.OrderDetails.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}

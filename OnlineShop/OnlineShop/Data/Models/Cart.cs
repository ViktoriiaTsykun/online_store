using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class Cart
    {
        private readonly AppDBContent appDBContent;

        public Cart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string id { get; set; }

        public List<CartItem> listItems { get; set; }

        public static Cart getCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new Cart(context) { id = cartId };
        }

        public void AddToCart(Product product)
        {
            this.appDBContent.CartItems.Add(new CartItem
            {
                CartId = id,
                product = product,
                price = product.price
            });

            appDBContent.SaveChanges();
        }

        public List<CartItem> getCartItems()
        {
            return appDBContent.CartItems.Where(c => c.CartId == id).Include(s => s.product).ToList();
        }
    }
}

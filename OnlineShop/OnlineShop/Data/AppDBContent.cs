using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>()
                .HasMany<Product>(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.categoryID);

            builder.Entity<Manufacturer>()
                .HasMany<Product>(manufacturer => manufacturer.Products)
                .WithOne(product => product.Manufacturer)
                .HasForeignKey(product => product.manufacturerID);

            builder.Entity<Cart>()
                .HasMany<CartItem>(cart => cart.listItems)
                .WithOne(cartItem => cartItem.Cart)
                .HasForeignKey(cartItem => cartItem.CartId);

            builder.Entity<Order>()
                .HasMany<OrderDetail>(order => order.orderDetails)
                .WithOne(orderDetail => orderDetail.order)
                .HasForeignKey(orderDetail => orderDetail.orderID);
        }
    }
}

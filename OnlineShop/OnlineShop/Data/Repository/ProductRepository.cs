using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> Products => appDBContent.Products.Include(c => c.Category).Include(m => m.Manufacturer);

        public IEnumerable<Product> getFavProducts => appDBContent.Products.Where(p => p.isFavourite).Include(c => c.Category).Include(m => m.Manufacturer);

        public Product getObjectProduct(int productId) => appDBContent.Products.FirstOrDefault(p => p.id == productId);
    }
}

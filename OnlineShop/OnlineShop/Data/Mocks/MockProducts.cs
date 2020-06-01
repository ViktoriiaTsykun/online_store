using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _categoryProducts = new MockCategory();
        public IEnumerable<Product> Products {
            get
            {
                return new List<Product>
                {
                    new Product { name = "Samsung A5", shortDescr = "Good mobile", longDescr = "A veryyy good mobile", img = "/img/Паспорт1.jpg", price = 30000, isFavourite = true, available = true, Category =  _categoryProducts.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Product> getFavProducts { get; set; }

        public Product getObjectProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}

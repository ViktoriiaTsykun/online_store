using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Компьютеры", description = "ПК для работы"},
                    new Category { categoryName = "Телевизоры", description = "Устройства для звонков"}
                };
            }
        }
    }
}

using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> allProducts { get; set; }

        public string currCategory { get; set; }

        public string categoryDescr { get; set; }
    }
}

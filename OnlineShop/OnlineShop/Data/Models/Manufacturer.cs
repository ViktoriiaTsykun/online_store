using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class Manufacturer
    {
        public int id { set; get; }

        public string manufacturerName { set; get; }

        public string description { set; get; }

        public List<Product> Products { set; get; }
    }
}

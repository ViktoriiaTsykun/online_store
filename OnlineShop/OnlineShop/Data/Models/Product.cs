using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class Product
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDescr { set; get; }

        public string longDescr { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public bool isFavourite { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }

        public int manufacturerID { set; get; }

        public virtual Manufacturer Manufacturer { set; get; }
    }
}

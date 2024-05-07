using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Intities
{
    internal class Product
    {
        public string Item {  get; set; }
        public double Price { get; set; }

        public Product(string item, double price)
        {
            Item = item;
            Price = price;
        }
    }
}

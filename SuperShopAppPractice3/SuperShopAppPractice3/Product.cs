using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Product
    {
        public Product()
        {

        }
        public string Id { get; set; }
        public double Quantity { get; set; }
        public Product(string id, double qty)
        {
            Id = id;
            Quantity = qty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    internal class Product
    {
        public int ProductID;
        public string Name;
        public double Price;
        public Product(
            int ProductID=0,
            string Name=" ",
            double Price=0)
        { 
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
        }
    }
}

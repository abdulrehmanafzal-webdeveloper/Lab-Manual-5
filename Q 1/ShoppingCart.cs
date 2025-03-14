using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    internal class ShoppingCart
    {
        public int CartID;
        public string CustomerName;
        public double TotalPrice;
        Product[] Product;
        int count;
        public ShoppingCart()
        {
            CartID = 0;
            CustomerName = " ";
            Product = new Product[10];
            count = 0;
            TotalPrice = 0;
        }
        public void addproduct(Product product)
        {
            Product[count] = product;
            count++;
            Console.WriteLine("product is added in cart");
        }
        public void removeproduct(int productId)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (Product[i].ProductID==productId)
                {
                    found = true;
                    Product[i] = Product[i+1];
                }
            }
            if (found == true)
            {
                count--;
            }
            else
            {
                Console.WriteLine($"Product ID: {productId} is not found");
            }
        }
        public void displaycart()
        {
            Console.WriteLine("______________________________________");
            Console.WriteLine("Produc id | Product name  | Price ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{Product[i].ProductID}            {Product[i].Name}            {Product[i].Price}");
                TotalPrice = Product[i].Price + TotalPrice;
            }
            Console.WriteLine($"total price of products={TotalPrice}");
        }
    }
}

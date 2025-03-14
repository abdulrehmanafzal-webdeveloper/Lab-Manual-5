using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            Console.Write("enter cart id=");
            int id = int.Parse(Console.ReadLine());
            Console.Write("enter cutomer name=");
            string Customername = Console.ReadLine();

            ShoppingCart cart = new ShoppingCart();
            cart.CartID = id;
            cart.CustomerName = Customername;



            Console.Write($"\nenter  product id=");
            int productid = int.Parse(Console.ReadLine());
            Console.Write("enter product name=");
            string proname = Console.ReadLine();
            Console.Write("enter product price=");
            double price = double.Parse(Console.ReadLine());
            product.Price = price;
            product.ProductID = productid;
            product.Name = proname;


            cart.addproduct(product);

            Product product2 = new Product();

            Console.Write($"\nenter  product id=");
            int productid2 = int.Parse(Console.ReadLine());
            Console.Write("enter product name=");
            string proname2 = Console.ReadLine();
            Console.Write("enter product price=");
            double price2 = double.Parse(Console.ReadLine());
            product2.Price = price2;
            product2.ProductID = productid2;
            product2.Name = proname2;

            cart.addproduct(product2);

            cart.displaycart();

            Console.Write("enter product id you want to remove");
            int id2 = int.Parse(Console.ReadLine());
            cart.removeproduct(id2);

            Employee employee = new Employee(1, "Abdul", "Rehman", new DateTime(1990, 5, 15), 55000, "IT");
            Employee employee2 = new Employee(2, "Ali", "Hassan", new DateTime(2023, 8, 20), 55000, "Fashion designer");
            Employee employee3 = new Employee(3, "Mohsin", "tariq", new DateTime(2015, 9, 10), 55000, "Garments");

            //Company
            Company company = new Company();
            company.addemployee(employee);
            company.addemployee(employee2);
            company.addemployee(employee3);

            Console.Write("enter employee id you want to remove=");
            int id3=int.Parse(Console.ReadLine());

            company.removeemployee(id3);

            Console.Write("enter employee id you want to display=");
            int id4 = int.Parse(Console.ReadLine());
            company.displaydetail(id4);
        }
    }
}

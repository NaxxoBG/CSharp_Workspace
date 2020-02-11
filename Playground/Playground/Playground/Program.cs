using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Order
    {
        public int Quantity;
        public Product Product;
    }

    public class Customer
    {
        public string Name;
        public string City;
        public Order[] Orders;

        public override string ToString()
        {
            return "Name " + Name + "City: " + City;
        }
    }

    public class Product
    {
        public string Name;
        public decimal Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product() { Name = "Fafla", Price = 1 };
            var p2 = new Product() { Name = "Semki", Price = 2 };
            var p3 = new Product() { Name = "Mleko", Price = 3 };
            var p4 = new Product() { Name = "Chubrica", Price = 5 };
            var p5 = new Product() { Name = "Butcheta", Price = 6 };

            var o1 = new Order() { Product = p1, Quantity = 30 };
            var o2 = new Order() { Product = p2, Quantity = 50 };
            var o3 = new Order() { Product = p3, Quantity = 100 };
            var o4 = new Order() { Product = p4, Quantity = 80 };
            var o5 = new Order() { Product = p5, Quantity = 200 };


            var c1 = new Customer() { City = " Horsens ", Name = " Jack ", Orders = new Order[] { o1, o3 } };
            var c2 = new Customer() { City = " Mexico city ", Name = " Pesho ", Orders = new Order[] { o1, o2 } };
            var c3 = new Customer() { City = " Tutrakan ", Name = " Genko ", Orders = new Order[] { o4, o5, o1 } };
            var c4 = new Customer() { City = " Melnik ", Name = " Stanimir ", Orders = new Order[] { o1, o3, o5 } };
            var c5 = new Customer() { City = " Vejle ", Name = " Stavri ", Orders = new Order[] { o5, o2 } };
            var c6 = new Customer() { City = " New York ", Name = " Vyrban ", Orders = new Order[] { o4, o1 } };

            var cst = new List<Customer> { c1, c2, c3, c4, c5, c6 };

            // Print the each customer's name and city on a new line
            (from cust in cst select new { cust.Name, cust.City }).ToList().ForEach(Console.WriteLine);

            // Print the total sum (prices of products in Orders) from each customer.
            cst.ForEach(c => Console.WriteLine($"Name: {c.Name.Trim()}; Total orders' sum: {c.Orders.Select(p => p.Product.Price * p.Quantity).Sum()}"));

            // Sum of all orders

            var totalSum = cst.SelectMany(c => c.Orders).Select(o => o.Quantity * o.Product.Price).Sum();
            Console.WriteLine(totalSum);
        }
    }
}

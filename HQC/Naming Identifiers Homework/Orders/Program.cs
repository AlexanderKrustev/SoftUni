using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using Orders.Models;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DataMapper db = new DataMapper();
            IEnumerable<Category> categories = db.GetCategories();
            IEnumerable<Product> products = db.GetProducts();
            IEnumerable<Order> orders = db.GetOrders();

            // Names of the 5 most expensive products
           IEnumerable<string> mostExpensive = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.ProductName);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensive));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var second = products
                .GroupBy(p => p.ProductCategory)
                .Select(grp => new { Category = categories.First(c => c.CategoryID == grp.Key).CategoryName, Count = grp.Count() })
                .ToList();
            foreach (var item in second)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var third = orders
                .GroupBy(o => o.OrderProductID)
                .Select(grp => new { Product = products.First(p => p.ProductID == grp.Key).ProductName, Quantities = grp.Sum(grpgrp => grpgrp.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in third)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var category = orders
                .GroupBy(o => o.OrderProductID)
                .Select(g => new { catId = products.First(p => p.ProductID== g.Key).ProductCategory, price = products.First(p => p.ProductID == g.Key).UnitPrice, quantity = g.Sum(p => p.Quantity) })
                .GroupBy(gg => gg.catId)
                .Select(grp => new { category_name = categories.First(c => c.CategoryID == grp.Key).CategoryName, total_quantity = grp.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", category.category_name, category.total_quantity);
        }
    }
}

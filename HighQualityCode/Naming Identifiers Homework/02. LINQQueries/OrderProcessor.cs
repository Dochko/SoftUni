using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using Orders.Models;

namespace Orders
{
    class OrderProcessor
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DataMapper productsDatabase = new DataMapper();
            IEnumerable<Category> categories = productsDatabase.GetAllCategories();
            IEnumerable<Product> products = productsDatabase.GetAllProducts();
            IEnumerable<Order> orders = productsDatabase.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpensive = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);

            Console.WriteLine(string.Join(Environment.NewLine, mostExpensive));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProducts = products
                .GroupBy(p => p.CategoryId)
                .Select(grp => new
                {
                    Category = categories.First(c => c.Id == grp.Key)
                    .Name, Count = grp.Count()
                })
                .ToList();

            foreach (var item in numberOfProducts)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var mostOrderedProducts = orders
                .GroupBy(o => o.ProductId)
                .Select(grp => new
                {
                    Product = products.First(p => p.Id == grp.Key)
                    .Name, Quantities = grp.Sum(grpgrp => grpgrp.Quantity) 
                })
                .OrderByDescending(q => q.Quantities)
                .Take(5);

            foreach (var item in mostOrderedProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(order => order.ProductId)
                .Select(g => new
                {
                    categoryId = products.First(p => p.Id == g.Key)
                    .CategoryId, price = products.First(p => p.Id == g.Key)
                    .UnitPrice, quantity = g.Sum(p => p.Quantity) 
                })
                .GroupBy(gg => gg.categoryId)
                .Select(grp => new
                {
                    categoryName = categories.First(c => c.Id == grp.Key)
                    .Name, totalQuantity = grp.Sum(g => g.quantity * g.price) 
                })
                .OrderByDescending(g => g.totalQuantity)
                .First();

            Console.WriteLine("{0}: {1}", mostProfitableCategory.categoryName, mostProfitableCategory.totalQuantity);
        }
    }
}

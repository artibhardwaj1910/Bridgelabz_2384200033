
using System;
using System.Collections.Generic;
using System.Linq;
namespace CollectionsAssignment
{
    class ShoppingCart
    {
        private Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Store product prices
        private LinkedList<Tuple<string, double>> cartOrder = new LinkedList<Tuple<string, double>>(); // Maintain order
        private SortedDictionary<double, List<string>> sortedCart = new SortedDictionary<double, List<string>>(); // Sort by price

        // Add product to cart
        public void AddProduct(string product, double price)
        {
            if (!productPrices.ContainsKey(product))
            {
                productPrices[product] = price;
                Console.WriteLine($"{product} added with price ${price}.");
            }

            cartOrder.AddLast(new Tuple<string, double>(product, price));

            if (!sortedCart.ContainsKey(price))
            {
                sortedCart[price] = new List<string>();
            }
            sortedCart[price].Add(product);
        }

        // Display products in order added
        public void DisplayCartOrder()
        {
            Console.WriteLine("\nCart in Order Added:");
            foreach (var item in cartOrder)
            {
                Console.WriteLine($"{item.Item1}: ${item.Item2}");
            }
        }

        // Display products sorted by price
        public void DisplaySortedCart()
        {
            Console.WriteLine("\nCart Sorted by Price:");
            foreach (var price in sortedCart.Keys)
            {
                foreach (var product in sortedCart[price])
                {
                    Console.WriteLine($"{product}: ${price}");
                }
            }
        }

        // Calculate total price
        public void DisplayTotalPrice()
        {
            double total = cartOrder.Sum(item => item.Item2);
            Console.WriteLine($"\nTotal Price: ${total}");
        }
    }

    class Program
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            // Adding products
            cart.AddProduct("Laptop", 999.99);
            cart.AddProduct("Headphones", 199.99);
            cart.AddProduct("Mouse", 49.99);
            cart.AddProduct("Keyboard", 89.99);
            cart.AddProduct("Monitor", 299.99);

            // Display results
            cart.DisplayCartOrder();
            cart.DisplaySortedCart();
            cart.DisplayTotalPrice();
        }
    }
}


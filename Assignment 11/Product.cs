using System;
using System.Collections.Generic;

namespace ObjectModelAssignment
{
    class Product
    {
        private string productName;
        private double price;

        // Constructor 
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }

        // Getter method 
        public string GetProductName()
        {
            return productName;
        }

        // Getter method 
        public double GetPrice()
        {
            return price;
        }

        // Method to display product details
        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {productName}, Price: ${price}");
        }
    }

    // Order class representing a customer's purchase
    class Order
    {
        private int orderID;
        private List<Product> products; 

        // Constructor to initialize order with an ID
        public Order(int orderID)
        {
            this.orderID = orderID;
            this.products = new List<Product>();
        }

        // Method to add a product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Method to display order details
        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {orderID}");
            Console.WriteLine("Products in the order:");
            foreach (Product product in products)
            {
                product.DisplayProduct();
            }
            Console.WriteLine();
        }
    }

    // Customer class representing a user who places orders
    class Customer
    {
        private string customerName;
        private int customerID;
        private List<Order> orders; 

        // Constructor to initialize customer details
        public Customer(string customerName, int customerID)
        {
            this.customerName = customerName;
            this.customerID = customerID;
            this.orders = new List<Order>();
        }

        // Getter method for customer name
        public string GetCustomerName()
        {
            return customerName;
        }

        // Method to place an order
        public void PlaceOrder(Order order)
        {
            orders.Add(order);
            Console.WriteLine($"{customerName} has placed an Order (ID: {order.GetOrderID()}).");
        }

        // Method to display customer's orders
        public void DisplayOrders()
        {
            Console.WriteLine($"{customerName}'s Orders:");
            foreach (Order order in orders)
            {
                order.DisplayOrder();
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating product objects
            Product product1 = new Product("Laptop", 1200.50);
            Product product2 = new Product("Smartphone", 799.99);
            Product product3 = new Product("Headphones", 149.99);

            // Creating customer objects
            Customer customer1 = new Customer("Alice", 101);
            Customer customer2 = new Customer("Bob", 102);

            // Creating order objects
            Order order1 = new Order(1);
            Order order2 = new Order(2);

            // Adding products to orders
            order1.AddProduct(product1);
            order1.AddProduct(product3);

            order2.AddProduct(product2);

            // Customers placing orders
            customer1.PlaceOrder(order1);
            customer2.PlaceOrder(order2);

            // Displaying customer orders
            customer1.DisplayOrders();
            customer2.DisplayOrders();
        }
    }
}

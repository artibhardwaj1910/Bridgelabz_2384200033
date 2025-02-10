using System;
namespace KeywordAssignment
{
    class Product
    {
        private static double discount = 5.0; 
        private readonly int productID; 
        private string productName;
        private double price;
        private int quantity;

        public Product(string productName, int productID, double price, int quantity)
        {
            this.productName = productName;
            this.productID = productID;
            this.price = price;
            this.quantity = quantity;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            discount = newDiscount;
        }

        public void DisplayProductDetails()
        {
            if (this is Product) 
            {
                Console.WriteLine($"Product Name: {productName}");
                Console.WriteLine($"Product ID: {productID}");
                Console.WriteLine($"Price: {price}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Discount: {discount}%");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Product product1 = new Product("Laptop", 501, 1500.99, 2);
            product1.DisplayProductDetails();
            Product.UpdateDiscount(10.0);
            product1.DisplayProductDetails();
        }
    }
}


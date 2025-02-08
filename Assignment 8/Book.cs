using System;
namespace ClassObjectLevel01
{
    public class Book
    {
        // fields 
        private string title;
        private string author;
        private double price;

        // Constructor to initialize 
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Method to display book details
        public void DisplayDetails()
        {
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book Price: ${price}");
        }
    }

    // Main class
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a Book object
            Book book1 = new Book("C# Programming", "John Smith", 29.99);

            // Displaying book details
            book1.DisplayDetails();
        }
    }
}


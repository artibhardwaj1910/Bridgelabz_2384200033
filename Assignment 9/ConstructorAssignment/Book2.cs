using System;
namespace ConstructorAssignment
{
    // Class representing a book in the library
    class Book2
    {
        // Private attributes
        private string title;
        private string author;
        private double price;
        private bool availability;

        // Constructor to initialize the book details
        public Book(string title, string author, double price, bool availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }

        // Getter and setter for title
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // Getter and setter for author
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // Getter and setter for price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Getter and setter for availability
        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        // Method to borrow the book
        public void BorrowBook()
        {
            if (availability)
            {
                Console.WriteLine($"You have successfully borrowed '{title}' by {author}.");
                availability = false; // Mark the book as unavailable once borrowed
            }
            else
            {
                Console.WriteLine($"Sorry, '{title}' by {author} is currently unavailable.");
            }
        }

        // Method to return the book
        public void ReturnBook()
        {
            availability = true;
            Console.WriteLine($"You have successfully returned '{title}' by {author}.");
        }
    }

}

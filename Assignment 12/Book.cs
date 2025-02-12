using System;

namespace InheritenceAssignment
{
    // Base class Book
    class Book
    {
        protected string title;
        protected int publicationYear;

        // Constructor to initialize Book attributes
        public Book(string title, int publicationYear)
        {
            this.title = title;
            this.publicationYear = publicationYear;
        }

        // Method to display book details
        public void DisplayInfo()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Publication Year: " + publicationYear);
        }
    }

    // Subclass Author inheriting from Book
    class Author : Book
    {
        private string name;
        private string bio;

        // Constructor to initialize Author attributes
        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            this.name = name;
            this.bio = bio;
        }

        // Method to display book and author details
        public void DisplayAuthorInfo()
        {
            DisplayInfo();
            Console.WriteLine("Author Name: " + name);
            Console.WriteLine("Bio: " + bio);
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating an object of Author (which includes Book details)
            Author author = new Author("Wings of Fire", 1999, "Dr. A.P.J. Abdul Kalam", "Former President of India and a renowned scientist.");

            // Displaying book and author details
            author.DisplayAuthorInfo();
        }
    }
}

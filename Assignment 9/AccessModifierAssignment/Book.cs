using System;

namespace AccessModifierAssignment
{
    // Base class Book
    class Book
    {
        // Public, protected, and private members
        public string ISBN;
        protected string title;
        private string author;

        // Constructor to initialize values
        public Book(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        // Getter method for author
        public string GetAuthor()
        {
            return author;
        }

        // Setter method for author
        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }

    // Derived class EBook demonstrating access to ISBN and title
    class EBook : Book
    {
        // Constructor to initialize values, calling base class constructor
        public EBook(string ISBN, string title, string author)
            : base(ISBN, title, author)
        {
        }

        // Method to display ISBN and title
        public void DisplayBookInfo()
        {
            Console.WriteLine("EBook ISBN: " + ISBN);
            Console.WriteLine("EBook Title: " + title);
        }
    }
}

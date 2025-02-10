using System;
namespace KeywordAssignment
{
    class Book
    {
        private static string libraryName = "City Library"; 
        private readonly string isbn; 
        private string title;
        private string author;

        public Book(string title, string author, string isbn)
        {
            this.title = title; 
            this.author = author;
            this.isbn = isbn;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name: {libraryName}");
        }

        public void DisplayBookDetails()
        {
            if (this is Book) 
            {
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"ISBN: {isbn}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Book.DisplayLibraryName();
            Book book1 = new Book("C# Programming", "John Doe", "1234567890");
            book1.DisplayBookDetails();
        }
    }
}


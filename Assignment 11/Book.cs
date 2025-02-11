using System;
using System.Collections.Generic;
namespace ObjectModelAssignment{

	class Book{
		
		private string title;
		private string author;
		
		public Book(string title, string auhtor){
			this.title = title;
			this.author = author;
		}
		
		public string GetTitle(){
			return title;
		}
		
		public string getAuthor(){
			return author;
		}
			
	}
	
	class Library{
	
		private string libraryName;
		private List<Book> books;
		
		public Library(string libraryName){
		
			this.libraryName = libraryName;
			this.book = new List<Book>();
		}
		
		public void AddBook(Book book){
			books.Add(Book);
		}
		
		public void DisplayBooks()
        {
            Console.WriteLine($"Books in {libraryName}:");
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.GetTitle()}, Author: {book.GetAuthor()}");
            }
            Console.WriteLine();
        }
	}
	
	class Program
    {
        static void Main()
        {
            // Creating book objects
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            Book book3 = new Book("1984", "George Orwell");

            // Creating library objects
            Library library1 = new Library("City Library");
            Library library2 = new Library("University Library");

            // Adding books to different libraries
            library1.AddBook(book1);
            library1.AddBook(book2);

            library2.AddBook(book2);
            library2.AddBook(book3);

            // Displaying books in each library
            library1.DisplayBooks();
            library2.DisplayBooks();
        }
    }
}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
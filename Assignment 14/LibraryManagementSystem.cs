using System;
namespace LibraryManagementSystem
{
    // Node representing a book in the library
    class BookNode
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public BookNode Next;
        public BookNode Prev;

        public BookNode(string title, string author, string genre, int bookID, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = bookID;
            IsAvailable = isAvailable;
            Next = null;
            Prev = null;
        }
    }

    // Doubly Linked List for Library Management
    class Library
    {
        private BookNode head;
        private BookNode tail;
        private int bookCount;

        public Library()
        {
            head = null;
            tail = null;
            bookCount = 0;
        }

        // Add a book at the beginning
        public void AddBookAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
        {
            BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            bookCount++;
            Console.WriteLine("Book added successfully at the beginning.");
        }

        // Add a book at the end
        public void AddBookAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
        {
            BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            bookCount++;
            Console.WriteLine("Book added successfully at the end.");
        }

        // Add a book at a specific position
        public void AddBookAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position)
        {
            if (position < 1 || position > bookCount + 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            BookNode newNode = new BookNode(title, author, genre, bookID, isAvailable);
            if (position == 1)
            {
                AddBookAtBeginning(title, author, genre, bookID, isAvailable);
                return;
            }

            BookNode temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.Next;
            }

            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if (temp.Next != null)
            {
                temp.Next.Prev = newNode;
            }
            else
            {
                tail = newNode;
            }

            temp.Next = newNode;
            bookCount++;
            Console.WriteLine("Book added successfully at position " + position);
        }

        // Remove a book by Book ID
        public void RemoveBook(int bookID)
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            BookNode temp = head;
            while (temp != null && temp.BookID != bookID)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Book ID not found.");
                return;
            }

            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
            else
            {
                head = temp.Next;
            }

            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
            else
            {
                tail = temp.Prev;
            }

            bookCount--;
            Console.WriteLine("Book removed successfully.");
        }

        // Search for a book by Title or Author
        public void SearchBook(string keyword)
        {
            BookNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Title.ToLower().Contains(keyword.ToLower()) || temp.Author.ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
                Console.WriteLine("Book not found.");
        }

        // Update a book's availability status
        public void UpdateAvailability(int bookID, bool isAvailable)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.BookID == bookID)
                {
                    temp.IsAvailable = isAvailable;
                    Console.WriteLine("Availability status updated successfully.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book ID not found.");
        }

        // Display all books in forward order
        public void DisplayBooksForward()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            Console.WriteLine("\nBooks in Library:");
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                temp = temp.Next;
            }
        }

        // Display all books in reverse order
        public void DisplayBooksReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            Console.WriteLine("\nBooks in Reverse Order:");
            BookNode temp = tail;
            while (temp != null)
            {
                Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                temp = temp.Prev;
            }
        }

        // Count total number of books
        public void CountBooks()
        {
            Console.WriteLine($"Total Books in Library: {bookCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book at Beginning");
                Console.WriteLine("2. Add Book at End");
                Console.WriteLine("3. Add Book at Position");
                Console.WriteLine("4. Remove Book");
                Console.WriteLine("5. Search Book");
                Console.WriteLine("6. Update Availability");
                Console.WriteLine("7. Display Books Forward");
                Console.WriteLine("8. Display Books Reverse");
                Console.WriteLine("9. Count Books");
                Console.WriteLine("10. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 10)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int bookID, position;
                string title, author, genre;
                bool isAvailable;

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.Write("Enter Book ID: ");
                        bookID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        genre = Console.ReadLine();
                        Console.Write("Is Available (true/false): ");
                        isAvailable = Convert.ToBoolean(Console.ReadLine());

                        if (choice == 1)
                            library.AddBookAtBeginning(title, author, genre, bookID, isAvailable);
                        else if (choice == 2)
                            library.AddBookAtEnd(title, author, genre, bookID, isAvailable);
                        else
                        {
                            Console.Write("Enter Position: ");
                            position = Convert.ToInt32(Console.ReadLine());
                            library.AddBookAtPosition(title, author, genre, bookID, isAvailable, position);
                        }
                        break;

                    case 4:
                        Console.Write("Enter Book ID to remove: ");
                        bookID = Convert.ToInt32(Console.ReadLine());
                        library.RemoveBook(bookID);
                        break;

                    case 5:
                        Console.Write("Enter Book Title or Author to search: ");
                        string keyword = Console.ReadLine();
                        library.SearchBook(keyword);
                        break;

                    case 6:
                        Console.Write("Enter Book ID to update availability: ");
                        bookID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Is Available (true/false): ");
                        isAvailable = Convert.ToBoolean(Console.ReadLine());
                        library.UpdateAvailability(bookID, isAvailable);
                        break;

                    case 7:
                        library.DisplayBooksForward();
                        break;

                    case 8:
                        library.DisplayBooksReverse();
                        break;

                    case 9:
                        library.CountBooks();
                        break;
                }
            }
        }
    }
}

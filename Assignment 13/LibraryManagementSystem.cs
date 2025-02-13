using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    // Abstract class LibraryItem
    public abstract class LibraryItem
    {
        // Encapsulated fields
        private string itemId;
        private string title;
        private string author;

        // Constructor
        public LibraryItem(string itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        // Properties
        public string ItemId => itemId;
        public string Title => title;
        public string Author => author;

        // Concrete method
        public void GetItemDetails()
        {
            Console.WriteLine($"Item ID: {itemId}, Title: {title}, Author: {author}");
        }

        // Abstract method
        public abstract int GetLoanDuration();
    }

    // Interface for reservable items
    public interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    // Book subclass
    public class Book : LibraryItem, IReservable
    {
        private bool isAvailable = true;

        public Book(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration() => 14; // Books can be borrowed for 14 days

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("Book reserved successfully.");
            }
            else
            {
                Console.WriteLine("Book is currently unavailable.");
            }
        }

        public bool CheckAvailability() => isAvailable;
    }

    // Magazine subclass
    public class Magazine : LibraryItem
    {
        public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration() => 7; // Magazines can be borrowed for 7 days
    }

    // DVD subclass
    public class DVD : LibraryItem, IReservable
    {
        private bool isAvailable = true;

        public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration() => 3; // DVDs can be borrowed for 3 days

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("DVD reserved successfully.");
            }
            else
            {
                Console.WriteLine("DVD is currently unavailable.");
            }
        }

        public bool CheckAvailability() => isAvailable;
    }

    class Program
    {
        static void Main()
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
            {
                new Book("B001", "The Great Gatsby", "F. Scott Fitzgerald"),
                new Magazine("M001", "Time Magazine", "Time Editors"),
                new DVD("D001", "Inception", "Christopher Nolan")
            };

            foreach (var item in libraryItems)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days\n");
            }

            IReservable reservableBook = new Book("B002", "1984", "George Orwell");
            reservableBook.ReserveItem();
            Console.WriteLine($"Is Book Available? {reservableBook.CheckAvailability()}\n");
        }
    }
}


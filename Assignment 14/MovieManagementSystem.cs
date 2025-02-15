using System;
namespace MovieManagementSystem
{
    // Class representing a Movie Node in the Doubly Linked List
    class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public MovieNode Prev;
        public MovieNode Next;

        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Prev = null;
            Next = null;
        }
    }

    // Class to manage the Movie Doubly Linked List
    class MovieDoublyLinkedList
    {
        private MovieNode head;

        // Add Movie at the Beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (head != null)
            {
                newNode.Next = head;
                head.Prev = newNode;
            }
            head = newNode;
        }

        // Add Movie at the End
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (head == null)
            {
                head = newNode;
                return;
            }

            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        // Add Movie at a Specific Position
        public void AddAtPosition(string title, string director, int year, double rating, int position)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (position == 1)
            {
                newNode.Next = head;
                if (head != null)
                    head.Prev = newNode;
                head = newNode;
                return;
            }

            MovieNode temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid Position!");
                return;
            }

            newNode.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = newNode;

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        // Remove Movie by Title
        public void RemoveByTitle(string title)
        {
            if (head == null)
            {
                Console.WriteLine("No Movies in the List!");
                return;
            }

            MovieNode temp = head;
            while (temp != null && temp.Title != title)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Movie Not Found!");
                return;
            }

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
            else
                head = temp.Next;

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            Console.WriteLine("Movie Record Deleted!");
        }

        // Search Movie by Director
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Director == director)
                {
                    Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
                Console.WriteLine("No Movies Found for the Given Director!");
        }

        // Search Movie by Rating
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
                Console.WriteLine("No Movies Found with the Given Rating!");
        }

        // Display Movies in Forward Order
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No Movies Available!");
                return;
            }

            MovieNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                temp = temp.Next;
            }
        }

        // Display Movies in Reverse Order
        public void DisplayReverse()
        {
            if (head == null)
            {
                Console.WriteLine("No Movies Available!");
                return;
            }

            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            while (temp != null)
            {
                Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                temp = temp.Prev;
            }
        }

        // Update Movie Rating by Title
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.Title == title)
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Movie Rating Updated!");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Movie Not Found!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MovieDoublyLinkedList movieList = new MovieDoublyLinkedList();

            while (true)
            {
                Console.WriteLine("\nMovie Management System");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Remove by Title");
                Console.WriteLine("5. Search by Director");
                Console.WriteLine("6. Search by Rating");
                Console.WriteLine("7. Display Forward");
                Console.WriteLine("8. Display Reverse");
                Console.WriteLine("9. Update Rating");
                Console.WriteLine("10. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 10)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                string title, director;
                int year, position;
                double rating;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Title: ");
                        title = Console.ReadLine();
                        Console.Write("Enter Director: ");
                        director = Console.ReadLine();
                        Console.Write("Enter Year of Release: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Rating: ");
                        rating = Convert.ToDouble(Console.ReadLine());
                        movieList.AddAtBeginning(title, director, year, rating);
                        break;

                    case 2:
                        Console.Write("Enter Title: ");
                        title = Console.ReadLine();
                        Console.Write("Enter Director: ");
                        director = Console.ReadLine();
                        Console.Write("Enter Year of Release: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Rating: ");
                        rating = Convert.ToDouble(Console.ReadLine());
                        movieList.AddAtEnd(title, director, year, rating);
                        break;

                    case 3:
                        Console.Write("Enter Title: ");
                        title = Console.ReadLine();
                        Console.Write("Enter Director: ");
                        director = Console.ReadLine();
                        Console.Write("Enter Year of Release: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Rating: ");
                        rating = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        movieList.AddAtPosition(title, director, year, rating, position);
                        break;

                    case 4:
                        Console.Write("Enter Movie Title to Remove: ");
                        title = Console.ReadLine();
                        movieList.RemoveByTitle(title);
                        break;

                    case 5:
                        Console.Write("Enter Director Name: ");
                        director = Console.ReadLine();
                        movieList.SearchByDirector(director);
                        break;

                    case 6:
                        Console.Write("Enter Rating to Search: ");
                        rating = Convert.ToDouble(Console.ReadLine());
                        movieList.SearchByRating(rating);
                        break;

                    case 7:
                        movieList.DisplayForward();
                        break;

                    case 8:
                        movieList.DisplayReverse();
                        break;

                    case 9:
                        Console.Write("Enter Movie Title to Update Rating: ");
                        title = Console.ReadLine();
                        Console.Write("Enter New Rating: ");
                        rating = Convert.ToDouble(Console.ReadLine());
                        movieList.UpdateRating(title, rating);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}

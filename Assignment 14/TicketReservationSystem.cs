using System;
namespace TicketReservationSystem
{
    // Node representing a ticket reservation
    class TicketNode
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public int SeatNumber;
        public DateTime BookingTime;
        public TicketNode Next;

        public TicketNode(int ticketID, string customerName, string movieName, int seatNumber)
        {
            TicketID = ticketID;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = DateTime.Now;
            Next = null;
        }
    }

    // Circular Linked List for ticket reservations
    class TicketReservation
    {
        private TicketNode last;
        private int count;

        public TicketReservation()
        {
            last = null;
            count = 0;
        }

        // Add a new ticket reservation at the end of the circular list
        public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber)
        {
            TicketNode newNode = new TicketNode(ticketID, customerName, movieName, seatNumber);

            if (last == null)
            {
                last = newNode;
                last.Next = last;
            }
            else
            {
                newNode.Next = last.Next;
                last.Next = newNode;
                last = newNode;
            }

            count++;
            Console.WriteLine("Ticket booked successfully.");
        }

        // Remove a ticket by Ticket ID
        public void RemoveTicket(int ticketID)
        {
            if (last == null)
            {
                Console.WriteLine("No tickets to remove.");
                return;
            }

            TicketNode current = last.Next;
            TicketNode previous = last;

            do
            {
                if (current.TicketID == ticketID)
                {
                    if (current == last && current.Next == last)
                    {
                        last = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current == last)
                            last = previous;
                    }

                    count--;
                    Console.WriteLine("Ticket removed successfully.");
                    return;
                }

                previous = current;
                current = current.Next;
            } while (current != last.Next);

            Console.WriteLine("Ticket ID not found.");
        }

        // Display the current tickets in the list
        public void DisplayTickets()
        {
            if (last == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode current = last.Next;
            Console.WriteLine("\nCurrent Ticket Reservations:");

            do
            {
                Console.WriteLine($"Ticket ID: {current.TicketID}, Customer: {current.CustomerName}, Movie: {current.MovieName}, Seat: {current.SeatNumber}, Booking Time: {current.BookingTime}");
                current = current.Next;
            } while (current != last.Next);
        }

        // Search for a ticket by Customer Name or Movie Name
        public void SearchTicket(string keyword)
        {
            if (last == null)
            {
                Console.WriteLine("No tickets found.");
                return;
            }

            TicketNode current = last.Next;
            bool found = false;

            do
            {
                if (current.CustomerName == keyword || current.MovieName == keyword)
                {
                    Console.WriteLine($"Ticket ID: {current.TicketID}, Customer: {current.CustomerName}, Movie: {current.MovieName}, Seat: {current.SeatNumber}, Booking Time: {current.BookingTime}");
                    found = true;
                }
                current = current.Next;
            } while (current != last.Next);

            if (!found)
                Console.WriteLine("No matching tickets found.");
        }

        // Calculate the total number of booked tickets
        public void TotalTickets()
        {
            Console.WriteLine($"Total Tickets Booked: {count}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TicketReservation system = new TicketReservation();

            while (true)
            {
                Console.WriteLine("\nOnline Ticket Reservation System");
                Console.WriteLine("1. Book a Ticket");
                Console.WriteLine("2. Remove a Ticket");
                Console.WriteLine("3. Display All Tickets");
                Console.WriteLine("4. Search Ticket by Customer or Movie Name");
                Console.WriteLine("5. Total Tickets Booked");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int ticketID, seatNumber;
                string customerName, movieName;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Ticket ID: ");
                        ticketID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Customer Name: ");
                        customerName = Console.ReadLine();
                        Console.Write("Enter Movie Name: ");
                        movieName = Console.ReadLine();
                        Console.Write("Enter Seat Number: ");
                        seatNumber = Convert.ToInt32(Console.ReadLine());
                        system.AddTicket(ticketID, customerName, movieName, seatNumber);
                        break;

                    case 2:
                        Console.Write("Enter Ticket ID to remove: ");
                        ticketID = Convert.ToInt32(Console.ReadLine());
                        system.RemoveTicket(ticketID);
                        break;

                    case 3:
                        system.DisplayTickets();
                        break;

                    case 4:
                        Console.Write("Enter Customer Name or Movie Name to search: ");
                        string keyword = Console.ReadLine();
                        system.SearchTicket(keyword);
                        break;

                    case 5:
                        system.TotalTickets();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}

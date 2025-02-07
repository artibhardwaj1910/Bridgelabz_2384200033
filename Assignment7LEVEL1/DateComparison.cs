using System;
namespace DateNTimeAssignment
{
    class DateComparison
    {
        static void Main()
        {
            // Taking first date input from the user
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            string firstDateInput = Console.ReadLine();
            DateTime firstDate = DateTime.Parse(firstDateInput);

            // Taking second date input from the user
            Console.Write("Enter the second date (yyyy-MM-dd): ");
            string secondDateInput = Console.ReadLine();
            DateTime secondDate = DateTime.Parse(secondDateInput);

            // Comparing the two dates
            if (firstDate < secondDate)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (firstDate > secondDate)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
    }
}


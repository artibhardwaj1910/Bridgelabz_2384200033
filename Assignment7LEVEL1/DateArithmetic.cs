using System;
namespace DateNTimeAssignment
{
    class DateArithmetic
    {
        static void Main()
        {
            // Taking user input for the date
            Console.Write("Enter a date (yyyy-MM-dd): ");
            string userInput = Console.ReadLine();

            // Parsing the user input into DateTime
            DateTime inputDate = DateTime.Parse(userInput);

            // Adding 7 days, 1 month, and 2 years to the date
            DateTime addedDate = inputDate.AddDays(7);
            addedDate = addedDate.AddMonths(1);
            addedDate = addedDate.AddYears(2);

            // Subtracting 3 weeks (21 days) from the result
            DateTime finalDate = addedDate.AddDays(-21);

            // Displaying results
            Console.WriteLine("Original Date: " + inputDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("After adding 7 days, 1 month, and 2 years: " + addedDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("After subtracting 3 weeks: " + finalDate.ToString("yyyy-MM-dd"));
        }
    }
}


using System;

namespace Assignment05Level2
{
    class LeapYearChecker
    {
        // Checks if the given year is a leap year
        static bool CheckLeapYear(int year)
        {
            // check leap year
            return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
        }

// Main Method
        static void Main(string[] args)
        {
            // Prompt the user to input a year
            Console.WriteLine("Enter a year (1582 or later):");
            int inputYear = Convert.ToInt32(Console.ReadLine());

            // Validate the input year
            if (inputYear < 1582)
            {
                Console.WriteLine("The Leap Year calculation only works for years 1582 or later.");
                return;
            }

            // Check if the year is a leap year
            bool isLeapYear = CheckLeapYear(inputYear);

            // Display the result
            if (isLeapYear)
            {
                Console.WriteLine($"{inputYear} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{inputYear} is not a Leap Year.");
            }
        }
    }
}


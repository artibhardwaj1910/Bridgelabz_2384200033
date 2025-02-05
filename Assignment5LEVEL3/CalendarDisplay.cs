using System;

namespace Assignment05Level3
{
    public class CalendarDisplay
    {
        // Method to get the name of the month
        public static string GetMonthName(int month)
        {
            string[] monthNames = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
            return monthNames[month - 1];
        }

        // Method to check if a year is a leap year
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Method to get the number of days in a month
        public static int GetDaysInMonth(int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(year))
            {
                return 29; // February in a leap year
            }

            return daysInMonth[month - 1];
        }

        // Method to get the first day of the month (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
        public static int GetFirstDayOfMonth(int month, int year)
        {
            int d = 1; // Day 1 of the month
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            return (d + x + (31 * m0) / 12) % 7;
        }

        static void Main(string[] args)
        {
            // Input month and year
            Console.WriteLine("Enter month (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (month < 1 || month > 12 || year <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid month (1-12) and year (greater than 0).");
                return;
            }

            string monthName = GetMonthName(month);
            int daysInMonth = GetDaysInMonth(month, year);
            int firstDay = GetFirstDayOfMonth(month, year);

            // Display the calendar
            Console.WriteLine($"\n  {monthName} {year}");
            Console.WriteLine("  Sun  Mon  Tue  Wed  Thu  Fri  Sat");

            // Indent the first day
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("     ");
            }

            // Display days of the month
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,5}"); // Right-align with 5-character width

                // Move to the next line after Saturday
                if ((firstDay + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}


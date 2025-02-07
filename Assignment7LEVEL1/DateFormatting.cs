using System;
namespace DateNTimeAssignment
{
    class DateFormatting
    {
        static void Main()
        {
            // Getting the current date
            DateTime currentDate = DateTime.Now;

            // Displaying the current date in different formats
            Console.WriteLine("Current Date in format dd/MM/yyyy: " + currentDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Current Date in format yyyy-MM-dd: " + currentDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Current Date in format EEE, MMM dd, yyyy: " + currentDate.ToString("ddd, MMM dd, yyyy"));
        }
    }
}


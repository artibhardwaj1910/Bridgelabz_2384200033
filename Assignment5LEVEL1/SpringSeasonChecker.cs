using System;
namespace Assignment05Level1
{
    class SpringSeasonChecker
    {
        // Method to check Spring Season.
       
        static bool IsSpringSeason(int month, int day)
        {
            // Check for spring season
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                return true;
            }
            return false;
        }

       // main method
        public static void Main(string[] args)
        {
            // Input: Get the month from the user
            Console.Write("Enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Input: Get the day from the user
            Console.Write("Enter the day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Check if it is spring season
            bool isSpring = IsSpringSeason(month, day);

            // Output the result
            if (isSpring)
            {
                Console.WriteLine("It's a Spring Season.");
            }
            else
            {
                Console.WriteLine("Not a Spring Season.");
            }
        }
    }
}


using System;
namespace Assignment05Level1
{
    class SimpleInterest
    {
         // Method to calculate Simple Interest.
        static double CalculateSI(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }

       // main method

       public static void Main(string[] args)
        {
            // Principal amount
            Console.Write("Enter the Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            // Rate of Interest
            Console.Write("Enter the Rate of Interest (in percentage): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            //  Time in years
            Console.Write("Enter the Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate SI
            double simpleInterest = CalculateSI(principal, rate, time);

            // Output
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time}.");
        }
    }
}


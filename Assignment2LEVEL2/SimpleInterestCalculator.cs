using System;
namespace Program{
    class SimpleInterestCalculator{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate the Simple Interest
            double simpleInterest = (principal * rate * time) / 100;

            // Display the result
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}, and Time {time} years."); }}}
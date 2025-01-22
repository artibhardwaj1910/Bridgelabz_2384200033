using System;
namespace Program{
    class DistanceConverter{
        static void Main(string[] args){
            // Declare variables
            double kilometers;
            double miles;
            const double conversionFactor = 1.6;

            // For user input
            Console.WriteLine("Enter the distance in kilometers:");
            kilometers = Convert.ToDouble(Console.ReadLine());

            // Calculate miles
            miles = kilometers / conversionFactor;

            // Display the result
            Console.WriteLine($"The total miles is {miles} mile(s) for the given {kilometers} km."); }}}
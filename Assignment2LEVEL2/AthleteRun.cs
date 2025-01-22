using System;
namespace Program{
    class AthleteRun{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the length of side 1 (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of side 2 (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of side 3 (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            double targetDistance = 5000;
            // Calculate the perimeter and rounds
            double perimeter = side1 + side2 + side3; 
            double rounds = targetDistance / perimeter;
            // Display the result
            Console.WriteLine($"The total number of rounds athlete will run is {rounds:F2} to complete 5 km."); }}}

using System;
namespace Assignment05Level1
{
    class TriangularParkRun
    {
    
        // Method to calculate the perimeter of the triangle.
        static double CalculatePerimeter(double side1, double side2, double side3){
            return side1 + side2 + side3;
        }

        // Method to calculate the number of rounds
        static double CalculateRounds(double distance, double perimeter){
            return distance / perimeter;
       }

     // main method
       public  static void Main(string[] args)
        {
            // Side 1 of the triangle
            Console.Write("Enter the length of side 1 (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            // Side 2 of the triangle
            Console.Write("Enter the length of side 2 (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Side 3 of the triangle
            Console.Write("Enter the length of side 3 (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Calculate the perimeter of the triangle
            double perimeter = CalculatePerimeter(side1, side2, side3);

            // Total distance to run (in meters)
            double totalDistance = 5000;

            // Calculate the number of rounds
            double rounds = CalculateRounds(totalDistance, perimeter);

            // Output the result
            Console.WriteLine($"To complete a 5 km run, the athlete must complete {Math.Ceiling(rounds)} full rounds.");
        }
    }
}


using System;
namespace Program{
    class SquareSideCalculator{
        static void Main(string[] args){
            // Declare variables
            double perimeter, sideLength;

            // For user input
            Console.WriteLine("Enter the perimeter of the square:");
            perimeter = Convert.ToDouble(Console.ReadLine());

            // Calculate the sideLength
            sideLength = perimeter / 4;

            // Display the result
            Console.WriteLine($"The length of the side is {sideLength} whose perimeter is {perimeter}."); }}}
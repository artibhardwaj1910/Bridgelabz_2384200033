using System;
namespace Program{
    class AreaOfTriangle{
        static void Main(string[] args){
            // Declare variables
            double baseLength, height;
            double areaInSquareCm, areaInSquareInches;

            // Take user input for base and height
            Console.WriteLine("Enter the base of the triangle in centimeters:");
            baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle in centimeters:");
            height = Convert.ToDouble(Console.ReadLine());

            // Calculate area in square centimeters
            areaInSquareCm = 0.5 * baseLength * height;

            // Convert area to square inche
            areaInSquareInches = areaInSquareCm / 6.4516;

            // Display the result
            Console.WriteLine($"The area of the triangle is {areaInSquareCm} square centimeters.");
            Console.WriteLine($"The area of the triangle in square inches is {areaInSquareInches} square inches."); }}}
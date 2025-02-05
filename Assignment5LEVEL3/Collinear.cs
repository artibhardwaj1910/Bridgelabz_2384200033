using System;
class Collinear{
    static void Main(string[] args){
        // Input for three points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check collinearity using slope formula
        bool isCollinearSlope = CheckCollinearityUsingSlope(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("\nCollinear using Slope Formula: " + (isCollinearSlope ? "Yes" : "No"));

        // Check collinearity using area of triangle formula
        bool isCollinearArea = CheckCollinearityUsingArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine("Collinear using Area of Triangle Formula: " + (isCollinearArea ? "Yes" : "No")); }

        static bool CheckCollinearityUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3){
        // Avoid division by zero and calculate slopes
        double slopeAB = (x2 - x1) != 0 ? (y2 - y1) / (x2 - x1) : double.PositiveInfinity;
        double slopeBC = (x3 - x2) != 0 ? (y3 - y2) / (x3 - x2) : double.PositiveInfinity;
        double slopeAC = (x3 - x1) != 0 ? (y3 - y1) / (x3 - x1) : double.PositiveInfinity;

        // Points are collinear if slopes are equal
        return slopeAB == slopeBC && slopeBC == slopeAC; }
        static bool CheckCollinearityUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate area of triangle using determinant method
        double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0; // Points are collinear if the area is zero  }}


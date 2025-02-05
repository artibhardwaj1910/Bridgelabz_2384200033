using System;

namespace Assignment05Level3
{
    public class EuclideanAndLine
    {
        // Method to calculate the Euclidean distance between two points
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        // Method to find the equation of a line given two points
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double[] result = new double[2]; // Array to store slope and y-intercept
            if (x2 - x1 == 0)
            {
                Console.WriteLine("The line is vertical and does not have a well-defined slope.");
                return null;
            }
            
            double slope = (y2 - y1) / (x2 - x1);
            double yIntercept = y1 - slope * x1;

            result[0] = slope;
            result[1] = yIntercept;

            return result;
        }

        static void Main(string[] args)
        {
            // Input points
            Console.WriteLine("Enter x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calculate and display the Euclidean distance
            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine($"Euclidean distance between the points: {distance:F2}");

            // Calculate and display the line equation
            double[] lineEquation = FindLineEquation(x1, y1, x2, y2);

            if (lineEquation != null)
            {
                Console.WriteLine($"Equation of the line: y = {lineEquation[0]:F2}x + {lineEquation[1]:F2}");
            }
        }
    }
}


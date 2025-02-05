using System;
namespace Assignment05Level2
{
    public class Quadratic
    {
        // Method to find the roots of the quadratic equation
        public static double[] FindRoots(double a, double b, double c)
        {
            // Calculate the value of delta
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                // Two distinct real roots exist
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                // Only one real root exists
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                // No real roots, return an empty array
                return new double[] { };
            }
        }

        static void Main(string[] args)
        {
            // Take input for a, b, and c
            Console.Write("Enter value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Call the FindRoots method to calculate the roots
            double[] roots = FindRoots(a, b, c);

            // Display the roots
            if (roots.Length == 2)
            {
                Console.WriteLine($"The roots of the equation are {roots[0]} and {roots[1]}.");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"The root of the equation is {roots[0]}.");
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}


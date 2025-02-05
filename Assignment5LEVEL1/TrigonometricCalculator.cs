using System;
namespace Assignment05Level1
{
    class TrigonometricCalculator
    {
        // Method to calculate sine, cosine, and tangent
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            // Convert angle from degrees to radians
            double angleInRadians = angle * (Math.PI / 180);

            // Calculate trigonometric functions
            double sine = Math.Sin(angleInRadians);
            double cosine = Math.Cos(angleInRadians);
            double tangent = Math.Tan(angleInRadians);

            return new double[] { sine, cosine, tangent };
        }

        // main method
        public static void Main(string[] args)
        {
            // Get the angle in degrees from the user
            Console.Write("Enter the angle in degrees: ");
            double angleInDegrees = Convert.ToDouble(Console.ReadLine());

            // Calculate trigonometric values
            double[] trigResults = CalculateTrigonometricFunctions(angleInDegrees);

            // Output the results
            Console.WriteLine($"For an angle of {angleInDegrees} degrees:");
            Console.WriteLine($"Sine: {trigResults[0]:F4}");
            Console.WriteLine($"Cosine: {trigResults[1]:F4}");
            Console.WriteLine($"Tangent: {trigResults[2]:F4}");
        }
    }
}


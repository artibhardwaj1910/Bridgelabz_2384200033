using System;
namespace Assignment05Level1
{
    class WindChillCalculator
    {
        // Method to calculate the wind chill temperature.
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        }

        //Main method
        public static void Main(string[] args)
        {
            // Get the temperature in Fahrenheit
            Console.Write("Enter the temperature in Fahrenheit: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            // Get the wind speed in miles per hour
            Console.Write("Enter the wind speed in miles per hour: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            // Calculate wind chill
            double windChill = CalculateWindChill(temperature, windSpeed);

            // Output
            Console.WriteLine($"The wind chill temperature is {windChill:F2}°F.");
        }
    }
}


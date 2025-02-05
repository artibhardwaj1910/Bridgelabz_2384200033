using System;
namespace Assignment05Level2
{
    class UnitConverter2
    {
        /// Converts yards to feet.
        public static double ConvertYardsToFeet(double yards)
        {
            double yardsTofeet = 3;
            return yards * yardsTofeet;
        }

        /// Converts feet to yards.
        public static double ConvertFeetToYards(double feet)
        {
            double feetToyards = 0.333333;
            return feet * feetToyards;
        }
        /// Converts meters to inches.
        public static double ConvertMetersToInches(double meters)
        {
            double metersToinches = 39.3701;
            return meters * metersToinches;
        }

        /// Converts inches to meters.
        public static double ConvertInchesToMeters(double inches)
        {
            double inchesTometers = 0.0254;
            return inches * inchesTometers;
        }

        /// Converts inches to centimeters.
        public static double ConvertInchesToCentimeters(double inches)
        {
            double inchesTocm = 2.54;
            return inches * inchesTocm;
        }

        static void Main(string[] args)
        {
            // Test each method in the UnitConverter class
            Console.WriteLine("Unit Converter Utility");

            // Convert yards to feet
            double yards = 2.0;
            Console.WriteLine($"{yards} yards = {ConvertYardsToFeet(yards):F2} feet");

            // Convert feet to yards
            double feet = 6.0;
            Console.WriteLine($"{feet} feet = {ConvertFeetToYards(feet):F2} yards");

            // Convert meters to inches
            double meters = 1.5;
            Console.WriteLine($"{meters} meters = {ConvertMetersToInches(meters):F2} inches");

            // Convert inches to meters
            double inches = 40.0;
            Console.WriteLine($"{inches} inches = {ConvertInchesToMeters(inches):F2} meters");

            // Convert inches to centimeters
            Console.WriteLine($"{inches} inches = {ConvertInchesToCentimeters(inches):F2} centimeters");
        }
    }
}


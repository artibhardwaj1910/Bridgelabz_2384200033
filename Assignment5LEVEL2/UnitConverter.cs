using System;
namespace Assignment05Level2
{
    class UnitConverter
    {
      // Converts kilometers to miles.
        public static double ConvertKmToMiles(double km)
        {
            double kmTOmiles = 0.621371;
            return km * kmTomiles;
        }
        /// Converts miles to kilometers.
        public static double ConvertMilesToKm(double miles)
        {
            double milesTokm = 1.60934;
            return miles * milesTokm;
        }
        /// Converts meters to feet.
        public static double ConvertMetersToFeet(double meters)
        {
            double metersTofeet = 3.28084;
            return meters * metersTofeet;
        }
        /// Converts feet to meters.
        public static double ConvertFeetToMeters(double feet)
        {
            double feetTometers = 0.3048;
            return feet * feetTometers;
        }
        static void Main(string[] args)
        {
            // Test each method in the UnitConverter class
            Console.WriteLine("Unit Converter Utility");

            // Convert kilometers to miles
            double kilometers = 5.0;
            Console.WriteLine($"{kilometers} kilometers = {ConvertKmToMiles(kilometers):F2} miles");

            // Convert miles to kilometers
            double miles = 3.0;
            Console.WriteLine($"{miles} miles = {ConvertMilesToKm(miles):F2} kilometers");

            // Convert meters to feet
            double meters = 10.0;
            Console.WriteLine($"{meters} meters = {ConvertMetersToFeet(meters):F2} feet");

            // Convert feet to meters
            double feet = 20.0;
            Console.WriteLine($"{feet} feet = {ConvertFeetToMeters(feet):F2} meters");
        }
    }
}


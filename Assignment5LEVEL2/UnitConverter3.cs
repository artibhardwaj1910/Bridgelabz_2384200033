using System;
namespace Assignment05Level2
{
    class UnitConverter3
    {
        // Convert Fahrenheit to Celsius
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double fahrenheitTocelsius = (fahrenheit - 32) * 5 / 9;
            return fahrenheitTocelsius;
        }

        // Convert Celsius to Fahrenheit
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double celsiusTofahrenheit = (celsius * 9 / 5) + 32;
            return celsiusTofahrenheit;
        }

        // Convert pounds to kilograms
        public static double ConvertPoundsToKilograms(double pounds)
        {
            double poundsTokilograms = 0.453592;
            return pounds * poundsTokilograms;
        }

        // Convert kilograms to pounds
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }

        // Convert gallons to liters
        public static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }

        // Convert liters to gallons
        public static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }

        static void Main(string[] args)
        {
            // Test each method in the UnitConverter class
            Console.WriteLine("Unit Converter Utility");

            // Convert Fahrenheit to Celsius
            double fahrenheit = 98.6;
            Console.WriteLine($"{fahrenheit} Fahrenheit = {ConvertFahrenheitToCelsius(fahrenheit):F2} Celsius");

            // Convert Celsius to Fahrenheit
            double celsius = 37.0;
            Console.WriteLine($"{celsius} Celsius = {ConvertCelsiusToFahrenheit(celsius):F2} Fahrenheit");

            // Convert pounds to kilograms
            double pounds = 150.0;
            Console.WriteLine($"{pounds} pounds = {ConvertPoundsToKilograms(pounds):F2} kilograms");

            // Convert kilograms to pounds
            double kilograms = 68.0;
            Console.WriteLine($"{kilograms} kilograms = {ConvertKilogramsToPounds(kilograms):F2} pounds");

            // Convert gallons to liters
            double gallons = 5.0;
            Console.WriteLine($"{gallons} gallons = {ConvertGallonsToLiters(gallons):F2} liters");

            // Convert liters to gallons
            double liters = 10.0;
            Console.WriteLine($"{liters} liters = {ConvertLitersToGallons(liters):F2} gallons");
        }
    }
}


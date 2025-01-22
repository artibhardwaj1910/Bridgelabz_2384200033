using System;
namespace Program{
    class DistanceInMiles{
        static void Main(string[] args){
           
            // Declare variables
            double distanceInFeet, distanceInYards, distanceInMiles;

            // For user input 
            Console.WriteLine("Enter the distance in feet:");
            distanceInFeet = Convert.ToDouble(Console.ReadLine());

            // Convert distance to yards and miles
            distanceInYards = distanceInFeet / 3; 
            distanceInMiles = distanceInYards / 1760; 

            // Display the result
            Console.WriteLine($"The distance of {distanceInFeet} feet is equivalent to:");
            Console.WriteLine($"Distance in yards: {distanceInYards} yards");
            Console.WriteLine($"Distance in miles: {distanceInMiles} miles"); }}}
using System;
namespace Program{
    class EarthVolume{
        public static void Main(string[] args){

            // Declare variables and initializing value
            double earthRadius = 6378;
            double kmToMiles = 0.621371;

            // Calculate the volumeKm and convert it
            double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(earthRadius, 3);

            double volumeMiles = volumeKm * Math.Pow(kmToMiles, 3);

            // Output the results
            Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm + " and in cubic miles is " + volumeMiles); }}}
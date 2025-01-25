using System;
class Football{
    static void Main(){
        // Define a double array to store the heights
        double[] heights = new double[11];

        // For user input
        Console.WriteLine("Enter the height of each 11 player:");

        double sum = 0.0;

        // Loop to take input for the heights
        for (int i = 0; i < heights.Length; i++){
            Console.Write("Enter height for player {0}: ", i + 1);
            heights[i] = Convert.ToDouble(Console.ReadLine());

            // Add the current player's height to the sum
            sum += heights[i];}

        // Calculate the mean height
        double meanHeight = sum / heights.Length;

        // Display the result
        Console.WriteLine("\nThe mean height of the football team is: " + meanHeight); }} 
using System;
class Table{
    static void Main(){
        // For user input
        Console.Write("Enter a number to find the multiplication table for numbers from 6 to 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define an integer array to store the multiplication results
        int[] result = new int[4]; 

        // Use a for loop to calculate the multiplication table
        for (int i = 6; i <= 9; i++){
            result[i - 6] = number * i;}

        // Display the multiplication results
        for (int i = 0; i < result.Length; i++){
            int multiplier = i + 6;  // Get the correct multiplier
            Console.WriteLine("{0} * {1} = {2}", number, multiplier, result[i]); }}}
using System;
class GreatestFactor{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the greatestFactor variable
        int greatestFactor = 1;

        // Loop to find the greatest factor other than the number itself
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0) 
            {
                greatestFactor = i; 
                break;
            }}
    
        // Display the result
        Console.WriteLine($"The greatest factor of {number} (other than itself) is: {greatestFactor}"); }}
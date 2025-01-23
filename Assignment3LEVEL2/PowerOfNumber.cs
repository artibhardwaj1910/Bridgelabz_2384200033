using System;
class PowerOfNumber{
    static void Main(){
        // For user input
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Initialize the result variable
        int result = 1;

        // Loop to calculate the power
        for (int i = 1; i <= power; i++){
            result *= number; // Multiply it with the base number
        }

        // Display the result
        Console.WriteLine($"{number} raised to the power {power} is: {result}"); }}
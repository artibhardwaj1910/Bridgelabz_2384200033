using System;
class FactorsOfNumber{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The factors of {number} are:");

        // Loop to find the factors
        for (int i = 1; i <= number; i++) 
        {
            if (number % i == 0) // Check if number is divisible by i
            {
                Console.WriteLine(i); }}}}
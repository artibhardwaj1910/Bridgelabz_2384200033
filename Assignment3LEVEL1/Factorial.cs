using System;
class Factorial
    static void Main(string[] args){
        int number;
        long factorial = 1; 

        // For user input
        Console.Write("Enter a positive integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive
        if (number >= 0)
        {
            // Calculate factorial
            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
   }
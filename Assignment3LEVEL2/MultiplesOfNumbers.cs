using System;
class MultiplesOfNumber{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The multiples of {number} below 100 are:");

        // Backward loop from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0){
                Console.WriteLine(i); }}}}
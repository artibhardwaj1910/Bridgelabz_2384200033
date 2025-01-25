using System;
class FindFactors{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Loop to find the factors of the number
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                // If the factors array is full, resize it
                if (index == maxFactor){
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp; }

                // Store the factor in the array
                factors[index] = i;
                index++; }}
				// Display the factors of the number
                Console.WriteLine("\nFactors of {0}:", number);
                for (int i = 0; i < index; i++){
                    Console.Write(factors[i] + " "); }}}
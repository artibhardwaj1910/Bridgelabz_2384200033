using System;
class Computations{
    static void Main(string[] args){
        int n, sum = 0;

        // For user input
        Console.Write("Enter a natural number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0){
            // Compute sum using while loop
            int i = 1;
            while (i <= n){
                sum += i;
                i++;}

            // Compute sum using formula
            int formulaSum = n * (n + 1) / 2;

            Console.WriteLine("Sum using while loop: " + sum);
            Console.WriteLine("Sum using formula: " + formulaSum);

            if (sum == formulaSum)
                Console.WriteLine("Both results are correct.");}
        else{
            Console.WriteLine("Not a natural number.");
 }}}
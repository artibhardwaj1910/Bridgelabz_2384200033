using System;
class NaturalNumbers{
    static void Main(string[] args){
        int n, sum = 0;

        // For user input
        Console.Write("Enter a natural number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0){
            // For loop
            for (int i = 1; i <= n; i++){
                sum += i;}

            // Calculate sum 
            int formulaSum = n * (n + 1) / 2;

            Console.WriteLine("Sum using for loop: " + sum);
            Console.WriteLine("Sum using formula: " + formulaSum);

            if (sum == formulaSum)
                Console.WriteLine("Both results are correct.");}
        else{
            Console.WriteLine("Not a natural number.");
 }}}
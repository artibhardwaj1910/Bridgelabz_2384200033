using System;
class Rewrite{
    static void Main(string[] args){
        int number;
        long factorial = 1; // To store the factorial result

        // For user input
        Console.Write("Enter a positive integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a positive integer
        if (number >= 0){
            // Calculate factorial
            for (int i = 1; i <= number; i++){
                factorial *= i;}

            // Display the result
            Console.WriteLine("The factorial of {0} is {1}", number, factorial);}
        else{
            // If the user enters a negative number
            Console.WriteLine("Please enter a positive integer.");
 }}}
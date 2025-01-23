using System;
class Prime{
    static void Main(){
        // For user input
        Console.Write("Enter a number to check if it's a prime number: ");
        int number = int.Parse(Console.ReadLine());

        // Prime numbers are greater than 1
        if (number <= 1){
            Console.WriteLine($"{number} is not a prime number.");
            return;}

        // Initialize isPrime to true
        bool isPrime = true;

        // For loop
        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0){
                isPrime = false;
                break; }}

        // Display the result
        if (isPrime){
            Console.WriteLine($"{number} is a prime number.");}
        else{
            Console.WriteLine($"{number} is not a prime number."); }}}
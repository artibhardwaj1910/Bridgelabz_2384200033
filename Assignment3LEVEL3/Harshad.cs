using System;
class Harshad{
    static void Main(string[] args) {
        int number, sum = 0, originalNumber;

        // For user input
        Console.Write("Enter an integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Store the copy of original number 
        originalNumber = number;

        // Calculate the sum of the digits
        while (number != 0){
           
            int digit = number % 10;
            sum += digit;
            number /= 10; }

        // Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0){
            Console.WriteLine("{0} is a Harshad Number.", originalNumber); }
        else {
            Console.WriteLine("{0} is not a Harshad Number.", originalNumber); }}}
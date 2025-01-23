using System;
class Armstrong{
    static void Main(string[] args){
        int number, sum = 0, originalNumber;

        // For user input
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Store the copy of original number in other variable
        originalNumber = number;

        while (number != 0){
            // Find the last digit of the number 
            int digit = number % 10;
            sum += digit * digit * digit;

            // Remove the last digit from the number by dividing by 10
            number /= 10; }
        // Check if the number is armstrong or not
        if (sum == originalNumber){
            Console.WriteLine("{0} is an Armstrong number.", originalNumber);}
        else{
            Console.WriteLine("{0} is not an Armstrong number.", originalNumber); }}}
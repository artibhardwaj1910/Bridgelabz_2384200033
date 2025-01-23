using System;
class NumberOfDigits{
    static void Main(string[] args) {
        int number, count = 0;

        // For user input
        Console.Write("Enter an integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Case where the number is 0
        if (number == 0){
           count = 1; }
        else {
            // While loop to count the digits
           while (number != 0){
              // Remove the last digit from the number by dividing by 10
              number /= 10;

              count++; }}

        // Display the result
        Console.WriteLine("The number has {0} digits.", count); }}
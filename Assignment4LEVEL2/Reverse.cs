using System;
class Reverse{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find the count of digits in the number
        int count = 0;
        int temp = number;
        while (temp != 0){
            count++;
            temp /= 10;}

        // Create an array to store the digits of the number
        int[] digits = new int[count];

        // Store the digits in the array
        temp = number;
        for (int i = 0; i < count; i++){
            digits[i] = temp % 10;
            temp /= 10;}

        // Display the digits in reverse order
        Console.WriteLine("Digits in reverse order: ");
        for (int i = 0; i < count; i++){
            Console.Write(digits[i]);}
        Console.WriteLine(); }}
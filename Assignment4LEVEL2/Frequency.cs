using System;
class Frequency{
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

        // Create a frequency array of size 10 to store the frequency
        int[] frequency = new int[10];

        // Loop through the digits array and calculate the frequency
        for (int i = 0; i < count; i++){
            frequency[digits[i]]++;}

        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit in the number:");
        for (int i = 0; i < 10; i++){
            if (frequency[i] > 0){
                Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
}}}}
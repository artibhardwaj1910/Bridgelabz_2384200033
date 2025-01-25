using System;
class Largest{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Define an array to store the digits of the number
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits and store them in the array
        while (number != 0 && index < maxDigit){
            digits[index] = number % 10; 
            number = number / 10;       
            index++; }

        // Variables to store the largest and second largest digits
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        // Find the largest and second largest digits in the array
        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];}
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];}}

        // Display the largest and second largest digits
        if (secondLargest == int.MinValue){
            Console.WriteLine("There is no second largest digit.");}
        else{
            Console.WriteLine($"The largest digit is: {largest}");
            Console.WriteLine($"The second largest digit is: {secondLargest}"); }}}
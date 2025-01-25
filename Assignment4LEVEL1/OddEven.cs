using System;
class OddEven{
    static void Main(){
        // For user input
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number;

        // Check if the input is a valid integer and a natural number
        if (!int.TryParse(input, out number) || number <= 0){
            Console.WriteLine("Error: Please enter a valid natural number.");
            Return; }

        // Create arrays for even and odd numbers
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];

        // Initialize index variables
        int evenIndex = 0;
        int oddIndex = 0;

        // Loop from 1 to the number to separate odd and even numbers
        for (int i = 1; i <= number; i++){
            if (i % 2 == 0) {
                evenNumbers[evenIndex] = i;
                evenIndex++; }
            else{
                oddNumbers[oddIndex] = i;
                oddIndex++;}}

        // Display the odd numbers array
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++){
            Console.Write(oddNumbers[i] + " ");}

        // Display the even numbers array
        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++){
            Console.Write(evenNumbers[i] + " "); }}}
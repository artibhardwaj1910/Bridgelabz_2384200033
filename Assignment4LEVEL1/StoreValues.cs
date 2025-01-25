using System;
class StoreValues{
    static void Main(){
        // Declare an array of 10 elements
        double[] numbers = new double[10];

        // Declare a variable to store the sum of the numbers
        double total = 0.0;

        // Initialize the index variable
        int index = 0;

        // For user input
        while (true){
            Console.Write("Enter a number (0 or negative number to stop): ");
            double input = Convert.ToDouble(Console.ReadLine());

            // Check if the input is 0 or a negative number
            if (input <= 0){
                break;}

            if (index >= 10){
                Console.WriteLine("Array is full. You can only enter 10 numbers.");
                break;}

            // Store the number in the array and increment the index
            numbers[index] = input;
            index++;}

        // Calculate the total sum 
        for (int i = 0; i < index; i++){
            total += numbers[i];}

        // Display the numbers
        Console.WriteLine("\nThe numbers you entered are:");
        for (int i = 0; i < index; i++){
            Console.WriteLine(numbers[i]);}

        // Display the total sum
        Console.WriteLine("\nThe total sum of the entered numbers is: " + total); }}
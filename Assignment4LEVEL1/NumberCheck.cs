using System;
class NumberCheck{
    static void Main(){
        // Define an integer array
        int[] numbers = new int[5];

        // For user input
        for (int i = 0; i < numbers.Length; i++){
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());}

        // For loop to check the conditions
        for (int i = 0; i < numbers.Length; i++){
            if (numbers[i] > 0){
                if (numbers[i] % 2 == 0){
                    Console.WriteLine("{0} is positive and even.", numbers[i]);}
                else{
                    Console.WriteLine("{0} is positive and odd.", numbers[i]);}}
            else if (numbers[i] < 0){
                Console.WriteLine("{0} is negative.", numbers[i]);}
            else{
                Console.WriteLine("{0} is zero.", numbers[i]);}}

        // Compare the first and last elements of the array
        if (numbers[0] == numbers[4]){
            Console.WriteLine("The first and last elements are equal.");}
        else if (numbers[0] > numbers[4]){
            Console.WriteLine("The first element is greater than the last element.");}
        else{
            Console.WriteLine("The first element is less than the last element."); }}}
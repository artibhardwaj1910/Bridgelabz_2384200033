using System;
class MultiTable{
    static void Main(){
        // Declare an integer variable to store the number input
        Console.Write("Enter a number to display its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Declare an integer array to store the results of multiplication
        int[] table = new int[10];

        // Loop through numbers 1 to 10
        for (int i = 1; i <= 10; i++){
            table[i - 1] = number * i;}

        // Display the multiplication table from the array
        for (int i = 0; i < table.Length; i++){
            Console.WriteLine("{0} * {1} = {2}", number, i + 1, table[i]); }}}
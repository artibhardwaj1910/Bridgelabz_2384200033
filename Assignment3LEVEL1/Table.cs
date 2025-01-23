using System;
class Table{
    static void Main(string[] args){
        int number;

        // For user input
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Display the table
        for (int i = 6; i <= 9; i++){
            Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
 }}}


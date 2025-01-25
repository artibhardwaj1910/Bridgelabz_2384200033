using System;
class Matrix{
    static void Main(){
        // For user input
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        // Create a second array
        int[,] matrix = new int[rows, columns];

        // Take input for each element 
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"Enter element at ({i + 1},{j + 1}): ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine()); }}

        int[] oneDArray = new int[rows * columns];

        // Index variable 
        int index = 0;

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                oneDArray[index] = matrix[i, j];
                index++; }}

        // Display the array
        Console.WriteLine("\nThe elements of the 1D array are:");
        for (int i = 0; i < oneDArray.Length; i++){
            Console.Write(oneDArray[i] + " "); }}}
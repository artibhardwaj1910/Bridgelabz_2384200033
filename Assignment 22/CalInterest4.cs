using System;
using System.IO;
class CalInterest4
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void PerformDivision(int numerator, int denominator)
    {
        try
        {
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }

    static void Method1()
    {
        throw new ArithmeticException("Attempted to divide by zero.");
    }

    static void Method2()
    {
        Method1();
    }

    static void ArrayDivision(int[] arr, int index, int divisor)
    {
        try
        {
            try
            {
                int value = arr[index];
                try
                {
                    int result = value / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter principal amount: ");
            double amount = double.Parse(Console.ReadLine());
            
            Console.Write("Enter interest rate: ");
            double rate = double.Parse(Console.ReadLine());
            
            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());
            
            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest: " + interest);
            
            Console.Write("Enter numerator for division: ");
            int numerator = int.Parse(Console.ReadLine());
            
            Console.Write("Enter denominator for division: ");
            int denominator = int.Parse(Console.ReadLine());
            
            PerformDivision(numerator, denominator);
            
            Method2();
            
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Enter index to access: ");
            int index = int.Parse(Console.ReadLine());
            
            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            
            ArrayDivision(arr, index, divisor);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input: Please enter numeric values.");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}


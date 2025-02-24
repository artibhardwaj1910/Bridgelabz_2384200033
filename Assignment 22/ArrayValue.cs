
using System;
class ArrayValue
{
    static void RetrieveArrayValue(int[] arr, int index)
    {
        if (arr == null)
        {
            throw new NullReferenceException("Array is not initialized!");
        }
        if (index < 0 || index >= arr.Length)
        {
            throw new IndexOutOfRangeException("Invalid index!");
        }
        
        Console.WriteLine($"Value at index {index}: {arr[index]}");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Enter index to retrieve value: ");
            int index = int.Parse(Console.ReadLine());
            
            RetrieveArrayValue(arr, index);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
    }
}


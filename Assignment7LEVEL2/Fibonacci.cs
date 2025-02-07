using System;
namespace FunctionAssignment
{
    class Program
    {
        static void GenerateFibonacci(int n)
        {
            int first = 0, second = 1, next;
            Console.Write($"{first} {second} ");

            for (int i = 3; i <= n; i++)
            {
                next = first + second;
                Console.Write($"{next} ");
                first = second;
                second = next;
            }
        }

        static void Main()
        {
            Console.Write("Enter the number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            GenerateFibonacci(terms);
        }
    }
}


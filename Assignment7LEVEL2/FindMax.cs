using System;

namespace FunctionAssignment
{
    class Program
    {
        static int FindMax(int a, int b, int c)
        {
            if (a > b && a > c) 
            {
                return a;
            }
            else if (b > c) 
            {
                return b;
            }
            else 
            {
                return c;
            }
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = FindMax(num1, num2, num3);
            Console.WriteLine($"The maximum number is: {max}");
        }
    }
}


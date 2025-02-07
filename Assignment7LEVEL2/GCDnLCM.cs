using System;
namespace FunctionAssignment
{
    class Program
    {
        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = FindGCD(num1, num2);
            int lcm = (num1 * num2) / gcd;

            Console.WriteLine($"GCD: {gcd}");
            Console.WriteLine($"LCM: {lcm}");
        }
    }
}


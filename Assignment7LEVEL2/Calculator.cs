using System;
namespace FunctionAssignment
{
    class Program
    {
        static double PerformOperation(double a, double b, char op)
        {
            if (op == '+') 
            {
                return a + b;
            }
            else if (op == '-') 
            {
                return a - b;
            }
            else if (op == '*') 
            {
                return a * b;
            }
            else if (op == '/') 
            {
                if (b != 0) 
                {
                    return a / b;
                }
                return double.NaN;
            }
            return 0;
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"Result: {result}");
        }
    }
}


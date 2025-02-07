using System;
namespace FunctionAssignment
{
    class Program
    {
        static double ToFahrenheit(double celsius) 
        {
            return (celsius * 9 / 5) + 32;
        }

        static double ToCelsius(double fahrenheit) 
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static void Main()
        {
            Console.Write("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Convert to (F)ahrenheit or (C)elsius? ");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'F') 
            {
                Console.WriteLine($"Temperature in Fahrenheit: {ToFahrenheit(temp)}");
            }
            else if (choice == 'C') 
            {
                Console.WriteLine($"Temperature in Celsius: {ToCelsius(temp)}");
            }
        }
    }
}


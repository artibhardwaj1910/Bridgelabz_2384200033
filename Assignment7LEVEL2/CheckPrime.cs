using System;
namespace FunctionAssignment
{
    class Program
    {
        static bool CheckPrime(int num)
        {
            if (num < 2) 
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = CheckPrime(num);
            if (isPrime) 
            {
                Console.WriteLine("It is a prime number.");
            }
            else 
            {
                Console.WriteLine("It is not a prime number.");
            }
        }
    }
}


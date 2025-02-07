using System;
namespace FunctionAssignment
{
    class Program
    {
        static void PlayGame()
        {
            int low = 1, high = 100, guess;
            char response;

            Console.WriteLine("Think of a number between 1 and 100.");
            do
            {
                guess = (low + high) / 2;
                Console.WriteLine($"Is your number {guess}? (Enter 'h' for too high, 'l' for too low, 'c' for correct): ");
                response = Convert.ToChar(Console.ReadLine());

                if (response == 'h') 
                {
                    high = guess - 1;
                }
                else if (response == 'l') 
                {
                    low = guess + 1;
                }

            } while (response != 'c');

            Console.WriteLine("Great! The computer guessed your number.");
        }

        static void Main()
        {
            PlayGame();
        }
    }
}


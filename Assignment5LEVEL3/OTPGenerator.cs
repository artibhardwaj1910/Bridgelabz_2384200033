using System;
using System.Linq;

namespace Assignment05Level3
{
    public class OTPGenerator
    {
        // Method to generate a 6-digit OTP using Math.Random()
        public static int GenerateSixDigitOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000); // Generate random number between 100000 and 999999
        }

        // Method to validate if OTPs in the array are unique
        public static bool AreOTPsUnique(int[] otpArray)
        {
            return otpArray.Distinct().Count() == otpArray.Length;
        }

        static void Main(string[] args)
        {
            // Array to store 10 OTPs
            int[] otpArray = new int[10];

            // Generate 10 OTPs and store in the array
            for (int i = 0; i < otpArray.Length; i++)
            {
                otpArray[i] = GenerateSixDigitOTP();
            }

            // Display the generated OTPs
            Console.WriteLine("Generated OTPs:");
            foreach (int otp in otpArray)
            {
                Console.WriteLine(otp);
            }

            // Validate the uniqueness of the OTPs
            bool areUnique = AreOTPsUnique(otpArray);
            Console.WriteLine($"\nAre all OTPs unique? {areUnique}");
        }
    }
}


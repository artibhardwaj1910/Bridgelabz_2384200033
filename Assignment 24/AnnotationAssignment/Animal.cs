using System;
namespace Annotation{
public class Animal
{
        // Method that will be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Child class Dog that overrides the MakeSound method
    public class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate a Dog object
            Dog dog = new Dog();

            // Call the MakeSound method
            dog.MakeSound();  // Output: Woof! Woof!
        }
    }
}}


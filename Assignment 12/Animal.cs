using System;

namespace InheritenceAssignment
{
    // Superclass Animal
    class Animal
    {
        protected string name;
        protected int age;

        // Constructor to initialize name and age
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Virtual method to be overridden by subclasses
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Subclass Dog inheriting from Animal
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Subclass Cat inheriting from Animal
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    // Subclass Bird inheriting from Animal
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps.");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of different subclasses
            Dog dog = new Dog("Buddy", 3);
            Cat cat = new Cat("Whiskers", 2);
            Bird bird = new Bird("Tweety", 1);

            // Calling MakeSound method to demonstrate polymorphism
            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
        }
    }
}

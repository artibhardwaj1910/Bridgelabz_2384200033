using System;
namespace ClassObjectLevel01
{
    public class Circle
    {
        //  field to store radius
        private double radius;

        // Constructor to initialize
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Method to calculate the area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        // Method to display
        public void DisplayDetails()
        {
            Console.WriteLine($"Circle with radius {radius}:");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Circumference: {CalculateCircumference()}");
        }
    }

    // Main class to demonstrate the usage of Circle class
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a object
            Circle circle1 = new Circle(5);

            // Displaying circle details
            circle1.DisplayDetails();
        }
    }
}


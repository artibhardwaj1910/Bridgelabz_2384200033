using System;

namespace InheritenceAssignment
{
    // Base class Vehicle
    class Vehicle
    {
        protected int maxSpeed;
        protected string fuelType;

        // Constructor to initialize Vehicle attributes
        public Vehicle(int maxSpeed, string fuelType)
        {
            this.maxSpeed = maxSpeed;
            this.fuelType = fuelType;
        }

        // Virtual method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
            Console.WriteLine("Fuel Type: " + fuelType);
        }
    }

    // Subclass Car inheriting from Vehicle
    class Car : Vehicle
    {
        private int seatCapacity;

        // Constructor to initialize Car attributes
        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
        {
            this.seatCapacity = seatCapacity;
        }

        // Overriding DisplayInfo to include Car-specific attributes
        public override void DisplayInfo()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
            Console.WriteLine("Fuel Type: " + fuelType);
            Console.WriteLine("Seat Capacity: " + seatCapacity);
        }
    }

    // Subclass Truck inheriting from Vehicle
    class Truck : Vehicle
    {
        private int payloadCapacity;

        // Constructor to initialize Truck attributes
        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
        {
            this.payloadCapacity = payloadCapacity;
        }

        // Overriding DisplayInfo to include Truck-specific attributes
        public override void DisplayInfo()
        {
            Console.WriteLine("Truck Details:");
            Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
            Console.WriteLine("Fuel Type: " + fuelType);
            Console.WriteLine("Payload Capacity: " + payloadCapacity + " kg");
        }
    }

    // Subclass Motorcycle inheriting from Vehicle
    class Motorcycle : Vehicle
    {
        private bool hasSidecar;

        // Constructor to initialize Motorcycle attributes
        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
        {
            this.hasSidecar = hasSidecar;
        }

        // Overriding DisplayInfo to include Motorcycle-specific attributes
        public override void DisplayInfo()
        {
            Console.WriteLine("Motorcycle Details:");
            Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
            Console.WriteLine("Fuel Type: " + fuelType);
            Console.WriteLine("Has Sidecar: " + (hasSidecar ? "Yes" : "No"));
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of different vehicle types
            Vehicle car = new Car(180, "Petrol", 5);
            Vehicle truck = new Truck(120, "Diesel", 10000);
            Vehicle motorcycle = new Motorcycle(150, "Petrol", false);

            // Storing objects in an array of Vehicle type
            Vehicle[] vehicles = { car, truck, motorcycle };

            // Using polymorphism to call DisplayInfo() dynamically
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}

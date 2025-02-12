using System;

namespace InheritenceAssignment
{
    // Superclass Vehicle
    class Vehicle
    {
        protected int maxSpeed;
        protected string model;

        // Constructor to initialize Vehicle attributes
        public Vehicle(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }

        // Method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
        }
    }

    // Interface Refuelable
    interface Refuelable
    {
        void Refuel(); // Method to be implemented by PetrolVehicle
    }

    // Subclass ElectricVehicle inheriting from Vehicle
    class ElectricVehicle : Vehicle
    {
        private int batteryCapacity;

        // Constructor to initialize ElectricVehicle attributes
        public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
            : base(maxSpeed, model)
        {
            this.batteryCapacity = batteryCapacity;
        }

        // Method to charge the vehicle
        public void Charge()
        {
            Console.WriteLine("Vehicle Type: Electric Vehicle");
            DisplayVehicleDetails();
            Console.WriteLine("Battery Capacity: " + batteryCapacity + " kWh");
            Console.WriteLine("Charging the vehicle...");
        }
    }

    // Subclass PetrolVehicle inheriting from Vehicle and implementing Refuelable interface
    class PetrolVehicle : Vehicle, Refuelable
    {
        private int fuelCapacity;

        // Constructor to initialize PetrolVehicle attributes
        public PetrolVehicle(int maxSpeed, string model, int fuelCapacity)
            : base(maxSpeed, model)
        {
            this.fuelCapacity = fuelCapacity;
        }

        // Implementing Refuel() method
        public void Refuel()
        {
            Console.WriteLine("Vehicle Type: Petrol Vehicle");
            DisplayVehicleDetails();
            Console.WriteLine("Fuel Capacity: " + fuelCapacity + " liters");
            Console.WriteLine("Refueling the vehicle...");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of ElectricVehicle and PetrolVehicle
            ElectricVehicle ev = new ElectricVehicle(150, "Tesla Model 3", 75);
            PetrolVehicle pv = new PetrolVehicle(180, "Honda City", 40);

            // Displaying details and actions
            ev.Charge();
            Console.WriteLine();
            pv.Refuel();
        }
    }
}

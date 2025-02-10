using System;
namespace KeywordAssignment
{
    class Vehicle
    {
        private static double registrationFee = 500.0; 
        private readonly string registrationNumber; 
        private string ownerName;
        private string vehicleType;

        public Vehicle(string ownerName, string vehicleType, string registrationNumber)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
            this.registrationNumber = registrationNumber;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }

        public void DisplayVehicleDetails()
        {
            if (this is Vehicle) 
            {
                Console.WriteLine($"Owner: {ownerName}");
                Console.WriteLine($"Vehicle Type: {vehicleType}");
                Console.WriteLine($"Registration Number: {registrationNumber}");
                Console.WriteLine($"Registration Fee: {registrationFee}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle vehicle1 = new Vehicle("John Doe", "Car", "XYZ123");
            vehicle1.DisplayVehicleDetails();
            Vehicle.UpdateRegistrationFee(550.0);
            vehicle1.DisplayVehicleDetails();
        }
    }
}


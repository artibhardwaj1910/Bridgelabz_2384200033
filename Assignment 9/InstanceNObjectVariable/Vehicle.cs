using System;
namespace InstanceNObjectVariable{
	class Vehicle{
		
        // Class variable
        private static double registrationFee = 500.00;

        // Instance variables
        private string ownerName;
        private string vehicleType;

        // Constructor to initialize instance variable
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Getters and Setters
        public string GetOwnerName()
        {
            return ownerName;
        }

        public void SetOwnerName(string ownerName)
        {
            this.ownerName = ownerName;
        }

        public string GetVehicleType()
        {
            return vehicleType;
        }

        public void SetVehicleType(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        // Instance Method to Display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner Name: {ownerName}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Registration Fee: ${registrationFee}");
            Console.WriteLine();
        }

        // Class Method to Update the registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }

    }
}
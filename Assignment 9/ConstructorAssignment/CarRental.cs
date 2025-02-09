using System;

namespace ConstructorAssignment
{
    // Class representing a car rental
    class CarRental
    {
        // Private attributes
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double rentalRate = 50.0; // Example rental rate per day

        // Constructor to initialize rental details
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        // Getter and setter for customerName
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        // Getter and setter for carModel
        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }

        // Getter and setter for rentalDays
        public int RentalDays
        {
            get { return rentalDays; }
            set { rentalDays = value; }
        }

        // Method to calculate the total rental cost
        public double CalculateTotalCost()
        {
            return rentalDays * rentalRate;
        }

        // Method to display rental details
        public void DisplayRentalDetails()
        {
            double totalCost = CalculateTotalCost();
            Console.WriteLine($"Customer: {customerName}");
            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Rental Days: {rentalDays}");
            Console.WriteLine($"Total Rental Cost: ${totalCost}");
        }
    }
}

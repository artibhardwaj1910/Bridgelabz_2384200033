using System;
using System.Collections.Generic;

// Interface for Insurance
public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Abstract Vehicle class
public abstract class Vehicle : IInsurable
{
    public string VehicleNumber { get; private set; }
    public string Type { get; protected set; }
    public double RentalRate { get; protected set; }
    private string InsurancePolicyNumber; // Encapsulation applied

    protected Vehicle(string vehicleNumber, double rentalRate, string policyNumber)
    {
        VehicleNumber = vehicleNumber;
        RentalRate = rentalRate;
        InsurancePolicyNumber = policyNumber;
    }

    // Abstract method for rental cost calculation
    public abstract double CalculateRentalCost(int days);

    // Implementing IInsurable methods
    public virtual double CalculateInsurance()
    {
        return RentalRate * 0.05; // Generic insurance cost calculation
    }

    public string GetInsuranceDetails()
    {
        return $"Insurance Policy Number: {new string('*', InsurancePolicyNumber.Length)}"; // Masked for security
    }
}

// Car class
public class Car : Vehicle
{
    public Car(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, rentalRate, policyNumber)
    {
        Type = "Car";
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }
}

// Bike class
public class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, rentalRate, policyNumber)
    {
        Type = "Bike";
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate * 0.8; // Discounted rate for bikes
    }
}

// Truck class
public class Truck : Vehicle
{
    public Truck(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, rentalRate, policyNumber)
    {
        Type = "Truck";
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate * 1.5; // Higher rate for trucks
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", 50, "POLICY123"),
            new Bike("BIKE456", 20, "POLICY456"),
            new Truck("TRUCK789", 100, "POLICY789")
        };

        int rentalDays = 5;

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle Type: {vehicle.Type}");
            Console.WriteLine($"Vehicle Number: {vehicle.VehicleNumber}");
            Console.WriteLine($"Rental Cost for {rentalDays} days: ${vehicle.CalculateRentalCost(rentalDays)}");
            Console.WriteLine($"Insurance Cost: ${vehicle.CalculateInsurance()}");
            Console.WriteLine(vehicle.GetInsuranceDetails());
            Console.WriteLine(new string('-', 40));
        }
    }
}


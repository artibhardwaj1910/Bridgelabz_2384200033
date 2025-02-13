using System;
public abstract class Vehicle
{
    // Private Fields to implement encapsulation
    private int _vehicleId;
    private string _driverName;
    private double _ratePerKm;

    // Public properties to access private fields
    public int VehicleId 
    { 
        get { return _vehicleId; }
        set { _vehicleId = value; }
    }

    public string DriverName 
    { 
        get { return _driverName; }
        set { _driverName = value; }
    }

    public double RatePerKm 
    { 
        get { return _ratePerKm; }
        set { _ratePerKm = value; }
    }

    // Abstract Method
    public abstract double CalculateFare(double distance);

    // Concrete Method
    public string GetVehicleDetails()
    {
        return $"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per km: {RatePerKm}";
    }
}

public class Car : Vehicle
{
    public Car(int vehicleId, string driverName, double ratePerKm)
    {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    // Override CalculateFare for Car
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

public class Bike : Vehicle
{
    public Bike(int vehicleId, string driverName, double ratePerKm)
    {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }
    // Override CalculateFare for Bike
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

public class Auto : Vehicle
{
    public Auto(int vehicleId, string driverName, double ratePerKm)
    {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    // Override CalculateFare for Auto
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

public class CarWithGPS : Car, IGPS
{
    private string _currentLocation;

    public CarWithGPS(int vehicleId, string driverName, double ratePerKm, string initialLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        _currentLocation = initialLocation;
    }

    public string GetCurrentLocation()
    {
        return _currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        _currentLocation = newLocation;
    }}

public class BikeWithGPS : Bike, IGPS
{
    private string _currentLocation;

    public BikeWithGPS(int vehicleId, string driverName, double ratePerKm, string initialLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        _currentLocation = initialLocation;
    }

    public string GetCurrentLocation()
    {
        return _currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        _currentLocation = newLocation;
    }
}

public class AutoWithGPS : Auto, IGPS
{
    private string _currentLocation;

    public AutoWithGPS(int vehicleId, string driverName, double ratePerKm, string initialLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        _currentLocation = initialLocation;
    }
    public string GetCurrentLocation()
    {
        return _currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        _currentLocation = newLocation;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create different vehicles
        Vehicle car = new Car(101, "John Doe", 10.5);
        Vehicle bike = new Bike(102, "Jane Smith", 5.0);
        Vehicle auto = new Auto(103, "Jim Brown", 7.0);

        // Calculate fares dynamically using polymorphism
        Console.WriteLine($"Car Fare for 10 km: ${car.CalculateFare(10)}");
        Console.WriteLine($"Bike Fare for 10 km: ${bike.CalculateFare(10)}");
        Console.WriteLine($"Auto Fare for 10 km: ${auto.CalculateFare(10)}");

        // Use vehicle reference to handle dynamic behavior
        ProcessVehicle(car, 15);
        ProcessVehicle(bike, 5);
        ProcessVehicle(auto, 12);
    }

    static void ProcessVehicle(Vehicle vehicle, double distance)
    {
        Console.WriteLine($"Processing {vehicle.GetVehicleDetails()} for {distance} km");
        Console.WriteLine($"Total Fare: ${vehicle.CalculateFare(distance)}");
    }

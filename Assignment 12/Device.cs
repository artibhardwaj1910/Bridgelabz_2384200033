using System;

namespace InheritenceAssignment
{
    // Base class Device
    class Device
    {
        protected int deviceId;
        protected string status;

        // Constructor to initialize Device attributes
        public Device(int deviceId, string status)
        {
            this.deviceId = deviceId;
            this.status = status;
        }

        // Method to display device status
        public void DisplayStatus()
        {
            Console.WriteLine("Device ID: " + deviceId);
            Console.WriteLine("Status: " + status);
        }
    }

    // Subclass Thermostat inheriting from Device
    class Thermostat : Device
    {
        private double temperatureSetting;

        // Constructor to initialize Thermostat attributes
        public Thermostat(int deviceId, string status, double temperatureSetting) : base(deviceId, status)
        {
            this.temperatureSetting = temperatureSetting;
        }

        // Method to display thermostat details
        public void DisplayThermostatStatus()
        {
            DisplayStatus();
            Console.WriteLine("Temperature Setting: " + temperatureSetting + "°C");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating an object of Thermostat
            Thermostat thermostat = new Thermostat(101, "Online", 22.5);

            // Displaying thermostat details
            thermostat.DisplayThermostatStatus();
        }
    }
}

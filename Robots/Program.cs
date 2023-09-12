using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    using System;

    // Model: Define the Robot class to represent the different types of robots.
    class Robot
    {
        public string Model { get; }
        public string Color { get; set; }
        public string Microchip { get; }
        public bool HasWifi { get; }
        public int BatteryCapacity { get; }
        public int NumberOfWheels { get; }
        public double SoapTankCapacity { get; }

        // Constructor for small robots
        public Robot(string microchip)
        {
            Model = "Small Robot";
            Color = "White";
            Microchip = microchip;
            HasWifi = false;
            BatteryCapacity = 0; // Small robots cannot have batteries
            NumberOfWheels = 0;
            SoapTankCapacity = 0.0;
        }

        // Constructor for large robots
        public Robot(string microchip, bool hasWifi, int batteryCapacity, int numberOfWheels)
        {
            Model = "Large Robot";
            Color = "White";
            Microchip = microchip;
            HasWifi = hasWifi;
            BatteryCapacity = batteryCapacity;
            NumberOfWheels = numberOfWheels;
            SoapTankCapacity = 0.0; // Large robots cannot have a soap tank
        }

        // Constructor for cleaning robots
        public Robot(string microchip, string color, double soapTankCapacity)
        {
            Model = "Cleaning Robot";
            Color = color;
            Microchip = microchip;
            HasWifi = false;
            BatteryCapacity = 0; // Cleaning robots cannot have batteries
            NumberOfWheels = 0;
            SoapTankCapacity = 2.3; // Fixed soap tank capacity for cleaning robots
        }

        // Method to display robot information
        public void DisplayRobotInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Microchip: {Microchip}");
            Console.WriteLine($"Has WiFi: {HasWifi}");
            Console.WriteLine($"Battery Capacity: {BatteryCapacity}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Soap Tank Capacity: {SoapTankCapacity} liters");
        }
    }

    // Controller: Implement the main program logic
    class Program
    {
        static void Main(string[] args)
        {
            // Create different types of robots using constructors
            Robot smallRobot1 = new Robot("RX");
            Robot smallRobot2 = new Robot("QT");
            Robot largeRobot1 = new Robot("RX", true, 150, 4);
            Robot cleaningRobot = new Robot("RX", "Blue", 2.3);

            // Display information about the robots
            Console.WriteLine("Small Robot 1:");
            smallRobot1.DisplayRobotInfo();
            Console.WriteLine();

            Console.WriteLine("Small Robot 2:");
            smallRobot2.DisplayRobotInfo();
            Console.WriteLine();

            Console.WriteLine("Large Robot 1:");
            largeRobot1.DisplayRobotInfo();
            Console.WriteLine();

            Console.WriteLine("Cleaning Robot:");
            cleaningRobot.DisplayRobotInfo();
        }
    }

}

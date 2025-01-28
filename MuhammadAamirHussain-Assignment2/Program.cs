using MuhammadAamirHussain_Assignment2.Interfaces;
using MuhammadAamirHussain_Assignment2.Factories;
using MuhammadAamirHussain_Assignment2.Models;
using System;

namespace MuhammadAamirHussain_Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            MotorcycleFactory motorcycleFactory = new MotorcycleFactory();

            // Create a few car models
            CarImpl car1 = carFactory.CreateCar("Maruti Suzuki", "Alto", 2022, 10000, 4);
            CarImpl car2 = carFactory.CreateCar("Tata", "Nexon", 2023, 5000, 4);
            CarImpl car3 = carFactory.CreateCar("Hyundai", "Creta", 2021, 15000, 4);

            // Create a few motorcycle models
            MotorcycleImpl motorcycle1 = motorcycleFactory.CreateMotorcycle("Royal Enfield", "Classic 350", 2020, 12000, "Single-Cylinder");
            MotorcycleImpl motorcycle2 = motorcycleFactory.CreateMotorcycle("Bajaj", "Pulsar 150", 2021, 8000, "Twin-Spark");
            MotorcycleImpl motorcycle3 = motorcycleFactory.CreateMotorcycle("TVS", "Apache RTR 160", 2022, 5000, "Single-Cylinder");

            // Store cars in a list
            var cars = new List<CarImpl> { car1, car2, car3 };
            var motorcycles = new List<MotorcycleImpl> { motorcycle1, motorcycle2, motorcycle3 };

            // Display and test each car's engine status
            Console.WriteLine("Car Details and Engine Status:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
                car.StartEngine();
                Console.WriteLine($"{car.Model} engine status: " + (car.IsEngineOn() ? "On" : "Off"));
                car.StopEngine();
                Console.WriteLine($"{car.Model} engine status: " + (car.IsEngineOn() ? "On" : "Off"));
                Console.WriteLine();
            }

            // Display and test each motorcycle's engine status
            Console.WriteLine("Motorcycle Details and Engine Status:");
            foreach (var motorcycle in motorcycles)
            {
                Console.WriteLine(motorcycle);
                motorcycle.StartEngine();
                Console.WriteLine($"{motorcycle.Model} engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
                motorcycle.StopEngine();
                Console.WriteLine($"{motorcycle.Model} engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
                Console.WriteLine();
            }
        }

    }

}
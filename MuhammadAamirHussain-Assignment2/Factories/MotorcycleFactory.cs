using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MuhammadAamirHussain_Assignment2.Interfaces;
using MuhammadAamirHussain_Assignment2.Models;

namespace MuhammadAamirHussain_Assignment2.Factories
{
    public class MotorcycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string model, int year, double mileage)
        {
            // Added engineType parameter to match the constructor of MotorcycleImpl
            return new MotorcycleImpl(model, year, mileage, "DefaultEngineType");
        }

        public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, double mileage, string engineType)
        {
            return new MotorcycleImpl(model, year, mileage, engineType);
        }
    }

}
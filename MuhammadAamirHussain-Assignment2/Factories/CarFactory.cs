using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MuhammadAamirHussain_Assignment2.Interfaces;
using MuhammadAamirHussain_Assignment2.Models;

namespace MuhammadAamirHussain_Assignment2.Factories
{



    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string model, int year, double mileage)
        {
            return new CarImpl(model, year, mileage, 4); // Assuming default 4 doors
        }

        public CarImpl CreateCar(string make, string model, int year, double mileage, int doors)
        {
            return new CarImpl(model, year, mileage, doors);
        }
    }
}

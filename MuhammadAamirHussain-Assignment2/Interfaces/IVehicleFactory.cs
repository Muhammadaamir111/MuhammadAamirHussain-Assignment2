using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammadAamirHussain_Assignment2.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string model, int year, double mileage);
    }
}
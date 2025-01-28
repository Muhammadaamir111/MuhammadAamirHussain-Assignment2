using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammadAamirHussain_Assignment2.Interfaces
{
    public interface IVehicle
    {
        string Model { get; set; }
        int Year { get; set; }
        double Mileage { get; set; }
        void StartEngine();
        void StopEngine();
        bool IsEngineOn();
    }
}

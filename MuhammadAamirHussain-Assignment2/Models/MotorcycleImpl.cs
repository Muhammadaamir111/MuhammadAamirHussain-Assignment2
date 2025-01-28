using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MuhammadAamirHussain_Assignment2.Interfaces;

namespace MuhammadAamirHussain_Assignment2.Models
{
    public class MotorcycleImpl : IMotorcycle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; }
        private bool engineOn;

        public MotorcycleImpl(string model, int year, double mileage, string engineType)
        {
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType;
            engineOn = false;
        }

        public void StartEngine()
        {
            engineOn = true;
        }

        public void StopEngine()
        {
            engineOn = false;
        }

        public bool IsEngineOn()
        {
            return engineOn;
        }

        public override string ToString()
        {
            return $"{Model} {Year} with {Mileage} km and {EngineType} engine.";
        }
    }
}

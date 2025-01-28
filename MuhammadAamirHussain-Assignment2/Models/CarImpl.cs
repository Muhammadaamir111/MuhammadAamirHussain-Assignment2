using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MuhammadAamirHussain_Assignment2.Interfaces;

namespace MuhammadAamirHussain_Assignment2.Models
{
    public class CarImpl : ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; }
        private bool engineOn;

        public CarImpl(string model, int year, double mileage, int doors)
        {
            Model = model;
            Year = year;
            Mileage = mileage;
            Doors = doors;
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

        public void Drive(double distance)
        {
            if (!engineOn)
                throw new InvalidOperationException("Engine is not on.");

            Mileage += distance;
        }

        public override string ToString()
        {
            return $"{Model} {Year} with {Mileage} km and {Doors} doors.";
        }
    }
}


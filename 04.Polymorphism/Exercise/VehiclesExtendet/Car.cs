using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double CarSummerConsump = 0.9;

        public Car(double fuelQuantity, double fuelConsump, double tankCapacity) : base(fuelQuantity, fuelConsump, CarSummerConsump, tankCapacity)
        {
        }
    }
}

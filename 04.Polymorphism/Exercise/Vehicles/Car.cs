using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double SummerConsump = 0.9;
        public Car(double fuelQuantity, double fuelConsump) : base(fuelQuantity, fuelConsump, SummerConsump)
        {
        }
    }
}

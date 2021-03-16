using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Bus : Vehicle
    {
        private const double withPeopleConsump = 1.4;

        public Bus(double fuelQuantity, double fuelConsump, double tankCapacity) : base(fuelQuantity, fuelConsump, withPeopleConsump, tankCapacity)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double summerConsump = 1.6;

        public Truck(double fuelQuantity, double fuelConsump) : base(fuelQuantity, fuelConsump, summerConsump)
        {
        }
         

        public override void Refueling(double refillFuel)
        {
            base.Refueling(refillFuel * 0.95);
        }
    }
}

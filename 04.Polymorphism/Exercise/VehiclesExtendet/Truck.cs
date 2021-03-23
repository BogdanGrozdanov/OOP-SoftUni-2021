using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double TrucksummerConsump = 1.6;

        public Truck(double fuelQuantity, double fuelConsump, double tankCapacity) : base(fuelQuantity, fuelConsump, TrucksummerConsump, tankCapacity)
        {
        }

        public override void Refueling(double refillFuel)
        {
            var totalFuel = FuelQuantity + refillFuel;
            if (refillFuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (TankCapacity < totalFuel)
            {
                throw new InvalidOperationException($"Cannot fit {refillFuel} fuel in the tank");
            }
            FuelQuantity += refillFuel * 0.95;
        }
    }
}

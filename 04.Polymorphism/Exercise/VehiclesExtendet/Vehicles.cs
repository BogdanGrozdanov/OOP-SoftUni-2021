using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsump, double summerConsump, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
            this.FuelConsumption = fuelConsump;
            this.SummerConsump = summerConsump;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        private double SummerConsump { get; set; }


        public void Driving(double distance)
        {
            double neededFuel = distance * (FuelConsumption + SummerConsump);
            if (neededFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }
            this.FuelQuantity -= neededFuel;
        }
        public virtual void DrivingEmpty(double distance)
        {
            double neededFuel = distance * FuelConsumption;
            if (neededFuel > FuelQuantity)
            {
                throw new Exception($"{GetType().Name} needs refueling");
            }
            FuelQuantity -= neededFuel;
        }

        public virtual void Refueling(double refillFuel)
        {
            var totalFuel = FuelQuantity + refillFuel;
            if (refillFuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (TankCapacity < totalFuel)
            {
                throw new ArgumentException($"Cannot fit {refillFuel} fuel in the tank");
            }
            FuelQuantity += refillFuel;
        }
    }
}

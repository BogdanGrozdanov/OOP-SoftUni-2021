using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {


        protected Vehicle(double fuelQuantity, double fuelConsump, double summerConsump)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsump;
            this.SummerConsump = summerConsump;
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

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

        public virtual void Refueling(double refillFuel)
        {
            FuelQuantity += refillFuel;
        }
    }

}

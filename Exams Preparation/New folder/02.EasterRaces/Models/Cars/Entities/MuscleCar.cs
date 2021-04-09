using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const int DefaultcubicCentimeters = 5000;
        private const int DefaulMinHorsePower = 400;
        private const int DefaulMaxHorsePower = 600;


        public MuscleCar(string model, int horsePower) : base(model, horsePower, DefaultcubicCentimeters, DefaulMinHorsePower, DefaulMaxHorsePower)
        {
        }
    }
}

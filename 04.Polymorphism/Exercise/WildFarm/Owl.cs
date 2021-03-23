using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double OwlModifier = 0.25;

        private static HashSet<string> owlAllowedFood = new HashSet<string> { nameof(Meat) };

        public Owl(string name, double weight, double wingSize) : base(name, weight, owlAllowedFood, OwlModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}

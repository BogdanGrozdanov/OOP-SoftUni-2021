using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private const double MouseModifier = 0.10;

        private static HashSet<string> allowedFood = new HashSet<string>
        {
            nameof(Fruit),
            nameof(Vegetable)
        };
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, allowedFood, MouseModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

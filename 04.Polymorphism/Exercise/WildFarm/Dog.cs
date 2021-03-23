using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private const double DogModifier = 0.40;

        private static HashSet<string> allowedFood = new HashSet<string> { nameof(Meat) };

        public Dog(string name, double weight, string livingRegion) : base(name, weight, allowedFood, DogModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; private set; }

        protected Feline(string name, double weight, HashSet<string> allowedFood, double weightModifier, string livingRegion, string breed) : base(name, weight, allowedFood, weightModifier, livingRegion)
        {
            this.Breed = breed;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {FoodEaten}]";
        }

    }
}

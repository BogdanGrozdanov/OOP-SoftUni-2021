using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private const double CatModifier = 0.30;

        private static HashSet<string> allowedFood = new HashSet<string> { nameof(Meat), nameof(Vegetable) };

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, allowedFood, CatModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        
    }
}

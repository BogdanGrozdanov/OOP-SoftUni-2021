using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private const double TigerModifier = 1.0;

        private static HashSet<string> allowedFood = new HashSet<string> { nameof(Meat) };

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, allowedFood, TigerModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}

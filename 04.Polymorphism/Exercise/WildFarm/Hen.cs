using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        private const double HenModifier = 0.35;

        private static HashSet<string> henAllowedFood = new HashSet<string>
        {
            nameof(Meat) ,
            nameof(Fruit),
            nameof(Vegetable),
            nameof(Seeds)
        };

        public Hen(string name, double weight, double wingSize) : base(name, weight, henAllowedFood, HenModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}

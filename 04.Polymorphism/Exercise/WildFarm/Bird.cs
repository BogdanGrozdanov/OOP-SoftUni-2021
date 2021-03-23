using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; private set; }

        protected Bird(string name, double weight, HashSet<string> allowedFood, double weightModifier, double wingSize) : base(name, weight, allowedFood, weightModifier)
        {
            WingSize = wingSize;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}

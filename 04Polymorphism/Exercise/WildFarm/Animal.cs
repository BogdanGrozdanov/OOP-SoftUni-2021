using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        private double WeightModifier { get; set; }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        private HashSet<string> AllowedFood { get; set; }

        public Animal(string name, double weight, HashSet<string> allowedFood, double weightModifier)
        {
            Name = name;
            Weight = weight;
            AllowedFood = allowedFood;
            WeightModifier = weightModifier;
        }
        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            var typeFood = food.GetType().Name;
            if (!AllowedFood.Contains(typeFood))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {typeFood}!");
            }
            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightModifier;
        }
       
    }
}

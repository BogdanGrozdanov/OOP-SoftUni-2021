using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private readonly string name;
        private readonly string favouriteFood;
        public Animal(string name, string food)
        {
            this.name = name;
            this.favouriteFood = food;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovourite food is {favouriteFood}";
        }
    }
}

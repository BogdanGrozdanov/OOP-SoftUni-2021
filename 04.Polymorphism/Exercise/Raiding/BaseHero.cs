using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; private set; }
        public int Power { get; private set; }

        public BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public virtual string CastAbility()
        {
            return "string.empty";
        }

    }
}

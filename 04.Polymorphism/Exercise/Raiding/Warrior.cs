using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int WariorPower = 100;

        public Warrior(string name) : base(name, WariorPower)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {WariorPower} damage";
        }
    }
}

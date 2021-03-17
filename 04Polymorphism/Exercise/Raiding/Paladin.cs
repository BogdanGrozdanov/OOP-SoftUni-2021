﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int PaladinPower = 100;
        public Paladin(string name) : base(name, PaladinPower)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {PaladinPower}";

        }
    }
}

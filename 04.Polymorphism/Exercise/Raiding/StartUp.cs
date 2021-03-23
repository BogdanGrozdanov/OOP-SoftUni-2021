using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> allHero = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            while (allHero.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                BaseHero hero = CreatHero(type, name);
                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
                allHero.Add(hero);
            }



            int bossHealt = int.Parse(Console.ReadLine());
            foreach (BaseHero hero in allHero)
            {
                Console.WriteLine(hero.CastAbility());
                bossHealt -= hero.Power;
            }
            if (bossHealt <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreatHero(string type, string name)
        {
            BaseHero hero = null;
            if (type == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if (type == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (type == nameof(Rogue))
            {
                hero = new Rogue(name);
            }
            else if (type == nameof(Warrior))
            {
                hero = new Warrior(name);
            }

            return hero;

        }
    }
}

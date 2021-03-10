using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthData = new List<IBirthable>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                var type = input[0];
                if (type == nameof(Citizen))
                {
                    string name = input[1];
                    string age = input[2];
                    string id = input[3];
                    string birthdate = input[4];

                    birthData.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == nameof(Pet))
                {
                    string name = input[1];
                    string id = input[2];
                    birthData.Add(new Pet(name, id));
                }
            }
            string findDate = Console.ReadLine();

            List<IBirthable> filtred = birthData.Where(p => p.Birthdate.EndsWith(findDate)).ToList();
            foreach (var item in filtred)
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}

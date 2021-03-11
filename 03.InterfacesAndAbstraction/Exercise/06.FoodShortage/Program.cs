using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> validBayers = new Dictionary<string, IBuyer>();
            for (int i = 0; i < line; i++)
            {
                var inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputData.Length == 4)
                {
                    var name = inputData[0];
                    var age = inputData[1];
                    var id = inputData[2];
                    var birthdate = inputData[3];
                    validBayers[name] = (new Citizen(name, age, id, birthdate));
                }
                else if (inputData.Length == 3)
                {
                    var name = inputData[0];
                    var age = inputData[1];
                    var group = inputData[2];
                    validBayers[name] = (new Rebel(name, age, group));
                }
            }
            while (true)
            {
                var comand = Console.ReadLine();
                if (comand == "End")
                {
                    break;
                }
                if (!validBayers.ContainsKey(comand))
                {
                    continue;
                }
                IBuyer buyer = validBayers[comand];
                buyer.BuyFood();
            }
            var total = validBayers.Values.Sum(b => b.Food);
            Console.WriteLine(total);
        }
    }
}

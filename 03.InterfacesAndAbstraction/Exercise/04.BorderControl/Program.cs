using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<IIds> id = new List<IIds>();

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                if (input.Length == 2)
                {
                    id.Add(new Robot(input[0],input[1]));
                }
                else
                {
                    id.Add(new Citizens(input[0],input[1],input[2]));
                }
            }
            var failId = Console.ReadLine();
            var filtredId = id.Where(p=>p.Id.EndsWith(failId)).ToList();
            foreach (var item in filtredId)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}

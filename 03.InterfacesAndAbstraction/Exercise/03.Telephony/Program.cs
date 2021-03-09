using System;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i].Length < 10)
                {
                    try
                    {
                        IStationaryPhone phone = new StationaryPhone(inputNumbers[i]);
                        Console.WriteLine(phone.MakeCall());

                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                else
                {
                    try
                    {
                        ISmartphone phone = new Smartphone(inputNumbers[i]);
                        Console.WriteLine(phone.MakeCall());
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }

            }

            var inputURL = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputURL.Length; i++)
            {
                try
                {
                    ISmartphone phone = new Smartphone(string.Empty, inputURL[i]);
                    Console.WriteLine(phone.Browsing());
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}

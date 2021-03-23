using System;

namespace Stealer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            var result = spy.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}

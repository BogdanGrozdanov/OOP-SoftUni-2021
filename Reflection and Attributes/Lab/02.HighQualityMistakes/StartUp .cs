using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            var result =spy.AnalyzeAccessModifiers("Hacker");
            Console.WriteLine(result);
        }
    }
}

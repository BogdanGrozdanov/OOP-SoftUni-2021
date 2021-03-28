using System;

namespace Exercsice
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(lenght, width, height);
                var area = box.SurfaceArea(box);
                var lateral = box.LateralSurfaceArea(box);
                var volume = box.Volume(box);
                Console.WriteLine($"Surface Area - {area:F2}");
                Console.WriteLine($"Lateral Surface Area - {lateral:F2}");
                Console.WriteLine($"Volume - {volume:F2}");
            }
            catch (ArgumentException ax)
            {
                Console.WriteLine(ax.Message);
            }
            
        }
    }
}

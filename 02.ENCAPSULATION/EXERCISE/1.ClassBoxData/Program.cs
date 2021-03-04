using System;
namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(lenght, width, height);

                double surfaceArea = box.SurfaceArea(box);
                double lateralSurfaceArea = box.LateralSurfaceArea(box);
                double volume = box.Volume(box);

                Console.WriteLine($"Surface Area - {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
                Console.WriteLine($"Volume - {volume:f2}");
            }
            catch ( ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

    }
}

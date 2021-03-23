using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreatVehicle();
            Vehicle truck = CreatVehicle();

            var numberOfComands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfComands; i++)
            {
                var comands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var comand = comands[0];
                var type = comands[1];
                double parametar = double.Parse(comands[2]);
                if (comand == "Drive")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Driving(parametar);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Driving(parametar);
                        }
                        Console.WriteLine($"{type} travelled {parametar} km");

                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    if (type == nameof(Car))
                    {
                        car.Refueling(parametar);
                    }
                    else if (type == nameof(Truck))
                    {
                        truck.Refueling(parametar);
                    }
                }


            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");




        }

        private static Vehicle CreatVehicle()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = input[0];
            var fuelQuntity = double.Parse(input[1]);
            var fuelConsump = double.Parse(input[2]);

            Vehicle vehicle = null;
            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuntity, fuelConsump);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuntity, fuelConsump);
            }
            return vehicle;
        }
    }
}

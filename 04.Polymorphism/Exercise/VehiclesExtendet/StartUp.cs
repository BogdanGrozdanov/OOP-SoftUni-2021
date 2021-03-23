using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreatVehicle();
            Vehicle truck = CreatVehicle();
            Vehicle bus = CreatVehicle();

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
                        else if (type == nameof(Bus))
                        {
                            bus.Driving(parametar);
                        }
                        Console.WriteLine($"{type} travelled {parametar} km");

                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if (comand == "Refuel")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Refueling(parametar);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Refueling(parametar);
                        }
                        else if (type == nameof(Bus))
                        {
                            bus.Refueling(parametar);
                        }
                    }
                    catch (Exception ex)
                    when (ex is ArgumentException || ex is InvalidOperationException)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (comand == "DriveEmpty")
                {
                    try
                    {
                        if (type == nameof(Bus))
                        {
                            bus.DrivingEmpty(parametar);
                        }
                        Console.WriteLine($"{type} travelled {parametar} km");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }


            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");




        }

        private static Vehicle CreatVehicle()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = input[0];
            double fuelQuntity = double.Parse(input[1]);
            double fuelConsump = double.Parse(input[2]);
            double capacity = double.Parse(input[3]);

            Vehicle vehicle = null;
            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuntity, fuelConsump, capacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuntity, fuelConsump, capacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuntity, fuelConsump, capacity);
            }
            return vehicle;
        }
    }
}

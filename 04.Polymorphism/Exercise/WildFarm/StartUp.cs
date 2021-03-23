using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                var inputData = input.Split();
                Animal animal = CreatAnimal(inputData);
                animals.Add(animal);
                string[] foodParts = Console.ReadLine().Split();
                Food food = CreatFood(foodParts);
                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreatFood(string[] foodParts)
        {
            Food food = null;
            var type = foodParts[0];
            var quantity = int.Parse(foodParts[1]);
            if (type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            return food;
        }

        private static Animal CreatAnimal(string[] inputData)
        {
            Animal animal = null;
            var animalType = inputData[0];
            var name = inputData[1];
            var weight = double.Parse(inputData[2]);

            if (animalType == nameof(Hen))
            {
                var wingSize = double.Parse(inputData[3]);

                animal = new Hen(name, weight, wingSize);
                Console.WriteLine(animal.ProduceSound());
            }
            else if (animalType == nameof(Owl))
            {
                var wingSize = double.Parse(inputData[3]);

                animal = new Owl(name, weight, wingSize);
                Console.WriteLine(animal.ProduceSound());
            }
            else if (animalType == nameof(Mouse))
            {
                var livingRegion = inputData[3];

                animal = new Mouse(name, weight, livingRegion);
                Console.WriteLine(animal.ProduceSound());
            }
            else if (animalType == nameof(Dog))
            {
                var livingRegion = inputData[3];

                animal = new Dog(name, weight, livingRegion);
                Console.WriteLine(animal.ProduceSound());
            }
            else if (animalType == nameof(Cat))
            {
                var livingRegion = inputData[3];
                var breed = inputData[4];

                animal = new Cat(name, weight, livingRegion, breed);
                Console.WriteLine(animal.ProduceSound());
            }
            else if (animalType == nameof(Tiger))
            {
                var livingRegion = inputData[3];
                var breed = inputData[4];

                animal = new Tiger(name, weight, livingRegion, breed);
                Console.WriteLine(animal.ProduceSound());
            }
            return animal;
        }
    }
}

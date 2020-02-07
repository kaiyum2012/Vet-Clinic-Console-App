using System;
using System.Collections.Generic;

namespace Vet_Clinic_Console_App
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Console.WriteLine("Welcome to Vet Clinic");
            Console.WriteLine("-------------------------------");

            SetupAnimals(animals);
            DisplayAnimals(animals);

            Console.ReadLine();

        }

        private static void DisplayAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                animal.Display();
            }
        }

        private static void SetupAnimals(List<Animal> animals)
        {
            animals.Add(new Mammal("DOG", false));
            animals.Add(new Fish("Tuna", Fish.FISH_TYPE.FRESH_WATER));
            animals.Add(new Bird("Pegion", Bird.BIRD_TYPE.FARM));
        }
    }
}

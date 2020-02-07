using System;

namespace Vet_Clinic_Console_App
{
    class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Animal(string name = "")
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Animal is {0}", Name);
        }
        
    }
}

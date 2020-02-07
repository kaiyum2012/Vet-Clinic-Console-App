using System;
using System.Collections.Generic;
using System.Text;

namespace Vet_Clinic_Console_App
{
    class Bird : Animal
    {
        public enum BIRD_TYPE
        {
            WILD,
            FARM
        }

        private BIRD_TYPE birdType;

        public BIRD_TYPE BirdType { get => birdType; set => birdType = value; }

        public Bird(string name, BIRD_TYPE type)
        {
            Name = name;
            birdType = type;
        }

        public override void Display()
        {
            Console.WriteLine("{0} is {1} of type {2}",Name, this.GetType().Name ,BirdType);
        }
    }
}

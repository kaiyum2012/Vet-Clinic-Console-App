using System;
using System.Collections.Generic;
using System.Text;

namespace Vet_Clinic_Console_App
{
    class Mammal : Animal
    {
        private bool isPregnant;

        public bool IsPragnant { get => isPregnant; set => isPregnant = value; }

        public Mammal(string name, bool isPregnant)
        {
            Name = name;
            IsPragnant = isPregnant;
        }

        public override void Display()
        {
            if (isPregnant)
                Console.WriteLine("{0} is {1} and Pregnant", Name, this.GetType().Name.ToString());
            else
                Console.WriteLine("{0} is {1} and not Pregnant", Name, this.GetType().Name.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Vet_Clinic_Console_App
{
    class Fish : Animal
    {
        public enum FISH_TYPE
        {
            FRESH_WATER,
            SALT_WATER,
            SOMETHING
        }

        private FISH_TYPE fishType;
       
        public FISH_TYPE FishType
        {
            get => fishType;
            set => fishType = value;
        }
        public Fish(string name, FISH_TYPE fish)
        {
            Name = name;
            FishType = fish;
        }

        public string GetFishType()
        {
            string strFishType;
            switch (FishType)
            {
                case FISH_TYPE.FRESH_WATER:
                    strFishType = "Fresh Water";
                    break;
                case FISH_TYPE.SALT_WATER:
                    strFishType = "Salt Water";
                    break;
                default:
                    strFishType = "";
                    break;
            }

            return strFishType;
        }
        public override void Display()
        {
            Console.WriteLine("{0} is {1} and lives in {2}",Name, this.GetType().Name, GetFishType());
        }
    }
}

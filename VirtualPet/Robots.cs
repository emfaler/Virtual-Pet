using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robots
    {
        public string Name { get; set; }

        public string Species { get; set; }

        public int GasLevel { get; set; } = 50;

        public int Boredom { get; set; } = 60;

        public int OilLevel { get; set; } = 30;

        public void SetName(string name)

        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public int GetGas()
        {
            return GasLevel;
        }

        public int GetBoredom()
        {
            return Boredom;
        }

        public int GetOilLevel()
        {
            return OilLevel;
        }

        public void Gas()
        {
            GasLevel -= 45;

            if (GasLevel < 0)
            {
                GasLevel = 0;
            }
        }

        public void SeeMechanic()
        {
            OilLevel += 30;

            if (OilLevel > 150)
            {
                OilLevel = 150;
            }
        }

        public void Play()
        {
            OilLevel += 10;
            Boredom -= 20;
            OilLevel += 10;

            if (OilLevel > 100)
            {
                OilLevel = 100;
            }

            if (Boredom < 0)
            {
                Boredom = 0;
            }

            if (OilLevel > 100)
            {
                OilLevel = 100;
            }


        }

        public void Tick()
        {
            OilLevel += 5;
            Boredom += 5;
            OilLevel -= 5;

            if (OilLevel > 100)
            {
                OilLevel = 100;
            }

            if (Boredom > 100)
            {
                Boredom = 100;
            }

            if (OilLevel < 0)
            {
                OilLevel = 0;
            }



















        }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {
        public int Hunger { get; set; } = 50;

        public int Energy { get; set; } = 60;

        public int Health { get; set; } = 30;

        public int GetHunger()
        {
            return Hunger;
        }

        public int GetEnergy()
        {
            return Energy;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;

            if (Hunger < 0)
            {
                Hunger = 0;
            }
        }

        public void SeeDoctor()
        {
            Health += 30;

            if (Health > 100)
            {
                Health = 100;
            }
        }

        public virtual void Play()
        {
            Hunger += 10;
            Energy -= 20;
            Health += 10;
        }

        public virtual void Tick()
        {
            Hunger += 5;
            Energy += 5;
            Health -= 5;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {

        public virtual string Name { get; set; }

        public virtual string Species { get; set; }

        public int Boredom { get; set; } = 60;

        //Space

        public virtual void SetName(string name)

        {
            Name = name;
        }

        public virtual string GetName()
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
        
        public int GetBoredom()
        {
            return Boredom;
        }
public virtual void Play()
        {
            Boredom -= 20;
        }

        public virtual void Tick()
        {
            Boredom += 5;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {

        public virtual string Name { get; set; }

        public virtual string Species { get; set; }

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
        
    }
}



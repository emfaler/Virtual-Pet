using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetTests
    {
        public Pet testPet;

        public PetTests()
        {
            testPet = new Pet();
        }

        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testPet);
        }
        
        [Fact]
        public void Pet_Should_Have_Name()
        {
             testPet.Name = "Pet Name"; 
            
             Assert.Equal("Pet Name", testPet.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
             testPet.SetName("Fluffy");

             Assert.Equal("Fluffy", testPet.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
             testPet.SetName("Fido");

             string testPetName = testPet.GetName();

             Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
             testPet.Species = "Pet Species";
            
             Assert.Equal("Pet Species", testPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
             testPet.SetSpecies("Cat");

             Assert.Equal("Cat", testPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
             testPet.SetSpecies("Dog");

             string testPetSpecies = testPet.GetSpecies();

             Assert.Equal("Dog", testPetSpecies);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RobotTests
    {
        Robots robotPets; 
        
        public RobotTests()
        {
            robotPets = new Robots();
        }



        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(robotPets);
        }

        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Fact]
        public void Pet_Should_Have_Name()
        {
            robotPets.Name = "Pet Name";

            Assert.Equal("Pet Name", robotPets.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            robotPets.SetName("Fluffy");

            Assert.Equal("Fluffy", robotPets.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            robotPets.SetName("Fido");

            string testPetName = robotPets.GetName();

            Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            robotPets.Species = "Pet Species";

            Assert.Equal("Pet Species", robotPets.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            robotPets.SetSpecies("Robo Cat");

            Assert.Equal("Robo Cat", robotPets.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            robotPets.SetSpecies("Robo Dog");

            string robotPetsSpecies = robotPets.GetSpecies();

            Assert.Equal("Robo Dog", robotPetsSpecies);
        }

        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            robotPets.OilLevel = 100;

            Assert.Equal(100, robotPets.OilLevel);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = robotPets.GetGas();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Boredom()
        {
            robotPets.Boredom = 100;

            Assert.Equal(100, robotPets.Boredom);
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
            int testPetBoredom = robotPets.GetBoredom();

            Assert.Equal(60, testPetBoredom);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {
            robotPets.OilLevel = 100;

            Assert.Equal(100, robotPets.OilLevel);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int testPetHealth = robotPets.GetOilLevel();

            Assert.Equal(30, testPetHealth);
        }

        [Fact]
        public void _Should_Decrease_GasLevel_By_40()
        {
            robotPets.Gas();

            Assert.Equal(10, robotPets.GetGas());
        }

        [Fact]
        public void SeeMechanic_Should_Increase_Health_By_30()
        {
            robotPets.SeeMechanic();

            Assert.Equal(60, robotPets.GetOilLevel());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            robotPets.Play();

            Assert.Equal(60, robotPets.GetGas());
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            robotPets.Play();

            Assert.Equal(40, robotPets.GetBoredom());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            robotPets.Play();

            Assert.Equal(40, robotPets.GetOilLevel());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            robotPets.Tick();

            Assert.Equal(55, robotPets.GetGas());
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            robotPets.Tick();

            Assert.Equal(65, robotPets.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            robotPets.Tick();

            Assert.Equal(25, robotPets.GetOilLevel());
        }
    }
}

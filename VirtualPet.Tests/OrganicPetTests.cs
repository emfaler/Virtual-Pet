using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicTests
    {
        public OrganicPet organicPets;

        public OrganicTests()
        {
            organicPets = new OrganicPet();
        }

        [Fact]
        public void organicPets_Should_Have_Hunger()
        {
            organicPets.Hunger = 100;

            Assert.Equal(100, organicPets.Hunger);
        }

        [Fact]
        public void Hunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int organicPetsHunger = organicPets.GetHunger();

            Assert.Equal(50, organicPetsHunger);
        }

        [Fact]
        public void organicPets_Should_Have_Energy()
        {
            organicPets.Energy = 100;

            Assert.Equal(100, organicPets.Energy);
        }

        [Fact]
        public void GetEnergy_Should_Return_Initial_Energy_Level_Of_60()
        {
            int organicPetsEnergy = organicPets.GetEnergy();

            Assert.Equal(60, organicPetsEnergy);
        }

        [Fact]
        public void organicPets_Should_Have_Health()
        {
            organicPets.Health = 100;

            Assert.Equal(100, organicPets.Health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int organicPetsHealth = organicPets.GetHealth();

            Assert.Equal(30, organicPets.Health);
        }

        [Fact]
        public void Hunger_Should_Decrease_Hunger_By_40()
        {
            organicPets.Feed();

            Assert.Equal(10, organicPets.GetHunger());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            organicPets.SeeDoctor();

            Assert.Equal(60, organicPets.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            organicPets.Play();

            Assert.Equal(60, organicPets.GetHunger());
        }

        [Fact]
        public void Play_Should_Decrease_Energy_By_20()
        {
            organicPets.Play();

            Assert.Equal(40, organicPets.GetEnergy());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            organicPets.Play();

            Assert.Equal(40, organicPets.GetHealth());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_10()
        {
            organicPets.Tick();

            Assert.Equal(60, organicPets.GetHunger());
        }

        [Fact]
        public void Tick_Should_Increase_Energy_By_15()
        {
            organicPets.Tick();

            Assert.Equal(75, organicPets.GetEnergy());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            organicPets.Tick();

            Assert.Equal(25, organicPets.GetHealth());
        }
    }
}



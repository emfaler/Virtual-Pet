using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RobotTests
    {
        public RobotPet robotPets;

        public RobotTests()
        {
            robotPets = new RobotPet();
        }

        [Fact]
        public void Pet_Should_Have_GasLevel()
        {
            robotPets.GasLevel = 100;

            Assert.Equal(100, robotPets.GasLevel);
        }

        [Fact]
        public void GetGasLevel_Should_Return_Initial_GasLevel_Level_Of_50()
        {
            int testPetGasLevel = robotPets.GetGasLevel();

            Assert.Equal(50, testPetGasLevel);
        }

        [Fact]
        public void Pet_Should_Have_Charger()
        {
            robotPets.Charger = 100;

            Assert.Equal(100, robotPets.Charger);
        }

        [Fact]
        public void GetCharger_Should_Return_Initial_Charger_Level_Of_60()
        {
            int testPetCharger = robotPets.GetCharger();

            Assert.Equal(60, testPetCharger);
        }

        [Fact]
        public void Pet_Should_Have_OilLevel()
        {
            robotPets.OilLevel = 100;

            Assert.Equal(100, robotPets.OilLevel);
        }

        [Fact]
        public void GetOilLevel_Should_Return_Initial_OilLevel_Level_Of_30()
        {
            int testPetHealth = robotPets.GetOilLevel();

            Assert.Equal(30, robotPets.OilLevel);
        }

        [Fact]
        public void Gas_Should_Decrease_GasLevel_By_40()
        {
            robotPets.Gas();

            Assert.Equal(10, robotPets.GetGasLevel());
        }

        [Fact]
        public void SeeMechanic_Should_Increase_OilLevel_By_30()
        {
            robotPets.SeeMechanic();

            Assert.Equal(60, robotPets.GetOilLevel());
        }

        [Fact]
        public void Play_Should_Increase_GasLevel_By_10()
        {
            robotPets.Play();

            Assert.Equal(60, robotPets.GetGasLevel());
        }

        [Fact]
        public void Play_Should_Decrease_Charger_By_20()
        {
            robotPets.Play();

            Assert.Equal(40, robotPets.GetCharger());
        }

        [Fact]
        public void Play_Should_Increase_OilLevel_By_10()
        {
            robotPets.Play();

            Assert.Equal(40, robotPets.GetOilLevel());
        }

        [Fact]
        public void Tick_Should_Increase_GasLevel_By_10()
        {
            robotPets.Tick();

            Assert.Equal(60, robotPets.GetGasLevel());
        }

        [Fact]
        public void Tick_Should_Increase_Charger_By_15()
        {
            robotPets.Tick();

            Assert.Equal(75, robotPets.GetCharger());
        }

        [Fact]
        public void Tick_Should_Decrease_OilLevel_By_5()
        {
            robotPets.Tick();

            Assert.Equal(25, robotPets.GetOilLevel());
        }
    }
}



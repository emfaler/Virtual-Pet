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
            testPet.GasLevel = 100;

            Assert.Equal(100, testPet.GasLevel);
        }

        [Fact]
        public void GetGasLevel_Should_Return_Initial_GasLevel_Level_Of_50()
        {
            int testPetGasLevel = testPet.GetGasLevel();

            Assert.Equal(50, testPetGasLevel);
        }

        [Fact]
        public void Pet_Should_Have_Charger()
        {
            testPet.Charger = 100;

            Assert.Equal(100, testPet.Charger);
        }

        [Fact]
        public void GetCharger_Should_Return_Initial_Charger_Level_Of_60()
        {
            int testPetCharger = testPet.GetCharger();

            Assert.Equal(60, testPetCharger);
        }

        [Fact]
        public void Pet_Should_Have_OilLevel()
        {
            testPet.OilLevel = 100;

            Assert.Equal(100, testPet.OilLevel);
        }

        [Fact]
        public void GetOilLevel_Should_Return_Initial_OilLevel_Level_Of_30()
        {
            int testPetHealth = testPet.GetOilLevel();

            Assert.Equal(30, testPetOilLevel);
        }

        [Fact]
        public void Gas_Should_Decrease_GasLevel_By_40()
        {
            testPet.Gas();

            Assert.Equal(10, testPet.GetGasLevel());
        }

        [Fact]
        public void SeeMechanic_Should_Increase_OilLevel_By_30()
        {
            testPet.SeeMechanic();

            Assert.Equal(60, testPet.GetOilLevel());
        }

        [Fact]
        public void Play_Should_Increase_GasLevel_By_10()
        {
            testPet.Play();

            Assert.Equal(60, testPet.GetGasLevel());
        }

        [Fact]
        public void Play_Should_Decrease_Charger_By_20()
        {
            testPet.Play();

            Assert.Equal(40, testPet.GetCharger());
        }

        [Fact]
        public void Play_Should_Increase_OilLevel_By_10()
        {
            testPet.Play();

            Assert.Equal(40, testPet.GetOilLevel());
        }

        [Fact]
        public void Tick_Should_Increase_GasLevel_By_5()
        {
            testPet.Tick();

            Assert.Equal(55, testPet.GetGasLevel());
        }

        [Fact]
        public void Tick_Should_Increase_Charger_By_5()
        {
            testPet.Tick();

            Assert.Equal(65, testPet.GetCharger());
        }

        [Fact]
        public void Tick_Should_Decrease_OilLevel_By_5()
        {
            testPet.Tick();

            Assert.Equal(25, testPet.GetOilLevel());
        }
    }
}











    }
}

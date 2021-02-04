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
        public void
            public void SetName_Should_Assign_Robot_Pet_Name_Property()
        {
            testPet.SetName("Bolt");

            Assert.Equal("Bolt", testPet.Name);
        }






    }
}

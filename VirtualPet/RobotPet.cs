using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RobotPet : Pet
    {

        public override string Name { get; set; }

        public override string Species { get; set; }

        public int GasLevel { get; set; } = 50;   //hunger

        public int Charger { get; set; } = 60;  //Energy

        public int OilLevel { get; set; } = 30;   //health

        public override void SetName(string name)

        {
            Name = name;
        }

        public override string GetName()
        {
            return Name;
        }

        public int GetGasLevel()
        {
            return GasLevel;
        }

        public int GetCharger()
        {
            return Charger;
        }

        public int GetOilLevel()
        {
            return OilLevel;
        }

        public void Gas()
        {
            GasLevel -= 40;

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

        public override void Play()
        {
            GasLevel += 10;
            Charger -= 20;
            OilLevel += 10;

            if (GasLevel > 150)
            {
                GasLevel = 150;
            }

            if (Charger < 0)
            {
                Charger = 0;
            }

            if (OilLevel > 150)
            {
                OilLevel = 150;
            }


        }

        public override void Tick()
        {
            GasLevel += 10;
            Charger += 15;
            OilLevel -= 5;

            if (GasLevel > 150)
            {
                GasLevel = 150;
            }

            if (Charger > 150)
            {
                Charger = 150;
            }

            if (OilLevel < 0)
            {
                OilLevel = 0;
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RobotPet : Pet
    {
        public int GasLevel { get; set; } = 50;   //hunger

        public int Charger { get; set; } = 60;  //Energy

        public int OilLevel { get; set; } = 30;   //health

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

            if (OilLevel > 100)
            {
                OilLevel = 100;
            }
        }

        public void Play()
        {
            GasLevel += 10;
            Charger -= 20;
            OilLevel += 10;

            if (GasLevel > 100)
            {
                GasLevel = 100;
            }

            if (Charger < 0)
            {
                Charger = 0;
            }

            if (OilLevel > 100)
            {
                OilLevel = 100;
            }


        }

        public void Tick()
        {
            GasLevel += 5;
            Charger += 5;
            OilLevel -= 5;

            if (GasLevel > 100)
            {
                GasLevel = 100;
            }

            if (Charger > 100)
            {
                Charger = 100;
            }

            if (OilLevel < 0)
            {
                OilLevel = 0;
            }
        }
    }
}

    //public void Feed()
    //{
    //    Charge -= 45;

    //    if (Hunger < 0)
    //    {
    //        Hunger = 0;
    //    }
    //}

    //public void Play()
    //{
    //    Hunger += 10;
    //    Boredom -= 20;
    //    Health += 10;
    //}








}

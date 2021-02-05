using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {

            Random random = new Random(); 

            //organic pet
            int startHunger = random.Next(50, 70);
            int startEnergy = random.Next(50, 60);
            int startHealth = random.Next(30, 50);

            //robot pet
            int startGasLevel = random.Next(10, 50);
            int startOilLevel = random.Next(30, 60);
            int startCharger = random.Next(5, 20);

            Pet pet = new Pet();

            OrganicPet organicPet = new OrganicPet();
            organicPet.Health = startHealth;
            organicPet.Hunger = startHunger;
            organicPet.Energy = startEnergy;

            RobotPet robotPet = new RobotPet();
            robotPet.GasLevel = startGasLevel;
            robotPet.OilLevel = startOilLevel;
            robotPet.Charger = startCharger;


            bool VirtualPet = true;
            
            do
            {
                organicPet.Tick();
                Console.WriteLine("Welcome to Pixel Pet!\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Pick your pet species");
                Console.WriteLine("2. Name your pet!");
                Console.WriteLine("3. Feed your pet");
                Console.WriteLine("4. Play with your pet");
                Console.WriteLine("5. Take pet to the doctor");
                Console.WriteLine("6. Check the status of you pet");
                Console.WriteLine("7. Exit game.");

                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("What species of animal would you like?");                
                        string speciesOfPet = Console.ReadLine();
                        pet.SetSpecies(speciesOfPet);
                        Console.WriteLine("\n");
                        Console.WriteLine($"The species of your animal is: {pet.Species}\n");
                        break;
                    case "2":
                        Console.WriteLine("What would you like to name your pet?");                
                        string nameOfPet = Console.ReadLine();
                        pet.SetName(nameOfPet);
                        Console.WriteLine("\n");
                        Console.WriteLine($"Congratulations! \nThe name of your pet is: {pet.Name}\n");
                        break;
                    case "3":
                        organicPet.Feed();
                        Console.WriteLine($"Would you like to feed {pet.Name}?");
                        Console.WriteLine($"{pet.Name} hunger levels are:{organicPet.Hunger}\n");
                        break;
                    case "4":
                        organicPet.Play();
                        Console.WriteLine($"Would you like to play with {pet.Name}?");
                        Console.WriteLine($"{pet.Name} boredom levels are:{organicPet.Energy}\n");
                        break;
                    case "5":
                        organicPet.SeeDoctor();
                        Console.WriteLine($"Would you like to take care of {pet.Name}?");
                        Console.WriteLine($"{pet.Name} Health levels are:{organicPet.Health}\n");
                        break;
                    case "6":
                        Console.WriteLine("Check overall status of pet:\n");
                        Console.WriteLine($"The name of your pet is {pet.Name} with a species type of {pet.Species}");                     
                        Console.WriteLine($"Hunger: {organicPet.Hunger}");
                        Console.WriteLine($"Boredom: {organicPet.Energy}");
                        Console.WriteLine($"Health: {organicPet.Health}");
                        break;
                    case "7":
                        VirtualPet = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Return to main menu\n");
                Console.ReadKey();
                Console.Clear();

            } while (VirtualPet);
        }
    }
}

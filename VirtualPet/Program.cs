using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int startHunger = random.Next(50);
            int startThirst = random.Next(60);
            int startEnergy = random.Next(70);

            Pet pet = new Pet();
            pet.Hunger = startHunger;
            pet.Thirst = startThirst;               // create methods for thirst  set thrist to 60 inital
            pet.Energy = startEnergy;               // create methods for energy  set energy to 70 inital 


            //List<Pet> animalType = new List<Pet>();
            //animalType.Add("Dog");
            //animalType.Add("Cat");
            //animalType.Add("Bird");

            //for (int i = 0; i < animalType.Count; i++)
            //{
            //    int menuNumber = i + 1;
            //    Console.WriteLine("\tPress {0} for {1}.", menuNumber, animalType[i]);
            //}


            bool VirtualPet = true;

            while (VirtualPet)
            {
                Console.WriteLine("Welcome to Pixel Pet!\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Pick your pet species");
                Console.WriteLine("2. Name your pet!");
                Console.WriteLine("3. Feed your pet?");
                Console.WriteLine("4. Play with your pet?");
                Console.WriteLine("5. Check your pets health!");

                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (userChoice)
                {
                    case "1": 
                       Console.WriteLine("What species of animal would you like?");                // Species is done!
                        string speciesOfPet = Console.ReadLine();
                        pet.SetSpecies(speciesOfPet);
                        Console.WriteLine($"The species of your animal is: {pet.Species}");
                        break;
                    case "2":
                        Console.WriteLine("What would you like to name your pet?");                         // Pet name is done!
                        string nameOfPet = Console.ReadLine();
                        pet.SetName(nameOfPet);
                        Console.WriteLine($"Congratulations! \nThe name of your pet is: {pet.Name}");
                        break;
                    case "3":
                        Console.WriteLine("What would you like to feed your pet?");                        // Need to create a method to feed animal with string
                        int petFood = Convert.ToInt32(Console.ReadLine());
                        // pet.(petFood);
                        break;
                    case "4":
                        Console.WriteLine("What activity would you like to do with your pet?");            // Need to create method for activity with string 
                        string petGame = Console.ReadLine();
                        break;
                    case "5":
                        pet.GetHealth();
                        Console.WriteLine($"Pet's health: {pet.Health}");
                        break;
                    case "6":
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
                
                Console.WriteLine("\nReturn to Main Menu.");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}

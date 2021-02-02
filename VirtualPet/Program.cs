using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            bool VirtualPet = true;
            
            while (VirtualPet)
            {
                Console.WriteLine("Welcome to Pixel Pet!\n");
                Console.WriteLine("What do you want to do first?");
                Console.WriteLine("1. Pick your pet species");
                Console.WriteLine("2. Name your pet!");
                Console.WriteLine("3. Feed your pet?");
                Console.WriteLine("4. Play with your pet?");
                Console.WriteLine("5. Check your pets health!");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1": 
                       Console.WriteLine("What species of animal would you like your pet?");                // Species is done!
                        string speciesOfPet = Console.ReadLine();
                        pet.SetSpecies(speciesOfPet);
                        Console.WriteLine($"The species of your animal is: {pet.Species}");
                        break;
                    case "2":
                        Console.WriteLine("What would you like to name your pet?");                         // Pet name is done!
                        string nameOfPet = Console.ReadLine();
                        pet.SetName(nameOfPet);
                        Console.WriteLine($"Congratulations! The name of your pet is: {pet.Name}");
                        Console.WriteLine(pet.Name + " is a " + pet.Species);
                        break;
                    case "3":
                        Console.WriteLine("Would you like to feed your pet?");                             // Need to create a method to feed animal with string
                        string petFood = Console.ReadLine();
                      //  pet.(petFood);
                        break;
                    case "4":
                        Console.WriteLine("What activity would you like to do with your pet?");            // Need to create method for activity with string 
                        string petGame = Console.ReadLine();
                        break;
                    case "5":
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

﻿using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int startHunger = random.Next(50);
            int startEnergy = random.Next(70);
            int startHealth = random.Next(30);

            Pet pet = new Pet();
            pet.Hunger = startHunger;           // create methods for thirst  set thrist to 60 inital
            pet.Boredom = startEnergy;
            pet.Health = startHealth;              // create methods for energy  set energy to 70 inital 

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

                        Console.WriteLine("\nReturn to Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("What would you like to name your pet?");                         // Pet name is done!
                        string nameOfPet = Console.ReadLine();
                        pet.SetName(nameOfPet);
                        Console.WriteLine($"Congratulations! \nThe name of your pet is: {pet.Name}");

                        Console.WriteLine("\nReturn to Main Menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("What would you like to feed your pet?");
                        Console.WriteLine($"{pet.Hunger }");
                        Console.WriteLine("\nReturn to Main Menu.");
                        Console.ReadKey();
                        Console.Clear();                                   // Need to create a method to feed animal with string

                        // pet.(petFood);
                        break;
                    case "4":
                        Console.WriteLine("What activity would you like to do with your pet?");
                        Console.WriteLine($"{pet.Boredom}");
                        Console.WriteLine("\nReturn to Main Menu.");                                        //change the place
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        pet.GetHealth();
                        Console.WriteLine("Pet's health:");
                        Console.WriteLine($"{pet.Health}");
                        Console.WriteLine("\nReturn to Main Menu.");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "6":
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

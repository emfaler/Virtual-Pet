using System;

namespace VirtualPet
{
    class Program //this is a change
    {
        static void Main(string[] args)
        {
            bool VirtualPet = true;
            while (VirtualPet)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Pixel Pet!\n");
                Console.WriteLine("What do you want to do first?");
                Console.WriteLine("1. Pick your pet species");
                Console.WriteLine("2. Name your pet!");
                Console.WriteLine("3. Feed your pet?");
                Console.WriteLine("4. Play with your pet?");
                Console.WriteLine("5. Check your pets health!");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1": 
                       Console.WriteLine("What species of animal would you like your pet?");
                        break;
                    case "2":
                        Console.WriteLine("What would you like to name your pet.");
                        break;
                    case "3":
                        Console.WriteLine("Would you like to feed your pet?");
                        break;
                    case "4":
                        Console.WriteLine("Would you like to play with your pet?");
                        break;
                    case "5":
                        Console.WriteLine("Check you pet's health.");
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

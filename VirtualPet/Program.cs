using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool VirtualPet = true;
            while (VirtualPet)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Pixel Pet!\n");
                Console.WriteLine("What do you want do first?");
                Console.WriteLine("Name your pet!");
                Console.WriteLine("Pick your pet species");
                Console.WriteLine("1. Feed your pet?");
                Console.WriteLine("2. Play with your pet?");
                Console.WriteLine("3. Check your pets health!");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        ();
                        break;
                    case "2":
                        ();
                        break;
                    case "3":
                        ();
                        break;
                        break;
                    case "q":
                        VirtualPet = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

using System;

namespace Proj5_1_Dice_Roller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dice Roller");

            String choice = "y";
                while (choice.Equals("y")) { }
            Console.Write("Roll the dice? (y/n): ")
                Random rnd = new Random;
                int Die1 = 
                int Die2 = 

                Console.WriteLine("Total: " + (Die1 + Die2));
            Console.WriteLine("Continue (y/n)? ");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Bye");

        }
    }
}

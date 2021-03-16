using System;

namespace Proj5_1_Dice_Roller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dice Roller");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Roll the dice? (y/n): ");
                choice = Console.ReadLine();
                Random rnd = new Random();
                int Die1 = rnd.Next(1, 7);
                int Die2 = rnd.Next(1, 7);

                String result = null;


                Console.WriteLine("Die 1: " + Die1);
                Console.WriteLine("Die 2: " + Die2);
                Console.WriteLine("Total: " + (Die1 + Die2));
                if (Die1 + Die2 == 2) {
                    result += "Snake Eyes!\n";
                } else if (Die1 + Die2 == 7) {
                    result += "Craps!\n";
                } else if (Die1 + Die2 == 12) {
                    result += "Box Cars!\n";
                }
                Console.WriteLine(result);
                Console.WriteLine("Roll Again? (y/n) ");
                choice = Console.ReadLine();
            }
        Console.WriteLine("Bye");
        }

        }
    }


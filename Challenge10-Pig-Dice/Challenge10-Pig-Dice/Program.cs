using System;

namespace Challenge10_Pig_Dice {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Pig Dice!");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("# of times to play?: ");
                choice = Console.ReadLine();
                Console.WriteLine("Here we go....");
                Random rnd = new Random();
                int Die1 = rnd.Next(1, 7);

                

                Console.WriteLine(Die1);

                Console.WriteLine("Roll Again? (y/n) ");
                choice = Console.ReadLine();

            }








                Console.WriteLine("Bye");
        }
    }
}

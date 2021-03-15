using System;

namespace Proj4_1_Table_Of_Powers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Squares and Cubes table");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter an integer: ");
                int nbr = Int32.Parse(Console.ReadLine());
                int nbr2 = nbr * nbr;
                int nbr3 = nbr * nbr * nbr;

                Console.WriteLine("Number   Squared   Cubed");
                Console.WriteLine("======   =======   =====");
                Console.WriteLine(+nbr + "       " + nbr2 + "      " + nbr3);
                Console.WriteLine("Continue (y/n)? ");
                choice = Console.ReadLine();

            }


















            Console.WriteLine("Bye");
        }
    }
}

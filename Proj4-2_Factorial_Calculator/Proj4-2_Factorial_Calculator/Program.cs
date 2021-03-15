using System;

namespace Proj4_2_Factorial_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial Calculator");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter an integer that's greater than 0 and less than 10: ");
                int nbr = Int32.Parse(Console.ReadLine());

                if (nbr < 11) {
                    for (int i = nbr; i > 0; i--) {
                        nbr *= i;
                    }
                    Console.WriteLine("Factorial of "+nbr+"! = {1}\n", nbr, nbr);
                    nbr--;
            } else { 
                    Console.WriteLine("Invalid integer, try again!");
            }
                Console.Write("Continue? (y/n): ");
                    choice = Console.ReadLine();
            }











            Console.WriteLine("Bye");
        }
    }
}

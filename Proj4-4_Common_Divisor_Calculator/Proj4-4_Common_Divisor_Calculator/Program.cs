using System;

namespace Proj4_4_Common_Divisor_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Greatest Common Divisor Finder");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter first number: ");
                int nbr1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int nbr2 = Int32.Parse(Console.ReadLine());
                 static ulong GCD(ulong nbr1, ulong nbr2) {
                    while (nbr1 != 0 && nbr2 != 0) {
                        if (nbr1 > nbr2)
                            nbr1 %= nbr2;
                        else
                            nbr2 %= nbr1;
                    }

                    return nbr1 | nbr2;
                }



                Console.Write("Continue? (y/n): ");
            choice = Console.ReadLine();

        }




            Console.WriteLine("Bye");
        }
    }
}

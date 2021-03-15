using System;

namespace Proj2_3_Rectangle_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter length: ");
                double length = Int32.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = Int32.Parse(Console.ReadLine());

                Console.WriteLine(length * width);
            Console.WriteLine("Continue? (y/n): ");
            choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");
        }
    }
}

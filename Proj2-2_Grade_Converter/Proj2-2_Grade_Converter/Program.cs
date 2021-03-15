using System;

namespace Proj2_2_Grade_Converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter");

            String choice = "y";
            while (choice.Equals("y")) {
            Console.Write("Enter numerical grade: ");
                int grade = Int32.Parse(Console.ReadLine());
                if (grade >= 87) {
                    Console.WriteLine("Letter grade: A");
                } else if (grade >= 77) {
                    Console.WriteLine("Letter grade: B");
                } else if (grade >= 67) {
                    Console.WriteLine("Letter grade: C");
                } else if (grade >= 57) {
                    Console.WriteLine("Letter grade: D");
                } else if (grade >= 0) {
                    Console.WriteLine("Letter grade: F");
                }
                Console.WriteLine("Continue? (y/n): ");
                    choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");

        }
    }
}

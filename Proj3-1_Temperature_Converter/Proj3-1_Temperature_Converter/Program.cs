using System;

namespace Proj3_1_Temperature_Converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Temperature Converter");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter degrees in Fahrenheit: ");
                double temp1 = Convert.ToDouble(Console.ReadLine());
                double temp2 = ((temp1 - 32) * 5 / 9);
                Console.WriteLine("Degress in Celsius " + (Math.Round(temp2, 1)));
            Console.WriteLine("Continue? (y/n): ");
            choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");
        }
    }
}

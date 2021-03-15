﻿using System;

namespace MathApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Math App");
            Console.WriteLine("Random #, dice roll...");
            String choice = "y";
                Random r = new Random();
            while (choice == "y") {
                int die = r.Next(1, 7);
                Console.WriteLine(die);
                Console.WriteLine("Again?");
                choice = Console.ReadLine();
            }
            //random number between 20 and 50
            int rand1 = r.Next(20, 51);
            Console.WriteLine(rand1);

            Console.WriteLine("round some numbers");
            double d1 = 57.123456789;
            Console.WriteLine(d1);
            //format to 2 decimal places
            Console.WriteLine(Math.Round(d1, 2));
            //format to 5 decimal places
            Console.WriteLine(Math.Round(d1, 5));
            //format to 6 decimal places
            Console.WriteLine(Math.Round(d1, 6));

            Console.WriteLine("format a currency:");
            double price = 59.78;
            Console.WriteLine(price.ToString("c"));
            Console.WriteLine("format a percentage - 2 decimal places");
            double percent = 3.7897543;
            Console.WriteLine(percent.ToString("f"));
            Console.WriteLine("format a percentage - 3 decimal places");
            Console.WriteLine(percent.ToString("f3"));




            Console.WriteLine("Bye");
        }
    }
}

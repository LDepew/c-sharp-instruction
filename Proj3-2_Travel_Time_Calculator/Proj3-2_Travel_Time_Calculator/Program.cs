using System;

namespace Proj3_2_Travel_Time_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Travel Time Calculator");

            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter miles per hour: ");
            double mph = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Estimated travel time");
            Console.WriteLine("---------------------");

            double time = Convert.ToDouble(miles / mph);
            Console.WriteLine("Time: " + time);
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");


        }
    }
}

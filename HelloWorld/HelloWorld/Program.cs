using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            int n1 = 6;
            int n2 = 7;
            
            Console.WriteLine(n1 + n2);

            Console.Write("Enter a whole number: ");
                int n3 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name: ");
            String lName = Console.ReadLine();
            String fullName = fName + lName;
            Console.WriteLine(fullName);

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter color name: (r/g/b) ");
                String color = Console.ReadLine();
                if (color == "r") {
                    Console.WriteLine("Red was picked!");
                } else if (color == "g") {
                    Console.WriteLine("Green was picked!");
                } else if (color == "b") {
                    Console.WriteLine("Blue was picked!");
                } 
                Console.WriteLine("Continue (y/n)? ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");
        }
    }
}

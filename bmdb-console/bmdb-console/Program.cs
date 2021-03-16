using System;

namespace bmdb_console {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the bmdb Console");

            String choice = "y";
            while (choice.Equals("y")) {
                int id = MyConsole.getInt("ID: ");
                String title = MyConsole.getRequiredString("Title: ");
                String rating = MyConsole.getRequiredString("Rating: ");
                int year = MyConsole.getInt("Year: ");
                String director = MyConsole.getRequiredString("Director: ");
            Console.Write("Enter movie title: ");
            Movie m1 = new Movie(id, title, rating, year, director);

                Console.WriteLine("Continue (y/n)? ");
                choice = Console.ReadLine();

                Console.WriteLine(m1);










            Console.WriteLine("Bye");
        }
    }
}

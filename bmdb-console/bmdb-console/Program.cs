using System;

namespace bmdb_console {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the bmdb Console");

            Console.Write("Enter movie ID: ");
            int id = Int32.Parse(Console.ReadLine());
            Console.Write("Enter movie title: ");
            String title = Console.ReadLine();
            Console.Write("Enter movie rating: ");
            String rating = Console.ReadLine();
            Console.Write("Enter movie year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter movie director: ");
            String director = Console.ReadLine();
            Movie m1 = new Movie(id, title, rating, year, director);


            Console.WriteLine(m1);










            Console.WriteLine("Bye");
        }
    }
}

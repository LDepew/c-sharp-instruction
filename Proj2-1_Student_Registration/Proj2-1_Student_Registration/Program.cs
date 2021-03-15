using System;

namespace Proj2_1_Student_Registration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter first name: ");
            String fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            String lname = Console.ReadLine();
            Console.Write("Enter year of birth: ");
                int b1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Welcome " + fname + " " + lname + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + fname + "*" + b1);

        }
    }
}

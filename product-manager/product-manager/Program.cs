using System;

namespace product_manager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager!!");

            Console.Write("Enter product code: ");
            String code = Console.ReadLine();
            Console.Write("Enter description code: ");
            String desc = Console.ReadLine();
            Console.Write("Enter product price: ");
            String priceStr = Console.ReadLine();
            double price = Convert.ToDouble(priceStr);
            Product p1 = new Product(code, desc, price);
            

            //Console.WriteLine("Product entered: " + code + ", " + desc + ", " + //price);
            //string interpolation
            //Console.WriteLine($"Product entered: { code}  ,   { desc}  ,   { price} ");
            Console.WriteLine(p1);






            Console.WriteLine("Bye");
        }
    }
}

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Your Name is: {0}", name);

            Console.WriteLine("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: {0}", age);

            Console.WriteLine("Enter adouble Number: ");
            var ratio = double.Parse(Console.ReadLine());
            Console.WriteLine("Your number was: {0}", ratio);

            Console.WriteLine("Can you write code in c#?");
            var canCodde = bool.Parse(Console.ReadLine());
            Console.WriteLine("Can you code?: {0}", canCodde);
        }
    }
}

using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            Console.WriteLine(b);
            Console.WriteLine(!b);
            if(!b)
            {
                Console.WriteLine("The bool value was set to " +
                    "false");
            
            }
            int x;
            bool greaterThanHundred = int.Parse(Console.ReadLine()) > 100;
     
            if (greaterThanHundred)
            {
                Console.WriteLine("You gave a number greater than hundred");
            }
        }

    }
}

using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x !=  10)
            {

                Console.WriteLine("No ten here");
            }
            else
            {
                Console.WriteLine("You typed ten");
            }

            int y = int.Parse(Console.ReadLine());
            if(y > 0)
            {
                Console.WriteLine("We Have a positive number");
            }
            else if ( y < 0)
            {
                Console.WriteLine("Negative i hope is no your bump round");
            }
            else
            {
                Console.WriteLine("FrOM ZERO TO HER00");
            }
        }
    }
}

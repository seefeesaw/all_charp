using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Whats up? vWhat is yopur favourite number?");
            var favNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Your Fav nUmber is: {0}",favNum);

            var doubleOfFav = favNum * 2;
            var halfOfFav = favNum / 2;

            Console.WriteLine("Double of your fav number is:{0}",doubleOfFav);
            Console.WriteLine("Halve of your fav number is:{0}", halfOfFav);

              //Incrementation of a number 

            var counter = 0;
            Console.WriteLine("The state of counter is: {0}", counter);
            counter = counter + 1;
            Console.WriteLine("The state of counter is: {0}", counter);
            counter += 100;
            Console.WriteLine("The state of counter is: {0}", counter);

            //Decrement of a number
            Console.WriteLine("The state of counter is: {0}", counter);
            counter = counter - 1;
            Console.WriteLine("The state of counter is: {0}", counter);
            counter -= 10;
            Console.WriteLine("The state of counter is: {0}", counter);

            //Doubling Operations

            counter *= 3;
            Console.WriteLine("Value of Counter is: {0}", counter);
            counter /= 2;
            Console.WriteLine("Value of counter is: {0}", counter);
            counter %= 2;
            Console.WriteLine("Value of counter is: {0}", counter);

            int r_1 = 10 % 2;
            Console.WriteLine("Remainder division");
            Console.WriteLine("10 % 2 = {0}", r_1);

            int r_2 = 33 % 5;
            Console.WriteLine("Remainder division");
            Console.WriteLine("33%2 = {0}", r_2);
        }
    }
}

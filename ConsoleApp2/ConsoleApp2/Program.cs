using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intergers
            var age = 20;
            Console.WriteLine(age);
            uint abel = 30;
            Console.WriteLine("Iam writing code for fun!!!");
            Console.WriteLine(abel);

            Console.WriteLine("Min value of int is {0}", int.MinValue);

            Console.WriteLine("Max value of uint is {0}", uint.MaxValue);
            Console.WriteLine("Min value of uint is {0}", uint.MinValue);

            var float_number = 2.56f;
            var double_number = 146.555;
            var decimal_number = 7000.888M;

            Console.WriteLine("Max value of uint is {0}", float_number);
            Console.WriteLine("Min value of uint is {0}", double_number);
            Console.WriteLine("Min value of uint is {0}", decimal_number);
            Console.WriteLine("Min value of uint is {0}",float.NaN);

            Console.WriteLine("Max value of uint is {0}", double.MaxValue);
            Console.WriteLine("Min value of uint is {0}", double.MinValue);

            Console.WriteLine("Max value of uint is {0}", decimal.MaxValue);
            Console.WriteLine("Min value of uint is {0}", decimal.MinValue);

            //Logical data types

            bool  logical_true = true;
            bool  logical_false = false;

            Console.WriteLine("Max value of uint is {0}", logical_true);
            Console.WriteLine("Min value of uint is {0}", logical_false);
            Console.WriteLine(bool.Parse("true"));

            //text

            char c = 'c';
            char one = '1';
            char symbol = '?';
            Console.WriteLine(c);
            Console.WriteLine(one);
            Console.WriteLine(symbol);

            //string
            string str = "seefeesaw";
            Console.WriteLine(str);


        }
    }
}

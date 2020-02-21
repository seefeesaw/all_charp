using System;
using PATA = ProjectA.TeamA;
using PATB =  ProjectA.TeamB;


namespace namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //namespaces help you organise code
            //using fully qualified names helps
            //you see where the namespace is coming from
            Console.WriteLine("Hello");
            PATA.ClassA.Print();
            PATB.ClassA.Print();

        }
    }
}

using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 1, 2, 3, 4, 5 };

            var listStack = new ListStack("liststack_1", values);
            var listStacker = new ListStacker(listStack);
            listStacker.Run();

            var hashSetStack = new HashSetStack("hashsetstack_1");
            var hashSetStacker = new HashSetStacker(hashSetStack);
            hashSetStacker.Run();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}

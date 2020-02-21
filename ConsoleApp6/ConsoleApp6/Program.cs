using System;

namespace ConsoleApp6
{
    class Program
    {
        enum Quality
        {
            QHD,
            great,
            okay,
            low
        }
        static void Main(string[] args)
        {
            Quality myQuality = Quality.QHD;

            switch (myQuality)
            {
                case Quality.great:
                    Console.WriteLine("qualityb was great");
                    break;
                case Quality.okay:
                    Console.WriteLine("qualityb was okay");
                    break;
                case Quality.low:
                    Console.WriteLine("qualityb was low");
                    break;
                default:
                    Console.WriteLine("Unrecognized Quality");
                    break;
            }
        }
    }
}

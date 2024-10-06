using System;
namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lön för arbetare 1");
            int arb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för arbetare 2");
            int arb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för arbetare 3");
            int arb3 = int.Parse(Console.ReadLine());
            int sum = (arb1 + arb2 + arb3) / 3;
            Console.WriteLine(sum);
        }
    }
}

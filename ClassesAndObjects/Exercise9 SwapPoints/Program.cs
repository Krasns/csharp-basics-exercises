using System;

namespace Exercise9_SwapPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new SwapPoints(3, 6);
            var p2 = new SwapPoints(12, -6);

            p1.PointSwap(p1, p2);

            Console.WriteLine($"{p1.X},{p1.Y}");
            Console.WriteLine($"{p2.X},{p2.Y}");
        }
    }
}

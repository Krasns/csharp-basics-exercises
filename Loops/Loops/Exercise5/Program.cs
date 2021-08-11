using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter second  word:");
            string second = Console.ReadLine();

            Console.Write(first);
            for (int i = 0; i < 30 - (first.Length + second.Length); i++)
            {
                Console.Write(".");
            }
            Console.Write(second);
        }
    }
}

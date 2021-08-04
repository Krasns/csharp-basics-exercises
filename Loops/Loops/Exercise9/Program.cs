using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int sum = 0;

            while (number != sum)
            {
                int first = rand.Next(1, 7);
                int second = rand.Next(1, 7);
                Console.WriteLine($"{first} and {second} = {sum = first + second}");
            }
            Console.ReadKey();
        }
    }
}
